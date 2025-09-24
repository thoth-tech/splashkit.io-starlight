// ------------------------------------------------------------------------------
// Script to generate .mdx files in the "/src/content/docs/api" folder,
// using a specific format to adapt to markdown from JSON data.

// Authors: @XQuestCode, @omckeon, and @thoth-tech members
// ------------------------------------------------------------------------------

// ------------------------------------------------------------------------------
// Imports
// ------------------------------------------------------------------------------
const fs = require("fs");
const kleur = require("kleur");
const path = require('path');

// ------------------------------------------------------------------------------
// Constants
// ------------------------------------------------------------------------------
// For cleaning files from usage-examples folder
const directoryToClean = 'src/content/docs/api';
const filesToKeep = ['index.mdx'];

// Define type mappings
const typeMappings = {
  int: "`Integer`",
  double: "`Double`",
  bool: "`Boolean`",
  char: "`Char`",
  string: "`String`",
  void: "`Void`",
  float: "`Float`",
  vector: "`Vector`",
  // Add more type mappings as needed
};

const guidesAvailable = {
  animations: false,
  audio: false,
  camera: false,
  database: false,
  inputs: false,
  json: false,
  networking: false,
  physics: false,
  sprites: false,
  utilities: false
};

// Define language label mappings
const languageLabelMappings = {
  pascal: "Pascal",
  python: "Python",
  cpp: "C++",
  csharp: "C#",
  // Add more mappings as needed
};

// Define language file extensions
const languageFileExtensions = {
  cpp: ".cpp",
  csharp: ".cs",
  python: ".py",
  pascal: ".pas"
};

// Define language order
const languageOrder = ["cpp", "csharp", "python", "pascal"];
var name = "";

const sk_colors = ["alice_blue", "antique_white", "aqua", "aquamarine", "azure", "beige", "bisque", "black", "blanched_almond", "blue", "blue_violet", "bright_green", "brown", "burly_wood", "cadet_blue", "chartreuse", "chocolate", "coral", "cornflower_blue", "cornsilk", "crimson", "cyan", "dark_blue", "dark_cyan", "dark_goldenrod", "dark_gray", "dark_green", "dark_khaki", "dark_magenta", "dark_olive_green", "dark_orange", "dark_orchid", "dark_red", "dark_salmon", "dark_sea_green", "dark_slate_blue", "dark_slate_gray", "dark_turquoise", "dark_violet", "deep_pink", "deep_sky_blue", "dim_gray", "dodger_blue", "firebrick", "floral_white", "forest_green", "fuchsia", "gainsboro", "ghost_white", "gold", "goldenrod", "gray", "green", "green_yellow", "honeydew", "hot_pink", "indian_red", "indigo", "ivory", "khaki", "lavender", "lavender_blush", "lawn_green", "lemon_chiffon", "light_blue", "light_coral", "light_cyan", "light_goldenrod_yellow", "light_gray", "light_green", "light_pink", "light_salmon", "light_sea_green", "light_sky_blue", "light_slate_gray", "light_steel_blue", "light_yellow", "lime", "lime_green", "linen", "magenta", "maroon", "medium_aquamarine", "medium_blue", "medium_orchid", "medium_purple", "medium_sea_green", "medium_slate_blue", "medium_spring_green", "medium_turquoise", "medium_violet_red", "midnight_blue", "mint_cream", "misty_rose", "moccasin", "navajo_white", "navy", "old_lace", "olive", "olive_drab", "orange", "orange_red", "orchid", "pale_goldenrod", "pale_green", "pale_turquoise", "pale_violet_red", "papaya_whip", "peach_puff", "peru", "pink", "plum", "powder_blue", "purple", "red", "rosy_brown", "royal_blue", "saddle_brown", "salmon", "sandy_brown", "sea_green", "sea_shell", "sienna", "silver", "sky_blue", "slate_blue", "slate_gray", "snow", "spring_green", "steel_blue", "swinburne_red", "tan", "teal", "thistle", "tomato", "transparent", "turquoise", "violet", "wheat", "white", "white_smoke", "yellow", "yellow_green"];

// ------------------------------------------------------------------------------
// Functions
// ------------------------------------------------------------------------------

// ------------------------------------------------------------------------------
// Get a list of all the files in a directory and it's subdirectories
// ------------------------------------------------------------------------------
function getAllFiles(dir, allFilesList = [], baseDir = null) {
  if (baseDir === null) {
    baseDir = dir;
  }
  
  try {
    const files = fs.readdirSync(dir);
    files.forEach(file => {
      const name = path.join(dir, file);
      if (fs.statSync(name).isDirectory()) {
        getAllFiles(name, allFilesList, baseDir);
      } else {
        const relativePath = path.relative(baseDir, name).replace(/\\/g, '/');
        allFilesList.push(relativePath);
      }
    });
  } catch (err) {
    console.error(kleur.yellow(`Warning: Unable to access directory ${dir}`), err);
  }
  return allFilesList;
}

