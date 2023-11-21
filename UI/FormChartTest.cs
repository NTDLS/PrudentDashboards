using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace UI
{
    public partial class FormChartTest : Form
    {
        public FormChartTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display_LineAndArea();
        }

        int next = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (next)
            {
                case 0:
                    Display_LineAndArea();
                    break;
                case 1:
                    DisplayLineChart();
                    break;
                case 2:
                    DisplayBarChart();
                    break;
                case 3:
                    DisplayPieChart();
                    break;
                case 4:
                    DisplayHeatmap();
                    break;
                case 5:
                    DisplayBoxPlot();
                    break;
                case 6:
                    DisplayCandlestickChart();
                    break;
                case 7:
                    DisplayContourPlot();
                    break;
                case 8:
                    DisplayHighLowChart();
                    break;
            }

            next++;

            if (next > 8)
            {
                next = 0;
            }
        }


        private void DisplayHighLowChart()
        {
            var plotModel = new PlotModel
            {
                Title = "High-Low Chart Example",
                Subtitle = "Using HighLowSeries in OxyPlot",
            };

            var series = new HighLowSeries
            {
                Title = "Price Range",
            };

            // Define high-low data
            var highLowData = new List<HighLowItem>
            {
                new HighLowItem(x: 1, high: 30, low: 10),
                new HighLowItem(x: 2, high: 35, low: 15),
                new HighLowItem(x: 3, high: 28, low: 12),
                new HighLowItem(x: 4, high: 32, low: 18),
                new HighLowItem(x: 5, high: 33, low: 20),
            };

            series.Items.AddRange(highLowData);

            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }

        private void Display_LineAndArea()
        {
            // Create a new PlotModel
            var plotModel = new PlotModel
            {
                Title = "Line Chart Example",
                Subtitle = "Using OxyPlot in WinForms",
            };

            {
                // Create a LineSeries for the chart
                var series = new AreaSeries
                {
                    Title = "Data Series 1",
                };

                // Sample data points
                series.Points.Add(new DataPoint(1, 10));
                series.Points.Add(new DataPoint(2, 20));
                series.Points.Add(new DataPoint(3, 30));
                series.Points.Add(new DataPoint(4, 25));
                series.Points.Add(new DataPoint(5, 35));

                // Add the LineSeries to the PlotModel
                plotModel.Series.Add(series);
            }

            {
                // Create a LineSeries for the chart
                var series = new LineSeries
                {
                    Title = "Data Series 2",
                };

                // Sample data points
                series.Points.Add(new DataPoint(1, 5));
                series.Points.Add(new DataPoint(2, 6));
                series.Points.Add(new DataPoint(3, 10));
                series.Points.Add(new DataPoint(4, 11));
                series.Points.Add(new DataPoint(5, 14));

                // Add the LineSeries to the PlotModel
                plotModel.Series.Add(series);
            }

            // Assign the PlotModel to the PlotView control
            plotView1.Model = plotModel;
        }

        private void DisplayLineChart()
        {
            // Create a new PlotModel
            var plotModel = new PlotModel
            {
                Title = "Line Chart Example",
                Subtitle = "Using OxyPlot in WinForms",
            };

            // Create a LineSeries for the chart
            var series = new LineSeries
            {
                Title = "Data Series",
            };

            // Sample data points
            series.Points.Add(new DataPoint(1, 10));
            series.Points.Add(new DataPoint(2, 20));
            series.Points.Add(new DataPoint(3, 30));
            series.Points.Add(new DataPoint(4, 25));
            series.Points.Add(new DataPoint(5, 35));

            // Add the LineSeries to the PlotModel
            plotModel.Series.Add(series);

            // Assign the PlotModel to the PlotView control
            plotView1.Model = plotModel;
        }

        private void DisplayBarChart()
        {
            var plotModel = new PlotModel
            {
                Title = "Bar Chart Example",
                Subtitle = "Using BarSeries in OxyPlot",
            };

            var series = new BarSeries
            {
                Title = "Data Series",
            };

            series.Items.Add(new BarItem { Value = 10 });
            series.Items.Add(new BarItem { Value = 20 });
            series.Items.Add(new BarItem { Value = 30 });
            series.Items.Add(new BarItem { Value = 25 });
            series.Items.Add(new BarItem { Value = 35 });

            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }

        private void DisplayPieChart()
        {
            var plotModel = new PlotModel
            {
                Title = "Pie Chart Example",
                Subtitle = "Using PieSeries in OxyPlot",
            };

            var series = new PieSeries();

            series.Slices.Add(new PieSlice("Category 1", 30));
            series.Slices.Add(new PieSlice("Category 2", 40));
            series.Slices.Add(new PieSlice("Category 3", 25));
            series.Slices.Add(new PieSlice("Category 4", 15));

            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }

        private void DisplayHeatmap()
        {
            var plotModel = new PlotModel { Title = "Heatmap" };

            // Color axis (the X and Y axes are generated automatically)
            plotModel.Axes.Add(new LinearColorAxis
            {
                Palette = OxyPalettes.Rainbow(100)
            });

            // generate 1d normal distribution
            var singleData = new double[100];
            for (int x = 0; x < 100; ++x)
            {
                singleData[x] = Math.Exp((-1.0 / 2.0) * Math.Pow(((double)x - 50.0) / 20.0, 2.0));
            }

            // generate 2d normal distribution
            var data = new double[100, 100];
            for (int x = 0; x < 100; ++x)
            {
                for (int y = 0; y < 100; ++y)
                {
                    data[y, x] = singleData[x] * singleData[(y + 30) % 100] * 100;
                }
            }

            var heatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = 99,
                Y0 = 0,
                Y1 = 99,
                Interpolate = true,
                RenderMethod = HeatMapRenderMethod.Bitmap,
                Data = data
            };

            plotModel.Series.Add(heatMapSeries);

            plotView1.Model = plotModel;
        }

        private void DisplayBoxPlot()
        {
            var plotModel = new PlotModel
            {
                Title = "Box Plot Example",
                Subtitle = "Using BoxPlotSeries in OxyPlot",
            };

            var series = new BoxPlotSeries
            {
                BoxWidth = 0.2,
            };

            // Define box plot data
            var boxPlotData = new BoxPlotItem(
                x: 1.0,           // X-coordinate
                lowerWhisker: 5.0,  // Lower whisker (minimum)
                boxBottom: 10.0,   // Box bottom (first quartile)
                median: 15.0,      // Median (second quartile)
                boxTop: 20.0,      // Box top (third quartile)
                upperWhisker: 25.0 // Upper whisker (maximum)
            );

            series.Items.Add(boxPlotData);

            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }

        private void DisplayCandlestickChart()
        {
            var plotModel = new PlotModel
            {
                Title = "Candlestick Chart Example",
                Subtitle = "Using CandleStickSeries in OxyPlot",
            };

            var series = new CandleStickSeries
            {
                Title = "Candlestick Data",
            };

            // Define candlestick data
            var candlestickData = new List<HighLowItem>
            {
                new HighLowItem(x: 1, high: 30, low: 10, open: 15, close: 25),
                new HighLowItem(x: 2, high: 35, low: 15, open: 25, close: 30),
                new HighLowItem(x: 3, high: 28, low: 12, open: 20, close: 26),
                new HighLowItem(x: 4, high: 32, low: 18, open: 28, close: 30),
                new HighLowItem(x: 5, high: 33, low: 20, open: 30, close: 32),
            };

            series.Items.AddRange(candlestickData);

            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }

        private void DisplayContourPlot()
        {
            var plotModel = new PlotModel { Title = "ContourSeries" };

            double x0 = -3.1;
            double x1 = 3.1;
            double y0 = -3;
            double y1 = 3;

            //generate values
            Func<double, double, double> peaks = (x, y) => 3 * (1 - x) * (1 - x) * Math.Exp(-(x * x) - (y + 1) * (y + 1)) - 10 * (x / 5 - x * x * x - y * y * y * y * y) * Math.Exp(-x * x - y * y) - 1.0 / 3 * Math.Exp(-(x + 1) * (x + 1) - y * y);
            var xx = ArrayBuilder.CreateVector(x0, x1, 100);
            var yy = ArrayBuilder.CreateVector(y0, y1, 100);
            var peaksData = ArrayBuilder.Evaluate(peaks, xx, yy);

            var cs = new ContourSeries
            {
                Color = OxyColors.Black,
                LabelBackground = OxyColors.White,
                ColumnCoordinates = yy,
                RowCoordinates = xx,
                Data = peaksData
            };
            plotModel.Series.Add(cs);

            plotView1.Model = plotModel;
        }
    }
}
