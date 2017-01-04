

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

namespace DAL.JC.基础_代码字典
{
    /// <summary>
    ///数据库访问层的Jc_code实现类
    ///此类由代码生成器生成
    ///表名：JC_CODE
    ///生成日期：2016-01-12 17:59:40
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com

    /// </summary>
    public class Jc_codeDALImp : Base.BasDAL, Jc_codeDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_codeParam">要插入的jc_codeParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_code jc_codeParam, OracleConnection con)
        {
            if ("" == jc_codeParam.Id || null == jc_codeParam.Id)
            {
                jc_codeParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_CODE(id,name,value,fk_code_type,pym,wbm,remark,zfbz,sort) VALUES(:id,:name,:value,:fk_code_type,:pym,:wbm,:remark,:zfbz,:sort)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_codeParam.Id;
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = jc_codeParam.Name;
            sqlparams.Add(pName);
            OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
            pValue.Direction = ParameterDirection.Input;
            pValue.Value = jc_codeParam.Value;
            sqlparams.Add(pValue);
            OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
            pFk_code_type.Direction = ParameterDirection.Input;
            pFk_code_type.Value = jc_codeParam.Fk_code_type;
            sqlparams.Add(pFk_code_type);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_codeParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_codeParam.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = jc_codeParam.Remark;
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_codeParam.Zfbz;
            sqlparams.Add(pZfbz);
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = jc_codeParam.Sort;
            sqlparams.Add(pSort);
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (1 == flag)
            {
                result = true;
            }
            return result;

        }

