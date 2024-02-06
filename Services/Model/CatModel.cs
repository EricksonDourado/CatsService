using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsService.Services.Model
{
    public class CatModel
    {
        //public Weight weight { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Temperament { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public string Reference_Image_Id { get; set; }
    }
    public class CatImages
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public List<CatModel> Breeds { get; set; }
        public string Sub_Id { get; set; }
        public string Image_Id { get; set; }
    }

    public class CatFavorites
    {
        public string Id { get; set; }
        public string User_Id { get; set; }
        public string Image_Id { get; set; }
        public string Sub_Id { get; set; }
        public string Created_At { get; set; }
        public CatImages Image { get; set; }
    }
    public class Weight
    {
        public string Imperial { get; set; }
        public string Metric { get; set; }
    }
}
