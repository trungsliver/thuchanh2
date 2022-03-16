CREATE DATABASE BTL_QLNS;

USE BTL_QLNS;


CREATE TABLE chuc_vu
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ten_chuc_vu NVARCHAR(100) NOT NULL,
	so_tien_phu_cap int NOT NULL
);

<-- drop table tblChucVu;

CREATE TABLE phong_ban
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ten_phong_ban NVARCHAR(100) NOT NULL
);

CREATE TABLE nhan_vien
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	id_phong_ban int NOT NULL,
	id_chuc_vu int Not NULL,
	ten_nhan_vien NVARCHAR(50) NOT NULL,
	ngay_sinh date NOT NULL,
	dia_chi NVARCHAR(100) NOT NULL,
	sdt nvarchar(15) NOT NULL,
	gioi_tinh NVARCHAR(10) NOT NULL,
	/*trang thai */
	trang_thai int default 1 not null,
	
	
		CONSTRAINT fk_nhanvien_iMaPB FOREIGN KEY (id_phong_ban) REFERENCES phong_ban(id),
		CONSTRAINT fk_nhanvien_iMaCV FOREIGN KEY (id_chuc_vu) REFERENCES chuc_vu(id)
);


CREATE TABLE hop_dong
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	loai_hop_dong NVARCHAR(50) NOT NULL,
	id_nhan_vien int NOT NULL,
	ngay_bat_dau date NOT NULL,
	ngay_ket_thuc date NOT NULL,
	don_gia_ngay_cong int NOT NULL,
	/*trang thai*/
	trang_thai int default 1 not null,
	CONSTRAINT fk_hopdong_iMaNV FOREIGN KEY (id_nhan_vien) REFERENCES nhan_vien(id)
);

CREATE TABLE thoi_gian
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	thang int NOT NULL,
	nam int NOT NULL
);

CREATE TABLE luong
(
	id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	id_hop_dong int NOT NULL,
	id_thoi_gian int NOT NULL,
	ngay_cong int NOT NULL,

	CONSTRAINT fk_luong_iMaHD FOREIGN KEY (id_hop_dong) REFERENCES hop_dong(id),
	CONSTRAINT fk_luong_iTG FOREIGN KEY (id_thoi_gian) REFERENCES thoi_gian(id)
);


/* NHẬP DỮ LIỆU */
insert into chuc_vu(ten_chuc_vu, so_tien_phu_cap)
values 
	(N'Truong phong', 2000000),
	(N'Pho phong', 1500000),
	(N'Nhan vien', 1000000);
select * from chuc_vu;

insert into phong_ban(ten_phong_ban)
values 
	(N'Phong kinh doanh'),
	(N'Phong nhan su'),
	(N'Phong ke toan'),
	(N'Phong marketing'),
	(N'Phong ky thuat');
select * from phong_ban;

insert into nhan_vien(id_phong_ban, id_chuc_vu, ten_nhan_vien, ngay_sinh, dia_chi, sdt, gioi_tinh)
values 
	(1, 1, N'Bui Duc Trung', '08/07/2001', N'Ha Noi', '0966674287', N'Nam'),
	(1, 2, N'Nguyen Kim Long', '08/30/2001', N'Ha Noi', '0915246868', N'Nam'),
	(1, 3, N'Nguyen Hoang Vu', '07/25/2000', N'Ha Noi', '0862354972', N'Nam'),

	(2, 1, N'Nghiem Thi Thu Linh', '05/18/1999', N'Hung Yen', '0913265934', N'Nu'),
	(2, 2, N'Nguyen Thi Thuy', '05/09/2001', N'Phu Tho', '0966523199', N'Nu'),
	(2, 3, N'Le Thi Uyen', '12/24/1998', N'Thanh Hoa', '0994523232', N'Nu'),
	
	(3, 1, N'Nguyen Minh Duc',  '09/05/1996', N'Bac Giang', '0934567891', N'Nam'),
	(3, 2, N'Luu Phuong Thao', '02/14/2000', N'Quang Ninh', '0932162222', N'Nu'),
	(3, 3, N'Nguyen Khanh Linh', '01/26/1999', N'Ha Noi', '0963219876', N'Nu'),

	(4, 1, N'Ngo Minh Anh', '06/16/1999', N'Thai Binh', '0966325984', N'Nu'),
	(4, 2, N'Nguyen Minh Thu', '05/18/2002', N'Ha Noi', '0936598621', N'Nu'),
	(4, 3, N'Vu Gia Huy', '04/01/1998', N'Hoa Binh', '0979654862', N'Nam'),

	(5, 1, N'Mai Xuan Tra', '11/19/1998', N'Ha Nam', '0966368368', N'Nu'),
	(5, 2, N'Le Minh Nguyet', '01/24/1995', N'Nghe An', '0916598758', N'Nu'),
	(5, 3, N'Nguyen Anh Minh', '07/02/1989', N'Cao Bang', '0966668888', N'Nam');
