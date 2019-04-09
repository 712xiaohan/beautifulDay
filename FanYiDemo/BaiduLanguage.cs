using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanYiDemo
{
    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string dst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int prefixWrap { get; set; }
        /// <summary>
        /// 测试
        /// </summary>
        public string src { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> relation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<object>> result { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string from { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string to { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string domain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }
    }
}
