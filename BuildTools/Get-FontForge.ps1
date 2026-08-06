if (-not (Get-ChildItem "$env:PROGRAMFILES\7-Zip\7z.exe")) {
    Write-Error "7-Zip must be installed in $env:PROGRAMFILES\7-Zip"
    exit 1
}

if (-not (Get-ChildItem "..\ExternalTools")) {
    New-Item -ItemType Directory -Path "..\ExternalTools"
}

if (-not (Get-ChildItem "..\ExternalTools\fontforge")) {

    #https://sourceforge.net/projects/fontforgebuilds/files/i686/Portable/FontForge-mingw-w64-i686-f8bbd6-r1.7z
    Invoke-WebRequest "https://netcologne.dl.sourceforge.net/project/fontforgebuilds/i686/Portable/FontForge-mingw-w64-i686-f8bbd6-r1.7z" -OutFile ..\ExternalTools\fontforge.7z

    Set-Location ..\ExternalTools\
    New-Item -ItemType Directory -Path fontforge
    Set-Location fontforge
    & "$env:PROGRAMFILES\7-Zip\7z.exe" x ..\fontforge.7z

    if (Test-Path "..\..\bin\x86\Release\ExternalTools\fontforge") {
        Remove-Item -Recurse -Force "..\..\bin\x86\Release\ExternalTools\fontforge"       
    }
    Copy-Item -Recurse -Force "..\fontforge" "..\..\bin\x86\Release\ExternalTools\fontforge"
}
else {
    Write-Host "..\ExternalTools\fontforge already exists"
}