// ------------------------------------------------------------------------------
// Get list of all finished examples
// ------------------------------------------------------------------------------
function getAllFinishedExamples() {
  var apiJsonData;
  try {
    var apiData = fs.readFileSync(path.join(__dirname, "json-files/api.json"));
    apiJsonData = JSON.parse(apiData);
  } catch (error) {
    console.error(kleur.red("Error occurred when trying to parse API Json data: "), error);
    return [];
  }

  const categories = []
  for (const categoryKey in apiJsonData) {
    if (categoryKey != "types") {
      categories.push(categoryKey);
    }
  }

  const allExamples = [];

  categories.forEach((categoryKey) => {
    const categoryFilePath = path.join(path.dirname(__dirname), "public", "usage-examples", categoryKey);
    
    // Check if directory exists before processing
    if (fs.existsSync(categoryFilePath)) {
      const categoryFiles = getAllFiles(categoryFilePath);

      // Filter for .txt files
      const txtFiles = categoryFiles.filter(file => file.endsWith('.txt'));

      if (txtFiles.length > 0) {
        txtFiles.forEach((file) => {
          allExamples.push(file);
        });
      }
    }
  });

  return allExamples;
}

// ------------------------------------------------------------------------------
// Type Mappings
// ------------------------------------------------------------------------------
function Mappings(jsonData) {
  // Check if jsonData is valid
  if (!jsonData) return;

  for (const categoryKey in jsonData) {
    const category = jsonData[categoryKey];
    
    // Add checks for category properties
    if (category.typedefs) {
      category.typedefs.forEach((typedef) => {
        if (typedef.name) {
          const name = typedef.name.split("_")
            .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
            .join(" ");

          typeMappings[typedef.name] = `[\`${name}\`](/api/${categoryKey.toLowerCase().replace(/\s+/g, "-")}/#${name.toLowerCase().replace(/\s+/g, "-")})`;
        }
      });
    }
    
    if (category.structs) {
      category.structs.forEach((struct) => {
        if (struct.name) {
          const name = struct.name.split("_")
            .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
            .join(" ");

          typeMappings[struct.name] = `[\`${name}\`](/api/${categoryKey.toLowerCase().replace(/\s+/g, "-")}/#${name.toLowerCase().replace(/\s+/g, "-")})`;
        }
      });
    }
    
    if (category.enums) {
      category.enums.forEach((enumm) => {
        if (enumm.name) {
          const name = enumm.name.split("_")
            .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
            .join(" ");

          typeMappings[enumm.name] = `[\`${name}\`](/api/${categoryKey.toLowerCase().replace(/\s+/g, "-")}/#${name.toLowerCase().replace(/\s+/g, "-")})`;
        }
      });
    }
  }
}

// ------------------------------------------------------------------------------
// Regex pattern for extracting the enums from the api.json signatures
// ------------------------------------------------------------------------------
function extractEnumValues(signature, language) {
  const details = [];
  let regex;

  if (language === 'cpp') {
    regex = /(\w+)\s*=\s*/g;
  } else {
    regex = /(\w+\.\w+)\s*=\s*/g;
  }

  let match;
  while ((match = regex.exec(signature)) !== null) {
    details.push(match[1]);
  }
  return details;
}

// ------------------------------------------------------------------------------
// Get Color RGB values from json file
// ------------------------------------------------------------------------------
function getColorRGBValues(colorName, jsonData) {
  const simplifiedName = colorName.replace("color_", "");

  const colorData = jsonData[simplifiedName];
  let rgbValues = '( 0, 0, 0)';
  if (colorData != undefined) {
    rgbValues = colorData.rgb;
  }
  return rgbValues;
}

// ------------------------------------------------------------------------------
// Get JSON data from .json file
// ------------------------------------------------------------------------------
function getJsonData(jsonFileName) {
  var jsonFile;
  var jsonData;
  try {
    jsonFile = fs.readFileSync(path.join(__dirname, "json-files", jsonFileName));
  } catch (err) {
    console.error(kleur.red("Error reading JSON file:"), err);
    return null;
  }
  try {
    jsonData = JSON.parse(jsonFile);
  } catch (error) {
    console.error(kleur.red("Error parsing JSON:"), error);
    return null;
  }
  return jsonData;
}

// ------------------------------------------------------------------------------
// Get API categories from JSON data
// ------------------------------------------------------------------------------
function getApiCategories(jsonData) {
  const apiCategories = [];
  if (!jsonData) return apiCategories;
  
  for (const categoryKey in jsonData) {
    if (categoryKey != "types") {
      apiCategories.push(jsonData[categoryKey]);
    }
  }
  return apiCategories;
}

