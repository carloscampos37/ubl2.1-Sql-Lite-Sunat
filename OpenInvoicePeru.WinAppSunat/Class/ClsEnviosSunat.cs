﻿using System;
using System.Data;
using OpenInvoicePeru.Class;

namespace OpenInvoicePeru.Class
{
    public class ClsEnviosSunat
 
      {
      public ClsFunciones ModFunc =new ClsFunciones() ;

        public string CadenaDatos(string Tipo, string vEmpresa, string vFecha, string vGrupo)
        {
            string vSql = "";
            switch (Tipo)
            {
                case "":
                    vSql = " SELECT a.empresaID, a.EstablecimientoID,Fechadocumento,a.SerieDocumento,a.DocumentoID, b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01'),AnexoSunat ";
                    vSql += " FROM dbo.FEDocumentosElectronicosCab a ";
                    vSql += "  INNER join FEDocumentosElectronicosDet b ON a.ID = b.DocumentosElectronicosCabID ";
                    vSql += "  INNER join FeEstablecimientos c ON a.EstablecimientoID = c.ID ";
                    vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                               vSql += " AND a.DocumentoID = '" + vGrupo + "' And ResumenSunat=0 ";
                    break;

                case "RC":
                           vSql = " SELECT  Item=IdentificadorEnvio+1,EstablecimientoID,a.seriedocumento,a.documentoID,Fechadocumento,grupo=isnull(b.GrupodeEnvioSunat,0), b.*,Letras=[dbo].fn_NumeroEnLetra(b.TotalImporteVenta,'01') ";
                           vSql += " FROM dbo.FEDocumentosElectronicosCab a ";
                            vSql += " INNER JOIN dbo.FEDocumentosElectronicosDet b ON a.ID = b.DocumentosElectronicosCabID  ";
                           vSql += "  INNER join FeEstablecimientos c ON a.EstablecimientoID = c.ID ";
                            vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                            vSql += " AND isnull(b.GrupodeEnvioSunat,0)=" + vGrupo + "  ";
                            vSql += " And ResumenSunat=1 ";

                    break;

                case "RA":

                    vSql = " SELECT Item=IdentificadorEnvio+1,Establecimiento_id,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01') ";
                    vSql += " FROM dbo.FEComunicacionBajaCab  a ";
                    vSql += "  INNER join FEComunicacionBajaDet b ON a.empresacodigo = b.empresacodigo ";
                    vSql += " AND a.id = b.ComunicacionBajaid ";
                    vSql += " WHERE a.Empresacodigo='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0   ";
                    vSql += " AND b.GrupodeEnvioSunat=" + vGrupo + " Order by Establecimientoid ";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimientoid ";

                    break;
            }
            vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by a.EstablecimientoID  ";
            return vSql;

        }

        public string CadenaDatosWeb(string Tipo, string vEmpresa, string vFecha, string vGrupo)
        {
            string vSql = "";
            switch (Tipo)
            {
                case "":
                    vSql = " SELECT a.empresaID, a.EstablecimientoID,Fechadocumento,b.SerieDocumento,b.DocumentoID, b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01'),AnexoSunat ";
                    vSql += " FROM dbo.FE_DocumentosElectronicosCab a ";
                    vSql += "  INNER join FE_DocumentosElectronicosDet b ON a.ID = b.DocumentosElectronicosCabID ";
                    vSql += "  INNER join Fe_Establecimientos c ON a.EstablecimientoID = c.ID ";
                    vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'" ;
        
                    break;

                case "RC":

                    vSql = " SELECT  Item=IdentificadorEnvio+1,EstablecimientoID,c.seriedocumento,c.documentoID,Fechadocumento,grupo=isnull(b.GrupodeEnvioSunat,0), c.*,Letras=[dbo].fn_NumeroEnLetra(c.TotalImporteVenta,'01') ";
                    vSql += " FROM dbo.FE_ResumenDiarioDocumentosCab a ";
                    vSql += " INNER JOIN dbo.FE_ResumenDiarioDocumentosDet b ON a.ID = b.ResumenDiarioCabID  ";
                    vSql += " INNER JOIN dbo.FE_ResumenDiarioDocumentosDetItem c ON b.ID = c.ResumenDiarioDetID  ";
                    vSql += "  INNER join Fe_Establecimientos d ON a.EstablecimientoID = d.ID ";
                    vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                    vSql += " AND isnull(b.GrupodeEnvioSunat,0)=" + vGrupo + "" ;
                    break;

                case "RA":

                    vSql = " SELECT Item=IdentificadorEnvio+1,Establecimiento_id,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01') ";
                    vSql += " FROM dbo.FE_ComunicacionBajaCab  a ";
                    vSql += "  INNER join FE_ComunicacionBajaDet b ON a.empresacodigo = b.empresacodigo ";
                    vSql += " AND a.ComunicacionBaja_id = b.ComunicacionBaja_id ";
                    vSql += " WHERE a.Empresacodigo='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0   ";
                    vSql += " AND b.GrupodeEnvioSunat=" + vGrupo + " Order by Establecimiento_id ";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimiento_id ";

                    break;
            }
            vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by a.EstablecimientoID  ";
            return vSql;
        }

