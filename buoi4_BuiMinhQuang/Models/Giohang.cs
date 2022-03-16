using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace buoi4_BuiMinhQuang.Models
{
    public class Giohang
    {
        MyDatamlDataContext data = new MyDatamlDataContext();
        public int masach { get; set; }

        [Display(Name = "Tên sách")]
        public String tensach { get; set; }

        [Display(Name ="Ảnh bìa")]
        public String  hinh { get; set; }

        [Display(Name ="Giá bán")]
        public Double giaban { get; set; }

        [Display(Name = "Số lượng")]
        public int isoluong { get; set; }

        [Display(Name = "Thành Tiền")]
        public Double dthanhtien
        {
            get { return isoluong * giaban; }
        }

        public Giohang()
        {

        }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            isoluong = 1;
        }
    }

}