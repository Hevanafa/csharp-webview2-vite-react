# C# + React + WebView2

03-01-2024


## Prerequisites

### Recommended

+ Visual Studio 2022
+ .NET Framework 4.8.1
+ Node.js (LTS v16.15.1)
+ Either yarn or pnpm for the React project

### Minimum

+ Visual Studio 2017 or later
+ .NET Framework 4.7.2 or later
+ Node.js (if it supports yarn or pnpm)
+ Either yarn or pnpm for the React project


## How to Start

1. Load the project with Visual Studio & let the IDE finish the installation of the dependencies,
2. Select **x64** as the processor architecture,
3. Open `react-src`,
4. Install the dependencies with either `yarn install` or `pnpm i`,
5. Start the local server with `pnpm dev` or `pnpm start`,
6. Run the project from Visual Studio.

Due to how `hostObjects` is used, the React project can only be run from the debugger, not on an external browser.


## How to Make the Distributable Version

1. In Visual Studio, change the target build from **Debug** to **Release**,
2. Build Solution (<key>Ctrl+Shift+B</key>),
3. Open `react-src`,
4. Execute the script `.\build_copy.ps1`, this script builds the React project & copies the `dist` folder to the Debug folder.  You can change this in the script.

