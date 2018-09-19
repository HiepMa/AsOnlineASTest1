using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("DanhSach_DeThi")]
    public class DanhSach_DeThi
    {
        [Key]
        [Column("ID_DE")]
        public long ID_DE { get; set; }

        [Column("ID_MonHoc")]
        public long ID_MonHoc { get; set; }
        
        [Column("Ma_DeThi")]
        public string Ma {
            get {return Ma; }
            set {Ma =value ;
                if (Ma.Length > 30) Ma = "NULL";
            }
        }
        
        [Column("Ten_DeThi")]
        public string Ten {
            get {return Ten; }
            set {
                Ten = value;
                if (Ten.Length> 50) Ten="NULL"; }
        }

        [Column("TrangThai_DeThi")]
        public bool TrangThai_DeThi { get; set; }

        [Column("TrangThai_Tron_DeThi")]
        public bool TrangThai_Tron_DeThi { get; set; }

        [Column("HT_DeThi")]
        public bool HienThi { get; set; }

        [Column("ThoiGianLamBai")]
        public int ThoiGianLamBai
        {
            get { return ThoiGianLamBai; }
            set { ThoiGianLamBai = value;
                if (ThoiGianLamBai <= 0) ThoiGianLamBai = 0; }
        }

        [Column("NgayBatDau_SuDung")]
        public DateTime DayStart { get; set; }

        [Column("NgayKetThucDuKien")]
        public DateTime DayEnd { get; set; }

        [Column("NgayKetThucThucTe")]
        public DateTime DayFinal { get; set; }

        [Column("Khac_DeThi")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 300) Khac = "NULL"; }
        }

        [Column("NguoiTao_DeThi")]
        public string NguoiTao
        {
            get { return NguoiTao; }
            set { if (NguoiTao.Length > 250) NguoiTao = "NULL"; }
        }

        [Column("NgayTao_DeThi")]
        public DateTime NgayTao { get; set; }

        [Column("NguoiCN_CauHoi")]
        public string NguoiCN
        {
            get { return NguoiCN; }
            set { if (NguoiCN.Length > 250) NguoiCN = "NULL"; }
        }

        [Column("NgayCN_CauHoi")]
        public DateTime NgayCN_CauHoi { get; set; }

        [ForeignKey("ID_MonHoc")]
        public virtual MonHoc MonHoc { get; set; }
    }
}