        public string CadenaDatosGuadalupe(string Tipo, string vEmpresa, string vFecha, string vGrupo)
        {
            string vSql = "";
            switch (Tipo)
            {
                case "":
                    vSql = " SELECT a.empresaID, a.EstablecimientoID,Fechadocumento,b.SerieDocumento,b.DocumentoID, b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01'),AnexoSunat ";
                    vSql += " FROM dbo.FEDocumentosElectronicosCab a ";
                    vSql += "  INNER join FEDocumentosElectronicosDet b ON a.ID = b.DocumentosElectronicosCabID ";
                    vSql += "  INNER join FeEstablecimientos c ON a.EstablecimientoID = c.ID ";
                    vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";

                    break;

                case "RC":

                    vSql = " SELECT  Item=IdentificadorEnvio+1,EstablecimientoID,c.seriedocumento,c.documentoID,Fechadocumento,grupo=isnull(b.GrupodeEnvioSunat,0), c.*,Letras=[dbo].fn_NumeroEnLetra(c.TotalImporteVenta,'01') ";
                    vSql += " FROM dbo.FeResumenDiarioDocumentosCab a ";
                    vSql += " INNER JOIN dbo.FeResumenDiarioDocumentosDet b ON a.ID = b.ResumenDiarioCabID  ";
                    vSql += " INNER JOIN dbo.FeResumenDiarioDocumentosDetItem c ON b.ID = c.ResumenDiarioDetID  ";
                    vSql += "  INNER join FeEstablecimientos d ON a.EstablecimientoID = d.ID ";
                    vSql += " WHERE a.EmpresaID='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                    vSql += " AND isnull(b.GrupodeEnvioSunat,0)=" + vGrupo + "";
                    break;

                case "RA":

                    vSql = " SELECT Item=IdentificadorEnvio+1,Establecimiento_id,Fechadocumento,b.*,Letras=[dbo].fn_NumeroEnLetra(TotalImporteVenta,'01') ";
                    vSql += " FROM dbo.FE_ComunicacionBajaCab  a ";
                    vSql += "  INNER join FE_ComunicacionBajaDet b ON a.empresacodigo = b.empresacodigo ";
                    vSql += " AND a.ComunicacionBaja_id = b.ComunicacionBaja_id ";
                    vSql += " WHERE a.Empresacodigo='" + vEmpresa + "' AND fechadocumento = '" + vFecha + "'";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0   ";
                    vSql += " AND b.GrupodeEnvioSunat=" + vGrupo + " Order by Establecimiento_id ";
                    vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by Establecimiento_id ";

                    break;
            }
            vSql += " AND a.EstadoAnulado=0 AND b.EstadoAnulado=0 Order by a.EstablecimientoID  ";
            return vSql;
        }



        public string CrearDirectorios(DataTable Dtempresa,string vEmpresa , DateTime vFecha)
        {
            string vDirectorio1 ;
            string vDirectorio2 ;

            // Creacion de directorio empresa
            vDirectorio1 = Convert.ToString(Dtempresa.Rows[0]["CarpetaEnviosXml"]);
            vDirectorio2 = vEmpresa;
            vDirectorio1 = ModFunc.CreacionDirectorio(vDirectorio1, vDirectorio2);

            // Creacion de directorio de facturas electronicas

            // Creacion de directorio año
             vDirectorio2 = Convert.ToString(vFecha.Date.Year );
            vDirectorio1 = ModFunc.CreacionDirectorio(vDirectorio1, vDirectorio2);

            // Creacion de directorio mes

            vDirectorio2 = ModFunc.DesMes(ModFunc.Derecha("0" + Convert.ToString(vFecha.Date.Month ), 2));
            return ModFunc.CreacionDirectorio(vDirectorio1, vDirectorio2);
  
          }

    }
}
