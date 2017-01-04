
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.Common;
using Model.YPKC;

namespace DAL.YPKC.药品库存_库存表
{
    /// <summary>
    ///数据库访问层的接口interface
    ///此类由代码生成器生成
    ///表名：YPKC_KC
    ///生成日期：2015-12-21 12:00:47
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public interface Ypkc_kcDAL
    {


        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="ypkc_kcParam">要插入的Ypkc_kc对象</param>
        /// <param name="con">Oracle连接对象</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        bool insert(Ypkc_kc ypkc_kcParam,OracleConnection con);

        /// <summary>
        /// 插入多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，如果不指定id,方法自动生成主键guid
        /// </summary>
        /// <param name="ypkc_kcParam">要插入的Ypkc_kc对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        bool inertBatch(List<Ypkc_kc> ypkc_kcParamList, OracleConnection con);

        /// <summary>
        /// 删除指定ID的一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param Name="id">要删除的数据的guid</param>
        /// <param Name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数为1时成功）</returns>
        bool deleteById(string id,OracleConnection con);

        /// <summary>
        /// 删除指定id集合的多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param name="idlist">要删除的数据的guid的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要删除的id的数量时成功）</returns>
        bool deleteByIdBatch(List<string> idlist, OracleConnection con);

        /// <summary>
        /// 根据删除条件，删除多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果需要根据ID来删除数据，请调用deleteById或deleteByIdBatch方法
        /// </summary>
        /// <param name="ypkc_kcParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        bool deleteByOtherCondition(Ypkc_kc ypkc_kcParamCondition , OracleConnection con);

        /// <summary>
        /// 根据ID修改一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 一般不直接调用此方法，请调用save方法进行插入和修改 
        /// </summary>
        /// <remarks>ID为空抛出异常</remarks>
        /// <param name="ypkc_kcParam">要修改的ypkc_kcParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否修改成功（影响的行数为1时成功）</returns>
        bool updateById(Ypkc_kc ypkc_kcParam,OracleConnection con);

        /// <summary>
        /// 根据codeList中的ID修改多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param name=ypkc_kcParamList">要修改的ypkc_kcParamList对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        bool updateByIdBatch(List<Ypkc_kc> ypkc_kcParamList, OracleConnection con);

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId或updateByIdBatch方法
        /// </summary>
        /// <param name="ypkc_kcParamCondition">条件对象</param>
        /// <param name="ypkc_kcParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        bool updateByOtherCondition(Ypkc_kc ypkc_kcParamCondition, Ypkc_kc ypkc_kcParamUpdate, OracleConnection con);

        /// <summary>
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Ypkc_kc</returns>
        Ypkc_kc findById(string id);

        /// <summary>
        /// 根据用户传入的参数查询（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第三个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_kcParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_kc对象集合list</returns>
        List<object> find(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList);
        
        /// <summary>
        /// 快速查询（药品编号匹配第一位，药品名称匹配名称和通用名称，拼音码匹配所有）
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page"></param>
        /// <param name="ypkc_kcParamLike"></param>
        /// <param name="sortList"></param>
        /// <returns></returns>
        List<object> findForFast(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList);

        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int,数量</returns>
        int getCount(Ypkc_kc ypkc_kcParam,Ypkc_kc ypkc_kcParamLike);

        /// <summary>
        /// 通用的保存方法，可新增或修改，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="ypkc_kcParam">要保存或更新的Ypkc_kc对象</param>
        /// <returns>bool，保存是否成功</returns>
        bool save(Ypkc_kc ypkc_kcParam,OracleConnection con);


        //*******************在此以后添加新的方法start
        #region DAL层的interface,接口，start
        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Ypkc_kc</returns>
        Ypkc_kc findContactObjectsById(string id);

        /// <summary>
        /// 根据用户传入的参数查询得到相关联的外键对象方法（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第二个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="ypkc_kcParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="ypkc_kcParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Ypkc_kc对象集合list</returns>
        List<object> findContactObjects(Ypkc_kc ypkc_kcParam, Model.Common.PageInfo page, Ypkc_kc ypkc_kcParamLike, List<SortInfo> sortList);


        #endregion DAL层的interface,接口，end
        //*******************在此以后添加新的方法end
    }
}
