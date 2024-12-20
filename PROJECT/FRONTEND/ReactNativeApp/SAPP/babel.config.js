const path = require('path');

module.exports = function(api) {
  api.cache(true);
  return {
    presets: ['babel-preset-expo'],
    plugins: [
      ['module-resolver', {
        alias: {
          common: path.resolve(__dirname, '../../Common'),
        },
      }],
    ],
  };
};