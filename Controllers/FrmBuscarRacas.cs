using CatsService.Services;
using CatsService.Services.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsService.Controllers
{
    public partial class FrmBuscarRacas : Form
    {
        private List<CatModel> listCats = new List<CatModel>();
        private CatImages _catImages;
        private CatApi _catApi;

        public FrmBuscarRacas()
        {
            InitializeComponent();
            _catApi = new CatApi();
            _catImages = new CatImages();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {

        }

        private async void btnAtualizarLista_Click(object sender, EventArgs e)
        {

            listCats = await _catApi.GetCaracteristicasAsync();

            foreach (var item in listCats)
            {
                this.comboBox1.Items.AddRange(new object[] { item.name });
            }
        }

        public async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;

            this.LblOrigem.Text = listCats[index].origin;
            this.LblDescricao.Text = listCats[index].description;
            this.LblTemperamento.Text = listCats[index].temperament;
            _catImages.image_id = listCats[index].reference_image_id.ToString();

            var imageCat = await _catApi.GetImagemCatById(_catImages.image_id);

            this.PicImagem.ImageLocation = imageCat.url.ToString();
        }

        private void btnIncluirFavoritos_Click(object sender, EventArgs e)
        {
            var user = "your-user-1234";

            CatApi catFavorite = new CatApi();
            catFavorite.IncludesFavoriteCat(this._catImages.image_id, user);
        }
    }
}
