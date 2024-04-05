namespace SistemasVentas.VISTA.BienvenidoVistas
{
    partial class BienvenidoCajeroVista
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
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
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(234, 160, 54);
            button1.Location = new Point(197, 354);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 30;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 46F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(157, 13, 20);
            label2.Location = new Point(363, 180);
            label2.Name = "label2";
            label2.Size = new Size(219, 75);
            label2.TabIndex = 25;
            label2.Text = "CAJERO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 26F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(157, 13, 20);
            label1.Location = new Point(361, 147);
            label1.Name = "label1";
            label1.Size = new Size(222, 42);
            label1.TabIndex = 24;
            label1.Text = "BIENVENIDO";
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
            button2.Location = new Point(344, 354);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 40);
            button2.TabIndex = 31;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cajero_pndd;
            pictureBox1.Location = new Point(47, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // BienvenidoCajeroVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(671, 448);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BienvenidoCajeroVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidoCajeroVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}