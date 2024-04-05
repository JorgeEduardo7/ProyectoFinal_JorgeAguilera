namespace SistemasVentas.VISTA.ClientesVistas
{
    partial class ClientesListarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesListarVista));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            IDCLIENTE = new DataGridViewTextBoxColumn();
            IDPERSONA = new DataGridViewTextBoxColumn();
            NOMBRE_COMPLETO = new DataGridViewTextBoxColumn();
            TIPO_CLIENTE = new DataGridViewTextBoxColumn();
            CODIGO_CLIENTE = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(923, 9);
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
            panel1.Size = new Size(969, 38);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(157, 13, 20);
            label1.Location = new Point(416, 57);
            label1.Name = "label1";
            label1.Size = new Size(221, 49);
            label1.TabIndex = 16;
            label1.Text = "CLIENTES";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(157, 13, 20);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(157, 13, 20);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(157, 13, 20);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 74, 173);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCLIENTE, IDPERSONA, NOMBRE_COMPLETO, TIPO_CLIENTE, CODIGO_CLIENTE, ESTADO });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(157, 13, 20);
            dataGridView1.Location = new Point(26, 145);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 74, 173);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(901, 244);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDCLIENTE
            // 
            IDCLIENTE.HeaderText = "";
            IDCLIENTE.MinimumWidth = 6;
            IDCLIENTE.Name = "IDCLIENTE";
            IDCLIENTE.ReadOnly = true;
            IDCLIENTE.Visible = false;
            IDCLIENTE.Width = 125;
            // 
            // IDPERSONA
            // 
            IDPERSONA.HeaderText = "";
            IDPERSONA.MinimumWidth = 6;
            IDPERSONA.Name = "IDPERSONA";
            IDPERSONA.ReadOnly = true;
            IDPERSONA.Visible = false;
            IDPERSONA.Width = 125;
            // 
            // NOMBRE_COMPLETO
            // 
            NOMBRE_COMPLETO.HeaderText = "NOMBRE COMPLETO";
            NOMBRE_COMPLETO.MinimumWidth = 6;
            NOMBRE_COMPLETO.Name = "NOMBRE_COMPLETO";
            NOMBRE_COMPLETO.ReadOnly = true;
            NOMBRE_COMPLETO.Width = 300;
            // 
            // TIPO_CLIENTE
            // 
            TIPO_CLIENTE.HeaderText = "TIPO CLIENTE";
            TIPO_CLIENTE.MinimumWidth = 6;
            TIPO_CLIENTE.Name = "TIPO_CLIENTE";
            TIPO_CLIENTE.ReadOnly = true;
            TIPO_CLIENTE.Width = 200;
            // 
            // CODIGO_CLIENTE
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CODIGO_CLIENTE.DefaultCellStyle = dataGridViewCellStyle3;
            CODIGO_CLIENTE.HeaderText = "CODIGO CLIENTE";
            CODIGO_CLIENTE.MinimumWidth = 6;
            CODIGO_CLIENTE.Name = "CODIGO_CLIENTE";
            CODIGO_CLIENTE.ReadOnly = true;
            CODIGO_CLIENTE.Width = 300;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.ReadOnly = true;
            ESTADO.Width = 200;
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
            button1.ForeColor = Color.White;
            button1.Location = new Point(100, 445);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 22;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(157, 13, 20);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 74, 173);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 74, 173);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 74, 173);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(253, 445);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 26;
            button3.Text = "VER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ClientesListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 160, 54);
            ClientSize = new Size(969, 520);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientesListarVista";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ClientesListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private DataGridViewTextBoxColumn IDCLIENTE;
        private DataGridViewTextBoxColumn IDPERSONA;
        private DataGridViewTextBoxColumn NOMBRE_COMPLETO;
        private DataGridViewTextBoxColumn TIPO_CLIENTE;
        private DataGridViewTextBoxColumn CODIGO_CLIENTE;
        private DataGridViewTextBoxColumn ESTADO;
    }
}