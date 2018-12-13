create database cinema
go

use cinema
go
create table Rap(
	idrap int identity(1,1),
	tenrap nvarchar(50),
	diachi nvarchar(100),
	soluongphong int,
	primary key (idrap)
)


create table Phong(
	idphong int identity(1,1),
	idrap int,
	sophong int,
	soluongghe int,
	primary key (idphong)
)

create table Ghe(
	idghe int identity(1,1),
	idphong int,
	loaighe nvarchar(10),
	sohang char(1),
	socot int,

	primary key (idghe)
)

create table Phim(
	idphim int identity(1,1),
	tuaphim nvarchar(100),
	theloai nvarchar(50),
	daodien nvarchar(50),
	ngaycongchieu date,
	thoiluong int,
	nuocsx nvarchar(50),
	namsx int,
	tinhtrang nvarchar(50),

	primary key(idphim)
)

create table SuatChieu(
	idsuatchieu int identity(1,1),
	idphong int,
	ngay date,
	thoigianbd time,
	idphim int,
	iddinhdang char(2),

	primary key(idsuatchieu)
)

create table DinhDangChieu(
	iddinhdang char(2),
	mota nvarchar(200),
	gia float,

	primary key(iddinhdang)
)

create table ThanhVien(
	cmnd char(10),
	sdt char(10),
	tenthanhvien nvarchar(50),
	ngaysinh date,
	primary key(cmnd)
)

create table ChucVu(
	idchucvu char(2),
	tenchucvu nvarchar(50),
	primary key (idchucvu)
)

create table NhanVien(
	idnhanvien int identity(1,1),
	cmnd char(10),
	tennhanvien nvarchar(50),
	sdt char(10),
	idchucvu char(2),
	matkhau nvarchar(16),
	thuocrap int,
	primary key(idnhanvien)
)

create table UuDai(
	iduudai nvarchar(20),
	tenuudai nvarchar(50),
	mota nvarchar(255),
	giamgia float,

	primary key(iduudai)
)


create table LoaiVe(
	idloaive nvarchar(5),
	mota nvarchar(50),
	gia float,

	primary key (idloaive)
)

create table Ve(
	idve int identity(1,1),
	idloaive nvarchar(5),
	suat int,
	ghe int,
	uudai nvarchar(20),
	nhanvienbanhang int,
	trangthai nvarchar(20),
	gia float,
	thanhvien char(10),
	thoigiandat datetime,

	primary key(idve)
)

go

alter table Phong
add constraint FK_Phong_Rap_idrap
foreign key (idrap)
references Rap(idrap)

alter table Ghe
add constraint FK_Ghe_Phong_idphong
foreign key (idphong)
references Phong(idphong)

alter table SuatChieu
add constraint FK_SuatChieu_DinhDangChieu_iddinhdang
foreign key (iddinhdang)
references DinhDangChieu(iddinhdang)

alter table SuatChieu
add constraint FK_SuatChieu_Phong_idphong
foreign key (idphong)
references Phong(idphong)

alter table SuatChieu
add constraint FK_SuatChieu_Phim_idphim
foreign key (idphim)
references Phim(idphim)

alter table NhanVien
add constraint FK_NhanVien_ChucVu_idchucvu
foreign key (idchucvu)
references ChucVu(idchucvu)

alter table Ve
add constraint FK_Ve_LoaiVe_idloaive
foreign key (idloaive)
references LoaiVe(idloaive)

alter table Ve
add constraint FK_Ve_SuatChieu_suat
foreign key (suat)
references SuatChieu(idsuatchieu)

alter table Ve
add constraint FK_Ve_Ghe_ghe
foreign key (ghe)
references Ghe(idghe)

alter table Ve
add constraint FK_Ve_Uudai_uudai
foreign key (uudai)
references Uudai(iduudai)

alter table Ve
add constraint FK_Ve_NhanVien_nhanvienbanhang
foreign key (nhanvienbanhang)
references NhanVien(idnhanvien)

alter table Ve
add constraint FK_Ve_ThanhVien_thanhvien
foreign key (thanhvien)
references ThanhVien(cmnd)

