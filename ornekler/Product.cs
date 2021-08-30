using System;
using System.Collections.Generic;
using System.Text;

namespace ornekler
{
    class Product
    {
        public int Id { get; set; } //Id si
        public int CategoryId { get; set; } //hangi kategoriye dahil olduğu 
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }// ürün fiyatı
        public int UnitsInStock { get; set; }// ürünün stok adedi


    }
}
