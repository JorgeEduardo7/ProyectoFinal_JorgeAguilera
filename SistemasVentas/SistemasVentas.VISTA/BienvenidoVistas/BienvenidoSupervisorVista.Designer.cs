namespace SistemasVentas.VISTA.BienvenidoVistas
{
    partial class BienvenidoSupervisorVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 13, 20);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(234, 160, 54);
            button1.Location = new Point(50, 361);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 30;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 13, 20);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 38);
            panel1.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 26F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(157, 13, 20);
            label4.Location = new Point(343, 153);
            label4.Name = "label4";
            label4.Size = new Size(222, 42);
            label4.TabIndex = 31;
            label4.Text = "BIENVENIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 40F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(157, 13, 20);
            label3.Location = new Point(303, 184);
            label3.Name = "label3";
            label3.Size = new Size(303, 66);
            label3.TabIndex = 32;
            label3.Text = "SUPERVISOR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sup_pro;
            pictureBox1.Location = new Point(50, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 13, 20);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(234, 160, 54);
            button2.Location = new Point(175, 361);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 34;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BienvenidoSupervisorVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(671, 448);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BienvenidoSupervisorVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidoSupervisorVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button2;
    }
}