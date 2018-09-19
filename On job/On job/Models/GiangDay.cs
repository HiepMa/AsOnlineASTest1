using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("GiangDay")]
    public class GiangDay
    {
        [Key]
        [Column("ID_GIANGDAY")]
        public long ID { get; set; }

        [Column("ID_GV")]
        public long ID_GV { get; set; }

        [Column("ID_MonHoc")]
        public long ID_MonHoc { get; set; }

        [Column("NgayBatDau_GiangDay")]
        public DateTime DayStart { get; set; }

        [Column("NgayKetThuc_GiangDay")]
        public DateTime DayEnd { get; set; }

        [Column("NgayKetThuc_GiangDay_ThucTe")]
        public DateTime DayFinal { get; set; }

        [Column("NguoiCN_GiangDay")]
        public string NguoiCN
        {
            get { return NguoiCN; }
            set { if (NguoiCN.Length > 250) NguoiCN = NguoiCN.Substring(0, 249); }
        }

        [Column("NgayCN_GiangDay")]
        public DateTime NgayCN { get; set; }
        public string Khac_GiangDay { get; set; }
        public bool HT_GiangDay { get; set; }

        [ForeignKey("ID_GV")]
        public virtual GiaoVien GiaoVien { get; set; }

        [ForeignKey("ID_MonHoc")]
        public virtual MonHoc MonHoc { get; set; }
    }
}