// ------------------------------------------------------------------------------
// Import Code for Usage example content
// ------------------------------------------------------------------------------
function getUsageExampleImports(categoryKey, functionKey) {
  let mdxData = "";
  // Use a relative path from the generated MDX file (src/content/docs/api) to the public folder
  // so that raw imports resolve correctly during the Astro/Vite build.
  let categoryPath = '../../../public/usage-examples/' + categoryKey;
  let categoryFilePath = path.join('./public/usage-examples/', categoryKey);

  // Check if directory exists
  if (!fs.existsSync(categoryFilePath)) {
    return mdxData;
  }

  const functionFiles = getAllFiles(categoryFilePath).filter(file => file.startsWith(functionKey));
  if (functionFiles.length > 0) {
    const txtFiles = functionFiles.filter(file => file.endsWith('.txt'))
    if (txtFiles.length > 0) {
      txtFiles.forEach((exampleTxtKey) => {
        let exampleKey = exampleTxtKey.replace(/\.txt$/, "");

        let importTitle = exampleKey.replace(/-/g, "_");

        languageOrder.forEach((lang) => {
          const languageFiles = functionFiles.filter(file => file.endsWith(languageFileExtensions[lang]));
          let codeFilePath = categoryPath + "/" + exampleTxtKey.replace(/\.txt$/, languageFileExtensions[lang]);

          if (languageFiles.length > 0) {
            // Check if both top level and oop code has been found for current function
            const csharpFiles = functionFiles.filter(file => file.endsWith("-top-level.cs") || file.endsWith("-oop.cs")).filter(file => file.includes(exampleKey));
            const cppFiles = functionFiles.filter(file => file.endsWith("-sk.cpp") || file.endsWith("-beyond.cpp")).filter(file => file.includes(exampleKey));
            
            if (lang == "csharp" && csharpFiles.length > 0) {
              csharpFiles.forEach(file => {
                if (file.includes(exampleKey)) {
                  if (file.includes("-top-level")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-top-level.cs"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      mdxData += `import ${importTitle}_top_level_${lang} from '${codeFilePath.replace(/\.cs$/, "-top-level.cs")}?raw';\n`;
                    }
                  }
                  if (file.includes("-oop")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-oop.cs"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      mdxData += `import ${importTitle}_oop_${lang} from '${codeFilePath.replace(/\.cs$/, "-oop.cs")}?raw';\n`;
                    }
                  }
                }
              });
            } else if (lang == "cpp" && cppFiles.length > 0) {
              cppFiles.forEach(file => {
                if (file.includes(exampleKey)) {
                  if (file.includes("-sk")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-sk.cpp"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      mdxData += `import ${importTitle}_sk_${lang} from '${codeFilePath.replace(/\.cpp$/, "-sk.cpp")}?raw';\n`;
                    }
                  }
                  if (file.includes("-beyond")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-beyond.cpp"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      mdxData += `import ${importTitle}_beyond_${lang} from '${codeFilePath.replace(/\.cpp$/, "-beyond.cpp")}?raw';\n`;
                    }
                  }
                }
              });
            } else {
              const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, languageFileExtensions[lang]));
              if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                mdxData += `import ${importTitle}_${lang} from '${codeFilePath}?raw';\n`;
              }
            }
          }
        });
      });
    }
  }
  mdxData += "\n";
  return mdxData;
}

