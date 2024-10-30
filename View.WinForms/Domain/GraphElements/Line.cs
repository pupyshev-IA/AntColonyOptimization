namespace View.WinForms.Domain.GraphElements;

public class Line
{
    public required Point StartPoisition { get; set; }

    public required Point EndPoisition { get; set; }

    public Color Color { get; set; }

    public int StartSpot { get; set; }

    public int EndSpot { get; set; }

    public double Length { get; set; }
}
