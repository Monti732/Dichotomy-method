using ScottPlot.WinForms;

namespace Dichotomy_method;

public partial class DichotomyForm : Form {
  private readonly FormsPlot _plot = new FormsPlot() { Dock = DockStyle.Fill };

  public DichotomyForm() {
    InitializeComponent();
    plot.Controls.Add(_plot);
  }

  private void CalculateButton_Click(object sender, EventArgs e) {
    _plot.Plot.Clear();
    var points = new PlotPointsArrayGenerator(-5, 5, 0.01);
    _plot.Plot.Add.Scatter(points.RangeOfX, points.GetYPoints(formulaTextBox.Text));
    _plot.Refresh();
  }

  private void allowCustomRange_CheckedChanged(object sender, EventArgs e) {
    
  }
}