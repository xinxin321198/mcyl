
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using BLL.JC.基础_工作人员所属科室关系;
using Model.JC;
using DAL.JC.基础_工作人员所属科室关系;
using Model.Common;

namespace BLL.JC.基础_工作人员所属科室关系
{
    /// <summary>
    ///业务逻辑层的实现类
    ///此类由代码生成器生成
    ///生成日期：2015-12-02 15:50:44
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
    public class Jc_ry_ksBLLImp:Jc_ry_ksBLL
    {
        private Jc_ry_ksDAL jc_ry_ksDal = new Jc_ry_ksDALImp();
        
        /// <summary>
        /// 单条记录保存方法，有ID为修改，没有ID为新增
        /// </summary>
        /// <param name="jc_ry_ksParam">保存的对象</param>
        /// <returns>bool,是否成功</returns>
        public bool save(Jc_ry_ks jc_ry_ksParam)
        {
            return jc_ry_ksDal.save(jc_ry_ksParam,null);
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <param name="jc_ry_ksParam"></param>
        /// <returns>bool,是否成功</returns>
        public bool inertList(List<Jc_ry_ks> jc_ry_ksParamList)
        {
            return jc_ry_ksDal.inertBatch(jc_ry_ksParamList,null);
        }

        /// <summary>
        /// 根据主键删除一条记录
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>bool,是否成功</returns>
        public bool deleteById(string id)
        {
            return jc_ry_ksDal.deleteById(id,null);
        }

        /// <summary>
        /// 根据ID的集合删除多条记录
        /// </summary>
        /// <param name="idList">id的集合</param>
        /// <returns>bool,是否成功</returns>
        public bool deleteByIdList(List<string> idList)
        {
            return jc_ry_ksDal.deleteByIdBatch(idList,null);
        }

        /// <summary>
        /// 批量修改（每个对象必须有ID）
        /// </summary>
        /// <param name="jc_ry_ksParamList">要修改的数据集合</param>
        /// <returns>bool,是否成功</returns>
        public bool updateByIdList(List<Jc_ry_ks> jc_ry_ksParamList)
        {
            return jc_ry_ksDal.updateByIdBatch(jc_ry_ksParamList, null);
        }

        /// <summary>
        /// 根据参数条件，得到满足条件的JC_RY_KS的所有对象列表
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第三个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_ry_ksParam">查询参数</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        public List<object> getList(Jc_ry_ks jc_ry_ksParam,Jc_ry_ks jc_ry_ksParamLike,List<SortInfo> sortList)
        {
            return jc_ry_ksDal.find(jc_ry_ksParam, null,jc_ry_ksParamLike,sortList);
        }

        /// <summary>
        /// 根据参数条件，得到满足条件的JC_RY_KS的所有对象列表（使用分页的方式）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，如果page参数为null,方法则会new一个默认的page，根据page中的pagesize参数查询出相应的条数
        /// 第三个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_ry_ksParam">查询参数</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        public List<object> getListByPage(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page,Jc_ry_ks jc_ry_ksParamLike,List<SortInfo> sortList)
        {
            //如果没有传分页对象，构建一个对应的分页对象（重点是必须给AllCount属性赋值）
            if (null==page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = jc_ry_ksDal.getCount(jc_ry_ksParam, jc_ry_ksParamLike);
            }
            return jc_ry_ksDal.find(jc_ry_ksParam, page,jc_ry_ksParamLike,sortList);
             
        }

        /// <summary>
        /// 根据主键得到一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Jc_ry_ks</returns>
        public Jc_ry_ks getById(string id)
        {
            return jc_ry_ksDal.findById(id);
        }

        /// <summary>
        /// 根据条件得到记录数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <param name="jc_ry_ksParam"></param>
        /// <returns></returns>
        public int getCount(Jc_ry_ks jc_ry_ksParam,Jc_ry_ks jc_ry_ksParamLike)
        {
            return jc_ry_ksDal.getCount(jc_ry_ksParam,jc_ry_ksParamLike);
        }
        //*******************在此以后添加新的方法start
        #region BLL层的implement,实现，start

        /// <summary>
        /// 根据主键，得到一条记录以及它的相关联对象
        /// </summary>
        ///<param name="id">主键</param>
        public Jc_ry_ks getContactObjectById(string id)
        {
            return jc_ry_ksDal.findContactObjectsById(id);
        }


        /// <summary>
        /// 得到所有关联对象,不带分页参数，显示根据条件得到的所有数据
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第三个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        ///<param name="jc_ry_ksParam">查询参数</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>List<object>,索引0为数据，索引1为分页对象</returns>
        public List<object> getListContactObject(Jc_ry_ks jc_ry_ksParam, Jc_ry_ks jc_ry_ksParamLike, List<SortInfo> sortList)
        {
            return jc_ry_ksDal.findContactObjects(jc_ry_ksParam, null, jc_ry_ksParamLike, sortList);
        }

        /// <summary>
        /// 得到所有关联对象，带分页参数，给分页参数指定pagesize得到第一页的数据或者不指定分页参数，系统使用默认的pagesize值
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，如果page参数为null,方法则会new一个默认的page，根据page中的pagesize参数查询出相应的条数
        /// 第三个参数是模糊查询参数，提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        ///<param name="jc_ry_ksParam">查询参数</param>
        ///<param name="jc_ry_ksParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>List<object>,索引0为数据，索引1为分页对象</returns>
        public List<object> getListContactObjectByPage(Jc_ry_ks jc_ry_ksParam, Model.Common.PageInfo page, Jc_ry_ks jc_ry_ksParamLike, List<SortInfo> sortList)
        {
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = jc_ry_ksDal.getCount(jc_ry_ksParam, jc_ry_ksParamLike);
            }
            return jc_ry_ksDal.findContactObjects(jc_ry_ksParam, page, jc_ry_ksParamLike, sortList);
        }

        #endregion BLL层的implement,实现，end











        
    }
}

