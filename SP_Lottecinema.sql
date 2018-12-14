use cinema
go


IF object_id('sp_DangNhap', 'p') is not null
	DROP PROC sp_DangNhap
go
-- sp_DangNhap
create procedure sp_DangNhap @cmnd char(10), @matkhau char(16), @chucvu char(2), @idrap int out, @idnhanvien int out
as
begin tran
	if(exists (select * 
				from NhanVien n
				where n.cmnd=@cmnd and n.matkhau=@matkhau and n.idchucvu = @chucvu))
		begin
			select @idnhanvien = idnhanvien from NhanVien where cmnd = @cmnd
			select @idrap = thuocrap from NhanVien where cmnd = @cmnd
			print N'Đăng nhập thành công'
		end
	else
		begin
			set @idnhanvien=0
			set @idrap = 0
			print N'Sai mật khẩu hoặc tên đăng nhập'
		end
commit tran

go

IF object_id('sp_ThemThanhVien', 'p') is not null
	DROP PROC sp_ThemThanhVien
go
-- sp_ThemThanhVien
create procedure sp_ThemThanhVien @cmnd char(10),
	@sdt char(10),
	@tenthanhvien nvarchar(50),
	@ngaysinh date
as
begin tran
SET TRAN ISOLATION LEVEL READ COMMITTED
if not exists(select * from ThanhVien where cmnd=@cmnd)
begin
	insert into ThanhVien(cmnd,sdt,tenthanhvien,ngaysinh)
	values(@cmnd,@sdt,@tenthanhvien,@ngaysinh)

	if(@ngaysinh>= SYSDATETIME())
	begin
		rollback tran
	end		
end
else
	print N'Đã tồn tại thành viên này, không thể thêm'
commit tran

go
IF object_id('sp_SuaThanhVien', 'p') is not null
	DROP PROC sp_SuaThanhVien
go
-- sua thanh vien
create procedure sp_SuaThanhVien @cmnd char(10),
	@sdt char(10),
	@tenthanhvien nvarchar(50),
	@ngaysinh date
as
begin tran
set tran isolation level repeatable read
	begin try
		declare @thanhvien nvarchar(50) = (select tenthanhvien from ThanhVien where cmnd=@cmnd)
		if (@thanhvien is not null)
			begin
				if(@sdt is not null)
				begin
					update ThanhVien
					set sdt=@sdt
					where cmnd=@cmnd
				end
				if(@tenthanhvien is not null)
				begin
					update ThanhVien
					set tenthanhvien=@tenthanhvien
					where cmnd=@cmnd
				end
				if(@ngaysinh is not null)
				begin		
					update ThanhVien
					set ngaysinh=@ngaysinh
					where cmnd=@cmnd			
					if(@ngaysinh>= SYSDATETIME())
						rollback tran
				end
			end
		else 
			print N'Không tìm thấy thành viên'
	end try
	begin catch
		select ERROR_MESSAGE() as ErrorMessage
		rollback tran
	end catch
commit tran
go

IF object_id('sp_XoaThanhVien', 'p') is not null
	DROP PROC sp_XoaThanhVien
go
-- xoa thanh vien
create procedure sp_XoaThanhVien @cmnd char(10)
as
begin tran
SET TRAN ISOLATION LEVEL READ COMMITTED
if exists(select * from ThanhVien where cmnd=@cmnd)
begin
	update Ve
	set thanhvien=null
	where thanhvien=@cmnd

	delete from ThanhVien
	where cmnd=@cmnd
end
else
	print N'Không tìm thấy thành viên'
commit tran
go

IF object_id('sp_TimThanhVien', 'p') is not null
	DROP PROC sp_TimThanhVien
