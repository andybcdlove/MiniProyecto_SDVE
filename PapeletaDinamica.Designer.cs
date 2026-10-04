namespace MiniProyecto_SDVE_Apache
{
    partial class PapeletaDinamica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PapeletaDinamica));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lTipoVotacion = new Label();
            groupBox1 = new GroupBox();
            rbCandidatoLibre = new RadioButton();
            tCandidatoLibre = new TextBox();
            rbCandidato5 = new RadioButton();
            rbCandidato4 = new RadioButton();
            rbCandidato1 = new RadioButton();
            rbCandidato3 = new RadioButton();
            rbCandidato2 = new RadioButton();
            bConfirmar = new Button();
            bSalir = new Button();
            bRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(652, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 62);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 62);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Verdana", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-3, 8);
            label1.Name = "label1";
            label1.Size = new Size(808, 62);
            label1.TabIndex = 7;
            label1.Text = "Votación Estudiantil\r\nPapeleta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lTipoVotacion
            // 
            lTipoVotacion.BackColor = Color.Navy;
            lTipoVotacion.Font = new Font("Verdana", 12F);
            lTipoVotacion.ForeColor = Color.White;
            lTipoVotacion.Location = new Point(-3, 86);
            lTipoVotacion.Name = "lTipoVotacion";
            lTipoVotacion.Size = new Size(808, 27);
            lTipoVotacion.TabIndex = 10;
            lTipoVotacion.Text = "Tipo de votacion";
            lTipoVotacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(rbCandidatoLibre);
            groupBox1.Controls.Add(tCandidatoLibre);
            groupBox1.Controls.Add(rbCandidato5);
            groupBox1.Controls.Add(rbCandidato4);
            groupBox1.Controls.Add(rbCandidato1);
            groupBox1.Controls.Add(rbCandidato3);
            groupBox1.Controls.Add(rbCandidato2);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 272);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Candidatos";
            // 
            // rbCandidatoLibre
            // 
            rbCandidatoLibre.AutoSize = true;
            rbCandidatoLibre.Font = new Font("Verdana", 12F);
            rbCandidatoLibre.Location = new Point(7, 227);
            rbCandidatoLibre.Name = "rbCandidatoLibre";
            rbCandidatoLibre.Size = new Size(155, 22);
            rbCandidatoLibre.TabIndex = 22;
            rbCandidatoLibre.TabStop = true;
            rbCandidatoLibre.Text = "Candidato Libre";
            rbCandidatoLibre.UseVisualStyleBackColor = true;
            // 
            // tCandidatoLibre
            // 
            tCandidatoLibre.Enabled = false;
            tCandidatoLibre.Location = new Point(179, 226);
            tCandidatoLibre.Name = "tCandidatoLibre";
            tCandidatoLibre.Size = new Size(299, 27);
            tCandidatoLibre.TabIndex = 17;
            // 
            // rbCandidato5
            // 
            rbCandidato5.AutoSize = true;
            rbCandidato5.Font = new Font("Verdana", 12F);
            rbCandidato5.Location = new Point(7, 193);
            rbCandidato5.Name = "rbCandidato5";
            rbCandidato5.Size = new Size(125, 22);
            rbCandidato5.TabIndex = 21;
            rbCandidato5.TabStop = true;
            rbCandidato5.Text = "Candidato 5";
            rbCandidato5.UseVisualStyleBackColor = true;
            // 
            // rbCandidato4
            // 
            rbCandidato4.AutoSize = true;
            rbCandidato4.Font = new Font("Verdana", 12F);
            rbCandidato4.Location = new Point(7, 155);
            rbCandidato4.Name = "rbCandidato4";
            rbCandidato4.Size = new Size(125, 22);
            rbCandidato4.TabIndex = 20;
            rbCandidato4.TabStop = true;
            rbCandidato4.Text = "Candidato 4";
            rbCandidato4.UseVisualStyleBackColor = true;
            // 
            // rbCandidato1
            // 
            rbCandidato1.AutoSize = true;
            rbCandidato1.Font = new Font("Verdana", 12F);
            rbCandidato1.Location = new Point(7, 40);
            rbCandidato1.Name = "rbCandidato1";
            rbCandidato1.Size = new Size(125, 22);
            rbCandidato1.TabIndex = 17;
            rbCandidato1.TabStop = true;
            rbCandidato1.Text = "Candidato 1";
            rbCandidato1.UseVisualStyleBackColor = true;
            // 
            // rbCandidato3
            // 
            rbCandidato3.AutoSize = true;
            rbCandidato3.Font = new Font("Verdana", 12F);
            rbCandidato3.Location = new Point(7, 116);
            rbCandidato3.Name = "rbCandidato3";
            rbCandidato3.Size = new Size(125, 22);
            rbCandidato3.TabIndex = 19;
            rbCandidato3.TabStop = true;
            rbCandidato3.Text = "Candidato 3";
            rbCandidato3.UseVisualStyleBackColor = true;
            // 
            // rbCandidato2
            // 
            rbCandidato2.AutoSize = true;
            rbCandidato2.Font = new Font("Verdana", 12F);
            rbCandidato2.Location = new Point(7, 79);
            rbCandidato2.Name = "rbCandidato2";
            rbCandidato2.Size = new Size(125, 22);
            rbCandidato2.TabIndex = 18;
            rbCandidato2.TabStop = true;
            rbCandidato2.Text = "Candidato 2";
            rbCandidato2.UseVisualStyleBackColor = true;
            // 
            // bConfirmar
            // 
            bConfirmar.BackColor = Color.DarkBlue;
            bConfirmar.Font = new Font("Verdana", 14F);
            bConfirmar.ForeColor = Color.White;
            bConfirmar.Location = new Point(298, 420);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(207, 35);
            bConfirmar.TabIndex = 17;
            bConfirmar.Text = "&Confirmar Voto";
            bConfirmar.UseVisualStyleBackColor = false;
            bConfirmar.Click += bConfirmar_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.DarkBlue;
            bSalir.Font = new Font("Verdana", 14F);
            bSalir.ForeColor = Color.White;
            bSalir.Location = new Point(662, 481);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(120, 39);
            bSalir.TabIndex = 19;
            bSalir.Text = "&Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // bRegresar
            // 
            bRegresar.BackColor = Color.DarkBlue;
            bRegresar.Font = new Font("Verdana", 14F);
            bRegresar.ForeColor = Color.White;
            bRegresar.Location = new Point(12, 481);
            bRegresar.Name = "bRegresar";
            bRegresar.Size = new Size(120, 39);
            bRegresar.TabIndex = 18;
            bRegresar.Text = "&Regresar";
            bRegresar.UseVisualStyleBackColor = false;
            bRegresar.Click += bRegresar_Click;
            // 
            // PapeletaDinamica
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(bSalir);
            Controls.Add(bRegresar);
            Controls.Add(bConfirmar);
            Controls.Add(groupBox1);
            Controls.Add(lTipoVotacion);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Verdana", 8.25F);
            Name = "PapeletaDinamica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PapeletaDinamica";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lTipoVotacion;
        private GroupBox groupBox1;
        private TextBox tCandidatoLibre;
        private RadioButton rbCandidato5;
        private RadioButton rbCandidato4;
        private RadioButton rbCandidato1;
        private RadioButton rbCandidato3;
        private RadioButton rbCandidato2;
        private RadioButton rbCandidatoLibre;
        private Button bConfirmar;
        private Button bSalir;
        private Button bRegresar;
    }
}
