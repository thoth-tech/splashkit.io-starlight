const kleur = require("kleur");
const fs = require('fs'); // Import the file system module to interact with the file system
const path = require('path'); // Import the path module to handle and transform file paths

// Define the path to the directory containing the guide and beyond SplashKit groups
const guidesDir = './src/content/docs/guides';
const beyondDir = './src/content/docs/beyond-splashkit';
// Define the path where the output JSON files will be saved
const guidesOutputJson = './scripts/guides-groups.json';
const beyondSkOutputJson = './scripts/beyond-splashkit-groups.json';

// Read the contents of the guides directory 
function getDirNames(directory)
{
    return fs.readdirSync(directory, { withFileTypes: true })
         // Filter out only the directories from the list of files and directories
        .filter(dirent => dirent.isDirectory())
        // Map the directory names to lowercase to standardise them
        .map(dirent => dirent.name);
}   

const guidesFolderNames = getDirNames(guidesDir);
// Write the list of group names to the output JSON file
fs.writeFileSync(guidesOutputJson, JSON.stringify(guidesFolderNames, null, 2));
// Log a message to the console indicating that the JSON file has been created
console.log(kleur.green("Available tutorial/guide category names have been written to " + guidesOutputJson + "\n"));
    
const beyondSkFolderNames = getDirNames(beyondDir);
fs.writeFileSync(beyondSkOutputJson, JSON.stringify(beyondSkFolderNames, null, 2));
console.log(kleur.green("Available tutorial/guide category names have been written to " + beyondSkOutputJson + "\n"));
