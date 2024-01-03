pnpm build;

Write-Host "Copying to C# build folder...";
$src = "dist";
$dest = "..\bin\x64\Release";  # "Debug" or "Release"
Copy-Item -Path $src -Destination $dest -Recurse -Force
