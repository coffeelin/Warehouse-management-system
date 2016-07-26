using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WMSDAO.Models
{
    public enum DineType
    {
        /// <summary>
        /// 进货
        /// </summary>
        Import = 0,
        /// <summary>
        /// 出货
        /// </summary>
        Export = 1
    }
    /// <summary>
    /// 仓库对外订单 入货
    /// </summary>
    public class Dine
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 定单的种类
        /// </summary>
        public DineType Type { get; set; }

        public decimal ServePrice { get; set; }

        public int StorageId { get; set; }
        public Storage Storage { get; set; }

        public ICollection<DineDeatil> DineDetails { get; set; }
    }

    /// <summary>
    ///  订单详细货物
    /// </summary>
    public class DineDeatil
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int DineId { get; set; }
        public Dine Dine { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}
