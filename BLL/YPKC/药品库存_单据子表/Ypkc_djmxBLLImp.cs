
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using BLL.YPKC.药品库存_单据子表;
using Model.YPKC;
using DAL.YPKC.药品库存_单据子表;
using Model.Common;

namespace BLL.YPKC.药品库存_单据子表
{
    /// <summary>
    ///业务逻辑层的实现类
    ///此类由代码生成器生成
    ///生成日期：2015-12-19 10:59:05
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    ///如果使用到事务
    ///引入命名空间using System.Transactions;
    ///Windows服务中开启MSDTC（Distributed Transaction Coordinator）
    ///数据库客户端和数据库服务器都必须开启此服务
    ///如果使用到事务,如下例子
    /*  bool flag1 = false;//指示第一个数据访问是否成功
        bool flag2 = false;//指示第二个数据访问是否成功
        bool flagResul = false//最终返回的结果
            ;
        using (TransactionScope ts = new TransactionScope())//创建一个事务对象
        {
            using (OracleConnection con = DAL.Common.OracleHelper.getConnection())//在这个事务对象中创建OracleConnection，使用事务时必须得使用同一个OracleConnection，否则达不到数据完整性的要求
            {
                //删除type
                flag1 = xxxDal.delete(xxxParam.Id, con);//调用数据访问层的方法
                //删除属于此type类型的所有code
                flag2 = xxxDal.delete(xxxParam.Id, con);//调用数据访问层的方法
                if (flag1 && flag2)
                {
                    flagResul = true;
                    ts.Complete();//执行成功之后提交整个事务
                }
                return flagResul;
            }
        }
     */
    /// </summary>
    public class Ypkc_djmxBLLImp:Ypkc_djmxBLL
    {
        private Ypkc_djmxDAL ypkc_djmxDal = new Ypkc_djmxDALImp();
        
        /// <summary>
        /// 单条记录保存方法，有ID为修改，没有ID为新增
        /// </summary>
        /// <param name="ypkc_djmxParam">保存的对象</param>
        /// <returns>bool,是否成功</returns>
        public bool save(Ypkc_djmx ypkc_djmxParam)
        {
            return ypkc_djmxDal.save(ypkc_djmxParam,null);
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="ypkc_djmxParam"></param>
        /// <returns>bool,是否成功</returns>
        public bool inertList(List<Ypkc_djmx> ypkc_djmxParamList)
        {
            return ypkc_djmxDal.inertBatch(ypkc_djmxParamList,null);
        }

        /// <summary>
        /// 根据主键删除一条记录
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>bool,是否成功</returns>
        public bool deleteById(string id)
        {
            return ypkc_djmxDal.deleteById(id,null);
        }

        /// <summary>
        /// 根据ID的集合删除多条记录
        /// </summary>
        /// <param name="idList">id的集合</param>
        /// <returns>bool,是否成功</returns>
        public bool deleteByIdList(List<string> idList)
        {
            return ypkc_djmxDal.deleteByIdBatch(idList,null);
        }

        /// <summary>
        /// 批量修改（每个对象必须有ID）
        /// </summary>
        /// <param name="ypkc_djmxParamList">要修改的数据集合</param>
        /// <returns>bool,是否成功</returns>
        public bool updateByIdList(List<Ypkc_djmx> ypkc_djmxParamList)
        {
            return ypkc_djmxDal.updateByIdBatch(ypkc_djmxParamList, null);
        }

        /// <summary>
        /// 根据参数条件，得到满足条件的YPKC_DJMX的所有对象列表
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第三个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="ypkc_djmxParam">查询参数</param>
        ///<param name="ypkc_djmxParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        public List<object> getList(Ypkc_djmx ypkc_djmxParam,Ypkc_djmx ypkc_djmxParamLike,List<SortInfo> sortList)
        {
            return ypkc_djmxDal.find(ypkc_djmxParam, null,ypkc_djmxParamLike,sortList);
        }

        /// <summary>
        /// 根据参数条件，得到满足条件的YPKC_DJMX的所有对象列表（使用分页的方式）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，如果page参数为null,方法则会new一个默认的page，根据page中的pagesize参数查询出相应的条数
        /// 第三个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="ypkc_djmxParam">查询参数</param>
        ///<param name="ypkc_djmxParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        public List<object> getListByPage(Ypkc_djmx ypkc_djmxParam, Model.Common.PageInfo page,Ypkc_djmx ypkc_djmxParamLike,List<SortInfo> sortList)
        {
            //如果没有传分页对象，构建一个对应的分页对象（重点是必须给AllCount属性赋值）
            if (null==page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = ypkc_djmxDal.getCount(ypkc_djmxParam,ypkc_djmxParamLike);
            }
            return ypkc_djmxDal.find(ypkc_djmxParam, page,ypkc_djmxParamLike,sortList);
             
        }

        /// <summary>
        /// 根据主键得到一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ypkc_djmx</returns>
        public Ypkc_djmx getById(string id)
        {
            return ypkc_djmxDal.findById(id);
        }

        /// <summary>
        /// 根据条件得到记录数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <param name="ypkc_djmxParam"></param>
        /// <returns></returns>
        public int getCount(Ypkc_djmx ypkc_djmxParam,Ypkc_djmx ypkc_djmxParamLike)
        {
            return ypkc_djmxDal.getCount(ypkc_djmxParam,ypkc_djmxParamLike);
        }
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
    }
}