// ------------------------------------------------------------------------------
// Get mdx string for Usage example content (with code tabs etc)
// ------------------------------------------------------------------------------
function getUsageExampleContent(jsonData, categoryKey, groupName, functionKey) {
  let mdxData = "";
  let categoryPath = '/usage-examples/' + categoryKey;
  let categoryFilePath = path.join('./public/usage-examples/', categoryKey);

  // Check if directory exists
  if (!fs.existsSync(categoryFilePath)) {
    return mdxData;
  }

  let exampleKey = functionKey.replace(/\.txt$/, "");
  const functionFiles = getAllFiles(categoryFilePath).filter(file => file.startsWith(exampleKey));

  if (functionFiles.length > 0) {
    const functionExampleFiles = functionFiles.filter(file => file.endsWith(".txt"));
    functionExampleFiles.forEach((exampleTxtKey) => {
      if (functionFiles.length > 0) {
        let importTitle = exampleKey.replace(/-/g, "_");

        // Description
        let exampleNum = exampleKey.replace(/\D/g, '');
        mdxData += `**Example ${exampleNum}**: `;
        
        try {
          let exampleTxt = fs.readFileSync(path.join(categoryFilePath, exampleTxtKey));
          mdxData += exampleTxt.toString();
        } catch (err) {
          console.error(kleur.red(`Error reading example file: ${exampleTxtKey}`), err);
          mdxData += "Example description not available.";
        }
        mdxData += "\n\n";

        // Code tabs
        mdxData += "<Tabs syncKey=\"code-language\">\n";
        languageOrder.forEach((lang) => {
          const languageFiles = functionFiles.filter(file => file.startsWith(exampleKey)).filter(file => file.endsWith(languageFileExtensions[lang]));

          if (languageFiles.length > 0) {
            const languageLabel = languageLabelMappings[lang] || lang;
            mdxData += `  <TabItem label="${languageLabel}">\n`;

            // Check if both top level and oop code has been found for current function
            const csharpFiles = functionFiles.filter(file => file.endsWith("-top-level.cs") || file.endsWith("-oop.cs")).filter(file => file.includes(exampleKey));
            const cppFiles = functionFiles.filter(file => file.endsWith("-sk.cpp") || file.endsWith("-beyond.cpp")).filter(file => file.includes(exampleKey));
            
            let functionTag = exampleKey.split("-")[0];
            if (lang == "cpp") {
              functionTag = groupName;
            }
            if (lang == "csharp") {
              functionTag = groupName.split("_")
                .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
                .join("");
            }
            
            if (lang == "csharp" && csharpFiles.length > 0) {
              // Render csharp-style inner tabs only if at least one of the specific files exists and is non-empty
              let csharpInner = "\n  <Tabs syncKey=\"csharp-style\">\n";
              csharpFiles.slice().reverse().forEach(file => {
                if (file.includes(exampleKey)) {
                  if (file.includes("-top-level")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-top-level.cs"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      csharpInner += `    <TabItem label=\"Top-level Statements\">\n`;
                      csharpInner += `      <Code code={${importTitle}_top_level_${lang}} lang=\"${lang}\" mark=\"${functionTag}\" />\n`;
                      csharpInner += "    </TabItem>\n";
                    }
                  }
                  if (file.includes("-oop")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-oop.cs"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                      csharpInner += `    <TabItem label=\"Object-Oriented\">\n`;
                      csharpInner += `      <Code code={${importTitle}_oop_${lang}} lang=\"${lang}\" mark=\"SplashKit.${functionTag}\" />\n`;
                      csharpInner += "    </TabItem>\n";
                    }
                  }
                }
              });
              csharpInner += "  </Tabs>\n\n";
              // Only append the inner tabs if they include at least one TabItem
              if (csharpInner.includes("<TabItem label=")) {
                mdxData += csharpInner;
                mdxData += "  </TabItem>\n";
              }
            } else if (lang == "cpp" && cppFiles.length > 0) {
              // For cpp variants (-sk/-beyond), only include if the corresponding file exists and is non-empty
              let cppIncluded = false;
              cppFiles.forEach(file => {
                if (file.includes(exampleKey)) {
                  if (file.includes("-sk")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-sk.cpp"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) cppIncluded = true;
                  }
                  if (file.includes("-beyond")) {
                    const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, "-beyond.cpp"));
                    if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) cppIncluded = true;
                  }
                }
              });
              if (cppIncluded) {
                mdxData += "  </TabItem>\n";
              }
            } else {
              const fullPath = path.join('./public/usage-examples/', categoryKey, exampleTxtKey.replace(/\.txt$/, languageFileExtensions[lang]));
              if (fs.existsSync(fullPath) && fs.statSync(fullPath).size > 0) {
                mdxData += `    <Code code={${importTitle}_${lang}} lang="${lang}" mark={"${functionTag}"} />\n`;
                mdxData += "  </TabItem>\n";
              }
            }
          }
        });
        mdxData += "</Tabs>\n\n";

        // Image or gif output
        mdxData += "**Output**:\n\n";

        let outputFilePath = categoryPath + "/" + exampleTxtKey;

        const imageFiles = functionFiles.filter(file => file.endsWith(exampleKey + '.png'));
        // Check for .png files
        if (imageFiles.length > 0) {
          outputFilePath = outputFilePath.replace(/\.txt$/, ".png");
          mdxData += `![${exampleKey} example](${outputFilePath})\n`
        } else {
          const gifFiles = functionFiles.filter(file => file.endsWith('.gif')).filter(file => file.startsWith(exampleKey));
          // Check for .gif files
          if (gifFiles.length > 0) {
            outputFilePath = outputFilePath.replace(/\.txt$/, ".gif");
            mdxData += `![${exampleKey} example](${outputFilePath})\n`
          } else {
            const webmFiles = functionFiles.filter(file => file.endsWith('.webm'));
            // Check for .webm files
            if (webmFiles.length > 0) {
              outputFilePath = outputFilePath.replace(/\.txt$/, ".webm");
              mdxData += `<video controls style="max-width:100%; margin:auto; margin-top:16px;">\n`
              mdxData += `\t<source src="${outputFilePath}" type="video/webm" />\n`
              mdxData += `</video>\n`
            } else {
              console.log(kleur.red("\nError: No image, gif or webm (audio) files found for " + exampleKey + " usage example"));
            }
          }
        }
      }
    });
  }
  return mdxData;
}

