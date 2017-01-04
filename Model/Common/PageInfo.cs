using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    /// <summary>
    /// 分页对象
    /// </summary>
    public class PageInfo
    {

        /// <summary>
        /// 每页显示的条数
        /// </summary>
        private int pageSize = 20;

        /// <summary>
        /// 所有记录的条数
        /// </summary>
        private int allCount = 0;

        /// <summary>
        /// 页码总数
        /// </summary>
        private int pageCount = 0;

        /// <summary>
        /// 当前页默认第一页
        /// </summary>
        private int currentPage = 1;

        /// <summary>
        /// 下一页的页码
        /// </summary>
        private int prevPage = 0;


        /// <summary>
        /// 上一页的页码
        /// </summary>
        private int nextPage = 0;


        /// <summary>
        /// 数据的最小范围
        /// </summary>
        private int minIndex = 0;



        /// <summary>
        /// 数据的最大范围
        /// </summary>
        private int maxIndex = 0;

        public PageInfo()
        {
        }

        public PageInfo(int pageSize)
        {
            this.pageSize = pageSize;
        }

        public int PageCount
        {
            get {//得到页码总数，（总数据条数/每页显示的数量）
                if (allCount % PageSize == 0)
                {
                    pageCount = AllCount / PageSize;
                }
                else
                {
                    pageCount = AllCount / PageSize + 1;
                }
                return pageCount; 
            }
            set { pageCount = value; }
        }

        public int MinIndex
        {
            get {//数据过滤的范围最小值
                if (0!=CurrentPage)
                {
                    minIndex = (CurrentPage - 1) * PageSize + 1; 
                }
                return minIndex;
            }
            set { minIndex = value; }
        }

        public int MaxIndex
        {
            get {//数据过滤的范围最大值
                if (0 != CurrentPage)
                {
                    maxIndex = PageSize * CurrentPage;
                }
                return maxIndex;
            }
            set { maxIndex = value; }
        }

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        public int AllCount
        {
            get { return allCount; }
            set { allCount = value; }
        }

        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        public int PrevPage
        {
            get 
            {
                if (CurrentPage<= 1)
                {
                    prevPage = 0;
                }
                else
                {
                    prevPage = CurrentPage - 1;
                }
                return prevPage;
            }
            set { prevPage = value; }
        }

        public int NextPage
        {
            get 
            {
                if (CurrentPage == PageCount)
                {
                    nextPage = 0;
                }
                else
                {
                    nextPage = CurrentPage + 1;
                }
                return nextPage; 
            }
            set { nextPage = value; }
        }


        
    }
}
