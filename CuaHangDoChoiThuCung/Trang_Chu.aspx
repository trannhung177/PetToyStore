<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trang_Chu.aspx.cs" Inherits="CuaHangDoChoiThuCung.Trang_Chu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cửa hàng đồ chơi thú cưng</title>
    <link href="css/StyleSheet.css" rel="stylesheet" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main">
		<div class="header" id="topp">
				<div class="logo">
					<a href="Trang_Chu.aspx#"><img src="img/Logo.PNG" width="250px" > </a>
				</div>
                    <div class="search">
                        <asp:TextBox ID="txtsearch" runat="server" placeholder="Nhập hãng sản phẩm muốn tìm..."></asp:TextBox>
                        <asp:Button ID="btnsearch" runat="server" Text="Tìm" CssClass="btn1" OnClick="btnsearch_Click" />
                       
				</div>
         
    
				<div id="loregisterlogin" runat="server">
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
		</div>
            
    
		<div class="brand-ads">
			<div class="brand" style="margin-left: 0px;">
				<ul>
				
					<li><a href="San_Pham.aspx?type=1" style="color: #cc9966;">  Shop cho chó</a></li>
					<li><a href="San_Pham.aspx?type=2" style="color: #cc9966;">  Shop cho mèo</a></li>
					
					
				</ul>
                <div class="ads5"><img src="img/Banner6.PNG" style="width:200px; height:394px;"></div>
			</div>
			<div class="ads">
				<div class="slide" style="width: 700px;">
                    <div class="chuyenslide">
                        <a href="San_Pham.aspx?type=1"><img src="img/Banner.PNG" style="height: 210px;width: 700px;"/></a>
                    </div>
				</div>
                
				<div class="ads4" style="margin-right: 0px;"><img src="img/Banner5.PNG" style="width:170px; height:458px;"></div>
				<div class="ads2"><img src="img/Banner2.PNG" style="height: 239px;width:345px;"></a></div>
				<div class="ads3"><img src="img/Banner3.PNG" style="height: 239px;width:345px;"></a></div>
				
			</div>
		</div>
		<hr><br>
		<div class="content">
			<center>
				<img src="img/Bán chạy.PNG" width="50px">
				<h3>TOP BÁN CHẠY</h3>
				<hr width="60px">
			</center>
			
				<div class="topbuy">
					<img src="img/pic1.PNG" width="100px">
					<h4> Yếm Teddy cho chó mèo</h4>
					<p>Giá : <strong>140.000đ</strong>  </p>
					<p>
						<button class="btnadd"><a href="ChiTietSanPham.aspx?id=1" style="color: white;">Tùy chọn</a></button>
					</p>
				</div>
				<div class="topbuy">
					<img src="img/pic2.PNG" width="100px"/>
					<h4> Nước hoa cho chó mèo</h4>
					<p>Giá : <strong>170.000đ</strong>  </p>
					<p>
						<button class="btnadd"><a href="ChiTietSanPham.aspx?id=2" style="color: white;">Tùy chọn</a></button>
					</p>
				</div>
                <div class="topbuy">
					<img src="img/pic3.PNG" width="100px"/>
					<h4>Áo vest bò Cowboy</h4>
					<p>Giá : <strong>160.000đ</strong>  </p>
					<p>
						<button class="btnadd"><a href="ChiTietSanPham.aspx?id=3" style="color: white;">Tùy chọn</a></button>
					</p>
				</div>
        </div>

       <div class="main-content">
                <h2 style="margin: 10px 0 10px 0;">Shop cho chó</h2>
			<hr />
                <div class="row">
                    <asp:ListView ID="ListViewNewProducts" runat="server">
                        <ItemTemplate>
                           <div class="col">
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
                </div>
            <h2 style="margin: 10px 0 10px 0;">Shop cho mèo</h2>
			<hr />
                <div class="row">
                    <asp:ListView ID="ListViewFeaturedProducts" runat="server">
                        <ItemTemplate>
                           <div class="col">
                                    <center>                   
                                    <a href="ChiTietSanPham.aspx?id=<%# Eval("id") %>">
                                        <img src="<%# Eval("images") %>" alt="" style="margin-top:15px; width:150px; height:180px;" />
                                    </a>
                                    <div>
                                        <p><%# Eval("name") %></p>
                                        <p><strong><%# Eval("price") %>đ</strong></p>                          
                                        
                                    </div>
                                    </center>   
                                </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
             
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
