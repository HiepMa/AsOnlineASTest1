using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("ThiSinh")]
    public class ThiSinh
    {
        [Key]
        public long ID_TK { get; set; }
        public string MADN_TS
        {
            get { return MADN_TS; }
            set
            {
                if (MADN_TS.Length >= 250)
                    MADN_TS = "NULL";
                else this.MADN_TS = MADN_TS;
            }
        }

        public string Ho_ThiSinh

        {
            get { return Ho_ThiSinh; }
            set
            {
                if (Ho_ThiSinh.Length >= 250)
                    Ho_ThiSinh = "NULL";
                else this.Ho_ThiSinh = Ho_ThiSinh;
            }
        }
        public string Ten_ThiSinh {
            get { return Ten_ThiSinh; }
            set
            {
                if (Ten_ThiSinh.Length >= 250)
                    Ten_ThiSinh = "NULL";
                else this.Ten_ThiSinh = Ten_ThiSinh;
            }
        }
        public string MatKhau_ThiSinh {
            get { return MatKhau_ThiSinh; }
            set
            {
                if (MatKhau_ThiSinh.Length >= 250)
                    MatKhau_ThiSinh = "NULL";
                else this.MatKhau_ThiSinh = MatKhau_ThiSinh;
            }
        }
        public string GioiTinh_ThiSinh
        {
            get { return GioiTinh_ThiSinh; }
            set
            {
                if (GioiTinh_ThiSinh.Equals("true") || GioiTinh_ThiSinh.Equals("false"))
                    GioiTinh_ThiSinh = GioiTinh_ThiSinh;
                else GioiTinh_ThiSinh = "NULL";
            }
        }
        public string Email_ThiSinh {
            get { return Email_ThiSinh; }
            set
            {
                if (Email_ThiSinh.Length >= 250)
                    Email_ThiSinh = "NULL";
                else this.Email_ThiSinh = Email_ThiSinh;
            }
        }

        public string DienThoai_ThiSinh {
            get { return DienThoai_ThiSinh; }
            set {
                if (DienThoai_ThiSinh.Length < 10 || DienThoai_ThiSinh.Length > 11)
                    DienThoai_ThiSinh = "NULL";
                else this.DienThoai_ThiSinh = DienThoai_ThiSinh;
            }
        }
        public string DiaChi_ThiSinh {
            get { return DiaChi_ThiSinh; }
            set
            {
                if (DiaChi_ThiSinh.Length >= 250)
                    DiaChi_ThiSinh = "NULL";
                else this.DiaChi_ThiSinh = DiaChi_ThiSinh;
            }
        }
        [Column("NgaySinh_ThiSinh")]
        public DateTime NgaySinh
        {
            get { return NgaySinh; }
            set
            {
                if (DateTime.Now.Year - NgaySinh.Year >= 7) this.NgaySinh = NgaySinh; 
            }
        }

        public bool HT_ThiSinh { get;set;}
        public string NguoiTao_ThiSinh
        {
            get { return NguoiTao_ThiSinh; }
            set
            {
                if (NguoiTao_ThiSinh.Length >= 250)
                    NguoiTao_ThiSinh = "NULL";
                else this.NguoiTao_ThiSinh = NguoiTao_ThiSinh;
            }
        }
        public DateTime NgayTao_ThiSinh { get; set; }
        public string NguoiCN_ThiSinh
        {
            get { return NguoiCN_ThiSinh; }
            set
            {
                if (NguoiCN_ThiSinh.Length >= 250)
                    NguoiCN_ThiSinh = "NULL";
                else this.NguoiCN_ThiSinh = NguoiCN_ThiSinh;
            }
        }
        public DateTime NgayCN_ThiSinh { get; set; }
        public string Khac_ThiSinh {
            get { return Khac_ThiSinh; }
            set
            {
                if (Khac_ThiSinh.Length >= 300)
                    Khac_ThiSinh = "NULL";
                else this.Khac_ThiSinh = NguoiCN_ThiSinh;
            }
        }
    }
}