go
-- tim thanh vien
create procedure sp_TimThanhVien @cmnd char(10)
as
begin tran
SET TRAN ISOLATION LEVEL READ COMMITTED
select count(*)
from ThanhVien
where day(ngaysinh) = day(GETDATE()) and month(ngaysinh) = month(GETDATE()) 

	if exists (select *
				from ThanhVien t
				where t.cmnd=@cmnd)
		begin
			select *
				from ThanhVien t
				where t.cmnd=@cmnd
		end
	else
		print N'Không tìm thấy thành viên'
commit tran

go

IF object_id('sp_XemSuatChieu', 'p') is not null
	DROP PROC sp_XemSuatChieu
go
create procedure sp_XemSuatChieu @idrap int,@idphim int, @ngay date
as
begin tran
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	--Lấy số lượng suất chiếu
	declare @soluong int
	if (@idphim is null)
	begin
		select @soluong = count(*)
		from (SuatChieu sc join Phong p on sc.idphong=p.idphong) join Rap r on r.idrap=p.idrap
		where r.idrap=@idrap and sc.ngay=@ngay

		--Thể hiện suất chiếu theo điều kiện
		select sc.*
		from (SuatChieu sc join Phong p on sc.idphong=p.idphong) join Rap r on r.idrap=p.idrap
		where r.idrap=@idrap and sc.ngay=@ngay
	end
	else
	begin
		select @soluong = count(*)
		from (SuatChieu sc join Phong p on sc.idphong=p.idphong) join Rap r on r.idrap=p.idrap
		where r.idrap=@idrap and sc.idphim=@idphim and sc.ngay=@ngay

		--Thể hiện suất chiếu theo điều kiện
		select sc.*
		from (SuatChieu sc join Phong p on sc.idphong=p.idphong) join Rap r on r.idrap=p.idrap
		where r.idrap=@idrap and sc.idphim=@idphim and sc.ngay=@ngay
	end
commit tran
go

IF object_id('sp_XemChoNgoi', 'p') is not null
	DROP PROC sp_XemChoNgoi
go
--Procedure xem chỗ ngồi: nhận vào idsuatchieu, trả về số lượng các ghế và tình trạng vé của ghế trong suất chiếu đó.
create procedure sp_XemChoNgoi
	@idsuatchieu int
as 
begin tran
	SET TRAN ISOLATION LEVEL SERIALIZABLE
		--Đếm số ghế còn trống
		declare @sl int
		select @sl = count(*)
		from Ve v
		where v.suat = @idsuatchieu and v.trangthai = N'Trống'

		select p.sophong,v.idve, g.idghe, g.sohang, g.socot, v.trangthai
		from (Ve as v join Ghe as g on v.ghe = g.idghe) join Phong p on p.idphong = g.idphong
		where v.suat = @idsuatchieu
commit tran 

--exec sp_XemChoNgoi 1

--Procedure đặt chỗ: thêm vào bảng vé các thông tin loại ghế, suất chiếu, số hàng và số cột, thành viên đặt và thời gian đặt
--Nếu không đặt được thì in ra "Ghế bận" return 1, ngược lại thành công thì trả về 0
go
IF object_id('sp_DatCho', 'p') is not null
	DROP PROC sp_DatCho
go
create procedure sp_DatCho
 @ve int, @thanhvien char(10)
as 
begin
begin tran
set tran isolation level repeatable read
	begin try
		if not exists(select * from Ve v where v.idve=@ve and v.trangthai like N'Trống')
		begin
			print N'Ghế bận'
			commit tran
			return 1
		end

		update Ve
		set thanhvien=@thanhvien, thoigiandat=GETDATE(), trangthai=N'Đang đặt'
		where idve=@ve

		print N'Thành công'
		commit tran
		return 0
	end try
	begin catch
		select ERROR_MESSAGE() as ErrorMessage
		rollback tran
	end catch
commit tran
end

go
select * from Ve
go
declare @boo int
exec @boo = sp_DatCho 65,null
print @boo
go
--exec sp_DatCho 1,'058375038'

--Procedure hủy đăt chỗ, truyền vào id của vé đặt
--drop procedure sp_HuyDatCho
go
IF object_id('sp_HuyDatCho', 'p') is not null
	DROP PROC sp_HuyDatCho