select * from nhan_vien;

<--delete from nhan_vien where ten_nhan_vien = N'a';-->

insert into hop_dong(loai_hop_dong, id_nhan_vien, ngay_bat_dau, ngay_ket_thuc, don_gia_ngay_cong)
values
	(N'Chinh thuc', 1, '01/01/2020', '01/01/2025', 500000),
	(N'Chinh thuc', 2, '02/01/2021', '02/01/2026', 500000),
	(N'Chinh thuc', 3, '03/01/2020', '03/01/2025', 500000),
	(N'Chinh thuc', 4, '01/05/2019', '01/05/2024', 500000),
	(N'Chinh thuc', 5, '01/15/2020', '01/15/2025', 500000),
	(N'Chinh thuc', 6, '05/01/2020', '05/01/2025', 500000),
	(N'Chinh thuc', 7, '10/05/2020', '10/05/2025', 500000),
	(N'Thu viec', 8, '10/15/2021', '10/15/2022', 500000),
	(N'Chinh thuc', 9, '01/04/2020', '01/04/2025', 500000),
	(N'Chinh thuc', 10, '07/01/2019', '07/01/2024', 500000),
	(N'Chinh thuc', 11, '09/01/2021', '09/01/2026', 500000),
	(N'Thu viec', 12, '01/01/2022', '01/01/2023', 500000),
	(N'Chinh thuc', 13, '01/11/2019', '01/11/2024', 500000),
	(N'Chinh thuc', 14, '01/19/2018', '01/19/2023', 500000),
	(N'Thu viec', 15, '01/15/2022', '01/15/2023', 500000);
select * from hop_dong;

insert into thoi_gian(thang, nam)
values
	(12, 2021),
	(1, 2022),
	(2, 2022);
select * from thoi_gian;

insert into luong(id_hop_dong, id_thoi_gian, ngay_cong)
values
	(1, 1, 26),
	(2, 1, 27),
	(3, 1, 28),
	(4, 1, 25),
	(5, 1, 26),
	(6, 1, 27),
	(7, 1, 26),
	(8, 1, 28),
	(9, 1, 26),
	(10, 1, 28),
	(11, 1, 27),
	(12, 1, 25),
	(13, 1, 26),
	(14, 1, 27),
	(15, 1, 26);
select * from luong;

<-- tìm nhân viên theo tên
SELECT * FROM nhan_vien WHERE ten_nhan_vien LIKE '%Bui Duc Trung%'

create view dsChucVu as select id as [Mã chức vụ], ten_chuc_vu as [Tên chức vụ], so_tien_phu_cap as [Phụ cấp] from chuc_vu
select * from dsChucVu

create proc themChucVu 
@tenchucvu nvarchar(100),
@phucap int
as
insert into chuc_vu(ten_chuc_vu, so_tien_phu_cap) values (@tenchucvu, @phucap)

exec themChucVu @tenchucvu='Thu viec' ,@phucap=100000
select *from chuc_vu

