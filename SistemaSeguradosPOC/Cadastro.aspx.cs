using System;
using SistemaSeguradosPOC.Models;
using SistemaSeguradosPOC.Service;
using SistemaSeguradosPOC.Repository;

namespace SistemaSeguradosPOC
{
    public partial class Cadastro : System.Web.UI.Page
    {
        //private readonly SeguradoService _service = new SeguradoService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var segurado = new Segurado
                {
                    Nome = txtNome.Text.Trim(),
                    Cpf = txtCpf.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DataNascimento = DateTime.Parse(txtDataNascimento.Text),
                    ValorContribuicao = decimal.Parse(txtValorContribuicao.Text)
                };

                var service = new SeguradoService();
                service.CadastrarSegurado(segurado);

                lblMensagem.Text = "Segurado cadastrado com sucesso.";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao cadastrar: " + ex.Message;
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var cpf = TextCpfExcluido.Text.Trim();

                if (string.IsNullOrWhiteSpace(cpf))
                    throw new Exception("Informe o CPF para exclusao.");

                var repository = new SeguradoRepository();
                var linhasAfetadas = repository.ExcluirSegurado(cpf);

                lblMensagem.Text = linhasAfetadas > 0
                    ? "Segurado excluido com sucesso."
                    : "Nenhum segurado encontrado com esse CPF.";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao excluir: " + ex.Message;
            }
        }
    }
}
