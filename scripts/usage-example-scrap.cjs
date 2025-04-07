// ------------------------------------------------------------------------------
// Imports
// ------------------------------------------------------------------------------
const fs = require('fs'); // Interact with the file system
const path = require('path'); // Handle and transform file paths


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
                            funcEntry = {
                                funcKey: funcKey,
                                title: title,
                                url: `/api/${folderKey}/#${funcKey.replaceAll("_", "-")}`,
                                functions: []
                            };
                            result[folderKey].push(funcEntry);
                        }
                        
                        let match;
                        while ((match = functionCallRegex.exec(pythonFile)) !== null) {
                            const funcName = match[1];
                            if (!funcEntry.functions.includes(funcName) && !ignoreKey.has(funcName)) {
                                funcEntry.functions.push(funcName)
                            }
                        }

                    } catch (error) {
                        console.error(`Error parsing JSON in file: ${pythonFiles}`);
                        console.error(error.message);
                    }
                })
            } else {
                if (folder != "CONTRIBUTING.mdx")
                console.log(`${folder} is not a diectory`);
            }
        } catch (err) {
            console.log(`Error loading JSON in folder: ${folder}`);
        }
    })
    return result;
}

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
