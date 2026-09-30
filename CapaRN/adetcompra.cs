using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class adetcompra {

		#region Campos
            private int _capdcandet;
            private decimal _capdprecom;
            private decimal _capdsubtot;
            private string _papdcoddet;
            private string _fapdcodcom;
            private string _fapdcodpro;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public int capdcandet
            { 
                get{ return this._capdcandet;}
                set{ this._capdcandet = value;}
            } 
		    public decimal capdprecom
            { 
                get{ return this._capdprecom;}
                set{ this._capdprecom = value;}
            } 
		    public decimal capdsubtot
            { 
                get{ return this._capdsubtot;}
                set{ this._capdsubtot = value;}
            } 
		    public string papdcoddet
            { 
                get{ return this._papdcoddet;}
                set{ this._papdcoddet = value;}
            } 
		    public string fapdcodcom
            { 
                get{ return this._fapdcodcom;}
                set{ this._fapdcodcom = value;}
            } 
		    public string fapdcodpro
            { 
                get{ return this._fapdcodpro;}
                set{ this._fapdcodpro = value;}
            } 
        #endregion

        #region Constructor
            public adetcompra()
            { 
		        this._capdcandet = 0;
		        this._capdprecom = 0;
		        this._capdsubtot = 0;
		        this._papdcoddet = "";
		        this._fapdcodcom = "";
		        this._fapdcodpro = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capdcandet," +
                                     "capdprecom," +
                                     "capdsubtot," +
                                     "papdcoddet," +
                                     "fapdcodcom," +
                                     "fapdcodpro " + 
                             "from adetcompra " +
                             "where "+
                                    "papdcoddet = @papdcoddet";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papdcoddet",this._papdcoddet);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capdcandet=ResultadoConsulta.GetInt32(0);
                    this._capdprecom=ResultadoConsulta.GetDecimal(1);
                    this._capdsubtot=ResultadoConsulta.GetDecimal(2);
                    this._papdcoddet=ResultadoConsulta.GetString(3);
                    this._fapdcodcom=ResultadoConsulta.GetString(4);
                    this._fapdcodpro=ResultadoConsulta.GetString(5);
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
                                     "capdcandet," +
                                     "capdprecom," +
                                     "capdsubtot," +
                                     "papdcoddet," +
                                     "fapdcodcom," +
                                     "fapdcodpro " + 
                             "from adetcompra " +
                             "where " +
                                    "papdcoddet = @papdcoddet";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papdcoddet",this._papdcoddet);

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
			        string sql = "insert into adetcompra (" +
                                                       "capdcandet," +
                                                       "capdprecom," +
                                                       "capdsubtot," +
                                                       "papdcoddet," +
                                                       "fapdcodcom," +
                                                       "fapdcodpro" +
                                                       ") " +
	                             "values (" + 
                                          "@capdcandet," +
                                          "@capdprecom," +
                                          "@capdsubtot," +
                                          "@papdcoddet," +
                                          "@fapdcodcom," +
                                          "@fapdcodpro" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroEntero("@capdcandet",this._capdcandet);
                    this.Conexion.AsignarParametroDecimal("@capdprecom",this._capdprecom);
                    this.Conexion.AsignarParametroDecimal("@capdsubtot",this._capdsubtot);
                    this.Conexion.AsignarParametroCadena("@papdcoddet",this._papdcoddet);
                    this.Conexion.AsignarParametroCadena("@fapdcodcom",this._fapdcodcom);
                    this.Conexion.AsignarParametroCadena("@fapdcodpro",this._fapdcodpro);

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
			        string sql = "update adetcompra set " +
                                                     "capdcandet = @capdcandet, " +
                                                     "capdprecom = @capdprecom, " +
                                                     "capdsubtot = @capdsubtot, " +
                                                     "fapdcodcom = @fapdcodcom, " +
                                                     "fapdcodpro = @fapdcodpro" +
                                 " where " +
                                        "papdcoddet = @papdcoddet";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroEntero("@capdcandet",this._capdcandet);
                    this.Conexion.AsignarParametroDecimal("@capdprecom",this._capdprecom);
                    this.Conexion.AsignarParametroDecimal("@capdsubtot",this._capdsubtot);
                    this.Conexion.AsignarParametroCadena("@papdcoddet",this._papdcoddet);
                    this.Conexion.AsignarParametroCadena("@fapdcodcom",this._fapdcodcom);
                    this.Conexion.AsignarParametroCadena("@fapdcodpro",this._fapdcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<adetcompra> Lista(string where)
            { 
                List<adetcompra> ListaResultado = new List<adetcompra>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capdcandet," +
                                     "capdprecom," +
                                     "capdsubtot," +
                                     "papdcoddet," +
                                     "fapdcodcom," +
                                     "fapdcodpro " + 
                             "from adetcompra " ;
 
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
                          adetcompra Auxiliar = new adetcompra();
                          Auxiliar.capdcandet = ResultadoConsulta.GetInt32(0);
                          Auxiliar.capdprecom = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.capdsubtot = ResultadoConsulta.GetDecimal(2);
                          Auxiliar.papdcoddet = ResultadoConsulta.GetString(3);
                          Auxiliar.fapdcodcom = ResultadoConsulta.GetString(4);
                          Auxiliar.fapdcodpro = ResultadoConsulta.GetString(5);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

