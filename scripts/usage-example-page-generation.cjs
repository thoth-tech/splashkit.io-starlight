// Written and maintained by Olivia McKeon (@omckeon)

const fs = require("fs");
const kleur = require("kleur");

// Define language label mappings
const languageLabelMappings = {
  cpp: "C++",
  csharp: "C#",
  python: "Python",
  // pascal: "Pascal",
  // Add more mappings as needed
};

// Define language file extensions
const languageFileExtensions = {
  cpp: ".cpp",
  csharp: ".cs",
  python: ".py",
  pascal: ".pas"
};

const languageOrder = ["cpp", "csharp", "python"];//, "pascal"];

// Get JSON data from api.json file
function getJsonData() {
  var jsonFile;
  var jsonData;
  try {
    jsonFile = fs.readFileSync(`${__dirname}/api.json`);
  } catch (err) {
    console.error(kleur.red("Error reading JSON file:"), err);
    return;
  }
  try {
    jsonData = JSON.parse(jsonFile);
  } catch (error) {
    console.error(kleur.red("Error parsing JSON:"), error);
    return;
  }
  return jsonData;
}

// Get a list of the category groups from the json data
function getApiCategories(jsonData) {
  const apiCategories = [];
  for (const categoryKey in jsonData) {
    if (categoryKey != "types") {
      apiCategories.push(categoryKey);
    }
  }
  return apiCategories;
}

// Get a list of all of the unique function names
function getUniqueFunctionNames(categoryKey, jsonData) {
  const category = jsonData[categoryKey];
  const functionNames = category.functions.map((func) => func.unique_global_name);
  return functionNames;
}

// Get a list of the function group names (name used for overloaded functions)
function getFunctionGroups(categoryKey, jsonData) {
  const category = jsonData[categoryKey];
  const functionNames = category.functions.map((func) => func.name);
  return functionNames;
}

// Get the category description to display on the index page link cards
function getCategoryDescription(categoryKey, jsonData) {
  const category = jsonData[categoryKey];
  return category.brief.replace(/\n/g, '');
}

// Search the folders to get a list of paths for all available files in the /public/usage-examples/ folder
function getAllFiles(dir, allFilesList = []) {
  const files = fs.readdirSync(dir);
  files.map(file => {
    const name = dir + '/' + file;
    if (fs.statSync(name).isDirectory()) { // check if subdirectory is present
      getAllFiles(name, allFilesList);     // do recursive execution for subdirectory
    } else {
      allFilesList.push(file);             // push filename into the array
    }
  })
  return allFilesList;
}

// Create function link to match with functions in the API Documentation pages
function getFunctionLink(jsonData, groupNameToCheck, uniqueNameToCheck) {
  let isOverloaded;
  let functionIndex = -1;
  let functionLink = "";
  for (const categoryKey in jsonData) {
    const category = jsonData[categoryKey];
    const categoryFunctions = category.functions;
    const functionGroups = {}; // Store functions grouped by name
    categoryFunctions.forEach((func) => {
      const functionName = func.name;
      if (!functionGroups[functionName]) {
        functionGroups[functionName] = [];
      }
      functionGroups[functionName].push(func);
    });

    for (const functionName in functionGroups) {
      if (functionName == groupNameToCheck) {
        const overloads = functionGroups[functionName];
        isOverloaded = overloads.length > 1;

        if (isOverloaded) {
          overloads.forEach((func, index) => {
            functionIndex = index + 1;
            if (uniqueNameToCheck == func.unique_global_name) {
              functionLink = functionName + "-" + (index + 1);
            }
          });
        }
        else {
          functionLink = functionName;
        }
      }
    }
  }
  return functionLink;
}

function findZipFileInTxt(folderPath) {
  const txtFiles = fs.readdirSync(folderPath).filter(file => file.endsWith('.txt'));
  for (const txtFile of txtFiles) {
    const txtFilePath = `${folderPath}/${txtFile}`;
    const fileContent = fs.readFileSync(txtFilePath, 'utf-8');

    // Regex to match a .zip path or URL
    const zipRegex = /\/[^\s]*\.zip/g;
    const match = fileContent.match(zipRegex);

    if (match && match.length > 0) {
      return match[0]; // Return the first match
    }
  }
  return null;
}

