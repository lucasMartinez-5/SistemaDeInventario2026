using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aventa {

		#region Campos
            private DateTime _capvfecven;
            private decimal _capvtotven;
            private string _papvcodven;
            private string _capvobsven;
            private string _fapvcodusu;
            private string _fapvcodcli;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public DateTime capvfecven
            { 
                get{ return this._capvfecven;}
                set{ this._capvfecven = value;}
            } 
		    public decimal capvtotven
            { 
                get{ return this._capvtotven;}
                set{ this._capvtotven = value;}
            } 
		    public string papvcodven
            { 
                get{ return this._papvcodven;}
                set{ this._papvcodven = value;}
            } 
		    public string capvobsven
            { 
                get{ return this._capvobsven;}
                set{ this._capvobsven = value;}
            } 
		    public string fapvcodusu
            { 
                get{ return this._fapvcodusu;}
                set{ this._fapvcodusu = value;}
            } 
		    public string fapvcodcli
            { 
                get{ return this._fapvcodcli;}
                set{ this._fapvcodcli = value;}
            } 
        #endregion

        #region Constructor
            public aventa()
            { 
		        this._capvfecven = DateTime.Now;
		        this._capvtotven = 0;
		        this._papvcodven = "";
		        this._capvobsven = "";
		        this._fapvcodusu = "";
		        this._fapvcodcli = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capvfecven," +
                                     "capvtotven," +
                                     "papvcodven," +
                                     "capvobsven," +
                                     "fapvcodusu," +
                                     "fapvcodcli " + 
                             "from aventa " +
                             "where "+
                                    "papvcodven = @papvcodven";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papvcodven",this._papvcodven);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capvfecven=ResultadoConsulta.GetDateTime(0);
                    this._capvtotven=ResultadoConsulta.GetDecimal(1);
                    this._papvcodven=ResultadoConsulta.GetString(2);
                    this._capvobsven=ResultadoConsulta.GetString(3);
                    this._fapvcodusu=ResultadoConsulta.GetString(4);
                    this._fapvcodcli=ResultadoConsulta.GetString(5);
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
                                     "capvfecven," +
                                     "capvtotven," +
                                     "papvcodven," +
                                     "capvobsven," +
                                     "fapvcodusu," +
                                     "fapvcodcli " + 
                             "from aventa " +
                             "where " +
                                    "papvcodven = @papvcodven";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papvcodven",this._papvcodven);

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
			        string sql = "insert into aventa (" +
                                                       "capvfecven," +
                                                       "capvtotven," +
                                                       "papvcodven," +
                                                       "capvobsven," +
                                                       "fapvcodusu," +
                                                       "fapvcodcli" +
                                                       ") " +
	                             "values (" + 
                                          "@capvfecven," +
                                          "@capvtotven," +
                                          "@papvcodven," +
                                          "@capvobsven," +
                                          "@fapvcodusu," +
                                          "@fapvcodcli" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroFechaHora("@capvfecven",this._capvfecven);
                    this.Conexion.AsignarParametroDecimal("@capvtotven",this._capvtotven);
                    this.Conexion.AsignarParametroCadena("@papvcodven",this._papvcodven);
                    this.Conexion.AsignarParametroCadena("@capvobsven",this._capvobsven);
                    this.Conexion.AsignarParametroCadena("@fapvcodusu",this._fapvcodusu);
                    this.Conexion.AsignarParametroCadena("@fapvcodcli",this._fapvcodcli);

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
			        string sql = "update aventa set " +
                                                     "capvfecven = @capvfecven, " +
                                                     "capvtotven = @capvtotven, " +
                                                     "capvobsven = @capvobsven, " +
                                                     "fapvcodusu = @fapvcodusu, " +
                                                     "fapvcodcli = @fapvcodcli" +
                                 " where " +
                                        "papvcodven = @papvcodven";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroFechaHora("@capvfecven",this._capvfecven);
                    this.Conexion.AsignarParametroDecimal("@capvtotven",this._capvtotven);
                    this.Conexion.AsignarParametroCadena("@papvcodven",this._papvcodven);
                    this.Conexion.AsignarParametroCadena("@capvobsven",this._capvobsven);
                    this.Conexion.AsignarParametroCadena("@fapvcodusu",this._fapvcodusu);
                    this.Conexion.AsignarParametroCadena("@fapvcodcli",this._fapvcodcli);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aventa> Lista(string where)
            { 
                List<aventa> ListaResultado = new List<aventa>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capvfecven," +
                                     "capvtotven," +
                                     "papvcodven," +
                                     "capvobsven," +
                                     "fapvcodusu," +
                                     "fapvcodcli " + 
                             "from aventa " ;
 
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
                          aventa Auxiliar = new aventa();
                          Auxiliar.capvfecven = ResultadoConsulta.GetDateTime(0);
                          Auxiliar.capvtotven = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.papvcodven = ResultadoConsulta.GetString(2);
                          Auxiliar.capvobsven = ResultadoConsulta.GetString(3);
                          Auxiliar.fapvcodusu = ResultadoConsulta.GetString(4);
                          Auxiliar.fapvcodcli = ResultadoConsulta.GetString(5);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

