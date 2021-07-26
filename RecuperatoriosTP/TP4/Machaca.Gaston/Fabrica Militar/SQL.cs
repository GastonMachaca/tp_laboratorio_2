using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Fabrica_Militar
{
    public class SQL
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        /// <summary>
        /// Constructor sin parametros que inicializa el atributo de conexion
        /// </summary>
        public SQL()
        {
            this.conexion = new SqlConnection("Data Source =.; Initial Catalog = MachacaGastonTP4; Integrated Security = True");
        }

        /// <summary>
        /// Envio los materiales del tanque creado.
        /// </summary>
        /// <param name="avion"></param>
        /// <returns></returns>
        public bool InsertarTanque(Tanque tanque)
        {
            bool retorno;

            int AmetralladoraSherman = tanque.CantidadAmetralladorasShermans;
            int AmetralladoraTigers = tanque.CantidadAmetralladorasTigers;
            int AmetralladoraT34 = tanque.CantidadAmetralladoras_T34;
            int CañonesShermans = tanque.CantidadCañonesShermans;
            int CañonesTiger = tanque.CantidadCañonesTigers;
            int CañonesT34 = tanque.CantidadCañones_T34;
            int MotoresSherman = tanque.CantidadMotoresShermans;
            int MotoresTiger = tanque.CantidadMotoresTigers;
            int MotoresT34 = tanque.CantidadMotores_T34;
            Tanques.TipoTanque Tipo = tanque.ObtenerDatosTanques;


            string sql = "INSERT INTO Tabla_Tanques (TipoDelTanque, AmetralladoraTigers, AmetralladoraT34, AmetralladoraSherman, CañonTigers, CañonT34, CañonSherman, MotoresTigers, MotoresT34, MotoresSherman) ";
            sql += "VALUES (@TipoDelTanque, @AmetralladoraTigers, @AmetralladoraT34, @AmetralladoraSherman, @CañonTigers, @CañonT34, @CañonSherman, @MotoresTigers, @MotoresT34, @MotoresSherman)";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@TipoDelTanque", Tipo.ToString());
                this.comando.Parameters.AddWithValue("@AmetralladoraTigers", AmetralladoraTigers);
                this.comando.Parameters.AddWithValue("@AmetralladoraT34", AmetralladoraT34);
                this.comando.Parameters.AddWithValue("@AmetralladoraSherman", AmetralladoraSherman);
                this.comando.Parameters.AddWithValue("@CañonTigers", CañonesTiger);
                this.comando.Parameters.AddWithValue("@CañonT34", CañonesT34);
                this.comando.Parameters.AddWithValue("@CañonSherman", CañonesShermans);
                this.comando.Parameters.AddWithValue("@MotoresTigers", MotoresTiger);
                this.comando.Parameters.AddWithValue("@MotoresT34", MotoresT34);
                this.comando.Parameters.AddWithValue("@MotoresSherman", MotoresSherman);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;

                throw new ExcepcionSqlConexion();
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }

        /// <summary>
        /// Envio los materiales del avion creado.
        /// </summary>
        /// <param name="avion"></param>
        /// <returns></returns>
        public bool InsertarAvion(Avion avion)
        {
            bool retorno;

            int AmetralladorasBlackWidow = avion.CantidadAmetralladorasBlackWindows;
            int AmetralladorasIlyushin = avion.CantidadAmetralladorasIlyushins;
            int AmetralladorasHenschel = avion.CantidadAmetralladorasHenschels;
            int CañonesBlackWidow = avion.CantidadCañonesBlackWindows;
            int CañonesIlyushin = avion.CantidadCañonesIlyushins;
            int CañonesHenschel = avion.CantidadCañonesHenschels;
            int MotoresBlackWidow = avion.CantidadMotoresBlackWindows;
            int MotoresIlyushin = avion.CantidadMotoresIlyushins;
            int MotoresHenschel = avion.CantidadMotoresHenschels;
            Aviones.Aeronaves Tipo = avion.ObtenerDatosAviones;


            string sql = "INSERT INTO Tabla_Aviones (TipoDeAvion, AmetralladorasBlackWindow, AmetralladorasIlyushin, AmetralladorasHenschel, CañonesBlackWidow, CañonesIlyushin, CañonesHenschel, MotoresBlackWidow, MotoresIlyushin, MotoresHenschel) ";
            sql += "VALUES (@TipoDeAvion, @AmetralladorasBlackWindow, @AmetralladorasIlyushin, @AmetralladorasHenschel, @CañonesBlackWidow, @CañonesIlyushin, @CañonesHenschel, @MotoresBlackWidow, @MotoresIlyushin, @MotoresHenschel)";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@TipoDeAvion", Tipo.ToString());
                this.comando.Parameters.AddWithValue("@AmetralladorasBlackWindow", AmetralladorasBlackWidow);
                this.comando.Parameters.AddWithValue("@AmetralladorasIlyushin", AmetralladorasIlyushin);
                this.comando.Parameters.AddWithValue("@AmetralladorasHenschel", AmetralladorasHenschel);
                this.comando.Parameters.AddWithValue("@CañonesBlackWidow", CañonesBlackWidow);
                this.comando.Parameters.AddWithValue("@CañonesIlyushin", CañonesIlyushin);
                this.comando.Parameters.AddWithValue("@CañonesHenschel", CañonesHenschel);
                this.comando.Parameters.AddWithValue("@MotoresBlackWidow", MotoresBlackWidow);
                this.comando.Parameters.AddWithValue("@MotoresIlyushin", MotoresIlyushin);
                this.comando.Parameters.AddWithValue("@MotoresHenschel", MotoresHenschel);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;

                throw new ExcepcionSqlConexion();
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return retorno;
        }
    }
}
