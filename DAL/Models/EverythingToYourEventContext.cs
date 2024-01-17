using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class EverythingToYourEventContext : DbContext
{
    public EverythingToYourEventContext()
    {
    }

    public EverythingToYourEventContext(DbContextOptions<EverythingToYourEventContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EventToProviderTbl> EventToProviderTbls { get; set; }

    public virtual DbSet<EventTypeAndProvCategotyTbl> EventTypeAndProvCategotyTbls { get; set; }

    public virtual DbSet<EventTypeTbl> EventTypeTbls { get; set; }

    public virtual DbSet<OpinionToProviderTbl> OpinionToProviderTbls { get; set; }

    public virtual DbSet<ParametersForCategoryTbl> ParametersForCategoryTbls { get; set; }

    public virtual DbSet<ProvidersCategoriesTbl> ProvidersCategoriesTbls { get; set; }

    public virtual DbSet<ProvidersTbl> ProvidersTbls { get; set; }

    public virtual DbSet<UsersTbl> UsersTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IQUC79O;Database=EverythingToYourEvent;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventToProviderTbl>(entity =>
        {
            entity.HasKey(e => e.Epcode).HasName("PK__EventToP__DD466FC2E72F3CEA");

            entity.ToTable("EventToProvider_tbl");

            entity.Property(e => e.Epcode).HasColumnName("EPcode");
            entity.Property(e => e.Epdate)
                .HasColumnType("date")
                .HasColumnName("EPdate");
            entity.Property(e => e.EpisDelete).HasColumnName("EPIsDelete");
            entity.Property(e => e.Epname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EPname");
            entity.Property(e => e.Epnotes)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasColumnName("EPnotes");
            entity.Property(e => e.Epstatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("EPstatus");
            entity.Property(e => e.EpwholeDay)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("EPwholeDay");
            entity.Property(e => e.UserId)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.ProvCodeNavigation).WithMany(p => p.EventToProviderTbls)
                .HasForeignKey(d => d.ProvCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EventToPr__ProvC__34C8D9D1");

            entity.HasOne(d => d.User).WithMany(p => p.EventToProviderTbls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EventToPr__UserI__35BCFE0A");
        });

        modelBuilder.Entity<EventTypeAndProvCategotyTbl>(entity =>
        {
            entity.HasKey(e => e.EventTypeProvcode).HasName("PK__EventTyp__53B5C1A963FB33DF");

            entity.ToTable("EventTypeAndProvCategoty_tbl");

            entity.Property(e => e.Pccode).HasColumnName("PCcode");

            entity.HasOne(d => d.EventTypeCodeNavigation).WithMany(p => p.EventTypeAndProvCategotyTbls)
                .HasForeignKey(d => d.EventTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EventType__Event__286302EC");

            entity.HasOne(d => d.PccodeNavigation).WithMany(p => p.EventTypeAndProvCategotyTbls)
                .HasForeignKey(d => d.Pccode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EventType__PCcod__29572725");
        });

        modelBuilder.Entity<EventTypeTbl>(entity =>
        {
            entity.HasKey(e => e.EventTypeCode).HasName("PK__EventTyp__69F6F70B72756661");

            entity.ToTable("EventType_tbl");

            entity.Property(e => e.EventTypeLogo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EventTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OpinionToProviderTbl>(entity =>
        {
            entity.HasKey(e => e.Opcode).HasName("PK__OpinionT__5EC7CF881DF6BD6D");

            entity.ToTable("OpinionToProvider_tbl");

            entity.Property(e => e.Opcode).HasColumnName("OPcode");
            entity.Property(e => e.Opdate)
                .HasColumnType("date")
                .HasColumnName("OPdate");
            entity.Property(e => e.OpisDelete).HasColumnName("OPIsDelete");
            entity.Property(e => e.OpisShow)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("OPisShow");
            entity.Property(e => e.Oppic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OPpic");
            entity.Property(e => e.Optext)
                .HasMaxLength(999)
                .IsUnicode(false)
                .HasColumnName("OPtext");
            entity.Property(e => e.UserId)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.ProvCodeNavigation).WithMany(p => p.OpinionToProviderTbls)
                .HasForeignKey(d => d.ProvCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OpinionTo__ProvC__38996AB5");

            entity.HasOne(d => d.User).WithMany(p => p.OpinionToProviderTbls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OpinionTo__UserI__398D8EEE");
        });

        modelBuilder.Entity<ParametersForCategoryTbl>(entity =>
        {
            entity.HasKey(e => e.ParamCcode).HasName("PK__Paramete__5D615F87F57FA4B0");

            entity.ToTable("ParametersForCategory_tbl");

            entity.Property(e => e.ParamCisDelete).HasColumnName("ParamCIsDelete");
            entity.Property(e => e.ParamCname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParamCtype)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Pccode).HasColumnName("PCcode");

            entity.HasOne(d => d.PccodeNavigation).WithMany(p => p.ParametersForCategoryTbls)
                .HasForeignKey(d => d.Pccode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Parameter__PCcod__2C3393D0");
        });

        modelBuilder.Entity<ProvidersCategoriesTbl>(entity =>
        {
            entity.HasKey(e => e.Pccode).HasName("PK__Provider__0C421EEF4D69F080");

            entity.ToTable("ProvidersCategories_tbl");

            entity.Property(e => e.Pccode).HasColumnName("PCcode");
            entity.Property(e => e.PcisDelete).HasColumnName("PCIsDelete");
            entity.Property(e => e.Pcname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PCname");
        });

        modelBuilder.Entity<ProvidersTbl>(entity =>
        {
            entity.HasKey(e => e.ProvCode).HasName("PK__Provider__E06F3136EC3D7854");

            entity.ToTable("Providers_tbl");

            entity.Property(e => e.OtherCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otherCategory");
            entity.Property(e => e.Pccode).HasColumnName("PCcode");
            entity.Property(e => e.ProvAddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ProvAdvertisementText)
                .HasMaxLength(999)
                .IsUnicode(false);
            entity.Property(e => e.ProvCity)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProvClip)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ProvEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProvLogo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProvPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic4)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic5)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic6)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic7)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvPic8)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProvStatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProvTitle)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.PccodeNavigation).WithMany(p => p.ProvidersTbls)
                .HasForeignKey(d => d.Pccode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Providers__PCcod__31EC6D26");

            entity.HasOne(d => d.User).WithMany(p => p.ProvidersTbls)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Providers__UserI__30F848ED");
        });

        modelBuilder.Entity<UsersTbl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users_tb__1788CCACFE7436EC");

            entity.ToTable("Users_tbl");

            entity.Property(e => e.UserId)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserFName");
            entity.Property(e => e.UserGender)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.UserLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserLName");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserPic)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
