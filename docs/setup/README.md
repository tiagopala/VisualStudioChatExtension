# Setup

## Necessary Tools

- Install Visual Studio Extension ToolSet

    ![Visual Studio Extension ToolSet](/images/visual-studio-extension-development.png)

- Install [Extensibility Essentials](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.ExtensibilityEssentials2022)

    ![Extensibility Essentials](/images/extensibility-essentials-2022.png)

## Compilation + Experimental Instance

For testing purposes you can enable deployment of the extension when building the project, by:

1. `Project -> Right Click -> Properties -> VSIX`.

2. Enable `Deploy VSIX content to experimental instance for debugging` option.

**Prerequisites**

First, you need to add the devenv.exe file path at your system variables:

![devenv-file-path-system-environment-variables](/images/devenv-file-path-system-environment-variables.png)

After that, you can run an **experimental visual studio** to test your extensions without any potential damages to your "real" visual studio.

`powershell
devenv.exe /RootSuffix Exp
`

> Don't forget to add the parameter `/RootSuffix Exp`