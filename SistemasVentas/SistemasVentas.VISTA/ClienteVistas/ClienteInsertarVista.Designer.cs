namespace SistemasVentas.VISTA.ClienteVistas
{
    partial class ClienteInsertarVista
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 118);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 73);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 28);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 119);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 14;
            label3.Text = "CODIGO CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 13;
            label2.Text = "TIPO CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 12;
            label1.Text = "PERSONA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 165);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 24;
            label4.Text = "ESTADO";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 163);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 13, 20);
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(234, 160, 54);
            button2.Location = new Point(364, 238);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 27;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 13, 20);
            button1.DialogResult = DialogResult.OK;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(234, 160, 54);
            button1.Location = new Point(214, 238);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 26;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 13, 20);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(234, 160, 54);
            button3.Location = new Point(513, 28);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 36);
            button3.TabIndex = 28;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ClienteInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(676, 310);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteInsertarVista";
            Text = "ClienteInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}