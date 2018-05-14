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
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | Coordinate | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | MathModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | DataModelBase | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | SampleDataModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | NeuralNetworkModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | TrainingDataModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Models | Model.cs | MachineLearningModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | LineSeriesViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MathViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | SampleDataViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | NeuralNetworkViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | TrainingDataViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MachineLearningViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.ViewModels | MainWindowViewModel.cs | MainWindowViewModel | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml | MainWindow | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF.Views | MainWindow.xaml.cs | MainWindow | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml | App | |
| NeuralNetworkSample.WPF | NeuralNetworkSample.WPF | App.xaml.cs | App | |
| NeuralNetworkSample.WPF |  | locations.csv |  | 座標データ ファイル (csv) |

=======
