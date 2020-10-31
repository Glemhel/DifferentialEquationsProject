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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabPanelControl = new System.Windows.Forms.TabControl();
            this.tabIVPSolutions = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chartIVP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLTE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonIVPPlot = new System.Windows.Forms.Button();
            this.checkBoxIVPRungeKutta = new System.Windows.Forms.CheckBox();
            this.checkBoxIVPImprovedEuler = new System.Windows.Forms.CheckBox();
            this.checkBoxIVPEuler = new System.Windows.Forms.CheckBox();
            this.labelIVPDisplayChoice = new System.Windows.Forms.Label();
            this.checkBoxIVPExact = new System.Windows.Forms.CheckBox();
            this.textBoxIVPN = new System.Windows.Forms.TextBox();
            this.textBoxIVPX = new System.Windows.Forms.TextBox();
            this.textBoxIVPy0 = new System.Windows.Forms.TextBox();
            this.textBoxIVPx0 = new System.Windows.Forms.TextBox();
            this.labelVPN = new System.Windows.Forms.Label();
            this.labelIVPX = new System.Windows.Forms.Label();
            this.labelIVPy0 = new System.Windows.Forms.Label();
            this.labelIVPx0 = new System.Windows.Forms.Label();
            this.labelIVPInput = new System.Windows.Forms.Label();
            this.tabErrorAnalysis = new System.Windows.Forms.TabPage();
            this.splitContainerEA = new System.Windows.Forms.SplitContainer();
            this.chartEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEAPlot = new System.Windows.Forms.Button();
            this.checkBoxEARungeKutta = new System.Windows.Forms.CheckBox();
            this.checkBoxEAImprovedEuler = new System.Windows.Forms.CheckBox();
            this.checkBoxEAEuler = new System.Windows.Forms.CheckBox();
            this.labelEADisplayChoice = new System.Windows.Forms.Label();
            this.checkBoxEAExact = new System.Windows.Forms.CheckBox();
            this.textBoxEAN = new System.Windows.Forms.TextBox();
            this.textBoxEAn0 = new System.Windows.Forms.TextBox();
            this.labelEAN = new System.Windows.Forms.Label();
            this.labelEAn0 = new System.Windows.Forms.Label();
            this.labelEAInput = new System.Windows.Forms.Label();
            this.tabPanelControl.SuspendLayout();
            this.tabIVPSolutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLTE)).BeginInit();
            this.tabErrorAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEA)).BeginInit();
            this.splitContainerEA.Panel1.SuspendLayout();
            this.splitContainerEA.Panel2.SuspendLayout();
            this.splitContainerEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEA)).BeginInit();
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
            this.tabPanelControl.Size = new System.Drawing.Size(1132, 706);
            this.tabPanelControl.TabIndex = 0;
            // 
            // tabIVPSolutions
            // 
            this.tabIVPSolutions.Controls.Add(this.splitContainer1);
            this.tabIVPSolutions.Location = new System.Drawing.Point(4, 25);
            this.tabIVPSolutions.Name = "tabIVPSolutions";
            this.tabIVPSolutions.Padding = new System.Windows.Forms.Padding(3);
            this.tabIVPSolutions.Size = new System.Drawing.Size(1124, 677);
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
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonIVPPlot);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIVPRungeKutta);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIVPImprovedEuler);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIVPEuler);
            this.splitContainer1.Panel2.Controls.Add(this.labelIVPDisplayChoice);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxIVPExact);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIVPN);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIVPX);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIVPy0);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxIVPx0);
            this.splitContainer1.Panel2.Controls.Add(this.labelVPN);
            this.splitContainer1.Panel2.Controls.Add(this.labelIVPX);
            this.splitContainer1.Panel2.Controls.Add(this.labelIVPy0);
            this.splitContainer1.Panel2.Controls.Add(this.labelIVPx0);
            this.splitContainer1.Panel2.Controls.Add(this.labelIVPInput);
            this.splitContainer1.Size = new System.Drawing.Size(1118, 671);
            this.splitContainer1.SplitterDistance = 651;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chartIVP);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chartLTE);
            this.splitContainer2.Size = new System.Drawing.Size(651, 671);
            this.splitContainer2.SplitterDistance = 335;
            this.splitContainer2.TabIndex = 0;
            // 
            // chartIVP
            // 
            chartArea5.Name = "ChartArea1";
            this.chartIVP.ChartAreas.Add(chartArea5);
            this.chartIVP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartIVP.Legends.Add(legend5);
            this.chartIVP.Location = new System.Drawing.Point(0, 0);
            this.chartIVP.Name = "chartIVP";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.Red;
            series16.Legend = "Legend1";
            series16.Name = "Exact";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Color = System.Drawing.Color.Blue;
            series17.Legend = "Legend1";
            series17.Name = "Euler";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series18.Legend = "Legend1";
            series18.Name = "ImprovedEuler";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Color = System.Drawing.Color.Lime;
            series19.Legend = "Legend1";
            series19.Name = "RungeKutta";
            this.chartIVP.Series.Add(series16);
            this.chartIVP.Series.Add(series17);
            this.chartIVP.Series.Add(series18);
            this.chartIVP.Series.Add(series19);
            this.chartIVP.Size = new System.Drawing.Size(649, 333);
            this.chartIVP.TabIndex = 0;
            this.chartIVP.Text = "chartIVP";
            // 
            // chartLTE
            // 
            chartArea6.Name = "ChartArea1";
            this.chartLTE.ChartAreas.Add(chartArea6);
            this.chartLTE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartLTE.Legends.Add(legend6);
            this.chartLTE.Location = new System.Drawing.Point(0, 0);
            this.chartLTE.Name = "chartLTE";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Color = System.Drawing.Color.Blue;
            series20.Legend = "Legend1";
            series20.Name = "Euler";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series21.Legend = "Legend1";
            series21.Name = "ImprovedEuler";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Color = System.Drawing.Color.Lime;
            series22.Legend = "Legend1";
            series22.Name = "RungeKutta";
            this.chartLTE.Series.Add(series20);
            this.chartLTE.Series.Add(series21);
            this.chartLTE.Series.Add(series22);
            this.chartLTE.Size = new System.Drawing.Size(649, 330);
            this.chartLTE.TabIndex = 0;
            this.chartLTE.Text = "chartLTE";
            // 
            // buttonIVPPlot
            // 
            this.buttonIVPPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIVPPlot.Location = new System.Drawing.Point(12, 395);
            this.buttonIVPPlot.Name = "buttonIVPPlot";
            this.buttonIVPPlot.Size = new System.Drawing.Size(328, 34);
            this.buttonIVPPlot.TabIndex = 15;
            this.buttonIVPPlot.Text = "Plot!";
            this.buttonIVPPlot.UseVisualStyleBackColor = true;
            this.buttonIVPPlot.Click += new System.EventHandler(this.button_plot_click);
            // 
            // checkBoxIVPRungeKutta
            // 
            this.checkBoxIVPRungeKutta.AutoSize = true;
            this.checkBoxIVPRungeKutta.Checked = true;
            this.checkBoxIVPRungeKutta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIVPRungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIVPRungeKutta.Location = new System.Drawing.Point(12, 348);
            this.checkBoxIVPRungeKutta.Name = "checkBoxIVPRungeKutta";
            this.checkBoxIVPRungeKutta.Size = new System.Drawing.Size(205, 28);
            this.checkBoxIVPRungeKutta.TabIndex = 14;
            this.checkBoxIVPRungeKutta.Text = "Runge-Kutta method";
            this.checkBoxIVPRungeKutta.UseVisualStyleBackColor = true;
            this.checkBoxIVPRungeKutta.CheckedChanged += new System.EventHandler(this.checkBoxIVPRungeKuttaCheckedChanged);
            // 
            // checkBoxIVPImprovedEuler
            // 
            this.checkBoxIVPImprovedEuler.AutoSize = true;
            this.checkBoxIVPImprovedEuler.Checked = true;
            this.checkBoxIVPImprovedEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIVPImprovedEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIVPImprovedEuler.Location = new System.Drawing.Point(12, 306);
            this.checkBoxIVPImprovedEuler.Name = "checkBoxIVPImprovedEuler";
            this.checkBoxIVPImprovedEuler.Size = new System.Drawing.Size(230, 28);
            this.checkBoxIVPImprovedEuler.TabIndex = 13;
            this.checkBoxIVPImprovedEuler.Text = "Improved Euler method";
            this.checkBoxIVPImprovedEuler.UseVisualStyleBackColor = true;
            this.checkBoxIVPImprovedEuler.CheckedChanged += new System.EventHandler(this.checkBoxIVPImprovedEulerCheckedChanged);
            // 
            // checkBoxIVPEuler
            // 
            this.checkBoxIVPEuler.AutoSize = true;
            this.checkBoxIVPEuler.Checked = true;
            this.checkBoxIVPEuler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIVPEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIVPEuler.Location = new System.Drawing.Point(12, 262);
            this.checkBoxIVPEuler.Name = "checkBoxIVPEuler";
            this.checkBoxIVPEuler.Size = new System.Drawing.Size(146, 28);
            this.checkBoxIVPEuler.TabIndex = 12;
            this.checkBoxIVPEuler.Text = "Euler method";
            this.checkBoxIVPEuler.UseVisualStyleBackColor = true;
            this.checkBoxIVPEuler.CheckedChanged += new System.EventHandler(this.checkBoxIVPEulerCheckedChanged);
            // 
            // labelIVPDisplayChoice
            // 
            this.labelIVPDisplayChoice.AutoSize = true;
            this.labelIVPDisplayChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIVPDisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPDisplayChoice.Location = new System.Drawing.Point(12, 181);
            this.labelIVPDisplayChoice.Name = "labelIVPDisplayChoice";
            this.labelIVPDisplayChoice.Padding = new System.Windows.Forms.Padding(5);
            this.labelIVPDisplayChoice.Size = new System.Drawing.Size(255, 36);
            this.labelIVPDisplayChoice.TabIndex = 11;
            this.labelIVPDisplayChoice.Text = "Choose solutions to display:";
            // 
            // checkBoxIVPExact
            // 
            this.checkBoxIVPExact.AutoSize = true;
            this.checkBoxIVPExact.Checked = true;
            this.checkBoxIVPExact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIVPExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxIVPExact.Location = new System.Drawing.Point(12, 224);
            this.checkBoxIVPExact.Name = "checkBoxIVPExact";
            this.checkBoxIVPExact.Size = new System.Drawing.Size(79, 28);
            this.checkBoxIVPExact.TabIndex = 10;
            this.checkBoxIVPExact.Text = "Exact";
            this.checkBoxIVPExact.UseVisualStyleBackColor = true;
            this.checkBoxIVPExact.CheckedChanged += new System.EventHandler(this.checkBoxIVPExactCheckedChanged);
            // 
            // textBoxIVPN
            // 
            this.textBoxIVPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIVPN.Location = new System.Drawing.Point(46, 146);
            this.textBoxIVPN.Name = "textBoxIVPN";
            this.textBoxIVPN.Size = new System.Drawing.Size(233, 28);
            this.textBoxIVPN.TabIndex = 9;
            this.textBoxIVPN.Text = "10";
            // 
            // textBoxIVPX
            // 
            this.textBoxIVPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIVPX.Location = new System.Drawing.Point(46, 118);
            this.textBoxIVPX.Name = "textBoxIVPX";
            this.textBoxIVPX.Size = new System.Drawing.Size(233, 28);
            this.textBoxIVPX.TabIndex = 8;
            this.textBoxIVPX.Text = "8";
            // 
            // textBoxIVPy0
            // 
            this.textBoxIVPy0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIVPy0.Location = new System.Drawing.Point(46, 88);
            this.textBoxIVPy0.Name = "textBoxIVPy0";
            this.textBoxIVPy0.Size = new System.Drawing.Size(233, 28);
            this.textBoxIVPy0.TabIndex = 7;
            this.textBoxIVPy0.Text = "0";
            // 
            // textBoxIVPx0
            // 
            this.textBoxIVPx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIVPx0.Location = new System.Drawing.Point(46, 57);
            this.textBoxIVPx0.Name = "textBoxIVPx0";
            this.textBoxIVPx0.Size = new System.Drawing.Size(233, 28);
            this.textBoxIVPx0.TabIndex = 6;
            this.textBoxIVPx0.Text = "1";
            // 
            // labelVPN
            // 
            this.labelVPN.AutoSize = true;
            this.labelVPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVPN.Location = new System.Drawing.Point(12, 151);
            this.labelVPN.Name = "labelVPN";
            this.labelVPN.Size = new System.Drawing.Size(29, 24);
            this.labelVPN.TabIndex = 5;
            this.labelVPN.Text = "N:";
            // 
            // labelIVPX
            // 
            this.labelIVPX.AutoSize = true;
            this.labelIVPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPX.Location = new System.Drawing.Point(13, 123);
            this.labelIVPX.Name = "labelIVPX";
            this.labelIVPX.Size = new System.Drawing.Size(29, 24);
            this.labelIVPX.TabIndex = 4;
            this.labelIVPX.Text = "X:";
            // 
            // labelIVPy0
            // 
            this.labelIVPy0.AutoSize = true;
            this.labelIVPy0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPy0.Location = new System.Drawing.Point(12, 93);
            this.labelIVPy0.Name = "labelIVPy0";
            this.labelIVPy0.Size = new System.Drawing.Size(34, 24);
            this.labelIVPy0.TabIndex = 3;
            this.labelIVPy0.Text = "y0:";
            // 
            // labelIVPx0
            // 
            this.labelIVPx0.AutoSize = true;
            this.labelIVPx0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPx0.Location = new System.Drawing.Point(12, 62);
            this.labelIVPx0.Name = "labelIVPx0";
            this.labelIVPx0.Size = new System.Drawing.Size(35, 24);
            this.labelIVPx0.TabIndex = 2;
            this.labelIVPx0.Text = "x0:";
            // 
            // labelIVPInput
            // 
            this.labelIVPInput.AutoSize = true;
            this.labelIVPInput.BackColor = System.Drawing.Color.Transparent;
            this.labelIVPInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIVPInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIVPInput.Location = new System.Drawing.Point(15, 12);
            this.labelIVPInput.Name = "labelIVPInput";
            this.labelIVPInput.Padding = new System.Windows.Forms.Padding(5);
            this.labelIVPInput.Size = new System.Drawing.Size(221, 36);
            this.labelIVPInput.TabIndex = 1;
            this.labelIVPInput.Text = "Input parameters of IVP:";
            // 
            // tabErrorAnalysis
            // 
            this.tabErrorAnalysis.Controls.Add(this.splitContainerEA);
            this.tabErrorAnalysis.Location = new System.Drawing.Point(4, 25);
            this.tabErrorAnalysis.Name = "tabErrorAnalysis";
            this.tabErrorAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrorAnalysis.Size = new System.Drawing.Size(1124, 677);
            this.tabErrorAnalysis.TabIndex = 1;
            this.tabErrorAnalysis.Text = "Error analysis";
            this.tabErrorAnalysis.UseVisualStyleBackColor = true;
            // 
            // splitContainerEA
            // 
            this.splitContainerEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEA.Location = new System.Drawing.Point(3, 3);
            this.splitContainerEA.Name = "splitContainerEA";
            // 
            // splitContainerEA.Panel1
            // 
            this.splitContainerEA.Panel1.Controls.Add(this.chartEA);
            // 
            // splitContainerEA.Panel2
            // 
            this.splitContainerEA.Panel2.Controls.Add(this.buttonEAPlot);
            this.splitContainerEA.Panel2.Controls.Add(this.checkBoxEARungeKutta);
            this.splitContainerEA.Panel2.Controls.Add(this.checkBoxEAImprovedEuler);
            this.splitContainerEA.Panel2.Controls.Add(this.checkBoxEAEuler);
            this.splitContainerEA.Panel2.Controls.Add(this.labelEADisplayChoice);
            this.splitContainerEA.Panel2.Controls.Add(this.checkBoxEAExact);
            this.splitContainerEA.Panel2.Controls.Add(this.textBoxEAN);
            this.splitContainerEA.Panel2.Controls.Add(this.textBoxEAn0);
            this.splitContainerEA.Panel2.Controls.Add(this.labelEAN);
            this.splitContainerEA.Panel2.Controls.Add(this.labelEAn0);
            this.splitContainerEA.Panel2.Controls.Add(this.labelEAInput);
            this.splitContainerEA.Size = new System.Drawing.Size(1118, 671);
            this.splitContainerEA.SplitterDistance = 618;
            this.splitContainerEA.TabIndex = 0;
            // 
            // chartEA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartEA.ChartAreas.Add(chartArea4);
            this.chartEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartEA.Legends.Add(legend4);
            this.chartEA.Location = new System.Drawing.Point(0, 0);
            this.chartEA.Name = "chartEA";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Red;
            series12.Legend = "Legend1";
            series12.Name = "Exact";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Blue;
            series13.Legend = "Legend1";
            series13.Name = "Euler";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series14.Legend = "Legend1";
            series14.Name = "ImprovedEuler";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Lime;
            series15.Legend = "Legend1";
            series15.Name = "RungeKutta";
            this.chartEA.Series.Add(series12);
            this.chartEA.Series.Add(series13);
            this.chartEA.Series.Add(series14);
            this.chartEA.Series.Add(series15);
            this.chartEA.Size = new System.Drawing.Size(616, 669);
            this.chartEA.TabIndex = 0;
            this.chartEA.Text = "chartEA";
            // 
            // buttonEAPlot
            // 
            this.buttonEAPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEAPlot.Location = new System.Drawing.Point(4, 337);
            this.buttonEAPlot.Name = "buttonEAPlot";
            this.buttonEAPlot.Size = new System.Drawing.Size(328, 34);
            this.buttonEAPlot.TabIndex = 30;
            this.buttonEAPlot.Text = "Analyze!";
            this.buttonEAPlot.UseVisualStyleBackColor = true;
            // 
            // checkBoxEARungeKutta
            // 
            this.checkBoxEARungeKutta.AutoSize = true;
            this.checkBoxEARungeKutta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEARungeKutta.Location = new System.Drawing.Point(4, 290);
            this.checkBoxEARungeKutta.Name = "checkBoxEARungeKutta";
            this.checkBoxEARungeKutta.Size = new System.Drawing.Size(205, 28);
            this.checkBoxEARungeKutta.TabIndex = 29;
            this.checkBoxEARungeKutta.Text = "Runge-Kutta method";
            this.checkBoxEARungeKutta.UseVisualStyleBackColor = true;
            // 
            // checkBoxEAImprovedEuler
            // 
            this.checkBoxEAImprovedEuler.AutoSize = true;
            this.checkBoxEAImprovedEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEAImprovedEuler.Location = new System.Drawing.Point(4, 248);
            this.checkBoxEAImprovedEuler.Name = "checkBoxEAImprovedEuler";
            this.checkBoxEAImprovedEuler.Size = new System.Drawing.Size(230, 28);
            this.checkBoxEAImprovedEuler.TabIndex = 28;
            this.checkBoxEAImprovedEuler.Text = "Improved Euler method";
            this.checkBoxEAImprovedEuler.UseVisualStyleBackColor = true;
            // 
            // checkBoxEAEuler
            // 
            this.checkBoxEAEuler.AutoSize = true;
            this.checkBoxEAEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEAEuler.Location = new System.Drawing.Point(4, 204);
            this.checkBoxEAEuler.Name = "checkBoxEAEuler";
            this.checkBoxEAEuler.Size = new System.Drawing.Size(146, 28);
            this.checkBoxEAEuler.TabIndex = 27;
            this.checkBoxEAEuler.Text = "Euler method";
            this.checkBoxEAEuler.UseVisualStyleBackColor = true;
            // 
            // labelEADisplayChoice
            // 
            this.labelEADisplayChoice.AutoSize = true;
            this.labelEADisplayChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEADisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEADisplayChoice.Location = new System.Drawing.Point(4, 123);
            this.labelEADisplayChoice.Name = "labelEADisplayChoice";
            this.labelEADisplayChoice.Padding = new System.Windows.Forms.Padding(5);
            this.labelEADisplayChoice.Size = new System.Drawing.Size(254, 36);
            this.labelEADisplayChoice.TabIndex = 26;
            this.labelEADisplayChoice.Text = "Choose methods to display:";
            // 
            // checkBoxEAExact
            // 
            this.checkBoxEAExact.AutoSize = true;
            this.checkBoxEAExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEAExact.Location = new System.Drawing.Point(4, 166);
            this.checkBoxEAExact.Name = "checkBoxEAExact";
            this.checkBoxEAExact.Size = new System.Drawing.Size(79, 28);
            this.checkBoxEAExact.TabIndex = 25;
            this.checkBoxEAExact.Text = "Exact";
            this.checkBoxEAExact.UseVisualStyleBackColor = true;
            // 
            // textBoxEAN
            // 
            this.textBoxEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEAN.Location = new System.Drawing.Point(34, 80);
            this.textBoxEAN.Name = "textBoxEAN";
            this.textBoxEAN.Size = new System.Drawing.Size(233, 28);
            this.textBoxEAN.TabIndex = 22;
            // 
            // textBoxEAn0
            // 
            this.textBoxEAn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEAn0.Location = new System.Drawing.Point(34, 49);
            this.textBoxEAn0.Name = "textBoxEAn0";
            this.textBoxEAn0.Size = new System.Drawing.Size(233, 28);
            this.textBoxEAn0.TabIndex = 21;
            // 
            // labelEAN
            // 
            this.labelEAN.AutoSize = true;
            this.labelEAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEAN.Location = new System.Drawing.Point(0, 85);
            this.labelEAN.Name = "labelEAN";
            this.labelEAN.Size = new System.Drawing.Size(29, 24);
            this.labelEAN.TabIndex = 18;
            this.labelEAN.Text = "N:";
            // 
            // labelEAn0
            // 
            this.labelEAn0.AutoSize = true;
            this.labelEAn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEAn0.Location = new System.Drawing.Point(0, 54);
            this.labelEAn0.Name = "labelEAn0";
            this.labelEAn0.Size = new System.Drawing.Size(36, 24);
            this.labelEAn0.TabIndex = 17;
            this.labelEAn0.Text = "n0:";
            // 
            // labelEAInput
            // 
            this.labelEAInput.AutoSize = true;
            this.labelEAInput.BackColor = System.Drawing.Color.Transparent;
            this.labelEAInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEAInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEAInput.Location = new System.Drawing.Point(3, 4);
            this.labelEAInput.Name = "labelEAInput";
            this.labelEAInput.Padding = new System.Windows.Forms.Padding(5);
            this.labelEAInput.Size = new System.Drawing.Size(219, 36);
            this.labelEAInput.TabIndex = 16;
            this.labelEAInput.Text = "Input range for analysis:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 706);
            this.Controls.Add(this.tabPanelControl);
            this.Name = "MainForm";
            this.Text = "DE Project";
            this.tabPanelControl.ResumeLayout(false);
            this.tabIVPSolutions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLTE)).EndInit();
            this.tabErrorAnalysis.ResumeLayout(false);
            this.splitContainerEA.Panel1.ResumeLayout(false);
            this.splitContainerEA.Panel2.ResumeLayout(false);
            this.splitContainerEA.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEA)).EndInit();
            this.splitContainerEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanelControl;
        private System.Windows.Forms.TabPage tabIVPSolutions;
        private System.Windows.Forms.TabPage tabErrorAnalysis;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelVPN;
        private System.Windows.Forms.Label labelIVPX;
        private System.Windows.Forms.Label labelIVPy0;
        private System.Windows.Forms.Label labelIVPx0;
        private System.Windows.Forms.Label labelIVPInput;
        private System.Windows.Forms.TextBox textBoxIVPN;
        private System.Windows.Forms.TextBox textBoxIVPX;
        private System.Windows.Forms.TextBox textBoxIVPy0;
        private System.Windows.Forms.TextBox textBoxIVPx0;
        private System.Windows.Forms.Label labelIVPDisplayChoice;
        private System.Windows.Forms.CheckBox checkBoxIVPExact;
        private System.Windows.Forms.Button buttonIVPPlot;
        private System.Windows.Forms.CheckBox checkBoxIVPRungeKutta;
        private System.Windows.Forms.CheckBox checkBoxIVPImprovedEuler;
        private System.Windows.Forms.CheckBox checkBoxIVPEuler;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIVP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLTE;
        private System.Windows.Forms.SplitContainer splitContainerEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEA;
        private System.Windows.Forms.Button buttonEAPlot;
        private System.Windows.Forms.CheckBox checkBoxEARungeKutta;
        private System.Windows.Forms.CheckBox checkBoxEAImprovedEuler;
        private System.Windows.Forms.CheckBox checkBoxEAEuler;
        private System.Windows.Forms.Label labelEADisplayChoice;
        private System.Windows.Forms.CheckBox checkBoxEAExact;
        private System.Windows.Forms.TextBox textBoxEAN;
        private System.Windows.Forms.TextBox textBoxEAn0;
        private System.Windows.Forms.Label labelEAN;
        private System.Windows.Forms.Label labelEAn0;
        private System.Windows.Forms.Label labelEAInput;
    }
}

