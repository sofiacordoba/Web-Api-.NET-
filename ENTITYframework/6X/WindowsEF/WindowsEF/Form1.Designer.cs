
namespace WindowsEF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.btnBuscarAuthor = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnBuscarPorCity = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(91, 50);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(99, 23);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 101);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(91, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author Id";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(179, 197);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorId.TabIndex = 4;
            this.txtAuthorId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarAuthor
            // 
            this.btnBuscarAuthor.Location = new System.Drawing.Point(346, 193);
            this.btnBuscarAuthor.Name = "btnBuscarAuthor";
            this.btnBuscarAuthor.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarAuthor.TabIndex = 5;
            this.btnBuscarAuthor.Text = "Buscar Author";
            this.btnBuscarAuthor.UseVisualStyleBackColor = true;
            this.btnBuscarAuthor.Click += new System.EventHandler(this.btnBuscarAuthor_Click);
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(179, 222);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(520, 150);
            this.gridAuthor.TabIndex = 6;
            // 
            // btnBuscarPorCity
            // 
            this.btnBuscarPorCity.Location = new System.Drawing.Point(701, 195);
            this.btnBuscarPorCity.Name = "btnBuscarPorCity";
            this.btnBuscarPorCity.Size = new System.Drawing.Size(87, 23);
            this.btnBuscarPorCity.TabIndex = 7;
            this.btnBuscarPorCity.Text = "Buscar por city";
            this.btnBuscarPorCity.UseVisualStyleBackColor = true;
            this.btnBuscarPorCity.Click += new System.EventHandler(this.btnBuscarPorCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(544, 197);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnBuscarPorCity);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnBuscarAuthor);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.Button btnBuscarAuthor;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnBuscarPorCity;
        private System.Windows.Forms.TextBox txtCity;
    }
}

