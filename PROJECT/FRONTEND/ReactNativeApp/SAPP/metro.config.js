// Learn more https://docs.expo.io/guides/customizing-metro
const { getDefaultConfig } = require('expo/metro-config');


const {mergeConfig} = require('metro-config')
const path = require('path')

const projectRoot = path.join(__dirname,'../../../')

const base = getDefaultConfig(projectRoot)
const config = mergeConfig(base, {
  projectRoot: projectRoot,
  resolver: {
    unstable_enableSymlinks: true,
    unstable_enablePackageExports: true,
    sourceExts: ['js', 'jsx', 'ts', 'tsx', 'json'],
  },
  watchFolders: [
    // path.join(__dirname,'../../Common/services'),
    // path.join(__dirname,'../../Common/DTOs'),
  ],
})

module.exports = config;
