using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntityLayer.Concrete
{
    public class Product
    {
        public string Id { get; set; }
        public string? code { get; set; }  //her ürünün bir kodu var
        public string? barcode { get; set; }  //unique değer

        public string? cat1name { get; set; }
        public string? ingcat1name { get; set; }

        public string? cat2name { get; set; }
        public string? ingcat2name { get; set; }

        public string? cat3name { get; set; }
        public string? ingcat3name { get; set; }

        public string? cat4name { get; set; }
        public string? ingcat4name { get; set; }

        public string? urlcat1name { get; set; }
        public string? urlcat2name { get; set; }
        public string? urlcat3name { get; set; }
        public string? urlcat4name { get; set; }

        public string? ws_code { get; set; }
        public string? name { get; set; }
        public string? ingname { get; set; }
        public string? stock { get; set; }
        public string? price { get; set; }
        public decimal? newprice { get; set; }
        public string? detail { get; set; }
        public string? width { get; set; }
        public string? height { get; set; }
        public string? imageUrl1 { get; set; }
        public string? imageUrl2 { get; set; }
        public string? imageUrl3 { get; set; }
        public string? imageUrl4 { get; set; }
        public string? imageUrl5 { get; set; }
        public string? imageUrl6 { get; set; }
    }
}
