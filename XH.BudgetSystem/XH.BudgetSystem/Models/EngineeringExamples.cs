using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XH.BudgetSystem
{
    /// <summary>
    /// 工程样例
    /// </summary>
    public class EngineeringExamples
    {
        public int ID { get; set; }
        /// <summary>
        /// 工程名称
        /// </summary>
        public string EngineeringName { get; set; }
        /// <summary>
        /// 原材料分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 原材料名称
        /// </summary>
        public string MaterialName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal BasePrice { get; set; }
        /// <summary>
        /// 消耗量
        /// </summary>
        public decimal Consumption { get; set; }
        /// <summary>
        /// 损耗量
        /// </summary>
        public decimal Loss { get; set; }
    }
}
