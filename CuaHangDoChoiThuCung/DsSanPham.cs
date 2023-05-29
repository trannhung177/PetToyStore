using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangDoChoiThuCung
{
    public class DsSanPham
    {
        public string id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string images { get; set; }
        public string detail { get; set; }
        public string type { get; set; }
        public DsSanPham()
        {

        }

        public DsSanPham(string id, string name, string price, string img, string detail, string type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.images = img;
            this.detail = detail;
            this.type = type;
        }
    }

}