go
create procedure sp_HuyDatCho
@idve int
as 
begin tran
	update Ve 
	set trangthai = N'Trống',thanhvien=null,thoigiandat=null
	where Ve.idve = @idve
commit tran

--exec sp_HuyDatCho 17

--Procedure bán vé: loại vé, suất chiếu, số hàng và cột của ghế, thành viên (có thể null), nhân viên bán, ưu đãi (có thể null)
--Trả về 1 nếu ghế bận, ngược lại trả về 0
go 
IF object_id('sp_BanVe', 'p') is not null
	DROP PROC sp_BanVe
go
create procedure sp_BanVe 
@ve int, @thanhvien char(10), @nhanvienbanhang int, @uudai nvarchar(20), @loaive nvarchar(5)
as
begin tran
set tran isolation level repeatable read
	begin try
		if not exists(select * from Ve v where v.idve=@ve and v.trangthai like N'Trống')
		begin
			print N'Ghế bận'
			commit tran
			return 1
		end

		declare @loaighe nvarchar(10)
	
		select @loaighe=g.loaighe
		from Ghe g join Ve v on (v.ghe = g.idghe)
		where v.idve = @ve

		--Kiểm tra thành viên tồn tại
		if @thanhvien is not null
		begin
			if not exists(select * from ThanhVien tv where @thanhvien = tv.cmnd) 
			begin
				print N'Thành viên không tồn tại'
				commit tran
				return 1
			end
		end
		--Kiểm tra nhân viên tồn tại
		if not exists(select * from NhanVien nv where @nhanvienbanhang = nv.idnhanvien)
		begin
			print N'Sai mã nhân viên'
			commit tran
			return 1
		end

		--Kiểm tra mã ưu đãi
		if @uudai is not null
		if not exists(select * from UuDai ud where @uudai = ud.iduudai)
		begin
			print N'Nhập sai mã ưu đãi'
			commit tran
			return 1
		end
		--Tính giá tiền vé
		if(@loaive is null)
		begin
			print N'Không tìm thấy loại vé'
			commit tran
			return 1
		end

		declare @giave float
		select @giave = lv.gia
			from LoaiVe lv
			where lv.idloaive = @loaive

		if upper(@loaighe) = 'VIP'
		begin
			set @giave = @giave + 5000
		end

		if @uudai is not NULL
		begin
			declare @giamgia float

			select @giamgia = ud.giamgia
			from UuDai ud where ud.iduudai = @uudai

			set @giave = @giave - @giave * @giamgia
		end

		--Tiến hành bán vé
		update Ve
		set uudai=@uudai,thanhvien=@thanhvien,nhanvienbanhang=@nhanvienbanhang,trangthai=N'Đã bán',gia=@giave,idloaive=@loaive
		where idve=@ve
	
		print N'Thành công' 
		commit tran
		return 0
	end try
	begin catch
		select ERROR_MESSAGE() as ErrorMessage
		rollback tran
	end catch
commit tran
--go
--exec sp_BanVe 15, null, 1, null, 'NL'

--exec sp_BanVe 'NL', 2, 'C', 5, NULL, 1, 'GiaSoc'
go
IF object_id('sp_LayVe', 'p') is not null
	DROP PROC sp_LayVe
