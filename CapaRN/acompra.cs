using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class acompra {

		#region Campos
            private DateTime _capcfeccom;
            private decimal _capctotcom;
            private string _papccodcom;
            private string _capdfaccom;
            private string _faprcodpro;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public DateTime capcfeccom
            { 
                get{ return this._capcfeccom;}
                set{ this._capcfeccom = value;}
            } 
		    public decimal capctotcom
            { 
                get{ return this._capctotcom;}
                set{ this._capctotcom = value;}
            } 
		    public string papccodcom
            { 
                get{ return this._papccodcom;}
                set{ this._papccodcom = value;}
            } 
		    public string capdfaccom
            { 
                get{ return this._capdfaccom;}
                set{ this._capdfaccom = value;}
            } 
		    public string faprcodpro
            { 
                get{ return this._faprcodpro;}
                set{ this._faprcodpro = value;}
            } 
        #endregion

        #region Constructor
            public acompra()
            { 
		        this._capcfeccom = DateTime.Now;
		        this._capctotcom = 0;
		        this._papccodcom = "";
		        this._capdfaccom = "";
		        this._faprcodpro = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capcfeccom," +
                                     "capctotcom," +
                                     "papccodcom," +
                                     "capdfaccom," +
                                     "faprcodpro " + 
                             "from acompra " +
                             "where "+
                                    "papccodcom = @papccodcom";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papccodcom",this._papccodcom);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capcfeccom=ResultadoConsulta.GetDateTime(0);
                    this._capctotcom=ResultadoConsulta.GetDecimal(1);
                    this._papccodcom=ResultadoConsulta.GetString(2);
                    this._capdfaccom=ResultadoConsulta.GetString(3);
                    this._faprcodpro=ResultadoConsulta.GetString(4);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool VerificarExistencia()
            { 
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capcfeccom," +
                                     "capctotcom," +
                                     "papccodcom," +
                                     "capdfaccom," +
                                     "faprcodpro " + 
                             "from acompra " +
                             "where " +
                                    "papccodcom = @papccodcom";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papccodcom",this._papccodcom);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.HasRows)
                {
                this.Conexion.Desconectar();

                    return true;
                }
                else 
                { 

                this.Conexion.Desconectar();
                    return false;
                } 
            } 
            public bool Grabar()
            { 
                if (this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "insert into acompra (" +
                                                       "capcfeccom," +
                                                       "capctotcom," +
                                                       "papccodcom," +
                                                       "capdfaccom," +
                                                       "faprcodpro" +
                                                       ") " +
	                             "values (" + 
                                          "@capcfeccom," +
                                          "@capctotcom," +
                                          "@papccodcom," +
                                          "@capdfaccom," +
                                          "@faprcodpro" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroFechaHora("@capcfeccom",this._capcfeccom);
                    this.Conexion.AsignarParametroDecimal("@capctotcom",this._capctotcom);
                    this.Conexion.AsignarParametroCadena("@papccodcom",this._papccodcom);
                    this.Conexion.AsignarParametroCadena("@capdfaccom",this._capdfaccom);
                    this.Conexion.AsignarParametroCadena("@faprcodpro",this._faprcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            } 
            public bool Modificar()
            { 
                if (!this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "update acompra set " +
                                                     "capcfeccom = @capcfeccom, " +
                                                     "capctotcom = @capctotcom, " +
                                                     "capdfaccom = @capdfaccom, " +
                                                     "faprcodpro = @faprcodpro" +
                                 " where " +
                                        "papccodcom = @papccodcom";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroFechaHora("@capcfeccom",this._capcfeccom);
                    this.Conexion.AsignarParametroDecimal("@capctotcom",this._capctotcom);
                    this.Conexion.AsignarParametroCadena("@papccodcom",this._papccodcom);
                    this.Conexion.AsignarParametroCadena("@capdfaccom",this._capdfaccom);
                    this.Conexion.AsignarParametroCadena("@faprcodpro",this._faprcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<acompra> Lista(string where)
            { 
                List<acompra> ListaResultado = new List<acompra>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capcfeccom," +
                                     "capctotcom," +
                                     "papccodcom," +
                                     "capdfaccom," +
                                     "faprcodpro " + 
                             "from acompra " ;
 
                if (where.Replace(" ", "") != "")
                {
                    sql+= "where " + where;
                }

 
                this.Conexion.PrepararComando(sql); 
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta!=null)
                {
                    while (ResultadoConsulta.Read())
                    {
                          acompra Auxiliar = new acompra();
                          Auxiliar.capcfeccom = ResultadoConsulta.GetDateTime(0);
                          Auxiliar.capctotcom = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.papccodcom = ResultadoConsulta.GetString(2);
                          Auxiliar.capdfaccom = ResultadoConsulta.GetString(3);
                          Auxiliar.faprcodpro = ResultadoConsulta.GetString(4);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

