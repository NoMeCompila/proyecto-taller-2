using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoTallerII
{
    public partial class Form_back : Form
    {
        public Form_back()
        {
            InitializeComponent();
        }

        //datos de conexión
        //public string cadena = "Server=DESKTOP-C7M4JOU;Database=JOYERIA;Integrated Security=true";
        SqlConnection cn = new SqlConnection("Server=DESKTOP-C7M4JOU;Database=JOYERIA;Integrated Security=true");

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            //generar un nombre en formato string con fecha y hora para la copia de seguridad
            string nombre_copia = (System.DateTime.Today.Day.ToString() + 
                "-" + System.DateTime.Today.Month.ToString() + "-" +
                System.DateTime.Today.Year.ToString() + "-" +
                System.DateTime.Now.Hour.ToString() + "-" +
                System.DateTime.Now.Minute.ToString()+"-"+
                System.DateTime.Now.Second.ToString()+"-"+
                "respaldo.bak");

            string comando_consulta = "BACKUP DATABASE [Joyeria] TO  DISK = N'C:\\Users\\Fer\\Desktop\\taller_copia\\proyecto-taller-2\\Backup\\"+nombre_copia+"'WITH NOFORMAT, NOINIT,  NAME = N'Joyeria-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta,cn);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia de seguridad se ha generado correctamente", "BACKUP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Si desea generar otra copia de seguridad por favor, cierre el formulario e intentelo de nuevo "+ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }


        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

  
    }
}
