using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("ChiTiet_BaiThi")]
    public class ChiTiet_BaiThi
    {
        [Key]
        [Column("ID_CTBAITHI")]
        public long ID_CTBAITHI { get; set; }

        [Column("ID_BAITHI")]
        public long Id_BaiTThi { get; set; }

        [Column("ID_CauHoi")]
        public long ID_CauHoi { get; set; }

        [Column("ThiSinh_LuaChon")]
        public string LuaChon
        {
            get { return LuaChon; }
            set {
                LuaChon = value;
                if (LuaChon.Length >= 350) LuaChon = "NULL";
            }
        }

        [Column("HT_ChiTiet_BaiThi")]
        public bool HienThi { get; set; }

        [Column("Diem_BaiThi")]
        public double Diem
        {
            get { return Diem; }
            set
            {
                Diem = value;
                if (Diem > 0.5) Diem = 0.5;
                if (Diem < 0.1) Diem = 0.1;
            }
        }
        
        [Column("Khac_CTBT")]
        public string Khac
        {
            get { return Khac; }
            set {
                Khac = value;
                if (Khac.Length > 250) Khac.Remove(250);
            }
        }
        [Column("ThuTu_LuaChon")]
        public string ThuTuLC
        {
            get { return ThuTuLC; }
            set { if (ThuTuLC.Length > 250) ThuTuLC.Remove(250); }
        }

        [Column("TT_TraLoi")]
        public bool ThuTuTL { get; set; }

        [ForeignKey("Id_BaiThi")]
        public virtual Baithi Baithi { get; set; }

        [ForeignKey("ID_CauHoi")]
        public virtual CauHoi CauHoi { get; set; }
    }
}
