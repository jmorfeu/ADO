using Dal;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ClearControl()
        {
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_apellido.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_apellido.Text) )
            {
                MessageBox.Show("Debe indicar el apellido");
                txt_apellido.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Debe indicar el Nombre");
                txt_nombre.Focus();
                return;
            }

            
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.Nombre=txt_nombre.Text;
            estudiantes.Apellido=txt_apellido.Text;

            try
            {
                Conexion conexion = new Conexion();
                conexion.InsertEstudiantes(estudiantes);
                MessageBox.Show("Estudiante insertado correctamente");
                ClearControl();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}