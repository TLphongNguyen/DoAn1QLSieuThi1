using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ETTCategory
    {
        protected int ma_loai_hang;
        protected string ten_loai_hang;
        public ETTCategory()
        {
            
        } 
        public ETTCategory(ETTCategory ETTCT)
        {
            this.ma_loai_hang = ETTCT.ma_loai_hang;
            ten_loai_hang = ETTCT.ten_loai_hang;
        }
        public ETTCategory(int Ma_loai_hang, string Ten_loai_hang)
        {
            this.ma_loai_hang = Ma_loai_hang;
            this.ten_loai_hang = Ten_loai_hang;
        }
        public ETTCategory( string Ten_loai_hang)
        {
            this.ten_loai_hang = Ten_loai_hang;
        }
        public int Ma_loai_hang
        {
            get { return ma_loai_hang; }
            set { ma_loai_hang = value; }
        }
        public string Ten_loai_hang
        {
            get { return ten_loai_hang; }
            set { ten_loai_hang = value; }
        }
    }
}
