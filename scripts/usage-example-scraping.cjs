// ------------------------------------------------------------------------------
// Imports
// ------------------------------------------------------------------------------
const kleur = require("kleur"); // Terminal highlighting
const fs = require('fs'); // Interact with the file system
const path = require('path'); // Handle and transform file paths


const srcDirectory = "./public/usage-examples"; //directory to be scraped
const outputDirectory = "./scripts/json-files/usage-example-references.json" //directory where "Usage Example" functions will be savedc
const apiJsonPath = "./scripts/json-files/api.json"; // Path to API JSON for checking overloads

// ------------------------------------------------------------------------------
// Load API JSON and build a set of overloaded function names
// ------------------------------------------------------------------------------
function getOverloadedFunctions() {
    try {
        const apiData = JSON.parse(fs.readFileSync(apiJsonPath, 'utf8'));
        const overloadedFunctions = new Set();
        const functionCounts = {};

        // Count occurrences of each function name across all categories
        Object.values(apiData).forEach(category => {
            if (category && category.functions && Array.isArray(category.functions)) {
                category.functions.forEach(func => {
                    if (func.name) {
                        functionCounts[func.name] = (functionCounts[func.name] || 0) + 1;
                    }
                });
            }
        });

        // Add functions that appear more than once (overloaded)
        Object.entries(functionCounts).forEach(([name, count]) => {
            if (count > 1) {
                overloadedFunctions.add(name);
            }
        });

        return overloadedFunctions;
    } catch (error) {
        console.error('Error loading API JSON:', error);
        return new Set();
    }
}

// ------------------------------------------------------------------------------
// Scraping all of the folders in usage example and retrieving the functions and title 
// ------------------------------------------------------------------------------
function getAvailableExamplesFunctionUsage(dir) {
    const result = {};
    const fileNameRegex = /^([a-zA-Z_][a-zA-Z0-9_]*)-/;

    const ignoreKey = new Set(["if", "else", "elif", "while", "for", "range", "int", "str", "match"]);
    const overloadedFunctions = getOverloadedFunctions();

    const folders = fs.readdirSync(dir);
    folders.forEach(folder => {
        const folderPath = path.join(dir, folder);
        const functionCallRegex = /\b([a-zA-Z_][a-zA-Z0-9_]*)\s*\(/g;

        try {
            const stats = fs.statSync(folderPath);

            // Checking if the path is a directory
            if (stats.isDirectory()) {
                const files = fs.readdirSync(folderPath);
                // Filtering for JSON files
                pythonFiles = files.filter(file => path.extname(file).toLowerCase() === '.py');
                textFiles = files.filter(file => path.extname(file).toLowerCase() === '.txt');

                pythonFiles.forEach(pyFile => {
                    const fileName = path.join(folderPath, pyFile);
                    const fileName2 = fileName.replace('.py', '.txt')
                    const pythonFile = fs.readFileSync(fileName);
                    const textFile = fs.readFileSync(fileName2, "utf8");
                    const title = textFile.split("\n")[0];
                    const pyFileMatch = fileNameRegex.exec(pyFile);
                    try {

                        const folderKey = folder.toLowerCase();
                        const funcKey = pyFileMatch[1].toLowerCase();

                        if (!result[folderKey]) {
                            result[folderKey] = []
                        }

                        let funcEntry = result[folderKey].find(entry => entry.funcKey === funcKey);

                        if (!funcEntry) {
                            // Check if this function is overloaded
                            const funcKeyUrlPart = funcKey.replaceAll("_", "-");
                            const isOverloaded = overloadedFunctions.has(funcKey);
                            const url = isOverloaded 
                                ? `/api/${folderKey}/#${funcKeyUrlPart}-functions`
                                : `/api/${folderKey}/#${funcKeyUrlPart}`;
                            
                            funcEntry = {
                                funcKey: funcKey,
                                title: title,
                                url: url,
                                functions: []
                            };
                            result[folderKey].push(funcEntry);
                        }

                        let match;
                        while ((match = functionCallRegex.exec(pythonFile)) !== null) {
                            const funcName = match[1];
                            if (!funcEntry.functions.includes(funcName) && !ignoreKey.has(funcName) && funcKey != funcName) {
                                funcEntry.functions.push(funcName)
                            }
                        }

                    } catch (error) {
                        console.error(`Error parsing JSON in file: ${pythonFiles}`);
                        console.error(error.message);
                    }
                })
            } else {
                if (folder != "CONTRIBUTING.mdx" && folder != ".DS_Store")
                    console.log(`${folder} is not a diectory`);
            }
        } catch (err) {
            console.log(`Error loading JSON in folder: ${folder}`);
        }
    })
    return result;
}

// ------------------------------------------------------------------------------
// Writing to the output JSON file
// ------------------------------------------------------------------------------
function generateAvailableFunctionsInUsageExamples(srcDirectory, outputDirectory) {
    try {
        const usageExamplesContent = getAvailableExamplesFunctionUsage(srcDirectory);

        try {
            fs.writeFileSync(outputDirectory, JSON.stringify(usageExamplesContent, null, 4));
        } catch (err) {
            console.log('Error writing output files: ', err);
        }
    } catch (error) {
        console.log('Error processing usage examples files: ', error);
    }
}

// ==============================================================================
// ========================= START of main script ===============================
// ==============================================================================

console.log(kleur.cyan('------------------------------------------------------------------------------'));
console.log(kleur.magenta('Usage Example Scraping:'));
console.log(kleur.cyan('------------------------------------------------------------------------------\n'));

generateAvailableFunctionsInUsageExamples(srcDirectory, outputDirectory);

console.log(kleur.green("All examples have been scraped successfully.\n"));
