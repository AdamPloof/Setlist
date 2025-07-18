const path = require('path');
const MiniCssExtractPlugin = require('mini-css-extract-plugin');

module.exports = {
    entry: './ClientApp/app.ts',
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'wwwroot/dist'),
        publicPath: '/dist/',
    },
    resolve: {
        extensions: ['.tsx', '.ts', '.js'],
    },
    module: {
        rules: [
            {
                test: /\.tsx?$/,
                exclude: /node_modules/,
                use: [
                    'ts-loader',
                    {
                        loader: 'babel-loader',
                        options: {
                            presets: [
                                ['@babel/preset-env', { targets: 'defaults' }],
                                ['@babel/preset-react', { runtime: 'automatic' }],
                                '@babel/preset-typescript'
                            ]
                        }
                    }
                ],
            },
            {
                test: /\.s[ac]ss$/i,
                use: [
                    MiniCssExtractPlugin.loader,
                    'css-loader',
                    {
                        loader: 'sass-loader',
                        options: {
                            sassOptions: {
                                silenceDeprecations: [
                                    'mixed-decls',
                                    'color-functions',
                                    'global-builtin',
                                    'import'
                                ]
                            }
                        }
                    }
                ],
            },
        ]
    },
    plugins: [
        new MiniCssExtractPlugin({ filename: 'bundle.css' }),
    ],
    mode: 'development'
};
