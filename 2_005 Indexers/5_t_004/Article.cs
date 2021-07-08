using System;
using System.Collections.Generic;
using System.Text;

namespace _5_t_004
{
    class Article
    {
        private string product_name { get; set; } //get и set здесь записаны как автоматические свойства
        private string shop_name { get; set; }
        private float product_cost
        {
            set
            {
                product_cost = value;
            }
            get
            {
                return product_cost;
            }
        }

    }
}
