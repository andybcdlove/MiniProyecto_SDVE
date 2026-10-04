namespace MiniProyecto_SDVE_Apache
{
    partial class Login
    {
        /// <summary>
        ///  Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Libera los recursos que se estén utilizando.
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
        ///  Método necesario para el diseñador: no modifiques
        ///  el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            bIngresar = new Button();
            tID = new TextBox();
            tContrasena = new TextBox();
            bSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkBlue;
            label1.Font = new Font("Verdana", 16F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(783, 71);
            label1.TabIndex = 1;
            label1.Text = "Votación Estudiantil\r\nLogin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 71);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(636, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 71);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(35, 18);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(33, 201);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(bIngresar);
            panel1.Controls.Add(tID);
            panel1.Controls.Add(tContrasena);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(225, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 6;
            // 
            // bIngresar
            // 
            bIngresar.BackColor = Color.White;
            bIngresar.Font = new Font("Verdana", 14F);
            bIngresar.ForeColor = Color.Navy;
            bIngresar.Location = new Point(129, 360);
            bIngresar.Name = "bIngresar";
            bIngresar.Size = new Size(105, 39);
            bIngresar.TabIndex = 8;
            bIngresar.Text = "Ingresar";
            bIngresar.UseVisualStyleBackColor = false;
            bIngresar.Click += bIngresar_Click;
            // 
            // tID
            // 
            tID.Font = new Font("Verdana", 12F);
            tID.Location = new Point(33, 99);
            tID.Name = "tID";
            tID.Size = new Size(281, 27);
            tID.TabIndex = 7;
            // 
            // tContrasena
            // 
            tContrasena.Font = new Font("Verdana", 12F);
            tContrasena.Location = new Point(33, 241);
            tContrasena.Name = "tContrasena";
            tContrasena.Size = new Size(281, 27);
            tContrasena.TabIndex = 6;
            tContrasena.UseSystemPasswordChar = true;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.DarkBlue;
            bSalir.Font = new Font("Verdana", 14F);
            bSalir.ForeColor = Color.White;
            bSalir.Location = new Point(652, 610);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(120, 39);
            bSalir.TabIndex = 13;
            bSalir.Text = "&Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(bSalir);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Verdana", 8.25F);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox tContrasena;
        private TextBox tID;
        private Button bIngresar;
        private Button bSalir;
    }
}
