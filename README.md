# CSharpNeuralNetworkSample-AI-decode
neural network sample in C# for Microsoft de:code 2018 AI sessions

C# でニューラルネットワークをフルスクラッチで書いて機械学習の原理を理解しよう

### 概要:
C# だけで機械学習の原理であるニューラルネットワークをフルスクラッチで書いてみるサンプルコードと説明。

### 狙い:
ニューラルネットワークを実装してみることで、機械学習の基礎をきちんと理解できる。機械学習を基礎から理解することができる。

### プロジェクト:

#### NeuralNetwork.Core

ニューラル ネットワーク

##### 名前空間 (namespace) - NeuralNetwork.Core

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| NeuralNetwork.cs | EnumerableExtension | 汎用拡張メソッド |
| | Math | 数学 |
| | Input | 入力 |
| | Neuron | ニューロン |
| | NeuralNetwork | ニューラル ネットワーク |

#### NeuralNetworkSample.WPF

ニューラル ネットワークを使用したサンプル

##### 名前空間 (namespace) - NeuralNetworkSample.WPF.Models

モデル

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| Model.cs | Coordinate | 地名、緯度、経度を含む座標 |
| | MathModel | 数学モデル |
| | DataModelBase | データ モデルのベース クラス |
| | SampleDataModel | 座標データ モデル |
| | NeuralNetworkModel | 訓練前のデータ モデル |
| | TrainingDataModel | 教師データ モデル |
| | MachineLearningModel | 教師データで機械学習後のモデル |

##### 名前空間 (namespace) - NeuralNetworkSample.WPF.ViewModels

ビューモデル

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| MainWindowViewModel.cs | LineSeriesViewModel | プロット用 |
| | MathViewModel | シグモイド関数表示用 |
| | SampleDataViewModel | 座標データ表示用 |
| | NeuralNetworkViewModel | 訓練前のデータ表示用 |
| | TrainingDataViewModel | 教師データ表示用 |
| | MachineLearningViewModel | 教師データで機械学習後の表示用 |
| | MainWindowViewModel | メイン画面全体の ViewModel |

##### 名前空間 (namespace) - NeuralNetworkSample.WPF.View

ビュー

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml | MainWindow | メイン画面 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml.cs | MainWindow | メイン画面 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml | App | アプリケーション |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml.cs | App | アプリケーション |
| NeuralNetworkSample.WPF |  | locations.csv |  | 座標データ ファイル (csv) |

##### 名前空間 (namespace) - NeuralNetworkSample.WPF.View

ビュー

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| MainWindow.xaml | MainWindow | メイン画面 |
| MainWindow.xaml.cs | MainWindow | メイン画面 |

##### 名前空間 (namespace) - NeuralNetworkSample.WPF

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| App.xaml | App | アプリケーション |
| App.xaml.cs | App | アプリケーション |

##### データ ファイル

| ファイル名 | 説明 |
| --- | --- |
| locations.csv | 座標データ ファイル (csv) |

### 説明:

![C# でニューラルネットワークをスクラッチで書いて機械学習の原理を理解しよう](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(01).png "C# でニューラルネットワークをスクラッチで書いて機械学習の原理を理解しよう")
![機械学習 (Machine Learning) とは](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(02).png "機械学習 (Machine Learning) とは")
![まず 人工知能 (Artificial Intelligence) とは](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(03).png "まず 人工知能 (Artificial Intelligence) とは")
![機械学習とは](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(04).png "機械学習とは")
![機械学習の種類](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(05).png "機械学習の種類")
![ディープラーニング (深層学習: Deep Learning)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(06).png "ディープラーニング (深層学習: Deep Learning)")
![ディープ ラーニング](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(07).png "ディープ ラーニング")
![人工知能と機械学習](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(08).png "人工知能と機械学習")
![ニューラル ネットワークとは](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(09).png "ニューラル ネットワークとは")
![神経細胞のネットワーク](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(10).png "神経細胞のネットワーク")
![ニューラル ネットワーク](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(11).png "ニューラル ネットワーク")
![個々のニューロン](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(12).png "個々のニューロン")
![シグモイド関数](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(13).png "シグモイド関数")
![ニューラル ネットワークによる分類](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(14).png "ニューラル ネットワークによる分類")
![今回作成するニューラル ネットワーク](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(15).png "今回作成するニューラル ネットワーク")
![今回のニューラル ネットワークの訓練](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(16).png "今回のニューラル ネットワークの訓練")
![訓練前の重みの値](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(17).png "訓練前の重みの値")
![訓練後の重みの値](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(18).png "訓練後の重みの値")



=======