alter table NhanVien
add constraint FK_NhanVien_Rap_thuocrap
foreign key (thuocrap)
references Rap(idrap)

go

insert into Rap(tenrap, diachi, soluongphong)
values (N'Catavil', N'Xa lộ Hà nội, Quận 2, thành phố Hồ Chí Minh', 3),
(N'Cộng Hòa', N'Cộng Hòa, Quận Tân Bình, thành phố Hồ Chí Minh', 5),
(N'Nowzone', N'Nguyễn Văn Cừ, Quận 1, thành phố Hồ Chí Minh', 4),
(N'Nam Sài Gòn', N'Nguyễn Hữu Thọ, Quận 7, thành phố Hồ Chí Minh', 5),
(N'Thủ Đức', N'Quốc lộ 1A, Quận Thủ Đức, thành phố Hồ Chí Minh', 3),
(N'Hà ĐÔng', N'Tô Hiệu, Quận Hà Đông, Hà Nội', 3),
(N'Landmark',N'Phạm Hùng, Quận Cầu Giấy, Hà Nội', 5),
(N'Ninh Kiều',N'Mậu Thân, Quận Ninh Kiều, Hà Nội', 3)
go

insert into Phong(idrap, sophong, soluongghe)
values (1, 1, 50),
(2, 1, 50),
(3, 1, 50),
(4, 1, 50),
(5, 1, 50),
(6, 1, 50),
(7, 1, 50),
(8, 1, 50)
go
insert into Ghe(idphong, loaighe, sohang, socot)
values
(1,N'Thường',N'A', 1), (1,N'Thường',N'A', 2), (1,N'Thường',N'A', 3), (1,N'Thường',N'A', 4), (1,N'Thường',N'A', 5), (1,N'Thường',N'A', 6), (1,N'Thường',N'A', 7), (1,N'Thường',N'A', 8), (1,N'Thường',N'A', 9), (1,N'Thường',N'A', 10), (1,N'Thường',N'B', 1), (1,N'Thường',N'B', 2), (1,N'Thường',N'B', 3), (1,N'Thường',N'B', 4), (1,N'Thường',N'B', 5), (1,N'Thường',N'B', 6), (1,N'Thường',N'B', 7), (1,N'Thường',N'B', 8), (1,N'Thường',N'B', 9), (1,N'Thường',N'B', 10), (1,N'Thường',N'C', 1), (1,N'Thường',N'C', 2), (1,N'Thường',N'C', 3), (1,N'Thường',N'C', 4), (1,N'Vip',N'C', 5), (1,N'Vip',N'C', 6), (1,N'Vip',N'C', 7), (1,N'Vip',N'C', 8), (1,N'Thường',N'C', 9), (1,N'Thường',N'C', 10), (1,N'Thường',N'D', 1), (1,N'Thường',N'D', 2), (1,N'Thường',N'D', 3), (1,N'Thường',N'D', 4), (1,N'Vip',N'D', 5), (1,N'Vip',N'D', 6), (1,N'Vip',N'D', 7), (1,N'Vip',N'D', 8), (1,N'Thường',N'D', 9), (1,N'Thường',N'D', 10), (1,N'Thường',N'E', 1), (1,N'Thường',N'E', 2), (1,N'Thường',N'E', 3), (1,N'Thường',N'E', 4), (1,N'Thường',N'E', 5), (1,N'Thường',N'E', 6), (1,N'Thường',N'E', 7), (1,N'Thường',N'E', 8), (1,N'Thường',N'E', 9), (1,N'Thường',N'E', 10), 
(2,N'Thường',N'A', 1), (2,N'Thường',N'A', 2), (2,N'Thường',N'A', 3), (2,N'Thường',N'A', 4), (2,N'Thường',N'A', 5), (2,N'Thường',N'A', 6), (2,N'Thường',N'A', 7), (2,N'Thường',N'A', 8), (2,N'Thường',N'A', 9), (2,N'Thường',N'A', 10), (2,N'Thường',N'B', 1), (2,N'Thường',N'B', 2), (2,N'Thường',N'B', 3), (2,N'Thường',N'B', 4), (2,N'Thường',N'B', 5), (2,N'Thường',N'B', 6), (2,N'Thường',N'B', 7), (2,N'Thường',N'B', 8), (2,N'Thường',N'B', 9), (2,N'Thường',N'B', 10), (2,N'Thường',N'C', 1), (2,N'Thường',N'C', 2), (2,N'Thường',N'C', 3), (2,N'Thường',N'C', 4), (2,N'Vip',N'C', 5), (2,N'Vip',N'C', 6), (2,N'Vip',N'C', 7), (2,N'Vip',N'C', 8), (2,N'Thường',N'C', 9), (2,N'Thường',N'C', 10), (2,N'Thường',N'D', 1), (2,N'Thường',N'D', 2), (2,N'Thường',N'D', 3), (2,N'Thường',N'D', 4), (2,N'Vip',N'D', 5), (2,N'Vip',N'D', 6), (2,N'Vip',N'D', 7), (2,N'Vip',N'D', 8), (2,N'Thường',N'D', 9), (2,N'Thường',N'D', 10), (2,N'Thường',N'E', 1), (2,N'Thường',N'E', 2), (2,N'Thường',N'E', 3), (2,N'Thường',N'E', 4), (2,N'Thường',N'E', 5), (2,N'Thường',N'E', 6), (2,N'Thường',N'E', 7), (2,N'Thường',N'E', 8), (2,N'Thường',N'E', 9), (2,N'Thường',N'E', 10), 
(3,N'Thường',N'A', 1), (3,N'Thường',N'A', 2), (3,N'Thường',N'A', 3), (3,N'Thường',N'A', 4), (3,N'Thường',N'A', 5), (3,N'Thường',N'A', 6), (3,N'Thường',N'A', 7), (3,N'Thường',N'A', 8), (3,N'Thường',N'A', 9), (3,N'Thường',N'A', 10), (3,N'Thường',N'B', 1), (3,N'Thường',N'B', 2), (3,N'Thường',N'B', 3), (3,N'Thường',N'B', 4), (3,N'Thường',N'B', 5), (3,N'Thường',N'B', 6), (3,N'Thường',N'B', 7), (3,N'Thường',N'B', 8), (3,N'Thường',N'B', 9), (3,N'Thường',N'B', 10), (3,N'Thường',N'C', 1), (3,N'Thường',N'C', 2), (3,N'Thường',N'C', 3), (3,N'Thường',N'C', 4), (3,N'Vip',N'C', 5), (3,N'Vip',N'C', 6), (3,N'Vip',N'C', 7), (3,N'Vip',N'C', 8), (3,N'Thường',N'C', 9), (3,N'Thường',N'C', 10), (3,N'Thường',N'D', 1), (3,N'Thường',N'D', 2), (3,N'Thường',N'D', 3), (3,N'Thường',N'D', 4), (3,N'Vip',N'D', 5), (3,N'Vip',N'D', 6), (3,N'Vip',N'D', 7), (3,N'Vip',N'D', 8), (3,N'Thường',N'D', 9), (3,N'Thường',N'D', 10), (3,N'Thường',N'E', 1), (3,N'Thường',N'E', 2), (3,N'Thường',N'E', 3), (3,N'Thường',N'E', 4), (3,N'Thường',N'E', 5), (3,N'Thường',N'E', 6), (3,N'Thường',N'E', 7), (3,N'Thường',N'E', 8), (3,N'Thường',N'E', 9), (3,N'Thường',N'E', 10), 
(4,N'Thường',N'A', 1), (4,N'Thường',N'A', 2), (4,N'Thường',N'A', 3), (4,N'Thường',N'A', 4), (4,N'Thường',N'A', 5), (4,N'Thường',N'A', 6), (4,N'Thường',N'A', 7), (4,N'Thường',N'A', 8), (4,N'Thường',N'A', 9), (4,N'Thường',N'A', 10), (4,N'Thường',N'B', 1), (4,N'Thường',N'B', 2), (4,N'Thường',N'B', 3), (4,N'Thường',N'B', 4), (4,N'Thường',N'B', 5), (4,N'Thường',N'B', 6), (4,N'Thường',N'B', 7), (4,N'Thường',N'B', 8), (4,N'Thường',N'B', 9), (4,N'Thường',N'B', 10), (4,N'Thường',N'C', 1), (4,N'Thường',N'C', 2), (4,N'Thường',N'C', 3), (4,N'Thường',N'C', 4), (4,N'Vip',N'C', 5), (4,N'Vip',N'C', 6), (4,N'Vip',N'C', 7), (4,N'Vip',N'C', 8), (4,N'Thường',N'C', 9), (4,N'Thường',N'C', 10), (4,N'Thường',N'D', 1), (4,N'Thường',N'D', 2), (4,N'Thường',N'D', 3), (4,N'Thường',N'D', 4), (4,N'Vip',N'D', 5), (4,N'Vip',N'D', 6), (4,N'Vip',N'D', 7), (4,N'Vip',N'D', 8), (4,N'Thường',N'D', 9), (4,N'Thường',N'D', 10), (4,N'Thường',N'E', 1), (4,N'Thường',N'E', 2), (4,N'Thường',N'E', 3), (4,N'Thường',N'E', 4), (4,N'Thường',N'E', 5), (4,N'Thường',N'E', 6), (4,N'Thường',N'E', 7), (4,N'Thường',N'E', 8), (4,N'Thường',N'E', 9), (4,N'Thường',N'E', 10), 
(5,N'Thường',N'A', 1), (5,N'Thường',N'A', 2), (5,N'Thường',N'A', 3), (5,N'Thường',N'A', 4), (5,N'Thường',N'A', 5), (5,N'Thường',N'A', 6), (5,N'Thường',N'A', 7), (5,N'Thường',N'A', 8), (5,N'Thường',N'A', 9), (5,N'Thường',N'A', 10), (5,N'Thường',N'B', 1), (5,N'Thường',N'B', 2), (5,N'Thường',N'B', 3), (5,N'Thường',N'B', 4), (5,N'Thường',N'B', 5), (5,N'Thường',N'B', 6), (5,N'Thường',N'B', 7), (5,N'Thường',N'B', 8), (5,N'Thường',N'B', 9), (5,N'Thường',N'B', 10), (5,N'Thường',N'C', 1), (5,N'Thường',N'C', 2), (5,N'Thường',N'C', 3), (5,N'Thường',N'C', 4), (5,N'Vip',N'C', 5), (5,N'Vip',N'C', 6), (5,N'Vip',N'C', 7), (5,N'Vip',N'C', 8), (5,N'Thường',N'C', 9), (5,N'Thường',N'C', 10), (5,N'Thường',N'D', 1), (5,N'Thường',N'D', 2), (5,N'Thường',N'D', 3), (5,N'Thường',N'D', 4), (5,N'Vip',N'D', 5), (5,N'Vip',N'D', 6), (5,N'Vip',N'D', 7), (5,N'Vip',N'D', 8), (5,N'Thường',N'D', 9), (5,N'Thường',N'D', 10), (5,N'Thường',N'E', 1), (5,N'Thường',N'E', 2), (5,N'Thường',N'E', 3), (5,N'Thường',N'E', 4), (5,N'Thường',N'E', 5), (5,N'Thường',N'E', 6), (5,N'Thường',N'E', 7), (5,N'Thường',N'E', 8), (5,N'Thường',N'E', 9), (5,N'Thường',N'E', 10), 
(6,N'Thường',N'A', 1), (6,N'Thường',N'A', 2), (6,N'Thường',N'A', 3), (6,N'Thường',N'A', 4), (6,N'Thường',N'A', 5), (6,N'Thường',N'A', 6), (6,N'Thường',N'A', 7), (6,N'Thường',N'A', 8), (6,N'Thường',N'A', 9), (6,N'Thường',N'A', 10), (6,N'Thường',N'B', 1), (6,N'Thường',N'B', 2), (6,N'Thường',N'B', 3), (6,N'Thường',N'B', 4), (6,N'Thường',N'B', 5), (6,N'Thường',N'B', 6), (6,N'Thường',N'B', 7), (6,N'Thường',N'B', 8), (6,N'Thường',N'B', 9), (6,N'Thường',N'B', 10), (6,N'Thường',N'C', 1), (6,N'Thường',N'C', 2), (6,N'Thường',N'C', 3), (6,N'Thường',N'C', 4), (6,N'Vip',N'C', 5), (6,N'Vip',N'C', 6), (6,N'Vip',N'C', 7), (6,N'Vip',N'C', 8), (6,N'Thường',N'C', 9), (6,N'Thường',N'C', 10), (6,N'Thường',N'D', 1), (6,N'Thường',N'D', 2), (6,N'Thường',N'D', 3), (6,N'Thường',N'D', 4), (6,N'Vip',N'D', 5), (6,N'Vip',N'D', 6), (6,N'Vip',N'D', 7), (6,N'Vip',N'D', 8), (6,N'Thường',N'D', 9), (6,N'Thường',N'D', 10), (6,N'Thường',N'E', 1), (6,N'Thường',N'E', 2), (6,N'Thường',N'E', 3), (6,N'Thường',N'E', 4), (6,N'Thường',N'E', 5), (6,N'Thường',N'E', 6), (6,N'Thường',N'E', 7), (6,N'Thường',N'E', 8), (6,N'Thường',N'E', 9), (6,N'Thường',N'E', 10), 
(7,N'Thường',N'A', 1), (7,N'Thường',N'A', 2), (7,N'Thường',N'A', 3), (7,N'Thường',N'A', 4), (7,N'Thường',N'A', 5), (7,N'Thường',N'A', 6), (7,N'Thường',N'A', 7), (7,N'Thường',N'A', 8), (7,N'Thường',N'A', 9), (7,N'Thường',N'A', 10), (7,N'Thường',N'B', 1), (7,N'Thường',N'B', 2), (7,N'Thường',N'B', 3), (7,N'Thường',N'B', 4), (7,N'Thường',N'B', 5), (7,N'Thường',N'B', 6), (7,N'Thường',N'B', 7), (7,N'Thường',N'B', 8), (7,N'Thường',N'B', 9), (7,N'Thường',N'B', 10), (7,N'Thường',N'C', 1), (7,N'Thường',N'C', 2), (7,N'Thường',N'C', 3), (7,N'Thường',N'C', 4), (7,N'Vip',N'C', 5), (7,N'Vip',N'C', 6), (7,N'Vip',N'C', 7), (7,N'Vip',N'C', 8), (7,N'Thường',N'C', 9), (7,N'Thường',N'C', 10), (7,N'Thường',N'D', 1), (7,N'Thường',N'D', 2), (7,N'Thường',N'D', 3), (7,N'Thường',N'D', 4), (7,N'Vip',N'D', 5), (7,N'Vip',N'D', 6), (7,N'Vip',N'D', 7), (7,N'Vip',N'D', 8), (7,N'Thường',N'D', 9), (7,N'Thường',N'D', 10), (7,N'Thường',N'E', 1), (7,N'Thường',N'E', 2), (7,N'Thường',N'E', 3), (7,N'Thường',N'E', 4), (7,N'Thường',N'E', 5), (7,N'Thường',N'E', 6), (7,N'Thường',N'E', 7), (7,N'Thường',N'E', 8), (7,N'Thường',N'E', 9), (7,N'Thường',N'E', 10), 
(8,N'Thường',N'A', 1), (8,N'Thường',N'A', 2), (8,N'Thường',N'A', 3), (8,N'Thường',N'A', 4), (8,N'Thường',N'A', 5), (8,N'Thường',N'A', 6), (8,N'Thường',N'A', 7), (8,N'Thường',N'A', 8), (8,N'Thường',N'A', 9), (8,N'Thường',N'A', 10), (8,N'Thường',N'B', 1), (8,N'Thường',N'B', 2), (8,N'Thường',N'B', 3), (8,N'Thường',N'B', 4), (8,N'Thường',N'B', 5), (8,N'Thường',N'B', 6), (8,N'Thường',N'B', 7), (8,N'Thường',N'B', 8), (8,N'Thường',N'B', 9), (8,N'Thường',N'B', 10), (8,N'Thường',N'C', 1), (8,N'Thường',N'C', 2), (8,N'Thường',N'C', 3), (8,N'Thường',N'C', 4), (8,N'Vip',N'C', 5), (8,N'Vip',N'C', 6), (8,N'Vip',N'C', 7), (8,N'Vip',N'C', 8), (8,N'Thường',N'C', 9), (8,N'Thường',N'C', 10), (8,N'Thường',N'D', 1), (8,N'Thường',N'D', 2), (8,N'Thường',N'D', 3), (8,N'Thường',N'D', 4), (8,N'Vip',N'D', 5), (8,N'Vip',N'D', 6), (8,N'Vip',N'D', 7), (8,N'Vip',N'D', 8), (8,N'Thường',N'D', 9), (8,N'Thường',N'D', 10), (8,N'Thường',N'E', 1), (8,N'Thường',N'E', 2), (8,N'Thường',N'E', 3), (8,N'Thường',N'E', 4), (8,N'Thường',N'E', 5), (8,N'Thường',N'E', 6), (8,N'Thường',N'E', 7), (8,N'Thường',N'E', 8), (8,N'Thường',N'E', 9), (8,N'Thường',N'E', 10)
go

