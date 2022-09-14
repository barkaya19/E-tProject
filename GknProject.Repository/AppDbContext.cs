using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GknProject.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GknProject.Repository
{ 
    public class AppDbContext : GknKargoErpContext
    {
       
        public AppDbContext(DbContextOptions<GknKargoErpContext> options) : base(options)
        {
        }

        public DbSet<TblAcentum> Acentum { get; set; }
        public DbSet<TblAktarimMerkeziBolge> AktarimMerkeziBolges { get; set; }
        public DbSet<TblAktarmaMerkezi> TblAktarmaMerkezis { get; set; }
        public DbSet<TblAraclar> TblAraclars { get; set; }
        public DbSet<TblAyarlar> TblAyarlars { get; set; }
        public DbSet<TblBankaListe> TblBankaListes { get; set; }
        public DbSet<TblBsSehir> TblBsSehirs { get; set; }
        public DbSet<TblFaturalar> TblFaturalars { get; set; }
        public DbSet<TblGidilenBolge> TblGidilenBolges { get; set; }
        public DbSet<TblGonderiDurumlari> TblGonderiDurumlaris { get; set; }
        public DbSet<TblGonderiHesaplama>  TblGonderiHesaplamas { get; set; }
        public DbSet<TblGonderiKargoJson> TblGonderiKargoJsons { get; set; }
        public DbSet<TblGonderiTransfer> TblGonderiTransfers { get; set; }
        public DbSet<TblGonderiUrunler> TblGonderiUrunlers { get; set; }
        public DbSet<TblGonderiYukHiz> TblGonderiYukHizs { get; set; }
        public DbSet<TblGonderiler> TblGonderilers { get; set; }
        public DbSet<TblGonderilerAb> TblGonderilerAbs { get; set; }
        public DbSet<TblGonderilerGb> TblGonderilerGbs { get; set; }
        public DbSet<TblIl> TblIls { get; set; }
        public DbSet<TblIlce> TblIlces { get; set; }
        public DbSet<TblKullaniciYetkileri> TblKullaniciYetkileris { get; set; }
        public DbSet<TblKullanicilar> TblKullanicilars { get; set; }
        public DbSet<TblMesafeler> TblMesafelers { get; set; }
        public DbSet<TblMobileLoginLog> TblMobileLoginLogs { get; set; }
        public DbSet<TblMusteriAd> TblMusteriAds { get; set; }
        public DbSet<TblMusteriBanka> TblMusteriBankas { get; set; }
        public DbSet<TblMusteriNotlari> TblMusteriNotlaris { get; set; }
        public DbSet<TblMusteriOzellik> TblMusteriOzelliks { get; set; }
        public DbSet<TblMusteriOzellikDurum> TblMusteriOzellikDurums { get; set; }
        public DbSet<TblMusteriTemsilci> TblMusteriTemsilcis { get; set; }
        public DbSet<TblMusteriler> TblMusterilers { get; set; }
        public DbSet<TblPaketTipleri> TblPaketTipleris { get; set; }
        public DbSet<TblSeferIlListesi> TblSeferIlListesis { get; set; }
        public DbSet<TblSeferTransferMerkezi> TblSeferTransferMerkezis { get; set; }
        public DbSet<TblSoforler> TblSoforlers { get; set; }
        public DbSet<TblSubeler> TblSubelers { get; set; }
        public DbSet<TblTasimaFirmalari> TblTasimaFirmalaris { get; set; }
        public DbSet<TblTasimaFirmalariSoz> TblTasimaFirmalariSozs { get; set; }
        public DbSet<TblTransfer> TblTransfers { get; set; }
        public DbSet<TblTransferMuhurListe> TblTransferMuhurListes { get; set; }
        public DbSet<TblUcrelendirmeSoz> TblUcrelendirmeSozs { get; set; }
        public DbSet<TblUcrelendirmeSozTmp> TblUcrelendirmeSozTmps { get; set; }
        public DbSet<TblUyruk> TblUyruks { get; set; }
        public DbSet<TblYasakBolge> TblYasakBolges { get; set; }
        public DbSet<TblYetkiler> TblYetkilers { get; set; }
        public DbSet<TblYukHizmet> TblYukHizmets { get; set; }
        public DbSet<TblYukHizmetSoz> TblYukHizmetSozs { get; set; }
    }
}