        /// <summary>
        /// 插入多条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象,并且自动使用事务）
        /// 主键为null时，自动生成主键guid
        /// </summary>
        /// <param name="jc_codeParamList">要插入的jc_codeParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_code> jc_codeParamList, OracleConnection con)
        {
            if (jc_codeParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> valueList = new List<string>();

            List<string> fk_code_typeList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<decimal?> sortList = new List<decimal?>();

            for (int i = 0; i < jc_codeParamList.Count; i++)
            {
                Jc_code jc_codeParam = jc_codeParamList[i];
                if ("" == jc_codeParam.Id || null == jc_codeParam.Id)
                {
                    jc_codeParam.Id = Model.Common.GUIDHelper.getGuid();
                }

                idList.Add(jc_codeParam.Id);

                nameList.Add(jc_codeParam.Name);

                valueList.Add(jc_codeParam.Value);

                fk_code_typeList.Add(jc_codeParam.Fk_code_type);

                pymList.Add(jc_codeParam.Pym);

                wbmList.Add(jc_codeParam.Wbm);

                remarkList.Add(jc_codeParam.Remark);

                zfbzList.Add(jc_codeParam.Zfbz);

                sortList.Add(jc_codeParam.Sort);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_CODE(id,name,value,fk_code_type,pym,wbm,remark,zfbz,sort) VALUES(:id,:name,:value,:fk_code_type,:pym,:wbm,:remark,:zfbz,:sort)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);
            OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
            pValue.Direction = ParameterDirection.Input;
            pValue.Value = valueList.ToArray();
            sqlparams.Add(pValue);
            OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
            pFk_code_type.Direction = ParameterDirection.Input;
            pFk_code_type.Value = fk_code_typeList.ToArray();
            sqlparams.Add(pFk_code_type);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = sortList.ToArray();
            sqlparams.Add(pSort);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_codeParamList.Count, sqlparams.ToArray());
            if (jc_codeParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }


        /// <summary>
        /// 删除指定ID的一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// </summary>
        /// <param Name="id">要删除的数据的guid</param>
        /// <param Name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数为1时成功）</returns>
        public bool deleteById(string id, OracleConnection con)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：deleteById");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_CODE WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, pId);
            if (1 == flag)
            {
                result = true;
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
            if (null == idList || 0 == idList.Count)
            {
                throw new Exception("ID的集合不允许为空或者数量为0，请赋值后调用；错误出自：deleteByIdBatch");
            }
            StringBuilder sql = new StringBuilder("DELETE JC_CODE WHERE ID=:id");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con, idList.Count, pId);
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
        /// <param name="jc_codeParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_code jc_codeParamCondition, OracleConnection con)
        {
            if (null != jc_codeParamCondition.Id && "" != jc_codeParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_CODE ");

            if (null != jc_codeParamCondition.Name && "" != jc_codeParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_codeParamCondition.Name;
                sqlparams.Add(pName);

            }

            if (null != jc_codeParamCondition.Value && "" != jc_codeParamCondition.Value)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Direction = ParameterDirection.Input;
                pValue.Value = jc_codeParamCondition.Value;
                sqlparams.Add(pValue);

            }

            if (null != jc_codeParamCondition.Fk_code_type && "" != jc_codeParamCondition.Fk_code_type)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Direction = ParameterDirection.Input;
                pFk_code_type.Value = jc_codeParamCondition.Fk_code_type;
                sqlparams.Add(pFk_code_type);

            }

            if (null != jc_codeParamCondition.Pym && "" != jc_codeParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_codeParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_codeParamCondition.Wbm && "" != jc_codeParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_codeParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }

            if (null != jc_codeParamCondition.Remark && "" != jc_codeParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_codeParamCondition.Remark;
                sqlparams.Add(pRemark);

            }

            if (null != jc_codeParamCondition.Zfbz && "" != jc_codeParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_codeParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_codeParamCondition.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = jc_codeParamCondition.Sort;
                sqlparams.Add(pSort);

            }

            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag >= 0)
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
        /// <param name="jc_codeParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_code jc_codeParam, OracleConnection con)
        {
            if ("" == jc_codeParam.Id || null == jc_codeParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_CODE SET ");
            if (null != jc_codeParam.Name && "" != jc_codeParam.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_codeParam.Name;
                sqlparams.Add(pName);

            }

            if (null != jc_codeParam.Value && "" != jc_codeParam.Value)
            {
                this.isComma(sql);
                sql.Append(" VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Direction = ParameterDirection.Input;
                pValue.Value = jc_codeParam.Value;
                sqlparams.Add(pValue);

            }

            if (null != jc_codeParam.Fk_code_type && "" != jc_codeParam.Fk_code_type)
            {
                this.isComma(sql);
                sql.Append(" FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Direction = ParameterDirection.Input;
                pFk_code_type.Value = jc_codeParam.Fk_code_type;
                sqlparams.Add(pFk_code_type);

            }

            if (null != jc_codeParam.Pym && "" != jc_codeParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_codeParam.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_codeParam.Wbm && "" != jc_codeParam.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_codeParam.Wbm;
                sqlparams.Add(pWbm);

            }

            if (null != jc_codeParam.Remark && "" != jc_codeParam.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_codeParam.Remark;
                sqlparams.Add(pRemark);

            }

            if (null != jc_codeParam.Zfbz && "" != jc_codeParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_codeParam.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_codeParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = jc_codeParam.Sort;
                sqlparams.Add(pSort);

            }

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_codeParam.Id;
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
        /// <param name="jc_codeParamList">要修改的Jc_code对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_code> jc_codeParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> valueList = new List<string>();

            List<string> fk_code_typeList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> remarkList = new List<string>();

            List<string> zfbzList = new List<string>();

            List<decimal?> sortList = new List<decimal?>();

            for (int i = 0; i < jc_codeParamList.Count; i++)
            {
                Jc_code jc_codeParam = jc_codeParamList[i];
                if ("" == jc_codeParam.Id || null == jc_codeParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

                idList.Add(jc_codeParam.Id);

                nameList.Add(jc_codeParam.Name);

                valueList.Add(jc_codeParam.Value);

                fk_code_typeList.Add(jc_codeParam.Fk_code_type);

                pymList.Add(jc_codeParam.Pym);

                wbmList.Add(jc_codeParam.Wbm);

                remarkList.Add(jc_codeParam.Remark);

                zfbzList.Add(jc_codeParam.Zfbz);

                sortList.Add(jc_codeParam.Sort);

            }



            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_CODE SET ");
            this.isComma(sql);
            sql.Append(" NAME=:name ");
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);

            this.isComma(sql);
            sql.Append(" VALUE=:value ");
            OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
            pValue.Direction = ParameterDirection.Input;
            pValue.Value = valueList.ToArray();
            sqlparams.Add(pValue);

            this.isComma(sql);
            sql.Append(" FK_CODE_TYPE=:fk_code_type ");
            OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
            pFk_code_type.Direction = ParameterDirection.Input;
            pFk_code_type.Value = fk_code_typeList.ToArray();
            sqlparams.Add(pFk_code_type);

            this.isComma(sql);
            sql.Append(" PYM=:pym ");
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);

            this.isComma(sql);
            sql.Append(" WBM=:wbm ");
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);

            this.isComma(sql);
            sql.Append(" REMARK=:remark ");
            OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
            pRemark.Direction = ParameterDirection.Input;
            pRemark.Value = remarkList.ToArray();
            sqlparams.Add(pRemark);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            this.isComma(sql);
            sql.Append(" SORT=:sort ");
            OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
            pSort.Direction = ParameterDirection.Input;
            pSort.Value = sortList.ToArray();
            sqlparams.Add(pSort);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_codeParamList.Count, sqlparams.ToArray());
            if (jc_codeParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_codeParamCondition">条件对象</param>
        /// <param name="jc_codeParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_code jc_codeParamCondition, Jc_code jc_codeParamUpdate, OracleConnection con)
        {
            if ((null != jc_codeParamCondition.Id && "!=jc_codeParamCondition.Id)||(null!=jc_codeParamUpdate.Id&&" != jc_codeParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_CODE SET ");
            if (null != jc_codeParamUpdate.Name && "" != jc_codeParamUpdate.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_codeParamUpdate.Name;
                sqlparams.Add(pName);

            }

            if (null != jc_codeParamUpdate.Value && "" != jc_codeParamUpdate.Value)
            {
                this.isComma(sql);
                sql.Append(" VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Direction = ParameterDirection.Input;
                pValue.Value = jc_codeParamUpdate.Value;
                sqlparams.Add(pValue);

            }

            if (null != jc_codeParamUpdate.Fk_code_type && "" != jc_codeParamUpdate.Fk_code_type)
            {
                this.isComma(sql);
                sql.Append(" FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Direction = ParameterDirection.Input;
                pFk_code_type.Value = jc_codeParamUpdate.Fk_code_type;
                sqlparams.Add(pFk_code_type);

            }

            if (null != jc_codeParamUpdate.Pym && "" != jc_codeParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_codeParamUpdate.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_codeParamUpdate.Wbm && "" != jc_codeParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_codeParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }

            if (null != jc_codeParamUpdate.Remark && "" != jc_codeParamUpdate.Remark)
            {
                this.isComma(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_codeParamUpdate.Remark;
                sqlparams.Add(pRemark);

            }

            if (null != jc_codeParamUpdate.Zfbz && "" != jc_codeParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_codeParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_codeParamUpdate.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = jc_codeParamUpdate.Sort;
                sqlparams.Add(pSort);

            }

            //添加条件的参数

            if (null != jc_codeParamCondition.Name && "" != jc_codeParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_codeParamCondition.Name;
                sqlparams.Add(pName);

            }

            if (null != jc_codeParamCondition.Value && "" != jc_codeParamCondition.Value)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Direction = ParameterDirection.Input;
                pValue.Value = jc_codeParamCondition.Value;
                sqlparams.Add(pValue);

            }

            if (null != jc_codeParamCondition.Fk_code_type && "" != jc_codeParamCondition.Fk_code_type)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Direction = ParameterDirection.Input;
                pFk_code_type.Value = jc_codeParamCondition.Fk_code_type;
                sqlparams.Add(pFk_code_type);

            }

            if (null != jc_codeParamCondition.Pym && "" != jc_codeParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_codeParamCondition.Pym;
                sqlparams.Add(pPym);

            }

            if (null != jc_codeParamCondition.Wbm && "" != jc_codeParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_codeParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }

            if (null != jc_codeParamCondition.Remark && "" != jc_codeParamCondition.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_codeParamCondition.Remark;
                sqlparams.Add(pRemark);

            }

            if (null != jc_codeParamCondition.Zfbz && "" != jc_codeParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_codeParamCondition.Zfbz;
                sqlparams.Add(pZfbz);

            }

            if (null != jc_codeParamCondition.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = jc_codeParamCondition.Sort;
                sqlparams.Add(pSort);

            }

            this.b_isWhere = false;
            bool result = false;
            int flag = OracleHelper.ExecuteNonQuery(sql.ToString(), con, sqlparams.ToArray());
            if (flag >= 0)
            {
                result = true;
            }

            return result;
        }




        /// <summary>
        /// 查找指定ID的用户
        /// </summary>
        /// <remarks>id为null、id重复、id未找到，抛异常</remarks>
        /// <returns>Jc_code</returns>
        public Jc_code findById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_CODE A ");
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
        /// <param name="jc_codeParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_codeParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_code对象集合list</returns>
        public List<object> find(Jc_code jc_codeParam, Model.Common.PageInfo page, Jc_code jc_codeParamLike, List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_code对象，标示查询所有数据
            if (null == jc_codeParam)
            {
                jc_codeParam = new Jc_code();
            }
            if (null != jc_codeParam.Id && "" != jc_codeParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_code> jc_codeParamList = new List<Jc_code>();//接收查询出的Jc_code对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_code jc_codeParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_CODE A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_codeParam.Name && "" != jc_codeParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_codeParam.Name;
                sqlparams.Add(pName);
            }

            if (null != jc_codeParam.Value && "" != jc_codeParam.Value)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Direction = ParameterDirection.Input;
                pValue.Value = jc_codeParam.Value;
                sqlparams.Add(pValue);
            }

            if (null != jc_codeParam.Fk_code_type && "" != jc_codeParam.Fk_code_type)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Direction = ParameterDirection.Input;
                pFk_code_type.Value = jc_codeParam.Fk_code_type;
                sqlparams.Add(pFk_code_type);
            }

            if (null != jc_codeParam.Pym && "" != jc_codeParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_codeParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_codeParam.Wbm && "" != jc_codeParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_codeParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_codeParam.Remark && "" != jc_codeParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Direction = ParameterDirection.Input;
                pRemark.Value = jc_codeParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != jc_codeParam.Zfbz && "" != jc_codeParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_codeParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_codeParam.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Direction = ParameterDirection.Input;
                pSort.Value = jc_codeParam.Sort;
                sqlparams.Add(pSort);

            }

            if (jc_codeParamLike != null)
            {

                if (null != jc_codeParamLike.Name && "" != jc_codeParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_codeParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_codeParamLike.Value && "" != jc_codeParamLike.Value)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.VALUE LIKE '%'||:value||'%' ");
                    OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                    pValue.Direction = ParameterDirection.Input;
                    pValue.Value = jc_codeParamLike.Value;
                    sqlparams.Add(pValue);
                }

                if (null != jc_codeParamLike.Fk_code_type && "" != jc_codeParamLike.Fk_code_type)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_CODE_TYPE LIKE '%'||:fk_code_type||'%' ");
                    OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                    pFk_code_type.Direction = ParameterDirection.Input;
                    pFk_code_type.Value = jc_codeParamLike.Fk_code_type;
                    sqlparams.Add(pFk_code_type);
                }

                if (null != jc_codeParamLike.Pym && "" != jc_codeParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_codeParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_codeParamLike.Wbm && "" != jc_codeParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_codeParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_codeParamLike.Remark && "" != jc_codeParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_codeParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != jc_codeParamLike.Zfbz && "" != jc_codeParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_codeParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_code>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM (" + sqlParam + @") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_code>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_codeParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_codeParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_codeParamList);//把List<Jc_code>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }



        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_code jc_codeParam, Jc_code jc_codeParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_code对象，标示查询所有数据
            if (null == jc_codeParam)
            {
                jc_codeParam = new Jc_code();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_CODE A");
            if (null != jc_codeParam.Name && "" != jc_codeParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = jc_codeParam.Name;
                sqlparams.Add(pName);
            }

            if (null != jc_codeParam.Value && "" != jc_codeParam.Value)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Value = jc_codeParam.Value;
                sqlparams.Add(pValue);
            }

            if (null != jc_codeParam.Fk_code_type && "" != jc_codeParam.Fk_code_type)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Value = jc_codeParam.Fk_code_type;
                sqlparams.Add(pFk_code_type);
            }

            if (null != jc_codeParam.Pym && "" != jc_codeParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_codeParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_codeParam.Wbm && "" != jc_codeParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_codeParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_codeParam.Remark && "" != jc_codeParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = jc_codeParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != jc_codeParam.Zfbz && "" != jc_codeParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_codeParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_codeParam.Sort)
            {
                this.isComma(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Value = jc_codeParam.Sort;
                sqlparams.Add(pSort);

            }

            if (jc_codeParamLike != null)
            {

                if (null != jc_codeParamLike.Name && "" != jc_codeParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_codeParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_codeParamLike.Value && "" != jc_codeParamLike.Value)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.VALUE LIKE '%'||:value||'%' ");
                    OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                    pValue.Direction = ParameterDirection.Input;
                    pValue.Value = jc_codeParamLike.Value;
                    sqlparams.Add(pValue);
                }

                if (null != jc_codeParamLike.Fk_code_type && "" != jc_codeParamLike.Fk_code_type)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_CODE_TYPE LIKE '%'||:fk_code_type||'%' ");
                    OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                    pFk_code_type.Direction = ParameterDirection.Input;
                    pFk_code_type.Value = jc_codeParamLike.Fk_code_type;
                    sqlparams.Add(pFk_code_type);
                }

                if (null != jc_codeParamLike.Pym && "" != jc_codeParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_codeParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_codeParamLike.Wbm && "" != jc_codeParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_codeParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_codeParamLike.Remark && "" != jc_codeParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_codeParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != jc_codeParamLike.Zfbz && "" != jc_codeParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_codeParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(), sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_codeParam"></param>
        /// <returns></returns>
        public bool save(Jc_code jc_codeParam, OracleConnection con)
        {
            if ("" != jc_codeParam.Id && null != jc_codeParam.Id)
            {
                //修改
                return this.updateById(jc_codeParam, con);
            }
            else
            {
                //新增
                return this.insert(jc_codeParam, con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_code dataSetToModel(DataRow row)
        {
            Jc_code jc_codeParam = new Jc_code();
            jc_codeParam.Id = Convert.ToString(row["ID"]).Trim();
            jc_codeParam.Name = Convert.ToString(row["NAME"]).Trim();
            jc_codeParam.Value = Convert.ToString(row["VALUE"]).Trim();
            jc_codeParam.Fk_code_type = Convert.ToString(row["FK_CODE_TYPE"]).Trim();
            jc_codeParam.Pym = Convert.ToString(row["PYM"]).Trim();
            jc_codeParam.Wbm = Convert.ToString(row["WBM"]).Trim();
            jc_codeParam.Remark = Convert.ToString(row["REMARK"]).Trim();
            jc_codeParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim();
            jc_codeParam.Sort = (decimal?)this.convertDBNullValue(row["SORT"]);

            return jc_codeParam;
        }



        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_code dataSetContactObjectsToModel(DataRow row)
        {
            Jc_code jc_codeParam = this.dataSetToModel(row);

            #region 添加Jc_code_type类别实体对象
            Jc_code_type jc_code_type = new Jc_code_type();
            jc_code_type.Id = Convert.ToString(row["JE_ID"]).Trim();
            jc_code_type.Name = Convert.ToString(row["JE_NAME"]).Trim();
            jc_code_type.Value = Convert.ToString(row["JE_VALUE"]).Trim();
            jc_code_type.Pym = Convert.ToString(row["JE_PYM"]).Trim();
            jc_code_type.Wbm = Convert.ToString(row["JE_WBM"]).Trim();
            jc_code_type.Remark = Convert.ToString(row["JE_REMARK"]).Trim();
            jc_code_type.Zfbz = Convert.ToString(row["JE_ZFBZ"]).Trim();
            jc_code_type.Sort = (decimal?)this.convertDBNullValue(row["JE_SORT"]);

            jc_codeParam.Jc_code_type = jc_code_type;
            #endregion 添加Jc_code_type类别实体对象

            return jc_codeParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_code</returns>
        public Jc_code findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_CODE_TYPE.ID AS JE_ID
            ,TT_JC_CODE_TYPE.NAME AS JE_NAME
            ,TT_JC_CODE_TYPE.VALUE AS JE_VALUE
            ,TT_JC_CODE_TYPE.PYM AS JE_PYM
            ,TT_JC_CODE_TYPE.WBM AS JE_WBM
            ,TT_JC_CODE_TYPE.REMARK AS JE_REMARK
            ,TT_JC_CODE_TYPE.ZFBZ AS JE_ZFBZ
            ,TT_JC_CODE_TYPE.SORT AS JE_SORT
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_CODE A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_CODE_TYPE TT_JC_CODE_TYPE 
            ON A.FK_CODE_TYPE = TT_JC_CODE_TYPE.ID

            ");

            //新建一个方法，在此加入多表连接的语句end
            sql.Append(" WHERE A.ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = id;
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), pId);
            DataRowCollection rows = ds.Tables[0].Rows;
            if (rows.Count > 1)
            {
                throw new Exception("此ID的数据有多个，主键不允许重复，请检查数据");
            }
            if (rows.Count == 0)
            {
                throw new Exception("此ID的数据不存在，请检查数据");
            }
            return this.dataSetContactObjectsToModel(rows[0]);
        }

        /// <summary>
        /// 根据用户传入的参数查询（id参数排除在外，如需查询id请使用findById方法）
        /// 第一个参数是查询参数，如果查询参数为null则查询所有
        /// 第二个参数是分页参数，传入带数据总行数的分页对象得到默认前PageSiz条数据（取决于page对象中的值），如果传null，则查出所有数据
        /// 第三个参数提供模糊查询功能，只适用于string类型的字段
        /// 第四个参数是排序的参数，传入排序的对象的集合，如果传null，则默认使用ID字段进行排序
        /// </summary>
        /// <param name="jc_codeParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_codeParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_code对象集合list</returns>
        public List<object> findContactObjects(Jc_code jc_codeParam, Model.Common.PageInfo page, Jc_code jc_codeParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_code对象，标示查询所有数据
            if (null == jc_codeParam)
            {
                jc_codeParam = new Jc_code();
            }
            if (null != jc_codeParam.Id && "" != jc_codeParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_code> jc_codeParamList = new List<Jc_code>();//接收查询出的Jc_code对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_code jc_codeParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_CODE_TYPE.ID AS JE_ID
            ,TT_JC_CODE_TYPE.NAME AS JE_NAME
            ,TT_JC_CODE_TYPE.VALUE AS JE_VALUE
            ,TT_JC_CODE_TYPE.PYM AS JE_PYM
            ,TT_JC_CODE_TYPE.WBM AS JE_WBM
            ,TT_JC_CODE_TYPE.REMARK AS JE_REMARK
            ,TT_JC_CODE_TYPE.ZFBZ AS JE_ZFBZ
            ,TT_JC_CODE_TYPE.SORT AS JE_SORT
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_CODE A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_CODE_TYPE TT_JC_CODE_TYPE 
            ON A.FK_CODE_TYPE = TT_JC_CODE_TYPE.ID

            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_codeParam.Name && "" != jc_codeParam.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = jc_codeParam.Name;
                sqlparams.Add(pName);
            }

            if (null != jc_codeParam.Value && "" != jc_codeParam.Value)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.VALUE=:value ");
                OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                pValue.Value = jc_codeParam.Value;
                sqlparams.Add(pValue);
            }

            if (null != jc_codeParam.Fk_code_type && "" != jc_codeParam.Fk_code_type)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_CODE_TYPE=:fk_code_type ");
                OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                pFk_code_type.Value = jc_codeParam.Fk_code_type;
                sqlparams.Add(pFk_code_type);
            }

            if (null != jc_codeParam.Pym && "" != jc_codeParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_codeParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_codeParam.Wbm && "" != jc_codeParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_codeParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_codeParam.Remark && "" != jc_codeParam.Remark)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.REMARK=:remark ");
                OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                pRemark.Value = jc_codeParam.Remark;
                sqlparams.Add(pRemark);
            }

            if (null != jc_codeParam.Zfbz && "" != jc_codeParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_codeParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (null != jc_codeParam.Sort)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SORT=:sort ");
                OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                pSort.Value = jc_codeParam.Sort;
                sqlparams.Add(pSort);

            }

            if (jc_codeParamLike != null)
            {

                if (null != jc_codeParamLike.Name && "" != jc_codeParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_codeParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_codeParamLike.Value && "" != jc_codeParamLike.Value)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.VALUE LIKE '%'||:value||'%' ");
                    OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                    pValue.Direction = ParameterDirection.Input;
                    pValue.Value = jc_codeParamLike.Value;
                    sqlparams.Add(pValue);
                }

                if (null != jc_codeParamLike.Fk_code_type && "" != jc_codeParamLike.Fk_code_type)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_CODE_TYPE LIKE '%'||:fk_code_type||'%' ");
                    OracleParameter pFk_code_type = new OracleParameter(":fk_code_type", OracleDbType.Varchar2);
                    pFk_code_type.Direction = ParameterDirection.Input;
                    pFk_code_type.Value = jc_codeParamLike.Fk_code_type;
                    sqlparams.Add(pFk_code_type);
                }

                if (null != jc_codeParamLike.Pym && "" != jc_codeParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_codeParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_codeParamLike.Wbm && "" != jc_codeParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_codeParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_codeParamLike.Remark && "" != jc_codeParamLike.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.REMARK LIKE '%'||:remark||'%' ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Direction = ParameterDirection.Input;
                    pRemark.Value = jc_codeParamLike.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != jc_codeParamLike.Zfbz && "" != jc_codeParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_codeParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != jc_codeParam.Jc_code_type)
            {

                if (null != jc_codeParam.Jc_code_type.Id && null != jc_codeParam.Jc_code_type.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = jc_codeParam.Jc_code_type.Id;
                    sqlparams.Add(pId);
                }

                if (null != jc_codeParam.Jc_code_type.Name && null != jc_codeParam.Jc_code_type.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Value = jc_codeParam.Jc_code_type.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_codeParam.Jc_code_type.Value && null != jc_codeParam.Jc_code_type.Value)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.VALUE=:value ");
                    OracleParameter pValue = new OracleParameter(":value", OracleDbType.NVarchar2);
                    pValue.Value = jc_codeParam.Jc_code_type.Value;
                    sqlparams.Add(pValue);
                }

                if (null != jc_codeParam.Jc_code_type.Pym && null != jc_codeParam.Jc_code_type.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Value = jc_codeParam.Jc_code_type.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_codeParam.Jc_code_type.Wbm && null != jc_codeParam.Jc_code_type.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Value = jc_codeParam.Jc_code_type.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_codeParam.Jc_code_type.Remark && null != jc_codeParam.Jc_code_type.Remark)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.REMARK=:remark ");
                    OracleParameter pRemark = new OracleParameter(":remark", OracleDbType.NVarchar2);
                    pRemark.Value = jc_codeParam.Jc_code_type.Remark;
                    sqlparams.Add(pRemark);
                }

                if (null != jc_codeParam.Jc_code_type.Zfbz && null != jc_codeParam.Jc_code_type.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_CODE_TYPE.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = jc_codeParam.Jc_code_type.Zfbz;
                    sqlparams.Add(pZfbz);
                }

                if (null != jc_codeParam.Jc_code_type.Sort)
                {
                    this.isComma(sql);
                    sql.Append(" TT_JC_CODE_TYPE.SORT=:sort ");
                    OracleParameter pSort = new OracleParameter(":sort", OracleDbType.Decimal);
                    pSort.Value = jc_codeParam.Jc_code_type.Sort;
                    sqlparams.Add(pSort);

                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_code>对象,索引1为Model.Common.PageInfo分页信息对象
            if (null != page)
            {
                string sqlParam = sql.ToString();
                sql = new StringBuilder(@" SELECT * FROM 
                (
                SELECT A.*, ROWNUM RN 
                FROM (" + sqlParam + @") A 
                WHERE ROWNUM <= :maxIndex
                )
                WHERE RN >= :minIndex ");
                sqlparams.Add(new OracleParameter("maxIndex", page.MaxIndex));
                sqlparams.Add(new OracleParameter("minIndex", page.MinIndex));
            }
            //*******分页end1*********
            DataSet ds = OracleHelper.getDataSet(sql.ToString(), sqlparams.ToArray());
            DataRowCollection rows = ds.Tables[0].Rows;
            //把每一行数据转换为一个对象放入List<Jc_code>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_codeParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_codeParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_codeParamList);//把List<Jc_code>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end

    }
}


