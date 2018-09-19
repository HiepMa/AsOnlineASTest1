using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("PhanQuyen")]
    public class PhanQuyen
    {
        [Key]
        [Column("ID_PhanQuyen")]
        public long ID { get; set; }

        [Column("ID_ManHinh")]
        public long ID_ManHinh { get; set; }

        [Column("ID_GV")]
        public long ID_GV { get; set; }

        [Column("CoQuyen")]
        public bool CoQuyen { get; set; }

        [Column("HT_PQ")]
        public bool HienThi { get; set; }

        [Column("NgayBD_PQ")]
        public DateTime NgayBD { get; set; }

        [Column("NgayKT_PQ")]
        public DateTime NgayKT { get; set; }

        [Column("NgayKT_TT")]
        public DateTime NgayKT_TT { get; set; }

        [Column("NguoiTao_PQ")]
        public string NguoiTao {
            get { return NguoiTao; }
            set {
                NguoiTao = value;
                if (NguoiTao.Length > 250) NguoiTao.Remove(250); }
        }

        [Column("NgayTao_PQ")]
        public DateTime NgayTao { get; set; }

        [Column("NguoiCN_PQ")]
        public string NguoiCN
        {
            get { return NguoiCN; }
            set { NguoiCN = value;
                if (NguoiCN.Length > 250) NguoiCN.Remove(250);
            }
        }

        [Column("NgayCN_PQ")]
        public DateTime NgayCN { get; set; }

        [Column("Khac_PQ")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 250) Khac.Remove(250); }
        }

        [ForeignKey("ID_ManHinh")]
        public virtual ManHinh ManHinh { get; set; }

        [ForeignKey("ID_GV")]
        public virtual GiaoVien GiaoVien { get; set; }
    }
}
