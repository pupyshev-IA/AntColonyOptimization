namespace View.WinForms
{
    partial class GraphViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphViewer));
            panelOuterMain = new Panel();
            panelMain = new Panel();
            tlpResult = new TableLayoutPanel();
            lblBestRouteValue = new Label();
            lblBestLength = new Label();
            lblBestRoute = new Label();
            lblBestLengthValue = new Label();
            tlpStartEndSpots = new TableLayoutPanel();
            numUpDownStartSpot = new NumericUpDown();
            numUpDownEndSpot = new NumericUpDown();
            lblStartSpot = new Label();
            lblEndSpot = new Label();
            panelOuterSettingsHolder = new Panel();
            panelSettingsHolder = new Panel();
            tlpSettings = new TableLayoutPanel();
            btnCreateGraph = new Button();
            lblInput = new Label();
            tlpNavigation = new TableLayoutPanel();
            btnForward = new Button();
            lblStage = new Label();
            btnBack = new Button();
            tlpParametersHolder = new TableLayoutPanel();
            tlpParameters2 = new TableLayoutPanel();
            lblCustomGraph = new Label();
            numUpDownRandomGraphSize = new NumericUpDown();
            lblRandomGraph = new Label();
            cbRandomGraph = new CheckBox();
            tbCustomGraph = new TextBox();
            tlpParameters1 = new TableLayoutPanel();
            numUpDownAlpha = new NumericUpDown();
            lblAlpha = new Label();
            lblBeta = new Label();
            lblEvaporation = new Label();
            lblPheromoneAmount = new Label();
            lblAntsCount = new Label();
            lblIterationsNumber = new Label();
            numUpDownBeta = new NumericUpDown();
            numUpDownEvaporation = new NumericUpDown();
            numUpDownPheromoneAmount = new NumericUpDown();
            numUpDownAntsCount = new NumericUpDown();
            numUpDownIterationsNumber = new NumericUpDown();
            panelOuterView = new Panel();
            panelView = new Panel();
            btnClose = new Button();
            panelOuterMain.SuspendLayout();
            panelMain.SuspendLayout();
            tlpResult.SuspendLayout();
            tlpStartEndSpots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownStartSpot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownEndSpot).BeginInit();
            panelOuterSettingsHolder.SuspendLayout();
            panelSettingsHolder.SuspendLayout();
            tlpSettings.SuspendLayout();
            tlpNavigation.SuspendLayout();
            tlpParametersHolder.SuspendLayout();
            tlpParameters2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownRandomGraphSize).BeginInit();
            tlpParameters1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownBeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownEvaporation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownPheromoneAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownAntsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownIterationsNumber).BeginInit();
            panelOuterView.SuspendLayout();
            SuspendLayout();
            // 
            // panelOuterMain
            // 
            panelOuterMain.BackColor = Color.FromArgb(120, 120, 120);
            panelOuterMain.Controls.Add(panelMain);
            panelOuterMain.Dock = DockStyle.Fill;
            panelOuterMain.Location = new Point(0, 0);
            panelOuterMain.Name = "panelOuterMain";
            panelOuterMain.Padding = new Padding(2);
            panelOuterMain.Size = new Size(1400, 710);
            panelOuterMain.TabIndex = 2;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(tlpResult);
            panelMain.Controls.Add(tlpStartEndSpots);
            panelMain.Controls.Add(panelOuterSettingsHolder);
            panelMain.Controls.Add(panelOuterView);
            panelMain.Controls.Add(btnClose);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1396, 706);
            panelMain.TabIndex = 0;
            panelMain.MouseDown += panelMain_MouseDown;
            // 
            // tlpResult
            // 
            tlpResult.ColumnCount = 2;
            tlpResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpResult.Controls.Add(lblBestRouteValue, 1, 0);
            tlpResult.Controls.Add(lblBestLength, 0, 1);
            tlpResult.Controls.Add(lblBestRoute, 0, 0);
            tlpResult.Controls.Add(lblBestLengthValue, 1, 1);
            tlpResult.Location = new Point(357, 609);
            tlpResult.Name = "tlpResult";
            tlpResult.RowCount = 2;
            tlpResult.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResult.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResult.Size = new Size(416, 80);
            tlpResult.TabIndex = 6;
            // 
            // lblBestRouteValue
            // 
            lblBestRouteValue.Dock = DockStyle.Fill;
            lblBestRouteValue.Font = new Font("Segoe UI", 12F);
            lblBestRouteValue.Location = new Point(145, 0);
            lblBestRouteValue.Margin = new Padding(0);
            lblBestRouteValue.Name = "lblBestRouteValue";
            lblBestRouteValue.Size = new Size(271, 40);
            lblBestRouteValue.TabIndex = 10;
            lblBestRouteValue.Text = "label";
            lblBestRouteValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBestLength
            // 
            lblBestLength.Dock = DockStyle.Fill;
            lblBestLength.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBestLength.Location = new Point(0, 40);
            lblBestLength.Margin = new Padding(0);
            lblBestLength.Name = "lblBestLength";
            lblBestLength.Size = new Size(145, 40);
            lblBestLength.TabIndex = 8;
            lblBestLength.Text = "Длина пути:";
            lblBestLength.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBestRoute
            // 
            lblBestRoute.Dock = DockStyle.Fill;
            lblBestRoute.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBestRoute.Location = new Point(0, 0);
            lblBestRoute.Margin = new Padding(0);
            lblBestRoute.Name = "lblBestRoute";
            lblBestRoute.Size = new Size(145, 40);
            lblBestRoute.TabIndex = 5;
            lblBestRoute.Text = "Лучший путь:";
            lblBestRoute.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBestLengthValue
            // 
            lblBestLengthValue.Dock = DockStyle.Fill;
            lblBestLengthValue.Font = new Font("Segoe UI", 12F);
            lblBestLengthValue.Location = new Point(145, 40);
            lblBestLengthValue.Margin = new Padding(0);
            lblBestLengthValue.Name = "lblBestLengthValue";
            lblBestLengthValue.Size = new Size(271, 40);
            lblBestLengthValue.TabIndex = 11;
            lblBestLengthValue.Text = "label";
            lblBestLengthValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpStartEndSpots
            // 
            tlpStartEndSpots.ColumnCount = 2;
            tlpStartEndSpots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStartEndSpots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStartEndSpots.Controls.Add(numUpDownStartSpot, 0, 1);
            tlpStartEndSpots.Controls.Add(numUpDownEndSpot, 0, 1);
            tlpStartEndSpots.Controls.Add(lblStartSpot, 0, 0);
            tlpStartEndSpots.Controls.Add(lblEndSpot, 1, 0);
            tlpStartEndSpots.Location = new Point(10, 609);
            tlpStartEndSpots.Name = "tlpStartEndSpots";
            tlpStartEndSpots.RowCount = 2;
            tlpStartEndSpots.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlpStartEndSpots.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpStartEndSpots.Size = new Size(320, 80);
            tlpStartEndSpots.TabIndex = 6;
            // 
            // numUpDownStartSpot
            // 
            numUpDownStartSpot.BackColor = Color.WhiteSmoke;
            numUpDownStartSpot.BorderStyle = BorderStyle.FixedSingle;
            numUpDownStartSpot.Dock = DockStyle.Fill;
            numUpDownStartSpot.Font = new Font("Segoe UI", 12F);
            numUpDownStartSpot.Location = new Point(3, 44);
            numUpDownStartSpot.Margin = new Padding(3, 0, 3, 0);
            numUpDownStartSpot.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numUpDownStartSpot.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownStartSpot.Name = "numUpDownStartSpot";
            numUpDownStartSpot.Size = new Size(154, 29);
            numUpDownStartSpot.TabIndex = 11;
            numUpDownStartSpot.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numUpDownEndSpot
            // 
            numUpDownEndSpot.BackColor = Color.WhiteSmoke;
            numUpDownEndSpot.BorderStyle = BorderStyle.FixedSingle;
            numUpDownEndSpot.Dock = DockStyle.Fill;
            numUpDownEndSpot.Font = new Font("Segoe UI", 12F);
            numUpDownEndSpot.Location = new Point(163, 44);
            numUpDownEndSpot.Margin = new Padding(3, 0, 3, 0);
            numUpDownEndSpot.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numUpDownEndSpot.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownEndSpot.Name = "numUpDownEndSpot";
            numUpDownEndSpot.Size = new Size(154, 29);
            numUpDownEndSpot.TabIndex = 10;
            numUpDownEndSpot.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblStartSpot
            // 
            lblStartSpot.Dock = DockStyle.Fill;
            lblStartSpot.Font = new Font("Segoe UI", 12F);
            lblStartSpot.Location = new Point(0, 0);
            lblStartSpot.Margin = new Padding(0);
            lblStartSpot.Name = "lblStartSpot";
            lblStartSpot.Size = new Size(160, 44);
            lblStartSpot.TabIndex = 5;
            lblStartSpot.Text = "Начальная позиция:";
            lblStartSpot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEndSpot
            // 
            lblEndSpot.Dock = DockStyle.Fill;
            lblEndSpot.Font = new Font("Segoe UI", 12F);
            lblEndSpot.Location = new Point(160, 0);
            lblEndSpot.Margin = new Padding(0);
            lblEndSpot.Name = "lblEndSpot";
            lblEndSpot.Size = new Size(160, 44);
            lblEndSpot.TabIndex = 9;
            lblEndSpot.Text = "Конечная позиция:";
            lblEndSpot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelOuterSettingsHolder
            // 
            panelOuterSettingsHolder.BackColor = Color.FromArgb(120, 120, 120);
            panelOuterSettingsHolder.Controls.Add(panelSettingsHolder);
            panelOuterSettingsHolder.Location = new Point(781, 73);
            panelOuterSettingsHolder.Name = "panelOuterSettingsHolder";
            panelOuterSettingsHolder.Padding = new Padding(1);
            panelOuterSettingsHolder.Size = new Size(605, 615);
            panelOuterSettingsHolder.TabIndex = 4;
            // 
            // panelSettingsHolder
            // 
            panelSettingsHolder.BackColor = Color.WhiteSmoke;
            panelSettingsHolder.Controls.Add(tlpSettings);
            panelSettingsHolder.Dock = DockStyle.Fill;
            panelSettingsHolder.Location = new Point(1, 1);
            panelSettingsHolder.Name = "panelSettingsHolder";
            panelSettingsHolder.Padding = new Padding(15, 10, 15, 10);
            panelSettingsHolder.Size = new Size(603, 613);
            panelSettingsHolder.TabIndex = 0;
            // 
            // tlpSettings
            // 
            tlpSettings.ColumnCount = 1;
            tlpSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSettings.Controls.Add(btnCreateGraph, 0, 1);
            tlpSettings.Controls.Add(lblInput, 0, 0);
            tlpSettings.Controls.Add(tlpNavigation, 0, 4);
            tlpSettings.Controls.Add(tlpParametersHolder, 0, 2);
            tlpSettings.Dock = DockStyle.Fill;
            tlpSettings.Location = new Point(15, 10);
            tlpSettings.Margin = new Padding(0);
            tlpSettings.Name = "tlpSettings";
            tlpSettings.RowCount = 2;
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSettings.Size = new Size(573, 593);
            tlpSettings.TabIndex = 1;
            // 
            // btnCreateGraph
            // 
            btnCreateGraph.BackColor = Color.FromArgb(27, 117, 208);
            btnCreateGraph.Cursor = Cursors.Hand;
            btnCreateGraph.Dock = DockStyle.Fill;
            btnCreateGraph.FlatStyle = FlatStyle.Flat;
            btnCreateGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreateGraph.ForeColor = Color.White;
            btnCreateGraph.Location = new Point(0, 47);
            btnCreateGraph.Margin = new Padding(0);
            btnCreateGraph.Name = "btnCreateGraph";
            btnCreateGraph.Size = new Size(573, 47);
            btnCreateGraph.TabIndex = 7;
            btnCreateGraph.Text = "Запуск";
            btnCreateGraph.UseVisualStyleBackColor = false;
            btnCreateGraph.Click += btnCreateGraph_Click;
            // 
            // lblInput
            // 
            lblInput.Dock = DockStyle.Fill;
            lblInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblInput.Location = new Point(0, 0);
            lblInput.Margin = new Padding(0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(573, 47);
            lblInput.TabIndex = 4;
            lblInput.Text = "Входные данные:";
            lblInput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpNavigation
            // 
            tlpNavigation.ColumnCount = 3;
            tlpNavigation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpNavigation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74F));
            tlpNavigation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tlpNavigation.Controls.Add(btnForward, 2, 0);
            tlpNavigation.Controls.Add(lblStage, 1, 0);
            tlpNavigation.Controls.Add(btnBack, 0, 0);
            tlpNavigation.Dock = DockStyle.Fill;
            tlpNavigation.Location = new Point(0, 543);
            tlpNavigation.Margin = new Padding(0);
            tlpNavigation.Name = "tlpNavigation";
            tlpNavigation.RowCount = 1;
            tlpNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpNavigation.Size = new Size(573, 50);
            tlpNavigation.TabIndex = 8;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.White;
            btnForward.Cursor = Cursors.Hand;
            btnForward.Dock = DockStyle.Fill;
            btnForward.Enabled = false;
            btnForward.Image = (Image)resources.GetObject("btnForward.Image");
            btnForward.Location = new Point(501, 3);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(69, 44);
            btnForward.TabIndex = 3;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // lblStage
            // 
            lblStage.Dock = DockStyle.Fill;
            lblStage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStage.Location = new Point(77, 3);
            lblStage.Margin = new Padding(3);
            lblStage.Name = "lblStage";
            lblStage.Size = new Size(418, 44);
            lblStage.TabIndex = 6;
            lblStage.Text = "label";
            lblStage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Fill;
            btnBack.Enabled = false;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 44);
            btnBack.TabIndex = 2;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // tlpParametersHolder
            // 
            tlpParametersHolder.ColumnCount = 2;
            tlpParametersHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpParametersHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpParametersHolder.Controls.Add(tlpParameters2, 1, 0);
            tlpParametersHolder.Controls.Add(tlpParameters1, 0, 0);
            tlpParametersHolder.Dock = DockStyle.Fill;
            tlpParametersHolder.Location = new Point(0, 94);
            tlpParametersHolder.Margin = new Padding(0);
            tlpParametersHolder.Name = "tlpParametersHolder";
            tlpParametersHolder.RowCount = 1;
            tlpParametersHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpParametersHolder.Size = new Size(573, 444);
            tlpParametersHolder.TabIndex = 9;
            // 
            // tlpParameters2
            // 
            tlpParameters2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpParameters2.ColumnCount = 1;
            tlpParameters2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpParameters2.Controls.Add(lblCustomGraph, 0, 3);
            tlpParameters2.Controls.Add(numUpDownRandomGraphSize, 0, 2);
            tlpParameters2.Controls.Add(lblRandomGraph, 0, 1);
            tlpParameters2.Controls.Add(cbRandomGraph, 0, 0);
            tlpParameters2.Controls.Add(tbCustomGraph, 0, 4);
            tlpParameters2.Dock = DockStyle.Fill;
            tlpParameters2.ForeColor = Color.Black;
            tlpParameters2.Location = new Point(289, 3);
            tlpParameters2.Name = "tlpParameters2";
            tlpParameters2.RowCount = 5;
            tlpParameters2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpParameters2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpParameters2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpParameters2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpParameters2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpParameters2.Size = new Size(281, 438);
            tlpParameters2.TabIndex = 7;
            // 
            // lblCustomGraph
            // 
            lblCustomGraph.Dock = DockStyle.Fill;
            lblCustomGraph.Enabled = false;
            lblCustomGraph.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCustomGraph.ForeColor = Color.Black;
            lblCustomGraph.Location = new Point(4, 133);
            lblCustomGraph.Name = "lblCustomGraph";
            lblCustomGraph.Size = new Size(273, 43);
            lblCustomGraph.TabIndex = 18;
            lblCustomGraph.Text = "Задать граф расстояний:";
            lblCustomGraph.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numUpDownRandomGraphSize
            // 
            numUpDownRandomGraphSize.BackColor = Color.WhiteSmoke;
            numUpDownRandomGraphSize.BorderStyle = BorderStyle.FixedSingle;
            numUpDownRandomGraphSize.Dock = DockStyle.Fill;
            numUpDownRandomGraphSize.Font = new Font("Segoe UI", 12F);
            numUpDownRandomGraphSize.Location = new Point(4, 89);
            numUpDownRandomGraphSize.Margin = new Padding(3, 0, 3, 0);
            numUpDownRandomGraphSize.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numUpDownRandomGraphSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numUpDownRandomGraphSize.Name = "numUpDownRandomGraphSize";
            numUpDownRandomGraphSize.Size = new Size(273, 29);
            numUpDownRandomGraphSize.TabIndex = 17;
            numUpDownRandomGraphSize.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblRandomGraph
            // 
            lblRandomGraph.Dock = DockStyle.Fill;
            lblRandomGraph.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRandomGraph.ForeColor = Color.Black;
            lblRandomGraph.Location = new Point(4, 45);
            lblRandomGraph.Name = "lblRandomGraph";
            lblRandomGraph.Size = new Size(273, 43);
            lblRandomGraph.TabIndex = 16;
            lblRandomGraph.Text = "Размер случайного графа:";
            lblRandomGraph.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbRandomGraph
            // 
            cbRandomGraph.AutoSize = true;
            cbRandomGraph.Checked = true;
            cbRandomGraph.CheckState = CheckState.Checked;
            cbRandomGraph.Cursor = Cursors.Hand;
            cbRandomGraph.Dock = DockStyle.Fill;
            cbRandomGraph.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbRandomGraph.Location = new Point(4, 4);
            cbRandomGraph.Name = "cbRandomGraph";
            cbRandomGraph.Size = new Size(273, 37);
            cbRandomGraph.TabIndex = 15;
            cbRandomGraph.Text = "Использовать случайный граф";
            cbRandomGraph.UseVisualStyleBackColor = true;
            cbRandomGraph.CheckedChanged += cbRandomGraph_CheckedChanged;
            // 
            // tbCustomGraph
            // 
            tbCustomGraph.Dock = DockStyle.Fill;
            tbCustomGraph.Enabled = false;
            tbCustomGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbCustomGraph.Location = new Point(4, 180);
            tbCustomGraph.Multiline = true;
            tbCustomGraph.Name = "tbCustomGraph";
            tbCustomGraph.Size = new Size(273, 254);
            tbCustomGraph.TabIndex = 19;
            tbCustomGraph.WordWrap = false;
            // 
            // tlpParameters1
            // 
            tlpParameters1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpParameters1.ColumnCount = 1;
            tlpParameters1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tlpParameters1.Controls.Add(numUpDownAlpha, 0, 1);
            tlpParameters1.Controls.Add(lblAlpha, 0, 0);
            tlpParameters1.Controls.Add(lblBeta, 0, 2);
            tlpParameters1.Controls.Add(lblEvaporation, 0, 4);
            tlpParameters1.Controls.Add(lblPheromoneAmount, 0, 6);
            tlpParameters1.Controls.Add(lblAntsCount, 0, 8);
            tlpParameters1.Controls.Add(lblIterationsNumber, 0, 10);
            tlpParameters1.Controls.Add(numUpDownBeta, 0, 3);
            tlpParameters1.Controls.Add(numUpDownEvaporation, 0, 5);
            tlpParameters1.Controls.Add(numUpDownPheromoneAmount, 0, 7);
            tlpParameters1.Controls.Add(numUpDownAntsCount, 0, 9);
            tlpParameters1.Controls.Add(numUpDownIterationsNumber, 0, 11);
            tlpParameters1.Dock = DockStyle.Fill;
            tlpParameters1.ForeColor = Color.Black;
            tlpParameters1.Location = new Point(3, 3);
            tlpParameters1.Name = "tlpParameters1";
            tlpParameters1.RowCount = 12;
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tlpParameters1.Size = new Size(280, 438);
            tlpParameters1.TabIndex = 7;
            // 
            // numUpDownAlpha
            // 
            numUpDownAlpha.BackColor = Color.WhiteSmoke;
            numUpDownAlpha.BorderStyle = BorderStyle.FixedSingle;
            numUpDownAlpha.DecimalPlaces = 1;
            numUpDownAlpha.Dock = DockStyle.Fill;
            numUpDownAlpha.Font = new Font("Segoe UI", 12F);
            numUpDownAlpha.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownAlpha.Location = new Point(4, 37);
            numUpDownAlpha.Margin = new Padding(3, 0, 3, 0);
            numUpDownAlpha.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUpDownAlpha.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownAlpha.Name = "numUpDownAlpha";
            numUpDownAlpha.Size = new Size(272, 29);
            numUpDownAlpha.TabIndex = 5;
            numUpDownAlpha.Value = new decimal(new int[] { 10, 0, 0, 65536 });
            // 
            // lblAlpha
            // 
            lblAlpha.Dock = DockStyle.Fill;
            lblAlpha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAlpha.ForeColor = Color.Black;
            lblAlpha.Location = new Point(4, 1);
            lblAlpha.Name = "lblAlpha";
            lblAlpha.Size = new Size(272, 35);
            lblAlpha.TabIndex = 14;
            lblAlpha.Text = "Alpha (Влияние феромона):";
            lblAlpha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBeta
            // 
            lblBeta.Dock = DockStyle.Fill;
            lblBeta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBeta.ForeColor = Color.Black;
            lblBeta.Location = new Point(4, 73);
            lblBeta.Name = "lblBeta";
            lblBeta.Size = new Size(272, 35);
            lblBeta.TabIndex = 14;
            lblBeta.Text = "Beta (Влияние эвристики):";
            lblBeta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEvaporation
            // 
            lblEvaporation.Dock = DockStyle.Fill;
            lblEvaporation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblEvaporation.ForeColor = Color.Black;
            lblEvaporation.Location = new Point(4, 145);
            lblEvaporation.Name = "lblEvaporation";
            lblEvaporation.Size = new Size(272, 35);
            lblEvaporation.TabIndex = 14;
            lblEvaporation.Text = "Rho (Коэффициент испарения):";
            lblEvaporation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPheromoneAmount
            // 
            lblPheromoneAmount.Dock = DockStyle.Fill;
            lblPheromoneAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPheromoneAmount.ForeColor = Color.Black;
            lblPheromoneAmount.Location = new Point(4, 217);
            lblPheromoneAmount.Name = "lblPheromoneAmount";
            lblPheromoneAmount.Size = new Size(272, 35);
            lblPheromoneAmount.TabIndex = 14;
            lblPheromoneAmount.Text = "Q (Количество феромона):";
            lblPheromoneAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAntsCount
            // 
            lblAntsCount.Dock = DockStyle.Fill;
            lblAntsCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAntsCount.ForeColor = Color.Black;
            lblAntsCount.Location = new Point(4, 289);
            lblAntsCount.Name = "lblAntsCount";
            lblAntsCount.Size = new Size(272, 35);
            lblAntsCount.TabIndex = 14;
            lblAntsCount.Text = "Количество муравьев:";
            lblAntsCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIterationsNumber
            // 
            lblIterationsNumber.Dock = DockStyle.Fill;
            lblIterationsNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblIterationsNumber.ForeColor = Color.Black;
            lblIterationsNumber.Location = new Point(4, 361);
            lblIterationsNumber.Name = "lblIterationsNumber";
            lblIterationsNumber.Size = new Size(272, 35);
            lblIterationsNumber.TabIndex = 14;
            lblIterationsNumber.Text = "Количество итераций:";
            lblIterationsNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numUpDownBeta
            // 
            numUpDownBeta.BackColor = Color.WhiteSmoke;
            numUpDownBeta.BorderStyle = BorderStyle.FixedSingle;
            numUpDownBeta.DecimalPlaces = 1;
            numUpDownBeta.Dock = DockStyle.Fill;
            numUpDownBeta.Font = new Font("Segoe UI", 12F);
            numUpDownBeta.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownBeta.Location = new Point(4, 109);
            numUpDownBeta.Margin = new Padding(3, 0, 3, 0);
            numUpDownBeta.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUpDownBeta.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownBeta.Name = "numUpDownBeta";
            numUpDownBeta.Size = new Size(272, 29);
            numUpDownBeta.TabIndex = 5;
            numUpDownBeta.Value = new decimal(new int[] { 20, 0, 0, 65536 });
            // 
            // numUpDownEvaporation
            // 
            numUpDownEvaporation.BackColor = Color.WhiteSmoke;
            numUpDownEvaporation.BorderStyle = BorderStyle.FixedSingle;
            numUpDownEvaporation.DecimalPlaces = 1;
            numUpDownEvaporation.Dock = DockStyle.Fill;
            numUpDownEvaporation.Font = new Font("Segoe UI", 12F);
            numUpDownEvaporation.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownEvaporation.Location = new Point(4, 181);
            numUpDownEvaporation.Margin = new Padding(3, 0, 3, 0);
            numUpDownEvaporation.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numUpDownEvaporation.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numUpDownEvaporation.Name = "numUpDownEvaporation";
            numUpDownEvaporation.Size = new Size(272, 29);
            numUpDownEvaporation.TabIndex = 5;
            numUpDownEvaporation.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // numUpDownPheromoneAmount
            // 
            numUpDownPheromoneAmount.BackColor = Color.WhiteSmoke;
            numUpDownPheromoneAmount.BorderStyle = BorderStyle.FixedSingle;
            numUpDownPheromoneAmount.DecimalPlaces = 1;
            numUpDownPheromoneAmount.Dock = DockStyle.Fill;
            numUpDownPheromoneAmount.Font = new Font("Segoe UI", 12F);
            numUpDownPheromoneAmount.Location = new Point(4, 253);
            numUpDownPheromoneAmount.Margin = new Padding(3, 0, 3, 0);
            numUpDownPheromoneAmount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDownPheromoneAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownPheromoneAmount.Name = "numUpDownPheromoneAmount";
            numUpDownPheromoneAmount.Size = new Size(272, 29);
            numUpDownPheromoneAmount.TabIndex = 5;
            numUpDownPheromoneAmount.Value = new decimal(new int[] { 1000, 0, 0, 65536 });
            // 
            // numUpDownAntsCount
            // 
            numUpDownAntsCount.BackColor = Color.WhiteSmoke;
            numUpDownAntsCount.BorderStyle = BorderStyle.FixedSingle;
            numUpDownAntsCount.Dock = DockStyle.Fill;
            numUpDownAntsCount.Font = new Font("Segoe UI", 12F);
            numUpDownAntsCount.Location = new Point(4, 325);
            numUpDownAntsCount.Margin = new Padding(3, 0, 3, 0);
            numUpDownAntsCount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numUpDownAntsCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownAntsCount.Name = "numUpDownAntsCount";
            numUpDownAntsCount.Size = new Size(272, 29);
            numUpDownAntsCount.TabIndex = 5;
            numUpDownAntsCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numUpDownIterationsNumber
            // 
            numUpDownIterationsNumber.BackColor = Color.WhiteSmoke;
            numUpDownIterationsNumber.BorderStyle = BorderStyle.FixedSingle;
            numUpDownIterationsNumber.Dock = DockStyle.Fill;
            numUpDownIterationsNumber.Font = new Font("Segoe UI", 12F);
            numUpDownIterationsNumber.Location = new Point(4, 397);
            numUpDownIterationsNumber.Margin = new Padding(3, 0, 3, 0);
            numUpDownIterationsNumber.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numUpDownIterationsNumber.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numUpDownIterationsNumber.Name = "numUpDownIterationsNumber";
            numUpDownIterationsNumber.Size = new Size(272, 29);
            numUpDownIterationsNumber.TabIndex = 5;
            numUpDownIterationsNumber.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // panelOuterView
            // 
            panelOuterView.BackColor = Color.FromArgb(170, 170, 170);
            panelOuterView.Controls.Add(panelView);
            panelOuterView.Location = new Point(3, 3);
            panelOuterView.Name = "panelOuterView";
            panelOuterView.Padding = new Padding(1);
            panelOuterView.Size = new Size(770, 600);
            panelOuterView.TabIndex = 1;
            // 
            // panelView
            // 
            panelView.BackColor = Color.FromArgb(235, 235, 235);
            panelView.Dock = DockStyle.Fill;
            panelView.Location = new Point(1, 1);
            panelView.Name = "panelView";
            panelView.Size = new Size(768, 598);
            panelView.TabIndex = 1;
            panelView.Paint += panelView_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(27, 117, 208);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1351, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // GraphViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 710);
            Controls.Add(panelOuterMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GraphViewer";
            Text = "GraphViewer";
            panelOuterMain.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            tlpResult.ResumeLayout(false);
            tlpStartEndSpots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numUpDownStartSpot).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownEndSpot).EndInit();
            panelOuterSettingsHolder.ResumeLayout(false);
            panelSettingsHolder.ResumeLayout(false);
            tlpSettings.ResumeLayout(false);
            tlpNavigation.ResumeLayout(false);
            tlpParametersHolder.ResumeLayout(false);
            tlpParameters2.ResumeLayout(false);
            tlpParameters2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownRandomGraphSize).EndInit();
            tlpParameters1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numUpDownAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownBeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownEvaporation).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownPheromoneAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownAntsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownIterationsNumber).EndInit();
            panelOuterView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOuterMain;
        private Panel panelMain;
        private Panel panelOuterSettingsHolder;
        private Panel panelSettingsHolder;
        private Panel panelOuterView;
        private Panel panelView;
        private Button btnClose;
        private TableLayoutPanel tlpSettings;
        private Button btnCreateGraph;
        private Label lblInput;
        private TableLayoutPanel tlpNavigation;
        private Button btnForward;
        private Label lblStage;
        private Button btnBack;
        private TableLayoutPanel tlpParameters1;
        private Label lblAlpha;
        private Label lblBeta;
        private Label lblEvaporation;
        private Label lblPheromoneAmount;
        private Label lblAntsCount;
        private Label lblIterationsNumber;
        private NumericUpDown numUpDownAlpha;
        private NumericUpDown numUpDownBeta;
        private NumericUpDown numUpDownEvaporation;
        private NumericUpDown numUpDownPheromoneAmount;
        private NumericUpDown numUpDownAntsCount;
        private NumericUpDown numUpDownIterationsNumber;
        private TableLayoutPanel tlpParametersHolder;
        private TableLayoutPanel tlpParameters2;
        private CheckBox cbRandomGraph;
        private Label lblRandomGraph;
        private NumericUpDown numUpDownRandomGraphSize;
        private Label lblCustomGraph;
        private TextBox tbCustomGraph;
        private TableLayoutPanel tlpResult;
        private Label lblBestRouteValue;
        private Label lblBestLength;
        private Label lblBestRoute;
        private Label lblBestLengthValue;
        private TableLayoutPanel tlpStartEndSpots;
        private Label lblStartSpot;
        private NumericUpDown numUpDownStartSpot;
        private NumericUpDown numUpDownEndSpot;
        private Label lblEndSpot;
    }
}
