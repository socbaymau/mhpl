
create proc capnhatphanphoi
as
	declare cur cursor for
	select tb2.MaDL, tb2.MaLVS, tb2.SoLuong from 
	(
		select distinct MaLVS, MAX(NgayDangKy) as NgayDangKy
		from SLDangKy
		where MaDL in
		(
			select distinct MaDL
			from SLDangKy
		)
		group by MaLVS
	)
	as tb1, SLDangKy as tb2
	where tb1.MaLVS=tb2.MaLVS and tb1.NgayDangKy=tb2.NgayDangKy
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
		fetch next from cur into @MaDL, @MaLVS, @SoLuong
		if(@SoLuong!=0)
		begin
			if exists(
				select top 1 *
				from PhanPhoi
				where MaDL=@MaDL AND MaLVS = @MaLVS
			)
			begin
				declare @CheckTiLe float
				select @CheckTiLe = TiLe
				from PhanPhoi
				where MaDL = @MaDL AND MaLVS = @MaLVS
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


create TRIGGER TG_Them_TiLe ON PhanPhoi AFTER UPDATE
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
			PRINT @TongTiLe
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

--select *
--from PhanPhoi

--update PhanPhoi
--set SoLuongBan = 70
--where MaPP = 3
----- neu tinh trang bang khoa thi k cho cap nhat

--exec capnhatphanphoi



