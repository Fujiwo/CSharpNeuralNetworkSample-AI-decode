using NeuralNetworkSample.WPF.Models;
using OxyPlot;
using System.Collections.Generic;
using System.Windows.Media;

namespace NeuralNetworkSample.WPF.ViewModels
{
    class LineSeriesViewModel
    {
        public List<DataPoint> Coordinates { get; set; }

        public string Title { get; set; } = "";

        public Color Color { get; set; } = Colors.Black;

        public MarkerType MarkerType { get; set; } = MarkerType.Plus;
    }

    class MathViewModel
    {
        public LineSeriesViewModel LinearFunctionGraph1 { get; } = new LineSeriesViewModel { Coordinates = MathModel.LinearFunction1, Title = "一次関数 (y = 2x - 1)", Color = Colors.Green, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel LinearFunctionGraph2 { get; } = new LineSeriesViewModel { Coordinates = MathModel.LinearFunction2, Title = "一次関数 (y = -3x + 10)", Color = Colors.Khaki, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel QuadraticFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.QuadraticFunction, Title = "二次関数 (y = x^2 - 10x + 10)", Color = Colors.Red, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel CubicFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.CubicFunction, Title = "三次関数 (y = x^3 - 10x^2 - 10x + 10)", Color = Colors.Blue, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel SigmoidFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.SigmoidFunction, Title = "シグモイド関数 (y = 1 /  (1 + e^-x))", Color = Colors.DarkOrange, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel DifferentialSigmoidFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.DifferentialSigmoidFunction, Title = "シグモイド関数の微分 (y = sigmoid(x) * (1 - sigmoid(x)))", Color = Colors.DarkGreen, MarkerType = MarkerType.Circle };
    }

    class SampleDataViewModel
    {
        public LineSeriesViewModel Data { get; } = new LineSeriesViewModel { Coordinates = new SampleDataModel().Coordinates, Title = "サンプル データ", Color = Colors.DarkBlue };
    }

    class NeuralNetworkViewModel
    {
        NeuralNetworkModel neuralNetworkModel = new NeuralNetworkModel();

        public LineSeriesViewModel Tokyo { get; private set; }
        public LineSeriesViewModel Kanagawa { get; private set; }

        public NeuralNetworkViewModel()
        {
            Tokyo = new LineSeriesViewModel { Coordinates = neuralNetworkModel.TokyoCoordinates, Title = "東京", Color = Colors.Red };
            Kanagawa = new LineSeriesViewModel { Coordinates = neuralNetworkModel.KanagawaCoordinates, Title = "神奈川", Color = Colors.Blue };
        }
    }

    class TrainingDataViewModel
    {
        TrainingDataModel trainingDataModelModel = new TrainingDataModel();

        public LineSeriesViewModel Tokyo { get; private set; }
        public LineSeriesViewModel Kanagawa { get; private set; }

        public TrainingDataViewModel()
        {
            Tokyo = new LineSeriesViewModel { Coordinates = trainingDataModelModel.LearningTokyoCoordinates, Title = "東京", Color = Colors.Red };
            Kanagawa = new LineSeriesViewModel { Coordinates = trainingDataModelModel.LearningKanagawaCoordinates, Title = "神奈川", Color = Colors.Blue };
        }
    }

    class MachineLearningViewModel
    {
        MachineLearningModel machineLearningModel = new MachineLearningModel();

        public LineSeriesViewModel TrainingTokyo { get; private set; }
        public LineSeriesViewModel TrainingKanagawa { get; private set; }
        public LineSeriesViewModel TestTokyo { get; private set; }
        public LineSeriesViewModel TestKanagawa { get; private set; }

        public MachineLearningViewModel()
        {
            TrainingTokyo = new LineSeriesViewModel { Coordinates = machineLearningModel.TrainingTokyoCoordinates, Title = "東京 教師データ", Color = Colors.Red, MarkerType = MarkerType.Plus };
            TrainingKanagawa = new LineSeriesViewModel { Coordinates = machineLearningModel.TrainingKanagawaCoordinates, Title = "神奈川 教師データ", Color = Colors.Blue, MarkerType = MarkerType.Plus };
            TestTokyo = new LineSeriesViewModel { Coordinates = machineLearningModel.TestTokyoCoordinates, Title = "東京 テストデータ", Color = Colors.DarkRed, MarkerType = MarkerType.Circle };
            TestKanagawa = new LineSeriesViewModel { Coordinates = machineLearningModel.TestKanagawaCoordinates, Title = "神奈川 テストデータ", Color = Colors.DarkBlue, MarkerType = MarkerType.Circle };
        }
    }

    class MainWindowViewModel
    {
        public MathViewModel Math { get; } = new MathViewModel();
        public SampleDataViewModel SampleData { get; } = new SampleDataViewModel();
        public NeuralNetworkViewModel NeuralNetwork { get; } = new NeuralNetworkViewModel();
        public TrainingDataViewModel TrainingData { get; } = new TrainingDataViewModel();
        public MachineLearningViewModel MachineLearning { get; } = new MachineLearningViewModel();
    }
}
