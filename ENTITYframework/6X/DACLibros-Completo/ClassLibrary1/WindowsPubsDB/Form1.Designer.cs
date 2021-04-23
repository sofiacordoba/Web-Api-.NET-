
namespace WindowsPubsDB
{
    partial class Form1
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
            this.gridPubs = new System.Windows.Forms.DataGridView();
            this.btnInsertarAutor = new System.Windows.Forms.Button();
            this.btnModificarAutor = new System.Windows.Forms.Button();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiudadAutor = new System.Windows.Forms.TextBox();
            this.btnCiudadAutor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.btnIdAutor = new System.Windows.Forms.Button();
            this.gridPubs2 = new System.Windows.Forms.DataGridView();
            this.Insertar = new System.Windows.Forms.Button();
            this.btnModificarPub = new System.Windows.Forms.Button();
            this.btnEliminarPub = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCiudadPub = new System.Windows.Forms.TextBox();
            this.btnCiudadPub = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPub = new System.Windows.Forms.TextBox();
            this.btnIdPub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPubs
            // 
            this.gridPubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPubs.Location = new System.Drawing.Point(33, 201);
            this.gridPubs.Name = "gridPubs";
            this.gridPubs.Size = new System.Drawing.Size(346, 237);
            this.gridPubs.TabIndex = 0;
            // 
            // btnInsertarAutor
            // 
            this.btnInsertarAutor.Location = new System.Drawing.Point(32, 30);
            this.btnInsertarAutor.Name = "btnInsertarAutor";
            this.btnInsertarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarAutor.TabIndex = 1;
            this.btnInsertarAutor.Text = "Insertar";
            this.btnInsertarAutor.UseVisualStyleBackColor = true;
            this.btnInsertarAutor.Click += new System.EventHandler(this.btnInsertarAutor_Click);
            // 
            // btnModificarAutor
            // 
            this.btnModificarAutor.Location = new System.Drawing.Point(32, 59);
            this.btnModificarAutor.Name = "btnModificarAutor";
            this.btnModificarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAutor.TabIndex = 2;
            this.btnModificarAutor.Text = "Modificar";
            this.btnModificarAutor.UseVisualStyleBackColor = true;
            this.btnModificarAutor.Click += new System.EventHandler(this.btnModificarAutor_Click);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.Location = new System.Drawing.Point(33, 88);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAutor.TabIndex = 3;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = true;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Autores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(402, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Publicadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad";
            // 
            // txtCiudadAutor
            // 
            this.txtCiudadAutor.Location = new System.Drawing.Point(32, 135);
            this.txtCiudadAutor.Name = "txtCiudadAutor";
            this.txtCiudadAutor.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadAutor.TabIndex = 7;
            // 
            // btnCiudadAutor
            // 
            this.btnCiudadAutor.Location = new System.Drawing.Point(152, 135);
            this.btnCiudadAutor.Name = "btnCiudadAutor";
            this.btnCiudadAutor.Size = new System.Drawing.Size(75, 23);
            this.btnCiudadAutor.TabIndex = 8;
            this.btnCiudadAutor.Text = "Buscar";
            this.btnCiudadAutor.UseVisualStyleBackColor = true;
            this.btnCiudadAutor.Click += new System.EventHandler(this.btnCiudadAutor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.Location = new System.Drawing.Point(32, 172);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.Size = new System.Drawing.Size(100, 20);
            this.txtIdAutor.TabIndex = 10;
            // 
            // btnIdAutor
            // 
            this.btnIdAutor.Location = new System.Drawing.Point(152, 172);
            this.btnIdAutor.Name = "btnIdAutor";
            this.btnIdAutor.Size = new System.Drawing.Size(75, 23);
            this.btnIdAutor.TabIndex = 11;
            this.btnIdAutor.Text = "Buscar";
            this.btnIdAutor.UseVisualStyleBackColor = true;
            this.btnIdAutor.Click += new System.EventHandler(this.btnIdAutor_Click);
            // 
            // gridPubs2
            // 
            this.gridPubs2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPubs2.Location = new System.Drawing.Point(405, 201);
            this.gridPubs2.Name = "gridPubs2";
            this.gridPubs2.Size = new System.Drawing.Size(383, 237);
            this.gridPubs2.TabIndex = 12;
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(405, 30);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(75, 23);
            this.Insertar.TabIndex = 13;
            this.Insertar.Text = "Insertar";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // btnModificarPub
            // 
            this.btnModificarPub.Location = new System.Drawing.Point(405, 60);
            this.btnModificarPub.Name = "btnModificarPub";
            this.btnModificarPub.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPub.TabIndex = 14;
            this.btnModificarPub.Text = "Modificar";
            this.btnModificarPub.UseVisualStyleBackColor = true;
            this.btnModificarPub.Click += new System.EventHandler(this.btnModificarPub_Click);
            // 
            // btnEliminarPub
            // 
            this.btnEliminarPub.Location = new System.Drawing.Point(405, 90);
            this.btnEliminarPub.Name = "btnEliminarPub";
            this.btnEliminarPub.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPub.TabIndex = 15;
            this.btnEliminarPub.Text = "Eliminar";
            this.btnEliminarPub.UseVisualStyleBackColor = true;
            this.btnEliminarPub.Click += new System.EventHandler(this.btnEliminarPub_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ciudad";
            // 
            // txtCiudadPub
            // 
            this.txtCiudadPub.Location = new System.Drawing.Point(405, 135);
            this.txtCiudadPub.Name = "txtCiudadPub";
            this.txtCiudadPub.Size = new System.Drawing.Size(100, 20);
            this.txtCiudadPub.TabIndex = 17;
            // 
            // btnCiudadPub
            // 
            this.btnCiudadPub.Location = new System.Drawing.Point(512, 135);
            this.btnCiudadPub.Name = "btnCiudadPub";
            this.btnCiudadPub.Size = new System.Drawing.Size(75, 23);
            this.btnCiudadPub.TabIndex = 18;
            this.btnCiudadPub.Text = "Buscar";
            this.btnCiudadPub.UseVisualStyleBackColor = true;
            this.btnCiudadPub.Click += new System.EventHandler(this.btnCiudadPub_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Id";
            // 
            // txtIdPub
            // 
            this.txtIdPub.Location = new System.Drawing.Point(405, 171);
            this.txtIdPub.Name = "txtIdPub";
            this.txtIdPub.Size = new System.Drawing.Size(100, 20);
            this.txtIdPub.TabIndex = 20;
            // 
            // btnIdPub
            // 
            this.btnIdPub.Location = new System.Drawing.Point(512, 171);
            this.btnIdPub.Name = "btnIdPub";
            this.btnIdPub.Size = new System.Drawing.Size(75, 23);
            this.btnIdPub.TabIndex = 21;
            this.btnIdPub.Text = "Buscar";
            this.btnIdPub.UseVisualStyleBackColor = true;
            this.btnIdPub.Click += new System.EventHandler(this.btnIdPub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIdPub);
            this.Controls.Add(this.txtIdPub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCiudadPub);
            this.Controls.Add(this.txtCiudadPub);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarPub);
            this.Controls.Add(this.btnModificarPub);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.gridPubs2);
            this.Controls.Add(this.btnIdAutor);
            this.Controls.Add(this.txtIdAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCiudadAutor);
            this.Controls.Add(this.txtCiudadAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnModificarAutor);
            this.Controls.Add(this.btnInsertarAutor);
            this.Controls.Add(this.gridPubs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPubs2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPubs;
        private System.Windows.Forms.Button btnInsertarAutor;
        private System.Windows.Forms.Button btnModificarAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCiudadAutor;
        private System.Windows.Forms.Button btnCiudadAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAutor;
        private System.Windows.Forms.Button btnIdAutor;
        private System.Windows.Forms.DataGridView gridPubs2;
        private System.Windows.Forms.Button Insertar;
        private System.Windows.Forms.Button btnModificarPub;
        private System.Windows.Forms.Button btnEliminarPub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCiudadPub;
        private System.Windows.Forms.Button btnCiudadPub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPub;
        private System.Windows.Forms.Button btnIdPub;
    }
}

