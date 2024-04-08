using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class DataBase
    {

        private static string server = "172.16.1.208";
        private static string database = "Excel";

        public static string MsgErro { get; private set; }
        public static string StrCon
        {
            get { return $"Data Source = {server} ;Initial Catalog = {database}; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False"; }
        }
        public static bool AdicionarTroca(Trocas trocas)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(StrCon)) 
                {
                    cn.Open();

                    var sql = "INSERT INTO tbCostumer (Placa, Nome, Telefone, Montadora, Modelo, Ano, OleoOriginal, OleoUsado, QTDE, FiltroOleo, FiltroAr, FiltroCombustivel, FiltroCabine, Palheta,  Bujao, FluidoDirecao, FluidoCambio, Pinos, DataTroca, KM, TrocaOleo, TrocaFiltroOleo, TrocaFiltroAr, TrocaFiltroComb, TrocaFiltroCabine, TrocaPalheta,  TrocaBujao, TrocaFluidoDirecao, TrocaFluidoCambio, TrocaPinos) VALUES (@Placa, @Nome, @Telefone, @Montadora, @Modelo, @Ano, @OleoOriginal, @OleoUsado, @QTDE, @FiltroOleo, @FiltroAr, @FiltroCombustivel, @FiltroCabine, @Palheta,  @Bujao, @FluidoDirecao, @FluidoCambio, @Pinos, @DataTroca, @KM, @TrocaOleo, @TrocaFiltroOleo, @TrocaFiltroAr, @TrocaFiltroComb, @TrocaFiltroCabine, @TrocaPalheta,  @TrocaBujao, @TrocaFluidoDirecao, @TrocaFluidoCambio, @TrocaPinos)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn)) 
                    {
                        cmd.Parameters.AddWithValue("@Placa", trocas.Cplaca);
                        cmd.Parameters.AddWithValue("@Nome", trocas.Cnome);
                        cmd.Parameters.AddWithValue("@Telefone", trocas.Ctelefone);
                        cmd.Parameters.AddWithValue("@Montadora", trocas.Cmontadora);
                        cmd.Parameters.AddWithValue("@Modelo", trocas.Cmodelo);
                        cmd.Parameters.AddWithValue("@Ano", trocas.Cano);
                        cmd.Parameters.AddWithValue("@OleoOriginal", trocas.ColeoOriginal);
                        cmd.Parameters.AddWithValue("@OleoUsado", trocas.ColeoUsado);
                        cmd.Parameters.AddWithValue("@QTDE", trocas.CqTDE);
                        cmd.Parameters.AddWithValue("@FiltroOleo", trocas.CfiltroOleo);
                        cmd.Parameters.AddWithValue("@FiltroAr", trocas.CfiltroAr);
                        cmd.Parameters.AddWithValue("@FiltroCombustivel", trocas.CfiltroCombustivel);
                        cmd.Parameters.AddWithValue("@FiltroCabine", trocas.CfiltroCabine);
                        cmd.Parameters.AddWithValue("@Palheta", trocas.Cpalheta);
                        cmd.Parameters.AddWithValue("@Bujao", trocas.Cbujao);
                        cmd.Parameters.AddWithValue("@FluidoDirecao", trocas.CfluidoDirecao);
                        cmd.Parameters.AddWithValue("@FluidoCambio", trocas.CfluidoCambio);
                        cmd.Parameters.AddWithValue("@Pinos", trocas.Cpinos);
                        cmd.Parameters.AddWithValue("@DataTroca", trocas.CdataTroca);
                        cmd.Parameters.AddWithValue("@KM", trocas.CkM);
                        cmd.Parameters.AddWithValue("@TrocaOleo", trocas.CtrocaOleo);
                        cmd.Parameters.AddWithValue("@TrocaFiltroOleo", trocas.CtrocaFiltroOleo);
                        cmd.Parameters.AddWithValue("@TrocaFiltroAr", trocas.CtrocaFiltroAr);
                        cmd.Parameters.AddWithValue("@TrocaFiltroComb", trocas.CtrocaFiltroComb);
                        cmd.Parameters.AddWithValue("@TrocaFiltroCabine", trocas.CtrocaFiltroCabine);
                        cmd.Parameters.AddWithValue("@TrocaPalheta", trocas.CtrocaPalheta);
                        cmd.Parameters.AddWithValue("@TrocaBujao", trocas.CtrocaBujao);
                        cmd.Parameters.AddWithValue("@TrocaFluidoFirecao", trocas.CtrocaFluidoDirecao);
                        cmd.Parameters.AddWithValue("@TrocaFluidoCambio", trocas.CtrocaFluidoCambio);
                        cmd.Parameters.AddWithValue("@TrocaPinos", trocas.CtrocaPinos);        
                        
                        cmd.ExecuteNonQuery();                        
                    }
                }
                MsgErro = "";
                return true;
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;   
                return false;
            }
        }
    }
}
