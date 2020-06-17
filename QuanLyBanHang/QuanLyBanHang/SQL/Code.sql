use QL_BanHang
go

create view BangLuong
as
select NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)as'Luong cung',Sum(HangHoa.HoaHong*ChiTietHoaDon.SoLuong)as'Hoa hong'
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join NhanVien on HoaDon.MaNV = NhanVien.MaNV
group by NhanVien.MaNV,NhanVien.TenNV, NhanVien.GioiTinh,NhanVien.DiaChi,CAST(NhanVien.RankNV AS int)

create view HangTon
as
select HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong
from HangHoa inner join NhaCungCap on HangHoa.MaNCC = NhaCungCap.MaNCC
group by HangHoa.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,HangHoa.DonGia,HangHoa.SoLuong

create view HangBan
as
select ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang, KhachHang.TenKH , ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH
group by ChiTietHoaDon.MaHD, ChiTietHoaDon.MaHH , HangHoa.TenHang,KhachHang.TenKH,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong


create view DoanhThu
as
select ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia as'dongiaban',ChiTietHoaDon.SoLuong as'Soluongban',HangHoa.SoLuong as'Soluongnhap',HangHoa.DonGia as'dongianhap',HoaDon.NgayLap
from HangHoa inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD
group by ChiTietHoaDon.MaHH,TenHang,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HangHoa.SoLuong,HangHoa.DonGia,HoaDon.NgayLap

create Trigger cau1
on ChiTietHoaDon
for Insert
as
	begin
		declare @soluong int
		declare @soluongban int
		select @soluong = HangHoa.SoLuong from HangHoa inner join inserted on HangHoa.MaHH = inserted.MaHH 
		
		select @soluongban = inserted.SoLuong from inserted
		
		Update HangHoa set HangHoa.SoLuong = HangHoa.SoLuong - @soluongban
		from HangHoa inner join inserted on HangHoa.MaHH = inserted.MaHH
	end


create trigger cau2
on ChiTietHoaDon
for delete
as
	begin
		update HangHoa set HangHoa.SoLuong = HangHoa.SoLuong + deleted.SoLuong
		from HangHoa inner join deleted
		on HangHoa.MaHH = deleted.MaHH
		where HangHoa.MaHH = deleted.MaHH
	end

create view DanhSachBan
as	
select ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
from NhaCungCap inner join HangHoa on NhaCungCap.MaNCC = HangHoa.MaNCC inner join ChiTietHoaDon on HangHoa.MaHH = ChiTietHoaDon.MaHH inner join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD inner join KhachHang on HoaDon.MaKH = KhachHang.MaKH inner join NhanVien on KhachHang.MaNV = NhanVien.MaNV
group by ChiTietHoaDon.MaHD,KhachHang.TenKH,ChiTietHoaDon.MaHH,HangHoa.TenHang,NhaCungCap.TenNCC,ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong,HoaDon.MaNV,NhanVien.TenNV,HoaDon.NgayLap
