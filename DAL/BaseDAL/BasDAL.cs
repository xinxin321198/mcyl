using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Common;

namespace DAL.Base
{
    public class BasDAL
    {
          /// <summary>
        /// 查询时sql语句是否有where，方便加条件，默认false，没有
        /// </summary>
        protected bool b_isWhere = false;

        /// <summary>
        /// 更新的时候，参数是否有多个，需不需要加逗号的标识，默认false，不需要
        /// </summary>
        protected bool b_isComma = false;


        /// <summary>
        /// 是否有where，没有的话加上，有的话就直接返回sql字符串
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        protected   StringBuilder isWhere(StringBuilder sql)
        {
            if (this.b_isWhere)
            {
                return null;
            }
            else
            {
                sql.Append(" where ");
                this.b_isWhere = true;
                return sql;
            }
        }

        /// <summary>
        /// 是否有and，没有的话加上，有的话就直接返回sql字符串
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        protected StringBuilder isAnd(StringBuilder sql)
        {
            if (!this.b_isWhere)
            {
                return null;
            }
            else
            {
                sql.Append(" and ");
                return sql;
            }
        }

        /// <summary>
        /// 是否有多个参数，有就得加上逗号
        /// </summary>
        /// <param Name="sql"></param>
        /// <returns></returns>
        protected StringBuilder isComma(StringBuilder sql)
        {
            if (this.b_isComma)
            {
                sql.Append(" , ");
                this.b_isComma = true;
                return sql;
                
            }
            else
            {
                this.b_isComma = true;
                return null;
            }
        }

        /// <summary>
        /// 把数据库中的可空字段（DBNull）转换为null
        /// </summary>
        /// <param Name="value">数据库字段值</param>
        /// <returns>如果为空返回null，否则返回原本的数据</returns>
        protected object convertDBNullValue(object value)
        {
            if (DBNull.Value == value)
            {
                return null;
            }
            else
            {
                return value;
            }
        }


        /// <summary>
        /// 按顺序从isAscList中取bool判断是添加正序还是倒序
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isAscList"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        protected StringBuilder addSort(StringBuilder sql, List<SortInfo> sortInfoList)
        {
            if (null == sortInfoList || 0 == sortInfoList.Count)
            {
                sql.Append(" ORDER BY A.ID ASC");//ID排序
            }
            else
            {
                sql.Append("  ORDER BY ");
                for (int i = 0; i < sortInfoList.Count; i++)
                {
                    SortInfo sort = sortInfoList[i];
                    this.isComma(sql);
                    if (null == sort)
                    {
                        throw new Exception("下标为" + i + "的排序参数对象不能为null");
                    }
                    else if (null == sort.ColumnName || "" == sort.ColumnName)
                    {
                        throw new Exception("下标为" + i + "的排序参数对象中的字段名称不能为空，请赋值");
                    }
                    else if (null == sort.SortType || "" == sort.SortType)
                    {
                        sql.Append(@" A." + sort.ColumnName + " ASC");
                    }
                    else
                    {
                        sql.Append(@" " + sort.ColumnName + " " + sort.SortType + "");

                    }
                }
                this.b_isComma = false;
            }
            return sql;
        }
    }
}
