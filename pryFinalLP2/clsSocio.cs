using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace pryFinalLP2
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =D:\\IES\\01-PrimerAño\\Programación 2\\Final\\pryFinalLP2\\bin\\Debug\\BD_Clientes.mdb";
        private string Tabla = "Socio";

        private Int32 idSoc;
        private String nom;
        private String dir;
        private Int32 idBar;
        private Int32 idAct;
        private Decimal deu;

        private Decimal deuda;
        private Int32 cant;
        private Decimal men;
        private Decimal may;

        public Int32 IdSocio
        {
            get { return idSoc; }
            set { idSoc = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Direccion
        {
            get { return dir; }
            set { dir = value; }
        }

        public Int32 idBarrio
        {
            get { return idBar; }
            set { idBar = value; }
        }

        public Int32 idActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }

        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }

        public Decimal TotalDeuda
        {
            get { return deuda; }
        }

        public Int32 TotalDeudores
        {
            get { return cant; }
        }

        public Decimal PromedioDeuda
        {
            get { return deuda / cant; }
        }

        public Decimal MenorDeudor
        {
            get { return men; }
        }

        public Decimal MayorDeudor
        {
            get { return may; }
        }


        public void AgregarNuevoRegistro()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                String verificarSql = "SELECT COUNT(*) FROM Socio WHERE IdSocio = " + IdSocio.ToString();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = verificarSql;

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un socio con ese número!!!");
                }
                else
                {
                    String sql = "INSERT INTO Socio (IdSocio, Nombre, Direccion, idBarrio, idActividad, Deuda) " +
                                 "VALUES (" + IdSocio.ToString() + ", '" + nom.Replace("'", "''") + "', '" + dir.Replace("'", "''") +
                                 "', " + idBar.ToString() + ", " + idAct.ToString() + ", 0)";

                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Nuevo glorioso en la familia!!!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al agregar el registro: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        public void ListarSocios(DataGridView Grilla)
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
                Grilla.Rows.Clear();
                deuda = 0;
                cant = 0;
                may = decimal.MinValue;
                men = decimal.MaxValue;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                        cant++;
                        deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        if (Convert.ToDecimal(fila["Deuda"]) > may)
                        { may = Convert.ToDecimal(fila["Deuda"]); }
                        if (Convert.ToDecimal(fila["Deuda"]) < men)
                        { men = Convert.ToDecimal(fila["Deuda"]); }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

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
                Combo.ValueMember = "IdSocio";
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

        public void ListarSociosDeudores(DataGridView Grilla)
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

                Grilla.Rows.Clear();
                deuda = 0;
                cant = 0;
                may = decimal.MinValue;
                men = decimal.MaxValue;

                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToDecimal(fila["Deuda"]) > 0)
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                            cant++;
                            deuda += Convert.ToDecimal(fila["Deuda"]);

                            if (Convert.ToDecimal(fila["Deuda"]) > may)
                            {
                                may = Convert.ToDecimal(fila["Deuda"]);
                            }

                            if (Convert.ToDecimal(fila["Deuda"]) < men)
                            {
                                men = Convert.ToDecimal(fila["Deuda"]);
                            }
                        }
                    }

                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ListarSociosXActividad(DataGridView Grilla, Int32 IdActividad)
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
                Grilla.Rows.Clear();
                deuda = 0;
                cant = 0;
                may = decimal.MinValue;
                men = decimal.MaxValue;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                            cant++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                            if (Convert.ToDecimal(fila["Deuda"]) > may)
                            { may = Convert.ToDecimal(fila["Deuda"]); }
                            if (Convert.ToDecimal(fila["Deuda"]) < men)
                            { men = Convert.ToDecimal(fila["Deuda"]); }
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarSociosXBarrio(DataGridView Grilla, Int32 IdBarrio)
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
                Grilla.Rows.Clear();
                deuda = 0;
                cant = 0;
                may = decimal.MinValue;
                men = decimal.MaxValue;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == IdBarrio)
                        {
                            Grilla.Rows.Add(fila["IdSocio"], fila["Nombre"], fila["Deuda"]);
                            cant++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                            if (Convert.ToDecimal(fila["Deuda"]) > may)
                            { may = Convert.ToDecimal(fila["Deuda"]); }
                            if (Convert.ToDecimal(fila["Deuda"]) < men)
                            { men = Convert.ToDecimal(fila["Deuda"]); }
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font LetraTexto = new Font("Arial", 8);
                Int32 linea = 180;
                reporte.Graphics.DrawString("Listado de Socios", LetraTitulo1, Brushes.Black, 100, 100);
                reporte.Graphics.DrawString("N° de Socio", LetraTitulo2, Brushes.Black, 100, 160);
                reporte.Graphics.DrawString("Nombre del Socio", LetraTitulo2, Brushes.Black, 200, 160);
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdSocio"].ToString() + " -", LetraTexto, Brushes.Black, 100, linea);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(), LetraTexto, Brushes.Black, 200, linea);
                        linea = linea + 12;

                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        public void ReporteSociosActividad(Int32 IdActividad, String NombreArchivo)
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
                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("Listado de Socios de una Actividad\n");
                AD.WriteLine("N°Socio;Nombre");
                deuda = 0;
                cant = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Nombre"]);
                            cant++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                    AD.Write("\nCantidad de Socios:;;");
                    AD.WriteLine(cant);
                    AD.Write("Deuda total:;;");
                    AD.WriteLine(deuda);
                }
                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteSociosBarrio(Int32 IdBarrio, String NombreArchivo)
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
                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("Listado de Socios de una Actividad\n");
                AD.WriteLine("N°Socio;Nombre");
                deuda = 0;
                cant = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == IdBarrio)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Nombre"]);
                            cant++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                    AD.Write("\nCantidad de Socios:;;");
                    AD.WriteLine(cant);
                    AD.Write("Deuda total:;;");
                    AD.WriteLine(deuda);
                }
                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ReporteClientes(String NombreArchivo)
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


                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("Listado de Socios\n");
                AD.WriteLine("N°Socio;Nombre;Deuda");


                deuda = 0;
                cant = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        AD.Write(fila["IdSocio"]);
                        AD.Write(";");
                        AD.Write(fila["Nombre"]);
                        AD.Write(";");
                        AD.WriteLine(fila["Deuda"]);
                        cant++;
                        deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                    }
                    AD.Write("\nCantidad de Clientes:;;");
                    AD.WriteLine(cant);
                    AD.Write("Deuda total:;;");
                    AD.WriteLine(deuda);
                }
                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ReporteClientesDeudores(String NombreArchivo)
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


                StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
                AD.WriteLine("Listado de Socios\n");
                AD.WriteLine("N°Socio;Nombre;Deuda");


                deuda = 0;
                cant = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToDecimal(fila["Deuda"]) > 0)
                        {
                            AD.Write(fila["IdSocio"]);
                            AD.Write(";");
                            AD.Write(fila["Nombre"]);
                            AD.Write(";");
                            AD.WriteLine(fila["Deuda"]);
                            cant++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                    AD.Write("\nCantidad de Clientes:;;");
                    AD.WriteLine(cant);
                    AD.Write("Deuda total:;;");
                    AD.WriteLine(deuda);
                }
                conexion.Close();
                AD.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Buscar(Int32 IdSocio)
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
                idSoc = 0;
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdSocio"]) == IdSocio)
                        {
                            idSoc = Convert.ToInt32(fila["IdSocio"]);
                            nom = fila["Nombre"].ToString();
                            dir = fila["Direccion"].ToString();
                            idBar = Convert.ToInt32(fila["IdBarrio"]);
                            idAct = Convert.ToInt32(fila["IdActividad"]);
                            deu = Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void Eliminar(Int32 IdSocio)
        {
            try
            {
                String sql = "DELETE * FROM Socio WHERE IdSocio = " + IdSocio.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Modificar(Int32 IdSocio)
        {
            try
            {
                String sql = "UPDATE Socio SET Nombre = '" + nom.Replace("'", "''") +
                             "', Direccion = '" + dir.Replace("'", "''") +
                             "', idBarrio = " + idBar.ToString() +
                             ", idActividad = " + idAct.ToString() +
                             ", Deuda = " + deu.ToString().Replace(',', '.') +
                             " WHERE IdSocio = " + IdSocio.ToString();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
