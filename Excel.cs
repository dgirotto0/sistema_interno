using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public static class Excel
    {
        public static DataTable GetDados()
        {
            var arquivo = @"C:\Users\daniel.girotto\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\Desktop\Projetos\Itaoleo\DadosItaoleo2.xls";
            var planilha = "SELECT * FROM [tbCostumer$]";

            var strCon = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + arquivo + "; Extended Properties=\"Excel 12.0; HDR=Yes IMEX=0\"";

            var dt = new DataTable();

            using (OleDbConnection con = new OleDbConnection(strCon))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(planilha, con))
                {
                    da.Fill(dt);
                }
            }

            return dt;

        }
    }
}
