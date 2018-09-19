using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("LichSu_CH")]
    public class LichSu_CH
    {
        [Key]
        [Column("ID_LS_CH")]
        public long ID_LS_CH { get; set; }

        [Column("ID_CH")]
        public long ID_CH { get; set; }

        [Column("MoTa_HanhDong")]
        public string MoTa
        {
            get { return MoTa; }
            set { if (MoTa.Length > 10) MoTa.Remove(10); }
        }

        [Column("NoiDungCN_LS_CH")]
        public string NoiDungCN { get; set; }

        [Column("NoiDung_Cu_LS_CH")]
        public string NoiDung_Cu_LS_CH { get; set; }

        [Column("NoiDung_Moi_LS_CH")]
        public string NoiDung_Moi_LS_CH { get; set; }

        [Column("DiemCH_Cu")]
        public double DiemCH_Cu { get; set; }

        [Column("DiemCH_Moi")]
        public double DiemCH_Moi { get; set; }

        [Column("CapDoCH_Cu")]
        public int CapDo_Cu { get; set; }

        [Column("CapDoCH_Moi")]
        public int CapDo_Moi { get; set; }

        [Column("NguoiCN_LS_CH")]
        public string NguoiCN
        {
            get { return NguoiCN; }
            set { if (NguoiCN.Length > 250) NguoiCN.Remove(250); }
        }

        [Column("NgayCN_LS_CH")]
        public DateTime NgayCN_LS_CH { get; set; }

        [Column("Khac_LS_CH")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 250) Khac.Remove(250); }
        }

        [ForeignKey("ID_CH")]
        public virtual CauHoi CauHoi { get; set; }
    }
}
