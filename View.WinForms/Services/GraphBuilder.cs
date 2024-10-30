using View.WinForms.Domain;
using View.WinForms.Domain.GraphElements;

namespace View.WinForms.Services;

public static class GraphBuilder
{
    public static GraphInfo CreateGraph(ScrollableControl layout, Dictionary<string, object> parameters)
    {
        var graphInfo = new GraphInfo();

        double[,] distances = (bool)parameters["IsRandomGraph"] == true
            ? CreateRandomMatrix((int)parameters["RandomGraphSize"])
            : GetCustomMatrix((string)parameters["CustomGraph"]);

        int spotId = 0;
        graphInfo.Distances = distances;
        graphInfo.SpotsInfo = CreateSpots(layout, distances.GetLength(0), ref spotId);
        graphInfo.LinesInfo = CreateLinesFromSpots(graphInfo.SpotsInfo.ToList(), distances);

        return graphInfo;
    }

    public static void VisualizeGraph(GraphInfo graphInfo, ScrollableControl layout, Graphics graphics)
    {
        Font textFont = new Font(AppConstants.TextFontFamily, AppConstants.TextSize);
        SolidBrush textBrush = new SolidBrush(AppConstants.TextColor);
        SolidBrush spotBrush = new SolidBrush(AppConstants.SpotColor);

        foreach (var line in graphInfo.LinesInfo)
        {
            Pen linePen = new Pen(line.Color, line.Color == AppConstants.LineColorCommon ? AppConstants.LineThickness : AppConstants.LineThickness + 2);
            graphics.DrawLine(linePen, line.StartPoisition, line.EndPoisition);

            PointF markerPosition = GetLineTextPosition(line);
            graphics.DrawString(line.Length.ToString(), textFont, textBrush, markerPosition);
        }

        foreach (var spot in graphInfo.SpotsInfo)
        {
            graphics.FillEllipse(spotBrush, new Rectangle(spot.Сoordinates, spot.Metrics));

            Point markerPosition = new Point(spot.Сoordinates.X + 25, spot.Сoordinates.Y - 15);
            graphics.DrawString("Spot " + (spot.Id + 1), textFont, textBrush, markerPosition);
        }
    }

    private static double[,] CreateRandomMatrix(int matrixSize)
    {
        var random = new Random();
        double[,] distances = new double[matrixSize, matrixSize];

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = i; j < matrixSize; j++)
            {
                if (i == j)
                    distances[i, j] = 0;
                else
                {
                    double randomValue = random.Next(1, 15);
                    distances[i, j] = randomValue;
                    distances[j, i] = randomValue;
                }
            }
        }

        return distances;
    }

    private static double[,] GetCustomMatrix(string input)
    {
        var elements = input.Split(' ').Select(double.Parse).ToArray();
        int matrixSize = (int)Math.Sqrt(elements.Length);

        double[,] matrix = new double[matrixSize, matrixSize];
        int index = 0;

        for (int i = 0; i < matrixSize; i++)
            for (int j = 0; j < matrixSize; j++)
                matrix[i, j] = elements[index++];

        return matrix;
    }

    private static ICollection<Line> CreateLinesFromSpots(List<Spot> spots, double[,] distances)
    {
        var lines = new List<Line>();

        for (int i = 0; i < spots.Count; i++)
        {
            for (int j = i + 1; j < spots.Count; j++)
            {
                var line = new Line
                {
                    Color = AppConstants.LineColorCommon,
                    StartSpot = i,
                    EndSpot = j,
                    Length = distances[i, j],

                    StartPoisition = new Point(
                        x: spots[i].Сoordinates.X + spots[i].Metrics.Width / 2, 
                        y: spots[i].Сoordinates.Y + spots[i].Metrics.Width / 2),
                    EndPoisition = new Point(
                        x: spots[j].Сoordinates.X + spots[j].Metrics.Width / 2,
                        y: spots[j].Сoordinates.Y + spots[j].Metrics.Width / 2),
                };

                lines.Add(line);
            }
        }

        return lines;
    }

    private static PointF GetLineTextPosition(Line line)
    {
        PointF midpoint = new PointF(
            (line.StartPoisition.X + line.EndPoisition.X) / 2f, 
            (line.StartPoisition.Y + line.EndPoisition.Y) / 2f
        );

        var increment = new Random().Next(10, 25);
        PointF textPosition = new PointF(
            midpoint.X - increment,
            midpoint.Y - increment
        );

        return textPosition;
    }

    private static ICollection<Spot> CreateSpots(ScrollableControl layout, int spotsCount, ref int spotId)
    {
        var spots = new List<Spot>();

        for (int spotNum = 0; spotNum < spotsCount; spotNum++)
        {
            var coordinates = GetSpotPosition(layout, spotsCount, spotNum);
            var spot = CreateSpotElement(spotId++, coordinates);
            spots.Add(spot);
        }

        return spots;
    }

    private static Spot CreateSpotElement(int id, Point coordinates)
    {
        var place = new Spot
        {
            Id = id,
            Сoordinates = coordinates,
            Metrics = new Size(AppConstants.SpotWidth, AppConstants.SpotHeight)
        };

        return place;
    }

    private static Point GetSpotPosition(ScrollableControl layout, int spotCount, int spotNum)
    {
        int parentCenterX = layout.Width / 2;
        int parentCenterY = layout.Height / 2;

        if (spotCount == 1)
        {
            int tokenX = parentCenterX - AppConstants.SpotWidth / 2;
            int tokenY = parentCenterY - AppConstants.SpotHeight / 2;

            return new Point(tokenX, tokenY);
        }

        double angle = 0;
        double angleStep = 360.0 / spotCount;
        angle = angleStep * spotNum;

        double radian = angle * (Math.PI / 180);
        int distanceFromCenter = (layout.Width - (int)AppConstants.SpotWidth) / 3;

        int x = parentCenterX + (int)(distanceFromCenter * Math.Cos(radian)) - (int)AppConstants.SpotWidth / 2;
        int y = parentCenterY + (int)(distanceFromCenter * Math.Sin(radian)) - (int)AppConstants.SpotHeight / 2;

        return new Point(x, y);
    }
}
