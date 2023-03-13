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
            listCatsFavoritos = await catApi.GetListFavoritos();
            catModels = await catApi.GetCaracteristicasAsync();

            foreach (var item in listCatsFavoritos)
            {
                var catFavorite = catModels.Where(m => m.reference_image_id.ToString() == item.image_id).Select(m => m.name ).FirstOrDefault();
                this.listBox1.Items.AddRange(new object[] {catFavorite});

            }

        }

    }
}
