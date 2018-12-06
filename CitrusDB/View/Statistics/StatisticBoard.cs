using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;

namespace CitrusDB.View.Statistics
{
    public partial class StatisticBoard : UserControl
    {
        public StatisticBoard()
        {
            InitializeComponent();

            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Name = "First",
                    Values = new ChartValues<ObservablePoint>{
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(2,12)
                    },
                    PointGeometrySize = 10
                }
            };

        }
    }
}
