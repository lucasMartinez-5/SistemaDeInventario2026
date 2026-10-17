using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lventa
    {
        #region Campos
        private DateTime _capvfecven;
        private decimal _capvtotven;
        private string _papvcodven;
        private string _capvobsven;
        private string _fapvcodusu;
        private string _fapvcodcli;
        private bool _caclestcli;
        private string _caclnumcel;
        private string _paclcodcli;
        private string _caclnitcli;
        private string _caclsoccli;
        private string _faclcntcli;
        private string _cacldircli;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public DateTime capvfecven
        {
            get { return this._capvfecven; }
            set { this._capvfecven = value; }
        }
        public decimal capvtotven
        {
            get { return this._capvtotven; }
            set { this._capvtotven = value; }
        }
        public string papvcodven
        {
            get { return this._papvcodven; }
            set { this._papvcodven = value; }
        }
        public string capvobsven
        {
            get { return this._capvobsven; }
            set { this._capvobsven = value; }
        }
        public string fapvcodusu
        {
            get { return this._fapvcodusu; }
            set { this._fapvcodusu = value; }
        }
        public string fapvcodcli
        {
            get { return this._fapvcodcli; }
            set { this._fapvcodcli = value; }
        }
        public bool caclestcli
        {
            get { return this._caclestcli; }
            set { this._caclestcli = value; }
        }
        public string caclnumcel
        {
            get { return this._caclnumcel; }
            set { this._caclnumcel = value; }
        }
        public string paclcodcli
        {
            get { return this._paclcodcli; }
            set { this._paclcodcli = value; }
        }
        public string caclnitcli
        {
            get { return this._caclnitcli; }
            set { this._caclnitcli = value; }
        }
        public string caclsoccli
        {
            get { return this._caclsoccli; }
            set { this._caclsoccli = value; }
        }
        public string faclcntcli
        {
            get { return this._faclcntcli; }
            set { this._faclcntcli = value; }
        }
        public string cacldircli
        {
            get { return this._cacldircli; }
            set { this._cacldircli = value; }
        }
        #endregion

        #region Constructor
        public lventa()
        {
            this._capvfecven = DateTime.Now;
            this._capvtotven = 0;
            this._papvcodven = "";
            this._capvobsven = "";
            this._fapvcodusu = "";
            this._fapvcodcli = "";

            this._caclestcli = true;
            this._caclnumcel = "";
            this._paclcodcli = "";
            this._caclnitcli = "";
            this._caclsoccli = "";
            this._faclcntcli = "";
            this._cacldircli = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        public List<lventa> Lista(string where)
        {
            List<lventa> ListaResultado = new List<lventa>();
            this.Conexion.Conectar();
            string sql = "select " +
                                 "capvfecven," +
                                 "capvtotven," +
                                 "papvcodven," +
                                 "capvobsven," +
                                 "fapvcodusu," +
                                 "fapvcodcli, " +
                                 "caclestcli," +
                                 "caclnumcel," +
                                 "paclcodcli," +
                                 "caclnitcli," +
                                 "caclsoccli," +
                                 "faclcntcli," +
                                 "cacldircli " +
                         "from aventa, aclient " +
                         "where aventa.fapvcodcli = aclient.paclcodcli ";

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
                    lventa Auxiliar = new lventa();
                    Auxiliar.capvfecven = ResultadoConsulta.GetDateTime(0);
                    Auxiliar.capvtotven = ResultadoConsulta.GetDecimal(1);
                    Auxiliar.papvcodven = ResultadoConsulta.GetString(2);
                    Auxiliar.capvobsven = ResultadoConsulta.GetString(3);
                    Auxiliar.fapvcodusu = ResultadoConsulta.GetString(4);
                    Auxiliar.fapvcodcli = ResultadoConsulta.GetString(5);

                    Auxiliar.caclestcli = ResultadoConsulta.GetBoolean(6);
                    Auxiliar.caclnumcel = ResultadoConsulta.GetString(7);
                    Auxiliar.paclcodcli = ResultadoConsulta.GetString(8);
                    Auxiliar.caclnitcli = ResultadoConsulta.GetString(9);
                    Auxiliar.caclsoccli = ResultadoConsulta.GetString(10);
                    Auxiliar.faclcntcli = ResultadoConsulta.GetString(11);
                    Auxiliar.cacldircli = ResultadoConsulta.GetString(12);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
    }
}