go
create procedure sp_LayVe 
@ve int, @nhanvienbanhang int, @uudai nvarchar(20), @loaive nvarchar(5)
as
begin tran

	--Kiểm tra vé đặt
	if not exists(select * from Ve v where @ve = v.idve and v.trangthai like N'Đang đặt')
	begin
		print N'Sai mã vé'
		commit tran
		return 1
	end
	--Kiểm tra nhân viên tồn tại
	if not exists(select * from NhanVien nv where @nhanvienbanhang = nv.idnhanvien)
	begin
		print N'Sai mã nhân viên'
		commit tran
		return 1
	end

	--Kiểm tra mã ưu đãi
	if @uudai is not null
	if not exists(select * from UuDai ud where @uudai = ud.iduudai)
	begin
		print N'Nhập sai mã ưu đãi'
		commit tran
		return 1
	end

	declare @loaighe nvarchar(10)
	
	select @loaighe=g.loaighe
	from Ghe g join Ve v on (v.ghe = g.idghe)
	where v.idve = @ve

	if(@loaive is null)
		begin
			print N'Không tìm thấy loại vé'
			commit tran
			return 1
		end
	--Tính giá tiền vé
	declare @giave float
	select @giave = lv.gia
		from LoaiVe lv
		where lv.idloaive = @loaive

	if upper(@loaighe) = 'VIP'
	begin
		set @giave = @giave + 5000
	end

	if @uudai is not NULL
	begin
		declare @giamgia float

		select @giamgia = ud.giamgia
		from UuDai ud where ud.iduudai = @uudai

		set @giave = @giave - @giave * @giamgia
	end

	--Tiến hành bán vé
	update Ve
	set uudai=@uudai,nhanvienbanhang=@nhanvienbanhang,trangthai=N'Đã bán',gia=@giave,idloaive=@loaive
	where idve=@ve
	
	print N'Thành công' 
	commit tran
	return 0
commit tran

go
IF object_id('sp_ThemSuatChieu', 'p') is not null
	DROP PROC sp_ThemSuatChieu
go

--Procedure thêm suất chiếu: nhận vào idphong, ngay, thời gian bắt đầu, idphim, iddingdang, loaive
--Thực hiện tạo mới suất chiếu và thêm vé của suất chiếu đó vào bảng vé
create procedure sp_ThemSuatChieu @idphong int, @ngay date, @thoigianbd time, @idphim int, @iddinhdang char(2)
as
begin tran
	insert into SuatChieu(idphong, ngay, thoigianbd, idphim, iddinhdang) values
	(@idphong,@ngay,@thoigianbd,@idphim,@iddinhdang)
	if(DATEDIFF(day,getdate(),@ngay)>3 or DATEDIFF(day,getdate(),@ngay)<1)
	begin
		rollback tran
	end
	declare @idSuatChieu int
	--select @idSuatChieu = sc.idsuatchieu
	--from SuatChieu sc;
	--where sc.idphong=@idphong and sc.ngay=@ngay and sc.thoigianbd=@thoigianbd and sc.idphim=@idphim
	select @idSuatChieu=MAX(sc.idsuatchieu)
	from SuatChieu sc

	declare @BangGhe table(idGhe int NOT NULL);

	insert into @BangGhe(idGhe)
	select idghe
	from Ghe
	where idphong = @idphong

	declare @idghe int
	while exists (select* from @BangGhe)
	begin
		select top(1) @idghe = idGhe from @BangGhe

		insert into Ve(suat,ghe,trangthai) values
		(@idSuatChieu,@idghe,N'Trống')

		delete top(1)
		from @BangGhe

	end
commit tran

go 

IF object_id('sp_SuaSuatChieu', 'p') is not null
	DROP PROC sp_SuaSuatChieu
