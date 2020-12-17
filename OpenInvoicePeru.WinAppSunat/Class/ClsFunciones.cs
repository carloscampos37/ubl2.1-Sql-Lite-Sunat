using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace OpenInvoicePeru.Class
{
    public class ClsFunciones
    {
        public string Left(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(0, caracteres);
        }

                public string Izquierda(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(0, caracteres);
        }

        public string Right(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(Dato.Length - caracteres, caracteres);
        }

        public string Derecha(string Dato, int caracteres)
        {
            if (caracteres > Dato.Length)
                caracteres = Dato.Length;
            return Dato.Substring(Dato.Length - caracteres, caracteres);
        }

        public DataTable FiltrarDataTable(DataTable poDataTable, string psFiltro, string psOrder = "")
        {
            DataRow[] loRows;
            DataTable loNuevoDataTable = new DataTable();
            try
            {
                loNuevoDataTable = poDataTable.Clone();
                if (psOrder == "")
                {
                    loRows = poDataTable.Select(psFiltro);
                }
                else
                {
                    loRows = poDataTable.Select(psFiltro, psOrder);
                }
                foreach (DataRow ldrRow in loRows)
                {
                    loNuevoDataTable.ImportRow(ldrRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return loNuevoDataTable;
        }

        public string ComputerName(int tipo = 0)
        {
            string functionReturnValue ;

            if (tipo == 0)
            {
                Random r = new Random();
                functionReturnValue = "##" + System.Environment.MachineName + r.Next(1, 1000).ToString();
            }
            else
            {
                functionReturnValue = "##" + System.Environment.MachineName;
            }
            return functionReturnValue;
        }

        public string CreacionDirectorio(string Cadena1, string cadena2)
        {
            string Cadena = Path.Combine(Cadena1, $"{cadena2}");

            if (!(Directory.Exists(Cadena)))
            {
                // Try to create the directory.
                Directory.CreateDirectory(Cadena);
            }
            return Cadena;
        }

        public string DesMes(string vMes)
        {
            string DescriMes ;
            switch (vMes)
            {
                case "01":
                    DescriMes = "ENERO";
                    break;

                case "02":
                    DescriMes = "FEBRERO";
                    break;

                case "03":
                    DescriMes = "MARZO";
                    break;

                case "04":
                    DescriMes = "ABRIL";
                    break;

                case "05":
                    DescriMes = "MAYO";
                    break;

                case "06":
                    DescriMes = "JUNIO";
                    break;

                case "07":
                    DescriMes = "JULIO";
                    break;

                case "08":
                    DescriMes = "AGOSTO";
                    break;

                case "09":
                    DescriMes = "SETIEMBRE";
                    break;

                case "10":
                    DescriMes = "OCTUBRE";
                    break;

                case "11":
                    DescriMes = "NOVIEMBRE";
                    break;

                default:
                    DescriMes = "DICIEMBRE";
                    break;
            }

            return DescriMes;
        }

        public void ActualizaItemDia(string vEmpresa, string vFecha, string vCadenaConex)
        {
            string SQL;
            SQL = " Update dbo.FEResumenDiarioDocumentosCab SET IdentificadorEnvio=IdentificadorEnvio+1";
            SQL += " WHERE EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";

            GrabarTabla(SQL, vCadenaConex);
        }

        public double Totalventas(DataTable dtx)
        {
            double valor = new double();
            for (int ii = 0; ii <= dtx.Rows.Count - 1; ii++)
            {
                valor += Convert.ToDouble(dtx.Rows[ii]["TotalImporteVenta"]);
            }
            return valor;
        }

        //  public DataTable DocumentosAEnviar()
        //{
        //       public string Sql = "";

        //  Sql=" SELECT Reg=SUm(NumerodeDocumentos) FROM fe_ResumenDiarioCab a INNER JOIN fe_ResumendiarioDet b"
        //    sql+="WHERE a.ResumenDiario_id=b.resumenDiario_id";
        // }

        public DataTable ConsultarTabla(string vSQL, string vCadConex)
        {
            string cError ;
            try
            {
                string strConn = "";
                strConn = vCadConex;
                SqlConnection oConn = new SqlConnection(vCadConex);
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(vSQL, oConn);
                da.Fill(dt1);
                oConn.Close();
                return dt1;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return null;
            }
        }

        public bool GrabarTabla(string vSQL, string vCadConex)
        {
            string cError="" ;
            try
            {
                SqlConnection oConn = new SqlConnection(vCadConex);
                SqlCommand da = new SqlCommand(vSQL, oConn);
                oConn.Open();
                da.ExecuteNonQuery();
                oConn.Close();
                da = null;
                return true;
            }
            catch (Exception ex)
            {
                cError = ex.Message;
                return false;
            }
        }

        public void ActualizaEnviosDia(DataTable dtx, string vItemEnvio, string vNroticket)
        {
            string Sql ;
            for (int ii = 0; ii <= dtx.Rows.Count - 1; ii++)
            {
                Sql = " UPDATE fe_ResumenDiarioDocumentos SET EstadoEnvioSunat_id='" + vItemEnvio + ", NumerodeAceptacion='" + vNroticket + "'";
                Sql += " WHERE empresacodigo='" + (string)dtx.Rows[ii]["Empresacodigo"] + "' ";
                Sql += " AND ResumenDiario_Id=" + (int)dtx.Rows[ii]["ResumenDiario_Id"] + " AND ResumendiarioCorrel=" + (int)dtx.Rows[ii]["ResumenDiario_Id"];

                //     GrabarTabla(Sql, Vgcnx);
            }
        }
    }
}