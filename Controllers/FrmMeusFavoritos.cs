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
            listBox1.Items.Clear();

            listCatsFavoritos = await catApi.GetListFavoritos();
            catModels = await catApi.GetCaracteristicasAsync();

            foreach (var item in listCatsFavoritos)
            {
                var catFavorite = catModels.Where(m => m.reference_image_id.ToString() == item.image_id).Select(m => m.name).FirstOrDefault();
                listBox1.Items.AddRange(new object[] { catFavorite });
            }
        }

        private void BtnExluirFavorito_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var catExcluir = (from cat in catModels
                                 join l in listCatsFavoritos on cat.reference_image_id equals l.image_id
                                 where cat.name == listBox1.SelectedItem as string
                                 select l.id ).FirstOrDefault() ;
                string idCat = catExcluir;

                catApi.DeleteCatFavoritoById(catExcluir.ToString());

                MessageBox.Show("Excluído do Favorito o Cat: " + listBox1.SelectedItem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PopularListBox();
            }
        }
    }
}
