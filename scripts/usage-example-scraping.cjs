// ------------------------------------------------------------------------------
// Imports
// ------------------------------------------------------------------------------
const kleur = require("kleur"); // Terminal highlighting
const fs = require('fs'); // Interact with the file system
const path = require('path'); // Handle and transform file paths


const srcDirectory = "./public/usage-examples"; //directory to be scraped
const outputDirectory = "./scripts/json-files/usage-example-references.json" //directory where "Usage Example" functions will be savedc

// ------------------------------------------------------------------------------
// Scraping all of the folders in usage example and retrieving the functions and title 
// ------------------------------------------------------------------------------
function getAvailableExamplesFunctionUsage(dir) {
    const result = {};
    const fileNameRegex = /^([a-zA-Z_][a-zA-Z0-9_]*)-/;

    const ignoreKey = new Set(["if", "else", "elif", "while", "for", "range", "int", "str", "match"]);

    const folders = fs.readdirSync(dir);
    folders.forEach(folder => {
        const folderPath = path.join(dir, folder);
        const functionCallRegex = /\b([a-zA-Z_][a-zA-Z0-9_]*)\s*\(/g;

        try {
            const stats = fs.statSync(folderPath);

            // Checking if the path is a directory
            if (stats.isDirectory()) {
                const files = fs.readdirSync(folderPath);

                const pythonFiles = files.filter(
                    file => path.extname(file).toLowerCase() === ".py"
                );

                pythonFiles.forEach(pyFile => {
                    const pythonPath = path.join(folderPath, pyFile);
                    const textPath = pythonPath.replace(/\.py$/i, ".txt");

                    if (!fs.existsSync(textPath)) {
                        throw new Error(
                            `Missing description file for "${pythonPath}": expected "${textPath}"`
                        );
                    }

                    const pythonFile = fs.readFileSync(pythonPath, "utf8");
                    const textFile = fs.readFileSync(textPath, "utf8");
                    const title = textFile.split("\n")[0];
                    const pyFileMatch = fileNameRegex.exec(pyFile);

                    try {
                        const folderKey = folder.toLowerCase();
                        const funcKey = pyFileMatch[1].toLowerCase();

                        if (!result[folderKey]) {
                            result[folderKey] = [];
                        }

                        let funcEntry = result[folderKey].find(
                            entry => entry.funcKey === funcKey
                        );

                        if (!funcEntry) {
                            funcEntry = {
                                funcKey: funcKey,
                                title: title,
                                url: `/api/${folderKey.replaceAll("_", "-")}/#${funcKey.replaceAll("_", "-")}`,
                                functions: []
                            };

                            result[folderKey].push(funcEntry);
                        }

                        let match;

                        while (
                            (match = functionCallRegex.exec(pythonFile)) !== null
                        ) {
                            const funcName = match[1];

                            if (
                                !funcEntry.functions.includes(funcName) &&
                                !ignoreKey.has(funcName) &&
                                funcKey !== funcName
                            ) {
                                funcEntry.functions.push(funcName);
                            }
                        }
                    } catch (error) {
                        console.error(`Error parsing usage example: ${pyFile}`);
                        console.error(error.message);
                        throw error;
                    }
                });
            } else {
                if (folder !== "CONTRIBUTING.mdx" && folder !== ".DS_Store") {
                    console.log(`${folder} is not a directory`);
                }
            }
        } catch (err) {
            throw new Error(
                `Failed to process usage examples in "${folderPath}": ${err.message}`
            );
        }

    })
    return result;
}

// ------------------------------------------------------------------------------
// Writing to the output JSON file
// ------------------------------------------------------------------------------
function generateAvailableFunctionsInUsageExamples(srcDirectory, outputDirectory) {
    const usageExamplesContent =
        getAvailableExamplesFunctionUsage(srcDirectory);

    fs.writeFileSync(
        outputDirectory,
        JSON.stringify(usageExamplesContent, null, 4)
    );
}

// ==============================================================================
// ========================= START of main script ===============================
// ==============================================================================

console.log(kleur.cyan('------------------------------------------------------------------------------'));
console.log(kleur.magenta('Usage Example Scraping:'));
console.log(kleur.cyan('------------------------------------------------------------------------------\n'));

try {
    generateAvailableFunctionsInUsageExamples(srcDirectory, outputDirectory);

    console.log(
        kleur.green("All examples have been scraped successfully.\n")
    );
} catch (error) {
    console.error(kleur.red(`Usage example scraping failed: ${error.message}`));
    process.exitCode = 1;
}
