import sharp from "sharp";

const lines = [
  "Does 'GameTimer' exist? false",
  "Created timer 'GameTimer'",
  "Does 'GameTimer' exist? true",
  "Freed timer 'GameTimer'",
  "Does 'GameTimer' exist? false",
];

const width = 980;
const height = 210;
const padX = 24;
const startY = 54;
const lineH = 30;

const escapeXml = (s) =>
  s
    .replace(/&/g, "&amp;")
    .replace(/</g, "&lt;")
    .replace(/>/g, "&gt;")
    .replace(/\"/g, "&quot;");

const text = lines
  .map((t, i) => `<text x="${padX}" y="${startY + i * lineH}">${escapeXml(t)}</text>`)
  .join("");

const svg = `
<svg xmlns="http://www.w3.org/2000/svg" width="${width}" height="${height}">
  <rect width="100%" height="100%" fill="#1e1e1e"/>
  <g font-family="Consolas, Menlo, Monaco, 'Courier New', monospace" font-size="22" fill="#d4d4d4">
    ${text}
  </g>
</svg>`;

await sharp(Buffer.from(svg), { density: 144 })
  .png()
  .toFile("public/usage-examples/timers/has_timer-1-example.png");

console.log("Wrote public/usage-examples/timers/has_timer-1-example.png");
