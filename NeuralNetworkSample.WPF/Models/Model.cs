using NeuralNetwork.Core;
using OxyPlot;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworkSample.WPF.Models
{
    public class Coordinate
    {
        public string Address { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double CorrectValue { get; set; }

        //public bool CloseTo(Coordinate coordinate, double range)
        //    => Distance(coordinate) <= range;

        //public double Distance(Coordinate coordinate)
        //    => System.Math.Sqrt(Math.Square(Latitude - coordinate.Latitude) + Math.Square(Longitude - coordinate.Longitude));

        public static Coordinate operator +(Coordinate coordinate1, Coordinate coordinate2)
            => new Coordinate { Latitude = coordinate1.Latitude + coordinate2.Latitude, Longitude = coordinate1.Longitude + coordinate2.Longitude, CorrectValue = coordinate1.CorrectValue };

        public static Coordinate operator -(Coordinate coordinate1, Coordinate coordinate2)
            => new Coordinate { Latitude = coordinate1.Latitude - coordinate2.Latitude, Longitude = coordinate1.Longitude - coordinate2.Longitude, CorrectValue = coordinate1.CorrectValue };
    }

    class MathModel
    {
        //public static List<DataPoint> LinearFunction1 => EnumerableExtension.Range(0.0, 10.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, 2.0 * x - 1.0)).ToList();
        //public static List<DataPoint> LinearFunction2 => EnumerableExtension.Range(0.0, 10.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, -3.0 * x + 10.0)).ToList();
        //public static List<DataPoint> QuadraticFunction => EnumerableExtension.Range(-5.0, 15.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, x * x - 10.0 * x + 10.0)).ToList();
        //public static List<DataPoint> CubicFunction => EnumerableExtension.Range(-5.0, 15.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, x * x * x - x * x - 10.0 * x + 10.0)).ToList();
        public static List<DataPoint> SigmoidFunction => EnumerableExtension.Range(-8.0, 8.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, Math.Sigmoid(x))).ToList();
        public static List<DataPoint> DifferentialSigmoidFunction => EnumerableExtension.Range(-8.0, 8.0, 0.1).Select<double, DataPoint>(x => new DataPoint(x, Math.DifferentialSigmoid(x))).ToList();
    }

    abstract class DataModelBase
    {
        const double range = 1.0;

        const string dataFileName = "locations.csv";
        //const string saveFileName = "locations.new.csv";

        //Coordinate centerCoordinate = new Coordinate { Latitude = 35.8, Longitude = 136.1 };
        protected Coordinate baseCoordinate = new Coordinate { Latitude = 34.5, Longitude = 137.5 };

        protected IEnumerable<Coordinate> OriginalCoordinates { get; private set; }

        public DataModelBase() => Load();

        protected static DataPoint ToDataPoint(Coordinate coordinate) => new DataPoint(coordinate.Longitude, coordinate.Latitude);

        //void Load() => OriginalCoordinates = Shos.CsvHelper.CsvSerializer.ReadCsv<Coordinate>(dataFileName).Where(coordinate => coordinate.CloseTo(centerCoordinate, range));
        void Load()
        {
            Shos.CsvHelper.CsvSerializer.Encoding = System.Text.Encoding.UTF8;
            //Shos.CsvHelper.CsvSerializer.Encoding = System.Text.Encoding.GetEncoding("Shift-JIS");
            OriginalCoordinates = Shos.CsvHelper.CsvSerializer.ReadCsv<Coordinate>(dataFileName); //.Where(coordinate => coordinate.CloseTo(centerCoordinate, range));
            //Shos.CsvHelper.CsvSerializer.Encoding = System.Text.Encoding.UTF8;
            //Shos.CsvHelper.CsvSerializer.WriteCsv<Coordinate>(OriginalCoordinates, saveFileName);
        }
    }

    class SampleDataModel : DataModelBase
    {
        public List<DataPoint> Coordinates { get; private set; }

        public SampleDataModel() => Load();

        void Load() => Coordinates = OriginalCoordinates.Select(coordinate => ToDataPoint(coordinate)).ToList();
    }

    class NeuralNetworkModel : SampleDataModel
    {
        public List<DataPoint> FukuiCoordinates { get; } = new List<DataPoint>();
        public List<DataPoint> OthersCoordinates { get; } = new List<DataPoint>();

        //const string dataFileName = "locations.csv";
        //Coordinate baseCoordinate = new Coordinate { Latitude = 34.5, Longitude = 137.5 }; // 35.8, 136.1 中心

        NeuralNetwork.Core.NeuralNetwork neuralNetwork = new NeuralNetwork.Core.NeuralNetwork();

        public NeuralNetworkModel() => Initialize(OriginalCoordinates.Select(coordinate => coordinate - baseCoordinate));

        //void Load() => Initialize(OriginalCoordinates);
        //{
        //    var coordinates = Shos.CsvHelper.CsvSerializer.ReadCsv<Coordinate>(dataFileName).Select(coordinate => coordinate - baseCoordinate);
        //    Initialize(coordinates);
        //}

        void Initialize(IEnumerable<Coordinate> coordinates)
        {
            FukuiCoordinates.Clear();
            OthersCoordinates.Clear();

            foreach (var coordinate in coordinates) {
                if (neuralNetwork.Commit((coordinate.Latitude, coordinate.Longitude)) < 0.5)
                    FukuiCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
                else
                    OthersCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
            }
        }

        //static DataPoint ToDataPoint(Coordinate coordinate) => new DataPoint(coordinate.Longitude, coordinate.Latitude);
    }

    class TrainingDataModel : SampleDataModel
    {
        public List<DataPoint> LearningFukuiCoordinates { get; } = new List<DataPoint>();
        public List<DataPoint> LearningOthersCoordinates { get; } = new List<DataPoint>();

        //const string dataFileName = "locations.csv";
        //Coordinate baseCoordinate = new Coordinate { Latitude = 34.5, Longitude = 137.5 }; // 35.8, 136.1 中心

        public TrainingDataModel() => Initialize(OriginalCoordinates.Select(coordinate => coordinate - baseCoordinate));

        //void Load()
        //{
        //    var coordinates = Shos.CsvHelper.CsvSerializer.ReadCsv<Coordinate>(dataFileName).Select(coordinate => coordinate - baseCoordinate);
        //    Initialize(coordinates);
        //}

        void Initialize(IEnumerable<Coordinate> coordinates)
        {
            LearningFukuiCoordinates.Clear();
            LearningOthersCoordinates.Clear();

            foreach (var coordinate in coordinates) {
                if (coordinate.CorrectValue < 0.5)
                    LearningFukuiCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
                else
                    LearningOthersCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
            }
        }
    }

    class MachineLearningModel : SampleDataModel
    {
        const int learningTimes = 1000;

        public List<DataPoint> TrainingFukuiCoordinates { get; } = new List<DataPoint>();
        public List<DataPoint> TrainingOthersCoordinates { get; } = new List<DataPoint>();
        public List<DataPoint> TestFukuiCoordinates { get; } = new List<DataPoint>();
        public List<DataPoint> TestOthersCoordinates { get; } = new List<DataPoint>();

        //const string dataFileName = "locations.csv";
        //Coordinate baseCoordinate = new Coordinate { Latitude = 34.5, Longitude = 137.5 }; // 35.8, 136.1 中心

        NeuralNetwork.Core.NeuralNetwork neuralNetwork = new NeuralNetwork.Core.NeuralNetwork();

        public MachineLearningModel() => Load();

        void Load()
        {
            //var coordinates = Shos.CsvHelper.CsvSerializer.ReadCsv<Coordinate>(dataFileName).Select(coordinate => coordinate - baseCoordinate);

            var coordinates = OriginalCoordinates.Select(coordinate => coordinate - baseCoordinate);
            InitializeTrainingData(coordinates);
            Learn(coordinates);
            Test();
        }

        void InitializeTrainingData(IEnumerable<Coordinate> coordinates)
        {
            TrainingFukuiCoordinates.Clear();
            TrainingOthersCoordinates.Clear();

            foreach (var coordinate in coordinates) {
                if (coordinate.CorrectValue < 0.5)
                    TrainingFukuiCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
                else
                    TrainingOthersCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
            }
        }

        void Learn(IEnumerable<Coordinate> coordinates)
             => neuralNetwork.Learn(coordinates.Select(coordinate => (coordinate.Latitude, coordinate.Longitude, coordinate.CorrectValue)), learningTimes);

        void Test()
        {
            var coordinates = new[] {
                //new Coordinate { Latitude = 34.6, Longitude = 138.0 },
                //new Coordinate { Latitude = 34.6,  Longitude = 138.18 },
                //new Coordinate { Latitude = 35.4,  Longitude = 138.0 },
                //new Coordinate { Latitude = 34.98,  Longitude = 138.1 },
                //new Coordinate { Latitude = 35.0,  Longitude = 138.25 },
                //new Coordinate { Latitude = 35.4,  Longitude = 137.6 },
                //new Coordinate { Latitude = 34.98,  Longitude = 137.52 },
                //new Coordinate { Latitude = 34.5,  Longitude = 138.5 },
                //new Coordinate { Latitude = 35.4,  Longitude = 138.1 }
                new Coordinate { Latitude = 36.258288, Longitude = 136.284582 },
                new Coordinate { Latitude = 36.274912, Longitude = 136.329279 },
                new Coordinate { Latitude = 36.115784, Longitude = 136.436160 },
                new Coordinate { Latitude = 35.921390, Longitude = 136.887256 },
                new Coordinate { Latitude = 35.801149, Longitude = 136.819202 },
                new Coordinate { Latitude = 35.837652, Longitude = 136.695777 },
                new Coordinate { Latitude = 35.810712, Longitude = 136.505430 },
                new Coordinate { Latitude = 35.742470, Longitude = 136.561360 },
                new Coordinate { Latitude = 35.802909, Longitude = 136.316039 },
                new Coordinate { Latitude = 35.665852, Longitude = 136.343790 },
                new Coordinate { Latitude = 35.571157, Longitude = 136.081772 },
                new Coordinate { Latitude = 35.503405, Longitude = 136.098920 },
                new Coordinate { Latitude = 35.482062, Longitude = 135.943618 },
                new Coordinate { Latitude = 35.333335, Longitude = 135.606685 },
                new Coordinate { Latitude = 35.420561, Longitude = 135.548270 },
                new Coordinate { Latitude = 35.473941, Longitude = 135.436580 },
                new Coordinate { Latitude = 35.532702, Longitude = 135.462497 },
                new Coordinate { Latitude = 35.557382, Longitude = 135.465656 }
            };

            var testCoordinates = coordinates.Select(coordinate => coordinate - baseCoordinate);
            InitializeTrainedData(testCoordinates);
        }

        void InitializeTrainedData(IEnumerable<Coordinate> coordinates)
        {
            TestFukuiCoordinates.Clear();
            TestOthersCoordinates.Clear();

            foreach (var coordinate in coordinates) {
                if (neuralNetwork.Commit((coordinate.Latitude, coordinate.Longitude)) < 0.5)
                    TestFukuiCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
                else
                    TestOthersCoordinates.Add(ToDataPoint(coordinate + baseCoordinate));
            }
        }
    }
}