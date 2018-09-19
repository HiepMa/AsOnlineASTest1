using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("Loai_CH")]
    public class Loai_CH
    {
        [Key]
        [Column("ID_LoaiCH")]
        public long ID_LoaiCH { get; set; }

        [Column("MaLoai_CH")]
        public string MaLoai {
            get { return MaLoai; }
            set { if (MaLoai.Length > 250) MaLoai.Remove(250); }
        }

        [Column("TenLoai_CH")]
        public string TenLoai
        {   get { return TenLoai; }
            set { if (TenLoai.Length > 250) TenLoai = TenLoai.Substring(0, 249); }
        }

        [Column("HT_Loai")]
        public bool HienThi { get; set; }

        [Column("Khac_LCH")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 250) Khac.Remove(250); }
        }
    }
}
