using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
namespace WebApplication1
{
    public partial class admin_ProductsManagement : System.Web.UI.Page
    {
        private string[] vinos = { "Santa Julia", "Luigi Bosca", "Rutini", "Alma Mora"};
        private string[] cervezas = { "Quilmes", "Brahma", "Stella Artois", "Andes Origen", "Corona", "Budweiser" };
        private string[] licores = { "Cusenier", "Bols", "Tia Maria"};
        private string[] whiskies = { "Johnnie Walker", "Jameson", "Jack Daniels", "Chivas Regal"};
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoLogic prodLog = new ProductoLogic();
            
        }

        protected void onTipoChanged(object sender, EventArgs e)
        {
            switch (dropTipos.SelectedIndex)
            {
                case 0: 
                    filtrarProductores(vinos);
                    cambiarReadOnly(true, false, true);
                    break;
                case 1: 
                    filtrarProductores(cervezas);
                    cambiarReadOnly(false, true, true);
                    break;
                case 2: 
                    filtrarProductores(licores);
                    cambiarReadOnly(true, true, true);
                    break;
                case 3: 
                    filtrarProductores(whiskies);
                    cambiarReadOnly(true, false, false);
                    break;
            }

            listProductores.DataBind();
        }

        private void filtrarProductores(string[] tipo)
        {
            for (int i=0;i<listProductores.Items.Count;i++)
            {
                for (int j=0;j<tipo.Length;j++)
                {
                    if (listProductores.Items[i].Value != tipo[j])
                    {
                        listProductores.Items[i].Enabled = false;
                    } else
                    {
                        listProductores.Items[i].Enabled = true;
                        break;
                    }
                }
                
            }
        }

        private void cambiarReadOnly(bool ibu, bool anio, bool aniejamiento)
        {
            txtIBU.ReadOnly = ibu;
            txtAnio.ReadOnly = anio;
            txtAniejamiento.ReadOnly = aniejamiento;
        }
    }
}