// ===============================================================================
// Start of Main Script
// ===============================================================================

console.log("Generating MDX files for Usage Examples pages...\n");

let name;
let success = true;
let testing = false;
let testingSuccess = true;
let testingOutput = "";
let fileNameToCheck = "";
// let simpleExample = false;

if (process.argv[2] != null) {
  fileNameToCheck = process.argv[2];
  testing = true;
}

let apiJsonData = getJsonData();
let categories = getApiCategories(apiJsonData);

// Loop through each category to create 1 page per category
categories.forEach((categoryKey) => {
  let categoryPath = '/usage-examples/' + categoryKey;
  let categoryFilePath = './public/usage-examples/' + categoryKey;
  const categoryFiles = getAllFiles(categoryFilePath);
  // Use .txt files to find completed usage examples
  const txtFiles = categoryFiles.filter(file => file.endsWith('.txt'))

  // Start of each page creation
  if (txtFiles.length > 0) {
    let mdxContent = "";

    // Create header info on page
    let categoryTitle = categoryKey.split("_")
      .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
      .join(" ");
    let categoryURL = categoryKey.replaceAll("_", "-");
    name = categoryTitle;
    mdxContent += "---\n";
    mdxContent += `title: ${categoryTitle}\n`;
    mdxContent += `description: ${getCategoryDescription(categoryKey, apiJsonData)}\n`;
    mdxContent += "sidebar:\n";
    mdxContent += `  label: ${categoryTitle}\n`;
    mdxContent += "banner:\n";
    mdxContent += `  content: Check out how to use the ${categoryTitle} functions!\n`;
    mdxContent += "---\n\n";

    mdxContent += `import { Code, Tabs, TabItem, LinkCard } from "@astrojs/starlight/components";\n`
    // mdxContent += `import { Code } from '@astrojs/starlight/components';\n`;
    mdxContent += `import Signatures from "/src/components/Signatures.astro";\n`;

    mdxContent += "\n:::note\n";
    mdxContent += `This page contains code examples of the [${categoryTitle}](/api/${categoryURL}) functions.\n`
    mdxContent += ":::\n\n";

    // Possible alternative
    // mdxContent += `\n<LinkCard\n`;
    // mdxContent += `  title="Related: ${categoryTitle} API Documention"\n`
    // mdxContent += `  href="/api/${categoryURL}"\n`
    // mdxContent += `/>\n\n`;

    // get function overload info
    let functionGroups = getFunctionGroups(categoryKey, apiJsonData);

    // get function info
    let functions = getUniqueFunctionNames(categoryKey, apiJsonData);
    let functionIndex = 0;
    let groupName = "";

    mdxContent += `## Simple Usage Examples\n`;
    const functionGroup = {};
    functions.forEach((functionKey) => {

      const functionExampleFiles = txtFiles.filter(file => file.startsWith(functionKey + '-'));
      groupName = functionGroups[functionIndex];

      if (functionExampleFiles.length > 0) {

        // Create function heading
        let functionTitle = functionKey.split("_")
          .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
          .join(" ");

        // Create Function Example heading with link
        const functionURL = getFunctionLink(apiJsonData, groupName, functionKey);

        // --- IN PROGRESS: Start ---

        // Note: Updating to use single heading with note about overloaded functions available

        // Check if overloaded
        // if (/\d/.test(functionURL) && groupName.includes("write_line")) {
        //   const categoryFunctions = apiJsonData[categoryKey].functions;
        //   const functionGroup = {};
        //   if (!functionGroup[groupName]) {
        //     functionGroup[groupName] = [];
        //   }
        //   categoryFunctions.forEach((func) => {
        //     const functionName = func.name;
        //     const uniqueName = func.unique_global_name;

        //     if (uniqueName.endsWith(functionKey) && functionName == groupName) {
        //       functionGroup[functionName].push(func);
        //     }
        //   });
        //   console.log(functionGroup);

        // mdxContent += `\n### [${functionTitle}](/api/${categoryURL}/#${groupName.replaceAll("_", "-")})\n\n`;
        // mdxContent += ":::note\n\n";
        // mdxContent += "This function is overloaded. The following versions exist:\n\n";

        //   overloads.forEach((func, index) => {
        //     mdxContent += `- [**${formattedFunctionName}** (`;

        //     var paramCount = Object.keys(func.parameters).length;
        //     var paramNumber = 1;

        //     for (const paramName in func.parameters) {
        //       const param = func.parameters[paramName];
        //       const paramType = param.type;
        //       if (index > 0) {
        //         mdxContent += "";
        //       }

        //       // mdxContent += `${paramName}: ${paramType}, `;

        //       mdxContent += `${paramName}: ${paramType}`;
        //       if (paramNumber < paramCount) {
        //         mdxContent += ", "
        //       }
        //       paramNumber++;
        //     }
        //     mdxContent += `)](/api/${categoryKey}/#${formattedLink.toLowerCase()}-${index + 1})\n`;
        //   });

        //   mdxContent += "\n:::\n";

        // }

        // --- IN PROGRESS: End ---

        mdxContent += `\n### [${functionTitle}](/api/${categoryURL}/#${functionURL.replaceAll("_", "-")})\n\n`;

        // Function signature heading (possible need to update)
        const signature = apiJsonData[categoryKey].functions.map((func) => func.signature)[functionIndex].replaceAll(";", "");
        mdxContent += `:::tip[Note]\n`;
        mdxContent += `The example(s) below are using the **${functionTitle}** function with the following signatures:\n\n`
        mdxContent += `<Signatures name="${functionKey.replaceAll("_", "-")}">\n`;
        mdxContent += `</Signatures>\n`;
        mdxContent += "\n:::\n";

        functionExampleFiles.forEach((exampleTxtKey) => {
          let exampleKey = exampleTxtKey.replaceAll(".txt", "");

          // -----------------------------------
          // ========= TESTING =================
          // -----------------------------------
          // Testing that all files are included for filename (terminal argument)
          if (fileNameToCheck == exampleKey) {

            // Define required code files
            const requiredCodeFiles = {
              ".cpp": "C++\t\t",
              "-top-level.cs": "C# (Top-Level)",
              "-oop.cs": "C# (Object-Oriented)",
              ".py": "Python\t",
              // ".pas": "Pascal",
            };

            let exampleFiles = categoryFiles.filter(file => file.startsWith(exampleKey));

            testingOutput += "\n------------------------------------------------\n\n";
            testingOutput += kleur.magenta("Testing") + kleur.cyan(" -> " + fileNameToCheck) + "\n\n";

            // Text file - check already done above
            testingOutput += kleur.green("\u2705 Text Description\t -> ") + kleur.white(fileNameToCheck + ".txt\n");

            // Check for output file (.png or .gif)
            if (exampleFiles.includes(fileNameToCheck + ".png")) {
              testingOutput += kleur.green("\u2705 Image\t\t -> ") + kleur.white(fileNameToCheck + ".png\n");
            } else if (exampleFiles.includes(fileNameToCheck + ".gif")) {
              testingOutput += kleur.green("\u2705 Image (Gif)\t\t -> ") + kleur.white(fileNameToCheck + ".gif\n");
            } else {
              testingOutput += kleur.red("\u274C Image/Gif\t\t -> ") + kleur.white(fileNameToCheck + " .png or .gif file\n");
              testingSuccess = false;
            }

            // Check code files
            Object.keys(requiredCodeFiles).forEach(function (extension) {
              if (exampleFiles.includes(fileNameToCheck + extension)) {
                testingOutput += kleur.green("\u2705 " + requiredCodeFiles[extension] + "\t -> ") + kleur.white(fileNameToCheck + extension + "\n");
              } else {
                testingOutput += kleur.red("\u274C " + requiredCodeFiles[extension] + "\t -> ") + kleur.white(fileNameToCheck + extension + "\n");
                testingSuccess = false;
              }
            });

            if (!testingSuccess) {
              testingOutput += "\nSome files missing or incorrectly named (shown in red above).\nPlease update to make sure you have all files listed above and try again.\n"
            }

            testingOutput += "\n------------------------------------------------\n";
          }
          // -----------------------------------

          // Description
          let txtFilePath = categoryFilePath + "/" + functionKey + "/" + exampleTxtKey;
          let exampleTxt = fs.readFileSync(txtFilePath);
          mdxContent += "\n";
          mdxContent += exampleTxt.toString();
          mdxContent += "\n\n";

          let languageCodeAvailable = {
            cpp: false,
            csharp: false,
            python: false,
            // pascal: false
          };

          // import code
          let codePath = categoryFilePath + "/" + functionKey;
          const codeFiles = getAllFiles(codePath);
          let importTitle = exampleKey.replaceAll("-", "_");
          let functionTag = "";
          languageOrder.forEach((lang) => {
            const languageFiles = codeFiles.filter(file => file.startsWith(exampleKey)).filter(file => file.endsWith(languageFileExtensions[lang]));
            let codeFilePath = categoryPath + "/" + functionKey + "/" + exampleTxtKey.replaceAll(".txt", languageFileExtensions[lang]);

            // import code if available
            if (languageFiles.length > 0) {
              languageCodeAvailable[lang] = true;

              // Check if both top level and oop code has been found for current function
              const csharpFiles = codeFiles.filter(file => file.endsWith("-top-level.cs") || file.endsWith("-oop.cs")).filter(file => file.includes(exampleKey));
              if (lang == "csharp" && csharpFiles.length > 0) {
                csharpFiles.forEach(file => {
                  if (file.includes(exampleKey)) {
                    if (file.includes("-top-level")) {
                      mdxContent += `import ${importTitle}_top_level_${lang} from '${codeFilePath.replaceAll(".cs", "-top-level.cs").replaceAll("/usage", "/public/usage")}?raw';\n`;
                    }
                    if (file.includes("-oop")) {
                      mdxContent += `import ${importTitle}_oop_${lang} from '${codeFilePath.replaceAll(".cs", "-oop.cs").replaceAll("/usage", "/public/usage")}?raw';\n`;
                    }
                  }
                });
              }
              else {
                mdxContent += `import ${importTitle}_${lang} from '${codeFilePath.replaceAll("/usage", "/public/usage")}?raw';\n`;
              }
            }
          });

          mdxContent += "\n";

          // Code tabs
          mdxContent += "<Tabs syncKey=\"code-language\">\n";
          languageOrder.forEach((lang) => {
            // add code tab if available
            if (languageCodeAvailable[lang]) {
              const languageLabel = languageLabelMappings[lang] || lang;
              mdxContent += `  <TabItem label="${languageLabel}">\n`;

              // Check if both top level and oop code has been found for current function
              const csharpFiles = codeFiles.filter(file => file.endsWith("-top-level.cs") || file.endsWith("-oop.cs")).filter(file => file.includes(exampleKey));
              functionTag = exampleKey.split("-")[0];
              if (lang == "cpp") {
                functionTag = groupName;
              }
              if (lang == "csharp") {
                functionTag = groupName.split("_")
                  .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
                  .join("");
              }
              if (lang == "csharp" && csharpFiles.length > 0) {
                mdxContent += "\n  <Tabs syncKey=\"csharp-style\">\n";
                // use reverse order to make Top level first
                csharpFiles.slice().reverse().forEach(file => {
                  if (file.includes(exampleKey)) {
                    if (file.includes("-top-level")) {
                      mdxContent += `    <TabItem label="Top-level Statements">\n`;
                      mdxContent += `      <Code code={${importTitle}_top_level_${lang}} lang="${lang}" mark={"${functionTag}"} />\n`;
                      mdxContent += "    </TabItem>\n";
                    }
                    if (file.includes("-oop")) {
                      mdxContent += `    <TabItem label="Object-Oriented">\n`;
                      mdxContent += `      <Code code={${importTitle}_oop_${lang}} lang="${lang}" mark={"SplashKit.${functionTag}"} />\n`;
                      mdxContent += "    </TabItem>\n";
                    }
                  }
                });
                mdxContent += "  </Tabs>\n\n";
                mdxContent += "  </TabItem>\n";
              }
              else {
                mdxContent += `    <Code code={${importTitle}_${lang}} lang="${lang}" mark={"${functionTag}"} />\n`;
                mdxContent += "  </TabItem>\n";
              }
            }

          });
          mdxContent += "</Tabs>\n\n";

          // Image or gif output
          mdxContent += "**Output**:\n\n";

          const imageFiles = categoryFiles.filter(file => file.endsWith(exampleKey + '.png'));
          let outputFilePath = categoryPath + "/" + functionKey + "/" + exampleTxtKey;

          if (imageFiles.length > 0) {
            outputFilePath = outputFilePath.replaceAll(".txt", ".png");
          }
          else {
            const gifFiles = categoryFiles.filter(file => file.endsWith('.gif'));
            if (gifFiles.length > 0) {
              outputFilePath = outputFilePath.replaceAll(".txt", ".gif");
            }
            else {
              console.log(kleur.red("\nError: No image or gif files found for " + exampleKey + "usage example"));
            }
          }

			mdxContent += `![${exampleKey} example](${outputFilePath})\n`

      // Find the .zip file path for the folder
      const zipFilePath = findZipFileInTxt(`${categoryFilePath}/${functionKey}`);

			// Add the toggle button and iframe logic
			mdxContent += `
			<div style="text-align: center; margin-top: 1rem;">
			  <button
				id="${functionKey}_sko_button"
				class="sko-button"
				style="margin-top: 1rem;"
				onclick="
				  (function() {
					try {
					  // Check the screen size and restrict functionality for small screens
					  const screenWidth = window.innerWidth;
					  if (screenWidth < 768) {
						alert('This feature is not available on screens of this size.');
						return;
					  }

					  // Declare variables for the iframe container, iframe element, message queue, and readiness flag
					  let globalIframeContainer = document.getElementById('sko_iframe_global_container');
					  let globalIframe = document.getElementById('sko_iframe_global');
					  const messageQueue = []; // Queue for storing messages while iframe is not ready
					  let isIframeReady = false; // Tracks whether iframe is ready to receive messages

					  // Add a fallback timeout to process messages
					  let readinessTimeout = null;

					  // Ensure only one message listener is added
					  if (!window.skoListenerAdded) {
						window.skoListenerAdded = true;

						// Add an event listener to process messages from the iframe
						window.addEventListener('message', function(event) {
						  if (event.data.type === 'SplashKitOnlineListening') {
							console.log('Iframe is ready to receive messages.');
							isIframeReady = true;

							// Clear timeout if readiness signal is received
							if (readinessTimeout) clearTimeout(readinessTimeout);

							// Process all queued messages
							while (messageQueue.length > 0) {
							  const message = messageQueue.shift();
							  globalIframe.contentWindow.postMessage(message, '*');
							}
						  }
						});
					  }

					  // Create the iframe and its container if it doesn't already exist
					  if (!globalIframeContainer) {
						// Create a container for the iframe
						globalIframeContainer = document.createElement('div');
						globalIframeContainer.id = 'sko_iframe_global_container';
						globalIframeContainer.style.position = 'fixed';
						globalIframeContainer.style.top = '50%';
						globalIframeContainer.style.left = '50%';
						globalIframeContainer.style.transform = 'translate(-50%, -50%)';
						globalIframeContainer.style.width = '75vw';
						globalIframeContainer.style.height = '75vh';
						globalIframeContainer.style.border = '1px solid #ccc';
						globalIframeContainer.style.borderRadius = '8px';
						globalIframeContainer.style.backgroundColor = '#fff';
						globalIframeContainer.style.zIndex = '9999';
						document.body.appendChild(globalIframeContainer);

						// Add a draggable bar for moving the iframe container
						const dragBar = document.createElement('div');
						dragBar.style.width = '100%';
						dragBar.style.height = '30px';
						dragBar.style.backgroundColor = '#333';
						dragBar.style.color = '#fff';
						dragBar.style.display = 'flex';
						dragBar.style.justifyContent = 'space-between';
						dragBar.style.alignItems = 'center';
						dragBar.style.padding = '0 10px';
						dragBar.style.cursor = 'move';
						dragBar.textContent = 'Drag to move';
						globalIframeContainer.appendChild(dragBar);

						// Add a close button to the drag bar
						const closeButton = document.createElement('button');
						closeButton.textContent = 'X';
						closeButton.style.backgroundColor = '#e74c3c';
						closeButton.style.color = '#fff';
						closeButton.style.border = 'none';
						closeButton.style.cursor = 'pointer';
						closeButton.onclick = function () {
						  globalIframeContainer.style.display = 'none';
						};
						dragBar.appendChild(closeButton);

						// Create the iframe element
						globalIframe = document.createElement('iframe');
						globalIframe.id = 'sko_iframe_global';
						globalIframe.src = 'https://thoth-tech.github.io/SplashkitOnline/?language=C++';
						globalIframe.style.width = '100%';
						globalIframe.style.height = 'calc(100% - 30px)';
						globalIframe.style.border = 'none';
						globalIframeContainer.appendChild(globalIframe);
					  }

					  // Display the iframe container
					  globalIframeContainer.style.display = 'block';

					  // Function to send a message to the iframe, queuing if it's not ready
					  const sendMessageToIframe = (message) => {
						if (isIframeReady) {
						  globalIframe.contentWindow.postMessage(message, '*');
						} else {
						  console.log('Iframe not ready, queuing message.');
						  messageQueue.push(message);
						}
					  };

					  // Paths to the C++ code and ZIP file
					  const filePath = '/usage-examples/${categoryKey}/${functionKey}/${exampleKey}.cpp';
					  const zipPath = '${zipFilePath}';

					  // Reset iframe state before sending new data
					  sendMessageToIframe({ eventType: 'ResetProjectState' });

					  // Add a fallback to process messages after a timeout
					  readinessTimeout = setTimeout(() => {
						console.warn('Iframe readiness timeout. Processing queued messages.');
						isIframeReady = true;
						while (messageQueue.length > 0) {
						  const message = messageQueue.shift();
						  globalIframe.contentWindow.postMessage(message, '*');
						}
					  }, 100); // 0.1-second timeout

					  // Fetch the C++ code and ZIP file
					  fetch(filePath)
						.then(response => {
						  if (!response.ok) throw new Error('Failed to fetch C++ file.');
						  return response.text();
						})
						.then(async codeData => {
						  let zipBlob = null;
						  try {
							const zipResponse = await fetch(zipPath);
							if (zipResponse.ok) zipBlob = await zipResponse.blob();
						  } catch (e) {
							console.warn('ZIP file fetch failed:', zipPath);
						  }

						  // Prepare the initialization message
						  const message = {
							eventType: 'InitializeProjectFromOutsideWorld',
							files: [{ path: '/code/main.cpp', data: codeData }],
							zips: zipBlob ? [{ data: zipBlob }] : []
						  };

						  // Send the message to the iframe
						  sendMessageToIframe(message);
						})
						.catch(err => console.error('Error fetching resources:', err));
					} catch (error) {
					  console.error('Error initializing iframe:', error);
					}
				  })();
				"
			  >
				Try it in SKO
			  </button>
			</div>`;

      mdxContent += "\n---\n";

        });
      }
      functionIndex++;
    });

    // Write the MDX file
    try {
      fs.writeFileSync(`./src/content/docs/usage-examples/${name}.mdx`, mdxContent);
      console.log(kleur.yellow('Usage Examples') + kleur.green(` -> ${categoryKey.split("_")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ")}`));
    } catch (err) {
      success = false;
      console.log(kleur.red(`Error writing ${categoryKey} MDX file: `) + `${err.message}`);
      return;
    }
  }
});

// Check if all MDX files generated successfully
if (success) {
  console.log(kleur.green("\nAll Usage Example MDX files generated successfully."));
}
// Output information when checking filename
if (testing) {
  console.log(testingOutput);
}
