# CSharpNeuralNetworkSample-AI-decode
neural network sample in C# for Microsoft de:code 2018 AI sessions

C# でニューラルネットワークをフルスクラッチで書いて機械学習の原理を理解しよう

### 概要:
C# だけで機械学習の原理であるニューラルネットワークをフルスクラッチで書いてみるサンプルコードと説明。

### 狙い:
ニューラルネットワークを実装してみることで、機械学習の基礎をきちんと理解できる。機械学習を基礎から理解することができる。

### プロジェクト:

| プロジェクト | 名前空間 (namespace) | ソース コード | クラス | 説明 |
| --- | --- | --- | --- | --- |
| NeuralNetwork.Core | NeuralNetwork.Core | NeuralNetwork.cs | EnumerableExtension | 汎用拡張メソッド |
| NeuralNetwork.Core | NeuralNetwork.Core | NeuralNetwork.cs | Math | 数学 |
| NeuralNetwork.Core | NeuralNetwork.Core | NeuralNetwork.cs | Input | 入力 |
| NeuralNetwork.Core | NeuralNetwork.Core | NeuralNetwork.cs | Neuron | ニューロン |
| NeuralNetwork.Core | NeuralNetwork.Core | NeuralNetwork.cs | NeuralNetwork | ニューラル ネットワーク |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | Coordinate | 地名、緯度、経度を含む座標 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | MathModel | 数学モデル |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | DataModelBase | データ モデルのベース クラス |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | SampleDataModel | 座標データ モデル |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | NeuralNetworkModel | 訓練前のデータ モデル |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | TrainingDataModel | 教師データ モデル |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | MachineLearningModel | 教師データで機械学習後のモデル |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | LineSeriesViewModel | プロット用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MathViewModel | シグモイド関数表示用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | SampleDataViewModel | 座標データ表示用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | NeuralNetworkViewModel | 訓練前のデータ表示用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | TrainingDataViewModel | 教師データ表示用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MachineLearningViewModel | 教師データで機械学習後の表示用 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MainWindowViewModel | メイン画面全体の ViewModel |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml | MainWindow | メイン画面 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml.cs | MainWindow | メイン画面 |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml | App | アプリケーション |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml.cs | App | アプリケーション |
| NeuralNetworkSample.WPF |  | locations.csv |  | 座標データ ファイル (csv) |

![](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(01).png "学習後の中間層の重み")


![学習後の入力層の重み](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-15%20(01).png "学習後の入力層の重み")
![学習後の中間層の重み](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-15%20(02).png "学習後の中間層の重み")




=======
