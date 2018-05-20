# CSharpNeuralNetworkSample-AI-decode
neural network sample in C# for Microsoft de:code 2018 AI sessions

C# でニューラルネットワークをスクラッチで書いて機械学習の原理を理解しよう

### 概要:


Microsoft [de:code 2018](https://www.microsoft.com/ja-jp/events/decode/2018/) で提供されるサンプル コードです。
次のセッションで説明します。

* [AI61 C# でニューラルネットワークをスクラッチで書いて機械学習の原理を理解しよう](https://www.event-marketing.jp/events/decode/2018/sess/Schedule_Detail.aspx?id=AI61&url=Schedule.aspx)
(2018/05/22 16:45 - 17:00)

C# で機械学習の原理であるニューラルネットワークをフルスクラッチで書いてみるサンプル コードと説明です。

ニューラルネットワークを実装してみることで、機械学習の基礎をきちんと理解できます。機械学習を基礎から理解することを目的としています。

### プロジェクト:

#### NeuralNetwork.Core

機械学習 (Machine Learning) のコアとなる部分です。

C# で少数のニューロンからなる小規模なニューラル ネットワークを作成しています。
ニューロンからの出力には、シグモイド関数を使います。

##### 名前空間 (namespace) - NeuralNetwork.Core

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| NeuralNetwork.cs | EnumerableExtension | 汎用拡張メソッド |
| | Math | 数学 |
| | Input | 入力 |
| | Neuron | ニューロン |
| | NeuralNetwork | ニューラル ネットワーク |

#### NeuralNetworkSample.WPF

上記ニューラル ネットワークを使用したサンプルです。

福井県とその周辺の実際の座標を用いて上記ニューラル ネットワークを訓練します。

教師データは、"locations.csv" で、地名、緯度、経度、福井県内かどうか、からなる 1,088点の座標データです。

訓練後のニューラル ネットワークに、テスト用の座標データを入力し、福井県の中の座標かどうかを判定させています。

表示するものは以下のものです。

* シグモイド関数のグラフ
* 全座標データのプロット
* 訓練前のニューラル ネットワークによる判定結果
* 教師データ
* 教師データで訓練後のニューラル ネットワークによる判定結果

このプログラムは WPF で作られており、MVVM (Model-View-ViewModel) パターンで構成されています。

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
| MainWindow.xaml | MainWindow | メイン画面 |
| MainWindow.xaml.cs | MainWindow | メイン画面 |

##### 名前空間 (namespace) - NeuralNetworkSample.WPF

| ソース コード | クラス | 説明 |
| --- | --- | --- |
| App.xaml | App | アプリケーション |
| App.xaml.cs | App | アプリケーション |

##### データ ファイルその他

| ファイル名 | 説明 |
| --- | --- |
| locations.csv | 座標データ ファイル (csv) |
| ClassDiagram.asta | クラス図 ([Astah](http://astah.change-vision.com) ファイル) |

##### クラス図

![クラス図](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-20%20(01).png "クラス図")

### 説明資料:

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
![Demo](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(19).png "Demo")
![C# によるニューロンの実装](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(20).png "C# によるニューロンの実装")
![C# によるニューラル ネットワークの実装](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(22).png "C# によるニューラル ネットワークの実装")
![C# によるニューラル ネットワークの実装 (続き)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(23).png "C# によるニューラル ネットワークの実装 (続き)")
![C# によるニューラル ネットワークの実装 (続き)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(24).png "C# によるニューラル ネットワークの実装 (続き)")
![C# によるニューラル ネットワークの実装 (続き)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(25).png "C# によるニューラル ネットワークの実装 (続き)")
![実行結果 (シグモイド関数)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(26).png "実行結果 (シグモイド関数)")
![実行結果 (座標データと訓練前)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(27).png "実行結果 (座標データと訓練前)")
![実行結果 (教師データと訓練後)](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(28).png "実行結果 (教師データと訓練後)")
![訓練前の重みの値](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(17).png "訓練前の重みの値")
![訓練後の重みの値](https://raw.githubusercontent.com/Fujiwo/CSharpNeuralNetworkSample-AI-decode/master/images/2018-05-16%20(18).png "訓練後の重みの値")

---

### 関連資料:

* [PredictStockPrice-AI-decode](https://github.com/Fujiwo/PredictStockPrice-AI-decode):
neural network sample in C# for Microsoft de:code 2018 AI sessions ([Microsoft Azure Machine Learning Studio](https://studio.azureml.net) による株価予想プログラム)

---
