using View.WinForms.Domain.GraphElements;

namespace View.WinForms.Domain;

public class GraphInfo
{
    public ICollection<Spot> SpotsInfo { get; set; } = new List<Spot>();

    public ICollection<Line> LinesInfo { get; set; } = new List<Line>();

    public double[,] Distances { get; set; }
}
