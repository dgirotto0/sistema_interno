using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Trocas
    {
        public string Cplaca { get; set; }
        public string Cnome { get; set; }
        public string Ctelefone { get; set; }
        public string Cmontadora { get; set; }
        public string Cmodelo { get; set; }
        public string Cano { get; set; }
        public string ColeoOriginal { get; set; }
        public string ColeoUsado { get; set; }
        public string CqTDE { get; set; }
        public string CfiltroOleo { get; set; }
        public string CfiltroAr { get; set; }
        public string CfiltroCombustivel { get; set; }
        public string CfiltroCabine { get; set; }
        public string Cpalheta { get; set; }
        public string Cbujao { get; set; }
        public string CfluidoDirecao { get; set; }
        public string CfluidoCambio { get; set; }
        public string Cpinos { get; set; }
        public string CdataTroca { get; set; }
        public string CkM { get; set; }
        public string CtrocaOleo { get; set; }
        public string CtrocaFiltroOleo { get; set; }
        public string CtrocaFiltroAr { get; set; }
        public string CtrocaFiltroComb { get; set; }
        public string CtrocaFiltroCabine { get; set; }
        public string CtrocaPalheta { get; set; }
        public string CtrocaBujao { get; set; }
        public string CtrocaFluidoDirecao { get; set; }
        public string CtrocaFluidoCambio { get; set; }
        public string CtrocaPinos { get; set; }

        public Trocas() { }

        public Trocas(string Placa, string Nome, string Telefone, string Montadora, string Modelo, string Ano, string OleoOriginal, string OleoUsado, 
            string QTDE, string FiltroOleo, string FiltroAr, string FiltroCombustivel, string FiltroCabine, string Palheta, string Bujao, string FluidoDirecao, 
            string FluidoCambio, string Pinos, string DataTroca, string KM, string TrocaOleo, string TrocaFiltroOleo, string TrocaFiltroAr, string TrocaFiltroComb, 
            string TrocaFiltroCabine, string TrocaPalheta, string TrocaBujao, string TrocaFluidoDirecao, string TrocaFluidoCambio, string TrocaPinos)
        {
            Cplaca = Placa;
            Cnome = Nome;
            Ctelefone = Telefone;
            Cmontadora = Montadora;
            Cmodelo = Modelo;
            Cano = Ano;
            ColeoOriginal = OleoOriginal;
            ColeoUsado = OleoUsado;
            CqTDE = QTDE;
            CfiltroOleo = FiltroOleo;
            CfiltroAr = FiltroAr;
            CfiltroCombustivel = FiltroCombustivel;
            CfiltroCabine = FiltroCabine;
            Cpalheta = Palheta;
            Cbujao = Bujao;
            CfluidoDirecao = FluidoDirecao;
            CfluidoCambio = FluidoCambio;
            Cpinos = Pinos;
            CdataTroca = DataTroca;
            CkM = KM;
            CtrocaOleo = TrocaOleo;
            CtrocaFiltroOleo = TrocaFiltroOleo;
            CtrocaFiltroAr = TrocaFiltroAr;
            CtrocaFiltroComb = TrocaFiltroComb;
            CtrocaFiltroCabine = TrocaFiltroCabine;
            CtrocaPalheta = TrocaPalheta;
            CtrocaBujao = TrocaBujao;
            CtrocaFluidoDirecao = TrocaFluidoDirecao;
            CtrocaFluidoCambio = TrocaFluidoCambio;
            CtrocaPinos = TrocaPinos;
        }

        public List<Trocas> GetTrocas()
        {
            var listaTrocas = new List<Trocas>();
            var dt = Excel.GetDados();

            foreach (DataRow item in dt.Rows)
                listaTrocas.Add(new Trocas(item["Placa"].ToString(), item["Nome"].ToString(), item["Telefone"].ToString(), item["Montadora"].ToString(),
                    item["Modelo"].ToString(), item["Ano"].ToString(), item["OleoOriginal"].ToString(), item["OleoUsado"].ToString(), item["QTDE"].ToString(), item["FiltroOleo"].ToString(),
                    item["FiltroAr"].ToString(), item["FiltroCombustivel"].ToString(), item["FiltroCabine"].ToString(), item["Palheta"].ToString(), item["Bujao"].ToString(), item["FluidoDirecao"].ToString(),
                    item["FluidoCambio"].ToString(), item["Pinos"].ToString(), item["DataTroca"].ToString(), item["KM"].ToString(), item["TrocaOleo"].ToString(), item["TrocaFiltroOleo"].ToString(),
                    item["TrocaFiltroAr"].ToString(), item["TrocaFiltroComb"].ToString(), item["TrocaFiltroCabine"].ToString(), item["TrocaPalheta"].ToString(), item["TrocaBujao"].ToString(), 
                    item["TrocaFluidoDirecao"].ToString(), item["TrocaFluidoCambio"].ToString(), item["TrocaPinos"].ToString()));

            return listaTrocas;
        }

        public bool AdicionarTroca(Trocas trocas)
        {
            return DataBase.AdicionarTroca(trocas);
        }
    }
}
