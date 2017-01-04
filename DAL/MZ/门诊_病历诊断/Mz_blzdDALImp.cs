

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Common;
using System.Transactions;//引入事务
using Oracle.DataAccess.Client;//引入oracle驱动
using Model.MZ;
using Model.Common;

namespace DAL.MZ.门诊_病历诊断
{
    /// <summary>
    ///数据库访问层的Mz_blzd实现类
    ///此类由代码生成器生成
    ///表名：MZ_BLZD
    ///生成日期：2015-12-31 10:48:20
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_blzdDALImp :Base.BasDAL,Mz_blzdDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="mz_blzdParam">要插入的mz_blzdParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Mz_blzd mz_blzdParam,OracleConnection con)
        {
            if (""==mz_blzdParam.Id||null==mz_blzdParam.Id)
            {
                mz_blzdParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO MZ_BLZD(id,zfbz,fk_gh_id,gh_lsh,fk_icd10_id,icd10_code,icd10_name,fk_bl_id) VALUES(:id,:zfbz,:fk_gh_id,:gh_lsh,:fk_icd10_id,:icd10_code,:icd10_name,:fk_bl_id)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = mz_blzdParam.Id;
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = mz_blzdParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = mz_blzdParam.Fk_gh_id;
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = mz_blzdParam.Gh_lsh;
            sqlparams.Add(pGh_lsh);
            OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
            pFk_icd10_id.Direction = ParameterDirection.Input;
            pFk_icd10_id.Value = mz_blzdParam.Fk_icd10_id;
            sqlparams.Add(pFk_icd10_id);
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = mz_blzdParam.Icd10_code;
            sqlparams.Add(pIcd10_code);
            OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
            pIcd10_name.Direction = ParameterDirection.Input;
            pIcd10_name.Value = mz_blzdParam.Icd10_name;
            sqlparams.Add(pIcd10_name);
            OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
            pFk_bl_id.Direction = ParameterDirection.Input;
            pFk_bl_id.Value = mz_blzdParam.Fk_bl_id;
            sqlparams.Add(pFk_bl_id);
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
        /// <param name="mz_blzdParamList">要插入的mz_blzdParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Mz_blzd> mz_blzdParamList, OracleConnection con)
        {
            if (mz_blzdParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> fk_icd10_idList = new List<string>();

            List<string> icd10_codeList = new List<string>();

            List<string> icd10_nameList = new List<string>();

            List<string> fk_bl_idList = new List<string>();

            for (int i = 0; i < mz_blzdParamList.Count; i++)
            {
                Mz_blzd mz_blzdParam = mz_blzdParamList[i];
                if ("" == mz_blzdParam.Id || null == mz_blzdParam.Id)
                {
                    mz_blzdParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(mz_blzdParam.Id);

            zfbzList.Add(mz_blzdParam.Zfbz);

            fk_gh_idList.Add(mz_blzdParam.Fk_gh_id);

            gh_lshList.Add(mz_blzdParam.Gh_lsh);

            fk_icd10_idList.Add(mz_blzdParam.Fk_icd10_id);

            icd10_codeList.Add(mz_blzdParam.Icd10_code);

            icd10_nameList.Add(mz_blzdParam.Icd10_name);

            fk_bl_idList.Add(mz_blzdParam.Fk_bl_id);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO MZ_BLZD(id,zfbz,fk_gh_id,gh_lsh,fk_icd10_id,icd10_code,icd10_name,fk_bl_id) VALUES(:id,:zfbz,:fk_gh_id,:gh_lsh,:fk_icd10_id,:icd10_code,:icd10_name,:fk_bl_id)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = fk_gh_idList.ToArray();
            sqlparams.Add(pFk_gh_id);
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = gh_lshList.ToArray();
            sqlparams.Add(pGh_lsh);
            OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
            pFk_icd10_id.Direction = ParameterDirection.Input;
            pFk_icd10_id.Value = fk_icd10_idList.ToArray();
            sqlparams.Add(pFk_icd10_id);
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = icd10_codeList.ToArray();
            sqlparams.Add(pIcd10_code);
            OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
            pIcd10_name.Direction = ParameterDirection.Input;
            pIcd10_name.Value = icd10_nameList.ToArray();
            sqlparams.Add(pIcd10_name);
            OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
            pFk_bl_id.Direction = ParameterDirection.Input;
            pFk_bl_id.Value = fk_bl_idList.ToArray();
            sqlparams.Add(pFk_bl_id);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, mz_blzdParamList.Count, sqlparams.ToArray());
            if (mz_blzdParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE MZ_BLZD WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE MZ_BLZD WHERE ID=:id");
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
        /// <param name="mz_blzdParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Mz_blzd mz_blzdParamCondition, OracleConnection con)
        {
            if (null!=mz_blzdParamCondition.Id&&""!=mz_blzdParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE MZ_BLZD ");

            if (null != mz_blzdParamCondition.Zfbz &&  ""!= mz_blzdParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blzdParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blzdParamCondition.Fk_gh_id &&  ""!= mz_blzdParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blzdParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blzdParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blzdParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blzdParamCondition.Fk_icd10_id &&  ""!= mz_blzdParamCondition.Fk_icd10_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ICD10_ID=:fk_icd10_id ");
                OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Direction = ParameterDirection.Input;
                pFk_icd10_id.Value = mz_blzdParamCondition.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);

            }
                        
            if (null != mz_blzdParamCondition.Icd10_code &&  ""!= mz_blzdParamCondition.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = mz_blzdParamCondition.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != mz_blzdParamCondition.Icd10_name &&  ""!= mz_blzdParamCondition.Icd10_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_NAME=:icd10_name ");
                OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Direction = ParameterDirection.Input;
                pIcd10_name.Value = mz_blzdParamCondition.Icd10_name;
                sqlparams.Add(pIcd10_name);

            }
                        
            if (null != mz_blzdParamCondition.Fk_bl_id &&  ""!= mz_blzdParamCondition.Fk_bl_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_BL_ID=:fk_bl_id ");
                OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Direction = ParameterDirection.Input;
                pFk_bl_id.Value = mz_blzdParamCondition.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);

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
        /// <param name="mz_blzdParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Mz_blzd mz_blzdParam,OracleConnection con)
        {
            if ("" == mz_blzdParam.Id || null == mz_blzdParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_BLZD SET ");
            if (null != mz_blzdParam.Zfbz &&  ""!= mz_blzdParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blzdParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blzdParam.Fk_gh_id &&  ""!= mz_blzdParam.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blzdParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blzdParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blzdParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blzdParam.Fk_icd10_id &&  ""!= mz_blzdParam.Fk_icd10_id)
            {
                this.isComma(sql);
                sql.Append(" FK_ICD10_ID=:fk_icd10_id ");
                OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Direction = ParameterDirection.Input;
                pFk_icd10_id.Value = mz_blzdParam.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);

            }
                        
            if (null != mz_blzdParam.Icd10_code &&  ""!= mz_blzdParam.Icd10_code)
            {
                this.isComma(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = mz_blzdParam.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != mz_blzdParam.Icd10_name &&  ""!= mz_blzdParam.Icd10_name)
            {
                this.isComma(sql);
                sql.Append(" ICD10_NAME=:icd10_name ");
                OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Direction = ParameterDirection.Input;
                pIcd10_name.Value = mz_blzdParam.Icd10_name;
                sqlparams.Add(pIcd10_name);

            }
                        
            if (null != mz_blzdParam.Fk_bl_id &&  ""!= mz_blzdParam.Fk_bl_id)
            {
                this.isComma(sql);
                sql.Append(" FK_BL_ID=:fk_bl_id ");
                OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Direction = ParameterDirection.Input;
                pFk_bl_id.Value = mz_blzdParam.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = mz_blzdParam.Id;
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
        /// <param name="mz_blzdParamList">要修改的Mz_blzd对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Mz_blzd> mz_blzdParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<string> fk_gh_idList = new List<string>();

            List<decimal?> gh_lshList = new List<decimal?>();

            List<string> fk_icd10_idList = new List<string>();

            List<string> icd10_codeList = new List<string>();

            List<string> icd10_nameList = new List<string>();

            List<string> fk_bl_idList = new List<string>();

            for (int i = 0; i < mz_blzdParamList.Count; i++)
            {
                Mz_blzd mz_blzdParam = mz_blzdParamList[i];
                if ("" == mz_blzdParam.Id || null == mz_blzdParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(mz_blzdParam.Id);

            zfbzList.Add(mz_blzdParam.Zfbz);

            fk_gh_idList.Add(mz_blzdParam.Fk_gh_id);

            gh_lshList.Add(mz_blzdParam.Gh_lsh);

            fk_icd10_idList.Add(mz_blzdParam.Fk_icd10_id);

            icd10_codeList.Add(mz_blzdParam.Icd10_code);

            icd10_nameList.Add(mz_blzdParam.Icd10_name);

            fk_bl_idList.Add(mz_blzdParam.Fk_bl_id);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_BLZD SET ");
            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" FK_GH_ID=:fk_gh_id ");
            OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
            pFk_gh_id.Direction = ParameterDirection.Input;
            pFk_gh_id.Value = fk_gh_idList.ToArray();
            sqlparams.Add(pFk_gh_id);

            this.isComma(sql);
            sql.Append(" GH_LSH=:gh_lsh ");
            OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
            pGh_lsh.Direction = ParameterDirection.Input;
            pGh_lsh.Value = gh_lshList.ToArray();
            sqlparams.Add(pGh_lsh);

            this.isComma(sql);
            sql.Append(" FK_ICD10_ID=:fk_icd10_id ");
            OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
            pFk_icd10_id.Direction = ParameterDirection.Input;
            pFk_icd10_id.Value = fk_icd10_idList.ToArray();
            sqlparams.Add(pFk_icd10_id);

            this.isComma(sql);
            sql.Append(" ICD10_CODE=:icd10_code ");
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = icd10_codeList.ToArray();
            sqlparams.Add(pIcd10_code);

            this.isComma(sql);
            sql.Append(" ICD10_NAME=:icd10_name ");
            OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
            pIcd10_name.Direction = ParameterDirection.Input;
            pIcd10_name.Value = icd10_nameList.ToArray();
            sqlparams.Add(pIcd10_name);

            this.isComma(sql);
            sql.Append(" FK_BL_ID=:fk_bl_id ");
            OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
            pFk_bl_id.Direction = ParameterDirection.Input;
            pFk_bl_id.Value = fk_bl_idList.ToArray();
            sqlparams.Add(pFk_bl_id);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,mz_blzdParamList.Count, sqlparams.ToArray());
            if (mz_blzdParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="mz_blzdParamCondition">条件对象</param>
        /// <param name="mz_blzdParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Mz_blzd mz_blzdParamCondition, Mz_blzd mz_blzdParamUpdate, OracleConnection con)
        {
            if ((null!=mz_blzdParamCondition.Id&&"!=mz_blzdParamCondition.Id)||(null!=mz_blzdParamUpdate.Id&&"!=mz_blzdParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE MZ_BLZD SET ");
            if (null != mz_blzdParamUpdate.Zfbz &&  ""!= mz_blzdParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blzdParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blzdParamUpdate.Fk_gh_id &&  ""!= mz_blzdParamUpdate.Fk_gh_id)
            {
                this.isComma(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blzdParamUpdate.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blzdParamUpdate.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blzdParamUpdate.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blzdParamUpdate.Fk_icd10_id &&  ""!= mz_blzdParamUpdate.Fk_icd10_id)
            {
                this.isComma(sql);
                sql.Append(" FK_ICD10_ID=:fk_icd10_id ");
                OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Direction = ParameterDirection.Input;
                pFk_icd10_id.Value = mz_blzdParamUpdate.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);

            }
                        
            if (null != mz_blzdParamUpdate.Icd10_code &&  ""!= mz_blzdParamUpdate.Icd10_code)
            {
                this.isComma(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = mz_blzdParamUpdate.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != mz_blzdParamUpdate.Icd10_name &&  ""!= mz_blzdParamUpdate.Icd10_name)
            {
                this.isComma(sql);
                sql.Append(" ICD10_NAME=:icd10_name ");
                OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Direction = ParameterDirection.Input;
                pIcd10_name.Value = mz_blzdParamUpdate.Icd10_name;
                sqlparams.Add(pIcd10_name);

            }
                        
            if (null != mz_blzdParamUpdate.Fk_bl_id &&  ""!= mz_blzdParamUpdate.Fk_bl_id)
            {
                this.isComma(sql);
                sql.Append(" FK_BL_ID=:fk_bl_id ");
                OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Direction = ParameterDirection.Input;
                pFk_bl_id.Value = mz_blzdParamUpdate.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);

            }
                        
            //添加条件的参数
            
            if (null != mz_blzdParamCondition.Zfbz &&  ""!= mz_blzdParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blzdParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            if (null != mz_blzdParamCondition.Fk_gh_id &&  ""!= mz_blzdParamCondition.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blzdParamCondition.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);

            }
                        
            if (null != mz_blzdParamCondition.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blzdParamCondition.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blzdParamCondition.Fk_icd10_id &&  ""!= mz_blzdParamCondition.Fk_icd10_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_ICD10_ID=:fk_icd10_id ");
                OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Direction = ParameterDirection.Input;
                pFk_icd10_id.Value = mz_blzdParamCondition.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);

            }
                        
            if (null != mz_blzdParamCondition.Icd10_code &&  ""!= mz_blzdParamCondition.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = mz_blzdParamCondition.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != mz_blzdParamCondition.Icd10_name &&  ""!= mz_blzdParamCondition.Icd10_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_NAME=:icd10_name ");
                OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Direction = ParameterDirection.Input;
                pIcd10_name.Value = mz_blzdParamCondition.Icd10_name;
                sqlparams.Add(pIcd10_name);

            }
                        
            if (null != mz_blzdParamCondition.Fk_bl_id &&  ""!= mz_blzdParamCondition.Fk_bl_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_BL_ID=:fk_bl_id ");
                OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Direction = ParameterDirection.Input;
                pFk_bl_id.Value = mz_blzdParamCondition.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);

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
        /// <returns>Mz_blzd</returns>
        public Mz_blzd findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_BLZD A ");
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
        /// <param name="mz_blzdParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="mz_blzdParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Mz_blzd对象集合list</returns>
        public List<object> find(Mz_blzd mz_blzdParam, Model.Common.PageInfo page,Mz_blzd mz_blzdParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Mz_blzd对象，标示查询所有数据
            if (null == mz_blzdParam)
            {
                mz_blzdParam = new Mz_blzd();
            }
            if (null!=mz_blzdParam.Id&&""!=mz_blzdParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Mz_blzd> mz_blzdParamList = new List<Mz_blzd>();//接收查询出的Mz_blzd对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Mz_blzd mz_blzdParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_BLZD A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != mz_blzdParam.Zfbz && "" != mz_blzdParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_blzdParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if (null != mz_blzdParam.Fk_gh_id && "" != mz_blzdParam.Fk_gh_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Direction = ParameterDirection.Input;
                pFk_gh_id.Value = mz_blzdParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
            }
                
            if (null != mz_blzdParam.Gh_lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Direction = ParameterDirection.Input;
                pGh_lsh.Value = mz_blzdParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
            if (null != mz_blzdParam.Fk_icd10_id && "" != mz_blzdParam.Fk_icd10_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_ICD10_ID=:fk_icd10_id ");
                OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Direction = ParameterDirection.Input;
                pFk_icd10_id.Value = mz_blzdParam.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);
            }
                
            if (null != mz_blzdParam.Icd10_code && "" != mz_blzdParam.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = mz_blzdParam.Icd10_code;
                sqlparams.Add(pIcd10_code);
            }
                
            if (null != mz_blzdParam.Icd10_name && "" != mz_blzdParam.Icd10_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICD10_NAME=:icd10_name ");
                OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Direction = ParameterDirection.Input;
                pIcd10_name.Value = mz_blzdParam.Icd10_name;
                sqlparams.Add(pIcd10_name);
            }
                
            if (null != mz_blzdParam.Fk_bl_id && "" != mz_blzdParam.Fk_bl_id)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_BL_ID=:fk_bl_id ");
                OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Direction = ParameterDirection.Input;
                pFk_bl_id.Value = mz_blzdParam.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);
            }
                
            if(mz_blzdParamLike!=null)
            {

                if (null != mz_blzdParamLike.Zfbz && "" != mz_blzdParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_blzdParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blzdParamLike.Fk_gh_id && "" != mz_blzdParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_blzdParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_blzdParamLike.Fk_icd10_id && "" != mz_blzdParamLike.Fk_icd10_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ICD10_ID LIKE '%'||:fk_icd10_id||'%' ");
                    OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                    pFk_icd10_id.Direction = ParameterDirection.Input;
                    pFk_icd10_id.Value = mz_blzdParamLike.Fk_icd10_id;
                    sqlparams.Add(pFk_icd10_id);
                }
                
                if (null != mz_blzdParamLike.Icd10_code && "" != mz_blzdParamLike.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE LIKE '%'||:icd10_code||'%' ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = mz_blzdParamLike.Icd10_code;
                    sqlparams.Add(pIcd10_code);
                }
                
                if (null != mz_blzdParamLike.Icd10_name && "" != mz_blzdParamLike.Icd10_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_NAME LIKE '%'||:icd10_name||'%' ");
                    OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                    pIcd10_name.Direction = ParameterDirection.Input;
                    pIcd10_name.Value = mz_blzdParamLike.Icd10_name;
                    sqlparams.Add(pIcd10_name);
                }
                
                if (null != mz_blzdParamLike.Fk_bl_id && "" != mz_blzdParamLike.Fk_bl_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_BL_ID LIKE '%'||:fk_bl_id||'%' ");
                    OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                    pFk_bl_id.Direction = ParameterDirection.Input;
                    pFk_bl_id.Value = mz_blzdParamLike.Fk_bl_id;
                    sqlparams.Add(pFk_bl_id);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Mz_blzd>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Mz_blzd>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //mz_blzdParamList.Add(this.dataSetContactObjectsToModel(row));
                mz_blzdParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(mz_blzdParamList);//把List<Mz_blzd>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Mz_blzd mz_blzdParam,Mz_blzd mz_blzdParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Mz_blzd对象，标示查询所有数据
            if (null == mz_blzdParam)
            {
                mz_blzdParam = new Mz_blzd();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM MZ_BLZD A");
                if (null != mz_blzdParam.Zfbz && "" != mz_blzdParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = mz_blzdParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blzdParam.Fk_gh_id && "" != mz_blzdParam.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID=:fk_gh_id ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                pFk_gh_id.Value = mz_blzdParam.Fk_gh_id;
                sqlparams.Add(pFk_gh_id);
                }
                
            if (null != mz_blzdParam.Gh_lsh)
            {
                this.isComma(sql);
                sql.Append(" GH_LSH=:gh_lsh ");
                OracleParameter pGh_lsh = new OracleParameter(":gh_lsh", OracleDbType.Decimal);
                pGh_lsh.Value = mz_blzdParam.Gh_lsh;
                sqlparams.Add(pGh_lsh);

            }
                        
                if (null != mz_blzdParam.Fk_icd10_id && "" != mz_blzdParam.Fk_icd10_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ICD10_ID=:fk_icd10_id ");
                    OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                pFk_icd10_id.Value = mz_blzdParam.Fk_icd10_id;
                sqlparams.Add(pFk_icd10_id);
                }
                
                if (null != mz_blzdParam.Icd10_code && "" != mz_blzdParam.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE=:icd10_code ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Value = mz_blzdParam.Icd10_code;
                sqlparams.Add(pIcd10_code);
                }
                
                if (null != mz_blzdParam.Icd10_name && "" != mz_blzdParam.Icd10_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_NAME=:icd10_name ");
                    OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                pIcd10_name.Value = mz_blzdParam.Icd10_name;
                sqlparams.Add(pIcd10_name);
                }
                
                if (null != mz_blzdParam.Fk_bl_id && "" != mz_blzdParam.Fk_bl_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_BL_ID=:fk_bl_id ");
                    OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                pFk_bl_id.Value = mz_blzdParam.Fk_bl_id;
                sqlparams.Add(pFk_bl_id);
                }
                
            if(mz_blzdParamLike!=null)
            {

                if (null != mz_blzdParamLike.Zfbz && "" != mz_blzdParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_blzdParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
                if (null != mz_blzdParamLike.Fk_gh_id && "" != mz_blzdParamLike.Fk_gh_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_GH_ID LIKE '%'||:fk_gh_id||'%' ");
                    OracleParameter pFk_gh_id = new OracleParameter(":fk_gh_id", OracleDbType.Varchar2);
                    pFk_gh_id.Direction = ParameterDirection.Input;
                    pFk_gh_id.Value = mz_blzdParamLike.Fk_gh_id;
                    sqlparams.Add(pFk_gh_id);
                }
                
                if (null != mz_blzdParamLike.Fk_icd10_id && "" != mz_blzdParamLike.Fk_icd10_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_ICD10_ID LIKE '%'||:fk_icd10_id||'%' ");
                    OracleParameter pFk_icd10_id = new OracleParameter(":fk_icd10_id", OracleDbType.Varchar2);
                    pFk_icd10_id.Direction = ParameterDirection.Input;
                    pFk_icd10_id.Value = mz_blzdParamLike.Fk_icd10_id;
                    sqlparams.Add(pFk_icd10_id);
                }
                
                if (null != mz_blzdParamLike.Icd10_code && "" != mz_blzdParamLike.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE LIKE '%'||:icd10_code||'%' ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = mz_blzdParamLike.Icd10_code;
                    sqlparams.Add(pIcd10_code);
                }
                
                if (null != mz_blzdParamLike.Icd10_name && "" != mz_blzdParamLike.Icd10_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_NAME LIKE '%'||:icd10_name||'%' ");
                    OracleParameter pIcd10_name = new OracleParameter(":icd10_name", OracleDbType.NVarchar2);
                    pIcd10_name.Direction = ParameterDirection.Input;
                    pIcd10_name.Value = mz_blzdParamLike.Icd10_name;
                    sqlparams.Add(pIcd10_name);
                }
                
                if (null != mz_blzdParamLike.Fk_bl_id && "" != mz_blzdParamLike.Fk_bl_id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_BL_ID LIKE '%'||:fk_bl_id||'%' ");
                    OracleParameter pFk_bl_id = new OracleParameter(":fk_bl_id", OracleDbType.Varchar2);
                    pFk_bl_id.Direction = ParameterDirection.Input;
                    pFk_bl_id.Value = mz_blzdParamLike.Fk_bl_id;
                    sqlparams.Add(pFk_bl_id);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="mz_blzdParam"></param>
        /// <returns></returns>
        public bool save(Mz_blzd mz_blzdParam,OracleConnection con)
        {
            if ("" != mz_blzdParam.Id && null != mz_blzdParam.Id)
            {
                //修改
                return this.updateById(mz_blzdParam,con);
            }
            else
            {
                //新增
                return this.insert(mz_blzdParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Mz_blzd dataSetToModel(DataRow row)
        {
            Mz_blzd mz_blzdParam = new Mz_blzd();
            mz_blzdParam.Id = Convert.ToString(row["ID"]).Trim(); 
            mz_blzdParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            mz_blzdParam.Fk_gh_id = Convert.ToString(row["FK_GH_ID"]).Trim(); 
            mz_blzdParam.Gh_lsh =  (decimal?)this.convertDBNullValue(row["GH_LSH"]);
            mz_blzdParam.Fk_icd10_id = Convert.ToString(row["FK_ICD10_ID"]).Trim(); 
            mz_blzdParam.Icd10_code = Convert.ToString(row["ICD10_CODE"]).Trim(); 
            mz_blzdParam.Icd10_name = Convert.ToString(row["ICD10_NAME"]).Trim(); 
            mz_blzdParam.Fk_bl_id = Convert.ToString(row["FK_BL_ID"]).Trim(); 
            
            return mz_blzdParam;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end
        
    }
}


