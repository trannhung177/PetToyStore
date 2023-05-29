using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class Trang_Chu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DsSanPham> arrGH = (List<DsSanPham>)Application["giohang"];
            List<DsSanPham> arr = (List<DsSanPham>)Application["sanpham"];
            List<DsSanPham> arrFeaturedProducts = new List<DsSanPham>();
            List<DsSanPham> arrNewProducts = new List<DsSanPham>();
            decimal totalprice = 0;
            foreach (DsSanPham sp in arr)
            {
                int id = Int32.Parse(sp.id);
                if (id == 1 || id == 2 || id == 3 || id == 4 || id == 5 || id == 6 || id == 7 || id == 8)
                {
                    arrFeaturedProducts.Add(sp);
                }
                if (id == 9 || id == 10 || id == 11 || id == 12 || id == 13 || id == 14 || id == 15 || id == 16)
                {
                    arrNewProducts.Add(sp);
                }
            }

            foreach (DsSanPham sp in arrGH)
            {
                totalprice += decimal.Parse(sp.price);
            }
            TotalPrice.Text = totalprice.ToString();

            if (Session["taikhoan"]!=null)
            {
                loregisterlogin.InnerHtml =
                    "Chào " + Session["taikhoan"].ToString() +
                    "<span>|</span> <a href=\"Dang_Xuat.aspx\" style=\"font-size: 15px; color: #cc9966\" >Đăng xuất</a>";
             
            }

            
            ListViewFeaturedProducts.DataSource = arrFeaturedProducts;
            ListViewFeaturedProducts.DataBind();

            ListViewNewProducts.DataSource = arrNewProducts;
            ListViewNewProducts.DataBind();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {

            if (txtsearch.Text == "chó") { Response.Redirect("San_Pham.aspx?type=1"); }
            else if (txtsearch.Text == "mèo") { Response.Redirect("San_Pham.aspx?type=2"); }
            else if (txtsearch.Text == "phụ kiện") { Response.Redirect("San_Pham.aspx?type=3"); }
            else
            { Response.Redirect("San_Pham.aspx?type=4"); }
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