insert into Phim(tuaphim, theloai, daodien, ngaycongchieu, thoiluong, nuocsx, namsx, tinhtrang)
values (N'Cô gái đến từ hôm qua',N'Học đường, Tình cảm',N'Phan Gia Nhật Linh','2018-5-12',120,N'Việt Nam',2018,N'Đang chiếu'),
('X-men',N'Hành động','Bryan Singer','2005-7-21',121,N'Hoa Kỳ',2004,N'Ngừng chiếu'),
('Fast and Furious',N'Hành động','Vin Diesel','2000-3-2',125,N'Hoa Kỳ',1990,N'Ngừng chiếu'),
(N'Tháng năm rựa rỡ',N'Tình cảm',N'Nguyễn Quang Dũng','2018-6-25',120,N'Việt Nam',2018,N'Đang chiếu'),
(N'Cô ba Sài Gòn',N'Tình cảm',N'Ngô Thanh Vân','2017-3-13',118,N'Việt Nam',2017,N'Ngừng chiếu'),
(N'Địch Nhân Kiệt: Tứ đại thiên vương',N'Dã sử',N'Từ Khắc','2018-7-27',123,N'Trung Quốc',2018,N'Ngừng chiếu'),
(N'Mắt biết',N'Tình cảm',N'Victo Vũ','2019-3-12',128,N'Việt Nam',2019,N'Sắp chiếu'),
(N'Em là bà nội của anh',N'Tình cảm',N'Phan Gia Nhật Linh','2015-12-11',118,N'Việt Nam',2015,N'Ngừng chiếu'),
(N'Thiên tài bất hảo',N'Học đường','Pichuka Cherat','2017-3-25',132,N'Thái Lan',2016,N'Ngừng chiếu'),
('Harry Porter',N'Viễn tưởng','Richard Man','2004-4-3',120,N'Anh',2003,N'Ngừng chiếu')
go

