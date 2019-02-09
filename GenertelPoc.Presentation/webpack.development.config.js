const path = require('path');
const VueLoaderPlugin = require('vue-loader/lib/plugin');
const CleanWebPackPlugin = require('clean-webpack-plugin');
const bundleOutputDir = './wwwroot/dist';

module.exports = (env) => {

    return [{
        mode:'development',
        resolve: { extensions: [ '.js' ] },
        entry: { 'genertel': './ClientApp/boot.js' },
        optimization: {
            splitChunks: {
                cacheGroups: {
                    commons: {
                        test: /[\\/]node_modules[\\/]/,
                        name: 'vendors',
                        chunks: 'all'
                    }
                },
            }
        },
        output: {
            path: path.resolve(__dirname, bundleOutputDir),
            filename: '[name].js',
            publicPath: 'dist/'
        },
        module: {
            rules: [
                { test: /\.vue$/, include: /ClientApp/, loader: 'vue-loader' },
                { test: /\.css$/, use: [ 'style-loader', 'css-loader' ] },
                { test: /\.(png|jpg|jpeg|gif|svg)$/, use: 'url-loader?limit=25000' }
            ]
        },
        plugins: [
            new VueLoaderPlugin(),
            new CleanWebPackPlugin('wwwroot/dist'),
        ]
    }];
};
