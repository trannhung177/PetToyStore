using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuaHangDoChoiThuCung
{
    public class GioHang
    {
        public string id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string detail { get; set; }
        public string number { get; set; }
        public string total { get; set; }
        public string type { get; set; }
        public GioHang()
        {

        }
        public GioHang(string id, string img, string name, string price, string detail, string number, string total, string type)
        {
            this.id = id;
            this.img = img;
            this.name = name;
            this.price = price;
            this.detail = detail;
            this.number = number;
            this.total = total;
            this.type = type;
        }
    }
}