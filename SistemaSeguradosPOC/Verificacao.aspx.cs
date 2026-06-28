using System;
using SistemaSeguradosPOC.Models;
using SistemaSeguradosPOC.Service;
using SistemaSeguradosPOC.Repository;

namespace SistemaSeguradosPOC
{
    public partial class Verificacao : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                var repository = new SeguradoRepository();
                var conectou = repository.TestarConexao();

                lblResultadoConexao.Text = conectou
                    ? "Conexao com o banco realizada com sucesso."
                    : "Nao foi possivel abrir a conexao com o banco.";
            }
            catch (Exception ex)
            {
                lblResultadoConexao.Text = "Erro ao conectar: " + ex.Message;
            }
        }
       
    }
}
