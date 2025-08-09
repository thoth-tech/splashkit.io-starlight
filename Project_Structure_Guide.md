# SplashKit API 文档项目结构详解

## 📁 项目整体架构

```
splashkit.io-starlight/
├── scripts/                    # 🔧 构建脚本
│   ├── api-pages-script.cjs   # 主要的 API 文档生成脚本
│   └── json-files/            # 📄 数据源文件
│       └── api.json          # API 函数的元数据和描述
├── public/                     # 🎯 静态资源
│   └── usage-examples/        # 📝 代码示例文件
│       ├── animations/        # 按 API 分类组织
│       ├── geometry/          
│       ├── graphics/          
│       └── ...
└── src/                       # 🏗️ 源代码
    └── content/
        └── docs/
            └── api/           # 📖 生成的最终文档
                ├── Animations.mdx
                ├── Geometry.mdx
                └── ...
```

---

## 🔄 文档生成流程

### 第1步：数据源
**`scripts/json-files/api.json`** - 包含所有 API 的基础信息：

```json
{
  "animations": {
    "brief": "动画功能的简要描述",
    "description": "详细描述", 
    "functions": [
      {
        "name": "animation_count",
        "signature": "int animation_count(animation_script script);",
        "description": "函数的详细说明",
        "parameters": { "script": {...} },
        "return": { "type": "int", "description": "..." },
        "signatures": {
          "cpp": ["int animation_count(animation_script script)"],
          "python": ["def animation_count(script):"],
          "csharp": [...],
          "pascal": [...]
        }
      }
    ]
  }
}
```

### 第2步：代码示例文件
**`public/usage-examples/{category}/`** - 每个函数的完整示例：

```
center_point-1-example.txt     # 📄 示例标题/描述
center_point-1-example.cpp     # 🔷 C++ 代码
center_point-1-example.py      # 🐍 Python 代码  
center_point-1-example-oop.cs  # 🔷 C# 面向对象版本
center_point-1-example-top-level.cs # 🔷 C# 顶级语句版本
center_point-1-example.png     # 🖼️ 输出图片/动画
```

### 第3步：脚本处理
**`scripts/api-pages-script.cjs`** 执行以下操作：

1. **读取 JSON 数据** → 获取函数基本信息
2. **扫描示例文件** → 查找匹配的代码示例
3. **生成 MDX 内容** → 组合所有信息
4. **输出最终文档** → 创建 `src/content/docs/api/*.mdx`

---

## 📋 MDX 文档的组成部分

每个生成的 `.mdx` 文件包含以下部分：

### 1. 📑 头部信息 (来自 JSON)
```yaml
---
title: Animations
description: 动画功能描述...
---
```

### 2. 📝 分类概述 (来自 JSON)
```markdown
:::tip[Animations]
动画功能的详细介绍...
:::
```

### 3. 🔧 函数文档 (来自 JSON)
```markdown
### [Animation Count](#animation-count)

函数描述...

**Parameters:**
| Name | Type | Description |
|------|------|-------------|
| script | Animation Script | 参数描述... |

**Return Type:** Integer
**Signatures:** (多语言代码签名)
```

### 4. 💻 代码示例 (来自示例文件)
```markdown
**Usage: &nbsp;&nbsp;{</>}**

<Accordion title="See Code Examples">
  <Tabs syncKey="code-language">
    <TabItem label="C++">
      <Code code={center_point_cpp} lang="cpp" />
    </TabItem>
    <TabItem label="Python">  
      <Code code={center_point_python} lang="python" />
    </TabItem>
    <TabItem label="C#">
      <Tabs syncKey="csharp-style">
        <TabItem label="Top-level Statements">
          <Code code={center_point_top_level_csharp} lang="csharp" />
        </TabItem>
        <TabItem label="Object-Oriented">
          <Code code={center_point_oop_csharp} lang="csharp" />
        </TabItem>
      </Tabs>
    </TabItem>
  </Tabs>

  **Output:**
  ![center_point example](/usage-examples/geometry/center_point-1-example.png)
</Accordion>
```

---

## 🎯 各文件类型的作用

| 文件类型 | 作用 | 示例 |
|---------|------|------|
| **📄 .txt** | 示例标题/描述 | `"Glowing Circle"` |
| **🔷 .cpp** | C++ 完整代码示例 | 包含 `#include "splashkit.h"` 的完整程序 |
| **🐍 .py** | Python 完整代码示例 | 包含 `from splashkit import *` 的完整程序 |
| **🔷 -oop.cs** | C# 面向对象风格 | 使用 `SplashKit.Function()` 调用 |
| **🔷 -top-level.cs** | C# 顶级语句风格 | 直接调用 `Function()` |
| **🖼️ .png/.gif/.webm** | 输出效果展示 | 程序运行的视觉结果 |

---

## 🔄 添加新示例的完整流程

### 步骤1: 创建示例文件
```bash
# 在 public/usage-examples/animations/ 目录下创建：
animation_count-1-example.txt          # "Animation Counter"  
animation_count-1-example.cpp          # C++ 完整代码
animation_count-1-example.py           # Python 完整代码
animation_count-1-example-oop.cs       # C# OOP 版本
animation_count-1-example-top-level.cs # C# 顶级语句版本
animation_count-1-example.png          # 输出截图
```

### 步骤2: 运行生成脚本
```bash
node scripts/api-pages-script.cjs
```

### 步骤3: 验证结果
检查 `src/content/docs/api/Animations.mdx` 是否包含：
- ✅ "See Code Examples" 按钮
- ✅ 多语言代码标签页  
- ✅ "Output:" 图片展示

---

## 💡 关键理解点

1. **JSON 只是元数据** - 包含函数签名、描述、参数信息
2. **真正的代码示例来自单独文件** - 每种语言一个文件
3. **脚本负责组装** - 将 JSON + 示例文件 → 完整 MDX
4. **命名规则很重要** - `{function_name}-{number}-example.{extension}`
5. **输出文件决定展示效果** - .png(静态), .gif(动画), .webm(视频)

---

## 🚀 现在您可以：

1. **理解为什么 Animations 缺示例** - 因为 `public/usage-examples/animations/` 目录为空
2. **知道如何添加示例** - 创建对应的文件并运行脚本
3. **了解文档结构** - JSON 基础信息 + 示例文件 = 完整文档
4. **掌握标准格式** - 参考 Geometry 分类的文件结构
