namespace MiniProyecto_SDVE_Apache
{
    partial class Reportes
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si se deben liberar los recursos administrados; de lo contrario, false.</param>
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
        /// Método necesario para el diseñador: no modifiques
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dvgConvocatoria = new DataGridViewTextBoxColumn();
            dvgCandidato = new DataGridViewTextBoxColumn();
            dvgVotosAbs = new DataGridViewTextBoxColumn();
            dvgPorcentaje = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lParticipacion = new Label();
            lAbstinencia = new Label();
            label4 = new Label();
            bExportar = new Button();
            bSalir = new Button();
            chartResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            bRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResultado).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1128, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 62);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 62);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Verdana", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-1, 9);
            label1.Name = "label1";
            label1.Size = new Size(1279, 62);
            label1.TabIndex = 10;
            label1.Text = "Votación Estudiantil\r\nResultados Electorales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dvgConvocatoria, dvgCandidato, dvgVotosAbs, dvgPorcentaje });
            dataGridView1.GridColor = Color.DarkBlue;
            dataGridView1.Location = new Point(12, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1058, 216);
            dataGridView1.TabIndex = 13;
            // 
            // dvgConvocatoria
            // 
            dvgConvocatoria.HeaderText = "Convocatoria";
            dvgConvocatoria.Name = "dvgConvocatoria";
            dvgConvocatoria.ReadOnly = true;
            // 
            // dvgCandidato
            // 
            dvgCandidato.HeaderText = "Candidato";
            dvgCandidato.Name = "dvgCandidato";
            dvgCandidato.ReadOnly = true;
            // 
            // dvgVotosAbs
            // 
            dvgVotosAbs.HeaderText = "Votos Absolutos";
            dvgVotosAbs.Name = "dvgVotosAbs";
            dvgVotosAbs.ReadOnly = true;
            // 
            // dvgPorcentaje
            // 
            dvgPorcentaje.HeaderText = "Porcentaje %";
            dvgPorcentaje.Name = "dvgPorcentaje";
            dvgPorcentaje.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 106);
            label2.Name = "label2";
            label2.Size = new Size(296, 18);
            label2.TabIndex = 14;
            label2.Text = "Total de Alumnos que Participaron:";
            // 
            // lParticipacion
            // 
            lParticipacion.Location = new Point(316, 106);
            lParticipacion.Name = "lParticipacion";
            lParticipacion.Size = new Size(296, 18);
            lParticipacion.TabIndex = 15;
            lParticipacion.Text = "----";
            // 
            // lAbstinencia
            // 
            lAbstinencia.Location = new Point(347, 150);
            lAbstinencia.Name = "lAbstinencia";
            lAbstinencia.Size = new Size(296, 18);
            lAbstinencia.TabIndex = 17;
            lAbstinencia.Text = "----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 150);
            label4.Name = "label4";
            label4.Size = new Size(327, 18);
            label4.TabIndex = 16;
            label4.Text = "Total de Alumnos que NO Participaron:";
            // 
            // bExportar
            // 
            bExportar.BackColor = Color.DarkBlue;
            bExportar.Font = new Font("Verdana", 14F);
            bExportar.ForeColor = Color.White;
            bExportar.Location = new Point(1065, 472);
            bExportar.Name = "bExportar";
            bExportar.Size = new Size(199, 35);
            bExportar.TabIndex = 18;
            bExportar.Text = "&Exportar Excel ";
            bExportar.UseVisualStyleBackColor = false;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.DarkBlue;
            bSalir.Font = new Font("Verdana", 14F);
            bSalir.ForeColor = Color.White;
            bSalir.Location = new Point(1065, 690);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(199, 35);
            bSalir.TabIndex = 19;
            bSalir.Text = "&Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // chartResultado
            // 
            chartArea1.Name = "ChartArea1";
            chartResultado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResultado.Legends.Add(legend1);
            chartResultado.Location = new Point(12, 434);
            chartResultado.Name = "chartResultado";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResultado.Series.Add(series1);
            chartResultado.Size = new Size(657, 300);
            chartResultado.TabIndex = 20;
            chartResultado.Text = "chart1";
            // 
            // bRegresar
            // 
            bRegresar.BackColor = Color.DarkBlue;
            bRegresar.Font = new Font("Verdana", 14F);
            bRegresar.ForeColor = Color.White;
            bRegresar.Location = new Point(12, 690);
            bRegresar.Name = "bRegresar";
            bRegresar.Size = new Size(199, 35);
            bRegresar.TabIndex = 21;
            bRegresar.Text = "&Regresar";
            bRegresar.UseVisualStyleBackColor = false;
            bRegresar.Click += bRegresar_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 801);
            Controls.Add(bRegresar);
            Controls.Add(chartResultado);
            Controls.Add(bSalir);
            Controls.Add(bExportar);
            Controls.Add(lAbstinencia);
            Controls.Add(label4);
            Controls.Add(lParticipacion);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dvgConvocatoria;
        private DataGridViewTextBoxColumn dvgCandidato;
        private DataGridViewTextBoxColumn dvgVotosAbs;
        private DataGridViewTextBoxColumn dvgPorcentaje;
        private Label label2;
        private Label lParticipacion;
        private Label lAbstinencia;
        private Label label4;
        private Button bExportar;
        private Button bSalir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultado;
        private Button bRegresar;
    }
}
