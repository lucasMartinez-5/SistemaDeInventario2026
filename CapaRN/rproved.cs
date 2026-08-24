using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class rproved {

		#region Campos
            private bool _crprsexpro;
            private bool _crprestpro;
            private string _crprapepat;
            private string _crprapemat;
            private string _crprnompro;
            private string _crprnumcel;
            private string _crprcorele;
            private string _crprdirpro;
            private string _prprcodpro;
            private string _crprfotpro;
            private string _crprnumcid;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool crprsexpro
            { 
                get{ return this._crprsexpro;}
                set{ this._crprsexpro = value;}
            } 
		    public bool crprestpro
            { 
                get{ return this._crprestpro;}
                set{ this._crprestpro = value;}
            } 
		    public string crprapepat
            { 
                get{ return this._crprapepat;}
                set{ this._crprapepat = value;}
            } 
		    public string crprapemat
            { 
                get{ return this._crprapemat;}
                set{ this._crprapemat = value;}
            } 
		    public string crprnompro
            { 
                get{ return this._crprnompro;}
                set{ this._crprnompro = value;}
            } 
		    public string crprnumcel
            { 
                get{ return this._crprnumcel;}
                set{ this._crprnumcel = value;}
            } 
		    public string crprcorele
            { 
                get{ return this._crprcorele;}
                set{ this._crprcorele = value;}
            } 
		    public string crprdirpro
            { 
                get{ return this._crprdirpro;}
                set{ this._crprdirpro = value;}
            } 
		    public string prprcodpro
            { 
                get{ return this._prprcodpro;}
                set{ this._prprcodpro = value;}
            } 
		    public string crprfotpro
            { 
                get{ return this._crprfotpro;}
                set{ this._crprfotpro = value;}
            } 
		    public string crprnumcid
            { 
                get{ return this._crprnumcid;}
                set{ this._crprnumcid = value;}
            } 
        #endregion

        #region Constructor
            public rproved()
            { 
		        this._crprsexpro = true;
		        this._crprestpro = true;
		        this._crprapepat = "";
		        this._crprapemat = "";
		        this._crprnompro = "";
		        this._crprnumcel = "";
		        this._crprcorele = "";
		        this._crprdirpro = "";
		        this._prprcodpro = "";
		        this._crprfotpro = "";
		        this._crprnumcid = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "crprsexpro," +
                                     "crprestpro," +
                                     "crprapepat," +
                                     "crprapemat," +
                                     "crprnompro," +
                                     "crprnumcel," +
                                     "crprcorele," +
                                     "crprdirpro," +
                                     "prprcodpro," +
                                     "crprfotpro," +
                                     "crprnumcid " + 
                             "from rproved " +
                             "where "+
                                    "prprcodpro = @prprcodpro";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@prprcodpro",this._prprcodpro);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._crprsexpro=ResultadoConsulta.GetBoolean(0);
                    this._crprestpro=ResultadoConsulta.GetBoolean(1);
                    this._crprapepat=ResultadoConsulta.GetString(2);
                    this._crprapemat=ResultadoConsulta.GetString(3);
                    this._crprnompro=ResultadoConsulta.GetString(4);
                    this._crprnumcel=ResultadoConsulta.GetString(5);
                    this._crprcorele=ResultadoConsulta.GetString(6);
                    this._crprdirpro=ResultadoConsulta.GetString(7);
                    this._prprcodpro=ResultadoConsulta.GetString(8);
                    this._crprfotpro=ResultadoConsulta.GetString(9);
                    this._crprnumcid=ResultadoConsulta.GetString(10);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }

            public bool ObtenerDatosCI(bool modificar, string ci)
                {
                this.Conexion.Conectar();
                string sql = "select " +
                                     "crprsexpro," +
                                     "crprestpro," +
                                     "crprapepat," +
                                     "crprapemat," +
                                     "crprnompro," +
                                     "crprnumcel," +
                                     "crprcorele," +
                                     "crprdirpro," +
                                     "prprcodpro," +
                                     "crprfotpro," +
                                     "crprnumcid " +
                             "from rproved " +
                             "where " +
                                    "crprnumcid = @crprnumcid";

                if (modificar)
                {
                    sql += " and crprnumcid!='" + ci + "'";
                }

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@crprnumcid", this._crprnumcid);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                this._crprsexpro = ResultadoConsulta.GetBoolean(0);
                this._crprestpro = ResultadoConsulta.GetBoolean(1);
                this._crprapepat = ResultadoConsulta.GetString(2);
                this._crprapemat = ResultadoConsulta.GetString(3);
                this._crprnompro = ResultadoConsulta.GetString(4);
                this._crprnumcel = ResultadoConsulta.GetString(5);
                this._crprcorele = ResultadoConsulta.GetString(6);
                this._crprdirpro = ResultadoConsulta.GetString(7);
                this._prprcodpro = ResultadoConsulta.GetString(8);
                this._crprfotpro = ResultadoConsulta.GetString(9);
                this._crprnumcid = ResultadoConsulta.GetString(10);
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
                                     "crprsexpro," +
                                     "crprestpro," +
                                     "crprapepat," +
                                     "crprapemat," +
                                     "crprnompro," +
                                     "crprnumcel," +
                                     "crprcorele," +
                                     "crprdirpro," +
                                     "prprcodpro," +
                                     "crprfotpro," +
                                     "crprnumcid " + 
                             "from rproved " +
                             "where " +
                                    "prprcodpro = @prprcodpro";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@prprcodpro",this._prprcodpro);

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
			        string sql = "insert into rproved (" +
                                                       "crprsexpro," +
                                                       "crprestpro," +
                                                       "crprapepat," +
                                                       "crprapemat," +
                                                       "crprnompro," +
                                                       "crprnumcel," +
                                                       "crprcorele," +
                                                       "crprdirpro," +
                                                       "prprcodpro," +
                                                       "crprfotpro," +
                                                       "crprnumcid" +
                                                       ") " +
	                             "values (" + 
                                          "@crprsexpro," +
                                          "@crprestpro," +
                                          "@crprapepat," +
                                          "@crprapemat," +
                                          "@crprnompro," +
                                          "@crprnumcel," +
                                          "@crprcorele," +
                                          "@crprdirpro," +
                                          "@prprcodpro," +
                                          "@crprfotpro," +
                                          "@crprnumcid" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@crprsexpro",this._crprsexpro);
                    this.Conexion.AsignarParametroLogico("@crprestpro",this._crprestpro);
                    this.Conexion.AsignarParametroCadena("@crprapepat",this._crprapepat);
                    this.Conexion.AsignarParametroCadena("@crprapemat",this._crprapemat);
                    this.Conexion.AsignarParametroCadena("@crprnompro",this._crprnompro);
                    this.Conexion.AsignarParametroCadena("@crprnumcel",this._crprnumcel);
                    this.Conexion.AsignarParametroCadena("@crprcorele",this._crprcorele);
                    this.Conexion.AsignarParametroCadena("@crprdirpro",this._crprdirpro);
                    this.Conexion.AsignarParametroCadena("@prprcodpro",this._prprcodpro);
                    this.Conexion.AsignarParametroCadena("@crprfotpro",this._crprfotpro);
                    this.Conexion.AsignarParametroCadena("@crprnumcid",this._crprnumcid);

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
			        string sql = "update rproved set " +
                                                     "crprsexpro = @crprsexpro, " +
                                                     "crprestpro = @crprestpro, " +
                                                     "crprapepat = @crprapepat, " +
                                                     "crprapemat = @crprapemat, " +
                                                     "crprnompro = @crprnompro, " +
                                                     "crprnumcel = @crprnumcel, " +
                                                     "crprcorele = @crprcorele, " +
                                                     "crprdirpro = @crprdirpro, " +
                                                     "crprfotpro = @crprfotpro, " +
                                                     "crprnumcid = @crprnumcid" +
                                 " where " +
                                        "prprcodpro = @prprcodpro";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@crprsexpro",this._crprsexpro);
                    this.Conexion.AsignarParametroLogico("@crprestpro",this._crprestpro);
                    this.Conexion.AsignarParametroCadena("@crprapepat",this._crprapepat);
                    this.Conexion.AsignarParametroCadena("@crprapemat",this._crprapemat);
                    this.Conexion.AsignarParametroCadena("@crprnompro",this._crprnompro);
                    this.Conexion.AsignarParametroCadena("@crprnumcel",this._crprnumcel);
                    this.Conexion.AsignarParametroCadena("@crprcorele",this._crprcorele);
                    this.Conexion.AsignarParametroCadena("@crprdirpro",this._crprdirpro);
                    this.Conexion.AsignarParametroCadena("@prprcodpro",this._prprcodpro);
                    this.Conexion.AsignarParametroCadena("@crprfotpro",this._crprfotpro);
                    this.Conexion.AsignarParametroCadena("@crprnumcid",this._crprnumcid);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<rproved> Lista(string where)
            { 
                List<rproved> ListaResultado = new List<rproved>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "crprsexpro," +
                                     "crprestpro," +
                                     "crprapepat," +
                                     "crprapemat," +
                                     "crprnompro," +
                                     "crprnumcel," +
                                     "crprcorele," +
                                     "crprdirpro," +
                                     "prprcodpro," +
                                     "crprfotpro," +
                                     "crprnumcid " + 
                             "from rproved " ;
 
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
                          rproved Auxiliar = new rproved();
                          Auxiliar.crprsexpro = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.crprestpro = ResultadoConsulta.GetBoolean(1);
                          Auxiliar.crprapepat = ResultadoConsulta.GetString(2);
                          Auxiliar.crprapemat = ResultadoConsulta.GetString(3);
                          Auxiliar.crprnompro = ResultadoConsulta.GetString(4);
                          Auxiliar.crprnumcel = ResultadoConsulta.GetString(5);
                          Auxiliar.crprcorele = ResultadoConsulta.GetString(6);
                          Auxiliar.crprdirpro = ResultadoConsulta.GetString(7);
                          Auxiliar.prprcodpro = ResultadoConsulta.GetString(8);
                          Auxiliar.crprfotpro = ResultadoConsulta.GetString(9);
                          Auxiliar.crprnumcid = ResultadoConsulta.GetString(10);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