// ------------------------------------------------------------------------------
// Clean directory to remove all files except those in the exclusions list
// ------------------------------------------------------------------------------
function cleanDirectory(directory, exclusions) {
  if (!fs.existsSync(directory)) {
    console.log(kleur.yellow(`Directory does not exist: ${directory}`));
    return;
  }

  const files = fs.readdirSync(directory, { withFileTypes: true });
  files.forEach(file => {
    const fullPath = path.join(directory, file.name);
    if (file.isDirectory()) {
      cleanDirectory(fullPath, exclusions);
    } else if (!exclusions.includes(file.name)) {
      try {
        fs.unlinkSync(fullPath);
        console.log(kleur.red(`  Deleted: `) + kleur.dim(`${fullPath}`));
      } catch (err) {
        console.error(kleur.red(`Error deleting file: ${fullPath}`), err);
      }
    }
  });
}

// ==============================================================================
// ========================= START of main script ===============================
// ==============================================================================

console.log(kleur.cyan('------------------------------------------------------------------------------'));
console.log(kleur.magenta('API Documentation mdx pages Generation:'));
console.log(kleur.cyan('------------------------------------------------------------------------------\n'));

console.log('Cleaning up directory for API Documentation pages...');
cleanDirectory(directoryToClean, filesToKeep);

let success = true;
const jsonData = getJsonData("api.json");
const jsonColors = getJsonData("colors.json");
let guidesJson = getJsonData("guides.json");
let guidesCategories = getApiCategories(guidesJson);
const usageExamples = getAllFinishedExamples();

// Check if we have valid JSON data before proceeding
if (!jsonData) {
  console.error(kleur.red("Error: Could not load API JSON data. Exiting."));
  process.exit(1);
}

Mappings(jsonData);
console.log(`\nGenerating MDX files for API Documentation pages...\n`);

