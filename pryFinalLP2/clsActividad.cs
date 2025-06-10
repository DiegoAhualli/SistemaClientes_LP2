using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryFinalLP2
{
    internal class clsActividad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =D:\\IES\\01-PrimerAño\\Programación 2\\Final\\pryFinalLP2\\bin\\Debug\\BD_Clientes.mdb";
        private string Tabla = "Actividad";

        public void Listar(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                Combo.DataSource = DS.Tables[Tabla];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idActividad";
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error inesperado: {e.Message}");
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }


        public String Buscar(Int32 IdActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                String Resultado = "";
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            Resultado = fila["Nombre"].ToString();
                        }
                    }
                }
                return Resultado;
            }
            catch (OleDbException ex)
            {
                return $"Error en la conexión a la base de datos: {ex.Message}";
            }
            catch (InvalidOperationException ex)
            {
                return $"Error en la operación de base de datos: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}";
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }


    }
}
