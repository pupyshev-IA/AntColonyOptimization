using System.Text;
using AntAlgorithm;
using View.WinForms.Domain;
using View.WinForms.Domain.GraphElements;
using View.WinForms.Services;

namespace View.WinForms;

public partial class GraphViewer : Form
{
    private const int MaxNumberOfResults = 5;

    private Action<Graphics> _action;
    private string _currentStageText = "Лучшие решения: {0}/{1}";
    private int _currentStage = 1;

    private GraphInfo _graphInfo;
    private AntColony _colony;
    private List<List<int>> _routes;

    public GraphViewer()
    {
        InitializeComponent();

        _action = InitializeNewGraph;
    }

    /*_________________________________________________________________________________________*/
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [System.Runtime.InteropServices.DllImport("user32.dll")]

    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [System.Runtime.InteropServices.DllImport("user32.dll")]

    public static extern bool ReleaseCapture();

    private void panelMain_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
    /*_________________________________________________________________________________________*/

    private void btnClose_Click(object sender, EventArgs e) =>
        Application.Exit();

    private void panelView_Paint(object sender, PaintEventArgs e) =>
        _action(e.Graphics);

    private void btnCreateGraph_Click(object sender, EventArgs e)
    {
        _currentStage = 1;
        _action = InitializeNewGraph;

        panelView.Invalidate();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        _currentStage--;
        _action = MakeStep;

        panelView.Invalidate();
    }

    private void btnForward_Click(object sender, EventArgs e)
    {
        _currentStage++;
        _action = MakeStep;

        panelView.Invalidate();
    }

    private void cbRandomGraph_CheckedChanged(object sender, EventArgs e) =>
        InvertElementsAvailability();

    private void InitializeNewGraph(Graphics graphics)
    {
        if (!cbRandomGraph.Checked && !IsCustomMatrixValid())
        {
            MessageBox.Show("Проверьте правильность ввода квадратной матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var parameters = new Dictionary<string, object>
        {
            { "IsRandomGraph", cbRandomGraph.Checked },
            { "RandomGraphSize", (int)numUpDownRandomGraphSize.Value },
            { "CustomGraph", tbCustomGraph.Text.Replace("\r\n", " ") }
        };

        _graphInfo = GraphBuilder.CreateGraph(panelView, parameters);
        DisplayMatrixOnForm(_graphInfo.Distances);

        _colony = InitializeAntColony(in _graphInfo);
        _routes = _colony.FindOptimalRoute(
            start: (int)numUpDownStartSpot.Value - 1,
            end: (int)numUpDownEndSpot.Value - 1,
            iterations: (int)numUpDownIterationsNumber.Value,
            ants: (int)numUpDownAntsCount.Value,
            numBestRoutes: MaxNumberOfResults
        );

        ShowCurrentRouteOnGraph(graphics);
    }

    private void MakeStep(Graphics graphics) =>
        ShowCurrentRouteOnGraph(graphics);

    private void ShowCurrentRouteOnGraph(Graphics graphics)
    {
        var restoredLines = RestoreLineColor(_graphInfo.LinesInfo.ToList());
        _graphInfo.LinesInfo = restoredLines;

        var updatedLines = ChangeLineColorForRoute(_routes[_currentStage - 1], _graphInfo.LinesInfo.ToList());
        _graphInfo.LinesInfo = updatedLines;

        SetValuesForResultLabels();
        SetValueForStageLabel();
        UpdateButtonsStatus();

        GraphBuilder.VisualizeGraph(_graphInfo, panelView, graphics);
    }

    private AntColony InitializeAntColony(in GraphInfo graphInfo)
    {
        var colony = new AntColony(
            distances: graphInfo.Distances,
            alpha: (double)numUpDownAlpha.Value,
            beta: (double)numUpDownBeta.Value,
            evaporation: (double)numUpDownEvaporation.Value,
            Q: (double)numUpDownPheromoneAmount.Value
        );

        return colony;
    }

    private bool IsCustomMatrixValid()
    {
        var elements = tbCustomGraph.Text.Replace("\r\n", " ").Split(' ').Select(double.Parse).ToList();
        int matrixSize = (int)Math.Sqrt(elements.Count);

        if (matrixSize * matrixSize != elements.Count)
            return false;

        return true;
    }

    private void DisplayMatrixOnForm(Array matrix)
    {
        var stringBuilder = new StringBuilder();
        int size = matrix.GetLength(0);
        int columnWidth = 10;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                stringBuilder.Append(matrix.GetValue(i, j).ToString().PadRight(columnWidth));

            stringBuilder.AppendLine();
        }

        tbCustomGraph.Text = stringBuilder.ToString();
    }

    private void SetValueForStageLabel() =>
        lblStage.Text = string.Format(_currentStageText, _currentStage, _routes.Count);

    private void SetValuesForResultLabels()
    {
        lblBestRouteValue.Text = string.Join(" -> ", _routes[_currentStage - 1].Select(n => n + 1));
        lblBestLengthValue.Text = _colony.CalculatePathLength(_routes[_currentStage - 1]).ToString();
    }

    private void UpdateButtonsStatus()
    {
        btnBack.Enabled = _currentStage > 1;
        btnForward.Enabled = _currentStage < _routes.Count;
    }

    private void InvertElementsAvailability()
    {
        lblRandomGraph.Enabled = !lblRandomGraph.Enabled;
        numUpDownRandomGraphSize.Enabled = !numUpDownRandomGraphSize.Enabled;

        lblCustomGraph.Enabled = !lblCustomGraph.Enabled;
        tbCustomGraph.Enabled = !tbCustomGraph.Enabled;
    }

    private List<Line> ChangeLineColorForRoute(List<int> rout, List<Line> lines)
    {
        for (int i = 0; i < rout.Count - 1; i++)
        {
            var line = lines
                .Where(line => (line.StartSpot == rout[i] && line.EndSpot == rout[i + 1]) || (line.StartSpot == rout[i + 1] && line.EndSpot == rout[i]))
                .First();
            line.Color = AppConstants.LineColorActive;
        }

        return lines;
    }

    private List<Line> RestoreLineColor(List<Line> lines)
    {
        foreach (var line in lines)
            line.Color = AppConstants.LineColorCommon;

        return lines;
    }
}