go
--Procedure sửa suất chiếu: nhận vào idsuatchieu,idphong mới, ngay mới, thời gian bắt đầu mới, iddingdang mới, loaive mới
--Thực hiện tạo mới suất chiếu và thêm vé của suất chiếu đó vào bảng vé
create procedure sp_SuaSuatChieu @idsuatchieu int, @idphongmoi int, @ngaymoi date, @thoigianbdmoi time, @iddinhdangmoi char(2)
as
begin tran
set tran isolation level repeatable read
	begin try
		declare @ngaycu date = (select ngay from SuatChieu where idsuatchieu=@idsuatchieu)
		
		if(DATEDIFF(day,@ngaycu,GETDATE())<1)
		begin
			rollback tran
		end
		--Thay đổi ngày mới
		if (@ngaymoi is not null)
		begin
			update SuatChieu
			set ngay = @ngaymoi 
			where idsuatchieu = @idsuatchieu

			if(DATEDIFF(day,getdate(),@ngaymoi)>3 or DATEDIFF(day,getdate(),@ngaymoi)<1)
			begin
				rollback tran
			end
		end
		--Thay đổi thời gian bắt đầu mới
		if(@thoigianbdmoi is not null)
		begin
			update SuatChieu
			set thoigianbd= @thoigianbdmoi
			where idsuatchieu = @idsuatchieu
		end
		--Thay đổi định dạng mới
		if(@iddinhdangmoi is not null)
		begin
			update SuatChieu
			set iddinhdang= @iddinhdangmoi 
			where idsuatchieu = @idsuatchieu
		end
		--Thay đổi phòng mới
		if(@idphongmoi is not null)
		begin
			update SuatChieu
			set idphong = @idphongmoi
			where idsuatchieu = @idsuatchieu

			declare @BangVe table(idVe int NOT NULL)
			declare @BangGhe table(idGhe int NOT NULL)
			insert into @BangVe(idVe)
			select idve
			from Ve
			where suat = @idsuatchieu

			insert into @BangGhe(idGhe)
			select idghe
			from Ghe
			where idphong = @idphongmoi

			declare @idghe int
			declare @idve int
			while exists (select 1 from @BangGhe)
			begin
				select top (1) @idghe = idGhe from @BangGhe
				select top (1) @idve = idVe from @BangVe
				update Ve
				set ghe = @idghe
				from Ve v
				where v.idve = @idve
			
				delete top(1)
				from @BangGhe
				delete top(1)
				from @BangVe
			end
		end
	end try
	begin catch
		select ERROR_MESSAGE() as ErrorMassage
		rollback tran
	end catch
commit tran
go
exec sp_SuaSuatChieu 16,4,'2018-12-16','13:00:00','3D'
select * from SuatChieu
select * from Ve
go 
IF object_id('sp_XoaSuatChieu', 'p') is not null
	DROP PROC sp_XoaSuatChieu
go
--Procedure xóa suất chiếu: nhận vào idsuatchieu
--Thực hiện xóa suất chiếu và vé với idsuatchieu tương ứng
create procedure sp_XoaSuatChieu @idsuatchieu int
as
begin tran
	delete from Ve
	where suat = @idsuatchieu
	
	delete from SuatChieu
	where idsuatchieu = @idsuatchieu
commit tran
go

IF object_id('SP_ThemPhim', 'p') is not null
	DROP PROC SP_ThemPhim
go
create procedure SP_ThemPhim @tuaphim nvarchar(100), @theloai nvarchar(50), @daodien nvarchar(50), @ngaycongchieu date, @thoiluong int, @nuocsx nvarchar(50), @namsx int, @tinhtrang nvarchar(50)
as
begin tran
set transaction isolation level repeatable read
	insert into Phim(tuaphim, theloai, daodien, ngaycongchieu, thoiluong, nuocsx, namsx, tinhtrang) 
	values(@tuaphim, @theloai, @daodien, @ngaycongchieu, @thoiluong, @nuocsx, @namsx, @tinhtrang)
	if (@namsx > year(@ngaycongchieu))
	begin
		rollback tran
	end
commit tran

go
IF object_id('SP_CapNhatPhim', 'p') is not null
	DROP PROC SP_CapNhatPhim
