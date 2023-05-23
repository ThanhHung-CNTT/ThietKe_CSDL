﻿USE QuanLyKhoHang
--1.NHÂN VIÊN CÓ ĐƠN HÀNG LỚN HƠN BAO NHIÊU
GO
CREATE PROCEDURE hoadonnhanvien
@_SoLuongDonHang INT
AS
BEGIN
	SELECT * 
	FROM NhanVien
	WHERE STT IN 
		( 
			SELECT IDNV
			FROM HoaDon
			GROUP BY IDNV
			HAVING SUM(1) > @_SoLuongDonHang
		)
END
--2.TOP 10 KHÁCH HÀNG CÓ ĐƠN HÀNG LỚN NHẤT
GO
CREATE PROCEDURE khachhanglonnhat
AS
BEGIN
	SELECT * 
	FROM KhachHang
	INNER JOIN
		( 
			SELECT TOP(10) IDKH, SUM(HDdongia) AS DG
			FROM HoaDon
			GROUP BY IDKH
			ORDER BY DG DESC
		) HD ON HD.IDKH = KhachHang.IDkh
END
--3.TOP 10 SẢN PHẨM ĐƯỢC YÊU THÍCH NHẤT
GO
CREATE PROCEDURE sanphamyeuthichnhat
AS
BEGIN
	SELECT TOP(10) HDmasp, MAX(HDtensp), SUM(HDsl * HDdongia) AS TIEN
	FROM HoaDon
	GROUP BY HDmasp
	ORDER BY TIEN DESC
END
--4.THỐNG KÊ SẢN PHẨM TRONG HÓA ĐƠN VÀ SẮP XẾP THEO THỨ TỰ TỪ LỚN ĐẾN NHỎ
GO
CREATE PROCEDURE thongkesp
AS
BEGIN
	SELECT TOP(10) HDmasp, MAX(HDtensp), SUM(HDsl) AS SL, SUM(HDdongia) AS DG, SUM(HDsl) * SUM(HDdongia) AS TONGTIEN
	FROM HoaDon
	GROUP BY HDmasp
	ORDER BY TONGTIEN DESC
END
--5.ĐƠN HÀNG LỚN CÓ SỐ LƯỢNG LỚN HƠN
GO
CREATE PROCEDURE kiemtradonhang
@_SoLuong INT
AS
BEGIN
	SELECT TOP(10) HDmasp, MAX(HDtensp), SUM(HDsl) AS SL
	FROM HoaDon
	GROUP BY HDmasp
	HAVING SUM(HDsl) >= @_SoLuong
	ORDER BY SL DESC
END