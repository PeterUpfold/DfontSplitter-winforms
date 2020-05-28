$output = ""

Get-ChildItem ..\ExternalTools -Recurse -File | ForEach-Object {

    $relative_dir = $_
    $relative_dir = $relative_dir.ToString().Split("\")

    $relative_dir_rebuild = ""

    $ignore = $true
    $relative_dir | ForEach-Object {
        if (-not $ignore) {
            $relative_dir_rebuild += $_ + "\"
        }
        if ( $_ -eq "dfontsplitter-winforms") {
            $ignore = $false
        }
    }
    $relative_dir_rebuild = $relative_dir_rebuild.Substring(0, $relative_dir_rebuild.Length-1) # strip final \

    $relative_dest_dir = $relative_dir_rebuild.Substring(0, $relative_dir_rebuild.LastIndexOf("\"))

    $output += "Source: ""$relative_dir_rebuild""; DestDir: ""{app}\$relative_dest_dir""; Flags: ignoreversion
"
}

Set-Content -Path fontforge-entries.txt -Value $output