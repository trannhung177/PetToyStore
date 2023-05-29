<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dang_Ky.aspx.cs" Inherits="CuaHangDoChoiThuCung.Dang_Ky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký</title>
    <link href="css/DangKy.css" rel="stylesheet" />
    <script lang="ja" >
        function dangKy()
        {
            var ten = document.getElementById("tendn");
            var email = document.getElementById("email");
            var MK = document.getElementById("matkhau");
            var reMK = document.getElementById("re-password");
            var check = true;
            if (ten.value=="") {
                err_tenĐN.innerHTML = "Bạn chưa nhập tên";
                ten.focus();
                check = false;
            }
            if (email.value=="") {
                err_email.innerHTML = "Bạn chưa nhập email";
                email.focus();
                check=false
            } else {
                if (email.indexOf("@gmail.com")<0) {
                    err_email.innerHTML = "email không đúng định dạng";
                    email.focus();
                    check = false;
                } else {

                }
            }
            if (MK.value=="") {
                err_MK.innerHTML = "Bạn chưa nhập mật khẩu";
                MK.focus();
                check = false;
            }
            if (reMK.value == "") {
                err_MK.innerHTML = "Bạn chưa nhập mật khẩu";
                MK.focus();
                check = false;
            }
            return check;
        }
    </script>
</head>
<body>
    <div class="main">
    <form id="form1" class="form" onsubmit="return dangKy()" runat="server" method="post" >
        <asp:Label ID="err" style="color:red;" runat="server"></asp:Label>
    <div>
        <h1>ĐĂNG KÝ</h1>
        <div class="form-gruop">
            <label for="tendn" class="form-label">Tên đăng nhập:*</label>
            <input type="text" id="tendn" name="tendn" class="form-control" />
            <div id="err_tenĐN" style="color: red"></div>
        </div>
        <div class="form-gruop">
            <label for="email" class="form-label">Email:*</label>
            <input type="text" id="email" name="email" placeholder="VD:...@gmail.com" class="form-control" />
            <div id="err_email" style="color: red"></div>
        </div>
        <div class="form-gruop">
            <label for="matkhau" class="form-label">Mật khẩu:*</label>
            <input type="password" id="matkhau" placeholder="VD:123456789" name="matkhau" class="form-control" />
            <div id="err_MK" style="color: red"></div>
        </div>
        <div class="form-gruop">
            <label for="re-password" class="form-label">Xác nhận mật khẩu</label>
            <input type="password" id="re-password" placeholder="Nhập lại mật khẩu" name="re-password" class="form-control"/>
            <div id="err_reMK" style="color: red"></div>
        </div>
        <br />
        <br />
        <div>
            <input type="submit" id="dangky" name="dangky" value="Đăng ký" class="form-submit" />
        </div>
        <div>
            Bạn có tài khoản chưa?<a href="Dang_Nhap.aspx">Đăng nhập</a>
        </div>
    </div>
    </form>
    </div>
</body>
</html>
