const repository = "MagnusHLund/lego-game-cheat-codes-inputter";
const releasesUrl = `https://github.com/${repository}/releases`;
const latestReleaseApiUrl = `https://api.github.com/repos/${repository}/releases/latest`;

const targets = [
  {
    id: "win-x64",
    label: "Windows",
    detail: "64-bit",
    fileName: "lego-game-cheat-codes-inputter-win-x64.zip",
  },
  {
    id: "linux-x64",
    label: "Linux",
    detail: "x64",
    fileName: "lego-game-cheat-codes-inputter-linux-x64.tar.gz",
  },
  {
    id: "linux-arm64",
    label: "Linux",
    detail: "ARM64",
    fileName: "lego-game-cheat-codes-inputter-linux-arm64.tar.gz",
  },
];

const primaryDownload = document.querySelector("#primary-download");
const secondaryDownload = document.querySelector("#secondary-download");
const downloadLabel = document.querySelector("#download-label");
const downloadDetail = document.querySelector("#download-detail");
const otherDownloads = document.querySelector("#other-downloads");
const otherDownloadsToggle = document.querySelector("#other-downloads-toggle");

function formatBytes(bytes) {
  if (!Number.isFinite(bytes) || bytes <= 0) {
    return "";
  }

  const units = ["B", "KB", "MB", "GB"];
  const unitIndex = Math.min(Math.floor(Math.log(bytes) / Math.log(1024)), units.length - 1);
  const value = bytes / 1024 ** unitIndex;
  return `${value.toFixed(value >= 10 || unitIndex === 0 ? 0 : 1)} ${units[unitIndex]}`;
}

function getPlatform() {
  const platform = (navigator.userAgentData?.platform || navigator.platform || "").toLowerCase();
  const userAgent = navigator.userAgent.toLowerCase();

  if (platform.includes("win") || userAgent.includes("windows")) {
    return "windows";
  }

  if (platform.includes("linux") || userAgent.includes("linux")) {
    return "linux";
  }

  if (platform.includes("mac") || userAgent.includes("macintosh")) {
    return "macos";
  }

  return "unknown";
}

async function getArchitecture() {
  if (navigator.userAgentData?.getHighEntropyValues) {
    const values = await navigator.userAgentData.getHighEntropyValues(["architecture", "bitness"]);
    if (values.architecture === "arm" && values.bitness === "64") {
      return "arm64";
    }
  }

  return /aarch64|arm64/.test(navigator.userAgent.toLowerCase()) ? "arm64" : "x64";
}

function renderOtherDownloads(availableTargets, selectedTarget) {
  otherDownloads.replaceChildren();

  for (const target of availableTargets) {
    const link = document.createElement("a");
    const name = document.createElement("span");
    const metadata = document.createElement("small");

    link.href = target.url;
    name.textContent = `${target.label} ${target.detail}`;
    metadata.textContent = [target.version, formatBytes(target.size)].filter(Boolean).join(" · ");
    link.append(name, metadata);

    if (target.id === selectedTarget?.id) {
      link.setAttribute("aria-current", "true");
      name.textContent += " (detected)";
    }

    otherDownloads.append(link);
  }
}

function showReleaseFallback(platform) {
  const unsupportedMac = platform === "macos";
  primaryDownload.classList.remove("is-loading");
  primaryDownload.href = releasesUrl;
  downloadLabel.textContent = unsupportedMac ? "View available downloads" : "View GitHub releases";
  downloadDetail.textContent = unsupportedMac
    ? "macOS builds are not currently available"
    : "No published release found yet";
  secondaryDownload.href = releasesUrl;
  otherDownloadsToggle.hidden = true;
}

async function configureDownloads() {
  const platform = getPlatform();
  const architecture = await getArchitecture();

  try {
    const response = await fetch(latestReleaseApiUrl, {
      headers: { Accept: "application/vnd.github+json" },
      cache: "no-store",
    });

    if (!response.ok) {
      throw new Error(`GitHub release request failed with status ${response.status}`);
    }

    const release = await response.json();
    const assetsByName = new Map(release.assets.map((asset) => [asset.name, asset]));
    const availableTargets = targets.flatMap((target) => {
      const asset = assetsByName.get(target.fileName);
      return asset
        ? [{ ...target, url: asset.browser_download_url, size: asset.size, version: release.tag_name }]
        : [];
    });

    let selectedTarget;
    if (platform === "windows") {
      selectedTarget = availableTargets.find((target) => target.id === "win-x64");
    } else if (platform === "linux") {
      selectedTarget = availableTargets.find((target) => target.id === `linux-${architecture}`);
    }

    primaryDownload.classList.remove("is-loading");
    secondaryDownload.href = release.html_url;

    if (selectedTarget) {
      primaryDownload.href = selectedTarget.url;
      downloadLabel.textContent = `Download for ${selectedTarget.label}`;
      downloadDetail.textContent = [
        selectedTarget.version,
        selectedTarget.detail,
        formatBytes(selectedTarget.size),
      ].filter(Boolean).join(" · ");
    } else {
      primaryDownload.href = release.html_url;
      downloadLabel.textContent = platform === "macos" ? "View available downloads" : "Choose your download";
      downloadDetail.textContent = platform === "macos"
        ? "macOS builds are not currently available"
        : `Latest release ${release.tag_name}`;
    }

    renderOtherDownloads(availableTargets, selectedTarget);
    otherDownloadsToggle.hidden = availableTargets.length === 0;
  } catch (error) {
    console.warn("Could not load the latest GitHub release.", error);
    showReleaseFallback(platform);
  }
}

otherDownloadsToggle.addEventListener("click", () => {
  const isExpanded = otherDownloadsToggle.getAttribute("aria-expanded") === "true";
  otherDownloadsToggle.setAttribute("aria-expanded", String(!isExpanded));
  otherDownloads.hidden = isExpanded;
});

configureDownloads();
