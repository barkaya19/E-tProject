using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GknProject.Core.Models
{
    public partial class GknKargoErpContext : DbContext
    {
        public GknKargoErpContext()
        {
        }

        public GknKargoErpContext(DbContextOptions<GknKargoErpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAcentum> TblAcenta { get; set; } = null!;
        public virtual DbSet<TblAktarimMerkeziBolge> TblAktarimMerkeziBolges { get; set; } = null!;
        public virtual DbSet<TblAktarmaMerkezi> TblAktarmaMerkezis { get; set; } = null!;
        public virtual DbSet<TblAraclar> TblAraclars { get; set; } = null!;
        public virtual DbSet<TblAyarlar> TblAyarlars { get; set; } = null!;
        public virtual DbSet<TblBankaListe> TblBankaListes { get; set; } = null!;
        public virtual DbSet<TblBsSehir> TblBsSehirs { get; set; } = null!;
        public virtual DbSet<TblFaturalar> TblFaturalars { get; set; } = null!;
        public virtual DbSet<TblGidilenBolge> TblGidilenBolges { get; set; } = null!;
        public virtual DbSet<TblGonderiDurumlari> TblGonderiDurumlaris { get; set; } = null!;
        public virtual DbSet<TblGonderiHesaplama> TblGonderiHesaplamas { get; set; } = null!;
        public virtual DbSet<TblGonderiKargoJson> TblGonderiKargoJsons { get; set; } = null!;
        public virtual DbSet<TblGonderiTransfer> TblGonderiTransfers { get; set; } = null!;
        public virtual DbSet<TblGonderiUrunler> TblGonderiUrunlers { get; set; } = null!;
        public virtual DbSet<TblGonderiYukHiz> TblGonderiYukHizs { get; set; } = null!;
        public virtual DbSet<TblGonderiler> TblGonderilers { get; set; } = null!;
        public virtual DbSet<TblGonderilerAb> TblGonderilerAbs { get; set; } = null!;
        public virtual DbSet<TblGonderilerGb> TblGonderilerGbs { get; set; } = null!;
        public virtual DbSet<TblIl> TblIls { get; set; } = null!;
        public virtual DbSet<TblIlce> TblIlces { get; set; } = null!;
        public virtual DbSet<TblKullaniciYetkileri> TblKullaniciYetkileris { get; set; } = null!;
        public virtual DbSet<TblKullanicilar> TblKullanicilars { get; set; } = null!;
        public virtual DbSet<TblMesafeler> TblMesafelers { get; set; } = null!;
        public virtual DbSet<TblMobileLoginLog> TblMobileLoginLogs { get; set; } = null!;
        public virtual DbSet<TblMusteriAd> TblMusteriAds { get; set; } = null!;
        public virtual DbSet<TblMusteriAdresler> TblMusteriAdreslers { get; set; } = null!;
        public virtual DbSet<TblMusteriBanka> TblMusteriBankas { get; set; } = null!;
        public virtual DbSet<TblMusteriNotlari> TblMusteriNotlaris { get; set; } = null!;
        public virtual DbSet<TblMusteriOzellik> TblMusteriOzelliks { get; set; } = null!;
        public virtual DbSet<TblMusteriOzellikDurum> TblMusteriOzellikDurums { get; set; } = null!;
        public virtual DbSet<TblMusteriTemsilci> TblMusteriTemsilcis { get; set; } = null!;
        public virtual DbSet<TblMusteriler> TblMusterilers { get; set; } = null!;
        public virtual DbSet<TblPaketTipleri> TblPaketTipleris { get; set; } = null!;
        public virtual DbSet<TblSeferIlListesi> TblSeferIlListesis { get; set; } = null!;
        public virtual DbSet<TblSeferTransferMerkezi> TblSeferTransferMerkezis { get; set; } = null!;
        public virtual DbSet<TblSoforler> TblSoforlers { get; set; } = null!;
        public virtual DbSet<TblSozlemeler> TblSozlemelers { get; set; } = null!;
        public virtual DbSet<TblSubeler> TblSubelers { get; set; } = null!;
        public virtual DbSet<TblTasimaFirmalari> TblTasimaFirmalaris { get; set; } = null!;
        public virtual DbSet<TblTasimaFirmalariSoz> TblTasimaFirmalariSozs { get; set; } = null!;
        public virtual DbSet<TblTransfer> TblTransfers { get; set; } = null!;
        public virtual DbSet<TblTransferMuhurListe> TblTransferMuhurListes { get; set; } = null!;
        public virtual DbSet<TblUcrelendirmeSoz> TblUcrelendirmeSozs { get; set; } = null!;
        public virtual DbSet<TblUcrelendirmeSozTmp> TblUcrelendirmeSozTmps { get; set; } = null!;
        public virtual DbSet<TblUyruk> TblUyruks { get; set; } = null!;
        public virtual DbSet<TblYasakBolge> TblYasakBolges { get; set; } = null!;
        public virtual DbSet<TblYetkiler> TblYetkilers { get; set; } = null!;
        public virtual DbSet<TblYukHizmet> TblYukHizmets { get; set; } = null!;
        public virtual DbSet<TblYukHizmetSoz> TblYukHizmetSozs { get; set; } = null!;
        public virtual DbSet<VwGetRandvalue> VwGetRandvalues { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.100.60.36; Initial Catalog=GknKargoErp;User ID=sa;Password=gkn123321!;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<TblAcentum>(entity =>
            {
                entity.HasKey(e => e.StAcentaId);

                entity.ToTable("tblAcenta");

                entity.Property(e => e.StAcentaId).HasColumnName("stAcentaId");

                entity.Property(e => e.StAcentaAdi).HasColumnName("stAcentaAdi");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi");
            });

            modelBuilder.Entity<TblAktarimMerkeziBolge>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblAktarimMerkeziBolge");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StIl).HasColumnName("stIl");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(90)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StIlce).HasColumnName("stIlce");

                entity.Property(e => e.StIlceAd)
                    .HasMaxLength(90)
                    .HasColumnName("stIlceAd");

                entity.Property(e => e.StMahalle).HasColumnName("stMahalle");

                entity.Property(e => e.StMahalleAd)
                    .HasMaxLength(90)
                    .HasColumnName("stMahalleAd");

                entity.Property(e => e.StMerkezId).HasColumnName("stMerkezId");
            });

            modelBuilder.Entity<TblAktarmaMerkezi>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblAktarmaMerkezi");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAd)
                    .HasMaxLength(150)
                    .HasColumnName("stAd");

                entity.Property(e => e.StIl).HasColumnName("stIl");

                entity.Property(e => e.StIlce).HasColumnName("stIlce");

                entity.Property(e => e.StMahalle).HasColumnName("stMahalle");
            });

            modelBuilder.Entity<TblAraclar>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblAraclar");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAracDesi).HasColumnName("stAracDesi");

                entity.Property(e => e.StAracTip)
                    .HasMaxLength(50)
                    .HasColumnName("stAracTip");

                entity.Property(e => e.StAracToken)
                    .HasMaxLength(100)
                    .HasColumnName("stAracToken");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPlaka)
                    .HasMaxLength(50)
                    .HasColumnName("stPlaka");

                entity.Property(e => e.StSofor).HasColumnName("stSofor");
            });

            modelBuilder.Entity<TblAyarlar>(entity =>
            {
                entity.HasKey(e => e.StAyarId);

                entity.ToTable("tblAyarlar");

                entity.Property(e => e.StAyarId).HasColumnName("stAyarId");

                entity.Property(e => e.StAyarDeger).HasColumnName("stAyarDeger");

                entity.Property(e => e.StAyarKey)
                    .HasMaxLength(50)
                    .HasColumnName("stAyarKey");
            });

            modelBuilder.Entity<TblBankaListe>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblBankaListe");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StBankaAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stBankaAdi");

                entity.Property(e => e.StBankaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("stBankaKodu");
            });

            modelBuilder.Entity<TblBsSehir>(entity =>
            {
                entity.ToTable("tblBsSehir");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(150)
                    .HasColumnName("ADI");

                entity.Property(e => e.Geo).HasColumnName("GEO");

                entity.Property(e => e.IlId).HasColumnName("IL_ID");

                entity.Property(e => e.Laty).HasColumnName("LATY");

                entity.Property(e => e.Longx).HasColumnName("LONGX");

                entity.Property(e => e.Nufus).HasColumnName("NUFUS");

                entity.Property(e => e.Uavtkodu).HasColumnName("UAVTKODU");

                entity.Property(e => e.UlkeId).HasColumnName("ULKE_ID");
            });

            modelBuilder.Entity<TblFaturalar>(entity =>
            {
                entity.HasKey(e => e.StFaturaId);

                entity.ToTable("tblFaturalar");

                entity.Property(e => e.StFaturaId).HasColumnName("stFaturaId");

                entity.Property(e => e.StAcentaId).HasColumnName("stAcentaId");

                entity.Property(e => e.StBaslangic)
                    .HasColumnType("datetime")
                    .HasColumnName("stBaslangic");

                entity.Property(e => e.StBitis)
                    .HasColumnType("datetime")
                    .HasColumnName("stBitis");

                entity.Property(e => e.StFaturaPeriyod)
                    .HasMaxLength(20)
                    .HasColumnName("stFaturaPeriyod");

                entity.Property(e => e.StFaturaPrefix)
                    .HasMaxLength(10)
                    .HasColumnName("stFaturaPrefix");

                entity.Property(e => e.StFaturaTutar)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("stFaturaTutar");

                entity.Property(e => e.StGonderiAdet).HasColumnName("stGonderiAdet");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StOlusturanKullanici).HasColumnName("stOlusturanKullanici");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StToplamKdv)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("stToplamKdv");
            });

            modelBuilder.Entity<TblGidilenBolge>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGidilenBolge");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAktarmaMerkezi).HasColumnName("stAktarmaMerkezi");

                entity.Property(e => e.StCariId).HasColumnName("stCariId");

                entity.Property(e => e.StCmrt)
                    .HasColumnName("stCmrt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StCrs)
                    .HasColumnName("stCrs")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StCum)
                    .HasColumnName("stCum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StEkTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stEkTutar");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StIlId).HasColumnName("stIlId");

                entity.Property(e => e.StIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlceAd");

                entity.Property(e => e.StIlceId).HasColumnName("stIlceId");

                entity.Property(e => e.StKargoId).HasColumnName("stKargoId");

                entity.Property(e => e.StMahalleAd)
                    .HasMaxLength(100)
                    .HasColumnName("stMahalleAd");

                entity.Property(e => e.StMahalleId).HasColumnName("stMahalleId");

                entity.Property(e => e.StOlusturan).HasColumnName("stOlusturan");

                entity.Property(e => e.StOlusturma)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturma")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StPers)
                    .HasColumnName("stPers")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPzr)
                    .HasColumnName("stPzr")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPzt)
                    .HasColumnName("stPzt")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StSali)
                    .HasColumnName("stSali")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblGonderiDurumlari>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderiDurumlari");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("stId");

                entity.Property(e => e.StAciklama)
                    .HasMaxLength(250)
                    .HasColumnName("stAciklama");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StSira).HasColumnName("stSira");
            });

            modelBuilder.Entity<TblGonderiHesaplama>(entity =>
            {
                entity.HasKey(e => e.StGonderiId);

                entity.ToTable("tblGonderiHesaplama");

                entity.Property(e => e.StGonderiId)
                    .ValueGeneratedNever()
                    .HasColumnName("stGonderiId");

                entity.Property(e => e.StArtanDesiId).HasColumnName("stArtanDesiId");

                entity.Property(e => e.StArtanDesiMiktar).HasColumnName("stArtanDesiMiktar");

                entity.Property(e => e.StArtanDesiTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stArtanDesiTutar");

                entity.Property(e => e.StErr)
                    .HasMaxLength(100)
                    .HasColumnName("stErr");

                entity.Property(e => e.StErrId).HasColumnName("stErrId");

                entity.Property(e => e.StKdvTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKdvTutar");

                entity.Property(e => e.StKuralAlici)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKuralAlici");

                entity.Property(e => e.StKuralArtanDesi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKuralArtanDesi");

                entity.Property(e => e.StKuralAyniGun)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKuralAyniGun");

                entity.Property(e => e.StKuralHesapAgirlik)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKuralHesapAgirlik");

                entity.Property(e => e.StKuralId).HasColumnName("stKuralId");

                entity.Property(e => e.StKuralTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stKuralTutar");

                entity.Property(e => e.StPoligonTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stPoligonTutar");

                entity.Property(e => e.StPostaHizmetBedeli)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stPostaHizmetBedeli");

                entity.Property(e => e.StSozlesmeTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stSozlesmeTutar");

                entity.Property(e => e.StToplamTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stToplamTutar");

                entity.Property(e => e.StYukHizmetJson).HasColumnName("stYukHizmetJson");

                entity.Property(e => e.StYukHizmetTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stYukHizmetTutar");
            });

            modelBuilder.Entity<TblGonderiKargoJson>(entity =>
            {
                entity.HasKey(e => e.StGonderiId);

                entity.ToTable("tblGonderiKargoJson");

                entity.Property(e => e.StGonderiId)
                    .ValueGeneratedNever()
                    .HasColumnName("stGonderiId");

                entity.Property(e => e.StGonderiJson).HasColumnName("stGonderiJson");
            });

            modelBuilder.Entity<TblGonderiTransfer>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderiTransfer");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("stCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StGonderiId).HasColumnName("stGonderiId");

                entity.Property(e => e.StTransferId).HasColumnName("stTransferId");
            });

            modelBuilder.Entity<TblGonderiUrunler>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_GonderiUrunler");

                entity.ToTable("tblGonderiUrunler");

                entity.HasIndex(e => e.StShipmentId, "IX_tblGonderiUrunler");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAgirlik)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stAgirlik");

                entity.Property(e => e.StBarcode)
                    .HasMaxLength(20)
                    .HasColumnName("stBarcode");

                entity.Property(e => e.StBoy)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stBoy");

                entity.Property(e => e.StDesi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stDesi");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StEn)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stEn");

                entity.Property(e => e.StGuId)
                    .HasMaxLength(150)
                    .HasColumnName("stGuId");

                entity.Property(e => e.StHacim)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stHacim");

                entity.Property(e => e.StMiktar).HasColumnName("stMiktar");

                entity.Property(e => e.StOlusturanUser).HasColumnName("stOlusturanUser");

                entity.Property(e => e.StOlusturmatarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmatarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StShipmentId).HasColumnName("stShipmentId");

                entity.Property(e => e.StSubBarcodeNo).HasColumnName("stSubBarcodeNo");

                entity.Property(e => e.StTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stTutar");

                entity.Property(e => e.StUrunAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stUrunAdi");

                entity.Property(e => e.StYukseklik)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stYukseklik");
            });

            modelBuilder.Entity<TblGonderiYukHiz>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderiYukHiz");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StGonderiId).HasColumnName("stGonderiId");

                entity.Property(e => e.StOlusturan).HasColumnName("stOlusturan");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StYukHizmetId).HasColumnName("stYukHizmetId");
            });

            modelBuilder.Entity<TblGonderiler>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderiler");

                entity.HasIndex(e => e.StGuId, "NonClusteredIndex-20220521-184608");

                entity.HasIndex(e => e.StBarcode, "NonClusteredIndex-20220705-160426")
                    .IsUnique();

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAliciAd)
                    .HasMaxLength(250)
                    .HasColumnName("stAliciAd");

                entity.Property(e => e.StAliciAdresId).HasColumnName("stAliciAdresId");

                entity.Property(e => e.StAliciId).HasColumnName("stAliciId");

                entity.Property(e => e.StAliciTip).HasColumnName("stAliciTip");

                entity.Property(e => e.StBarcode).HasColumnName("stBarcode");

                entity.Property(e => e.StBilgiGirisRefNo)
                    .HasMaxLength(50)
                    .HasColumnName("stBilgiGirisRefNo");

                entity.Property(e => e.StCikisAkMer).HasColumnName("stCikisAkMer");

                entity.Property(e => e.StEklemeTip).HasColumnName("stEklemeTip");

                entity.Property(e => e.StFaturaId).HasColumnName("stFaturaId");

                entity.Property(e => e.StGonderiAdet).HasColumnName("stGonderiAdet");

                entity.Property(e => e.StGonderiDurumu).HasColumnName("stGonderiDurumu");

                entity.Property(e => e.StGondericiAd)
                    .HasMaxLength(250)
                    .HasColumnName("stGondericiAd");

                entity.Property(e => e.StGondericiId).HasColumnName("stGondericiId");

                entity.Property(e => e.StGondericiTip).HasColumnName("stGondericiTip");

                entity.Property(e => e.StGuId).HasColumnName("stGuId");

                entity.Property(e => e.StIrsaliyeFatNo)
                    .HasMaxLength(50)
                    .HasColumnName("stIrsaliyeFatNo");

                entity.Property(e => e.StMalBedel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stMalBedel");

                entity.Property(e => e.StMesafe).HasColumnName("stMesafe");

                entity.Property(e => e.StMusteriRefNo)
                    .HasMaxLength(50)
                    .HasColumnName("stMusteriRefNo");

                entity.Property(e => e.StNavlun)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stNavlun");

                entity.Property(e => e.StOdemeFirmaId).HasColumnName("stOdemeFirmaId");

                entity.Property(e => e.StOdemeSekli).HasColumnName("stOdemeSekli");

                entity.Property(e => e.StOlusturan).HasColumnName("stOlusturan");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StPaketTipi).HasColumnName("stPaketTipi");

                entity.Property(e => e.StRiskMalKiy)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stRiskMalKiy");

                entity.Property(e => e.StServisTipi).HasColumnName("stServisTipi");

                entity.Property(e => e.StSigBedel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stSigBedel");

                entity.Property(e => e.StTahminiTeslimGun)
                    .HasColumnName("stTahminiTeslimGun")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StTasiyiciId).HasColumnName("stTasiyiciId");

                entity.Property(e => e.StTeslimMail)
                    .HasMaxLength(100)
                    .HasColumnName("stTeslimMail");

                entity.Property(e => e.StTeslimZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("stTeslimZamani");

                entity.Property(e => e.StTeslimZamaniOng)
                    .HasColumnType("datetime")
                    .HasColumnName("stTeslimZamaniOng");

                entity.Property(e => e.StToplamaSubeId).HasColumnName("stToplamaSubeId");

                entity.Property(e => e.StTransfer).HasColumnName("stTransfer");

                entity.Property(e => e.StTransferTmp).HasColumnName("stTransferTmp");

                entity.Property(e => e.StVarisAkMer).HasColumnName("stVarisAkMer");

                entity.Property(e => e.StYukHizmet)
                    .HasColumnType("text")
                    .HasColumnName("stYukHizmet");

                entity.Property(e => e.StZimmet).HasColumnName("stZimmet");
            });

            modelBuilder.Entity<TblGonderilerAb>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderilerAB");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.AbAdresId).HasColumnName("AB_AdresId");

                entity.Property(e => e.AbGfAd)
                    .HasMaxLength(100)
                    .HasColumnName("AB_GF_Ad");

                entity.Property(e => e.AbGfApt)
                    .HasMaxLength(100)
                    .HasColumnName("AB_GF_Apt");

                entity.Property(e => e.AbGfAptNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_AptNo");

                entity.Property(e => e.AbGfCinisyet)
                    .HasMaxLength(15)
                    .HasColumnName("AB_GF_Cinisyet");

                entity.Property(e => e.AbGfDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_DaireNo");

                entity.Property(e => e.AbGfIlce).HasColumnName("AB_GF_Ilce");

                entity.Property(e => e.AbGfIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_IlceAd");

                entity.Property(e => e.AbGfMahalle).HasColumnName("AB_GF_Mahalle");

                entity.Property(e => e.AbGfMahalleAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_MahalleAd");

                entity.Property(e => e.AbGfPk)
                    .HasMaxLength(20)
                    .HasColumnName("AB_GF_Pk");

                entity.Property(e => e.AbGfSehir).HasColumnName("AB_GF_Sehir");

                entity.Property(e => e.AbGfSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_SehirAd");

                entity.Property(e => e.AbGfSokak)
                    .HasMaxLength(250)
                    .HasColumnName("AB_GF_Sokak");

                entity.Property(e => e.AbGfSoyad)
                    .HasMaxLength(100)
                    .HasColumnName("AB_GF_Soyad");

                entity.Property(e => e.AbGfTcNo)
                    .HasMaxLength(15)
                    .HasColumnName("AB_GF_TcNo");

                entity.Property(e => e.AbGfTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("AB_GF_Telefon");

                entity.Property(e => e.AbGfUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("AB_GF_Uyruk");

                entity.Property(e => e.AbGuId).HasColumnName("AB_GuId");

                entity.Property(e => e.AbOlusturan).HasColumnName("AB_Olusturan");

                entity.Property(e => e.AbOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("AB_OlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AbStAd)
                    .HasMaxLength(150)
                    .HasColumnName("AB_stAd");

                entity.Property(e => e.AbStApartman)
                    .HasMaxLength(70)
                    .HasColumnName("AB_stApartman");

                entity.Property(e => e.AbStBinaNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_stBinaNo");

                entity.Property(e => e.AbStCadde)
                    .HasMaxLength(150)
                    .HasColumnName("AB_stCadde");

                entity.Property(e => e.AbStCariId).HasColumnName("AB_stCariId");

                entity.Property(e => e.AbStCins)
                    .HasMaxLength(15)
                    .HasColumnName("AB_stCins");

                entity.Property(e => e.AbStDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_stDaireNo");

                entity.Property(e => e.AbStIl).HasColumnName("AB_stIl");

                entity.Property(e => e.AbStIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("AB_stIlAd");

                entity.Property(e => e.AbStIlce).HasColumnName("AB_stIlce");

                entity.Property(e => e.AbStIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("AB_stIlceAd");

                entity.Property(e => e.AbStIlgiliEposta)
                    .HasMaxLength(150)
                    .HasColumnName("AB_stIlgiliEposta");

                entity.Property(e => e.AbStIlgiliGsm)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stIlgiliGsm");

                entity.Property(e => e.AbStIlgiliKisi)
                    .HasMaxLength(150)
                    .HasColumnName("AB_stIlgiliKisi");

                entity.Property(e => e.AbStIlgiliTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stIlgiliTelefon");

                entity.Property(e => e.AbStMasrafKodu)
                    .HasMaxLength(30)
                    .HasColumnName("AB_stMasrafKodu");

                entity.Property(e => e.AbStPostaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stPostaKodu");

                entity.Property(e => e.AbStSemt).HasColumnName("AB_stSemt");

                entity.Property(e => e.AbStSemtAd)
                    .HasMaxLength(100)
                    .HasColumnName("AB_stSemtAd");

                entity.Property(e => e.AbStSoyad)
                    .HasMaxLength(150)
                    .HasColumnName("AB_stSoyad");

                entity.Property(e => e.AbStTc)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stTc");

                entity.Property(e => e.AbStTel)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stTel");

                entity.Property(e => e.AbStTip)
                    .HasMaxLength(50)
                    .HasColumnName("AB_stTip");

                entity.Property(e => e.AbStUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("AB_stUyruk");

                entity.Property(e => e.AbStVergiDairesi)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stVergiDairesi");

                entity.Property(e => e.AbStVergiNo)
                    .HasMaxLength(20)
                    .HasColumnName("AB_stVergiNo");

                entity.Property(e => e.AbUnvan)
                    .HasMaxLength(250)
                    .HasColumnName("AB_Unvan");

                entity.Property(e => e.AbYtAd)
                    .HasMaxLength(100)
                    .HasColumnName("AB_YT_Ad");

                entity.Property(e => e.AbYtApt)
                    .HasMaxLength(100)
                    .HasColumnName("AB_YT_Apt");

                entity.Property(e => e.AbYtAptNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_AptNo");

                entity.Property(e => e.AbYtCinisyet)
                    .HasMaxLength(15)
                    .HasColumnName("AB_YT_Cinisyet");

                entity.Property(e => e.AbYtDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_DaireNo");

                entity.Property(e => e.AbYtIlce).HasColumnName("AB_YT_Ilce");

                entity.Property(e => e.AbYtIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_IlceAd");

                entity.Property(e => e.AbYtMahalle).HasColumnName("AB_YT_Mahalle");

                entity.Property(e => e.AbYtMahalleAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_MahalleAd");

                entity.Property(e => e.AbYtPk)
                    .HasMaxLength(20)
                    .HasColumnName("AB_YT_Pk");

                entity.Property(e => e.AbYtSehir).HasColumnName("AB_YT_Sehir");

                entity.Property(e => e.AbYtSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_SehirAd");

                entity.Property(e => e.AbYtSokak)
                    .HasMaxLength(250)
                    .HasColumnName("AB_YT_Sokak");

                entity.Property(e => e.AbYtSoyad)
                    .HasMaxLength(100)
                    .HasColumnName("AB_YT_Soyad");

                entity.Property(e => e.AbYtTcNo)
                    .HasMaxLength(15)
                    .HasColumnName("AB_YT_TcNo");

                entity.Property(e => e.AbYtTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("AB_YT_Telefon");

                entity.Property(e => e.AbYtUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("AB_YT_Uyruk");

                entity.Property(e => e.StGonderiId).HasColumnName("stGonderiId");
            });

            modelBuilder.Entity<TblGonderilerGb>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblGonderilerGB");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.GbGfAd)
                    .HasMaxLength(100)
                    .HasColumnName("GB_GF_Ad");

                entity.Property(e => e.GbGfApt)
                    .HasMaxLength(100)
                    .HasColumnName("GB_GF_Apt");

                entity.Property(e => e.GbGfAptNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_AptNo");

                entity.Property(e => e.GbGfCinisyet)
                    .HasMaxLength(15)
                    .HasColumnName("GB_GF_Cinisyet");

                entity.Property(e => e.GbGfDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_DaireNo");

                entity.Property(e => e.GbGfIlce).HasColumnName("GB_GF_Ilce");

                entity.Property(e => e.GbGfIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_IlceAd");

                entity.Property(e => e.GbGfMahalle).HasColumnName("GB_GF_Mahalle");

                entity.Property(e => e.GbGfMahalleAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_MahalleAd");

                entity.Property(e => e.GbGfPk)
                    .HasMaxLength(20)
                    .HasColumnName("GB_GF_Pk");

                entity.Property(e => e.GbGfSehir).HasColumnName("GB_GF_Sehir");

                entity.Property(e => e.GbGfSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_SehirAd");

                entity.Property(e => e.GbGfSokak)
                    .HasMaxLength(250)
                    .HasColumnName("GB_GF_Sokak");

                entity.Property(e => e.GbGfSoyad)
                    .HasMaxLength(100)
                    .HasColumnName("GB_GF_Soyad");

                entity.Property(e => e.GbGfTcNo)
                    .HasMaxLength(15)
                    .HasColumnName("GB_GF_TcNo");

                entity.Property(e => e.GbGfTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("GB_GF_Telefon");

                entity.Property(e => e.GbGfUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("GB_GF_Uyruk");

                entity.Property(e => e.GbGuId).HasColumnName("GB_GuId");

                entity.Property(e => e.GbOlusturan).HasColumnName("GB_Olusturan");

                entity.Property(e => e.GbOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("GB_OlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GbStAd)
                    .HasMaxLength(150)
                    .HasColumnName("GB_stAd");

                entity.Property(e => e.GbStApartman)
                    .HasMaxLength(70)
                    .HasColumnName("GB_stApartman");

                entity.Property(e => e.GbStBinaNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_stBinaNo");

                entity.Property(e => e.GbStCadde)
                    .HasMaxLength(150)
                    .HasColumnName("GB_stCadde");

                entity.Property(e => e.GbStCariId).HasColumnName("GB_stCariId");

                entity.Property(e => e.GbStCins)
                    .HasMaxLength(15)
                    .HasColumnName("GB_stCins");

                entity.Property(e => e.GbStDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_stDaireNo");

                entity.Property(e => e.GbStIl).HasColumnName("GB_stIl");

                entity.Property(e => e.GbStIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("GB_stIlAd");

                entity.Property(e => e.GbStIlce).HasColumnName("GB_stIlce");

                entity.Property(e => e.GbStIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("GB_stIlceAd");

                entity.Property(e => e.GbStIlgiliEposta)
                    .HasMaxLength(150)
                    .HasColumnName("GB_stIlgiliEposta");

                entity.Property(e => e.GbStIlgiliGsm)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stIlgiliGsm");

                entity.Property(e => e.GbStIlgiliKisi)
                    .HasMaxLength(150)
                    .HasColumnName("GB_stIlgiliKisi");

                entity.Property(e => e.GbStIlgiliTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stIlgiliTelefon");

                entity.Property(e => e.GbStMasrafKodu)
                    .HasMaxLength(30)
                    .HasColumnName("GB_stMasrafKodu");

                entity.Property(e => e.GbStPostaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stPostaKodu");

                entity.Property(e => e.GbStSemt).HasColumnName("GB_stSemt");

                entity.Property(e => e.GbStSemtAd)
                    .HasMaxLength(100)
                    .HasColumnName("GB_stSemtAd");

                entity.Property(e => e.GbStSoyad)
                    .HasMaxLength(150)
                    .HasColumnName("GB_stSoyad");

                entity.Property(e => e.GbStTc)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stTc");

                entity.Property(e => e.GbStTel)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stTel");

                entity.Property(e => e.GbStTip)
                    .HasMaxLength(50)
                    .HasColumnName("GB_stTip");

                entity.Property(e => e.GbStUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("GB_stUyruk");

                entity.Property(e => e.GbStVergiDairesi)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stVergiDairesi");

                entity.Property(e => e.GbStVergiNo)
                    .HasMaxLength(20)
                    .HasColumnName("GB_stVergiNo");

                entity.Property(e => e.GbUnvan)
                    .HasMaxLength(250)
                    .HasColumnName("GB_Unvan");

                entity.Property(e => e.GbYtAd)
                    .HasMaxLength(100)
                    .HasColumnName("GB_YT_Ad");

                entity.Property(e => e.GbYtApt)
                    .HasMaxLength(100)
                    .HasColumnName("GB_YT_Apt");

                entity.Property(e => e.GbYtAptNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_AptNo");

                entity.Property(e => e.GbYtCinisyet)
                    .HasMaxLength(15)
                    .HasColumnName("GB_YT_Cinisyet");

                entity.Property(e => e.GbYtDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_DaireNo");

                entity.Property(e => e.GbYtIlce).HasColumnName("GB_YT_Ilce");

                entity.Property(e => e.GbYtIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_IlceAd");

                entity.Property(e => e.GbYtMahalle).HasColumnName("GB_YT_Mahalle");

                entity.Property(e => e.GbYtMahalleAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_MahalleAd");

                entity.Property(e => e.GbYtPk)
                    .HasMaxLength(20)
                    .HasColumnName("GB_YT_Pk");

                entity.Property(e => e.GbYtSehir).HasColumnName("GB_YT_Sehir");

                entity.Property(e => e.GbYtSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_SehirAd");

                entity.Property(e => e.GbYtSokak)
                    .HasMaxLength(250)
                    .HasColumnName("GB_YT_Sokak");

                entity.Property(e => e.GbYtSoyad)
                    .HasMaxLength(100)
                    .HasColumnName("GB_YT_Soyad");

                entity.Property(e => e.GbYtTcNo)
                    .HasMaxLength(15)
                    .HasColumnName("GB_YT_TcNo");

                entity.Property(e => e.GbYtTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("GB_YT_Telefon");

                entity.Property(e => e.GbYtUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("GB_YT_Uyruk");

                entity.Property(e => e.StGonderiId).HasColumnName("stGonderiId");
            });

            modelBuilder.Entity<TblIl>(entity =>
            {
                entity.HasKey(e => e.StIild);

                entity.ToTable("tblIl");

                entity.Property(e => e.StIild).HasColumnName("stIIld");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(150)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StPlakaKodu).HasColumnName("stPlakaKodu");
            });

            modelBuilder.Entity<TblIlce>(entity =>
            {
                entity.ToTable("tblIlce");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StIlceAdi)
                    .HasMaxLength(255)
                    .HasColumnName("stIlceAdi");

                entity.Property(e => e.StPlakaKodu).HasColumnName("stPlakaKodu");
            });

            modelBuilder.Entity<TblKullaniciYetkileri>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblKullaniciYetkileri");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAcces).HasColumnName("stAcces");

                entity.Property(e => e.StDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("stDateTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StPermissionId).HasColumnName("stPermissionId");

                entity.Property(e => e.StUserId).HasColumnName("stUserId");
            });

            modelBuilder.Entity<TblKullanicilar>(entity =>
            {
                entity.HasKey(e => e.StKullaniciId);

                entity.ToTable("tblKullanicilar");

                entity.Property(e => e.StKullaniciId).HasColumnName("stKullaniciId");

                entity.Property(e => e.StAd)
                    .HasMaxLength(50)
                    .HasColumnName("stAd");

                entity.Property(e => e.StAktarmaMerkezi).HasColumnName("stAktarmaMerkezi");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StGirisZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("stGirisZamani");

                entity.Property(e => e.StIp)
                    .HasMaxLength(50)
                    .HasColumnName("stIP");

                entity.Property(e => e.StKullaniciAdi)
                    .HasMaxLength(50)
                    .HasColumnName("stKullaniciAdi");

                entity.Property(e => e.StMailAdres)
                    .HasMaxLength(50)
                    .HasColumnName("stMailAdres");

                entity.Property(e => e.StMobilBosaltSeferId).HasColumnName("stMobilBosaltSeferId");

                entity.Property(e => e.StMobilBosaltSeferTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stMobilBosaltSeferTarihi");

                entity.Property(e => e.StMobilYukleSeferId).HasColumnName("stMobilYukleSeferId");

                entity.Property(e => e.StMobilYukleSeferTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stMobilYukleSeferTarihi");

                entity.Property(e => e.StMobileToken)
                    .HasMaxLength(100)
                    .HasColumnName("stMobileToken")
                    .HasDefaultValueSql("(N'156c399a-5da3-4b9b-bd3c-474796338bc5')");

                entity.Property(e => e.StSifre)
                    .HasMaxLength(250)
                    .HasColumnName("stSifre");

                entity.Property(e => e.StSoyad)
                    .HasMaxLength(50)
                    .HasColumnName("stSoyad");
            });

            modelBuilder.Entity<TblMesafeler>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblMesafeler");

                entity.HasIndex(e => e.StBaslaIlId, "NonClusteredIndex-20220519-160302");

                entity.HasIndex(e => e.StBaslaIlceId, "NonClusteredIndex-20220519-160317");

                entity.HasIndex(e => e.StBitirIlId, "NonClusteredIndex-20220519-160327");

                entity.HasIndex(e => e.StBitirIlceId, "NonClusteredIndex-20220519-160336");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StBaslaIlId).HasColumnName("stBaslaIlId");

                entity.Property(e => e.StBaslaIlceId).HasColumnName("stBaslaIlceId");

                entity.Property(e => e.StBitirIlId).HasColumnName("stBitirIlId");

                entity.Property(e => e.StBitirIlceId).HasColumnName("stBitirIlceId");

                entity.Property(e => e.StGun)
                    .HasColumnName("stGun")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StMesafe).HasColumnName("stMesafe");
            });

            modelBuilder.Entity<TblMobileLoginLog>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblMobileLoginLog");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StBarcode)
                    .HasMaxLength(50)
                    .HasColumnName("stBarcode");

                entity.Property(e => e.StMobilToken)
                    .HasMaxLength(50)
                    .HasColumnName("stMobilToken");
            });

            modelBuilder.Entity<TblMusteriAd>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PK_tblMusteriAD_1");

                entity.ToTable("tblMusteriAD");

                entity.Property(e => e.AdId).HasColumnName("AD_Id");

                entity.Property(e => e.AdHash)
                    .HasMaxLength(250)
                    .HasColumnName("AD_Hash");

                entity.Property(e => e.AdOlusturan).HasColumnName("AD_Olusturan");

                entity.Property(e => e.AdOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("AD_OlusturmaTarihi");

                entity.Property(e => e.AdSahisMi).HasColumnName("AD_SahisMi");

                entity.Property(e => e.AdStAd)
                    .HasMaxLength(150)
                    .HasColumnName("AD_stAd");

                entity.Property(e => e.AdStApartman)
                    .HasMaxLength(70)
                    .HasColumnName("AD_stApartman");

                entity.Property(e => e.AdStBinaNo)
                    .HasMaxLength(50)
                    .HasColumnName("AD_stBinaNo");

                entity.Property(e => e.AdStCadde)
                    .HasMaxLength(150)
                    .HasColumnName("AD_stCadde");

                entity.Property(e => e.AdStCins)
                    .HasMaxLength(15)
                    .HasColumnName("AD_stCins");

                entity.Property(e => e.AdStDaireNo)
                    .HasMaxLength(50)
                    .HasColumnName("AD_stDaireNo");

                entity.Property(e => e.AdStIl).HasColumnName("AD_stIl");

                entity.Property(e => e.AdStIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("AD_stIlAd");

                entity.Property(e => e.AdStIlce).HasColumnName("AD_stIlce");

                entity.Property(e => e.AdStIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("AD_stIlceAd");

                entity.Property(e => e.AdStIlgiliEposta)
                    .HasMaxLength(150)
                    .HasColumnName("AD_stIlgiliEposta");

                entity.Property(e => e.AdStIlgiliGsm)
                    .HasMaxLength(20)
                    .HasColumnName("AD_stIlgiliGsm");

                entity.Property(e => e.AdStIlgiliKisi)
                    .HasMaxLength(150)
                    .HasColumnName("AD_stIlgiliKisi");

                entity.Property(e => e.AdStIlgiliTelefon)
                    .HasMaxLength(20)
                    .HasColumnName("AD_stIlgiliTelefon");

                entity.Property(e => e.AdStMusteriGuId).HasColumnName("AD_stMusteriGuId");

                entity.Property(e => e.AdStMusteriId).HasColumnName("AD_stMusteriId");

                entity.Property(e => e.AdStPostaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("AD_stPostaKodu");

                entity.Property(e => e.AdStSemt).HasColumnName("AD_stSemt");

                entity.Property(e => e.AdStSemtAd)
                    .HasMaxLength(100)
                    .HasColumnName("AD_stSemtAd");

                entity.Property(e => e.AdStSoyad)
                    .HasMaxLength(150)
                    .HasColumnName("AD_stSoyad");

                entity.Property(e => e.AdStTc)
                    .HasMaxLength(20)
                    .HasColumnName("AD_stTc");

                entity.Property(e => e.AdStTel)
                    .HasMaxLength(20)
                    .HasColumnName("AD_stTel");

                entity.Property(e => e.AdStUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("AD_stUyruk");

                entity.Property(e => e.AdStVergiDairesi)
                    .HasMaxLength(80)
                    .HasColumnName("AD_stVergiDairesi");

                entity.Property(e => e.AdStVergiNo)
                    .HasMaxLength(50)
                    .HasColumnName("AD_stVergiNo");

                entity.Property(e => e.AdUnvan)
                    .HasMaxLength(250)
                    .HasColumnName("AD_Unvan");
            });

            modelBuilder.Entity<TblMusteriAdresler>(entity =>
            {
                entity.HasKey(e => e.StAdresId)
                    .HasName("PK_tblAdresler");

                entity.ToTable("tblMusteriAdresler");

                entity.Property(e => e.StAdresId).HasColumnName("stAdresId");

                entity.Property(e => e.SGuId)
                    .HasMaxLength(250)
                    .HasColumnName("sGuId");

                entity.Property(e => e.StAdresAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stAdresAdi");

                entity.Property(e => e.StAdresTipiId)
                    .HasMaxLength(250)
                    .HasColumnName("stAdresTipiId");

                entity.Property(e => e.StApartman)
                    .HasMaxLength(250)
                    .HasColumnName("stApartman");

                entity.Property(e => e.StBinaNo)
                    .HasMaxLength(10)
                    .HasColumnName("stBinaNo");

                entity.Property(e => e.StCadde)
                    .HasMaxLength(250)
                    .HasColumnName("stCadde");

                entity.Property(e => e.StDaireNo)
                    .HasMaxLength(10)
                    .HasColumnName("stDaireNo");

                entity.Property(e => e.StEkUcret).HasColumnName("stEkUcret");

                entity.Property(e => e.StEkUcretAciklama)
                    .HasMaxLength(250)
                    .HasColumnName("stEkUcretAciklama");

                entity.Property(e => e.StEposta)
                    .HasMaxLength(150)
                    .HasColumnName("stEposta");

                entity.Property(e => e.StFax)
                    .HasMaxLength(50)
                    .HasColumnName("stFax");

                entity.Property(e => e.StGsm)
                    .HasMaxLength(50)
                    .HasColumnName("stGsm");

                entity.Property(e => e.StIl).HasColumnName("stIl");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StIlce).HasColumnName("stIlce");

                entity.Property(e => e.StIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlceAd");

                entity.Property(e => e.StKisi)
                    .HasMaxLength(150)
                    .HasColumnName("stKisi");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StOlusturanKulaniciId).HasColumnName("stOlusturanKulaniciId");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi");

                entity.Property(e => e.StPostaKodu)
                    .HasMaxLength(10)
                    .HasColumnName("stPostaKodu");

                entity.Property(e => e.StSemt).HasColumnName("stSemt");

                entity.Property(e => e.StSemtAd)
                    .HasMaxLength(100)
                    .HasColumnName("stSemtAd");

                entity.Property(e => e.StTelefon)
                    .HasMaxLength(50)
                    .HasColumnName("stTelefon");
            });

            modelBuilder.Entity<TblMusteriBanka>(entity =>
            {
                entity.HasKey(e => e.StBankaBilgiId)
                    .HasName("PK_tblMusteriNotlari");

                entity.ToTable("tblMusteriBanka");

                entity.Property(e => e.StBankaBilgiId).HasColumnName("stBankaBilgiId");

                entity.Property(e => e.StAdSoyad)
                    .HasMaxLength(250)
                    .HasColumnName("stAdSoyad");

                entity.Property(e => e.StBankaId)
                    .HasMaxLength(250)
                    .HasColumnName("stBankaId");

                entity.Property(e => e.StHesapNo)
                    .HasMaxLength(50)
                    .HasColumnName("stHesapNo");

                entity.Property(e => e.StIban)
                    .HasMaxLength(50)
                    .HasColumnName("stIban");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StParaBirimiId)
                    .HasMaxLength(10)
                    .HasColumnName("stParaBirimiId");

                entity.Property(e => e.StSubeAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stSubeAdi");

                entity.Property(e => e.StSubeKodu)
                    .HasMaxLength(50)
                    .HasColumnName("stSubeKodu");
            });

            modelBuilder.Entity<TblMusteriNotlari>(entity =>
            {
                entity.HasKey(e => e.StMusteriNotId)
                    .HasName("PK_tblMusteriNotları");

                entity.ToTable("tblMusteriNotlari");

                entity.Property(e => e.StMusteriNotId).HasColumnName("stMusteriNotId");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StNot)
                    .HasColumnType("text")
                    .HasColumnName("stNot");

                entity.Property(e => e.StNotHatTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("stNotHatTarih");

                entity.Property(e => e.StNotMail)
                    .HasColumnType("text")
                    .HasColumnName("stNotMail");

                entity.Property(e => e.StNotTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stNotTarihi");

                entity.Property(e => e.StOlusturanKullaniciId).HasColumnName("stOlusturanKullaniciId");
            });

            modelBuilder.Entity<TblMusteriOzellik>(entity =>
            {
                entity.HasKey(e => e.StOzellikId);

                entity.ToTable("tblMusteriOzellik");

                entity.Property(e => e.StOzellikId).HasColumnName("stOzellikId");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StOzelikTuruId).HasColumnName("stOzelikTuruId");

                entity.Property(e => e.StOzellikAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stOzellikAdi");

                entity.Property(e => e.StSira).HasColumnName("stSira");
            });

            modelBuilder.Entity<TblMusteriOzellikDurum>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblMusteriOzellikDurum");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StIzinId).HasColumnName("stIzinId");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");
            });

            modelBuilder.Entity<TblMusteriTemsilci>(entity =>
            {
                entity.HasKey(e => e.StMusteriTemsilciId);

                entity.ToTable("tblMusteriTemsilci");

                entity.Property(e => e.StMusteriTemsilciId).HasColumnName("stMusteriTemsilciId");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.StAdSoyad)
                    .HasMaxLength(200)
                    .HasColumnName("stAdSoyad");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StMailAdres)
                    .HasMaxLength(50)
                    .HasColumnName("stMailAdres");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StTelNo)
                    .HasMaxLength(50)
                    .HasColumnName("stTelNo");
            });

            modelBuilder.Entity<TblMusteriler>(entity =>
            {
                entity.HasKey(e => e.StMusteriId);

                entity.ToTable("tblMusteriler");

                entity.Property(e => e.StMusteriId).HasColumnName("stMusteriId");

                entity.Property(e => e.StAcentaId).HasColumnName("stAcentaId");

                entity.Property(e => e.StAd)
                    .HasMaxLength(50)
                    .HasColumnName("stAd");

                entity.Property(e => e.StAdUnvan)
                    .HasMaxLength(250)
                    .HasColumnName("stAdUnvan");

                entity.Property(e => e.StAlOdBenSozHesap).HasColumnName("stAlOdBenSozHesap");

                entity.Property(e => e.StAnaHesapId).HasColumnName("stAnaHesapId");

                entity.Property(e => e.StApartman)
                    .HasMaxLength(100)
                    .HasColumnName("stApartman");

                entity.Property(e => e.StAptNo)
                    .HasMaxLength(20)
                    .HasColumnName("stAptNo");

                entity.Property(e => e.StBeklenenCiro).HasColumnName("stBeklenenCiro");

                entity.Property(e => e.StBolgeId).HasColumnName("stBolgeId");

                entity.Property(e => e.StCadde)
                    .HasMaxLength(250)
                    .HasColumnName("stCadde");

                entity.Property(e => e.StCariDisSubesiId).HasColumnName("stCariDisSubesiId");

                entity.Property(e => e.StCariKod)
                    .HasMaxLength(30)
                    .HasColumnName("stCariKod");

                entity.Property(e => e.StCariSuspanSubeId).HasColumnName("stCariSuspanSubeId");

                entity.Property(e => e.StCinsiyet)
                    .HasMaxLength(10)
                    .HasColumnName("stCinsiyet");

                entity.Property(e => e.StDaireNo)
                    .HasMaxLength(20)
                    .HasColumnName("stDaireNo");

                entity.Property(e => e.StDefaultFormAb)
                    .HasMaxLength(50)
                    .HasColumnName("stDefaultFormAB");

                entity.Property(e => e.StDefaultFormGb)
                    .HasMaxLength(50)
                    .HasColumnName("stDefaultFormGB");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StFaturalasmaSuresi).HasColumnName("stFaturalasmaSuresi");

                entity.Property(e => e.StGirisZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("stGirisZamani");

                entity.Property(e => e.StGuId).HasColumnName("stGuId");

                entity.Property(e => e.StHerkeseGonder).HasColumnName("stHerkeseGonder");

                entity.Property(e => e.StHesapTipiId).HasColumnName("stHesapTipiId");

                entity.Property(e => e.StHesapTuruId).HasColumnName("stHesapTuruId");

                entity.Property(e => e.StIhbarCalismaGun).HasColumnName("stIhbarCalismaGun");

                entity.Property(e => e.StIhbarCalismaSaat)
                    .HasMaxLength(5)
                    .HasColumnName("stIhbarCalismaSaat");

                entity.Property(e => e.StIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("stIlceAd");

                entity.Property(e => e.StIlceId).HasColumnName("stIlceId");

                entity.Property(e => e.StKullaniciAdi)
                    .HasMaxLength(50)
                    .HasColumnName("stKullaniciAdi");

                entity.Property(e => e.StMagazaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("stMagazaKodu");

                entity.Property(e => e.StMahalleAd)
                    .HasMaxLength(50)
                    .HasColumnName("stMahalleAd");

                entity.Property(e => e.StMahalleId).HasColumnName("stMahalleId");

                entity.Property(e => e.StMusteriTemsilciId).HasColumnName("stMusteriTemsilciId");

                entity.Property(e => e.StMusteriTipId).HasColumnName("stMusteriTipId");

                entity.Property(e => e.StOdemeTipiId).HasColumnName("stOdemeTipiId");

                entity.Property(e => e.StOdemeVadesi).HasColumnName("stOdemeVadesi");

                entity.Property(e => e.StOlusturanKulaniciId).HasColumnName("stOlusturanKulaniciId");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi");

                entity.Property(e => e.StPerAbadres)
                    .HasColumnName("stPerABAdres")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerAbcari)
                    .HasColumnName("stPerABCari")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerAbyb)
                    .HasColumnName("stPerABYb")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerAbyk)
                    .HasColumnName("stPerABYk")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerGbcari)
                    .HasColumnName("stPerGBCari")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerGbyb)
                    .HasColumnName("stPerGBYb")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPerGbyk)
                    .HasColumnName("stPerGBYk")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StPostaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("stPostaKodu");

                entity.Property(e => e.StSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("stSehirAd");

                entity.Property(e => e.StSehirId).HasColumnName("stSehirId");

                entity.Property(e => e.StSifre)
                    .HasMaxLength(250)
                    .HasColumnName("stSifre");

                entity.Property(e => e.StSoyad)
                    .HasMaxLength(50)
                    .HasColumnName("stSoyad");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StSubeId).HasColumnName("stSubeId");

                entity.Property(e => e.StTahsilatTipi)
                    .HasMaxLength(50)
                    .HasColumnName("stTahsilatTipi");

                entity.Property(e => e.StTcNo)
                    .HasMaxLength(11)
                    .HasColumnName("stTcNo");

                entity.Property(e => e.StTelefonNo)
                    .HasMaxLength(25)
                    .HasColumnName("stTelefonNo");

                entity.Property(e => e.StUnvani)
                    .HasMaxLength(250)
                    .HasColumnName("stUnvani");

                entity.Property(e => e.StUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("stUyruk");

                entity.Property(e => e.StVergiDairesi)
                    .HasMaxLength(150)
                    .HasColumnName("stVergiDairesi");

                entity.Property(e => e.StVergiNo)
                    .HasMaxLength(20)
                    .HasColumnName("stVergiNo");

                entity.Property(e => e.StYetAd)
                    .HasMaxLength(50)
                    .HasColumnName("stYetAd");

                entity.Property(e => e.StYetApartman)
                    .HasMaxLength(100)
                    .HasColumnName("stYetApartman");

                entity.Property(e => e.StYetAptNo)
                    .HasMaxLength(20)
                    .HasColumnName("stYetAptNo");

                entity.Property(e => e.StYetCadde)
                    .HasMaxLength(250)
                    .HasColumnName("stYetCadde");

                entity.Property(e => e.StYetCins)
                    .HasMaxLength(10)
                    .HasColumnName("stYetCins");

                entity.Property(e => e.StYetDaireNo)
                    .HasMaxLength(20)
                    .HasColumnName("stYetDaireNo");

                entity.Property(e => e.StYetIlceAd)
                    .HasMaxLength(50)
                    .HasColumnName("stYetIlceAd");

                entity.Property(e => e.StYetIlceId).HasColumnName("stYetIlceId");

                entity.Property(e => e.StYetMahAd)
                    .HasMaxLength(50)
                    .HasColumnName("stYetMahAd");

                entity.Property(e => e.StYetMahId).HasColumnName("stYetMahId");

                entity.Property(e => e.StYetPostaKodu)
                    .HasMaxLength(20)
                    .HasColumnName("stYetPostaKodu");

                entity.Property(e => e.StYetSehirAd)
                    .HasMaxLength(50)
                    .HasColumnName("stYetSehirAd");

                entity.Property(e => e.StYetSehirId).HasColumnName("stYetSehirId");

                entity.Property(e => e.StYetSoyad)
                    .HasMaxLength(50)
                    .HasColumnName("stYetSoyad");

                entity.Property(e => e.StYetTc)
                    .HasMaxLength(20)
                    .HasColumnName("stYetTc");

                entity.Property(e => e.StYetTel)
                    .HasMaxLength(25)
                    .HasColumnName("stYetTel");

                entity.Property(e => e.StYetUyruk)
                    .HasMaxLength(50)
                    .HasColumnName("stYetUyruk");
            });

            modelBuilder.Entity<TblPaketTipleri>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblPaketTipleri");

                entity.Property(e => e.StId)
                    .ValueGeneratedNever()
                    .HasColumnName("stId");

                entity.Property(e => e.StPaketTipAd)
                    .HasMaxLength(150)
                    .HasColumnName("stPaketTipAd");
            });

            modelBuilder.Entity<TblSeferIlListesi>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblSeferIlListesi");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StCikisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stCikisTarihi");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StGuId)
                    .HasColumnName("stGuId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StIlId).HasColumnName("stIlId");

                entity.Property(e => e.StKullaniciId).HasColumnName("stKullaniciId");

                entity.Property(e => e.StSeferId).HasColumnName("stSeferId");

                entity.Property(e => e.StTahminiVarisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stTahminiVarisTarihi");
            });

            modelBuilder.Entity<TblSeferTransferMerkezi>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblSeferTransferMerkezi");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StCikisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stCikisTarihi");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StGuId)
                    .HasColumnName("stGuId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StKullaniciId).HasColumnName("stKullaniciId");

                entity.Property(e => e.StMuhruAcan).HasColumnName("stMuhruAcan");

                entity.Property(e => e.StMuhurAcmaZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("stMuhurAcmaZamani");

                entity.Property(e => e.StMuhurNo)
                    .HasMaxLength(50)
                    .HasColumnName("stMuhurNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StMuhurlemeZamani)
                    .HasColumnType("datetime")
                    .HasColumnName("stMuhurlemeZamani");

                entity.Property(e => e.StMuhurleyen).HasColumnName("stMuhurleyen");

                entity.Property(e => e.StSeferId).HasColumnName("stSeferId");

                entity.Property(e => e.StTahminiVarisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stTahminiVarisTarihi");

                entity.Property(e => e.StTransferMerkeziId).HasColumnName("stTransferMerkeziId");
            });

            modelBuilder.Entity<TblSoforler>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblSoforler");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StSoforAd)
                    .HasMaxLength(100)
                    .HasColumnName("stSoforAd");
            });

            modelBuilder.Entity<TblSozlemeler>(entity =>
            {
                entity.HasKey(e => e.StSozlesmeId);

                entity.ToTable("tblSozlemeler");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StDosya).HasColumnName("stDosya");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StGuId).HasColumnName("stGuId");

                entity.Property(e => e.StKoli).HasColumnName("stKoli");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StPalet).HasColumnName("stPalet");

                entity.Property(e => e.StRulo).HasColumnName("stRulo");

                entity.Property(e => e.StSozAcentaId).HasColumnName("stSozAcentaId");

                entity.Property(e => e.StSozAcentaOran).HasColumnName("stSozAcentaOran");

                entity.Property(e => e.StSozAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stSozAdi");

                entity.Property(e => e.StSozBas)
                    .HasColumnType("datetime")
                    .HasColumnName("stSozBas");

                entity.Property(e => e.StSozBit)
                    .HasColumnType("datetime")
                    .HasColumnName("stSozBit");

                entity.Property(e => e.StSozCalisDrm).HasColumnName("stSozCalisDrm");

                entity.Property(e => e.StSozOdemeGun).HasColumnName("stSozOdemeGun");
            });

            modelBuilder.Entity<TblSubeler>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblSubeler");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StBirimKodu)
                    .HasMaxLength(50)
                    .HasColumnName("stBirimKodu");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StSubeAdi)
                    .HasMaxLength(250)
                    .HasColumnName("stSubeAdi");
            });

            modelBuilder.Entity<TblTasimaFirmalari>(entity =>
            {
                entity.HasKey(e => e.StItasFirmaId);

                entity.ToTable("tblTasimaFirmalari");

                entity.Property(e => e.StItasFirmaId).HasColumnName("stITasFirmaId");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StTasimaFirmaAdi)
                    .HasMaxLength(150)
                    .HasColumnName("stTasimaFirmaAdi");
            });

            modelBuilder.Entity<TblTasimaFirmalariSoz>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_tblSozTasFirmalar");

                entity.ToTable("tblTasimaFirmalariSoz");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StTasFirmaId).HasColumnName("stTasFirmaId");
            });

            modelBuilder.Entity<TblTransfer>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblTransfer");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAnaAktarmaMerkezi).HasColumnName("stAnaAktarmaMerkezi");

                entity.Property(e => e.StAracBarcode).HasColumnName("stAracBarcode");

                entity.Property(e => e.StAracId).HasColumnName("stAracId");

                entity.Property(e => e.StDurum)
                    .HasColumnName("stDurum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StGuId).HasColumnName("stGuId");

                entity.Property(e => e.StKullaniciId).HasColumnName("stKullaniciId");

                entity.Property(e => e.StNotlar).HasColumnName("stNotlar");

                entity.Property(e => e.StOlusturanId).HasColumnName("stOlusturanId");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StSoforId).HasColumnName("stSoforId");
            });

            modelBuilder.Entity<TblTransferMuhurListe>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblTransferMuhurListe");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAksiyon)
                    .HasMaxLength(50)
                    .HasColumnName("stAksiyon");

                entity.Property(e => e.StAksiyonId).HasColumnName("stAksiyonId");

                entity.Property(e => e.StCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("stCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StKullaniciId).HasColumnName("stKullaniciId");

                entity.Property(e => e.StMuhurNo)
                    .HasMaxLength(50)
                    .HasColumnName("stMuhurNo");

                entity.Property(e => e.StTransferId).HasColumnName("stTransferId");
            });

            modelBuilder.Entity<TblUcrelendirmeSoz>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_tblSozUcrelendirme");

                entity.ToTable("tblUcrelendirmeSoz");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StArtanDesi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stArtanDesi");

                entity.Property(e => e.StAyniGun)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stAyniGun");

                entity.Property(e => e.StBasDesi).HasColumnName("stBasDesi");

                entity.Property(e => e.StBasKm).HasColumnName("stBasKm");

                entity.Property(e => e.StBitDesi).HasColumnName("stBitDesi");

                entity.Property(e => e.StBitKm).HasColumnName("stBitKm");

                entity.Property(e => e.StIadeOrani)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stIadeOrani");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StPaketTipi).HasColumnName("stPaketTipi");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StTasFirmaId).HasColumnName("stTasFirmaId");

                entity.Property(e => e.StTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stTutar");

                entity.Property(e => e.StUcretAlici)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stUcretAlici");
            });

            modelBuilder.Entity<TblUcrelendirmeSozTmp>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblUcrelendirmeSozTmp");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StArtanDesi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stArtanDesi");

                entity.Property(e => e.StAyniGun)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stAyniGun");

                entity.Property(e => e.StBasDesi).HasColumnName("stBasDesi");

                entity.Property(e => e.StBasKm).HasColumnName("stBasKm");

                entity.Property(e => e.StBitDesi).HasColumnName("stBitDesi");

                entity.Property(e => e.StBitKm).HasColumnName("stBitKm");

                entity.Property(e => e.StBolgeDisi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stBolgeDisi");

                entity.Property(e => e.StIadeOrani)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stIadeOrani");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi");

                entity.Property(e => e.StPaketTipi).HasColumnName("stPaketTipi");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StTasFirmaId).HasColumnName("stTasFirmaId");

                entity.Property(e => e.StTutar)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stTutar");

                entity.Property(e => e.StUcretAlici)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stUcretAlici");
            });

            modelBuilder.Entity<TblUyruk>(entity =>
            {
                entity.HasKey(e => e.StUyrukId);

                entity.ToTable("tblUyruk");

                entity.Property(e => e.StUyrukId).HasColumnName("stUyrukId");

                entity.Property(e => e.StBaslik)
                    .HasMaxLength(100)
                    .HasColumnName("stBaslik");

                entity.Property(e => e.StUyrukKod)
                    .HasMaxLength(50)
                    .HasColumnName("stUyrukKod");
            });

            modelBuilder.Entity<TblYasakBolge>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblYasakBolge");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StCariId).HasColumnName("stCariId");

                entity.Property(e => e.StIlAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlAd");

                entity.Property(e => e.StIlId).HasColumnName("stIlId");

                entity.Property(e => e.StIlceAd)
                    .HasMaxLength(100)
                    .HasColumnName("stIlceAd");

                entity.Property(e => e.StIlceId).HasColumnName("stIlceId");

                entity.Property(e => e.StKargoId).HasColumnName("stKargoId");

                entity.Property(e => e.StMahalleAd)
                    .HasMaxLength(100)
                    .HasColumnName("stMahalleAd");

                entity.Property(e => e.StMahalleId).HasColumnName("stMahalleId");

                entity.Property(e => e.StOlusturan).HasColumnName("stOlusturan");

                entity.Property(e => e.StOlusturma)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturma")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblYetkiler>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblYetkiler");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StColor)
                    .HasMaxLength(50)
                    .HasColumnName("stColor");

                entity.Property(e => e.StComment).HasColumnName("stComment");

                entity.Property(e => e.StFunctionName)
                    .HasMaxLength(100)
                    .HasColumnName("stFunctionName");

                entity.Property(e => e.StItemTeype)
                    .HasMaxLength(100)
                    .HasColumnName("stItemTeype");

                entity.Property(e => e.StMenuItem)
                    .HasMaxLength(100)
                    .HasColumnName("stMenuItem");

                entity.Property(e => e.StMenuItemChild)
                    .HasMaxLength(50)
                    .HasColumnName("stMenuItemChild");

                entity.Property(e => e.StPageName)
                    .HasMaxLength(100)
                    .HasColumnName("stPageName");
            });

            modelBuilder.Entity<TblYukHizmet>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("tblYukHizmet");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StAciklama)
                    .HasMaxLength(250)
                    .HasColumnName("stAciklama");

                entity.Property(e => e.StDurum).HasColumnName("stDurum");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StType)
                    .HasColumnName("stType")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblYukHizmetSoz>(entity =>
            {
                entity.HasKey(e => e.StId)
                    .HasName("PK_tblSozYukHizmet");

                entity.ToTable("tblYukHizmetSoz");

                entity.Property(e => e.StId).HasColumnName("stId");

                entity.Property(e => e.StOlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("stOlusturmaTarihi")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StSozlesmeId).HasColumnName("stSozlesmeId");

                entity.Property(e => e.StYukHizmetDeger)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("stYukHizmetDeger");

                entity.Property(e => e.StYukHizmetId).HasColumnName("stYukHizmetId");
            });

            modelBuilder.Entity<VwGetRandvalue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_getRANDValue");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
