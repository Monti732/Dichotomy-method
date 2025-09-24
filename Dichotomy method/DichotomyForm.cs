using System.Globalization;
using System.Text.RegularExpressions;
using ScottPlot.WinForms;

namespace Dichotomy_method;

public partial class DichotomyForm : Form {
  private readonly FormsPlot _plot = new FormsPlot() { Dock = DockStyle.Fill };

  public DichotomyForm() {
    InitializeComponent();
    plot.Controls.Add(_plot);
  }

  private void AllowDigitsAndComma(object sender, KeyPressEventArgs e) {
    var textBox = sender as TextBox;

    if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;

    if ((e.KeyChar == '.' || e.KeyChar == ',')
        && !textBox.Text.Contains('.')
        && !textBox.Text.Contains(',')
        && textBox.Text.Length > 0)
      return;

    e.Handled = true;
  }

  private void AllowSignedDigitsAndComma(object sender, KeyPressEventArgs e) {
    var textBox = sender as TextBox;

    if (e.KeyChar == '-' && textBox.Text.Length == 0) return;

    AllowDigitsAndComma(sender, e);
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

  private void BuildPlot(object sender, EventArgs e) {
    _plot.Plot.Clear();
    var numberFormat = CultureInfo.InvariantCulture.NumberFormat;
    PlotPointsArrayGenerator points;
    if (allowCustomRange.Checked) {
      points = new PlotPointsArrayGenerator(
        double.Parse(x1TextBox.Text, numberFormat),
        double.Parse(x2TextBox.Text, numberFormat),
        double.Parse(stepTextBox.Text, numberFormat),
        formulaTextBox.Text);
    }
    else points = new PlotPointsArrayGenerator(-5, 5, 0.01, formulaTextBox.Text);

    _plot.Plot.Add.Scatter(
      points.GetPoints(PlotPointsArrayGenerator.Axis.X),
      points.GetPoints(PlotPointsArrayGenerator.Axis.Y));
    _plot.Refresh();
  }

  private void CalculateRoot(object sender, EventArgs e) {
    var numberFormat = CultureInfo.InvariantCulture.NumberFormat;
    var solver = new DichotomySolver();
    var regex = new Regex(@"^0(.|,)0*1$");

    if (!regex.IsMatch(eTextBox.Text) && eTextBox.Text != "1")
      throw new Exception("Wrong format of E value, should be 0.1 or 1");

    var result = solver.Solve(double.Parse(aTextBox.Text, numberFormat), double.Parse(bTextBox.Text, numberFormat),
      double.Parse(eTextBox.Text, numberFormat),
      formulaTextBox.Text);

    if (!result.Contains('T')) result = CutOffResult(result);

    rootLabel.Text = result;
  }

  private void allowCustomRange_MouseCaptureChanged(object sender, EventArgs e) {
    if (allowCustomRange.Checked) {
      tableLayoutPanel2.Visible = true;
      return;
    }

    tableLayoutPanel2.Visible = false;
  }

  private string CutOffResult(string result) {
    if (eTextBox.Text == "1") return result;
    var numberOfDigitsAfterComma = eTextBox.Text.Length - 2;
    return result.Substring(0, result.IndexOfAny([',', '.']) + numberOfDigitsAfterComma + 1);
  }

  private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
    formulaTextBox.Text = "";
    aTextBox.Text = "";
    bTextBox.Text = "";
    eTextBox.Text = "";
    x2TextBox.Text = "";
    x1TextBox.Text = "";
    stepTextBox.Text = "";
    rootLabel.Text = "";
  }
}