using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

using CitrusDB.View.Statistics;

namespace CitrusDB.Model.Extensions
{
    public static class ExtensionCharts
    {

        public static void CreateSeries(this Chart chart, string name, Color color, IList<DateModel> dateModels)
        {
            var series = new Series
            {
                ChartType = SeriesChartType.Line,
                Color = color,
                Name = name
            };

            foreach (DateModel date in dateModels)
                series.Points.AddXY(date.Time, date.Count);

            //todo: ??
            //chart.Series.Add(series);
            if (chart.Series.FindByName(series.Name) != null)
                chart.Series[series.Name] = series;
            else
                chart.Series.Add(series);

            chart.Series[name].XValueType = ChartValueType.DateTime;
        }

    }
}
