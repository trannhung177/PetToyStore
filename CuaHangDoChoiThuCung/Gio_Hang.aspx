<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gio_Hang.aspx.cs" Inherits="CuaHangDoChoiThuCung.Gio_Hang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giỏ Hàng</title>
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

            
    <h2 style="margin-top:10px;">Giỏ hàng của bạn: <small class="pull-right"><asp:Label ID="TotalProduct" runat="server" Text="Label"></asp:Label> sản phẩm </small></h2>
    <br />
    <center>
        <hr>
    <table style="margin: 10px 0 150px 0; border:2px solid black;">
                    <thead>
                        <tr>
                            <th>Sản phẩm</th>
                            <th style="width:230px">Tên sản phẩm</th>
                            <th style="width:72px">Mô tả</th>
                            <th style="width:115px">Giá</th>
                            <th style="width:131px">Thành tiền</th>
                        </tr>
                    </thead>
                    
        
                    <tbody>
                        <asp:ListView ID="DsGiohang" runat="server">
                            <LayoutTemplate>
                                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <img width="100" src="<%# Eval("images") %>" alt=""></td>
                                    <td><p ><%# Eval("name") %></p></td>
                                    <td><a href="ChiTietSanPham.aspx?id=<%# Eval("id") %>">Chi tiết</a> </td>
                                    <td><%# Eval("price") %>đ</td>
                                     <td><%# Eval("price") %>đ</td>
                                    <td>
                                        <div class="input-append">
                                            <asp:Button runat="server" CssClass="btn btn-mini btn-danger" CommandArgument='<%# Eval("id") %>' Text="X" OnClick="btnRemove_Click" />
                                        </div>
                                    </td>
                                   
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                        <tr>
                            <td colspan="5" class="alignR">Tổng tiền :	</td>
                            <td><asp:Label ID="TotalPriceProduct" runat="server" Text="Label"></asp:Label>đ</td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
        </center>
   
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
