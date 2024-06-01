const fs = require('fs');
const path = require('path');

async function fetchData() {
    try {
        const response = await fetch(
            "https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/config.json"
        );
        const data = await response.json();

        if (data.games) {
            let mdxContent = `---
title: Game Page
---

<div className="game-page-container">

${data.games.map(section => `


## [${section.name}](#${section.name.toLowerCase().replace(/\s/g, "-")})

### Description
${section.description}

${section.image ? `![Game Image for ${section.name}](${!section.image.startsWith("http") ? `https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/${section.src}/${section.image}` : section.image})` : '![](https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I)'}


Language - \`${section.language}\` \t
Rating - \`${section.rating}\`

### Command
\`\`\`${section.language}\n
${section.command}\n\`\`\`\n
<button onclick="window.open('https://download-directory.github.io?url=https://raw.githubusercontent.com/XQuestCode/SplashkitGames/tree/main/${section.src}/', '_blank')">Download</button>

---\n`).join('\n')}

</div>`;

            const filePath = path.join(__dirname, '../src/content/docs/games.mdx');

            // Create the directory if it doesn't exist
            const directoryPath = path.dirname(filePath);
            fs.mkdirSync(directoryPath, { recursive: true });

            // Write the file
            fs.writeFileSync(filePath, mdxContent);
            console.log('MDX document generated');
        } else {
            console.log('No data found.');
        }
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}

fetchData();