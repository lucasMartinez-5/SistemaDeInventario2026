using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class adetventa {

		#region Campos
            private int _capwcandet;
            private decimal _capwpreven;
            private decimal _capwsubtot;
            private string _papwcoddet;
            private string _fapwcodven;
            private string _fapwcodpro;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public int capwcandet
            { 
                get{ return this._capwcandet;}
                set{ this._capwcandet = value;}
            } 
		    public decimal capwpreven
            { 
                get{ return this._capwpreven;}
                set{ this._capwpreven = value;}
            } 
		    public decimal capwsubtot
            { 
                get{ return this._capwsubtot;}
                set{ this._capwsubtot = value;}
            } 
		    public string papwcoddet
            { 
                get{ return this._papwcoddet;}
                set{ this._papwcoddet = value;}
            } 
		    public string fapwcodven
            { 
                get{ return this._fapwcodven;}
                set{ this._fapwcodven = value;}
            } 
		    public string fapwcodpro
            { 
                get{ return this._fapwcodpro;}
                set{ this._fapwcodpro = value;}
            } 
        #endregion

        #region Constructor
            public adetventa()
            { 
		        this._capwcandet = 0;
		        this._capwpreven = 0;
		        this._capwsubtot = 0;
		        this._papwcoddet = "";
		        this._fapwcodven = "";
		        this._fapwcodpro = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capwcandet," +
                                     "capwpreven," +
                                     "capwsubtot," +
                                     "papwcoddet," +
                                     "fapwcodven," +
                                     "fapwcodpro " + 
                             "from adetventa " +
                             "where "+
                                    "papwcoddet = @papwcoddet";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papwcoddet",this._papwcoddet);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capwcandet=ResultadoConsulta.GetInt32(0);
                    this._capwpreven=ResultadoConsulta.GetDecimal(1);
                    this._capwsubtot=ResultadoConsulta.GetDecimal(2);
                    this._papwcoddet=ResultadoConsulta.GetString(3);
                    this._fapwcodven=ResultadoConsulta.GetString(4);
                    this._fapwcodpro=ResultadoConsulta.GetString(5);
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
                                     "capwcandet," +
                                     "capwpreven," +
                                     "capwsubtot," +
                                     "papwcoddet," +
                                     "fapwcodven," +
                                     "fapwcodpro " + 
                             "from adetventa " +
                             "where " +
                                    "papwcoddet = @papwcoddet";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papwcoddet",this._papwcoddet);

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
			        string sql = "insert into adetventa (" +
                                                       "capwcandet," +
                                                       "capwpreven," +
                                                       "capwsubtot," +
                                                       "papwcoddet," +
                                                       "fapwcodven," +
                                                       "fapwcodpro" +
                                                       ") " +
	                             "values (" + 
                                          "@capwcandet," +
                                          "@capwpreven," +
                                          "@capwsubtot," +
                                          "@papwcoddet," +
                                          "@fapwcodven," +
                                          "@fapwcodpro" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroEntero("@capwcandet",this._capwcandet);
                    this.Conexion.AsignarParametroDecimal("@capwpreven",this._capwpreven);
                    this.Conexion.AsignarParametroDecimal("@capwsubtot",this._capwsubtot);
                    this.Conexion.AsignarParametroCadena("@papwcoddet",this._papwcoddet);
                    this.Conexion.AsignarParametroCadena("@fapwcodven",this._fapwcodven);
                    this.Conexion.AsignarParametroCadena("@fapwcodpro",this._fapwcodpro);

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
			        string sql = "update adetventa set " +
                                                     "capwcandet = @capwcandet, " +
                                                     "capwpreven = @capwpreven, " +
                                                     "capwsubtot = @capwsubtot, " +
                                                     "fapwcodven = @fapwcodven, " +
                                                     "fapwcodpro = @fapwcodpro" +
                                 " where " +
                                        "papwcoddet = @papwcoddet";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroEntero("@capwcandet",this._capwcandet);
                    this.Conexion.AsignarParametroDecimal("@capwpreven",this._capwpreven);
                    this.Conexion.AsignarParametroDecimal("@capwsubtot",this._capwsubtot);
                    this.Conexion.AsignarParametroCadena("@papwcoddet",this._papwcoddet);
                    this.Conexion.AsignarParametroCadena("@fapwcodven",this._fapwcodven);
                    this.Conexion.AsignarParametroCadena("@fapwcodpro",this._fapwcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<adetventa> Lista(string where)
            { 
                List<adetventa> ListaResultado = new List<adetventa>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capwcandet," +
                                     "capwpreven," +
                                     "capwsubtot," +
                                     "papwcoddet," +
                                     "fapwcodven," +
                                     "fapwcodpro " + 
                             "from adetventa " ;
 
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
                          adetventa Auxiliar = new adetventa();
                          Auxiliar.capwcandet = ResultadoConsulta.GetInt32(0);
                          Auxiliar.capwpreven = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.capwsubtot = ResultadoConsulta.GetDecimal(2);
                          Auxiliar.papwcoddet = ResultadoConsulta.GetString(3);
                          Auxiliar.fapwcodven = ResultadoConsulta.GetString(4);
                          Auxiliar.fapwcodpro = ResultadoConsulta.GetString(5);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

