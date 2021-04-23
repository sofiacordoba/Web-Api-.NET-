
namespace WindowsFormsApp1
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
            this.btnInsertarAuthor = new System.Windows.Forms.Button();
            this.btnModificarAuthor = new System.Windows.Forms.Button();
            this.btnEliminarAuthor = new System.Windows.Forms.Button();
            this.btnInsertarPublisher = new System.Windows.Forms.Button();
            this.btnModificarPublisher = new System.Windows.Forms.Button();
            this.btnEliminarPublisher = new System.Windows.Forms.Button();
            this.btnBuscaruthor = new System.Windows.Forms.Button();
            this.btnBuscarPorCity = new System.Windows.Forms.Button();
            this.btnBuscarPubporCountry = new System.Windows.Forms.Button();
            this.btnBuscarPubporId = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtAuthorId = new System.Windows.Forms.Label();
            this.txtPublisherId = new System.Windows.Forms.Label();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertarAuthor
            // 
            this.btnInsertarAuthor.Location = new System.Drawing.Point(101, 26);
            this.btnInsertarAuthor.Name = "btnInsertarAuthor";
            this.btnInsertarAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarAuthor.TabIndex = 0;
            this.btnInsertarAuthor.Text = "Insertar";
            this.btnInsertarAuthor.UseVisualStyleBackColor = true;
            // 
            // btnModificarAuthor
            // 
            this.btnModificarAuthor.Location = new System.Drawing.Point(101, 81);
            this.btnModificarAuthor.Name = "btnModificarAuthor";
            this.btnModificarAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAuthor.TabIndex = 1;
            this.btnModificarAuthor.Text = "Modificar";
            this.btnModificarAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAuthor
            // 
            this.btnEliminarAuthor.Location = new System.Drawing.Point(101, 133);
            this.btnEliminarAuthor.Name = "btnEliminarAuthor";
            this.btnEliminarAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAuthor.TabIndex = 2;
            this.btnEliminarAuthor.Text = "Eliminar";
            this.btnEliminarAuthor.UseVisualStyleBackColor = true;
            // 
            // btnInsertarPublisher
            // 
            this.btnInsertarPublisher.Location = new System.Drawing.Point(585, 35);
            this.btnInsertarPublisher.Name = "btnInsertarPublisher";
            this.btnInsertarPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarPublisher.TabIndex = 3;
            this.btnInsertarPublisher.Text = "Insertar";
            this.btnInsertarPublisher.UseVisualStyleBackColor = true;
            this.btnInsertarPublisher.Click += new System.EventHandler(this.btnInsertarPublisher_Click);
            // 
            // btnModificarPublisher
            // 
            this.btnModificarPublisher.Location = new System.Drawing.Point(585, 81);
            this.btnModificarPublisher.Name = "btnModificarPublisher";
            this.btnModificarPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPublisher.TabIndex = 4;
            this.btnModificarPublisher.Text = "Modificar";
            this.btnModificarPublisher.UseVisualStyleBackColor = true;
            this.btnModificarPublisher.Click += new System.EventHandler(this.btnModificarPublisher_Click);
            // 
            // btnEliminarPublisher
            // 
            this.btnEliminarPublisher.Location = new System.Drawing.Point(585, 133);
            this.btnEliminarPublisher.Name = "btnEliminarPublisher";
            this.btnEliminarPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPublisher.TabIndex = 5;
            this.btnEliminarPublisher.Text = "Eliminar";
            this.btnEliminarPublisher.UseVisualStyleBackColor = true;
            this.btnEliminarPublisher.Click += new System.EventHandler(this.btnEliminarPublisher_Click);
            // 
            // btnBuscaruthor
            // 
            this.btnBuscaruthor.Location = new System.Drawing.Point(225, 195);
            this.btnBuscaruthor.Name = "btnBuscaruthor";
            this.btnBuscaruthor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaruthor.TabIndex = 6;
            this.btnBuscaruthor.Text = "Buscar Author";
            this.btnBuscaruthor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorCity
            // 
            this.btnBuscarPorCity.Location = new System.Drawing.Point(225, 241);
            this.btnBuscarPorCity.Name = "btnBuscarPorCity";
            this.btnBuscarPorCity.Size = new System.Drawing.Size(105, 23);
            this.btnBuscarPorCity.TabIndex = 7;
            this.btnBuscarPorCity.Text = "Buscar por City";
            this.btnBuscarPorCity.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPubporCountry
            // 
            this.btnBuscarPubporCountry.Location = new System.Drawing.Point(655, 242);
            this.btnBuscarPubporCountry.Name = "btnBuscarPubporCountry";
            this.btnBuscarPubporCountry.Size = new System.Drawing.Size(133, 23);
            this.btnBuscarPubporCountry.TabIndex = 8;
            this.btnBuscarPubporCountry.Text = "Buscar por Country";
            this.btnBuscarPubporCountry.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPubporId
            // 
            this.btnBuscarPubporId.Location = new System.Drawing.Point(677, 204);
            this.btnBuscarPubporId.Name = "btnBuscarPubporId";
            this.btnBuscarPubporId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPubporId.TabIndex = 9;
            this.btnBuscarPubporId.Text = "Buscar";
            this.btnBuscarPubporId.UseVisualStyleBackColor = true;
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(-1, 288);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(387, 150);
            this.gridAuthor.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(549, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.AutoSize = true;
            this.txtAuthorId.Location = new System.Drawing.Point(27, 200);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(50, 13);
            this.txtAuthorId.TabIndex = 15;
            this.txtAuthorId.Text = "Author Id";
            this.txtAuthorId.Click += new System.EventHandler(this.txtAuthorId_Click);
            // 
            // txtPublisherId
            // 
            this.txtPublisherId.AutoSize = true;
            this.txtPublisherId.Location = new System.Drawing.Point(466, 209);
            this.txtPublisherId.Name = "txtPublisherId";
            this.txtPublisherId.Size = new System.Drawing.Size(62, 13);
            this.txtPublisherId.TabIndex = 16;
            this.txtPublisherId.Text = "Publisher Id";
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(409, 288);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.Size = new System.Drawing.Size(379, 150);
            this.gridPublisher.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridPublisher);
            this.Controls.Add(this.txtPublisherId);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnBuscarPubporId);
            this.Controls.Add(this.btnBuscarPubporCountry);
            this.Controls.Add(this.btnBuscarPorCity);
            this.Controls.Add(this.btnBuscaruthor);
            this.Controls.Add(this.btnEliminarPublisher);
            this.Controls.Add(this.btnModificarPublisher);
            this.Controls.Add(this.btnInsertarPublisher);
            this.Controls.Add(this.btnEliminarAuthor);
            this.Controls.Add(this.btnModificarAuthor);
            this.Controls.Add(this.btnInsertarAuthor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarAuthor;
        private System.Windows.Forms.Button btnModificarAuthor;
        private System.Windows.Forms.Button btnEliminarAuthor;
        private System.Windows.Forms.Button btnInsertarPublisher;
        private System.Windows.Forms.Button btnModificarPublisher;
        private System.Windows.Forms.Button btnEliminarPublisher;
        private System.Windows.Forms.Button btnBuscaruthor;
        private System.Windows.Forms.Button btnBuscarPorCity;
        private System.Windows.Forms.Button btnBuscarPubporCountry;
        private System.Windows.Forms.Button btnBuscarPubporId;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtAuthorId;
        private System.Windows.Forms.Label txtPublisherId;
        private System.Windows.Forms.DataGridView gridPublisher;
    }
}

