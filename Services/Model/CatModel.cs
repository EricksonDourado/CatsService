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
        public string id { get; set; }
        public string name { get; set; }
        public string temperament { get; set; }
        public string description { get; set; }
        public string origin { get; set; }
        public string reference_image_id { get; set; }
    }
    public class CatImages
    {
        public string id { get; set; }
        public string url { get; set; }
        public List<CatModel> breeds { get; set; }
        public string sub_id { get; set; }
        public string image_id { get; set; }
    }

    public class CatFavorites
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string image_id { get; set; }
        public string sub_id { get; set; }
        public string created_at { get; set; }
        public CatImages image { get; set; }
    }
    public class Weight
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }
}
