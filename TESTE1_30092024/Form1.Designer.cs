namespace TESTE1_30092024
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tamanhojanelaform = new System.Windows.Forms.NumericUpDown();
            this.textBoxArquivo = new System.Windows.Forms.TextBox();
            this.labelArquivo = new System.Windows.Forms.Label();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.checkBoxNegativos = new System.Windows.Forms.CheckBox();
            this.labelColunaAnalise = new System.Windows.Forms.Label();
            this.formColunaAnalise = new System.Windows.Forms.NumericUpDown();
            this.labelCortePotencial = new System.Windows.Forms.Label();
            this.formCortePotencial = new System.Windows.Forms.NumericUpDown();
            this.labelLinhaInicial = new System.Windows.Forms.Label();
            this.formLinhaInicial = new System.Windows.Forms.NumericUpDown();
            this.labelTamJanela = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonanalise = new System.Windows.Forms.Button();
            this.tabControlArquivo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewArquivo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.checkBoxPosCab = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartxY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCorteDerivada = new System.Windows.Forms.Label();
            this.formDerivada = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhojanelaform)).BeginInit();
            this.groupBoxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formColunaAnalise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCortePotencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLinhaInicial)).BeginInit();
            this.tabControlArquivo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArquivo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDerivada)).BeginInit();
            this.SuspendLayout();
            // 
            // tamanhojanelaform
            // 
            this.tamanhojanelaform.Location = new System.Drawing.Point(11, 35);
            this.tamanhojanelaform.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.tamanhojanelaform.Name = "tamanhojanelaform";
            this.tamanhojanelaform.Size = new System.Drawing.Size(120, 20);
            this.tamanhojanelaform.TabIndex = 1;
            this.tamanhojanelaform.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // textBoxArquivo
            // 
            this.textBoxArquivo.Location = new System.Drawing.Point(59, 12);
            this.textBoxArquivo.Name = "textBoxArquivo";
            this.textBoxArquivo.Size = new System.Drawing.Size(475, 20);
            this.textBoxArquivo.TabIndex = 2;
            // 
            // labelArquivo
            // 
            this.labelArquivo.AutoSize = true;
            this.labelArquivo.Location = new System.Drawing.Point(7, 17);
            this.labelArquivo.Name = "labelArquivo";
            this.labelArquivo.Size = new System.Drawing.Size(46, 13);
            this.labelArquivo.TabIndex = 4;
            this.labelArquivo.Text = "Arquivo:";
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParametros.Controls.Add(this.labelCorteDerivada);
            this.groupBoxParametros.Controls.Add(this.formDerivada);
            this.groupBoxParametros.Controls.Add(this.checkBoxPosCab);
            this.groupBoxParametros.Controls.Add(this.checkBoxNegativos);
            this.groupBoxParametros.Controls.Add(this.labelColunaAnalise);
            this.groupBoxParametros.Controls.Add(this.formColunaAnalise);
            this.groupBoxParametros.Controls.Add(this.labelCortePotencial);
            this.groupBoxParametros.Controls.Add(this.formCortePotencial);
            this.groupBoxParametros.Controls.Add(this.labelLinhaInicial);
            this.groupBoxParametros.Controls.Add(this.formLinhaInicial);
            this.groupBoxParametros.Controls.Add(this.labelTamJanela);
            this.groupBoxParametros.Controls.Add(this.tamanhojanelaform);
            this.groupBoxParametros.Location = new System.Drawing.Point(10, 68);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(658, 100);
            this.groupBoxParametros.TabIndex = 5;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parâmetros";
            // 
            // checkBoxNegativos
            // 
            this.checkBoxNegativos.AutoSize = true;
            this.checkBoxNegativos.Location = new System.Drawing.Point(516, 48);
            this.checkBoxNegativos.Name = "checkBoxNegativos";
            this.checkBoxNegativos.Size = new System.Drawing.Size(122, 17);
            this.checkBoxNegativos.TabIndex = 9;
            this.checkBoxNegativos.Text = "Considera negativos";
            this.checkBoxNegativos.UseVisualStyleBackColor = true;
            // 
            // labelColunaAnalise
            // 
            this.labelColunaAnalise.AutoSize = true;
            this.labelColunaAnalise.Location = new System.Drawing.Point(144, 58);
            this.labelColunaAnalise.Name = "labelColunaAnalise";
            this.labelColunaAnalise.Size = new System.Drawing.Size(94, 13);
            this.labelColunaAnalise.TabIndex = 8;
            this.labelColunaAnalise.Text = "Coluna de análise:";
            // 
            // formColunaAnalise
            // 
            this.formColunaAnalise.Location = new System.Drawing.Point(147, 74);
            this.formColunaAnalise.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.formColunaAnalise.Name = "formColunaAnalise";
            this.formColunaAnalise.Size = new System.Drawing.Size(120, 20);
            this.formColunaAnalise.TabIndex = 7;
            this.formColunaAnalise.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // labelCortePotencial
            // 
            this.labelCortePotencial.AutoSize = true;
            this.labelCortePotencial.Location = new System.Drawing.Point(144, 19);
            this.labelCortePotencial.Name = "labelCortePotencial";
            this.labelCortePotencial.Size = new System.Drawing.Size(81, 13);
            this.labelCortePotencial.TabIndex = 6;
            this.labelCortePotencial.Text = "Corte potencial:";
            // 
            // formCortePotencial
            // 
            this.formCortePotencial.DecimalPlaces = 6;
            this.formCortePotencial.Location = new System.Drawing.Point(147, 35);
            this.formCortePotencial.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.formCortePotencial.Name = "formCortePotencial";
            this.formCortePotencial.Size = new System.Drawing.Size(120, 20);
            this.formCortePotencial.TabIndex = 5;
            this.formCortePotencial.Value = new decimal(new int[] {
            125,
            0,
            0,
            393216});
            // 
            // labelLinhaInicial
            // 
            this.labelLinhaInicial.AutoSize = true;
            this.labelLinhaInicial.Location = new System.Drawing.Point(8, 58);
            this.labelLinhaInicial.Name = "labelLinhaInicial";
            this.labelLinhaInicial.Size = new System.Drawing.Size(65, 13);
            this.labelLinhaInicial.TabIndex = 4;
            this.labelLinhaInicial.Text = "Linha inicial:";
            // 
            // formLinhaInicial
            // 
            this.formLinhaInicial.Location = new System.Drawing.Point(11, 74);
            this.formLinhaInicial.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.formLinhaInicial.Name = "formLinhaInicial";
            this.formLinhaInicial.Size = new System.Drawing.Size(120, 20);
            this.formLinhaInicial.TabIndex = 3;
            this.formLinhaInicial.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // labelTamJanela
            // 
            this.labelTamJanela.AutoSize = true;
            this.labelTamJanela.Location = new System.Drawing.Point(8, 19);
            this.labelTamJanela.Name = "labelTamJanela";
            this.labelTamJanela.Size = new System.Drawing.Size(101, 13);
            this.labelTamJanela.TabIndex = 2;
            this.labelTamJanela.Text = "Tamanho da janela:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TESTE1_30092024.Properties.Resources.pasta;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(540, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonanalise
            // 
            this.buttonanalise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonanalise.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonanalise.ImageKey = "(nenhum/a)";
            this.buttonanalise.Location = new System.Drawing.Point(582, 7);
            this.buttonanalise.Name = "buttonanalise";
            this.buttonanalise.Size = new System.Drawing.Size(68, 29);
            this.buttonanalise.TabIndex = 0;
            this.buttonanalise.Text = "Carregar";
            this.buttonanalise.UseVisualStyleBackColor = true;
            this.buttonanalise.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlArquivo
            // 
            this.tabControlArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlArquivo.Controls.Add(this.tabPage1);
            this.tabControlArquivo.Controls.Add(this.tabPage2);
            this.tabControlArquivo.Controls.Add(this.tabPage3);
            this.tabControlArquivo.Location = new System.Drawing.Point(9, 197);
            this.tabControlArquivo.Name = "tabControlArquivo";
            this.tabControlArquivo.SelectedIndex = 0;
            this.tabControlArquivo.Size = new System.Drawing.Size(659, 241);
            this.tabControlArquivo.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewArquivo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArquivo
            // 
            this.dataGridViewArquivo.AllowUserToAddRows = false;
            this.dataGridViewArquivo.AllowUserToDeleteRows = false;
            this.dataGridViewArquivo.AllowUserToOrderColumns = true;
            this.dataGridViewArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArquivo.Location = new System.Drawing.Point(-1, 6);
            this.dataGridViewArquivo.Name = "dataGridViewArquivo";
            this.dataGridViewArquivo.ReadOnly = true;
            this.dataGridViewArquivo.Size = new System.Drawing.Size(652, 209);
            this.dataGridViewArquivo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewResultados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Picos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Location = new System.Drawing.Point(0, 6);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.Size = new System.Drawing.Size(648, 206);
            this.dataGridViewResultados.TabIndex = 0;
            // 
            // checkBoxPosCab
            // 
            this.checkBoxPosCab.AutoSize = true;
            this.checkBoxPosCab.Checked = true;
            this.checkBoxPosCab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPosCab.Location = new System.Drawing.Point(516, 26);
            this.checkBoxPosCab.Name = "checkBoxPosCab";
            this.checkBoxPosCab.Size = new System.Drawing.Size(110, 17);
            this.checkBoxPosCab.TabIndex = 10;
            this.checkBoxPosCab.Text = "Possui cabeçalho";
            this.checkBoxPosCab.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartxY);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(651, 215);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gráfico XY";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartxY
            // 
            this.chartxY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartxY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartxY.Legends.Add(legend2);
            this.chartxY.Location = new System.Drawing.Point(-3, 6);
            this.chartxY.Name = "chartxY";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartxY.Series.Add(series2);
            this.chartxY.Size = new System.Drawing.Size(654, 203);
            this.chartxY.TabIndex = 0;
            this.chartxY.Text = "chart1";
            // 
            // labelCorteDerivada
            // 
            this.labelCorteDerivada.AutoSize = true;
            this.labelCorteDerivada.Location = new System.Drawing.Point(281, 19);
            this.labelCorteDerivada.Name = "labelCorteDerivada";
            this.labelCorteDerivada.Size = new System.Drawing.Size(79, 13);
            this.labelCorteDerivada.TabIndex = 12;
            this.labelCorteDerivada.Text = "Corte derivada:";
            // 
            // formDerivada
            // 
            this.formDerivada.DecimalPlaces = 12;
            this.formDerivada.Location = new System.Drawing.Point(284, 35);
            this.formDerivada.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.formDerivada.Name = "formDerivada";
            this.formDerivada.Size = new System.Drawing.Size(120, 20);
            this.formDerivada.TabIndex = 11;
            this.formDerivada.Value = new decimal(new int[] {
            4,
            0,
            0,
            458752});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.tabControlArquivo);
            this.Controls.Add(this.groupBoxParametros);
            this.Controls.Add(this.labelArquivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxArquivo);
            this.Controls.Add(this.buttonanalise);
            this.MinimumSize = new System.Drawing.Size(695, 489);
            this.Name = "Form1";
            this.Text = "Cálculadora de picos Aline de Godoy";
            ((System.ComponentModel.ISupportInitialize)(this.tamanhojanelaform)).EndInit();
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formColunaAnalise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formCortePotencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLinhaInicial)).EndInit();
            this.tabControlArquivo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArquivo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDerivada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonanalise;
        private System.Windows.Forms.NumericUpDown tamanhojanelaform;
        private System.Windows.Forms.TextBox textBoxArquivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelArquivo;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.Label labelLinhaInicial;
        private System.Windows.Forms.NumericUpDown formLinhaInicial;
        private System.Windows.Forms.Label labelTamJanela;
        private System.Windows.Forms.Label labelCortePotencial;
        private System.Windows.Forms.NumericUpDown formCortePotencial;
        private System.Windows.Forms.Label labelColunaAnalise;
        private System.Windows.Forms.NumericUpDown formColunaAnalise;
        private System.Windows.Forms.CheckBox checkBoxNegativos;
        private System.Windows.Forms.TabControl tabControlArquivo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewArquivo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.CheckBox checkBoxPosCab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartxY;
        private System.Windows.Forms.Label labelCorteDerivada;
        private System.Windows.Forms.NumericUpDown formDerivada;
    }
}

