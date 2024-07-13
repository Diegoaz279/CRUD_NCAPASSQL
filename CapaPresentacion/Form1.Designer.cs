namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            label2 = new Label();
            txtMarca = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(963, 397);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(1039, 153);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightCyan;
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(1240, 153);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 37);
            txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.LightCyan;
            txtDesc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesc.Location = new Point(1240, 216);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(329, 37);
            txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Honeydew;
            label2.Location = new Point(1039, 216);
            label2.Name = "label2";
            label2.Size = new Size(189, 38);
            label2.TabIndex = 3;
            label2.Text = "Descripcion:";
            label2.Click += label2_Click;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.LightCyan;
            txtMarca.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(1240, 273);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(329, 37);
            txtMarca.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(1039, 273);
            label3.Name = "label3";
            label3.Size = new Size(112, 38);
            label3.TabIndex = 5;
            label3.Text = "Marca:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.LightCyan;
            txtPrecio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(1240, 335);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(329, 37);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(1039, 335);
            label4.Name = "label4";
            label4.Size = new Size(113, 38);
            label4.TabIndex = 7;
            label4.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.LightCyan;
            txtStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(1240, 395);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(329, 37);
            txtStock.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Honeydew;
            label5.Location = new Point(1039, 395);
            label5.Name = "label5";
            label5.Size = new Size(103, 38);
            label5.TabIndex = 9;
            label5.Text = "Stock:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(1183, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(274, 72);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 255, 255);
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(73, 512);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(138, 52);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 255, 255);
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(236, 512);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 52);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Peru;
            label6.Location = new Point(1080, 57);
            label6.Name = "label6";
            label6.Size = new Size(475, 48);
            label6.TabIndex = 14;
            label6.Text = "INGRESE LOS PRODUTOS ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Peru;
            label7.Location = new Point(41, 27);
            label7.Name = "label7";
            label7.Size = new Size(362, 41);
            label7.TabIndex = 15;
            label7.Text = "TABLA DE PRODUCTOS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1616, 601);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDesc;
        private Label label2;
        private TextBox txtMarca;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Label label5;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label6;
        private Label label7;
    }
}
