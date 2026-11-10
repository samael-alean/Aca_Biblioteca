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
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAño = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloL = new Label();
            lblISBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1348, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(443, 0);
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
            pnlBusqueda.Size = new Size(1348, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(748, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // texBuscar
            // 
            texBuscar.Location = new Point(575, 15);
            texBuscar.Name = "texBuscar";
            texBuscar.Size = new Size(125, 27);
            texBuscar.TabIndex = 3;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(382, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(44, 20);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "ISBN";
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
            pnlDatos.Size = new Size(1348, 287);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(521, 126);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(227, 28);
            cmbEditorial.TabIndex = 16;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(521, 84);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(227, 28);
            cmbAutor.TabIndex = 15;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(521, 238);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(227, 27);
            txtExistencias.TabIndex = 14;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(521, 197);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(227, 27);
            txtAño.TabIndex = 13;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(521, 164);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(227, 27);
            txtCategoria.TabIndex = 12;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(522, 47);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(227, 27);
            txtTitulo.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(521, 14);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(227, 27);
            txtISBN.TabIndex = 10;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(382, 245);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(89, 20);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "Existencias:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(382, 195);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(42, 20);
            lblAño.TabIndex = 8;
            lblAño.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(382, 164);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(382, 126);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 20);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(382, 92);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(55, 20);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
            // 
            // lblTituloL
            // 
            lblTituloL.AutoSize = true;
            lblTituloL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloL.Location = new Point(378, 54);
            lblTituloL.Name = "lblTituloL";
            lblTituloL.Size = new Size(54, 20);
            lblTituloL.TabIndex = 4;
            lblTituloL.Text = "Titulo:";
            lblTituloL.Click += lblTituloL_Click;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(378, 14);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(48, 20);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(249, 408);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(731, 53);
            pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(609, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 38);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.Location = new Point(475, 7);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 38);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Elimininar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.Location = new Point(324, 7);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 38);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(177, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 38);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(19, 7);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(138, 38);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(97, 467);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(1100, 254);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
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
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private DataGridView dgvLibros;
    }
}