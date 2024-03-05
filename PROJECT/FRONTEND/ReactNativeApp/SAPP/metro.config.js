
const path = require('path');

module.exports = {
 transformer: {
   getTransformOptions: async () => ({
     transform: {
       experimentalImportSupport: false,
       inlineRequires: true,
     },
   }),
 },
 resolver: {
   sourceExts: ['js', 'json', 'ts', 'tsx', 'jsx'],
 },
 watchFolders: [
   path.resolve(__dirname, '../../Common'),
 ],
 projectRoot: path.resolve(__dirname),
};