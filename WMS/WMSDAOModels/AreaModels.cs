using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMSDAO.Models
{
    public enum AreaStatus
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 满货
        /// </summary>
        Full = 1,
        /// <summary>
        /// 维修状态
        /// </summary>
        Repair = 2 
    }
        
    /// <summary>
    /// 区域
    /// </summary>
    public class Area
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20),Required]
        public string Name { get; set; }
        /// <summary>
        /// 区域的状态
        /// </summary>
        public AreaStatus Status { get; set; } = AreaStatus.Normal;
        
        public ICollection<Storage> Storages { get; set; }

    }

    /// <summary>
    /// 货架 
    /// </summary>
    public class Storage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20), Required]
        public string Name { get; set; }

        /// <summary>
        /// 已存容量
        /// </summary>
        [Required]
        public int Capacity { get; set; }
        /// <summary>
        /// 最大存储容量
        /// </summary>
        [Required]
        public int MaxCapacity { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}
