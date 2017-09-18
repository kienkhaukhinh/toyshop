using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.VIEWMODEL
{
    public class sanphambanchayviewmodel
    {

        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        //   [System.ComponentModel.DisplayName("Mã sản phẩm")]
        // public int masp { get; set; }
        [System.ComponentModel.DisplayName("Tên sản phẩm")]
        public string tensp { get; set; }
        [System.ComponentModel.DisplayName("Giá bán")]
        public Nullable<decimal> giaban { get; set; }
        [System.ComponentModel.DisplayName("Số lượng bán ra")]
        public Nullable<int> soluongbanra { get; set; }
        //[System.ComponentModel.DisplayName("Doanh thu")]
    

    }
}