// Process each category
for (const categoryKey in jsonData) {
  const category = jsonData[categoryKey];
  
  // Skip the "types" category
  if (categoryKey === "types") continue;
  
  let mdxContent = "";
  name = categoryKey.split("_")
    .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
    .join(" ");
  
  const categoryFunctions = category.functions || [];
  const functionNames = categoryFunctions.map((func) => func.name);

  mdxContent += "---\n";
  mdxContent += `title: ${name}\n`;
  if (category.brief != "") { 
    mdxContent += `description: ${category.brief.replace(/\n/g, '')}\n`; 
  } else { 
    mdxContent += `description: Some description....\n`; 
  }
  mdxContent += "---\n\n";
  
  if (category.brief != "") {
    mdxContent += `:::tip[${name}]\n`;
    mdxContent += `${category.brief}\n`
    mdxContent += `:::\n`
  }
  
  mdxContent += `\nimport { Code, Tabs, TabItem, LinkCard, CardGrid, LinkButton } from "@astrojs/starlight/components";\nimport Accordion from '../../../components/Accordion.astro'\n`;
  
  if (guidesAvailable[categoryKey]) {
    mdxContent += "\n## \n";
    mdxContent += `## ${name} Guides\n`;
    mdxContent += `<LinkCard
        title="Using ${name}"
        description="Examples & Guides"
        href="/guides/${categoryKey}/"
        />\n\n`;
  }
  
  mdxContent += "\n";
  mdxContent += "## Functions\n";
  
  const functionGroups = {};
  categoryFunctions.forEach((func) => {
    const functionName = func.name;
    if (!functionGroups[functionName]) {
      functionGroups[functionName] = [];
    }
    functionGroups[functionName].push(func);
  });

  for (const functionName in functionGroups) {
    const overloads = functionGroups[functionName];
    const isOverloaded = overloads.length > 1;

    // Create a section for overloaded functions
    if (isOverloaded) {
      const hasExampleInGroup = functionGroups[functionName].some((func) =>
        usageExamples.some((example) => example.endsWith(func.unique_global_name + "-1-example.txt"))
      );

      const hasGuideInGroup = functionGroups[functionName].some((func) =>
        guidesCategories.some((category) =>
          category.some((guide) =>
            guide.functions && guide.functions.includes(func.unique_global_name)
          )
        )
      );

      const formattedFunctionName = functionName
        .split("_")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ");
      const formattedLink = formattedFunctionName.toLowerCase().replace(/\s+/g, "-");

      const hasSymbol = (hasExampleInGroup || hasGuideInGroup) ? `&nbsp;&nbsp;&lcub;&lt;/&gt;&rcub;` : "";
      const formattedGroupLink = `${formattedLink}-functions`;

      mdxContent += `\n### [${formattedFunctionName}](#${formattedGroupLink})${hasSymbol} \\{#${formattedGroupLink}\\}\n\n`;

      mdxContent += ":::note\n\n";
      mdxContent += "This function is overloaded. The following versions exist:\n\n";

      overloads.forEach((func, index) => {
        mdxContent += `- [**${formattedFunctionName}** (`;

        var paramCount = Object.keys(func.parameters || {}).length;
        var paramNumber = 1;

        for (const paramName in func.parameters) {
          const param = func.parameters[paramName];
          const paramType = param.type;
          
          mdxContent += `${paramName}: ${paramType}`;
          if (paramNumber < paramCount) {
            mdxContent += ", "
          }
          paramNumber++;
        }
        
        const formattedUniqueLink = func.unique_global_name.toLowerCase().replace(/_/g, "-");
        mdxContent += `)](/api/${categoryKey}/#${formattedUniqueLink})`;

        // Put bolded {</>} symbol at the end of heading link if function has a usage example
        const hasExample = usageExamples.some(example => example.endsWith(func.unique_global_name + "-1-example.txt"));
        const hasGuide = guidesCategories.some((category) => 
          category.some((guide) => guide.functions && guide.functions.includes(func.unique_global_name))
        );

        if (hasExample || hasGuide) {
          mdxContent += "&nbsp;&nbsp;<strong>&lcub;&lt;/&gt;&rcub;</strong>";
        }

        mdxContent += `\n`;
      });

      mdxContent += "\n:::\n";
    }

    overloads.forEach((func, index) => {
      // Format the header based on whether it's overloaded or not
      let functionName2 = functionName.split("_")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ");
      
      const formattedName3 = func.name
        .split("_")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ");

      const formattedLink = formattedName3.toLowerCase().replace(/\s+/g, "-");
      const formattedUniqueLink = func.unique_global_name.toLowerCase().replace(/_/g, "-");
      const hasExample = usageExamples.some(example => example.endsWith(func.unique_global_name + "-1-example.txt"));
      const hasGuide = guidesCategories.some((category) => 
        category.some((guide) => guide.functions && guide.functions.includes(func.unique_global_name))
      );

      // Put {</>} symbol at the end of headers of overloaded functions with usage example or else just keep empty
      const formattedName = isOverloaded
        ? `\n#### [${functionName2}](#${formattedUniqueLink})${(hasExample || hasGuide) ? '&nbsp;&nbsp;&lcub;&lt;/&gt;&rcub;' : ''} \\{#${formattedUniqueLink}\\}`
        : `\n### [${functionName2}](#${formattedLink})${(hasExample || hasGuide) ? '&nbsp;&nbsp;&lcub;&lt;/&gt;&rcub;' : ''}`;

      // Replace type names in the description with formatted versions
      let description = func.description || "";
      for (const typeName in typeMappings) {
        const typeMapping = typeMappings[typeName];
        description = description.replace(
          new RegExp(`\`\\b${typeName}\\b\``, "g"),
          typeMapping
        );
      }

      // Color boxes next to heading
      if (functionName.startsWith("color_") && sk_colors.includes(functionName.replace("color_", ""))) {
        mdxContent += `\n#### <span style="display:none;">${functionName2}</span>\n`
        mdxContent += `${formattedName}`;
        const rgbValues = getColorRGBValues(functionName, jsonColors);
        mdxContent += ` <div class='color-box' style="background:rgba${rgbValues}"></div>`
      } else {
        mdxContent += `${formattedName}`;
      }

      mdxContent += "\n\n";

      for (const names of functionNames) {
        const normalName = names
          .split("_")
          .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
          .join(" ");
        const formattedLink = normalName.toLowerCase().replace(/\s+/g, "-");
        const link = `[\`${normalName}\`](/api/${categoryKey}/#${formattedLink})`
        description = description.replace(new RegExp(`\`\\b${names}\\b\``, "g"), link);
        description = description.replaceAll("\n", " ");
      }
      mdxContent += description ? `${description}\n\n` : "";

      // Add Parameters section only if there are parameters
      if (func.parameters && Object.keys(func.parameters).length > 0) {
        mdxContent += "**Parameters:**\n\n";
        mdxContent += `<div class="function-parameters-list">\n\n`;
        mdxContent +=
          "| Name   | Type                                               | Description                                                                        |\n";
        mdxContent +=
          "| ------ | -------------------------------------------------- | ---------------------------------------------------------------------------------- |\n";

        for (const paramName in func.parameters) {
          const param = func.parameters[paramName];
          let paramType = typeMappings[param.type] || param.type;
          if (paramType == 'unsigned int') {
            paramType = "`Unsigned Integer`";
          }
          let description2 = param.description || "";
          for (const typeName in typeMappings) {
            const typeMapping = typeMappings[typeName];

            description2 = description2.replace(
              new RegExp(`\`\\b${typeName}\\b\``, "g"),
              typeMapping
            );
          }

          for (const names of functionNames) {
            const normalName = names
              .split("_")
              .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
              .join(" ");
            const formattedLink = normalName.toLowerCase().replace(/\s+/g, "-");
            const link = `[\`${normalName}\`](/api/${categoryKey}/#${formattedLink})`
            description2 = description2.replace(new RegExp(`\`\\b${names}\\b\``, "g"), link);
            description2 = description2.replaceAll("\n", " ");
          }

          mdxContent += `| ${paramName} | ${paramType} | ${description2} |\n`;
        }

        mdxContent += "\n";
        mdxContent += `</div>\n\n`;
      }
      
      if (func.return) {
        if (func.return.type == 'unsigned int') {
          mdxContent += "**Return Type:** Unsigned Integer\n\n";
        } else if (func.return.type != 'void') {
          mdxContent += "**Return Type:** " + (typeMappings[func.return.type] || func.return.type) + "\n\n";

          mdxContent += "*Returns:* ";
          let returnDescription = func.return.description || "";
          for (const typeName in typeMappings) {
            const typeMapping = typeMappings[typeName];

            returnDescription = returnDescription.replace(
              new RegExp(`\`\\b${typeName}\\b\``, "g"),
              typeMapping
            );
          }

          mdxContent += `${returnDescription}\n\n`;
        }
      }

      mdxContent += "**Signatures:**\n\n";
      mdxContent += "<Tabs syncKey=\"code-language\">\n";

      // Reorder Code tabs
      languageOrder.forEach((lang) => {
        if (func.signatures && func.signatures[lang] && func.signatures[lang].length > 0) {
          try {
            const code = (Array.isArray(func.signatures[lang])) ? func.signatures[lang].join("\n") : func.signatures[lang];
            const languageLabel = languageLabelMappings[lang] || lang;
            mdxContent += `  <TabItem label="${languageLabel}">\n`;
            mdxContent +=
              "\n```" + lang + "\n" + code + '\n```\n\n";
            mdxContent += "  </TabItem>\n";
          } catch (e) {
            console.log(e + " " + lang + " " + func.name)
          }
        }
      });

      mdxContent += "</Tabs>\n\n";

      let usageHeading = false;
      let allGuides = [];
      
      if (guidesCategories) {
        guidesCategories.forEach((category) => {
          category.forEach((guide) => {
            if (guide.functions) {
              guide.functions.forEach((used) => {
                if (func.unique_global_name == used) {
                  allGuides.push({
                    name: guide.name,
                    url: guide.url
                  });
                }
              })
            }
          })
        })
      }

      if (allGuides.length > 0) {
        if (!usageHeading) {
          mdxContent += "**Usage:&nbsp;&nbsp;&lcub;&lt;/&gt;&rcub;**\n\n";
          usageHeading = true;
        }
        mdxContent += `<Accordion title="See Implementations in Guides" uniqueID={${JSON.stringify(func.unique_global_name + "_guides")}} customButton="guidesAccordion">\n\n`

        mdxContent += `<ul>`
        allGuides.forEach((guide) => {
          mdxContent += `<li> [${guide.name}](${guide.url}) </li>`
        })
        mdxContent += `</ul>\n\n`

        mdxContent += `</Accordion>\n\n`
      }

      let linked = false;
      usageExamples.forEach((example) => {
        if (func.unique_global_name == example.split('-')[0]) {
          if (!usageHeading) {
            mdxContent += "**Usage:&nbsp;&nbsp;&lcub;&lt;/&gt;&rcub;**\n\n";
            usageHeading = true;
          }
          mdxContent += getUsageExampleImports(categoryKey, example.replace(".txt", ""));
          if (!linked) {
            // Import code files
            mdxContent += `<Accordion title="See Code Examples" uniqueID={${JSON.stringify(func.unique_global_name + "_example")}} customButton="usageExamplesAccordion">\n\n`;
            linked = true;
          }

          mdxContent += getUsageExampleContent(jsonData, categoryKey, func.name, example);
          mdxContent += `\n`;
        }
      });
      if (linked) {
        mdxContent += `</Accordion>\n`;
      }

      mdxContent += "---\n";
    });
  }

  let allTypes = [];
  
  // Safely add types if they exist
  if (category.typedefs) allTypes.push(...category.typedefs);
  if (category.enums) allTypes.push(...category.enums);
  if (category.structs) allTypes.push(...category.structs);
  
  // Remove empty arrays and items without names
  allTypes = allTypes.filter((type) => type && type.name);

  const sortedTypes = allTypes.sort((a, b) => a.name.localeCompare(b.name));

  if (sortedTypes.length > 0) {
    // Add the Types section
    mdxContent += "\n## Types\n";

    sortedTypes.forEach((type) => {
      const formattedName = type.name
        .split("_")
        .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
        .join(" ");

      const formattedTypeName = formattedName || `\`${type.name}\``;
      let formattedLinkName = type.name.toLowerCase();
      formattedLinkName = formattedLinkName.replaceAll("_", "-");
      mdxContent += `\n### [${formattedTypeName}](#${formattedLinkName})\n\n`;

      let description = type.description || "";
      for (const typeName in typeMappings) {
        const typeMapping = typeMappings[typeName];
        description = description.replace(new RegExp(`\`\\b${typeName}\\b\``, "g"), typeMapping);
      }

      for (const names of functionNames) {
        const normalName = names
          .split("_")
          .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
          .join(" ");
        const formattedLink = normalName.toLowerCase().replace(/\s+/g, "-");
        const link = `[\`${normalName}\`](/api/${categoryKey}/#${formattedLink})`

        description = description.replace(new RegExp(`\`\\b${names}\\b\``, "g"), link);
      }

      // If it's a struct, add a table for its fields
      if (type.fields) {
        mdxContent +=
          "| Field  | Type                                               | Description                                                                        |\n";
        mdxContent +=
          "| ------ | -------------------------------------------------- | ---------------------------------------------------------------------------------- |\n";

        for (const fieldName in type.fields) {
          const field = type.fields[fieldName];
          const fieldType = typeMappings[field.type] || field.type;
          let fieldDescription = field.description || "";

          for (const typeName in typeMappings) {
            const typeMapping = typeMappings[typeName];
            fieldDescription = fieldDescription.replace(
              new RegExp(`\`\\b${typeName}\\b\``, "g"),
              typeMapping
            );
          }
          for (const names of functionNames) {
            const normalName = names
              .split("_")
              .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
              .join(" ");
            const formattedLink = normalName.toLowerCase().replace(/\s+/g, "-");
            const link = `[\`${normalName}\`](/api/${categoryKey}/#${formattedLink})`
            description = description.replace(new RegExp(`\`\\b${names}\\b\``, "g"), link);
          }

          mdxContent += `| ${fieldName} | ${fieldType} | ${fieldDescription.replace(/\n/g, '')} |\n`;
        }

        mdxContent += "\n";
      }

      for (const typeName in typeMappings) {
        const typeMapping = typeMappings[typeName];
        description = description.replace(new RegExp(`\`\\b${typeName}\\b\``, "g"), typeMapping);
      }
      for (const names of functionNames) {
        const normalName = names
          .split("_")
          .map((word) => word.charAt(0).toUpperCase() + word.slice(1))
          .join(" ");
        const formattedLink = normalName.toLowerCase().replace(/\s+/g, "-");
        const link = `[\`${normalName}\`](/api/${categoryKey}/#${formattedLink})`
        description = description.replace(new RegExp(`\`\\b${names}\\b\``, "g"), link);
      }
      description = description.replaceAll("\n\n\n", "\n\n");
      mdxContent += `${description}\n\n`;

      // If it's an enum, add a table for its constants
      if (type.constants) {
        mdxContent += "<Tabs syncKey=\"code-language\">\n";

        // Build constantsData from type.constants so that they remain the same in all tabs
        const constantsData = {};
        Object.keys(type.constants).forEach((constantName) => {
          const constant = type.constants[constantName];
          constantsData[constantName] = {
            description: constant.description ? constant.description.replace(/\n/g, '') : "No description"
          };
        });

        // Iterate over each language
        languageOrder.forEach(lang => {
          if (type.signatures && type.signatures[lang]) {
            const signature = Array.isArray(type.signatures[lang]) ? type.signatures[lang].join("\n") : type.signatures[lang];
            const enumValues = extractEnumValues(signature, lang);

            // Build the mapping so that each constant has its own name, but the description remains the same
            const formattedNames = {};
            const cppNames = Object.keys(type.constants);
            cppNames.forEach((cppName, index) => {
              formattedNames[cppName] = enumValues[index] || cppName;
            });

            mdxContent += `  <TabItem label="${languageLabelMappings[lang] || lang}">\n`;
            mdxContent += "| Constant | Description |\n";
            mdxContent += "| --------- | ----------- |\n";

            // Keep the description the same for all constants using the constantsData object
            Object.keys(constantsData).forEach((cppName) => {
              const formattedName = formattedNames[cppName] || cppName;
              const data = constantsData[cppName];
              mdxContent += `| ${formattedName} | ${data.description} |\n`;
            });

            mdxContent += "  </TabItem>\n";
          }
        });

        mdxContent += "</Tabs>\n";
      }

      mdxContent += `\n---\n`;
    });
  }

  // Replace spaces with underscores in the name
  const formattedName = name.replace(/\s+/g, '-');

  // Write the MDX file
  try {
    const outputDir = path.dirname(`./src/content/docs/api/${formattedName}.mdx`);
    if (!fs.existsSync(outputDir)) {
      fs.mkdirSync(outputDir, { recursive: true });
    }
    
    fs.writeFileSync(`./src/content/docs/api/${formattedName}.mdx`, mdxContent);
    console.log(kleur.yellow('  Generated: ') + kleur.green(`${formattedName}.mdx`));
  } catch (err) {
    success = false;
    console.log(kleur.red(`Error writing ${categoryKey} MDX file: ${err.message}`));
  }
}

// Check if all MDX files generated successfully
if (success) {
  console.log(kleur.green("\nAll API Documentation MDX files generated successfully.\n"));
} else {
  console.log(kleur.yellow("\nSome API Documentation MDX files may not have been generated successfully.\n"));
}