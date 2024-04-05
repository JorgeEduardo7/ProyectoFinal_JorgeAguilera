namespace SistemasVentas.VISTA.MenuVistas
{
    partial class MenuCajeroVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCajeroVista));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox16 = new PictureBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(707, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 13, 20);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 38);
            panel1.TabIndex = 60;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.FromArgb(0, 74, 173);
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(245, 160);
            pictureBox16.Margin = new Padding(3, 2, 3, 2);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(44, 36);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 74;
            pictureBox16.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(234, 160, 54);
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(157, 13, 20);
            button5.Location = new Point(295, 160);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(284, 40);
            button5.TabIndex = 73;
            button5.Text = "VENTAS";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // MenuCajeroVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(753, 362);
            ControlBox = false;
            Controls.Add(pictureBox16);
            Controls.Add(button5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuCajeroVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuVendedorVista";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox16;
        private Button button5;
    }
}