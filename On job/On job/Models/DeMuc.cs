using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("DeMuc")]
    public class DeMuc
    {
        [Key]
        [Column("ID_DeMuc")]
        public long ID { get; set; }

        [Column("ID_MonHoc")]
        public long ID_MonHoc { get; set; }

        [Column("Ma_DeMuc")]
        public string Ma
        { get { return Ma; }
            set { if (Ma.Length > 30) Ma = Ma.Substring(0, 29); }
        }

        [Column("Ten_DeMuc")]
        public string Ten
        {
            get { return Ten; }
            set { if (Ten.Length > 100) Ten = Ten.Substring(0, 99); }
        }

        [Column("HT_DeMuc")]
        public bool HienThi { get; set; }

        [Column("NguoiTao_DM")]
        public string NguoiTao {
            get { return NguoiTao; }
            set {if(NguoiTao.Length>250) NguoiTao=NguoiTao.Substring(0,249); }
        }

        [Column("NgayTao_DM")]
        public DateTime NgayTao { get; set; }

        [Column("NguoiCN_DM")]
        public string NguoiCN {
            get { return NguoiCN; }
            set { if (NguoiCN.Length > 250) NguoiCN = NguoiCN.Substring(0, 249); }
        }

        [Column("NgayCN_DM")]
        public DateTime NgayCN { get; set; }

        [Column("Khac_DeMuc")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 250) Khac = Khac.Substring(0, 249); }
        }
        [ForeignKey("ID_MonHoc")]
        public virtual MonHoc MonHoc { get; set; }
    }
}
