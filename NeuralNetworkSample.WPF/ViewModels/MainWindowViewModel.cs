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
        public LineSeriesViewModel SigmoidFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.SigmoidFunction, Title = "シグモイド関数 (y = 1 /  (1 + e^-x))", Color = Colors.DarkOrange, MarkerType = MarkerType.Circle };
        public LineSeriesViewModel DifferentialSigmoidFunctionGraph { get; } = new LineSeriesViewModel { Coordinates = MathModel.DifferentialSigmoidFunction, Title = "シグモイド関数の微分 (y = sigmoid(x) * (1 - sigmoid(x)))", Color = Colors.DarkGreen, MarkerType = MarkerType.Circle };
    }

    class SampleDataViewModel
    {
        public LineSeriesViewModel Data { get; } = new LineSeriesViewModel { Coordinates = new SampleDataModel().Coordinates, Title = "座標データ", Color = Colors.DarkBlue };
    }

    class NeuralNetworkViewModel
    {
        NeuralNetworkModel neuralNetworkModel = new NeuralNetworkModel();

        public LineSeriesViewModel Fukui { get; private set; }
        public LineSeriesViewModel Others { get; private set; }

        public NeuralNetworkViewModel()
        {
            Fukui = new LineSeriesViewModel { Coordinates = neuralNetworkModel.FukuiCoordinates, Title = "福井", Color = Colors.Red };
            Others = new LineSeriesViewModel { Coordinates = neuralNetworkModel.OthersCoordinates, Title = "他都道府県", Color = Colors.Blue };
        }
    }

    class TrainingDataViewModel
    {
        TrainingDataModel trainingDataModelModel = new TrainingDataModel();

        public LineSeriesViewModel Fukui { get; private set; }
        public LineSeriesViewModel Others { get; private set; }

        public TrainingDataViewModel()
        {
            Fukui = new LineSeriesViewModel { Coordinates = trainingDataModelModel.LearningFukuiCoordinates, Title = "福井", Color = Colors.Red };
            Others = new LineSeriesViewModel { Coordinates = trainingDataModelModel.LearningOthersCoordinates, Title = "他都道府県", Color = Colors.Blue };
        }
    }

    class MachineLearningViewModel
    {
        MachineLearningModel machineLearningModel = new MachineLearningModel();

        public LineSeriesViewModel TrainingFukui { get; private set; }
        public LineSeriesViewModel TrainingOthers { get; private set; }
        public LineSeriesViewModel TestFukui { get; private set; }
        public LineSeriesViewModel TestOthers { get; private set; }

        public MachineLearningViewModel()
        {
            TrainingFukui = new LineSeriesViewModel { Coordinates = machineLearningModel.TrainingFukuiCoordinates, Title = "福井 教師データ", Color = Colors.Red, MarkerType = MarkerType.Plus };
            TrainingOthers = new LineSeriesViewModel { Coordinates = machineLearningModel.TrainingOthersCoordinates, Title = "他都道府県 教師データ", Color = Colors.Blue, MarkerType = MarkerType.Plus };
            TestFukui = new LineSeriesViewModel { Coordinates = machineLearningModel.TestFukuiCoordinates, Title = "福井 テストデータ", Color = Colors.DarkRed, MarkerType = MarkerType.Circle };
            TestOthers = new LineSeriesViewModel { Coordinates = machineLearningModel.TestOthersCoordinates, Title = "他都道府県 テストデータ", Color = Colors.DarkBlue, MarkerType = MarkerType.Circle };
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
