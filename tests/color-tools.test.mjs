import assert from "node:assert/strict";
import test from "node:test";

import {
  hsbToRgb,
  updateExpressiveCode,
} from "../src/utils/color-tools.mjs";

test("hsbToRgb converts primary and neutral colors", () => {
  assert.deepEqual(hsbToRgb(0, 1, 1), { r: 255, g: 0, b: 0 });
  assert.deepEqual(hsbToRgb(120, 1, 1), { r: 0, g: 255, b: 0 });
  assert.deepEqual(hsbToRgb(240, 1, 1), { r: 0, g: 0, b: 255 });
  assert.deepEqual(hsbToRgb(180, 0, 0.5), { r: 128, g: 128, b: 128 });
  assert.deepEqual(hsbToRgb(0, 0.5, 0.5), { r: 128, g: 64, b: 64 });
});

test("hsbToRgb normalizes hue and clamps saturation and brightness", () => {
  assert.deepEqual(hsbToRgb(360, 1, 1), hsbToRgb(0, 1, 1));
  assert.deepEqual(hsbToRgb(-120, 1, 1), hsbToRgb(240, 1, 1));
  assert.deepEqual(hsbToRgb(0, 2, 2), { r: 255, g: 0, b: 0 });
  assert.deepEqual(hsbToRgb(0, -1, -1), { r: 0, g: 0, b: 0 });
});

test("hsbToRgb rejects non-finite values", () => {
  assert.throws(() => hsbToRgb(Number.NaN, 1, 1), TypeError);
  assert.throws(() => hsbToRgb(0, Number.POSITIVE_INFINITY, 1), TypeError);
});

test("updateExpressiveCode keeps visible and copied code synchronized", () => {
  const codeElement = { textContent: "old code" };
  const copyButton = { dataset: { code: "old code" } };
  const container = {
    querySelector(selector) {
      if (selector === ".code") return codeElement;
      if (selector === "button[data-code]") return copyButton;
      return null;
    },
  };

  assert.equal(updateExpressiveCode(container, "line one\nline two"), true);
  assert.equal(codeElement.textContent, "line one\nline two");
  assert.equal(copyButton.dataset.code, "line one\u007fline two");
});
