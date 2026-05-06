// ------------------------------------------------------------------------------
// Imports
// ------------------------------------------------------------------------------
const kleur = require("kleur"); // Terminal highlighting
const fs = require('fs'); // Interact with the file system
const path = require('path'); // Handle and transform file paths


const srcDirectory = "./public/usage-examples"; //directory to be scraped
const outputDirectory = "./scripts/json-files/usage-example-references.json" //directory where "Usage Example" functions will be savedc
const apiJsonPath = "./scripts/json-files/api.json";

const functionKeyOverrides = {
    celestial_mechanics: "sprite_set_velocity",
    rectangle_around: "rectangle_around_circle"
};

function buildApiFunctionIndex(filePath) {
    const apiData = JSON.parse(fs.readFileSync(filePath, "utf8"));
    const functionIndex = new Map();

    Object.entries(apiData).forEach(([categoryKey, categoryValue]) => {
        if (categoryKey === "types" || !categoryValue || !Array.isArray(categoryValue.functions)) return;

        categoryValue.functions.forEach((func) => {
            if (func && typeof func.unique_global_name === "string") {
                functionIndex.set(func.unique_global_name, categoryKey);
            }
        });
    });

    return functionIndex;
}

function resolvePrimaryFunctionKey(rawFuncKey, calledFunctions, apiFunctionIndex) {
    const candidateKeys = [];

    if (functionKeyOverrides[rawFuncKey]) {
        candidateKeys.push(functionKeyOverrides[rawFuncKey]);
    }

    candidateKeys.push(rawFuncKey, ...calledFunctions);

    for (const key of candidateKeys) {
        if (apiFunctionIndex.has(key)) return key;
    }

    return rawFuncKey;
}

// ------------------------------------------------------------------------------
// Scraping all of the folders in usage example and retrieving the functions and title 
// ------------------------------------------------------------------------------
function getAvailableExamplesFunctionUsage(dir) {
    const result = {};
    const fileNameRegex = /^([a-zA-Z_][a-zA-Z0-9_]*)-/;
    const apiFunctionIndex = buildApiFunctionIndex(apiJsonPath);

    const ignoreKey = new Set(["if", "else", "elif", "while", "for", "range", "int", "str", "match"]);

    const folders = fs.readdirSync(dir);
    folders.forEach(folder => {
        const folderPath = path.join(dir, folder);
        const functionCallRegex = /\b([a-zA-Z_][a-zA-Z0-9_]*)\s*\(/g;

        try {
            if (fs.statSync(folderPath).isDirectory()) {
                const files = fs.readdirSync(folderPath);
                const pythonFiles = files.filter(file => path.extname(file).toLowerCase() === '.py');

                pythonFiles.forEach(pyFile => {
                    const fileName = path.join(folderPath, pyFile);
                    const fileName2 = fileName.replace('.py', '.txt');
                    
                    if (!fs.existsSync(fileName2)) return;

                    const pythonFile = fs.readFileSync(fileName, "utf8");
                    const textFile = fs.readFileSync(fileName2, "utf8");
                    const title = textFile.split(/\r?\n/)[0].replace(/[\r\n]/g, "").trim();
                    const pyFileMatch = fileNameRegex.exec(pyFile);
                    
                    if (!pyFileMatch) return;

                    try {
                        const folderKey = folder.toLowerCase();
                        const funcKey = pyFileMatch[1].toLowerCase();
                        const calledFunctions = [];

                        let match;
                        while ((match = functionCallRegex.exec(pythonFile)) !== null) {
                            const funcName = match[1];
                            if (!calledFunctions.includes(funcName) && !ignoreKey.has(funcName) && funcKey != funcName) {
                                calledFunctions.push(funcName)
                            }
                        }

                        const resolvedFuncKey = resolvePrimaryFunctionKey(funcKey, calledFunctions, apiFunctionIndex);
                        const apiCategory = apiFunctionIndex.get(resolvedFuncKey);
                        const targetCategory = apiCategory || folderKey;

                        if (!result[targetCategory]) {
                            result[targetCategory] = [];
                        }

                        let funcEntry = result[targetCategory].find(entry => entry.funcKey === resolvedFuncKey && entry.title === title);

                        if (!funcEntry) {
                            funcEntry = {
                                funcKey: resolvedFuncKey,
                                title: title,
                                url: apiCategory
                                    ? `/api/${apiCategory}/#${resolvedFuncKey.replaceAll("_", "-")}`
                                    : `/usage-examples/${folderKey}`,
                                functions: []
                            };
                            result[targetCategory].push(funcEntry);
                        }

                        calledFunctions.forEach((funcName) => {
                            if (!funcEntry.functions.includes(funcName)) {
                                funcEntry.functions.push(funcName);
                            }
                        });
                        funcEntry.functions.sort();

                    } catch (error) {
                        console.error(`Error processing file ${pyFile}:`, error.message);
                    }
                });
            }
        } catch (err) {
            // Skip non-directories or permission errors
        }
    });

    // Sort the root categories
    const sortedResult = {};
    Object.keys(result).sort().forEach(key => {
        sortedResult[key] = result[key].sort((a, b) => a.funcKey.localeCompare(b.funcKey));
    });

    return sortedResult;
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