insert into DinhDangChieu(iddinhdang, mota, gia)
values ('2D',N'2D',5000),
('3D',N'3D',10000)
go

insert into SuatChieu(idphong, ngay, thoigianbd, idphim, iddinhdang)
values (1,'2018-11-22','12:10:05',1,'2D'),
(1,'2018-11-22','08:50:00',1,'2D'),
(2,'2018-11-22','12:10:05',1,'2D'),
(3,'2018-11-25','19:00:00',4,'2D'),
(1,'2016-10-23','20:00:00',8,'2D'),
(2,'2004-05-05','13:05:00',10,'3D'),
(3,'2018-8-1','10:10:00',6,'3D'),
(1,'2017-5-15','12:10:00',5,'3D'),
(2,'2000-4-5','16:10:00',3,'3D'),
(3,'2017-4-24','14:25:00',9,'2D')

go

insert into ThanhVien(cmnd, sdt, tenthanhvien, ngaysinh)
values ('249603038','0948394039',N'Nguyễn Thành Long','1998-11-22'),
('204860386','0948674930',N'Trần Văn Trung','1990-3-20'),
('205860496','0938375930',N'Hoàng Thị Dung','2000-5-30'),
('694830583','0386749603',N'Mai Thanh Huyền','1993-4-5'),
('308406940','0149684405',N'Lê Thị An','1992-7-4'),
('058375038','03496t8302',N'Lý Tầm Hoan','2001-9-6'),
('960604835','0593850382',N'Quách Tĩnh','1995-5-8'),
('583060385','0583458376',N'Hồng Thất Công','1980-2-11'),
('059438406','0234056949',N'Tây Dương Phong','1967-5-20')
go
select * from ThanhVien
insert into ChucVu(idchucvu, tenchucvu)
values ('NV',N'Nhân Viên'),
('QL',N'Quản Lý')
go

