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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1096, 428);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1191, 76);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1307, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(1307, 113);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(329, 31);
            txtDesc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1191, 113);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 3;
            label2.Text = "Descripcion:";
            label2.Click += label2_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(1307, 150);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(329, 31);
            txtMarca.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1191, 150);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 5;
            label3.Text = "Marca:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(1307, 189);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(329, 31);
            txtPrecio.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1191, 189);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 7;
            label4.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1307, 226);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(329, 31);
            txtStock.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1191, 226);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 9;
            label5.Text = "Stock:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1191, 302);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(445, 64);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar:";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 610);
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
            Controls.Add(dataGridView1);
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
    }
}
