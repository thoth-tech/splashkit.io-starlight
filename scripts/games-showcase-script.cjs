const fs = require('fs');
const path = require('path');
const kleur = require("kleur");

// ------------------------------------------------------------------------------
// Constants
// ------------------------------------------------------------------------------
const inputJsonPath = path.join(__dirname, './json-files/games-showcase.json')
const gameData = fs.readFileSync(inputJsonPath, 'utf-8');
const inputJson = JSON.parse(gameData);

// ==============================================================================
// ========================= START of main script ===============================
// ==============================================================================
let success = true;

console.log(kleur.cyan('------------------------------------------------------------------------------'));
    console.log(kleur.magenta('Games Showcase MDX Pages Generation: '));
    console.log(kleur.cyan('------------------------------------------------------------------------------\n'));

const generateGameShowcase = (gameKey, gameData) => {
    return gameData.map(game => {
        const installationSteps = game.installation.map(step => `1. ${step}`).join('\n');
        const developers = Object.entries(game.dev).map(([name, url]) => `- [${name}](${url})`).join('\n');

        return `---
title: ${game.title}
description: ${game.shortDesc}
download-link: "${game.download}"
featured: true
sidebar:
  hidden: false
---

{/*Embedding dynamic JavaScript directly in MDX to generate game gif*/}
<img
  src={"/gifs/games-showcase/${game.title.toLowerCase().replace(/\s+/g, '-')}-showcase.gif"}
  alt="${game.title} Showcase"
/>
        
## Description

${game.description}

## Installation

${installationSteps}

<div class="centered-button-container">
  <button
    class="custom-button"
    onclick="window.open('${game.download}', '_blank')">
    Download
  </button>
</div>
        
## Gameplay
        
${game.gameplay}
        
## Developers
        
${developers}

Last Updated: ${game.date}

<div class="centered-button-container">
  <button class="custom-button" onclick="location.href='/games'">
    Back to Games Index
  </button>
</div>`;
}).join(`\n\n`)

}

Object.entries(inputJson).forEach(([key, data]) => {
    const md = generateGameShowcase(key, data);
    outputPath = path.join(__dirname, "../src/content/docs/games");
    try {
      fs.writeFileSync(`${outputPath}/${key.replace(/\s+/g, '-').toLowerCase()}.mdx`, md);
      console.log(kleur.yellow('  Generated: ') + kleur.green(`${key.replace(/\s+/g, '-').toLowerCase()}.mdx`));
    } catch (err) {
      success = false;
      console.log(kleur.red(`Error writing ${input} MDX file: ${err.message}`));
    }
})

if (success) {
  console.log(kleur.green("\nAll Game Showcase MDX files generated successfully.\n"));
}