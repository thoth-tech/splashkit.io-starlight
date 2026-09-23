/**
 * Convert SplashKit HSB values (HSV: hue in degrees, saturation and brightness
 * from 0 to 1) into 8-bit RGB values suitable for a browser preview.
 */
export function hsbToRgb(hue, saturation, brightness) {
  if (![hue, saturation, brightness].every(Number.isFinite)) {
    throw new TypeError("HSB values must be finite numbers");
  }

  const normalizedHue = ((hue % 360) + 360) % 360;
  const normalizedSaturation = Math.min(Math.max(saturation, 0), 1);
  const normalizedBrightness = Math.min(Math.max(brightness, 0), 1);

  const chroma = normalizedBrightness * normalizedSaturation;
  const hueSection = normalizedHue / 60;
  const secondary = chroma * (1 - Math.abs((hueSection % 2) - 1));

  let red = 0;
  let green = 0;
  let blue = 0;

  if (hueSection < 1) {
    red = chroma;
    green = secondary;
  } else if (hueSection < 2) {
    red = secondary;
    green = chroma;
  } else if (hueSection < 3) {
    green = chroma;
    blue = secondary;
  } else if (hueSection < 4) {
    green = secondary;
    blue = chroma;
  } else if (hueSection < 5) {
    red = secondary;
    blue = chroma;
  } else {
    red = chroma;
    blue = secondary;
  }

  const match = normalizedBrightness - chroma;

  return {
    r: Math.round((red + match) * 255),
    g: Math.round((green + match) * 255),
    b: Math.round((blue + match) * 255),
  };
}

/**
 * Update both the visible Expressive Code output and the value used by its copy
 * button. Expressive Code represents newlines as DEL characters in data-code.
 */
export function updateExpressiveCode(container, code) {
  if (!container) return false;

  const codeElement = container.querySelector(".code");
  const copyButton = container.querySelector("button[data-code]");

  if (codeElement) codeElement.textContent = code;
  if (copyButton && "dataset" in copyButton) {
    copyButton.dataset.code = code.replaceAll("\n", "\u007f");
  }

  return Boolean(codeElement && copyButton);
}
