using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    /// <summary>
    /// 排序的对象
    /// </summary>
    public class SortInfo
    {
        public static readonly string 正序 = "ASC";
        public static readonly string 倒序 = "DESC";

        public SortInfo()
        {

        }
        public SortInfo(string columnName)
        {
            this.columnName = columnName;
        }
        public SortInfo(string columnName,string sortType)
        {
            this.columnName = columnName;
            this.sortType = sortType;
        }
        /// <summary>
        /// 需要排序的字段名称
        /// </summary>
        private string columnName;
        /// <summary>
        /// 需要排序的字段名称
        /// </summary>
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        /// <summary>
        /// 排序类型升序ASC或者降序DESC
        /// </summary>
        private string sortType;
        /// <summary>
        /// 排序类型升序ASC或者降序DESC
        /// </summary>
        public string SortType
        {
            get { return sortType; }
            set { sortType = value; }
        }
    }
}
