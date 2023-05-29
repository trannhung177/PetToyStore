using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuaHangDoChoiThuCung
{
    public partial class Dang_Nhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["tk"] != null)
            {
                string tk = Request.Form["tk"];
                string mk = Request.Form["mk"];
                int dem = 0;
                if (tk != "" && mk != "")
                {
                    List<DsNguoiDung> users = (List<DsNguoiDung>)Application["nguoidung"];

                    foreach (DsNguoiDung user in users)
                    {
                        if (tk == user.name)
                        {
                            dem = 1;
                            if (mk == user.password)
                            {
                                Session["taikhoan"] = tk;
                                Response.Redirect("Trang_chu.aspx");
                                break;
                            }
                            else
                            {
                                err_mkhau.InnerHtml = "Sai mật khẩu";
                                break;
                            }
                        }
                    }
                    if (dem == 0)
                    {
                        err_tendn.InnerHtml = "Không tồn tại tài khoản ";
                    }
                }
            }

        }
    }
}