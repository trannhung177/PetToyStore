using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class Gio_Hang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal totalprice = 0;
            List<DsSanPham> arr = (List<DsSanPham>)Application["giohang"];
            foreach (DsSanPham sp in arr)
            {
                totalprice += decimal.Parse(sp.price);
            }
            DsGiohang.DataSource = arr;
            DsGiohang.DataBind();
            TotalProduct.Text = arr.Count.ToString();
            TotalPrice.Text = totalprice.ToString();
            TotalPriceProduct.Text = totalprice.ToString();
    }
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();
            List<DsSanPham> arr = (List<DsSanPham>)Application["giohang"];
            foreach (DsSanPham sp in arr)
            {
                if (sp.id == id)
                {
                    arr.Remove(sp);
                    break;

                }
            }
            Application["giohang"] = arr;
            DsGiohang.DataSource = arr;
            DsGiohang.DataBind();
            TotalProduct.Text = arr.Count.ToString();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}