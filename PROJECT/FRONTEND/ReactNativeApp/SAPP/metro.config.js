const path = require('path');
const { getDefaultConfig, mergeConfig } = require('@react-native/metro-config');

const defaultConfig = getDefaultConfig(__dirname);

const {
  resolver: { sourceExts, assetExts },
} = getDefaultConfig(__dirname);


const extraNodeModules = {
    'common': path.resolve(__dirname + '\\..\\..\\Common'),
  };
  const watchFolders = [
    path.resolve(__dirname ),
    path.resolve(__dirname + '\\..\\..\\Common'),
    "${__dirname}\\..\\.."
  ];
  const config = {
    transformer: {
      getTransformOptions: async () => ({
        transform: {
          experimentalImportSupport: false,
          inlineRequires: false,
        },
      }),
      babelTransformerPath: require.resolve('react-native-svg-transformer'),
    }, 
    resolver: {
      extraNodeModules,
      assetExts: assetExts.filter(ext => ext !== 'svg'),
      sourceExts: ['jsx','js','ts','tsx','json','svg'],
    },
    projectRoot: path.resolve(__dirname),
    watchFolders,
  };

  module.exports = mergeConfig(defaultConfig, config);
