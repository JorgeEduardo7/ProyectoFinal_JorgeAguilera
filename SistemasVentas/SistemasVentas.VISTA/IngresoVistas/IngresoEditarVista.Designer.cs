namespace SistemasVentas.VISTA.IngresoVistas
{
    partial class IngresoEditarVista
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 13, 20);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(533, 48);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 22);
            button3.TabIndex = 61;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(157, 13, 20);
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(365, 255);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 60;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 13, 20);
            button1.DialogResult = DialogResult.OK;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(214, 255);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 59;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(197, 181);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 58;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 136);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 184);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 56;
            label4.Text = "ESTADO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 139);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 55;
            label3.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 92);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 54;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 48);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 95);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 52;
            label2.Text = "FECHA INGRESO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 51;
            label1.Text = "PROVEEDOR";
            // 
            // IngresoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(700, 338);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IngresoEditarVista";
            Text = "IngresoEditarVista";
            Load += IngresoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}