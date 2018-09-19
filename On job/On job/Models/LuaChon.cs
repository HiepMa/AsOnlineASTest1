using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("LuaChon")]
    public class LuaChon
    {
        [Key]
        [Column("ID_LUACHON")]
        public long ID_LUACHON { set; get; }

        [Column("ID_CH")]
        public long ID_CH { get; set; }

        [Column("NoiDung_LuaChon")]
        public string NoiDung { get; set; }

        [Column("DapAn")]
        public bool DapAn { get; set; }

        [Column("HT_LuaChon")]
        public bool HienThi { get; set; }

        [Column("NguoiTao_LuaChon")]
        public string NguoiTao
        {
            get { return NguoiTao; }
            set {
                NguoiTao = value;
                if (NguoiTao.Length > 250) NguoiTao.Remove(250); }
        }

        [Column("NgayTao_LuaChon")]
        public DateTime NgayTao { get; set; }

        [Column("NguoiCN_LuaChon")]
        public string NguoiCN
        {
            get { return NguoiCN; }
            set {
                NguoiCN = value;
                if (NguoiCN.Length > 250) NguoiCN.Remove(250); }
        }

        [Column("NgayCN_LuaChon")]
        public DateTime NgayCN { get; set; }

        [Column("Khac_LuaChon")]
        public string Khac
        {
            get { return Khac; }
            set
            {
                Khac = value;
                if (Khac.Length > 250) Khac.Remove(250);
            }
        }

        [ForeignKey("ID_CH")]
        public virtual CauHoi CauHoi { get; set; }
    }
}
