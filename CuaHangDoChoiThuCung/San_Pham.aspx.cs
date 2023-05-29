using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class San_Pham : System.Web.UI.Page
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
            if (Request.QueryString["type"] != null)
            {
                string type = Request.QueryString["type"];
                if (type == "1") { titleproducts1.Text = "Shop cho chó"; }
                else if (type == "2") { titleproducts1.Text = "Shop cho mèo"; } 
               
                else { titleproducts1.Text = "Bạn phải nhập lớn hơn 3 kí tự..."; }

                List<DsSanPham> arr = (List<DsSanPham>)Application["sanpham"];
                List<DsSanPham> arrtype = new List<DsSanPham>();
                foreach (DsSanPham sp in arr)
                {
                    if (sp.type == type) { arrtype.Add(sp); }
                }
                ListViewProducts1.DataSource = arrtype;
                ListViewProducts1.DataBind();
            }
            else
            {
                if (Request.QueryString["search"] == null)
                {
                    titleproducts1.Text = "Thức ăn cho chó";
                    titleproducts2.Text = "Thức ăn cho mèo";
                    titleproducts3.Text = "Phụ kiện chó mèo";
                    List<DsSanPham> arr = (List<DsSanPham>)Application["sanpham"];
                    List<DsSanPham> arrListViewProducts1 = new List<DsSanPham>();
                    List<DsSanPham> arrListViewProducts2 = new List<DsSanPham>();
                    List<DsSanPham> arrListViewProducts3 = new List<DsSanPham>();
                    foreach (DsSanPham sp in arr)
                    {
                        int id = Int32.Parse(sp.id);
                        if (id == 9 || id == 10 || id == 11 || id == 12 || id == 13 || id == 14 || id == 15 || id == 16)
                        {
                            arrListViewProducts1.Add(sp);
                        }
                        if (id == 25 || id == 26 || id == 27 || id == 28 || id == 29 || id == 30 || id == 31 || id == 32)
                        {
                            arrListViewProducts2.Add(sp);
                        }
                        if (id == 33 || id == 34 || id == 35 || id == 36 || id == 37 || id == 38 || id == 39 || id == 40)
                        {
                            arrListViewProducts3.Add(sp);
                        }
                    }
                    ListViewProducts1.DataSource = arrListViewProducts1;
                    ListViewProducts1.DataBind();

                    ListViewProducts2.DataSource = arrListViewProducts2;
                    ListViewProducts2.DataBind();

                    ListViewProducts3.DataSource = arrListViewProducts3;
                    ListViewProducts3.DataBind();

                }
                else
                {
                    string search = Request.QueryString["search"];
                    string typesearch = " ";
                    if (search == "chó") { typesearch = "1"; }
                    else if (search == "mèo") { typesearch = "2"; }
                    else if (search == "phụ kiện") { typesearch = "3"; }
                    else
                    {
                        titleproducts1.Text = "Kết quả tìm kiếm";
                        List<DsSanPham> arr = (List<DsSanPham>)Application["sanpham"];
                        List<DsSanPham> arr1 = new List<DsSanPham>();
                        foreach (DsSanPham sp in arr)
                        {
                            string s = sp.name.IndexOf(search).ToString();
                            if (s != "-1") { arr1.Add(sp); }
                        }
                        ListViewProducts1.DataSource = arr1;
                        ListViewProducts1.DataBind();
                        return;
                    }
                    titleproducts1.Text = "Kết quả tìm kiếm";
                    List<DsSanPham> arr2 = (List<DsSanPham>)Application["sanpham"];
                    List<DsSanPham> arr3 = new List<DsSanPham>();
                    foreach (DsSanPham sp in arr2) { if (sp.type == typesearch) { arr3.Add(sp); } }
                    ListViewProducts2.DataSource = arr3;
                    ListViewProducts2.DataBind();
                    return;
                }
            }
            //sapxep();
        }

        private void sapxep()
        {
            List<DsSanPham> arrsp = (List<DsSanPham>)Application["sanpham"];

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