insert into NhanVien(cmnd, tennhanvien, sdt, idchucvu, matkhau, thuocrap)
values ('272453889',N'Nguyễn Hoàng Sang','0963456789','NV','hoangsang123',1),
('273441849',N'Nguyễn Văn Toàn','0973456529','NV','mama123123',2),
('286783789',N'Lê Ngọc Vân','0963356142','NV','haha456789',3),
('272129513',N'Trần Vân Anh','0969103489','NV','vananh123465789',4),
('279631234',N'Hoàng Ngọc Lan','0965678912','NV','lalalavietnam',5),
('274861369',N'Nguyễn Huỳnh Hồng Diễm','0965846799','QL','hongdiemhong',1),
('276531695',N'Đinh Kim Ngọc','0963651248','QL','kimngockim',2)
go

insert into UuDai(iduudai, tenuudai, mota, giamgia)
values ('Monday',N'Giảm giá ngày thứ hai',N'Mọi khách hàng đều được giảm giá vào ngày thứ hai hàng tuần',0.2),
('GiaSoc',N'Giá sốc',N'Giá sốc trong khung giờ nhất định',0.5),
('SinhNhat',N'Sinh Nhật',N'Giảm giá 100% trong ngày sinh nhật của thành viên',1.0)
go

insert into LoaiVe(idloaive, mota, gia) values
('NL', N'Vé dành cho người lớn.', 60000),
('TE', N'Vé dành cho trẻ em.', 30000),
('HSSV', N'Vé dành cho học sinh, sinh viên.', 45000)
go

