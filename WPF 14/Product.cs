using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPF_14
{
    public enum ProductTypes
    {
        [Description("Еда")]
        Еда,
        [Description("Бытовая техника")]
        Бытовая_техника
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductTypes { get; set; }
    }
}
