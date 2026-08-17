param (
    [string]$Configuration,
    [string]$AssemblyInfoPath
)

# 1. Clear Read-Only attribute if source control (like SVN) has locked it
$fileInfo = Get-Item $AssemblyInfoPath
if ($fileInfo.IsReadOnly) {
    $fileInfo.IsReadOnly = $false
}

# 2. Use .NET classes to ensure the file handle is completely closed after reading
$content = [System.IO.File]::ReadAllText($AssemblyInfoPath)

$versionRegex = '(?m)^\[assembly:\s*AssemblyVersion\("(\d+)\.(\d+)\.(\d+)\.(\d+)"\)\]'
$fileVersionRegex = '(?m)^\[assembly:\s*AssemblyFileVersion\("(\d+)\.(\d+)\.(\d+)\.(\d+)"\)\]'

if ($content -match $versionRegex) {
    $major = [int]$matches[1]
    $release = [int]$matches[2]
    $patch = [int]$matches[3]
    $debug = [int]$matches[4]

    switch ($Configuration) {
        "Major"   { $major++; $release=0; $patch=0; $debug=0 }
        "Release" { $release++; $patch=0; $debug=0 }
        "Patch"   { $patch++; $debug=0 }
        "Debug"   { $debug++ }
    }

    $newVersion = "$major.$release.$patch.$debug"

    # Replace both Version and FileVersion globally in the string
    $content = $content -replace $versionRegex, "[assembly: AssemblyVersion(`"$newVersion`")]"
    $content = $content -replace $fileVersionRegex, "[assembly: AssemblyFileVersion(`"$newVersion`")]"

    # 3. Write all text back, which manages its own clean stream opening/closing
    [System.IO.File]::WriteAllText($AssemblyInfoPath, $content, [System.Text.Encoding]::UTF8)
}