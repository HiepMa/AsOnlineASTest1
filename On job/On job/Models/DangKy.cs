using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("DangKy")]
    public class DangKy
    {
        [Key]
        [Column("ID_DANGKY")]
        public long ID { get; set; }

        [Column("ID_TK")]
        public long ID_TK { get; set; }

        [Column("iID_MONHOC")]
        public long ID_MONHOC { get; set; }

        [Column("Ngay_DangKy")]
        public DateTime Day { get; set; }

        [Column("CamThi")]
        public bool CamThi { get; set; }

        [Column("NGUOICN_DK")]
        public string NguoiCN {
            get { return NguoiCN; }
            set { if (NguoiCN.Length > 250) NguoiCN = NguoiCN.Substring(0, 249); }
            } 

        [Column("NgayCN_DangKy")]
        public DateTime NgayCN { get; set; }

        [ForeignKey("ID_TK")]
        public virtual ThiSinh ThiSinh { get; set; }

        [ForeignKey("ID_MONHOC")]
        public virtual MonHoc MonHoc { get; set; }
    }
}
