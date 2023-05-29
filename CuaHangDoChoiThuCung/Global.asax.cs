using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CuaHangDoChoiThuCung
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["nguoidung"] = new List<DsNguoiDung>();
            Application["sanpham"] = new List<DsSanPham>();
            Application["giohang"] = new List<DsSanPham>();


            List<DsSanPham> dsSanPham = new List<DsSanPham>();
            // Shop cho chó
            dsSanPham.Add(new DsSanPham() { id = "1", name = "Sữa Bột Predogen 110g", price = "160000", images = "img/pic6.PNG", detail = "Sữa bột dành cho chó PREDOGEN được sản xuất theo công thức của WONDERLIFE PHARMA  (mỹ) là một thực phẩm bổ dưỡng cho chó yêu của bạn ngoài những thức ăn thông thường, giúp chó yêu cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "2", name = "Thức ăn khô 1kg", price = "100000", images = "img/pic7.PNG", detail = "Sản phẩm Thức Ăn Khô Cho Chó Con Smart Heart Gold Puppy 1kg là loại thức ăn hạt dành riêng cho chó nhỏ tầm dưới 12 tháng tuổi. Dòng sản phẩm SmartHeart đang ngày càng được ưa chuộng trong cộng đồng thú cưng vì hương vi thơm ngon, dễ ăn và được các bé cún yêu thích.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "3", name = "Dụng cụ lấy lông chó mèo", price = "145000", images = "img/pic8.PNG", detail = "Với những người nuôi chó mèo, việc lông thú rải khắp nơi là điều không thể tránh khỏi. Lông thú cưng rơi vào quần áo, dính vào đồ dùng gây bất tiện cho chủ nhân, lại mất vệ sinh. Vì vậy, xử lý những đám lông rơi vãi khắp nơi chính là điều ai cũng muốn! Hiểu được nỗi niềm đó, sản phẩm Dụng Cụ Lấy Lông Chó Mèo Bám Dính đã ra đời để giải quyết vấn đề này giúp bạn! ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "4", name = "Kính thời trang thú cưng", price = "35000", images = "img/pic9.PNG", detail = "Kính Thời Trang Cho Thú Cưng chính là sản phẩm hot nhất mùa hè này! Trời chuyển hè, những tia nắng gắt có thể chiếu vào mắt các bạn thú cưng. Vì vậy hãy bảo vệ đôi mắt của các bé bằng cách đeo Kính Thời Trang Cho Thú Cưng. Không chỉ là sản phẩm giúp bảo vệ mắt mà còn giúp các bạn chó mèo hết sức thời thượng! ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "5", name = "Sữa tắm cho chó", price = "120000", images = "img/pic10.PNG", detail = "Sữa tắm SOS dành cho chó lông trắng với nhiều công dụng ưu việt được xuất xứ từ Đài Loan. Có lợi thế chỗ đứng lâu năm trên thị trường cùng sự nghiên cứu tìm tòi không ngừng cải tiến của đội ngũ chuyên gia. Sữa tắm SOS được đánh giá là một trong những dòng sữa tắm tốt nhất cho chó hiện nay.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "6", name = "Áo sọc vằn mùa hè", price = "85000", images = "img/pic11.PNG", detail = "Áo Mùa Hè Teddy Sọc Cho Chó Mèo được làm từ những chất liệu vải khô thoáng nhất. Chủ yếu là từ vải cotton giúp thấm mồ hôi hiệu quả. Đồng thời, trong những ngày thời tiết mùa hè thì sản phẩm này sẽ giúp trao đổi không khí, khiến thú cưng thấy dễ chịu, mát mẻ hơn. ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "7", name = "Khay vệ sinh cho chó", price = "110000", images = "img/pic12.PNG", detail = "Được thiết kế dành riêng cho cún đi vệ sinh, nên hộp đi vệ sinh cho bên mình nhập về có kiểu dáng bắt mắt, chất lượng nhựa bền, đẹp.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "8", name = "Túi xách đa năng", price = "250000", images = "img/pic13.PNG", detail = "Bạn muốn đi chơi xa mà muốn mang bé cưng của mình đi theo ư? Bạn lo lắng không biết cho bé cưng vào đâu mà tiện lợi lại không làm chó mèo khó chịu?? Giờ đây đã có sản phẩm túi xách lưới vận chuyển chó mèo siêu tiện lợi.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "9", name = "Pate thịt heo Tellme 130g", price = "20.000", images = "img/pic22.PNG", detail = "Pate Gan Thịt Heo Cho Chó TXúc xích Tellme cho chó là món ăn vô cùng yêu thích của những chú chó. Không chỉ có mùi vị thơm ngon, món ăn còn cung cấp chất dinh dưỡng, vitamin thiết yếu để thú cưng của bạn phát triền toàn diện. llme 130g là món ăn vô cùng yêu thích của những chú chó. Không chỉ có mùi vị thơm ngon, món ăn còn cung cấp chất dinh dưỡng, vitamin thiết yếu để thú cưng phát triền toàn diện. ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "10", name = "Xúc xích Tellme", price = "50000", images = "img/pic23.PNG", detail = "Xúc xích Tellme cho chó là món ăn vô cùng yêu thích của những chú chó. Không chỉ có mùi vị thơm ngon, món ăn còn cung cấp chất dinh dưỡng, vitamin thiết yếu để thú cưng của bạn phát triền toàn diện.  ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "11", name = "Gan bò sấy 75gr", price = "30000", images = "img/pic24.PNG", detail = "Gan bò sấy cho chó mèo Tellme là món ăn vô cùng yêu thích của những chú chó, mèo. Không chỉ có mùi vị thơm ngon, món ăn còn cung cấp chất dinh dưỡng, vitamin thiết yếu để thú cưng của bạn phát triền toàn diện. ", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "12", name = "Thức ăn hạt hữu cơ 2kg", price = "230000", images = "img/pic25.PNG", detail = "Thức ăn hạt ANF được làm từ rau củ, thịt rõ nguồn gốc với nguồn nguyên liệu được trồng và nuôi dưỡng theo phương pháp hữu cơ hiện đại. Sản phẩm được nhập khẩu trực tiếp từ Hàn Quốc, đảm bảo an toàn thực phẩm, đảm bảo dinh dưỡng nhất đủ chất cho cún yêu của bạn!", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "13", name = "Thức ăn hạt mềm 1.2kg", price = "200000", images = "img/pic26.PNG", detail = "Thức Ăn Khô Hạt Mềm Chó Con Zenith Puppy 1.2kg là thực phẩm bán ẩm nên không cần phải ngâm vào nước như các thực phẩm khác. Sản phẩm là loại thức ăn hạt mềm, nên rất dễ dàng tiêu hóa, đồng thời tạo cảm giác ngon miệng tuyệt vời dành cho chó con.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "14", name = "Thức ăn khô vị gà", price = "150000", images = "img/pic27.PNG", detail = "Sản phẩm thức ăn khô cho chó con này cung cấp đầy đủ lượng chất dinh dưỡng cần thiết để chú chó phát triển một cách toàn diện. Một túi Pedigree Puppy Chicken, Egg & Milk 1,5kg có chứa các chất dinh dưỡng như: vitamin E, Protein, Canxi, Phốt pho và các khoáng chất thiết yếu.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "15", name = "Thức ăn khô vị bò", price = "170000", images = "img/pic28.PNG", detail = "Thức Ăn Khô SmartHeart Cho Chó Trưởng Thành Vị Thịt Bò Nướng 1.5Kg dành cho chó trưởng thành phát triển nhằm đáp ứng hoặc vượt qua các tiêu chuẩn dinh dưỡng thức ăn cho chó AAFCO để duy trì cho chó trưởng thành đước thiết lập bởi hiệp hội thức ăn chăn nuôi Hoa Kì.", type = "1" });
            dsSanPham.Add(new DsSanPham() { id = "16", name = "Thức ăn khô SmartHeart", price = "1200000", images = "img/pic29.PNG", detail = "Thương hiệu thức ăn cho chó SmartHeart thuộc sở hữu của tập đoàn Perfect Companion – Thái Lan, đang dần khẳng định vị trí và có chỗ đứng vững trên thị trường hiện nay. Chất lượng sản phẩm của Smartheart luôn được đặt lên hàng đầu với việc nâng cao chất lượng sản phẩm, thành phần dinh dưỡng đa dạng, có nhiều loại thức ăn dành cho các lứa tuổi của chó từ chó nhỏ cho đến chó trưởng thành.", type = "1" });

            // Shop cho mèo
            dsSanPham.Add(new DsSanPham() { id = "17", name = "Thức ăn khô vị bò", price = "122000", images = "img/pic14.PNG", detail = "Sản phẩm thức ăn khô cho chó con này cung cấp đầy đủ lượng chất dinh dưỡng cần thiết để chú chó phát triển một cách toàn diện. Một túi Pedigree Puppy Chicken, Egg & Milk 1,5kg có chứa các chất dinh dưỡng như: vitamin E, Protein, Canxi, Phốt pho và các khoáng chất thiết yếu.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "18", name = "Cát vệ sinh Catlike", price = "110000", images = "img/pic15.PNG", detail = "Cát Vệ Sinh Catlike Hương Cà Phê 15l là sản phẩm cát vệ sinh cho mèo rất an toàn. Được làm từ thành phần tự nhiên, không độc hại cho mèo, đảm bảo an toàn vệ sinh. Với nguồn gốc, xuất xứ rõ ràng, được nhiều bạn lựa chọn, sản phẩm này giúp việc dọn vệ sinh cho mèo dễ dàng hơn.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "19", name = "Sữa bột Precaten", price = "250000", images = "img/pic16.PNG", detail = "Sữa bột dành cho Mèo PRECATEN được sản xuất theo công thức của WONDERLIFE PHARMA (Mỹ) là một thực phẩm bổ dưỡng cho mèo yêu của bạn. ngoài những thức ăn thông thường, sữa giúp bé mèo cảm thấy ngon miệng hơn, bồi bổ cơ thể và cung cấp những thứ cần thiết để phát triển toàn diện.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "20", name = "Balo phi hành gia", price = "350000", images = "img/pic17.PNG", detail = " Ba lô Phi Hành Gia Vận Chuyển Chó Mèo là một sản phẩm hoàn toàn mới. Đây là sản phẩm dành riêng cho thú cưng của bạn với một không gian thú vị và an toàn hơn cho vật nuôi. Cho phép thú cưng tận hưởng ánh nắng mặt trời, phong cảnh và tương tác với thế giới bên ngoài.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "21", name = "Sữa tắm mượt lông mèo", price = "80000", images = "img/pic18.PNG", detail = "Sữa Tắm Mượt Lông Cho Chó Mèo Bio Jolie 500ml an toàn và dịu nhẹ, phù hợp sử dụng với cả chó và mèo. Với các thành phần dưỡng chất như: Vitamin E, vitamin B6, Poliquaternium, D – Panthenol,… Không chỉ giúp dưỡng lông siêu mượt mà còn giúp khử mùi hôi một cách hiệu quả.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "22", name = "Khay vệ sinh", price = "116000", images = "img/pic19.PNG", detail = "Khay Vệ Sinh Cho Mèo là sản phẩm dùng để giúp huấn luyện mèo đi vệ sinh đúng chó. Phù hợp với tất cả loại mèo và giống mèo. Với những bé mèo con thì hình thành thói quen đi vệ sinh đúng chỗ là rất quan trọng. Điều này sẽ giúp bạn không phải vất vả dọn vệ sinh cho mèo về sau. Bên cạnh đó, sản phẩm Khay Vệ Sinh Cho Mèo có thiết kế thông minh, tiện lợi sẽ giúp ích cho bạn khi dọn vệ sinh cho mèo. ", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "23", name = "Xịt khử mùi Bulde", price = "150000", images = "img/pic20.PNG", detail = "Với công dụng chính là khử mùi của chó mèo, Xịt Khử Mùi Dưỡng Lông Budle Budle Cho Chó Mèo có thể dùng để khử mùi nơi ngủ và các vật dụng khác của thú cưng. Hơn nữa còn có tác dụng khử trùng, kháng khuẩn, loại bỏ hoàn toàn các vi khuẩn, nấm hay ký sinh gây hai.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "24", name = "Bát đựng thức ăn mèo", price = "35000", images = "img/pic21.PNG", detail = "Sản phẩm Bát Nhựa Đôi Vuông Cho Chó Mèo chính là giải pháp trong việc ăn uống của thú cưng. Các loại Bát Nhựa Đôi Vuông Cho Chó Mèo đều được làm từ những chất liệu an toàn, đảm bảo phù hợp với thú cưng. Sản phẩm không chứa chất độc hại, không có màu hoá học, rất an toàn cho chó mèo sử dụng. ", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "25", name = "Gan bò sấy 75gr", price = "30000", images = "img/pic30.PNG", detail = "Sản phẩm được chế biến từ những nguyên liệu đảm bảo an toàn cho chó, mèo. Không sử dụng các chất bảo quản, phụ gia. Thú cưng của bạn sẽ lớn khoẻ, phát triển cân bằng sau khi sử dụng.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "26", name = "Hộp súp thưởng 36 gói", price = "325000", images = "img/pic31.PNG", detail = "Bánh Thưởng Dạng Kem – MeO Creamy Treats ngon tuyệt hảo, giàu dưỡng chất giúp mèo ăn ngon miệng, mau lớn. Đây là món ăn nhẹ thơm ngon với hương vị cá ngừ thơm ngon. Nó giúp cho những chú mèo nhà bạn trở nên năng động và hoạt bát hơn.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "27", name = "Thức ăn hạt Catsrang 1kg", price = "95000", images = "img/pic32.PNG", detail = "Bột thịt gà ngụ ý về thịt gà, da gà, xương gà, hoặc nội tạng. Tất cả được đưa vào ép và nấu ở nhiệt độ cao để loại bỏ nước và thu về thịt gà cô đặc với tỉ lệ khoảng 70% protein, >10% béo và một lượng nhỏ axit amin, hầu hết vi khuẩn vi rút cũng bị loại bỏ trong quá trình nấu này.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "28", name = "Thức ăm hạt Catsrang 5kg", price = "225000", images = "img/pic33.PNG", detail = "Bột thịt gà ngụ ý về thịt gà, da gà, xương gà, hoặc nội tạng. Tất cả được đưa vào ép và nấu ở nhiệt độ cao để loại bỏ nước và thu về thịt gà cô đặc với tỉ lệ khoảng 70% protein, >10% béo và một lượng nhỏ axit amin, hầu hết vi khuẩn vi rút cũng bị loại bỏ trong quá trình nấu này.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "29", name = "Bánh thưởng vị cá hồi", price = "45000", images = "img/pic34.PNG", detail = "Sản phẩm Bánh Thưởng Dạng Kem Me-O Vị Cá Hồi là kết quả của các chuyên gia đến từ Thái Lan. Được nhập khẩu tại Thái Lan, với chất lượng an toàn. Đây là 1 dòng sản phẩm thuộc thương hiệu Me-O rất quen thuộc với chúng ta rồi! Me-O là thương hiệu có nguồn gốc từ Thái Lan, chuyên sản xuất các sản phẩm dành cho mèo. ", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "30", name = "Thức ăn khô cho mèo Eye", price = "150000", images = "img/pic35.PNG", detail = "Thức Ăn Khô Cho Mèo Cat Eye 1.5Kg được phối trộn đặc biệt dành cho mèo mọi lứa tuổi để giảm chứng rụng lông, cải thiện bộ lông mèo và cải thiện tiêu hóa. Với những thành phần dễ tiêu hóa và cực kỳ ngon miệng sẽ giúp tăng cường hệ thống miễn dịch, cải thiện khả năng hấp thụ dinh dưỡng, tăng cường sức khỏe đại tràng và giảm lãng phí thức ăn ăn vào của mèo.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "31", name = "Thức ăn cho mèo WhisKas", price = "60000", images = "img/pic36.PNG", detail = "Thức Ăn Cho Mèo Con Whiskas Junior 450g được chế biến từ cá nguồn nguyên liệu cá Hồi, cá Thu,...giàu dinh dưỡng, hương vị yêu thích của họ nhà Mèo. Hàm lượng dinh dưỡng trong sản phẩm thức ăn dành cho Mèo Whiskas, đảm bảo cung cấp đủ những dưỡng chất cần thiết cho sự phát triển của những chú Mèo.", type = "2" });
            dsSanPham.Add(new DsSanPham() { id = "32", name = "Pate Royal Canin", price = "35000", images = "img/pic37.PNG", detail = "Đây là sản phẩm thuộc loại thức ăn ướt cho mèo, kích thích sự thèm ăn của mèo. Và bổ sung dinh dưỡng tốt nhất cho bé. Thực phẩm bổ sung Royal Canin Intense Beauty Gravy với công thức tạo ra với sự cân bằng tối ưu giữa các protein, chất béo và carbohydrate để hỗ trợ sự ngon miệng, bổ sung dinh dưỡng hoàn hảo và đặc biệt là chăm sóc da và lông mèo khỏe đẹp. Các công thức của ROYAL CANIN được tạo ra với sự cân bằng tối ưu giữa các protein, chất béo và carbohydrate để hỗ trợ sự ngon miệng, bổ sung dinh dưỡng hoàn hảo.", type = "2" });

            // Phụ kiện chó mèo
            dsSanPham.Add(new DsSanPham() { id = "33", name = "Vòng cổ nơ", price = "30000", images = "img/pic38.PNG", detail = "Xuất xứ: Thượng Hải Chất liệu: Vải,lục lạc bằng đồng. Các chất liệu được sử dụng đều rất an toàn,phù hợp với thú cưng. Đảm bảo chó mèo có thể sử dụng mà không bị ảnh hưởng tới sức khoẻ.Nguồn gốc xuất xứ cũng rõ ràng. Sản phẩm có sẵn và được bán với giá tốt nhất tại siêu thị thú cưng FamiPet. ", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "34", name = "Vòng cổ cao cấp", price = "160000", images = "img/pic39.PNG", detail = "Xuất xứ: Thượng Hải Chất liệu: Dây đồng , ngọc trai nhựa,lục lạc đồng Màu sắc: Đa dạng", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "35", name = "Vòng cổ thời trang", price = "65000", images = "img/pic40.PNG", detail = "Vòng Cổ Nơ Thời Trang Cho Thú Cưng sử dụng các chất liệu đều rất an toàn, phù hợp với thú cưng. Đảm bảo chó mèo có thể sử dụng mà không bị ảnh hưởng tới sức khoẻ. Nguồn gốc xuất xứ cũng rõ ràng. ", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "36", name = "Cây cào móng nhỏ cho mèo", price = "155000", images = "img/pic41.PNG", detail = "Chú mèo nào cũng có sở thích cào đồ vật. Một phần để chúng luyện móng, một phần chúng rất có hưng thú với việc đó. Chính vì vậy, việc sắm một Cây Cào Móng Nhỏ Cho Mèo sẽ cho mèo những giờ chơi vui vẻ và bạn cũng có thể bảo vệ các đồ dùng của mình tốt hơn.", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "37", name = "Yếm lưới kèo dây dắt", price = "100000", images = "img/pic42.PNG", detail = "Bạn không thể quản lý được những chú chó hay nhưng chú mèo tăng động luôn thích chạy nhảy khắp nơi. Bộ Đai yếm lưới kèm dây dắt 1m2 cho Chó Mèo sẽ là sự lựa chọn rất tốt cho bạn.Sản phẩm không làm đau mà lại dễ dàng giúp bạn quản lý thú cưng hơn.", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "38", name = "Dây dắt tròn", price = "60000", images = "img/pic43.PNG", detail = "Tiện lợi, dễ sử dụng: Dây dắt chó kèm yếm. ngực và tay cầm trợ lực là sản phẩm thích hợp để thú cưng luôn bên bạn. Bạn có thể thoải mái dạo bộ, đi chơi, đi mua sắm… và có những phút giây thư giãn mà không lo phải luôn để mắt đến thú nuôi của mình bị chạy lạc mất hoặc đơn giản là không ở trong vòng kiểm soát của bạn. ", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "39", name = "Dây dắt yếm 2.5cm", price = "70000", images = "img/pic44.PNG", detail = "Thỉnh thoảng bạn muốn đưa thú cưng của mình đi chơi. Bạn không thể quản lý được những chú chó hay nhưng chú mèo tăng động luôn thích chạy nhảy khắp nơi. Dây Dắt Yếm 2.5cm Cho Chó Mèo sẽ là sự lựa chọn rất tốt cho bạn. Sản phẩm không làm đau mà lại dễ dàng giúp bạn quản lý thú cưng hơn.", type = "3" });
            dsSanPham.Add(new DsSanPham() { id = "40", name = "Dây dắt tự động chó mèo", price = "95000", images = "img/pic45.PNG", detail = "Cho chó mèo đi dạo là điều mà các bạn đều cần làm. Đi dạo 10 - 15 phút mỗi ngày sẽ giúp các bạn khoẻ mạnh hơn, vận động nhiều hơn. Chắc chắn cho thú cưng đi dạo bạn sẽ cần đến các sản phẩm dây dắt rồi. Và với Dây Dắt Tự Động Cho Chó Mèo, việc dắt thú cưng đi dạo sẽ trở nên dễ dàng hơn bao giờ hết! Cùng FamiPet tìm hiểu thêm về sản phẩm này ngay sau đây.", type = "3" });


            Application["sanpham"] = dsSanPham;
        
        }

        protected void Session_Start(object sender, EventArgs e)
        {

            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}