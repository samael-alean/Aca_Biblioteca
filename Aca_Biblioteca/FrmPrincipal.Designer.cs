namespace Aca_Biblioteca
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btmReporte = new FontAwesome.Sharp.IconButton();
            btmPrestamos = new FontAwesome.Sharp.IconButton();
            btmEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btmReporte);
            pnlMenu.Controls.Add(btmPrestamos);
            pnlMenu.Controls.Add(btmEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(328, 603);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;
            btnSalir.Location = new Point(0, 395);
            btnSalir.Margin = new Padding(10, 0, 10, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(328, 45);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btmReporte
            // 
            btmReporte.AutoSize = true;
            btmReporte.Dock = DockStyle.Top;
            btmReporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmReporte.IconChar = FontAwesome.Sharp.IconChar.BookAtlas;
            btmReporte.IconColor = Color.Black;
            btmReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btmReporte.IconSize = 30;
            btmReporte.Location = new Point(0, 350);
            btmReporte.Margin = new Padding(10, 0, 10, 0);
            btmReporte.Name = "btmReporte";
            btmReporte.Size = new Size(328, 45);
            btmReporte.TabIndex = 7;
            btmReporte.Text = "Reporte";
            btmReporte.TextAlign = ContentAlignment.MiddleLeft;
            btmReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmReporte.UseVisualStyleBackColor = true;
            btmReporte.Click += btmReporte_Click;
            // 
            // btmPrestamos
            // 
            btmPrestamos.AutoSize = true;
            btmPrestamos.Dock = DockStyle.Top;
            btmPrestamos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmPrestamos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btmPrestamos.IconColor = Color.Black;
            btmPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btmPrestamos.IconSize = 30;
            btmPrestamos.Location = new Point(0, 305);
            btmPrestamos.Margin = new Padding(10, 0, 10, 0);
            btmPrestamos.Name = "btmPrestamos";
            btmPrestamos.Size = new Size(328, 45);
            btmPrestamos.TabIndex = 6;
            btmPrestamos.Text = "Prestamos";
            btmPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btmPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmPrestamos.UseVisualStyleBackColor = true;
            btmPrestamos.Click += btmPrestamos_Click;
            // 
            // btmEditoriales
            // 
            btmEditoriales.AutoSize = true;
            btmEditoriales.Dock = DockStyle.Top;
            btmEditoriales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btmEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btmEditoriales.IconColor = Color.Black;
            btmEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btmEditoriales.IconSize = 30;
            btmEditoriales.Location = new Point(0, 260);
            btmEditoriales.Margin = new Padding(10, 0, 10, 0);
            btmEditoriales.Name = "btmEditoriales";
            btmEditoriales.Size = new Size(328, 45);
            btmEditoriales.TabIndex = 5;
            btmEditoriales.Text = "Editoriales";
            btmEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btmEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmEditoriales.UseVisualStyleBackColor = true;
            btmEditoriales.Click += btmEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;
            btnAutores.Location = new Point(0, 215);
            btnAutores.Margin = new Padding(10, 0, 10, 0);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(328, 45);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleLeft;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.Location = new Point(0, 170);
            btnUsuarios.Margin = new Padding(10, 0, 10, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(328, 45);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.AutoSize = true;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;
            btnLibros.Location = new Point(0, 125);
            btnLibros.Margin = new Padding(10, 0, 10, 0);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(328, 45);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;
            btnInicio.Location = new Point(0, 80);
            btnInicio.Margin = new Padding(10, 0, 10, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(328, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.DarkBlue;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(328, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(134, 69);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.WhiteSmoke;
            lblSubtitulo.Location = new Point(155, 44);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(128, 18);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema De Gestion ";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(140, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.LightSteelBlue;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(328, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1184, 80);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ControlLight;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(328, 568);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(1184, 35);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(328, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1184, 488);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 603);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestion De Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }
        
        

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btmPrestamos;
        private FontAwesome.Sharp.IconButton btmEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btmReporte;
    }
}
