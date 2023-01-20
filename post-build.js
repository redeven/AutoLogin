const { existsSync, readFileSync, writeFileSync } = require("fs");
const path = require("path");
const buildPath = path.join('.', 'bin', 'x64', 'Release', 'AutoLogin');
const manifestPath = path.join(buildPath, 'AutoLogin.json');
const downloadPath = 'https://raw.githubusercontent.com/redeven/AutoLogin/master/bin/x64/Release/AutoLogin/latest.zip';
if (existsSync(manifestPath)) {
    const manifestString = readFileSync(manifestPath, 'utf-8');
    const manifest = JSON.parse(manifestString);
    manifest.LastUpdated = Math.floor(new Date().getTime() / 1000);
    manifest.DownloadLinkInstall = downloadPath;
    manifest.DownloadLinkTesting = downloadPath;
    manifest.DownloadLinkUpdate = downloadPath;
    const repository = [manifest];
    writeFileSync('repository.json', JSON.stringify(repository, null, 4), 'utf-8');
}