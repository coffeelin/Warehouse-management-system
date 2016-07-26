using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSDAO.Models
{
    public enum ProductStatus
    {
        /// <summary>
        ///  正常状态
        /// </summary>
        Normal = 0,

        /// <summary>
        ///  仓库缺货状态
        /// </summary>
        Absence = 1
    }

    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string Name { get; set; }
        /// <summary>
        /// 产品的状态
        /// </summary>
        public ProductStatus Status { get; set; } = ProductStatus.Normal;

        /// <summary>
        /// 产品的价格
        /// </summary>
        public ProductPrice Price { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }

    /// <summary>
    /// 产品相关价格 
    /// </summary>
    public class ProductPrice
    {
        [Key, ForeignKey(nameof(Product))]
        public string Id { get; set; }
        
        public Product Product { get; set; }

        /// <summary>
        /// 单位服务费
        /// </summary>
        public decimal PreServePrice { get; set; }
        /// <summary>
        /// 产品价格
        /// </summary>
        public decimal Price { get; set; }
    }

    /// <summary>
    /// 产品出产商
    /// </summary>
    public class Manufacturer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [MaxLength(20), Required]
        public string Name { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime RegistTime { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
