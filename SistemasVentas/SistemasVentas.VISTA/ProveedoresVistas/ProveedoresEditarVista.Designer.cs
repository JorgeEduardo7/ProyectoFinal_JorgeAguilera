namespace SistemasVentas.VISTA.ProveedoresVistas
{
    partial class ProveedoresEditarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedoresEditarVista));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtIcon = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            TIPOPRODUCTO = new DataGridViewTextBoxColumn();
            MARCA = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            label9 = new Label();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtIcon).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIcon
            // 
            txtIcon.BackColor = SystemColors.ButtonHighlight;
            txtIcon.Image = (Image)resources.GetObject("txtIcon.Image");
            txtIcon.Location = new Point(75, 995);
            txtIcon.Name = "txtIcon";
            txtIcon.Size = new Size(221, 83);
            txtIcon.SizeMode = PictureBoxSizeMode.Zoom;
            txtIcon.TabIndex = 53;
            txtIcon.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 74, 173);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(82, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 467);
            panel2.TabIndex = 51;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(pictureBox8);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(946, 459);
            panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 74, 173);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 74, 173);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TIPOPRODUCTO, MARCA, NOMBRE, PRECIO });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(0, 74, 173);
            dataGridView1.Location = new Point(10, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 74, 173);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(933, 359);
            dataGridView1.TabIndex = 2;
            // 
            // TIPOPRODUCTO
            // 
            TIPOPRODUCTO.HeaderText = "TIPO PRODUCTO";
            TIPOPRODUCTO.MinimumWidth = 6;
            TIPOPRODUCTO.Name = "TIPOPRODUCTO";
            TIPOPRODUCTO.ReadOnly = true;
            TIPOPRODUCTO.Width = 300;
            // 
            // MARCA
            // 
            MARCA.HeaderText = "MARCA";
            MARCA.MinimumWidth = 6;
            MARCA.Name = "MARCA";
            MARCA.ReadOnly = true;
            MARCA.Width = 200;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 200;
            // 
            // PRECIO
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PRECIO.DefaultCellStyle = dataGridViewCellStyle5;
            PRECIO.HeaderText = "PRECIO";
            PRECIO.MinimumWidth = 6;
            PRECIO.Name = "PRECIO";
            PRECIO.ReadOnly = true;
            PRECIO.Width = 200;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 74, 173);
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(394, 30);
            label9.Name = "label9";
            label9.Size = new Size(182, 34);
            label9.TabIndex = 1;
            label9.Text = "PRODUCTOS";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(0, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(946, 88);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(760, 265);
            label4.Name = "label4";
            label4.Size = new Size(122, 34);
            label4.TabIndex = 46;
            label4.Text = "ESTADO";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(114, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(955, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1005, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 74, 173);
            button1.DialogResult = DialogResult.OK;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(125, 1010);
            button1.Name = "button1";
            button1.Size = new Size(126, 54);
            button1.TabIndex = 52;
            button1.Text = "EDITAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(31, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(64, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(760, 134);
            label3.Name = "label3";
            label3.Size = new Size(171, 34);
            label3.TabIndex = 45;
            label3.Text = "DIRECCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(364, 265);
            label2.Name = "label2";
            label2.Size = new Size(151, 34);
            label2.TabIndex = 44;
            label2.Text = "TELÉFONO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1055, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 134);
            label1.Name = "label1";
            label1.Size = new Size(132, 34);
            label1.TabIndex = 43;
            label1.Text = "NOMBRE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 51);
            panel1.TabIndex = 41;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 74, 173);
            button2.DialogResult = DialogResult.OK;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(125, 1010);
            button2.Name = "button2";
            button2.Size = new Size(126, 54);
            button2.TabIndex = 54;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(364, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 36);
            textBox2.TabIndex = 55;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(364, 331);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 36);
            textBox1.TabIndex = 56;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(760, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 36);
            textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(760, 331);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 36);
            textBox4.TabIndex = 58;
            // 
            // ProveedoresEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1107, 1101);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(txtIcon);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedoresEditarVista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedoresEditarVista";
            Load += ProveedoresEditarVista_Load;
            ((System.ComponentModel.ISupportInitialize)txtIcon).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox txtIcon;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TIPOPRODUCTO;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn PRECIO;
        private Label label9;
        private PictureBox pictureBox8;
        private Label label4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}