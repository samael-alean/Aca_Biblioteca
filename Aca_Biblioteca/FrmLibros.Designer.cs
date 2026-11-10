namespace Aca_Biblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            texBuscar = new TextBox();
            pnlDatos = new Panel();
            lblBuscar = new Label();
            lblISBN = new Label();
            lblTituloL = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblCategoria = new Label();
            lblAño = new Label();
            lblExistencias = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtCategoria = new TextBox();
            txtAño = new TextBox();
            txtExistencias = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(253, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(305, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTION DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(texBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(800, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(494, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // texBuscar
            // 
            texBuscar.Location = new Point(300, 17);
            texBuscar.Name = "texBuscar";
            texBuscar.Size = new Size(125, 27);
            texBuscar.TabIndex = 3;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloL);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 287);
            pnlDatos.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(179, 24);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(44, 20);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "ISBN";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(185, 14);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(48, 20);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblTituloL
            // 
            lblTituloL.AutoSize = true;
            lblTituloL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloL.Location = new Point(179, 54);
            lblTituloL.Name = "lblTituloL";
            lblTituloL.Size = new Size(54, 20);
            lblTituloL.TabIndex = 4;
            lblTituloL.Text = "Titulo:";
            lblTituloL.Click += lblTituloL_Click;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(185, 87);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(55, 20);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(179, 126);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 20);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(179, 164);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(185, 202);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(42, 20);
            lblAño.TabIndex = 8;
            lblAño.Text = "Año:";
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(179, 245);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(89, 20);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(279, 11);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(227, 27);
            txtISBN.TabIndex = 10;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(279, 54);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(227, 27);
            txtTitulo.TabIndex = 11;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(279, 157);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(227, 27);
            txtCategoria.TabIndex = 12;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(279, 195);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(227, 27);
            txtAño.TabIndex = 13;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(279, 238);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(227, 27);
            txtExistencias.TabIndex = 14;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(279, 87);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(227, 28);
            cmbAutor.TabIndex = 15;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(279, 123);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(227, 28);
            cmbEditorial.TabIndex = 16;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button button1;
        private TextBox texBuscar;
        private Panel pnlDatos;
        private Button btnBuscar;
        private Label lblBuscar;
        private Label lblISBN;
        private Label lblAño;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label lblAutor;
        private Label lblTituloL;
        private Label lblExistencias;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAño;
    }
}