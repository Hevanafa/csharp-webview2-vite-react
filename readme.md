# C# + WebView2 + Vite + React

03-01-2024

This is a project that makes use of React as the frontend and C# as the backend, similar to [Tauri](https://tauri.app/) & [Electron](https://www.electronjs.org/es/).

The React project is created with `pnpm create vite` command.  It uses React + TypeScript + SWC template and already has an example component & the function call to C#.

This project is meant to be a template for my future C# projects with React frontend ~~because I hate WPF's complexity~~.

If you're a VB .NET programmer, I'm planning to make a template with that language soon after this.


## Background

I was inspired by Rust Tauri because of how it uses WebView2, which is similar to Electron but has a smaller output EXE size.

If Tauri can do it, why can't C#?


## File List Overview

The C# project is the base project.

Everything inside `react-src` is the React project.


## Prerequisites

### Recommended

+ Visual Studio 2022
+ .NET Framework 4.8.1
+ Node.js (LTS v16.15.1)
+ Either [yarn](https://yarnpkg.com/) or [PNPM](https://pnpm.io/) for the React project

### Minimum

+ Visual Studio 2017 or later
+ .NET Framework 4.7.2 or later
+ Node.js (if it supports yarn or pnpm)
+ Either [yarn](https://yarnpkg.com/) or [PNPM](https://pnpm.io/) for the React project


## How to Start

1. Load the project with Visual Studio & let the IDE finish the installation of the dependencies,
2. Select **x64** as the processor architecture,
3. Open `react-src`,
4. Install the dependencies with either `yarn install` or `pnpm i`,
5. Start the local server with `pnpm dev` or `pnpm start`,
6. Run the project from Visual Studio.

Due to how `window.chrome.webview.hostObjects` is used, the React project can only be run from the Visual Studio debugger, not on an external browser.


## How to Make the Distributable Version

1. In Visual Studio, change the target build from **Debug** to **Release**,
2. Build Solution (<key>Ctrl+Shift+B</key>),
3. Open `react-src`,
4. Execute the script `.\build_copy.ps1`, this script builds the React project & copies the `dist` folder to the C# bin folder.  You can change this in the script (**Release** by default).

