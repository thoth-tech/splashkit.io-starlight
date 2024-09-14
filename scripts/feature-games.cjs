const fs = require('fs');
const path = require('path');
const matter = require('gray-matter');

const gamesDir = path.join(__dirname, '../src/content/docs/games');
const outputFile = path.join(__dirname, '../src/components/react/GameCardSwiper/games-config.json'); // Updated path

// Function to generate JSON config
function generateGamesConfig() {
  const files = fs.readdirSync(gamesDir).filter(file => {
    console.log(`Processing file: ${file}`); // Log the file being processed
    return file.endsWith('.mdx') && file !== 'games.mdx' && file !== 'index.mdx';
  });

  const games = [];

  files.forEach(file => {
    const filePath = path.join(gamesDir, file);
    const content = fs.readFileSync(filePath, 'utf8');
    
    try {
      const { data: frontmatter } = matter(content);
      
      console.log(`Frontmatter for ${file}:`, frontmatter); // Log frontmatter of each file

      if (frontmatter.title && frontmatter.description) {
        const game = {
          name: frontmatter.title,  // Use 'title' from frontmatter as 'name'
          description: frontmatter.description, // Use 'description' from frontmatter
          link: file.replace('.mdx', ''), // Use the filename (without .mdx) as 'link'
          featured: frontmatter.featured || false // Use 'featured' from frontmatter, default to false if undefined
        };
        games.push(game);
      } else {
        console.warn(`Missing fields in frontmatter for ${file}. Skipping.`);
      }
    } catch (error) {
      console.error(`Error processing file ${file}:`, error);
    }
  });

  const config = { games };

  fs.writeFileSync(outputFile, JSON.stringify(config, null, 2));
  console.log(`Games config generated at: ${outputFile}`);
}

generateGamesConfig();
