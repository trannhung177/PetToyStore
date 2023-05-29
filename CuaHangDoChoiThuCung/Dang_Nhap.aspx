<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dang_Nhap.aspx.cs" Inherits="CuaHangDoChoiThuCung.Dang_Nhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
<link href="css/DangKy.css" rel="stylesheet" />
    <script lang="ja">
        function DangNhap()
        {
            var ten = document.getElementById("tk");
            var mk = document.getElementById("mk");

            var check = true;

            if (ten.value == "") {
                err_tendn.innerHTML = "Bạn chưa nhập tên đăng nhập";
                ten.focus();
                check = false;
            }
            if (mk.value=="") {
                err_mkhau.innerHTML = "Bạn chưa nhập mật khẩu";
                mk.focus();
                check = false;
            }
            return check;

        }

    </script>
</head>
<body>
    <div class="main">
        <form id="form1" class="form" runat="server" onsubmit="return DangNhap()">
            <div>
                <div>
                    ĐĂNG NHẬP
                </div>
                <div class="form-gruop">
                    <label for="tk" class="form-label">Tài khoản:*</label>
                    <input type="text" id="tk" name="tk" class="form-control" />
                    <div id="err_tendn"  runat="server" style="color: red"></div>
                </div>
                <div class="form-gruop">
                    <label for="mk" class="form-label">Mật khẩu:*</label>
                    <input type="password" id="mk" name="mk" class="form-control" />
                    <div id="err_mkhau" runat="server" style="color: red"></div>
                </div>
                <div class="form-gruop">
                    <input type="submit" value="ĐĂNG NHẬP" class="form-submit" />
                </div>
                <div>
                    Bạn chưa có tài khoản?<a href="Dang_Ky.aspx">Đăng ký</a>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
