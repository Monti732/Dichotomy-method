using System.Globalization;
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
    PlotPointsArrayGenerator points;
    if (allowCustomRange.Checked) {
      //holy molly, that's a lot of letters
      points = new PlotPointsArrayGenerator(double.Parse(x1TextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
        double.Parse(x2TextBox.Text, CultureInfo.InvariantCulture.NumberFormat),
        double.Parse(stepTextBox.Text, CultureInfo.InvariantCulture.NumberFormat), formulaTextBox.Text);
    }
    else points = new PlotPointsArrayGenerator(-5, 5, 0.01, formulaTextBox.Text);

    _plot.Plot.Add.Scatter(points.GetPoints(PlotPointsArrayGenerator.Axis.X),
      points.GetPoints(PlotPointsArrayGenerator.Axis.Y));
    _plot.Refresh();
  }

  private bool AllowDigitsAndComma(object sender, KeyPressEventArgs e) {
    var textBox = sender as TextBox;

    if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return true;

    if (textBox.Text.Contains(',')) return false;
    if (textBox.Text.Contains('.')) return false;

    if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text != "") return true;

    return false;
  }

  private void AllowSignedDigitsAndComma(object sender, KeyPressEventArgs e) {
    var textBox = sender as TextBox;

    if (AllowDigitsAndComma(sender, e)) return;

    if (e.KeyChar != '-' || textBox.Text != "") e.Handled = true;
  }

  private void ApplyInputRestrictionByTag(object sender, KeyPressEventArgs e) {
    var textBox = sender as TextBox;

    if (textBox.Tag.ToString() == "") throw new Exception("Tag is required");

    switch (textBox.Tag.ToString()) {
    case "Unsigned":
      AllowDigitsAndComma(sender, e);
      break;
    case "Signed":
      AllowSignedDigitsAndComma(sender, e);
      break;
    }
  }
}