using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DsSanPham> arrGH = (List<DsSanPham>)Application["giohang"];
            decimal totalprice = 0;
            foreach (DsSanPham sp in arrGH)
            {
                totalprice += decimal.Parse(sp.price);
            }
            TotalPrice.Text = totalprice.ToString();

            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Trang_Chu.aspx", true);

            }
            else
            {
                List<DsSanPham> arr = (List<DsSanPham>)Application["sanpham"];
                foreach (DsSanPham sp in arr)
                {
                    if (sp.id == Request.QueryString["id"])
                    {
                        name.Text = sp.name;
                        price.Text = "Giá bán:" + sp.price + "đ";
                        Image1.ImageUrl = sp.images;
                        btnthem.CommandArgument = sp.id;
                        details.Text = sp.detail;
                    }
                }
            }
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();

            List<DsSanPham> arr = (List<DsSanPham>)Application["giohang"];
            List<DsSanPham> arrsp = (List<DsSanPham>)Application["sanpham"];
            if (arr.Count == 0)
            {
                arr = new List<DsSanPham>();
            }

            foreach (DsSanPham sp in arrsp)
            {
                if (sp.id == id)
                {
                    arr.Add(sp);
                    break;
                }
            }
            Application["giohang"] = arr;
            Page.Response.Redirect(Page.Request.Url.ToString(), true);

        }
    }
}