using Flee.PublicTypes;

namespace Dichotomy_method;

public class PlotPointsArrayGenerator {
  private readonly ExpressionContext _context = new ExpressionContext();
  public double[] RangeOfX { get; }

  public PlotPointsArrayGenerator(double startX, double endX, double step) {
    _context.Options.StringComparison = StringComparison.OrdinalIgnoreCase;
    RangeOfX = GetXPoints(startX, endX, step);
  }

  public double[] GetYPoints(string formula) {
    List<double> pointsY = [];
    foreach (var x in RangeOfX) {
      _context.Variables["x"] = x;
      var expr = _context.CompileGeneric<double>(formula);
      pointsY.Add(expr.Evaluate());
    }

    return pointsY.ToArray();
  }

  private double[] GetXPoints(double startX, double endX, double step) {
    List<double> pointsX = [];
    int steps = (int)((endX - startX) / step);
    for (int i = 0; i<= steps; i++) pointsX.Add(Math.Round((startX + i * step),2));

    return pointsX.ToArray();
  }
}