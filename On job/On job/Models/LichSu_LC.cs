using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("LichSu_LC")]
    public class LichSu_LC
    {
        [Key]
        public long ID_LS_LC { get; set; }
        public long ID_LUACHON { get; set; }
        public string MoTa_LS_LC { get; set; }
        public string NoiDungCN_LS_LC { get; set; }
        public string NoiDungMoi_LS_LC { get; set; }
        public string NoiDungCu_LS_LC { get; set; }
        public string NguoiCN_LS_LC { get; set; }
        public DateTime Ngay_LS_LC { get; set; }
    }
}
