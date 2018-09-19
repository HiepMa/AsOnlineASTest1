using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("CauHoi")]
    public class CauHoi
    {
        [Key]
        [Column("ID_CH")]
        public long ID { get; set; }

        [Column("ID_LoaiCH")]
        public long ID_LoaiCH { get; set; }

        [Column("ID_DeMuc")]
        public long ID_DeMuc { get; set; }

        [Column("NoiDung_CauHoi")]
        public string NoiDung { get; set; }
            
        [Column ("CapDo")]
        public int CapDo {
            get { return CapDo; }
            set {
                CapDo = value;
                if (CapDo > 9) CapDo = 9;
                if (CapDo < 1) CapDo = 1;
            }
        }

        [Column("TrangThaiTron_CauHoi")]
        public bool TrThaiTron { get; set; }

        [Column("HT_CauHoi")]
        public bool HienThi { get; set; }

        [Column("Diem_CauHoi")]
        public double Diem {
            get {return Diem; }
            set
            {
                Diem = value;
                if (Diem > 0.5) Diem = 0.5;
                if (Diem < 0.1) Diem = 0.1;
            }
            }

        [Column("NguoiTao_CauHoi")]
        public string NguoiTao
        {
            get { return NguoiTao; }
            set {
                NguoiTao = value;
                if (NguoiTao.Length >= 250) NguoiTao = "NULL";//Chuoi dai hon do dai quy dinh
            }
        }

        [Column("NgayTao_CauHoi")]
        public DateTime NgayTao {
            get { return NgayTao; }
            set { NgayTao=DateTime.Now; }
        }

        [Column("NguoiCN_CauHoi")]
        public string NguoiCN  {
            get { return NguoiCN; }
            set
            {
                NguoiCN = value;
                if (NguoiCN.Length >= 250) NguoiCN = "NULL";//Chuoi dai hon do dai quy dinh
            }
        }

        [Column("NgayCN_CauHoi")]
        public DateTime NgayCN { get; set; }

        [Column("Khac_CH")]
        public string Khac
        {
            get { return Khac; }
            set { Khac = value;
                if (Khac.Length >= 250) Khac = "NULL";//Chuoi dai hon do dai quy dinh
            }
        }

        [ForeignKey("ID_LoaiCH")]
        public virtual Loai_CH Loai_CH { get; set; }

        [ForeignKey("ID_DeMuc")]
        public virtual DeMuc DeMuc { get; set; }
    }
}