go
--drop procedure SP_ThemPhim
--go
create procedure SP_CapNhatPhim @idphim int, @tuaphim nvarchar(100), @theloai nvarchar(50), @daodien nvarchar(50), @ngaycongchieu date, @thoiluong int, @nuocsx nvarchar(50), @namsx int, @tinhtrang nvarchar(50)
as
begin tran
set tran isolation level repeatable read
	begin try
	if (exists(select * from Phim where idphim = @idphim))
		begin
			update Phim
			set tuaphim = @tuaphim, theloai = @theloai, daodien = @daodien, ngaycongchieu = @ngaycongchieu, thoiluong = @thoiluong, nuocsx = @nuocsx, namsx = @namsx, tinhtrang = @tinhtrang
			where idphim = @idphim

			if (@namsx >  year(@ngaycongchieu))
			begin
				print N'Năm sản xuất không phù hợp với ngày công chiếu'
				rollback
			end
			else
				begin
					print N'Cập nhật thành công'
				end
		end
	else
		print N'Không tồn tại idphim cần cập nhật'
	end try
	begin catch
		select ERROR_MESSAGE() as ErrorMessage
		rollback tran
	end catch
commit tran
go

IF object_id('SP_XemDanhSachPhim', 'p') is not null
	DROP PROC SP_XemDanhSachPhim
go
create procedure SP_XemDanhSachPhim  @theloai nvarchar(50), @namsx int, @tinhtrang nvarchar(50),
@soluong int output
as
begin tran
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	--Đếm số lượng
	select @soluong = count(*)
	from Phim 
	where (theloai = @theloai) or (namsx = @namsx) or (tinhtrang = @tinhtrang)

	select *
	from Phim 
	where (theloai = @theloai) or (namsx = @namsx) or (tinhtrang = @tinhtrang)
commit tran

go

IF object_id('SP_LietKeSuatChieu', 'p') is not null
	DROP PROC SP_LietKeSuatChieu
go
CREATE PROCEDURE SP_LietKeSuatChieu
@soluong int output
AS
BEGIN
	SET TRAN ISOLATION LEVEL SERIALIZABLE
	begin tran
	select @soluong = count(*)
	from SuatChieu

	SELECT *
	FROM SuatChieu
	commit
END

GO

IF object_id('SP_ThongKe', 'p') is not null
	DROP PROC SP_ThongKe
go
--drop procedure SP_ThongKe
-- 17. Thong ke
CREATE PROCEDURE SP_ThongKe(@rap int,@phim int,@ngayBD DATE,@ngayKT DATE)
AS
BEGIN TRAN
	-- Neu khong chon rap, bao loi
	IF (@rap IS NULL)
	BEGIN
		RAISERROR(N'Hay chon rap!',16,1)
		commit tran
		RETURN 1
	END

	-- Da chon rap
	ELSE 
	BEGIN
		IF (@ngayBD IS NULL)
			SET @ngayBD = (SELECT MIN(ngay) FROM SuatChieu)
		IF (@ngayKT IS NULL)
			SET @ngayKT = (SELECT MAX(ngay) FROM SuatChieu)
		
		-- Neu khong chon phim, thong ke tat ca cac phim
		IF (@phim IS NULL)
		BEGIN
			SELECT p.tuaphim AS Phim, COUNT(p.idphim) AS SoLuongVe, SUM(v.gia) AS DoanhThu
			FROM ((Ve v JOIN SuatChieu s ON v.suat=s.idsuatchieu)
				JOIN Phim p ON s.idphim=p.idphim)
			WHERE s.ngay BETWEEN @ngayBD AND @ngayKT and LOWER(v.trangthai) like N'đã bán'
			GROUP BY p.idphim, p.tuaphim
		END

		ELSE
		BEGIN
			SELECT p.tuaphim as Phim, COUNT(*) AS SoLuongVe, SUM(v.gia) AS DoanhThu
			FROM ((Ve v JOIN SuatChieu s ON v.suat=s.idsuatchieu)
				JOIN Phim p ON s.idphim=p.idphim)
			WHERE (s.ngay BETWEEN @ngayBD AND @ngayKT) AND p.idphim=@phim and LOWER(v.trangthai) like N'Đã bán'
			group by p.tuaphim
		END
	END
COMMIT TRAN

GO
IF object_id('SP_LietKeLoaiVe', 'p') is not null
	DROP PROC SP_LietKeLoaiVe
