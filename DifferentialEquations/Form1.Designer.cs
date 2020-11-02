namespace DifferentialEquations
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPanelControl = new System.Windows.Forms.TabControl();
            this.tabIVPSolutions = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chartIVP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLTE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabErrorAnalysis = new System.Windows.Forms.TabPage();
            this.chartEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlotAnalyze = new System.Windows.Forms.Button();
            this.checkBoxRungeKutta = new System.Windows.Forms.CheckBox();
            this.checkBoxImprovedEuler = new System.Windows.Forms.CheckBox();
            this.checkBoxEuler = new System.Windows.Forms.CheckBox();
            this.labelDisplayChoice = new System.Windows.Forms.Label();
            this.checkBoxExact = new System.Windows.Forms.CheckBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxy0 = new System.Windows.Forms.TextBox();
            this.textBoxx0 = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labely0 = new System.Windows.Forms.Label();
            this.labelx0 = new System.Windows.Forms.Label();
            this.labelIVPInput = new System.Windows.Forms.Label();
            this.textBoxnFinish = new System.Windows.Forms.TextBox();
            this.textBoxnStart = new System.Windows.Forms.TextBox();
            this.labelnFinish = new System.Windows.Forms.Label();
            this.labelnStart = new System.Windows.Forms.Label();
            this.labelEAInput = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabPanelControl.SuspendLayout();
            this.tabIVPSolutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLTE)).BeginInit();
            this.tabErrorAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanelControl
            // 
            this.tabPanelControl.Controls.Add(this.tabIVPSolutions);
            this.tabPanelControl.Controls.Add(this.tabErrorAnalysis);
            this.tabPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelControl.Location = new System.Drawing.Point(0, 0);
            this.tabPanelControl.Name = "tabPanelControl";
            this.tabPanelControl.SelectedIndex = 0;
            this.tabPanelControl.Size = new System.Drawing.Size(798, 702);
            this.tabPanelControl.TabIndex = 0;
            // 
            // tabIVPSolutions
            // 
            this.tabIVPSolutions.Controls.Add(this.splitContainer1);
            this.tabIVPSolutions.Location = new System.Drawing.Point(4, 25);
            this.tabIVPSolutions.Name = "tabIVPSolutions";
            this.tabIVPSolutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVPSolutions.Size = new System.Drawing.Size(790, 673);
            this.tabIVPSolutions.TabIndex = 0;
            this.tabIVPSolutions.Text = "IVP solutions";
            this.tabIVPSolutions.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartIVP);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartLTE);
            this.splitContainer1.Size = new System.Drawing.Size(784, 667);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // chartIVP
            // 
            chartArea13.CursorX.IsUserEnabled = true;
            chartArea13.CursorX.IsUserSelectionEnabled = true;
            chartArea13.CursorY.IsUserEnabled = true;
            chartArea13.CursorY.IsUserSelectionEnabled = true;
            chartArea13.Name = "ChartArea1";
            this.chartIVP.ChartAreas.Add(chartArea13);
            this.chartIVP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Name = "Legend1";
            legend13.Title = "IVP";
            this.chartIVP.Legends.Add(legend13);
            this.chartIVP.Location = new System.Drawing.Point(0, 0);
            this.chartIVP.Name = "chartIVP";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series41.Color = System.Drawing.Color.Red;
            series41.Legend = "Legend1";
            series41.Name = "Exact";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series42.Color = System.Drawing.Color.Blue;
            series42.Legend = "Legend1";
            series42.Name = "Euler";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series43.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series43.Legend = "Legend1";
            series43.Name = "ImprovedEuler";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series44.Color = System.Drawing.Color.Lime;
            series44.Legend = "Legend1";
            series44.Name = "RungeKutta";
            this.chartIVP.Series.Add(series41);
            this.chartIVP.Series.Add(series42);
            this.chartIVP.Series.Add(series43);
            this.chartIVP.Series.Add(series44);
            this.chartIVP.Size = new System.Drawing.Size(782, 259);
            this.chartIVP.TabIndex = 0;
            this.chartIVP.Text = "chartIVP";
            // 
            // chartLTE
            // 
            chartArea14.CursorX.IsUserEnabled = true;
            chartArea14.CursorX.IsUserSelectionEnabled = true;
            chartArea14.Name = "ChartArea1";
            this.chartLTE.ChartAreas.Add(chartArea14);
            this.chartLTE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend14.Name = "Legend1";
            legend14.Title = "LTE";
            this.chartLTE.Legends.Add(legend14);
            this.chartLTE.Location = new System.Drawing.Point(0, 0);
            this.chartLTE.Name = "chartLTE";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series45.Color = System.Drawing.Color.Blue;
            series45.Legend = "Legend1";
            series45.Name = "Euler";
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series46.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series46.Legend = "Legend1";
            series46.Name = "ImprovedEuler";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series47.Color = System.Drawing.Color.Lime;
            series47.Legend = "Legend1";
            series47.Name = "RungeKutta";
            this.chartLTE.Series.Add(series45);
            this.chartLTE.Series.Add(series46);
            this.chartLTE.Series.Add(series47);
            this.chartLTE.Size = new System.Drawing.Size(782, 400);
            this.chartLTE.TabIndex = 0;
            this.chartLTE.Text = "chartLTE";
            // 
            // tabErrorAnalysis
            // 
            this.tabErrorAnalysis.Controls.Add(this.chartEA);
            this.tabErrorAnalysis.Location = new System.Drawing.Point(4, 25);
            this.tabErrorAnalysis.Name = "tabErrorAnalysis";
            this.tabErrorAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrorAnalysis.Size = new System.Drawing.Size(790, 673);
            this.tabErrorAnalysis.TabIndex = 1;
            this.tabErrorAnalysis.Text = "Error analysis";
            this.tabErrorAnalysis.UseVisualStyleBackColor = true;
            // 
            // chartEA
            // 
            chartArea15.CursorX.IsUserEnabled = true;
            chartArea15.CursorX.IsUserSelectionEnabled = true;
            chartArea15.CursorY.IsUserEnabled = true;
            chartArea15.CursorY.IsUserSelectionEnabled = true;
            chartArea15.Name = "ChartArea1";
            this.chartEA.ChartAreas.Add(chartArea15);
            this.chartEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Name = "Legend1";
            legend15.Title = "GTE";
            this.chartEA.Legends.Add(legend15);
            this.chartEA.Location = new System.Drawing.Point(3, 3);
            this.chartEA.Name = "chartEA";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series48.Color = System.Drawing.Color.Blue;
            series48.Legend = "Legend1";
            series48.Name = "Euler";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series49.Legend = "Legend1";
            series49.Name = "ImprovedEuler";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Color = System.Drawing.Color.Lime;
            series50.Legend = "Legend1";
            series50.Name = "RungeKutta";
            this.chartEA.Series.Add(series48);
            this.chartEA.Series.Add(series49);
            this.chartEA.Series.Add(series50);
            this.chartEA.Size = new System.Drawing.Size(784, 667);
            this.chartEA.TabIndex = 0;
            this.chartEA.Text = "chartEA";
            // 
            // buttonPlotAnalyze
            // 
            this.buttonPlotAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlotAnalyze.Location = new System.Drawing.Point(11, 557);
            this.buttonPlotAnalyze.Name = "buttonPlotAnalyze";
            this.buttonPlotAnalyze.Size = new System.Drawing.Size(328, 34);
            this.buttonPlotAnalyze.TabIndex = 15;
            this.buttonPlotAnalyze.Text = "Plot and Analyze!";
            this.buttonPlotAnalyze.UseVisualStyleBackColor = true;
            this.buttonPlotAnalyze.Click += new System.EventHandler(this.buttonIVPPlotClick);
            // 
            // checkBoxRungeKutta
            // 
            this.checkBoxRungeKutta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRungeKutta.AutoSize = true;
            this.checkBoxRungeKutta.Checked = true;
            this.checkBoxRungeKutta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRungeKutta.Location = new System.Drawing.Point(11, 501);
            this.checkBoxRungeKutta.Name = "checkBoxRungeKutta";
            this.checkBoxRungeKutta.Size = new System.Drawing.Size(205, 28);
            this.checkBoxRungeKutta.TabIndex = 14;
            this.checkBoxRungeKutta.Text = "Runge-Kutta method";
            this.checkBoxRungeKutta.UseVisualStyleBackColor = true;
            this.checkBoxRungeKutta.CheckedChanged += new System.EventHandler(this.checkBoxIVPRungeKuttaCheckedChanged);
            // 
            // checkBoxImprovedEuler
            // 
            this.checkBoxImprovedEuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxImprovedEuler.AutoSize = true;
            this.checkBoxImprovedEuler.Checked = true;
            this.checkBoxImprovedEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImprovedEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxImprovedEuler.Location = new System.Drawing.Point(11, 467);
            this.checkBoxImprovedEuler.Name = "checkBoxImprovedEuler";
            this.checkBoxImprovedEuler.Size = new System.Drawing.Size(230, 28);
            this.checkBoxImprovedEuler.TabIndex = 13;
            this.checkBoxImprovedEuler.Text = "Improved Euler method";
            this.checkBoxImprovedEuler.UseVisualStyleBackColor = true;
            this.checkBoxImprovedEuler.CheckedChanged += new System.EventHandler(this.checkBoxIVPImprovedEulerCheckedChanged);
            // 
            // checkBoxEuler
            // 
            this.checkBoxEuler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEuler.AutoSize = true;
            this.checkBoxEuler.Checked = true;
            this.checkBoxEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEuler.Location = new System.Drawing.Point(11, 433);
            this.checkBoxEuler.Name = "checkBoxEuler";
            this.checkBoxEuler.Size = new System.Drawing.Size(146, 28);
            this.checkBoxEuler.TabIndex = 12;
            this.checkBoxEuler.Text = "Euler method";
            this.checkBoxEuler.UseVisualStyleBackColor = true;
            this.checkBoxEuler.CheckedChanged += new System.EventHandler(this.checkBoxIVPEulerCheckedChanged);
            // 
            // labelDisplayChoice
            // 
            this.labelDisplayChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDisplayChoice.AutoSize = true;
            this.labelDisplayChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDisplayChoice.Location = new System.Drawing.Point(3, 348);
            this.labelDisplayChoice.Name = "labelDisplayChoice";
            this.labelDisplayChoice.Padding = new System.Windows.Forms.Padding(5);
            this.labelDisplayChoice.Size = new System.Drawing.Size(255, 36);
            this.labelDisplayChoice.TabIndex = 11;
            this.labelDisplayChoice.Text = "Choose solutions to display:";
            // 
            // checkBoxExact
            // 
            this.checkBoxExact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExact.AutoSize = true;
            this.checkBoxExact.Checked = true;
            this.checkBoxExact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxExact.Location = new System.Drawing.Point(11, 399);
            this.checkBoxExact.Name = "checkBoxExact";
            this.checkBoxExact.Size = new System.Drawing.Size(79, 28);
            this.checkBoxExact.TabIndex = 10;
            this.checkBoxExact.Text = "Exact";
            this.checkBoxExact.UseVisualStyleBackColor = true;
            this.checkBoxExact.CheckedChanged += new System.EventHandler(this.checkBoxIVPExactCheckedChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxN.Location = new System.Drawing.Point(106, 165);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(233, 28);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.Text = "10";
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(106, 131);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(233, 28);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.Text = "8";
            // 
            // textBoxy0
            // 
            this.textBoxy0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxy0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxy0.Location = new System.Drawing.Point(106, 97);
            this.textBoxy0.Name = "textBoxy0";
            this.textBoxy0.Size = new System.Drawing.Size(233, 28);
            this.textBoxy0.TabIndex = 7;
            this.textBoxy0.Text = "0";
            // 
            // textBoxx0
            // 
            this.textBoxx0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxx0.Location = new System.Drawing.Point(106, 63);
            this.textBoxx0.Name = "textBoxx0";
            this.textBoxx0.Size = new System.Drawing.Size(233, 28);
            this.textBoxx0.TabIndex = 6;
            this.textBoxx0.Text = "1";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(61, 169);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(29, 24);
            this.labelN.TabIndex = 5;
            this.labelN.Text = "N:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(61, 135);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(29, 24);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X:";
            // 
            // labely0
            // 
            this.labely0.AutoSize = true;
            this.labely0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labely0.Location = new System.Drawing.Point(56, 101);
            this.labely0.Name = "labely0";
            this.labely0.Size = new System.Drawing.Size(34, 24);
            this.labely0.TabIndex = 3;
            this.labely0.Text = "y0:";
            // 
            // labelx0
            // 
            this.labelx0.AutoSize = true;
            this.labelx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelx0.Location = new System.Drawing.Point(55, 67);
            this.labelx0.Name = "labelx0";
            this.labelx0.Size = new System.Drawing.Size(35, 24);
            this.labelx0.TabIndex = 2;
            this.labelx0.Text = "x0:";
            // 
            // labelIVPInput
            // 
            this.labelIVPInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIVPInput.AutoSize = true;
            this.labelIVPInput.BackColor = System.Drawing.Color.Transparent;
            this.labelIVPInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIVPInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPInput.Location = new System.Drawing.Point(3, 8);
            this.labelIVPInput.Name = "labelIVPInput";
            this.labelIVPInput.Padding = new System.Windows.Forms.Padding(5);
            this.labelIVPInput.Size = new System.Drawing.Size(221, 36);
            this.labelIVPInput.TabIndex = 1;
            this.labelIVPInput.Text = "Input parameters of IVP:";
            // 
            // textBoxnFinish
            // 
            this.textBoxnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnFinish.Location = new System.Drawing.Point(106, 294);
            this.textBoxnFinish.Name = "textBoxnFinish";
            this.textBoxnFinish.Size = new System.Drawing.Size(233, 28);
            this.textBoxnFinish.TabIndex = 22;
            this.textBoxnFinish.Text = "100";
            // 
            // textBoxnStart
            // 
            this.textBoxnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnStart.Location = new System.Drawing.Point(106, 260);
            this.textBoxnStart.Name = "textBoxnStart";
            this.textBoxnStart.Size = new System.Drawing.Size(233, 28);
            this.textBoxnStart.TabIndex = 21;
            this.textBoxnStart.Text = "50";
            // 
            // labelnFinish
            // 
            this.labelnFinish.AutoSize = true;
            this.labelnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnFinish.Location = new System.Drawing.Point(13, 298);
            this.labelnFinish.Name = "labelnFinish";
            this.labelnFinish.Size = new System.Drawing.Size(77, 24);
            this.labelnFinish.TabIndex = 18;
            this.labelnFinish.Text = "nFinish:";
            // 
            // labelnStart
            // 
            this.labelnStart.AutoSize = true;
            this.labelnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelnStart.Location = new System.Drawing.Point(28, 264);
            this.labelnStart.Name = "labelnStart";
            this.labelnStart.Size = new System.Drawing.Size(62, 24);
            this.labelnStart.TabIndex = 17;
            this.labelnStart.Text = "nStart:";
            // 
            // labelEAInput
            // 
            this.labelEAInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEAInput.AutoSize = true;
            this.labelEAInput.BackColor = System.Drawing.Color.Transparent;
            this.labelEAInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEAInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEAInput.Location = new System.Drawing.Point(3, 209);
            this.labelEAInput.Name = "labelEAInput";
            this.labelEAInput.Padding = new System.Windows.Forms.Padding(5);
            this.labelEAInput.Size = new System.Drawing.Size(219, 36);
            this.labelEAInput.TabIndex = 16;
            this.labelEAInput.Text = "Input range for analysis:";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabPanelControl);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonPlotAnalyze);
            this.splitContainer3.Panel2.Controls.Add(this.labelIVPInput);
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxRungeKutta);
            this.splitContainer3.Panel2.Controls.Add(this.labelx0);
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxImprovedEuler);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxx0);
            this.splitContainer3.Panel2.Controls.Add(this.labelEAInput);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxnFinish);
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxEuler);
            this.splitContainer3.Panel2.Controls.Add(this.labelnFinish);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxnStart);
            this.splitContainer3.Panel2.Controls.Add(this.labely0);
            this.splitContainer3.Panel2.Controls.Add(this.checkBoxExact);
            this.splitContainer3.Panel2.Controls.Add(this.labelnStart);
            this.splitContainer3.Panel2.Controls.Add(this.labelDisplayChoice);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxy0);
            this.splitContainer3.Panel2.Controls.Add(this.labelX);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxN);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxX);
            this.splitContainer3.Panel2.Controls.Add(this.labelN);
            this.splitContainer3.Size = new System.Drawing.Size(1237, 704);
            this.splitContainer3.SplitterDistance = 800;
            this.splitContainer3.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 704);
            this.Controls.Add(this.splitContainer3);
            this.Name = "MainForm";
            this.Text = "DE Project";
            this.tabPanelControl.ResumeLayout(false);
            this.tabIVPSolutions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLTE)).EndInit();
            this.tabErrorAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEA)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanelControl;
        private System.Windows.Forms.TabPage tabIVPSolutions;
        private System.Windows.Forms.TabPage tabErrorAnalysis;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labely0;
        private System.Windows.Forms.Label labelx0;
        private System.Windows.Forms.Label labelIVPInput;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxy0;
        private System.Windows.Forms.TextBox textBoxx0;
        private System.Windows.Forms.Label labelDisplayChoice;
        private System.Windows.Forms.CheckBox checkBoxExact;
        private System.Windows.Forms.Button buttonPlotAnalyze;
        private System.Windows.Forms.CheckBox checkBoxRungeKutta;
        private System.Windows.Forms.CheckBox checkBoxImprovedEuler;
        private System.Windows.Forms.CheckBox checkBoxEuler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEA;
        private System.Windows.Forms.TextBox textBoxnFinish;
        private System.Windows.Forms.TextBox textBoxnStart;
        private System.Windows.Forms.Label labelnFinish;
        private System.Windows.Forms.Label labelnStart;
        private System.Windows.Forms.Label labelEAInput;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIVP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLTE;
    }
}

