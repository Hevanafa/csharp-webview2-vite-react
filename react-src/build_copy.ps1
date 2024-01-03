pnpm build;

Write-Host "Copying to debug folder...";
$src = "dist";
$dest = "..\bin\x64\Debug";
Copy-Item -Path $src -Destination $dest -Recurse -Force
