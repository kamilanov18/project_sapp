const path = require('path');

const extraNodeModules = {
    'common': path.resolve(__dirname + '/../../Common'),
  };
  const watchFolders = [
    path.resolve(__dirname + '/../../Common')
  ];
  module.exports = {
    transformer: {
      getTransformOptions: async () => ({
        transform: {
          experimentalImportSupport: false,
          inlineRequires: false,
        },
      }),
    }, 
    resolver: {
      extraNodeModules,
      sourceExts: ['jsx','js','ts','tsx','json','svg'],
    },
    projectRoot: path.resolve(__dirname),
    watchFolders,
  };