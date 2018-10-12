alter table PhanPhoi add TiLe float
drop table PhanPhoi
go
drop table SLDangKy
CREATE TABLE SLDangKy
(
	MaSLDK int identity PRIMARY KEY,
	MaDL int NOT NULL, --FK--
	MaLVS int NOT NULL, --FK--
	NgayDangKy DATETIME,
	SoLuong INT
)
CREATE TABLE PhanPhoi
(
	MaPP int identity PRIMARY KEY,
	MaLVS int Not Null,--fk
	MaDL int NOT NULL, --FK--
	Ngay DATE,
	SoLuongGiao INT,
	SoLuongBan INT,
	TiLe FLOAT
)
ALTER TABLE SLDangKy
	ADD
		CONSTRAINT FK_SLDK_DaiLy_MaDL FOREIGN KEY (MaDL) REFERENCES DaiLy(MaDL),
		CONSTRAINT FK_SLDK_LoaiVeSo_MaLVS FOREIGN KEY (MaLVS) REFERENCES LoaiVeSo(MaLVS)

ALTER TABLE PhanPhoi
	ADD
		CONSTRAINT FK_PhanPhoi_LoaiVeSo_MaLVS FOREIGN KEY (MaLVS) REFERENCES LoaiVeSo(MaLVS),
		
		CONSTRAINT FK_PhanPhoi_DaiLy_MaDL FOREIGN KEY (MaDL) REFERENCES DaiLy(MaDL)

alter table PhanPhoi drop column MaLVS
select* from SLDangKy
select* from DaiLy
select* from LoaiVeSo
select * from PhanPhoi

insert into SLDangKy (MaDL, MaLVS, NgayDangKy, SoLuong)
values (1,2,'10/01/2018', 100),
 (1,3,'10/01/2018', 100),
 (2,3,'10/01/2018', 100)
alter proc capnhatphanphoi
as
	declare cur cursor for
	select tb2.MaDL, tb2.MaLVS, tb2.SoLuong from 
	(
		select MaDL, MAX(NgayDangKy) as NgayDangKy
		from SLDangKy
		group by MaDL
	)
	as tb1, SLDangKy as tb2
	where tb1.MaDL=tb2.MaDL and tb1.NgayDangKy=tb2.NgayDangKy
	--
	declare @MaDL int
	declare @MaLVS int
	declare @SoLuong int
	--mở con trỏ
	open cur
	fetch next from cur into @MaDL, @MaLVS, @SoLuong
	--nếu con trỏ còn dữ liệu để trỏ
	while @@FETCH_STATUS=0
	begin
	--đã thêm hay chưa
		if(@SoLuong!=0)
		begin
			if exists(
				select top 1 *
				from PhanPhoi
				where MaDL=@MaDL
			)
			begin
				declare @CheckTiLe float
				select @CheckTiLe = TiLe
				from PhanPhoi
				where MaDL = @MaDL
				--
				if(@CheckTiLe IS NOT NULL)
				BEGIN
					declare @TiLe float
					select @TiLe=AVG(TiLe)
					from PhanPhoi
					where MaPP in
					(
						select top 3 MaPP
						from PhanPhoi
						where MaDL=@MaDL
						order by Ngay desc
					)
					--them vao bang
					declare @SoLuongGiao int =cast((@TiLe / 100 * @SoLuong) AS INT)
					INSERT INTO PhanPhoi(MaLVS, MaDL, Ngay, SoLuongGiao)
						VALUES(@MaLVS, @MaDL,CONVERT(DATE, GETDATE()), @SoLuongGiao)
				END
			end
			else 
			begin
				INSERT INTO PhanPhoi(MaLVS, MaDL, Ngay, SoLuongGiao)
						VALUES(@MaLVS, @MaDL,CONVERT(DATE, GETDATE()), @SoLuong)
			end
		end
		fetch next from cur into @MaDL, @MaLVS, @SoLuong
	end
	close cur
	deallocate cur
go


CREATE TRIGGER TG_Them_TiLe ON PhanPhoi AFTER UPDATE
AS
	DECLARE @MaPP INT
	DECLARE @SoLuongGiaoInserted INT
	DECLARE @SoLuongGiaoDeleted INT
	DECLARE @SoLuongBan INT
	DECLARE @TongTiLe FLOAT
	--
	SELECT @SoLuongGiaoInserted = SoLuongGiao
	FROM inserted
	--
	SELECT @SoLuongGiaoDeleted = SoLuongGiao
	FROM deleted
	--
	SELECT @SoLuongBan = SoLuongBan
	FROM inserted
	--
	IF(@SoLuongGiaoInserted = @SoLuongGiaoDeleted)
	BEGIN
		IF(@SoLuongBan IS NOT NULL)
		BEGIN
			SELECT @MaPP = MaPP, @SoLuongGiaoInserted = SoLuongGiao, @SoLuongBan = SoLuongBan
			FROM inserted
			--
			SET @TongTiLe = (CAST(@SoLuongBan AS FLOAT) / CAST(@SoLuongGiaoInserted AS FLOAT)) * 100
			--
			UPDATE PhanPhoi
			SET TiLe = @TongTiLe
			WHERE MaPP = @MaPP
		END
	END
	ELSE
	BEGIN
		IF(@SoLuongBan IS NOT NULL)
		BEGIN
			SELECT @MaPP = MaPP, @SoLuongGiaoInserted = SoLuongGiao, @SoLuongBan = SoLuongBan
			FROM inserted
			--
			SET @TongTiLe = (CAST(@SoLuongBan AS FLOAT) / CAST(@SoLuongGiaoInserted AS FLOAT)) * 100
			--
			UPDATE PhanPhoi
			SET TiLe = @TongTiLe
			WHERE MaPP = @MaPP
		END
	END
GO