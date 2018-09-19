using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Onjob.Models
{
    [Table("ManHinh")]
    public class ManHinh
    {
        [Key]
        [Column("ID_ManHinh")]
        public long ID { get; set; }

        [Column("MaManHinh")]
        public string Ma
        {
            get { return Ma; }
            set {
                Ma = value;
                if (Ma.Length > 250) Ma.Remove(250); }
        }

        [Column("TenManHinh")]
        public string Ten
        {
            get { return Ten; }
            set {
                Ten = value;
                if (Ten.Length > 100) Ten.Remove(100); }
        }

        [Column("HT_ManHinh")]
        public bool HienThi { get; set; }

        [Column("MoTaManHinh")]
        public string MoTa { get; set; }

        [Column("URL")]
        public string URL
        {
            get { return URL; }
            set { if (URL.Length > 300) URL = "NULL"; }
        }

        [Column("Khac_ManHinh")]
        public string Khac
        {
            get { return Khac; }
            set { if (Khac.Length > 250) Khac.Remove(250); }
        }
    }
}