go
-- 18. Liet ke loai ve
CREATE PROCEDURE SP_LietKeLoaiVe
AS
BEGIN TRAN
	SELECT *
	FROM LoaiVe
COMMIT TRAN

GO
IF object_id('SP_LietKeUuDai', 'p') is not null
	DROP PROC SP_LietKeUuDai
go
-- 19. Liet ke uu dai
CREATE PROCEDURE SP_LietKeUuDai
AS
BEGIN TRAN
	SELECT *
	FROM UuDai
COMMIT TRAN
GO

--drop procedure SP_ThongKe
--EXEC SP_ThongKe 1,null, null, null
--select * from Rap
--select * from Phong
--select * from SuatChieu
--select * from Phim
--select * from Ve

--exec SP_LietKeSuatChieu
--exec SP_ThongKe 3,null,'2018-01-01',null
IF object_id('SP_LietKeRap', 'p') is not null
	DROP PROC SP_LietKeRap
go
CREATE PROCEDURE SP_LietKeRap
AS
BEGIN tran
	SELECT *
	FROM Rap
commit tran

GO
IF object_id('SP_LietKePhim', 'p') is not null
	DROP PROC SP_LietKePhim
go
-- Liet ke danh sach phim
CREATE PROCEDURE SP_LietKePhim
AS
BEGIN tran
	SELECT *
	FROM Phim
commit tran

GO

-- Tim ma rap ma nhan vien dang quan ly
IF object_id('SP_LamViecORap', 'p') is not null
	DROP PROC SP_LamViecORap
go
CREATE PROCEDURE SP_LamViecORap @nhanvien INT, @rap INT OUT
AS
BEGIN tran
	SELECT @rap = thuocrap FROM NhanVien WHERE idnhanvien = @nhanvien
	print @rap
commit tran
go
-- liet ke phong
IF object_id('sp_LietKePhong', 'p') is not null
	DROP PROC sp_LietKePhong
go
CREATE PROCEDURE sp_LietKePhong @rap int
AS
BEGIN tran
	select *
	from Phong
	where idrap=@rap
commit tran

go

go
IF object_id('sp_danhsachvedat', 'p') is not null
	DROP PROC sp_danhsachvedat
go
create procedure sp_danhsachvedat
as
SET TRAN ISOLATION LEVEL SERIALIZABLE
begin tran
	select v.idve, v.idloaive, v.trangthai, 
			tv.cmnd, tv.tenthanhvien,
			r.idrap, ph.idphong,
			sc.idsuatchieu,  
			p.tuaphim
	from (ve as v join ThanhVien as tv on v.thanhvien = tv.cmnd) 
			join SuatChieu as sc on sc.idsuatchieu = v.suat
			join Phim as p on sc.idphim = p.idphim
			join Phong ph on ph.idphong = sc.idphong
			join Rap r on r.idrap = ph.idrap 
	where v.trangthai = N'Đang đặt'
commit tran
go
IF object_id('sp_laygiave', 'p') is not null
	DROP PROC sp_laygiave
go
create procedure sp_laygiave @idghe int, @loaive nvarchar(5), @uudai nvarchar(20), @giave float out
as
begin tran
	select @giave = lv.gia
		from LoaiVe lv
		where lv.idloaive = @loaive
	declare @loaighe nvarchar(10) = (select loaighe from Ghe where idghe = @idghe)
	if upper(@loaighe) like 'VIP'
	begin
		set @giave = @giave + 5000
	end

	if @uudai is not NULL
	begin
		declare @giamgia float

		select @giamgia = ud.giamgia
		from UuDai ud where ud.iduudai = @uudai

		set @giave = @giave - @giave * @giamgia
	end
commit tran

go
IF object_id('sp_LietKeThanhVien', 'p') is not null
	DROP PROC sp_LietKeThanhVien
go
create procedure sp_LietKeThanhVien
as
begin
	select * 
	from ThanhVien
end


