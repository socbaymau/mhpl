using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class VESOContext : DbContext
    {
        public VESOContext()
        {
        }

        public VESOContext(DbContextOptions<VESOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CongNo> CongNo { get; set; }
        public virtual DbSet<DaiLy> DaiLy { get; set; }
        public virtual DbSet<Giai> Giai { get; set; }
        public virtual DbSet<Kqxs> Kqxs { get; set; }
        public virtual DbSet<LoaiVeSo> LoaiVeSo { get; set; }
        public virtual DbSet<PhanPhoi> PhanPhoi { get; set; }
        public virtual DbSet<PhieuChi> PhieuChi { get; set; }
        public virtual DbSet<PhieuThu> PhieuThu { get; set; }
        public virtual DbSet<SldangKy> SldangKy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SOCBAYMAU;Database=VESO;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CongNo>(entity =>
            {
                entity.HasKey(e => e.MaCn);

                entity.Property(e => e.MaCn).HasColumnName("MaCN");

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SoTien).HasColumnType("money");

                entity.HasOne(d => d.MaDlNavigation)
                    .WithMany(p => p.CongNo)
                    .HasForeignKey(d => d.MaDl)
                    .HasConstraintName("FK_CongNo_DaiLy");
            });

            modelBuilder.Entity<DaiLy>(entity =>
            {
                entity.HasKey(e => e.MaDl);

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(100);

                entity.Property(e => e.TinhTrang).HasMaxLength(20);
            });

            modelBuilder.Entity<Giai>(entity =>
            {
                entity.HasKey(e => e.MaGiai);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.SoTien).HasColumnType("money");

                entity.Property(e => e.TenGiai).HasMaxLength(50);
            });

            modelBuilder.Entity<Kqxs>(entity =>
            {
                entity.HasKey(e => e.MaKq);

                entity.ToTable("KQXS");

                entity.Property(e => e.MaKq).HasColumnName("MaKQ");

                entity.Property(e => e.MaLvs).HasColumnName("MaLVS");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.HasOne(d => d.MaGiaiNavigation)
                    .WithMany(p => p.Kqxs)
                    .HasForeignKey(d => d.MaGiai)
                    .HasConstraintName("FK_KQXS_Giai");

                entity.HasOne(d => d.MaLvsNavigation)
                    .WithMany(p => p.Kqxs)
                    .HasForeignKey(d => d.MaLvs)
                    .HasConstraintName("FK_KQXS_LoaiVeSo");
            });

            modelBuilder.Entity<LoaiVeSo>(entity =>
            {
                entity.HasKey(e => e.MaLvs);

                entity.Property(e => e.MaLvs).HasColumnName("MaLVS");

                entity.Property(e => e.Tinh).HasMaxLength(100);

                entity.Property(e => e.TinhTrang).HasMaxLength(20);
            });

            modelBuilder.Entity<PhanPhoi>(entity =>
            {
                entity.HasKey(e => e.MaPp);

                entity.Property(e => e.MaPp).HasColumnName("MaPP");

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.MaLvs).HasColumnName("MaLVS");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.HasOne(d => d.MaDlNavigation)
                    .WithMany(p => p.PhanPhoi)
                    .HasForeignKey(d => d.MaDl)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MaLvsNavigation)
                    .WithMany(p => p.PhanPhoi)
                    .HasForeignKey(d => d.MaLvs)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhieuChi>(entity =>
            {
                entity.HasKey(e => e.MaPc);

                entity.Property(e => e.MaPc).HasColumnName("MaPC");

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).HasMaxLength(250);

                entity.Property(e => e.SoTien).HasColumnType("money");

                entity.HasOne(d => d.MaDlNavigation)
                    .WithMany(p => p.PhieuChi)
                    .HasForeignKey(d => d.MaDl)
                    .HasConstraintName("FK_PhieuChi_DaiLy");
            });

            modelBuilder.Entity<PhieuThu>(entity =>
            {
                entity.HasKey(e => e.MaPt);

                entity.Property(e => e.MaPt).HasColumnName("MaPT");

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.SoTien).HasColumnType("money");

                entity.HasOne(d => d.MaDlNavigation)
                    .WithMany(p => p.PhieuThu)
                    .HasForeignKey(d => d.MaDl)
                    .HasConstraintName("FK_PhieuThu_DaiLy");
            });

            modelBuilder.Entity<SldangKy>(entity =>
            {
                entity.HasKey(e => e.MaSldk);

                entity.ToTable("SLDangKy");

                entity.Property(e => e.MaSldk).HasColumnName("MaSLDK");

                entity.Property(e => e.MaDl).HasColumnName("MaDL");

                entity.Property(e => e.MaLvs).HasColumnName("MaLVS");

                entity.Property(e => e.NgayDangKy).HasColumnType("datetime");

                entity.HasOne(d => d.MaDlNavigation)
                    .WithMany(p => p.SldangKy)
                    .HasForeignKey(d => d.MaDl)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SLDK_DaiLy_MaDL");

                entity.HasOne(d => d.MaLvsNavigation)
                    .WithMany(p => p.SldangKy)
                    .HasForeignKey(d => d.MaLvs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SLDK_LoaiVeSo_MaLVS");
            });
        }
    }
}