SET IDENTITY_INSERT Ve ON
insert into Ve(idve, idloaive, suat, ghe, uudai, nhanvienbanhang, trangthai, gia, thanhvien, thoigiandat) values
(1, 'NL', 1, 35, null, 1, N'đã bán', 60000,null,null),
(2, 'NL', 1, 36, null, 1, N'đã bán', 60000,null,null),
(3, 'HSSV', 2, 35, 'SinhNhat', 2, N'đã bán', 0,null,null),
(4, 'HSSV', 2, 37, 'Monday', 2, N'đã bán', 40000,null,null),
(5, 'HSSV', 2, 2, 'Monday', 2, N'đã bán', 40000,null,null),
(6, 'NL', 1, 1, null, 1, N'đã bán', 60000,null,null),
(7, 'TE', 1, 2, null, 2, N'đã bán', 30000,null,null),
(8, 'NL', 1, 3, null, 2, N'đã bán', 60000,null,null),
(9, 'TE', 3, 5, null, 2, N'đã bán', 30000,null,null),
(10, 'NL', 3, 6, null, 1, N'đã bán', 60000,null,null),
(11, 'HSSV', 1, 21, null, 1, N'đã bán', 45000,null,null),
(12, 'HSSV', 2, 22, null, 4, N'đã bán', 45000,null,null),
(13, 'NL', 2, 21, null, 3, N'đã bán', 60000,null,null)
SET IDENTITY_INSERT Ve OFF
go

update NhanVien set matkhau = '1' where cmnd = '274861369'