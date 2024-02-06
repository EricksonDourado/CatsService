using CatsService.Services;
using CatsService.Services.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsService.Controllers
{
    public partial class FrmMeusFavoritos : Form
    {
        CatApi catApi = new CatApi();
        List<CatModel> catModels = new List<CatModel>();
        List<CatFavorites> listCatsFavoritos = new List<CatFavorites>();
        private CatApi _catApi = new CatApi();

        public FrmMeusFavoritos()
        {
            InitializeComponent();
        }

        private async void FrmMeusFavoritos_Load(object sender, EventArgs e)
        {
            PopularListBox();
        }

        private async void PopularListBox()
        {
            lbFavoritos.Items.Clear();

            listCatsFavoritos = await catApi.GetListFavoritos();
            catModels = await catApi.GetCaracteristicasAsync();

            foreach (var item in listCatsFavoritos)
            {
                var catFavorite = catModels.Where(m => m.Reference_Image_Id.ToString() == item.Image_Id).Select(m => m.Name).FirstOrDefault();
                lbFavoritos.Items.AddRange(new object[] { catFavorite });
            }
        }

        private void BtnExluirFavorito_Click(object sender, EventArgs e)
        {
            if (lbFavoritos.SelectedItem != null)
            {
                var catExcluir = (from cat in catModels
                                 join l in listCatsFavoritos on cat.Reference_Image_Id equals l.Image_Id
                                 where cat.Name == lbFavoritos.SelectedItem as string
                                 select l.Id ).FirstOrDefault() ;
                string idCat = catExcluir;

                catApi.DeleteCatFavoritoById(catExcluir.ToString());

                MessageBox.Show("Excluído do Favorito o Cat: " + lbFavoritos.SelectedItem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PopularListBox();
            }
        }


        private async void lbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
                String name = lbFavoritos.SelectedItem.ToString();
                String idCatSelec = catModels.Where(c => c.Name == name).Select(c => c.Reference_Image_Id).FirstOrDefault();

                var imageCat = await _catApi.GetImagemCatById(idCatSelec);

                this.pictImagem.ImageLocation = imageCat.Url.ToString();
        }
    }
}
