using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lcompra
    {
        #region Campos
        private DateTime _capcfeccom;
        private decimal _capctotcom;
        private string _papccodcom;
        private string _capdfaccom;
        private string _faprcodpro;
        private bool _caprestpro;
        private string _caprnumcel;
        private string _paprcodpro;
        private string _caprnitpro;
        private string _caprsocpro;
        private string _faprcntpro;
        private string _caprdirpro;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public DateTime capcfeccom
        {
            get { return this._capcfeccom; }
            set { this._capcfeccom = value; }
        }
        public decimal capctotcom
        {
            get { return this._capctotcom; }
            set { this._capctotcom = value; }
        }
        public string papccodcom
        {
            get { return this._papccodcom; }
            set { this._papccodcom = value; }
        }
        public string capdfaccom
        {
            get { return this._capdfaccom; }
            set { this._capdfaccom = value; }
        }
        public string faprcodpro
        {
            get { return this._faprcodpro; }
            set { this._faprcodpro = value; }
        }
        public bool caprestpro
        {
            get { return this._caprestpro; }
            set { this._caprestpro = value; }
        }
        public string caprnumcel
        {
            get { return this._caprnumcel; }
            set { this._caprnumcel = value; }
        }
        public string paprcodpro
        {
            get { return this._paprcodpro; }
            set { this._paprcodpro = value; }
        }
        public string caprnitpro
        {
            get { return this._caprnitpro; }
            set { this._caprnitpro = value; }
        }
        public string caprsocpro
        {
            get { return this._caprsocpro; }
            set { this._caprsocpro = value; }
        }
        public string faprcntpro
        {
            get { return this._faprcntpro; }
            set { this._faprcntpro = value; }
        }
        public string caprdirpro
        {
            get { return this._caprdirpro; }
            set { this._caprdirpro = value; }
        }
        #endregion

        #region Constructor
        public lcompra()
        {
            this._capcfeccom = DateTime.Now;
            this._capctotcom = 0;
            this._papccodcom = "";
            this._capdfaccom = "";
            this._faprcodpro = "";
            this._caprestpro = true;
            this._caprnumcel = "";
            this._paprcodpro = "";
            this._caprnitpro = "";
            this._caprsocpro = "";
            this._faprcntpro = "";
            this._caprdirpro = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        
        public List<lcompra> Lista(string where)
        {
            List<lcompra> ListaResultado = new List<lcompra>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "capcfeccom," +
                                 "capctotcom," +
                                 "papccodcom," +
                                 "capdfaccom," +
                                 "faprcodpro," +
                                 "caprestpro," +
                                 "caprnumcel," +
                                 "paprcodpro," +
                                 "caprnitpro," +
                                 "caprsocpro," +
                                 "faprcntpro," +
                                 "caprdirpro " +
                         "from acompra, aproved " +
                         "where acompra.faprcodpro = aproved.paprcodpro ";

            if (where.Replace(" ", "") != "")
            {
                sql += "where " + where;
            }


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    lcompra Auxiliar = new lcompra();
                    Auxiliar.capcfeccom = ResultadoConsulta.GetDateTime(0);
                    Auxiliar.capctotcom = ResultadoConsulta.GetDecimal(1);
                    Auxiliar.papccodcom = ResultadoConsulta.GetString(2);
                    Auxiliar.capdfaccom = ResultadoConsulta.GetString(3);
                    Auxiliar.faprcodpro = ResultadoConsulta.GetString(4);
                    Auxiliar.caprestpro = ResultadoConsulta.GetBoolean(5);
                    Auxiliar.caprnumcel = ResultadoConsulta.GetString(6);
                    Auxiliar.paprcodpro = ResultadoConsulta.GetString(7);
                    Auxiliar.caprnitpro = ResultadoConsulta.GetString(8);
                    Auxiliar.caprsocpro = ResultadoConsulta.GetString(9);
                    Auxiliar.faprcntpro = ResultadoConsulta.GetString(10);
                    Auxiliar.caprdirpro = ResultadoConsulta.GetString(11);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion
    }
}
