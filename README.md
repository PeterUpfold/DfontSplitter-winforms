# DfontSplitter for Windows (Windows Forms version)

This program allows you to convert many Mac OS X .dfont file into the TTF files that Windows can make use of.

Please note you should only perform this process on fonts that you have the right to use. You are solely responsible for your actions with this program.

**If you just want to _use_ this program, download the installer from [https://peter.upfold.org.uk/projects/dfontsplitter](https://peter.upfold.org.uk/projects/dfontsplitter)**. This repository contains the source code for developer use.

[![DfontSplitter screenshot](https://raw.githubusercontent.com/PeterUpfold/DfontSplitter-winforms/main/dfontsplitter_screenshot.png)](https://peter.upfold.org.uk/projects/dfontsplitter)

## About

DfontSplitter is a graphical wrapper around the command line tool [Fondu](https://fondu.sourceforge.net) (a modified [fondu-win-dll](https://github.com/peterupfold/fondu-win-dll) is used in DfontSplitter) and also [FontForge](https://sourceforge.net/projects/fontforgebuilds). These tools support its font conversion functionality.

## Licence

Please see [LICENSE.md](https://github.com/PeterUpfold/DfontSplitter-winforms/blob/main/LICENSE.md) for more information.

## Developer Instructions

If you're a developer and want to work on this project, these instructions should help.

Please ensure you have 7-Zip installed in `%PROGRAMFILES%`. (This may require having the 64-bit version)

To set up a development environment to build this project, you will need to:

 * execute `BuildTools\Get-Fontforge.ps1` (ensuring you are in the `BuildTools` directory first) to get a compatible build of FontForge;
 * execute `BuildTools\Get-VCRedist.ps1` (`cd` back into the `BuildTools` directory first!) to pull down the VC++ redistributables. 

 You will now be able to open the `.sln` file in Visual Studio and build a debug or release version that will work correctly.

 (A Build Event runs `powershell -ExecutionPolicy bypass -Command Copy-Item -Recurse -Force "$(ProjectDir)\ExternalTools" "$(TargetDir)\ExternalTools"` to copy FontForge components to the output directory.)

 ### FontForge and the Inno Setup installer file

 If you desire to use a new build of FontForge, (you will have updated the URL in `Get-Fontforge.ps1`), you may need to regenerate the list of items for the Inno Setup file to build the installer which includes all the files in the FontForge distribution.

 For this, execute `BuildTools\Get-FontForgeISSEntries.ps1`. This creates a `Source` entry for each of the FontForge distribution files and outputs this to `fontforge-entries.txt`. Update the `DfontSplitter.iss` file with these entries.

 Some paths in `DfontSplitter.iss` will need updating with the root of your project -- `OutputDir`, `SourceDir`, `InfoBeforeFile`. _TODO can these be relative paths so this step can be avoided?_

 If you redistribute a modified version of DfontSplitter, please prominently label that the project is modified, or use a different project name entirely. This will help to avoid user confusion. Thank you.
