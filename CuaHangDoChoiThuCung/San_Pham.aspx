<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="San_Pham.aspx.cs" Inherits="CuaHangDoChoiThuCung.San_Pham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sản phẩm</title>
	<link href="css/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="main">
		<div class="header" id="topp">
				<div class="logo">
					<a href="Trang_Chu.aspx#"><img src="img/Logo.PNG" width="250px" > </a>
				</div>
                    <div class="search">
                        <input name="ctl00$txtsearch" type="text" id="txtsearch" placeholder="Nhập hãng sản phẩm muốn tìm..." />
                        <input type="submit" name="ctl00$btnsearch" value="Tìm" id="btnsearch" class="btn1" />
                       
				</div>
         
    
				<div id="loregisterlogin">
                    <a href="Dang_Nhap.aspx" style="font-size: 15px ;color: #cc9966;">Đăng nhập</a>
                    <span>|</span>
                    <a href="Dang_Ky.aspx" style="font-size: 15px;color: #cc9966"> Đăng ký</a> 
				</div>	
				
				<div class="cart" style="padding:6px 0 6px 6px;">
						<img src="img/GioHang.PNG" width="25px">
						<a href="Gio_Hang.aspx" style="color: #cc9966;">Giỏ hàng</a>
                        <span style="color:#cc9966; background:#f5f5f5; border:none;border-radius: 5px 5px 5px 5px; padding:0 5px 0 5px; margin-left: 15px;">
                            <asp:Label ID="TotalPrice" runat="server" Text="Label"></asp:Label> ₫</span>
				</div>
		</div>
		<div class="header-sub">
				<div class="list" style="margin-left: 0px;">
					<img src="img/list.png" width="18px">
					<a href="">Danh mục sản phẩm</a>
				</div>
				<div class="menu">
					<ul>
						<li><a href="Trang_Chu.aspx#">Trang Chủ</a></li>
						<li><a href="#ft">Giới Thiệu</a></li>
						<li><a href="San_Pham.aspx#">Sản Phẩm</a></li>
						<li><a href="#">Tin Tức</a></li>
						<li><a href="#">Liên Hệ</a></li>
					</ul>
				</div>
			<a href="SanPham.aspx"><img src="img/Banner7.PNG" style="height: 290px;width: 1100px;"/></a>
		</div>

            
     <h3 style="
                        border: 1px solid grey;
                        border-radius: 0 50px 50px 0;
                        background-color: whitesmoke;
                        width: 345px;
                        padding-top: 1px;
                        margin-top: 10px;
                        margin-bottom: 10px;">
                <asp:Label ID="titleproducts1" runat="server" Text="Label"></asp:Label></h3>
            <div class="rowSP" >
                
                <form id="formproducts1">
                    <asp:ListView ID="ListViewProducts1" runat="server">
                        <ItemTemplate>
                           <div class="colSP" >
                                    <center>                   
                                    <a href="ChiTietSanPham.aspx?id=<%# Eval("id") %>">
                                        <img src="<%# Eval("images") %>" alt="" style="margin-top:5px; width:150px; height:180px;" />
                                    </a>
                                    <div>
                                        <p><%# Eval("name") %></p>
                                        <p><strong><%# Eval("price") %>đ</strong></p>     
                                    </div>
                                    </center>   
                                </div>
                        </ItemTemplate>
                    </asp:ListView>
                </form>
            </div>

			<h3 style="
                        border: 1px solid grey;
                        border-radius: 0 50px 50px 0;
                        background-color: whitesmoke;
                        width: 345px;
                        padding-top: 1px;
                        margin-top: 10px;
                        margin-bottom: 10px;">
                <asp:Label ID="titleproducts2" runat="server" Text="Label"></asp:Label></h3>
            <div class="rowSP" >
                
                <form id="formproducts2">
                    <asp:ListView ID="ListViewProducts2" runat="server">
                        <ItemTemplate>
                           <div class="colSP" >
                                    <center>                   
                                    <a href="ChiTietSanPham.aspx?id=<%# Eval("id") %>">
                                        <img src="<%# Eval("images") %>" alt="" style="margin-top:5px; width:150px; height:180px;" />
                                    </a>
                                    <div>
                                        <p><%# Eval("name") %></p>
                                        <p><strong><%# Eval("price") %>đ</strong></p>     
                                    </div>
                                    </center>   
                                </div>
                        </ItemTemplate>
                    </asp:ListView>
                </form>
            </div>

             <h3 style="
                        border: 1px solid grey;
                        border-radius: 0 50px 50px 0;
                        background-color: whitesmoke;
                        width: 345px;
                        padding-top: 1px;
                        margin-top: 10px;
                        margin-bottom: 10px;">
                <asp:Label ID="titleproducts3" runat="server" Text="Label"></asp:Label></h3>
            <div class="rowSP" >
                
                <form id="formproducts3">
                    <asp:ListView ID="ListViewProducts3" runat="server">
                        <ItemTemplate>
                           <div class="colSP" >
                                    <center>                   
                                    <a href="ChiTietSanPham.aspx?id=<%# Eval("id") %>">
                                        <img src="<%# Eval("images") %>" alt="" style="margin-top:5px; width:150px; height:180px;" />
                                    </a>
                                    <div>
                                        <p><%# Eval("name") %></p>
                                        <p><strong><%# Eval("price") %>đ</strong></p>     
                                    </div>
                                    </center>   
                                </div>
                        </ItemTemplate>
                    </asp:ListView>
                </form>
            </div>
   
		<div class="pre-footer">
			
		</div>
        <hr />

    <footer id="ft">
            <ul style="width: 1090px;padding-top: 45px;margin-bottom: 0px;">
                <li>
                    <div class="text">
                    <h4>Hỗ trợ</h4>
                    <hr style="width: 193px;">
                    <div>
                        Hướng dẫn mua hàng
                        <br>
                        Điều khoản dịch vụ
                        <br>
                        Hướng dẫn thanh toán
                        <br />
                        </div>
                    </div>
                </li>
                <li>
                    <div class="text">
                    <h4>Tin tức</h4>
                    <div>
                        <hr>
                        Trong một số trường hợp bạn nhận nuôi một chú mèo hoặc có thể chúng sống cùng mẹ,
                        chúng đều phải cai sữa đúng cách nhằm giúp mèo con phát triển một cách tốt nhất...
                    <a href="#">Read more</a></div>
                    </div>
                </li>
                <li>
                    <div class="text">
                    <h4>Thời gian mở cửa</h4>
                    <div>
                        <hr style="width: 193px;">
                    Monday - Friday: 8h - 22h
                    <br>
                    Saturday & Sunday: 9h - 23h
                    <br>
                    </div>
                    </div>
                </li>
                <li>
                    <div class="text" >
                    <h4>Liên hệ</h4>
                    <div>
                    <hr style="width: 168px;">
                    Phone: 0987654321
                    <br>
                    Email: famipet@gmail.com
                    <br>
                    Address: 96 Định Công
                    </div>
                    </div>
                </li>
                <a href="#topp" style="float:right;"><img src="img/Back.PNG" width="50px" /></a>   
            </ul>
    </footer>
        </div>
    </form>
</body>
</html>
