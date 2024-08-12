using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class CostumerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=<SERVIDOR>;Initial Catalog=""<SEU BANCO>"";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public CostumerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string valorOleo = cbxOleo.Checked ? "SIM" : "NÃO";
                string valorFiltroOleo = cbxFiltroOleo.Checked ? "SIM" : "NÃO";
                string valorFiltroAr = cbxFiltroAr.Checked ? "SIM" : "NÃO";
                string valorFiltroComb = cbxFiltroComb.Checked ? "SIM" : "NÃO";
                string valorFiltroCabine = cbxFiltroCabine.Checked ? "SIM" : "NÃO";
                string valorPalheta = cbxPalheta.Checked ? "SIM" : "NÃO";
                string valorBujao = cbxBujao.Checked ? "SIM" : "NÃO";
                string valorFluidoDirecao = cbxFluidoDirecao.Checked ? "SIM" : "NÃO";
                string valorFluidoCambio = cbxFluidoCambio.Checked ? "SIM" : "NÃO";
                string valorPinos = cbxPinos.Checked ? "SIM" : "NÃO";


                cmd = new SqlCommand("INSERT INTO <SEU BANCO>$(Placa, Nome, Telefone, Montadora, Modelo, Ano, OleoOriginal, OleoUsado, QTDE, FiltroOleo, FiltroAr, FiltroCombustivel, FiltroCabine, Palheta,  Bujao, FluidoDirecao, FluidoCambio, Pinos, Obs, DataTroca, KM, TrocaOleo, TrocaFiltroOleo, TrocaFiltroAr, TrocaFiltroComb, TrocaFiltroCabine, TrocaPalheta,  TrocaBujao, TrocaFluidoDirecao, TrocaFluidoCambio, TrocaPinos) VALUES (@Placa, @Nome, @Telefone, @Montadora, @Modelo, @Ano, @OleoOriginal, @OleoUsado, @QTDE, @FiltroOleo, @FiltroAr, @FiltroCombustivel, @FiltroCabine, @Palheta,  @Bujao, @FluidoDirecao, @FluidoCambio, @Pinos, @Obs, @DataTroca, @KM, @TrocaOleo, @TrocaFiltroOleo, @TrocaFiltroAr, @TrocaFiltroComb, @TrocaFiltroCabine, @TrocaPalheta,  @TrocaBujao, @TrocaFluidoDirecao, @TrocaFluidoCambio, @TrocaPinos)", con);
                cmd.Parameters.AddWithValue("@Nome", txtCName.Text);
                try
                {
                    cmd.Parameters.AddWithValue("@Telefone", txtCPhone.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cmd.Parameters.AddWithValue("@Modelo", txtCarro.Text);
                cmd.Parameters.AddWithValue("@Montadora", txtMontadora.Text);
                cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                cmd.Parameters.AddWithValue("@Ano", txtAno.Text);
                cmd.Parameters.AddWithValue("@OleoOriginal", txtOleoOriginal.Text);
                cmd.Parameters.AddWithValue("@OleoUsado", txtOleoUsado.Text);
                try
                {
                    cmd.Parameters.AddWithValue("@QTDE", txtQuantidadeOleo.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.Parameters.AddWithValue("@FiltroOleo", txtFiltroOleo.Text);
                cmd.Parameters.AddWithValue("@FiltroAr", txtFiltroAr.Text);
                cmd.Parameters.AddWithValue("@FiltroCabine", txtFiltroCabine.Text);
                cmd.Parameters.AddWithValue("@FiltroCombustivel", txtCombustivel.Text);
                cmd.Parameters.AddWithValue("@Bujao", txtBujao.Text);
                cmd.Parameters.AddWithValue("@Palheta", txtPalheta.Text);
                cmd.Parameters.AddWithValue("@FluidoDirecao", txtFluidoDirecao.Text);
                cmd.Parameters.AddWithValue("@FluidoCambio", txtFluidoCambio.Text);
                cmd.Parameters.AddWithValue("@Pinos", txtPinos.Text);
                cmd.Parameters.AddWithValue("@Obs", txtObservacao.Text);
                try
                {
                    DateTime dataTroca = DateTime.Parse(mtxDataTroca.Text);
                    cmd.Parameters.AddWithValue("@DataTroca", dataTroca);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erro na Data: ", ex.Message);
                }
                try
                {
                    cmd.Parameters.AddWithValue("@KM", txtKm.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmd.Parameters.AddWithValue("@TrocaOleo", valorOleo);
                cmd.Parameters.AddWithValue("@TrocaFiltroOleo", valorFiltroOleo);
                cmd.Parameters.AddWithValue("@TrocaFiltroAr", valorFiltroAr);
                cmd.Parameters.AddWithValue("@TrocaFiltroComb", valorFiltroComb);
                cmd.Parameters.AddWithValue("@TrocaFiltroCabine", valorFiltroCabine);
                cmd.Parameters.AddWithValue("@TrocaPalheta", valorPalheta);
                cmd.Parameters.AddWithValue("@TrocaBujao", valorBujao);
                cmd.Parameters.AddWithValue("@TrocaFluidoDirecao", valorFluidoDirecao);
                cmd.Parameters.AddWithValue("@TrocaFluidoCambio", valorFluidoCambio);
                cmd.Parameters.AddWithValue("@TrocaPinos", valorPinos);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cliente Cadastrado!");
                Clear();    
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                con.Close();
            }
        }

        private void Clear()
        {
            txtCName.Clear();
            txtCPhone.Clear();
            txtCarro.Clear();
            txtMontadora.Clear();
            txtPlaca.Clear();
            txtAno.Clear();
            txtOleoOriginal.Clear();
            txtQuantidadeOleo.Clear();
            txtFiltroOleo.Clear();
            txtFiltroAr.Clear();
            txtFiltroCabine.Clear();
            txtCombustivel.Clear();
            txtOleoUsado.Clear();
            txtBujao.Clear();
            txtPalheta.Clear();
            txtFluidoDirecao.Clear();
            txtFluidoCambio.Clear();
            txtObservacao.Clear();
            mtxDataTroca.Clear();
            txtKm.Clear();
            txtPinos.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();            
        }

        /*private void btnUptade_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza que quer atualizar esse cliente?", "Atualizando Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conUpdate = new SqlConnection(@"Data Source=<SERVIDOR>;Initial Catalog=<SEU BANCO>;User ID=<USER>;Password=<SENHA"))
                    {

                        conUpdate.Open();

                        using (SqlCommand cmdUpdate = new SqlCommand("UPTADE <SUA TABELA> SET Placa = @Placa, Nome = @Nome, Telefone = @Telefone, Montadora = @Montadora, Modelo = @Modelo, Ano = @Ano, OleoOriginal = @OleoOriginal, OleoUsado = @OleoUsado, QTDE = @QTDE, FiltroOleo = @FiltroOleo, FiltroAr = @FiltroAr, FiltroCombustivel = @FiltroCombustivel, FiltroCabine @FiltroCabine, Palheta @Palheta,  Bujao = @Bujao, FluidoDirecao = @FluidoDirecao, FluidoCambio = @FluidoCambio, Pinos = @Pinos, DataTroca = @DataTroca, KM = @KM, TrocaOleo = @TrocaOleo, TrocaFiltroOleo = @TrocaFiltroOleo, TrocaFiltroAr = @TrocaFiltroAr, TrocaFiltroComb = @TrocaFiltroComb, TrocaFiltroCabine = @TrocaFiltroCabine, TrocaPalheta = @TrocaPalheta,  TrocaBujao = @TrocaBujao, TrocaFluidoDirecao = @TrocaFluidoDirecao, TrocaFluidoCambio = @TrocaFluidoCambio, TrocaPinos = @TrocaPinos)  WHERE <ID> LIKE '" + lblCostumerId.Text + "' ", con))
                        {
                        string valorOleo = cbxOleo.Checked ? "SIM" : "NÃO";
                        string valorFiltroOleo = cbxFiltroOleo.Checked ? "SIM" : "NÃO";
                        string valorFiltroAr = cbxFiltroAr.Checked ? "SIM" : "NÃO";
                        string valorFiltroComb = cbxFiltroComb.Checked ? "SIM" : "NÃO";
                        string valorFiltroCabine = cbxFiltroCabine.Checked ? "SIM" : "NÃO";
                        string valorPalheta = cbxPalheta.Checked ? "SIM" : "NÃO";
                        string valorBujao = cbxBujao.Checked ? "SIM" : "NÃO";
                        string valorFluidoDirecao = cbxFluidoDirecao.Checked ? "SIM" : "NÃO";
                        string valorFluidoCambio = cbxFluidoCambio.Checked ? "SIM" : "NÃO";
                        string valorPinos = cbxPinos.Checked ? "SIM" : "NÃO";

                        cmd.Parameters.AddWithValue("@Nome", txtCName.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtCPhone.Text);
                        cmd.Parameters.AddWithValue("@Modelo", txtCarro.Text);
                        cmd.Parameters.AddWithValue("@Montadora", txtMontadora.Text);
                        cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                        cmd.Parameters.AddWithValue("@Ano", txtAno.Text);
                        cmd.Parameters.AddWithValue("@OleoOriginal", txtOleoOriginal.Text);
                        cmd.Parameters.AddWithValue("@OleoUsado", txtOleoUsado.Text);
                        cmd.Parameters.AddWithValue("@QTDE", txtQuantidadeOleo.Text);
                        cmd.Parameters.AddWithValue("@FiltroOleo", txtFiltroOleo.Text);
                        cmd.Parameters.AddWithValue("@FiltroAr", txtFiltroAr.Text);
                        cmd.Parameters.AddWithValue("@FiltroCabine", txtFiltroCabine.Text);
                        cmd.Parameters.AddWithValue("@FiltroCombustivel", txtCombustivel.Text);
                        cmd.Parameters.AddWithValue("@Bujao", txtBujao.Text);
                        cmd.Parameters.AddWithValue("@Palheta", txtPalheta.Text);
                        cmd.Parameters.AddWithValue("@FluidoDirecao", txtFluidoDirecao.Text);
                        cmd.Parameters.AddWithValue("@FluidoCambio", txtFluidoCambio.Text);
                        cmd.Parameters.AddWithValue("@Pinos", txtPinos.Text);
                        cmd.Parameters.AddWithValue("@DataTroca", mtxDataTroca.Text);
                        cmd.Parameters.AddWithValue("@KM", txtKm.Text);
                        cmd.Parameters.AddWithValue("@TrocaOleo", valorOleo);
                        cmd.Parameters.AddWithValue("@TrocaFiltroOleo", valorFiltroOleo);
                        cmd.Parameters.AddWithValue("@TrocaFiltroAr", valorFiltroAr);
                        cmd.Parameters.AddWithValue("@TrocaFiltroComb", valorFiltroComb);
                        cmd.Parameters.AddWithValue("@TrocaFiltroCabine", valorFiltroCabine);
                        cmd.Parameters.AddWithValue("@TrocaPalheta", valorPalheta);
                        cmd.Parameters.AddWithValue("@TrocaBujao", valorBujao);
                        cmd.Parameters.AddWithValue("@TrocaFluidoDirecao", valorFluidoDirecao);
                        cmd.Parameters.AddWithValue("@TrocaFluidoCambio", valorFluidoCambio);
                        cmd.Parameters.AddWithValue("@TrocaPinos", valorPinos);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        }                        
                    }
                    MessageBox.Show("Cliente Atualizado!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }*/

        private void txtKm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSave.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                    string valorOleo = cbxOleo.Checked ? "SIM" : "NÃO";
                    string valorFiltroOleo = cbxFiltroOleo.Checked ? "SIM" : "NÃO";
                    string valorFiltroAr = cbxFiltroAr.Checked ? "SIM" : "NÃO";
                    string valorFiltroComb = cbxFiltroComb.Checked ? "SIM" : "NÃO";
                    string valorFiltroCabine = cbxFiltroCabine.Checked ? "SIM" : "NÃO";
                    string valorPalheta = cbxPalheta.Checked ? "SIM" : "NÃO";
                    string valorBujao = cbxBujao.Checked ? "SIM" : "NÃO";
                    string valorFluidoDirecao = cbxFluidoDirecao.Checked ? "SIM" : "NÃO";
                    string valorFluidoCambio = cbxFluidoCambio.Checked ? "SIM" : "NÃO";
                    string valorPinos = cbxPinos.Checked ? "SIM" : "NÃO";


                    cmd = new SqlCommand("INSERT INTO <BANCO>$(Placa, Nome, Telefone, Montadora, Modelo, Ano, OleoOriginal, OleoUsado, QTDE, FiltroOleo, FiltroAr, FiltroCombustivel, FiltroCabine, Palheta,  Bujao, FluidoDirecao, FluidoCambio, Pinos, Obs, DataTroca, KM, TrocaOleo, TrocaFiltroOleo, TrocaFiltroAr, TrocaFiltroComb, TrocaFiltroCabine, TrocaPalheta,  TrocaBujao, TrocaFluidoDirecao, TrocaFluidoCambio, TrocaPinos) VALUES (@Placa, @Nome, @Telefone, @Montadora, @Modelo, @Ano, @OleoOriginal, @OleoUsado, @QTDE, @FiltroOleo, @FiltroAr, @FiltroCombustivel, @FiltroCabine, @Palheta,  @Bujao, @FluidoDirecao, @FluidoCambio, @Pinos, @Obs, @DataTroca, @KM, @TrocaOleo, @TrocaFiltroOleo, @TrocaFiltroAr, @TrocaFiltroComb, @TrocaFiltroCabine, @TrocaPalheta,  @TrocaBujao, @TrocaFluidoDirecao, @TrocaFluidoCambio, @TrocaPinos)", con);
                    cmd.Parameters.AddWithValue("@Nome", txtCName.Text);                    
                    try
                    {
                        cmd.Parameters.AddWithValue("@Telefone", txtCPhone.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Erro no Telefone: ", ex.Message);
                    }

                    cmd.Parameters.AddWithValue("@Modelo", txtCarro.Text);
                    cmd.Parameters.AddWithValue("@Montadora", txtMontadora.Text);
                    cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    cmd.Parameters.AddWithValue("@Ano", txtAno.Text);
                    cmd.Parameters.AddWithValue("@OleoOriginal", txtOleoOriginal.Text);
                    cmd.Parameters.AddWithValue("@OleoUsado", txtOleoUsado.Text);
                    try
                    {
                        cmd.Parameters.AddWithValue("@QTDE", txtQuantidadeOleo.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Erro na QTDE: ", ex.Message);
                    }
                    cmd.Parameters.AddWithValue("@FiltroOleo", txtFiltroOleo.Text);
                    cmd.Parameters.AddWithValue("@FiltroAr", txtFiltroAr.Text);
                    cmd.Parameters.AddWithValue("@FiltroCabine", txtFiltroCabine.Text);
                    cmd.Parameters.AddWithValue("@FiltroCombustivel", txtCombustivel.Text);
                    cmd.Parameters.AddWithValue("@Bujao", txtBujao.Text);
                    cmd.Parameters.AddWithValue("@Palheta", txtPalheta.Text);
                    cmd.Parameters.AddWithValue("@FluidoDirecao", txtFluidoDirecao.Text);
                    cmd.Parameters.AddWithValue("@FluidoCambio", txtFluidoCambio.Text);
                    cmd.Parameters.AddWithValue("@Pinos", txtPinos.Text);
                    cmd.Parameters.AddWithValue("@Obs", txtObservacao.Text);   
                    try
                    {
                        DateTime dataTroca = DateTime.Parse(mtxDataTroca.Text);
                        cmd.Parameters.AddWithValue("@DataTroca", dataTroca);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Erro na Data: ", ex.Message);
                    }                    
                    try
                    {
                        cmd.Parameters.AddWithValue("@KM", txtKm.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Erro no KM: ", ex.Message);
                    }
                    cmd.Parameters.AddWithValue("@TrocaOleo", valorOleo);
                    cmd.Parameters.AddWithValue("@TrocaFiltroOleo", valorFiltroOleo);
                    cmd.Parameters.AddWithValue("@TrocaFiltroAr", valorFiltroAr);
                    cmd.Parameters.AddWithValue("@TrocaFiltroComb", valorFiltroComb);
                    cmd.Parameters.AddWithValue("@TrocaFiltroCabine", valorFiltroCabine);
                    cmd.Parameters.AddWithValue("@TrocaPalheta", valorPalheta);
                    cmd.Parameters.AddWithValue("@TrocaBujao", valorBujao);
                    cmd.Parameters.AddWithValue("@TrocaFluidoDirecao", valorFluidoDirecao);
                    cmd.Parameters.AddWithValue("@TrocaFluidoCambio", valorFluidoCambio);
                    cmd.Parameters.AddWithValue("@TrocaPinos", valorPinos);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cliente Cadastrado!");
                    Clear();

                    this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                con.Close();
            }
        }
    }
}
