namespace MiniProyecto_SDVE_Apache
{
    partial class Convocatoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convocatoria));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            chkSociedadAlumno = new CheckBox();
            chkConsejoUniversitario = new CheckBox();
            chkConsejoRepresentantes = new CheckBox();
            bContinuar = new Button();
            bSalir = new Button();
            bRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(646, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 71);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 71);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Verdana", 16F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(791, 71);
            label1.TabIndex = 4;
            label1.Text = "Votación Estudiantil\r\nConvocatoria";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F);
            label2.Location = new Point(18, 114);
            label2.Name = "label2";
            label2.Size = new Size(736, 18);
            label2.TabIndex = 7;
            label2.Text = "Selecciona los procesos activos en los que deseas participar (puedes elegir 1, 2 o los 3)";
            // 
            // chkSociedadAlumno
            // 
            chkSociedadAlumno.AutoSize = true;
            chkSociedadAlumno.Font = new Font("Verdana", 12F);
            chkSociedadAlumno.Location = new Point(25, 156);
            chkSociedadAlumno.Name = "chkSociedadAlumno";
            chkSociedadAlumno.Size = new Size(202, 22);
            chkSociedadAlumno.TabIndex = 8;
            chkSociedadAlumno.Text = "Sociedad de Alumnos";
            chkSociedadAlumno.UseVisualStyleBackColor = true;
            // 
            // chkConsejoUniversitario
            // 
            chkConsejoUniversitario.AutoSize = true;
            chkConsejoUniversitario.Font = new Font("Verdana", 12F);
            chkConsejoUniversitario.Location = new Point(25, 202);
            chkConsejoUniversitario.Name = "chkConsejoUniversitario";
            chkConsejoUniversitario.Size = new Size(203, 22);
            chkConsejoUniversitario.TabIndex = 9;
            chkConsejoUniversitario.Text = "Consejo Universitario";
            chkConsejoUniversitario.UseVisualStyleBackColor = true;
            // 
            // chkConsejoRepresentantes
            // 
            chkConsejoRepresentantes.AutoSize = true;
            chkConsejoRepresentantes.Font = new Font("Verdana", 12F);
            chkConsejoRepresentantes.Location = new Point(25, 251);
            chkConsejoRepresentantes.Name = "chkConsejoRepresentantes";
            chkConsejoRepresentantes.Size = new Size(254, 22);
            chkConsejoRepresentantes.TabIndex = 10;
            chkConsejoRepresentantes.Text = "Consejo de Representantes";
            chkConsejoRepresentantes.UseVisualStyleBackColor = true;
            // 
            // bContinuar
            // 
            bContinuar.BackColor = Color.DarkBlue;
            bContinuar.Font = new Font("Verdana", 14F);
            bContinuar.ForeColor = Color.White;
            bContinuar.Location = new Point(331, 302);
            bContinuar.Name = "bContinuar";
            bContinuar.Size = new Size(120, 39);
            bContinuar.TabIndex = 11;
            bContinuar.Text = "&Continuar";
            bContinuar.UseVisualStyleBackColor = false;
            bContinuar.Click += bContinuar_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.DarkBlue;
            bSalir.Font = new Font("Verdana", 14F);
            bSalir.ForeColor = Color.White;
            bSalir.Location = new Point(662, 390);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(120, 39);
            bSalir.TabIndex = 15;
            bSalir.Text = "&Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // bRegresar
            // 
            bRegresar.BackColor = Color.DarkBlue;
            bRegresar.Font = new Font("Verdana", 14F);
            bRegresar.ForeColor = Color.White;
            bRegresar.Location = new Point(12, 390);
            bRegresar.Name = "bRegresar";
            bRegresar.Size = new Size(120, 39);
            bRegresar.TabIndex = 14;
            bRegresar.Text = "&Regresar";
            bRegresar.UseVisualStyleBackColor = false;
            bRegresar.Click += bRegresar_Click;
            // 
            // Convocatoria
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 441);
            Controls.Add(bSalir);
            Controls.Add(bRegresar);
            Controls.Add(bContinuar);
            Controls.Add(chkConsejoRepresentantes);
            Controls.Add(chkConsejoUniversitario);
            Controls.Add(chkSociedadAlumno);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Verdana", 8.25F);
            Name = "Convocatoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de Convocatorias";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private CheckBox chkSociedadAlumno;
        private CheckBox chkConsejoUniversitario;
        private CheckBox chkConsejoRepresentantes;
        private Button bContinuar;
        private Button bSalir;
        private Button bRegresar;
    }
}
