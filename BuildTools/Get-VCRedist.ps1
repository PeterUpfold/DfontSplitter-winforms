if (-not (Get-ChildItem ".\VC_redist.x86.exe")) {
    Invoke-WebRequest "https://aka.ms/vs/16/release/vc_redist.x86.exe" -OutFile .\VC_redist.x86.exe
}