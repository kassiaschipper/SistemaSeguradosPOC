using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaSeguradosPOC
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new Service.SeguradoService();
                var segurados = service.BuscarTodosSegurados();
                gvSegurados.DataSource = segurados;
                gvSegurados.DataBind();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao consultar: " + ex.Message;
            }
        }
    }
}