create proc suaChucVu_phucap
@id int,
@phucap int
as
update chuc_vu set so_tien_phu_cap = @phucap where id = @id

exec suaChucVu_phucap @id=5, @phucap=600000

<-- nhan_vien(id_phong_ban, id_chuc_vu, ten_nhan_vien, ngay_sinh, dia_chi, sdt, gioi_tinh)

create proc themNhanVien
@id_phong_ban int,
@id_chuc_vu int,
@hoten nvarchar(50),
@ngaysinh date,
@diachi nvarchar(100),
@sdt nvarchar(15),
@gioitinh nvarchar(10)
as
insert into nhan_vien(id_phong_ban, id_chuc_vu, ten_nhan_vien, ngay_sinh, dia_chi, sdt, gioi_tinh)
values (@id_phong_ban, @id_chuc_vu, @hoten, @ngaysinh, @diachi, @sdt, @gioitinh)


create view dsNhanVien as select 
id as [Mã nhân viên], 
id_phong_ban as [Mã phòng ban], 
id_chuc_vu as [Mã chức vụ],
ten_nhan_vien as [Họ tên],
ngay_sinh as [Ngày sinh], 
dia_chi as [Địa chỉ], 
sdt as [Số điện thoại], 
gioi_tinh as [Giới tính] 
from nhan_vien
select * from dsNhanVien

alter view dsNhanVien as select 
id as [Mã nhân viên], 
id_phong_ban as [Mã phòng ban], 
id_chuc_vu as [Mã chức vụ],
ten_nhan_vien as [Họ tên],
ngay_sinh as [Ngày sinh], 
dia_chi as [Địa chỉ], 
sdt as [Số điện thoại], 
gioi_tinh as [Giới tính] 
from nhan_vien where trang_thai=1

create proc suaNhanVien_diachi
@id int,
@diachi nvarchar(50)
as
update nhan_vien set dia_chi = @diachi where id = @id

<-- sửa trạng thái để xóa nhân viên
create proc suaNhanVien_trangthai
@id int,
@trangthai int
as
update nhan_vien set trang_thai = @trangthai where id = @id


create view dsNhanVien_PhongBan as select 
id as [Mã nhân viên], 
id_phong_ban as [Mã phòng ban], 
id_chuc_vu as [Mã chức vụ],
ten_nhan_vien as [Họ tên],
ngay_sinh as [Ngày sinh], 
dia_chi as [Địa chỉ], 
sdt as [Số điện thoại], 
gioi_tinh as [Giới tính] 
from nhan_vien where trang_thai=1 
select * from dsNhanVien

<-- Hiển thị nhân viên theo tên phòng ban
create procedure NV_PhongBan
@phongban nvarchar(25)
as
select 
nhan_vien.id as [Mã nhân viên], 
nhan_vien.id_phong_ban as [Mã phòng ban], 
nhan_vien.id_chuc_vu as [Mã chức vụ],
nhan_vien.ten_nhan_vien as [Họ tên],
nhan_vien.ngay_sinh as [Ngày sinh], 
nhan_vien.dia_chi as [Địa chỉ], 
nhan_vien.sdt as [Số điện thoại], 
nhan_vien.gioi_tinh as [Giới tính] 
from (nhan_vien inner join phong_ban on nhan_vien.id_phong_ban = phong_ban.id)
where phong_ban.ten_phong_ban = @phongban and nhan_vien.trang_thai=1
go

exec NV_PhongBan @phongban=N'Phong kinh doanh';

<-- Hiển thị tổng số nhân viên từng phòng ban
create view tongNV_PhongBan
as
select  
phong_ban.ten_phong_ban as [Tên phòng ban], 
(select count(nhan_vien.id) from nhan_vien where phong_ban.id=nhan_vien.id_phong_ban and nhan_vien.trang_thai=1 ) as [Tổng nhân viên]
from phong_ban

select*from tongNV_PhongBan
select*from nhan_vien

