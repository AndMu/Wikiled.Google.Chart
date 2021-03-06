using Wikiled.Google.Chart;
using Wikiled.Google.Chart.Helpers;

namespace Wikiled.Google.Charts.TestApp
{
    class PieChartTests
    {
        public static string TwoDTest()
        {
            int[] data = { 10, 20, 30, 40 };
            PieChart pieChart = new PieChart(250, 150);
            pieChart.SetTitle("2D Test");
            pieChart.SetData(data);
            pieChart.SetPieChartLabels(new[] { "A", "B", "C", "D" });

            return pieChart.GetUrl();
        }

        public static string ThreeDTest()
        {
            int[] data = { 10, 20, 30, 40 };
            PieChart pieChart = new PieChart(300, 150, PieChartType.ThreeD);
            pieChart.SetTitle("3D Test");
            pieChart.SetData(data);
            pieChart.SetPieChartLabels(new[] { "A", "B", "C", "D" });
            pieChart.SetDatasetColors(new[] { Colors.GetColor("0000FF") });
            return pieChart.GetUrl();
        }
    }
}
