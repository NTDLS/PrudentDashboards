using Library;
using OxyPlot;
using OxyPlot.Series;

namespace UI
{
    public static class ChartHelpers
    {
        public static List<string> GetListViewFields(ListView listView)
        {
            List<string> results = new();
            foreach (ListViewItem item in listView.Items)
            {
                results.Add(item.Text);
            }
            return results;
        }

        public static void AddSeriesDataPoint(ChartType chartType, Series series, double value, string seriesLabel)
        {
            if (chartType == ChartType.Bar)
            {
                ((BarSeries)series).Items.Add(new BarItem((double)value));
            }
            else if (chartType == ChartType.Line)
            {
                var castSeries = ((LineSeries)series);
                castSeries.Points.Add(new DataPoint(castSeries.Points.Count, (double)value));
            }
            else if (chartType == ChartType.Pie)
            {
                var castSeries = ((PieSeries)series);
                castSeries.Slices.Add(new PieSlice(seriesLabel, (double)value));
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Series CreateSeries(ChartType chartType, string displayName)
        {
            if (chartType == ChartType.Bar)
            {
                return new BarSeries
                {
                    Title = displayName
                };
            }
            else if (chartType == ChartType.Line)
            {
                return new LineSeries
                {
                    Title = displayName
                     //LegendKey = displayName,
                };
            }
            else if (chartType == ChartType.Pie)
            {
                return new PieSeries
                {
                    Title = displayName
                };
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
