if (-not (Get-ChildItem "$env:PROGRAMFILES\7-Zip\7z.exe")) {
    Write-Error "7-Zip must be installed in $env:PROGRAMFILES\7-Zip"
    exit 1
}

if (-not (Get-ChildItem "..\ExternalTools")) {
    New-Item -ItemType Directory -Path "..\ExternalTools"
}

if (-not (Get-ChildItem "..\ExternalTools\fontforge")) {

    Invoke-WebRequest "https://netcologne.dl.sourceforge.net/project/fontforgebuilds/i686/Portable/FontForge-mingw-w64-i686-e5275e-r1.7z" -OutFile ..\ExternalTools\fontforge.7z

    cd ..\ExternalTools\
    New-Item -ItemType Directory -Path fontforge
    cd fontforge
    & "$env:PROGRAMFILES\7-Zip\7z.exe" x ..\fontforge.7z

}