

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.JC;
using Model.Common;

namespace DAL.JC.基础_发票领用管理
{
    /// <summary>
    ///数据库访问层的Jc_fply实现类
    ///此类由代码生成器生成
    ///表名：JC_FPLY
    ///生成日期：2015-12-02 15:38:16
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_fplyDALImp :Base.BasDAL,Jc_fplyDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_fplyParam">要插入的jc_fplyParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_fply jc_fplyParam,OracleConnection con)
        {
            if (""==jc_fplyParam.Id||null==jc_fplyParam.Id)
            {
                jc_fplyParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_FPLY(id,lsh,lyr_id,lysj,fph_start,fph_end,czy_id,fplx,zfbz) VALUES(:id,:lsh,:lyr_id,:lysj,:fph_start,:fph_end,:czy_id,:fplx,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_fplyParam.Id;
            sqlparams.Add(pId);
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = jc_fplyParam.Lsh;
            sqlparams.Add(pLsh);
            OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
            pLyr_id.Direction = ParameterDirection.Input;
            pLyr_id.Value = jc_fplyParam.Lyr_id;
            sqlparams.Add(pLyr_id);
            OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
            pLysj.Direction = ParameterDirection.Input;
            pLysj.Value = jc_fplyParam.Lysj;
            sqlparams.Add(pLysj);
            OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
            pFph_start.Direction = ParameterDirection.Input;
            pFph_start.Value = jc_fplyParam.Fph_start;
            sqlparams.Add(pFph_start);
            OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
            pFph_end.Direction = ParameterDirection.Input;
            pFph_end.Value = jc_fplyParam.Fph_end;
            sqlparams.Add(pFph_end);
            OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
            pCzy_id.Direction = ParameterDirection.Input;
            pCzy_id.Value = jc_fplyParam.Czy_id;
            sqlparams.Add(pCzy_id);
            OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
            pFplx.Direction = ParameterDirection.Input;
            pFplx.Value = jc_fplyParam.Fplx;
            sqlparams.Add(pFplx);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_fplyParam.Zfbz;
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result =  true;
            }
            return result;

        }

        /// <summary>
        /// 插入多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象,并且自动使用事务）
        /// 主键为null时，自动生成主键guid
        /// </summary>
        /// <param name="jc_fplyParamList">要插入的jc_fplyParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_fply> jc_fplyParamList, OracleConnection con)
        {
            if (jc_fplyParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<decimal?> lshList = new List<decimal?>();

            List<string> lyr_idList = new List<string>();

            List<DateTime> lysjList = new List<DateTime>();

            List<string> fph_startList = new List<string>();

            List<string> fph_endList = new List<string>();

            List<string> czy_idList = new List<string>();

            List<string> fplxList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_fplyParamList.Count; i++)
            {
                Jc_fply jc_fplyParam = jc_fplyParamList[i];
                if ("" == jc_fplyParam.Id || null == jc_fplyParam.Id)
                {
                    jc_fplyParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_fplyParam.Id);

            lshList.Add(jc_fplyParam.Lsh);

            lyr_idList.Add(jc_fplyParam.Lyr_id);

            lysjList.Add(jc_fplyParam.Lysj);

            fph_startList.Add(jc_fplyParam.Fph_start);

            fph_endList.Add(jc_fplyParam.Fph_end);

            czy_idList.Add(jc_fplyParam.Czy_id);

            fplxList.Add(jc_fplyParam.Fplx);

            zfbzList.Add(jc_fplyParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_FPLY(id,lsh,lyr_id,lysj,fph_start,fph_end,czy_id,fplx,zfbz) VALUES(:id,:lsh,:lyr_id,:lysj,:fph_start,:fph_end,:czy_id,:fplx,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = lshList.ToArray();
            sqlparams.Add(pLsh);
            OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
            pLyr_id.Direction = ParameterDirection.Input;
            pLyr_id.Value = lyr_idList.ToArray();
            sqlparams.Add(pLyr_id);
            OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
            pLysj.Direction = ParameterDirection.Input;
            pLysj.Value = lysjList.ToArray();
            sqlparams.Add(pLysj);
            OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
            pFph_start.Direction = ParameterDirection.Input;
            pFph_start.Value = fph_startList.ToArray();
            sqlparams.Add(pFph_start);
            OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
            pFph_end.Direction = ParameterDirection.Input;
            pFph_end.Value = fph_endList.ToArray();
            sqlparams.Add(pFph_end);
            OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
            pCzy_id.Direction = ParameterDirection.Input;
            pCzy_id.Value = czy_idList.ToArray();
            sqlparams.Add(pCzy_id);
            OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
            pFplx.Direction = ParameterDirection.Input;
            pFplx.Value = fplxList.ToArray();
            sqlparams.Add(pFplx);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_fplyParamList.Count, sqlparams.ToArray());
            if (jc_fplyParamList.Count == flag)
            {
                result  = true;
            }
            return result;
        }


        /// <summary>
        /// 删除指定ID的一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param Name="id">要删除的数据的guid</param>
        /// <param Name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数为1时成功）</returns>
        public bool deleteById(string id,OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：deleteById");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_FPLY WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            if (1 == flag)
            {
                result =  true;
            }
            else if (0 == flag)
            {
                throw new Exception("删除了" + flag + "条数据，请检查ID是否在数据库中存在；错误出自：deleteById");
            }
            else if (flag > 1)
            {
                throw new Exception("删除了" + flag + "条数据，数据库中主键重复；错误出自：deleteById");
            }
            return result;
        }

        /// <summary>
        /// 删除指定id集合的多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象，并且自动使用事务）
        /// </summary>
        /// <param name="idlist">要删除的数据的guid的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要删除的id的数量时成功）</returns>
        public bool deleteByIdBatch(List<string> idList, OracleConnection con)
        {
            if (null==idList||0==idList.Count)
            {
                throw new Exception("ID的集合不允许为空或者数量为0，请赋值后调用；错误出自：deleteByIdBatch");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_FPLY WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,idList.Count, pId);
            if (idList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据删除条件，删除多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果需要根据ID来删除数据，请调用deleteById或deleteByIdBatch方法
        /// </summary>
        /// <param name="jc_fplyParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_fply jc_fplyParamCondition, OracleConnection con)
        {
            if (null!=jc_fplyParamCondition.Id&&""!=jc_fplyParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_FPLY ");

            if (null != jc_fplyParamCondition.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = jc_fplyParamCondition.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != jc_fplyParamCondition.Lyr_id &&  ""!= jc_fplyParamCondition.Lyr_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYR_ID=:lyr_id ");
                OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Direction = ParameterDirection.Input;
                pLyr_id.Value = jc_fplyParamCondition.Lyr_id;
                sqlparams.Add(pLyr_id);

            }
                        
            if (DateTime.MinValue != jc_fplyParamCondition.Lysj &&null != jc_fplyParamCondition.Lysj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYSJ=:lysj ");
                OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Direction = ParameterDirection.Input;
                pLysj.Value = jc_fplyParamCondition.Lysj;
                sqlparams.Add(pLysj);

            }
                        
            if (null != jc_fplyParamCondition.Fph_start &&  ""!= jc_fplyParamCondition.Fph_start)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPH_START=:fph_start ");
                OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Direction = ParameterDirection.Input;
                pFph_start.Value = jc_fplyParamCondition.Fph_start;
                sqlparams.Add(pFph_start);

            }
                        
            if (null != jc_fplyParamCondition.Fph_end &&  ""!= jc_fplyParamCondition.Fph_end)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPH_END=:fph_end ");
                OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Direction = ParameterDirection.Input;
                pFph_end.Value = jc_fplyParamCondition.Fph_end;
                sqlparams.Add(pFph_end);

            }
                        
            if (null != jc_fplyParamCondition.Czy_id &&  ""!= jc_fplyParamCondition.Czy_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CZY_ID=:czy_id ");
                OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Direction = ParameterDirection.Input;
                pCzy_id.Value = jc_fplyParamCondition.Czy_id;
                sqlparams.Add(pCzy_id);

            }
                        
            if (null != jc_fplyParamCondition.Fplx &&  ""!= jc_fplyParamCondition.Fplx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPLX=:fplx ");
                OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Direction = ParameterDirection.Input;
                pFplx.Value = jc_fplyParamCondition.Fplx;
                sqlparams.Add(pFplx);

            }
                        
            if (null != jc_fplyParamCondition.Zfbz &&  ""!= jc_fplyParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_fplyParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag>=0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 修改指定ID的一条数据（自动生成OracleConnection对象，直接修改）
        /// 一般不直接调用此方法，请调用save方法进行插入和修改
        /// </summary>
        /// <remarks>ID为空抛出异常</remarks>
        /// <param name="jc_fplyParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_fply jc_fplyParam,OracleConnection con)
        {
            if ("" == jc_fplyParam.Id || null == jc_fplyParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_FPLY SET ");
            if (null != jc_fplyParam.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = jc_fplyParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != jc_fplyParam.Lyr_id &&  ""!= jc_fplyParam.Lyr_id)
            {
                this.isComma(sql);
                sql.Append(" LYR_ID=:lyr_id ");
                OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Direction = ParameterDirection.Input;
                pLyr_id.Value = jc_fplyParam.Lyr_id;
                sqlparams.Add(pLyr_id);

            }
                        
            if (DateTime.MinValue != jc_fplyParam.Lysj &&null != jc_fplyParam.Lysj)
            {
                this.isComma(sql);
                sql.Append(" LYSJ=:lysj ");
                OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Direction = ParameterDirection.Input;
                pLysj.Value = jc_fplyParam.Lysj;
                sqlparams.Add(pLysj);

            }
                        
            if (null != jc_fplyParam.Fph_start &&  ""!= jc_fplyParam.Fph_start)
            {
                this.isComma(sql);
                sql.Append(" FPH_START=:fph_start ");
                OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Direction = ParameterDirection.Input;
                pFph_start.Value = jc_fplyParam.Fph_start;
                sqlparams.Add(pFph_start);

            }
                        
            if (null != jc_fplyParam.Fph_end &&  ""!= jc_fplyParam.Fph_end)
            {
                this.isComma(sql);
                sql.Append(" FPH_END=:fph_end ");
                OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Direction = ParameterDirection.Input;
                pFph_end.Value = jc_fplyParam.Fph_end;
                sqlparams.Add(pFph_end);

            }
                        
            if (null != jc_fplyParam.Czy_id &&  ""!= jc_fplyParam.Czy_id)
            {
                this.isComma(sql);
                sql.Append(" CZY_ID=:czy_id ");
                OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Direction = ParameterDirection.Input;
                pCzy_id.Value = jc_fplyParam.Czy_id;
                sqlparams.Add(pCzy_id);

            }
                        
            if (null != jc_fplyParam.Fplx &&  ""!= jc_fplyParam.Fplx)
            {
                this.isComma(sql);
                sql.Append(" FPLX=:fplx ");
                OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Direction = ParameterDirection.Input;
                pFplx.Value = jc_fplyParam.Fplx;
                sqlparams.Add(pFplx);

            }
                        
            if (null != jc_fplyParam.Zfbz &&  ""!= jc_fplyParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_fplyParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_fplyParam.Id;
            sqlparams.Add(pId);
            this.b_isComma = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result = true;
            }
            else if (0 == flag)
            {
                throw new Exception("更新" + flag + "条数据，请检查ID是否在数据库中存在；错误出自：updateById");
            }
            else if (flag > 1)
            {
                throw new Exception("更新了" + flag + "条数据，数据库中主键重复；错误出自：updateById");
            }

            return result;
        }

        /// <summary>
        /// 根据List中的ID修改多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象，并且自动使用事务）
        /// </summary>
        /// <param name="jc_fplyParamList">要修改的Jc_fply对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_fply> jc_fplyParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<decimal?> lshList = new List<decimal?>();

            List<string> lyr_idList = new List<string>();

            List<DateTime> lysjList = new List<DateTime>();

            List<string> fph_startList = new List<string>();

            List<string> fph_endList = new List<string>();

            List<string> czy_idList = new List<string>();

            List<string> fplxList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_fplyParamList.Count; i++)
            {
                Jc_fply jc_fplyParam = jc_fplyParamList[i];
                if ("" == jc_fplyParam.Id || null == jc_fplyParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_fplyParam.Id);

            lshList.Add(jc_fplyParam.Lsh);

            lyr_idList.Add(jc_fplyParam.Lyr_id);

            lysjList.Add(jc_fplyParam.Lysj);

            fph_startList.Add(jc_fplyParam.Fph_start);

            fph_endList.Add(jc_fplyParam.Fph_end);

            czy_idList.Add(jc_fplyParam.Czy_id);

            fplxList.Add(jc_fplyParam.Fplx);

            zfbzList.Add(jc_fplyParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_FPLY SET ");
            this.isComma(sql);
            sql.Append(" LSH=:lsh ");
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = lshList.ToArray();
            sqlparams.Add(pLsh);

            this.isComma(sql);
            sql.Append(" LYR_ID=:lyr_id ");
            OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
            pLyr_id.Direction = ParameterDirection.Input;
            pLyr_id.Value = lyr_idList.ToArray();
            sqlparams.Add(pLyr_id);

            this.isComma(sql);
            sql.Append(" LYSJ=:lysj ");
            OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
            pLysj.Direction = ParameterDirection.Input;
            pLysj.Value = lysjList.ToArray();
            sqlparams.Add(pLysj);

            this.isComma(sql);
            sql.Append(" FPH_START=:fph_start ");
            OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
            pFph_start.Direction = ParameterDirection.Input;
            pFph_start.Value = fph_startList.ToArray();
            sqlparams.Add(pFph_start);

            this.isComma(sql);
            sql.Append(" FPH_END=:fph_end ");
            OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
            pFph_end.Direction = ParameterDirection.Input;
            pFph_end.Value = fph_endList.ToArray();
            sqlparams.Add(pFph_end);

            this.isComma(sql);
            sql.Append(" CZY_ID=:czy_id ");
            OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
            pCzy_id.Direction = ParameterDirection.Input;
            pCzy_id.Value = czy_idList.ToArray();
            sqlparams.Add(pCzy_id);

            this.isComma(sql);
            sql.Append(" FPLX=:fplx ");
            OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
            pFplx.Direction = ParameterDirection.Input;
            pFplx.Value = fplxList.ToArray();
            sqlparams.Add(pFplx);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_fplyParamList.Count, sqlparams.ToArray());
            if (jc_fplyParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_fplyParamCondition">条件对象</param>
        /// <param name="jc_fplyParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_fply jc_fplyParamCondition, Jc_fply jc_fplyParamUpdate, OracleConnection con)
        {
            if ((null!=jc_fplyParamCondition.Id&&"!=jc_fplyParamCondition.Id)||(null!=jc_fplyParamUpdate.Id&&"!=jc_fplyParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_FPLY SET ");
            if (null != jc_fplyParamUpdate.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = jc_fplyParamUpdate.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != jc_fplyParamUpdate.Lyr_id &&  ""!= jc_fplyParamUpdate.Lyr_id)
            {
                this.isComma(sql);
                sql.Append(" LYR_ID=:lyr_id ");
                OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Direction = ParameterDirection.Input;
                pLyr_id.Value = jc_fplyParamUpdate.Lyr_id;
                sqlparams.Add(pLyr_id);

            }
                        
            if (DateTime.MinValue != jc_fplyParamUpdate.Lysj &&null != jc_fplyParamUpdate.Lysj)
            {
                this.isComma(sql);
                sql.Append(" LYSJ=:lysj ");
                OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Direction = ParameterDirection.Input;
                pLysj.Value = jc_fplyParamUpdate.Lysj;
                sqlparams.Add(pLysj);

            }
                        
            if (null != jc_fplyParamUpdate.Fph_start &&  ""!= jc_fplyParamUpdate.Fph_start)
            {
                this.isComma(sql);
                sql.Append(" FPH_START=:fph_start ");
                OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Direction = ParameterDirection.Input;
                pFph_start.Value = jc_fplyParamUpdate.Fph_start;
                sqlparams.Add(pFph_start);

            }
                        
            if (null != jc_fplyParamUpdate.Fph_end &&  ""!= jc_fplyParamUpdate.Fph_end)
            {
                this.isComma(sql);
                sql.Append(" FPH_END=:fph_end ");
                OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Direction = ParameterDirection.Input;
                pFph_end.Value = jc_fplyParamUpdate.Fph_end;
                sqlparams.Add(pFph_end);

            }
                        
            if (null != jc_fplyParamUpdate.Czy_id &&  ""!= jc_fplyParamUpdate.Czy_id)
            {
                this.isComma(sql);
                sql.Append(" CZY_ID=:czy_id ");
                OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Direction = ParameterDirection.Input;
                pCzy_id.Value = jc_fplyParamUpdate.Czy_id;
                sqlparams.Add(pCzy_id);

            }
                        
            if (null != jc_fplyParamUpdate.Fplx &&  ""!= jc_fplyParamUpdate.Fplx)
            {
                this.isComma(sql);
                sql.Append(" FPLX=:fplx ");
                OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Direction = ParameterDirection.Input;
                pFplx.Value = jc_fplyParamUpdate.Fplx;
                sqlparams.Add(pFplx);

            }
                        
            if (null != jc_fplyParamUpdate.Zfbz &&  ""!= jc_fplyParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_fplyParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_fplyParamCondition.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = jc_fplyParamCondition.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != jc_fplyParamCondition.Lyr_id &&  ""!= jc_fplyParamCondition.Lyr_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYR_ID=:lyr_id ");
                OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Direction = ParameterDirection.Input;
                pLyr_id.Value = jc_fplyParamCondition.Lyr_id;
                sqlparams.Add(pLyr_id);

            }
                        
            if (DateTime.MinValue != jc_fplyParamCondition.Lysj &&null != jc_fplyParamCondition.Lysj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LYSJ=:lysj ");
                OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Direction = ParameterDirection.Input;
                pLysj.Value = jc_fplyParamCondition.Lysj;
                sqlparams.Add(pLysj);

            }
                        
            if (null != jc_fplyParamCondition.Fph_start &&  ""!= jc_fplyParamCondition.Fph_start)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPH_START=:fph_start ");
                OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Direction = ParameterDirection.Input;
                pFph_start.Value = jc_fplyParamCondition.Fph_start;
                sqlparams.Add(pFph_start);

            }
                        
            if (null != jc_fplyParamCondition.Fph_end &&  ""!= jc_fplyParamCondition.Fph_end)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPH_END=:fph_end ");
                OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Direction = ParameterDirection.Input;
                pFph_end.Value = jc_fplyParamCondition.Fph_end;
                sqlparams.Add(pFph_end);

            }
                        
            if (null != jc_fplyParamCondition.Czy_id &&  ""!= jc_fplyParamCondition.Czy_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CZY_ID=:czy_id ");
                OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Direction = ParameterDirection.Input;
                pCzy_id.Value = jc_fplyParamCondition.Czy_id;
                sqlparams.Add(pCzy_id);

            }
                        
            if (null != jc_fplyParamCondition.Fplx &&  ""!= jc_fplyParamCondition.Fplx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FPLX=:fplx ");
                OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Direction = ParameterDirection.Input;
                pFplx.Value = jc_fplyParamCondition.Fplx;
                sqlparams.Add(pFplx);

            }
                        
            if (null != jc_fplyParamCondition.Zfbz &&  ""!= jc_fplyParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_fplyParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag>=0)
            {
                result = true;
            }

            return result;
        }




        /// <summary>
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Jc_fply</returns>
        public Jc_fply findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_FPLY A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            sql.Append(" WHERE A.ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = id;
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), pId);
            DataRowCollection rows = ds.Tables[0].Rows;
            if (rows.Count > 1)
            {
                throw new Exception("此ID的数据有多个，主键不允许重复，请检查数据；错误出自：findById");
            }
            if (rows.Count == 0)
            {
                throw new Exception("此ID的数据不存在，请检查数据；错误出自：findById");
            }
            return this.dataSetToModel(rows[0]);
        }

        /// <summary>
        /// 根据用户传入的参数查询（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第三个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_fplyParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_fplyParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_fply对象集合list</returns>
        public List<object> find(Jc_fply jc_fplyParam, Model.Common.PageInfo page,Jc_fply jc_fplyParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_fply对象，标示查询所有数据
            if (null == jc_fplyParam)
            {
                jc_fplyParam = new Jc_fply();
            }
            if (null!=jc_fplyParam.Id&&""!=jc_fplyParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_fply> jc_fplyParamList = new List<Jc_fply>();//接收查询出的Jc_fply对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_fply jc_fplyParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_FPLY A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_fplyParam.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = jc_fplyParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != jc_fplyParam.Lyr_id && "" != jc_fplyParam.Lyr_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LYR_ID=:lyr_id ");
                OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Direction = ParameterDirection.Input;
                pLyr_id.Value = jc_fplyParam.Lyr_id;
                sqlparams.Add(pLyr_id);
            }
                
                if (DateTime.MinValue != jc_fplyParam.Lysj &&null != jc_fplyParam.Lysj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYSJ=:lysj ");
                    OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Direction = ParameterDirection.Input;
                pLysj.Value = jc_fplyParam.Lysj;
                sqlparams.Add(pLysj);
                }
                
            if (null != jc_fplyParam.Fph_start && "" != jc_fplyParam.Fph_start)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FPH_START=:fph_start ");
                OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Direction = ParameterDirection.Input;
                pFph_start.Value = jc_fplyParam.Fph_start;
                sqlparams.Add(pFph_start);
            }
                
            if (null != jc_fplyParam.Fph_end && "" != jc_fplyParam.Fph_end)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FPH_END=:fph_end ");
                OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Direction = ParameterDirection.Input;
                pFph_end.Value = jc_fplyParam.Fph_end;
                sqlparams.Add(pFph_end);
            }
                
            if (null != jc_fplyParam.Czy_id && "" != jc_fplyParam.Czy_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CZY_ID=:czy_id ");
                OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Direction = ParameterDirection.Input;
                pCzy_id.Value = jc_fplyParam.Czy_id;
                sqlparams.Add(pCzy_id);
            }
                
            if (null != jc_fplyParam.Fplx && "" != jc_fplyParam.Fplx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FPLX=:fplx ");
                OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Direction = ParameterDirection.Input;
                pFplx.Value = jc_fplyParam.Fplx;
                sqlparams.Add(pFplx);
            }
                
            if (null != jc_fplyParam.Zfbz && "" != jc_fplyParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_fplyParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_fplyParamLike!=null)
            {

                if (null != jc_fplyParamLike.Lyr_id && "" != jc_fplyParamLike.Lyr_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYR_ID LIKE '%'||:lyr_id||'%' ");
                    OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                    pLyr_id.Direction = ParameterDirection.Input;
                    pLyr_id.Value = jc_fplyParamLike.Lyr_id;
                    sqlparams.Add(pLyr_id);
                }
                
                if (null != jc_fplyParamLike.Fph_start && "" != jc_fplyParamLike.Fph_start)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_START LIKE '%'||:fph_start||'%' ");
                    OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                    pFph_start.Direction = ParameterDirection.Input;
                    pFph_start.Value = jc_fplyParamLike.Fph_start;
                    sqlparams.Add(pFph_start);
                }
                
                if (null != jc_fplyParamLike.Fph_end && "" != jc_fplyParamLike.Fph_end)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_END LIKE '%'||:fph_end||'%' ");
                    OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                    pFph_end.Direction = ParameterDirection.Input;
                    pFph_end.Value = jc_fplyParamLike.Fph_end;
                    sqlparams.Add(pFph_end);
                }
                
                if (null != jc_fplyParamLike.Czy_id && "" != jc_fplyParamLike.Czy_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CZY_ID LIKE '%'||:czy_id||'%' ");
                    OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                    pCzy_id.Direction = ParameterDirection.Input;
                    pCzy_id.Value = jc_fplyParamLike.Czy_id;
                    sqlparams.Add(pCzy_id);
                }
                
                if (null != jc_fplyParamLike.Fplx && "" != jc_fplyParamLike.Fplx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPLX LIKE '%'||:fplx||'%' ");
                    OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                    pFplx.Direction = ParameterDirection.Input;
                    pFplx.Value = jc_fplyParamLike.Fplx;
                    sqlparams.Add(pFplx);
                }
                
                if (null != jc_fplyParamLike.Zfbz && "" != jc_fplyParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_fplyParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_fply>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM ("+sqlParam+@") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_fply>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_fplyParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_fplyParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_fplyParamList);//把List<Jc_fply>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_fply jc_fplyParam,Jc_fply jc_fplyParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_fply对象，标示查询所有数据
            if (null == jc_fplyParam)
            {
                jc_fplyParam = new Jc_fply();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_FPLY A");
            if (null != jc_fplyParam.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Value = jc_fplyParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
                if (null != jc_fplyParam.Lyr_id && "" != jc_fplyParam.Lyr_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYR_ID=:lyr_id ");
                    OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                pLyr_id.Value = jc_fplyParam.Lyr_id;
                sqlparams.Add(pLyr_id);
                }
                
                if (DateTime.MinValue != jc_fplyParam.Lysj &&null != jc_fplyParam.Lysj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYSJ=:lysj ");
                    OracleParameter pLysj = new OracleParameter(":lysj", OracleDbType.Date);
                pLysj.Value = jc_fplyParam.Lysj;
                sqlparams.Add(pLysj);
                }
                
                if (null != jc_fplyParam.Fph_start && "" != jc_fplyParam.Fph_start)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_START=:fph_start ");
                    OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                pFph_start.Value = jc_fplyParam.Fph_start;
                sqlparams.Add(pFph_start);
                }
                
                if (null != jc_fplyParam.Fph_end && "" != jc_fplyParam.Fph_end)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_END=:fph_end ");
                    OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                pFph_end.Value = jc_fplyParam.Fph_end;
                sqlparams.Add(pFph_end);
                }
                
                if (null != jc_fplyParam.Czy_id && "" != jc_fplyParam.Czy_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CZY_ID=:czy_id ");
                    OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                pCzy_id.Value = jc_fplyParam.Czy_id;
                sqlparams.Add(pCzy_id);
                }
                
                if (null != jc_fplyParam.Fplx && "" != jc_fplyParam.Fplx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPLX=:fplx ");
                    OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                pFplx.Value = jc_fplyParam.Fplx;
                sqlparams.Add(pFplx);
                }
                
                if (null != jc_fplyParam.Zfbz && "" != jc_fplyParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_fplyParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_fplyParamLike!=null)
            {

                if (null != jc_fplyParamLike.Lyr_id && "" != jc_fplyParamLike.Lyr_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LYR_ID LIKE '%'||:lyr_id||'%' ");
                    OracleParameter pLyr_id = new OracleParameter(":lyr_id", OracleDbType.Varchar2);
                    pLyr_id.Direction = ParameterDirection.Input;
                    pLyr_id.Value = jc_fplyParamLike.Lyr_id;
                    sqlparams.Add(pLyr_id);
                }
                
                if (null != jc_fplyParamLike.Fph_start && "" != jc_fplyParamLike.Fph_start)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_START LIKE '%'||:fph_start||'%' ");
                    OracleParameter pFph_start = new OracleParameter(":fph_start", OracleDbType.NVarchar2);
                    pFph_start.Direction = ParameterDirection.Input;
                    pFph_start.Value = jc_fplyParamLike.Fph_start;
                    sqlparams.Add(pFph_start);
                }
                
                if (null != jc_fplyParamLike.Fph_end && "" != jc_fplyParamLike.Fph_end)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPH_END LIKE '%'||:fph_end||'%' ");
                    OracleParameter pFph_end = new OracleParameter(":fph_end", OracleDbType.NVarchar2);
                    pFph_end.Direction = ParameterDirection.Input;
                    pFph_end.Value = jc_fplyParamLike.Fph_end;
                    sqlparams.Add(pFph_end);
                }
                
                if (null != jc_fplyParamLike.Czy_id && "" != jc_fplyParamLike.Czy_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CZY_ID LIKE '%'||:czy_id||'%' ");
                    OracleParameter pCzy_id = new OracleParameter(":czy_id", OracleDbType.Varchar2);
                    pCzy_id.Direction = ParameterDirection.Input;
                    pCzy_id.Value = jc_fplyParamLike.Czy_id;
                    sqlparams.Add(pCzy_id);
                }
                
                if (null != jc_fplyParamLike.Fplx && "" != jc_fplyParamLike.Fplx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FPLX LIKE '%'||:fplx||'%' ");
                    OracleParameter pFplx = new OracleParameter(":fplx", OracleDbType.Varchar2);
                    pFplx.Direction = ParameterDirection.Input;
                    pFplx.Value = jc_fplyParamLike.Fplx;
                    sqlparams.Add(pFplx);
                }
                
                if (null != jc_fplyParamLike.Zfbz && "" != jc_fplyParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_fplyParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_fplyParam"></param>
        /// <returns></returns>
        public bool save(Jc_fply jc_fplyParam,OracleConnection con)
        {
            if ("" != jc_fplyParam.Id && null != jc_fplyParam.Id)
            {
                //修改
                return this.updateById(jc_fplyParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_fplyParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_fply dataSetToModel(DataRow row)
        {
            Jc_fply jc_fplyParam = new Jc_fply();
            jc_fplyParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_fplyParam.Lsh =  (decimal?)this.convertDBNullValue(row["LSH"]);
            jc_fplyParam.Lyr_id = Convert.ToString(row["LYR_ID"]).Trim(); 
            jc_fplyParam.Lysj =  (DateTime)row["LYSJ"];
            jc_fplyParam.Fph_start = Convert.ToString(row["FPH_START"]).Trim(); 
            jc_fplyParam.Fph_end = Convert.ToString(row["FPH_END"]).Trim(); 
            jc_fplyParam.Czy_id = Convert.ToString(row["CZY_ID"]).Trim(); 
            jc_fplyParam.Fplx = Convert.ToString(row["FPLX"]).Trim(); 
            jc_fplyParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_fplyParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region

        #endregion
        //*******************在此以后添加新的方法end
        
    }
}


