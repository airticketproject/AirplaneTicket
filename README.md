# AirPlane Ticket Management (C#)

### Đồ án môn Nhập môn công nghệ phần mềm lớp SE104.J23.PMCL - Khoa công nghệ phần mềm - Trường Đại học Công ghệ thông tin(UIT)

### Giảng viên hướng dẫn: Thầy Nguyễn Công Hoan

## Đồ án và các chức năng
  - Tên đồ án: Quản lí bán vé chuyến bay
  - Các chức năng
  
    ![Chức năng của websỉte](https://i.imgur.com/MrQpu5I.jpg)
## Công nghệ sử dụng
  - SQL Server
  - C#
## Kiến trúc của đồ án
  - Mô hình 3 lớp (3 LAYERS - 1PC)
    ![Kiến trúc](https://i.imgur.com/qRxgyHW.jpg)
  - Sơ đồ lớp 
    ![Kiến trúc](https://i.imgur.com/Q9Ztumb.png)

## Khảo sát hiện trạng
1. Đối nội

    ![Đối nội](https://i.imgur.com/2udj1fE.png)

  - Trụ sở chính: chia thành 2 phòng ban
    +	Phòng marketing: xây dựng các kế hoạch marketing cho công ty
    +	Phòng bán vé: phụ trách việc bán vé trực tiếp tại trụ sở chính
-	Hệ thống trực tuyến: chia làm 2 hệ thống
    +	Hệ thống đặt vé trực tuyến: hệ thống trang web được công ty đặt hàng từ bên thứ 3.
    +	Hệ thống marketing online: được công ty thuê marketing khi có hoạch marketing online từ phòng marketing
-	Hệ thống các phòng bán vé vệ tinh: Các phòng vé nhỏ tại các tỉnh, thành phố

2. Đối ngoại
  -	Đại lý cấp chính của hãng hàng không: Vietjet Air, Jetstar Pacific
-	Đối tác với các hãng hàng không:
    +	Vietnam Airlines
    +	Air Asia
    +	China Southern Airlines
    +	Thai Airways
    +	Japan Airlines
    +	Air France
    +	All Nippon Airways
    +	China Eastern Airlines
    +	…
## Cài đặt và triển khai
  - Bước 01: Cài đặt visual studio (https://visualstudio.microsoft.com/vs/)
  - Bước 02: Cài đặt Sql Server (https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
  - Bước 03: Download source code
  - Bước 04: Chạy file createDBQLBVMB.cmd để cài đặt cơ sở dữ liệu

    ![Cài đặt](https://i.imgur.com/j6elHTE.png?1)
  - Bước 05: Chạy file BanVeMayBay.sln 

    ![Cài đặt](https://i.imgur.com/NEt76LI.png?1)

## Các nguồn tham khảo
  - https://stackoverflow.com
  - https://vietjack.com
  - https://coders.tokyo
  - https://www.w3schools.com
  - https://youtube.com
  - http://veminhthanh.vn
## Tài liệu báo cáo:
  - http://bit.ly/BaoCaoCuoiKi