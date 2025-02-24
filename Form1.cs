using System.Data;

namespace AppBases_De_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectividad conectividad = new Conectividad();
            DataSet resultado = conectividad.conectarMySQL();
            tablaConsulta.DataSource = resultado.Tables[0];
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            Conectividad conectividad = new Conectividad();
            DataSet resultado = conectividad.conectarPostgreSQL();
            tablaConsulta.DataSource = resultado.Tables[0];
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            Conectividad conectividad = new Conectividad();
            DataSet resultado = conectividad.conectarSQLite();
            tablaConsulta.DataSource = resultado.Tables[0];
        }

        private void tablaConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
