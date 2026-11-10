using Aca_Biblioteca.Datos;

namespace Aca_Biblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Conexion conexion = new Conexion(); 

            try
            { 
             using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                // La conexión se ha establecido correctamente
                MessageBox.Show("Conexión a la base de datos establecida correctamente.",
                    "Aca_Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                    "Aca_Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            AbrirFormulario(new FrmInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            // Limpiar el panel de contenido
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void btmEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void btmPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void btmReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}