--1.CẬP NHẬT TỒN KHO MỖI KHI BÁN MỘT HÓA ĐƠN SẢN PHẨM. Với trigger này mỗi khi bán một hóa đơn,
--số lượng sản phẩm trong tồn kho sẽ được cập nhật
USE QuanLyKhoHang
GO
CREATE TRIGGER trg_ban_don_hang
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET SoLuongSP = SoLuongSP - (
		SELECT SoLuongSP
		FROM HoaDon
		WHERE HDmasp = masp
	)
	FROM TonKho
	JOIN HoaDon ON HoaDon.HDmasp = TonKho.masp
END
--2.CẬP NHẬT TỒN KHO MỖI KHI NHẬP KHO. Khi cửa hàng cập nhật sản phẩm, số lượng sản phẩm tồn kho sẽ tăng lên
--bằng với phần vừa nhập
GO
CREATE TRIGGER trg_nhap_kho
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET SoLuongSP = TonKho.SoLuongSP + (
		SELECT SoLuongSP
		FROM NhapKho
		WHERE NhapKho.masp = TonKho.masp
	)
	FROM TonKho
	JOIN NhapKho ON NhapKho.masp = TonKho.masp
END
--3.CẬP NHẬT TÊN SẢN PHẨM Ở HÓA ĐƠN KHI THAY ĐỔI TÊN. Khi sản phẩm được được đổi tên thì tên sản phẩm cũng được thay 
--đổi trong hóa đơn.
GO
CREATE TRIGGER trg_cap_nhat_ten_sp
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoaDon
	SET HDtensp = (
		SELECT HDtensp
		FROM HoaDon
		WHERE HDmasp = masp
	)
	FROM HoaDon
	JOIN NhapKho ON NhapKho.masp = HoaDon.HDmasp
END
--4.CẬP NHẬT TỒN KHO MỖI KHI GIÁ NHẬP KHO THAY ĐỔI. Khi giá nhập của mỗi sản phẩm tăng or giảm thì giá sẽ được
--cập nhật từ bảng nhập kho sang tồn kho
GO
CREATE TRIGGER trg_gia_nhap_kho
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET gianhapsp = (
		SELECT gianhapsp
		FROM NhapKho
		WHERE NhapKho.masp = TonKho.masp
	)
	FROM TonKho
	JOIN NhapKho ON NhapKho.masp = TonKho.masp
END
--5.CẬP NHẬT TỒN KHO MỖI KHI GIÁ BÁN KHO THAY ĐỔI. Khi giá bán trong bản nhập kho thay đổi thì bảng tồn kho sẽ được
--cập nhật theo
GO
CREATE TRIGGER trg_gia_ban_kho
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET giabansp = (
		SELECT giabansp
		FROM NhapKho
		WHERE NhapKho.masp = TonKho.masp
	)
	FROM TonKho
	JOIN NhapKho ON NhapKho.masp = TonKho.masp
END
--6.CẬP NHẬT ĐƠN VỊ SẢN PHẨM MỖI KHI ĐƠN VỊ TRONG TỒN KHO KHO THAY ĐỔI. Đơn vị tính sản phẩm sẽ được thay đổi
--khi bảng nhập kho thay đổi
GO
CREATE TRIGGER trg_don_vi_sp
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET donvisp = (
		SELECT donvisp
		FROM NhapKho
		WHERE NhapKho.masp = TonKho.masp
	)
	FROM TonKho
	JOIN NhapKho ON NhapKho.masp = TonKho.masp
END
--7.CẬP NHẬT ẢNH SẢN PHẨM MỖI KHI GIÁ BÁN KHO THAY ĐỔI. Hình ảnh của sản phẩm tại bảng nhập kho thay đổi thì bảng
--tồn kho sẽ cập nhật theo
GO
CREATE TRIGGER trg_anh_sp
ON TonKho
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE TonKho
	SET anhsp = (
		SELECT anhsp
		FROM NhapKho
		WHERE NhapKho.masp = TonKho.masp
	)
	FROM TonKho
	JOIN NhapKho ON NhapKho.masp = TonKho.masp
END
--8.CẬP NHẬT DƠN GIÁ HÓA ĐƠN KHI ĐƠN GIÁ THAY ĐỔI
GO
CREATE TRIGGER trg_gia_hoa_don
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoaDon
	SET HDdongia = (
		SELECT HDdongia
		FROM TonKho
		WHERE TonKho.masp = HoaDon.HDmasp
	)
	FROM HoaDon
	JOIN TonKho ON TonKho.masp = HoaDon.HDmasp
END
--9.CẬP NHẬT THANH TOÁN HÓA ĐƠN KHI ĐƠN GIÁ THAY ĐỔI
GO
CREATE TRIGGER trg_thanh_toan_hd
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoaDon
	SET HDtt = (
		SELECT HoaDon.HDtt * TonKho.soluongsp
		FROM TonKho
		WHERE TonKho.masp = HoaDon.HDmasp
	)
	FROM HoaDon
	JOIN TonKho ON TonKho.masp = HoaDon.HDmasp
END
--10.CẬP NHẬT DƠN VỊ SẢN PHẨM HÓA ĐƠN KHI ĐƠN GIÁ THAY ĐỔI
GO
CREATE TRIGGER trg_don_vi_hoa_don_sp
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE HoaDon
	SET HDdonvi = (
		SELECT HDdonvi
		FROM TonKho
		WHERE TonKho.masp = HoaDon.HDmasp
	)
	FROM HoaDon
	JOIN TonKho ON TonKho.masp = HoaDon.HDmasp
END