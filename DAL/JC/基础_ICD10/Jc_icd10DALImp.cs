

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

namespace DAL.JC.基础_ICD10
{
    /// <summary>
    ///数据库访问层的Jc_icd10实现类
    ///此类由代码生成器生成
    ///表名：JC_ICD10
    ///生成日期：2015-12-03 16:46:46
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_icd10DALImp :Base.BasDAL,Jc_icd10DAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_icd10Param">要插入的jc_icd10Param对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_icd10 jc_icd10Param,OracleConnection con)
        {
            if (""==jc_icd10Param.Id||null==jc_icd10Param.Id)
            {
                jc_icd10Param.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_ICD10(id,icd10_code,name,en_name,pym,wbm,zfbz) VALUES(:id,:icd10_code,:name,:en_name,:pym,:wbm,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_icd10Param.Id;
            sqlparams.Add(pId);
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = jc_icd10Param.Icd10_code;
            sqlparams.Add(pIcd10_code);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = jc_icd10Param.Name;
            sqlparams.Add(pName);
            OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
            pEn_name.Direction = ParameterDirection.Input;
            pEn_name.Value = jc_icd10Param.En_name;
            sqlparams.Add(pEn_name);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_icd10Param.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_icd10Param.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_icd10Param.Zfbz;
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
        /// <param name="jc_icd10ParamList">要插入的jc_icd10Param对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_icd10> jc_icd10ParamList, OracleConnection con)
        {
            if (jc_icd10ParamList.Count==0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> icd10_codeList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> en_nameList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_icd10ParamList.Count; i++)
            {
                Jc_icd10 jc_icd10Param = jc_icd10ParamList[i];
                if ("" == jc_icd10Param.Id || null == jc_icd10Param.Id)
                {
                    jc_icd10Param.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_icd10Param.Id);

            icd10_codeList.Add(jc_icd10Param.Icd10_code);

            nameList.Add(jc_icd10Param.Name);

            en_nameList.Add(jc_icd10Param.En_name);

            pymList.Add(jc_icd10Param.Pym);

            wbmList.Add(jc_icd10Param.Wbm);

            zfbzList.Add(jc_icd10Param.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_ICD10(id,icd10_code,name,en_name,pym,wbm,zfbz) VALUES(:id,:icd10_code,:name,:en_name,:pym,:wbm,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = icd10_codeList.ToArray();
            sqlparams.Add(pIcd10_code);
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);
            OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
            pEn_name.Direction = ParameterDirection.Input;
            pEn_name.Value = en_nameList.ToArray();
            sqlparams.Add(pEn_name);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_icd10ParamList.Count, sqlparams.ToArray());
            if (jc_icd10ParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_ICD10 WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_ICD10 WHERE ID=:id");
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
        /// <param name="jc_icd10ParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_icd10 jc_icd10ParamCondition, OracleConnection con)
        {
            if (null!=jc_icd10ParamCondition.Id&&""!=jc_icd10ParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_ICD10 ");

            if (null != jc_icd10ParamCondition.Icd10_code &&  ""!= jc_icd10ParamCondition.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10ParamCondition.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != jc_icd10ParamCondition.Name &&  ""!= jc_icd10ParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10ParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_icd10ParamCondition.En_name &&  ""!= jc_icd10ParamCondition.En_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10ParamCondition.En_name;
                sqlparams.Add(pEn_name);

            }
                        
            if (null != jc_icd10ParamCondition.Pym &&  ""!= jc_icd10ParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10ParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_icd10ParamCondition.Wbm &&  ""!= jc_icd10ParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10ParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_icd10ParamCondition.Zfbz &&  ""!= jc_icd10ParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10ParamCondition.Zfbz;
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
        /// <param name="jc_icd10Param"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_icd10 jc_icd10Param,OracleConnection con)
        {
            if ("" == jc_icd10Param.Id || null == jc_icd10Param.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_ICD10 SET ");
            if (null != jc_icd10Param.Icd10_code &&  ""!= jc_icd10Param.Icd10_code)
            {
                this.isComma(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10Param.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != jc_icd10Param.Name &&  ""!= jc_icd10Param.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10Param.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_icd10Param.En_name &&  ""!= jc_icd10Param.En_name)
            {
                this.isComma(sql);
                sql.Append(" EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10Param.En_name;
                sqlparams.Add(pEn_name);

            }
                        
            if (null != jc_icd10Param.Pym &&  ""!= jc_icd10Param.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10Param.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_icd10Param.Wbm &&  ""!= jc_icd10Param.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10Param.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_icd10Param.Zfbz &&  ""!= jc_icd10Param.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10Param.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_icd10Param.Id;
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
        /// <param name="jc_icd10ParamList">要修改的Jc_icd10对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_icd10> jc_icd10ParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> icd10_codeList = new List<string>();

            List<string> nameList = new List<string>();

            List<string> en_nameList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_icd10ParamList.Count; i++)
            {
                Jc_icd10 jc_icd10Param = jc_icd10ParamList[i];
                if ("" == jc_icd10Param.Id || null == jc_icd10Param.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_icd10Param.Id);

            icd10_codeList.Add(jc_icd10Param.Icd10_code);

            nameList.Add(jc_icd10Param.Name);

            en_nameList.Add(jc_icd10Param.En_name);

            pymList.Add(jc_icd10Param.Pym);

            wbmList.Add(jc_icd10Param.Wbm);

            zfbzList.Add(jc_icd10Param.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_ICD10 SET ");
            this.isComma(sql);
            sql.Append(" ICD10_CODE=:icd10_code ");
            OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
            pIcd10_code.Direction = ParameterDirection.Input;
            pIcd10_code.Value = icd10_codeList.ToArray();
            sqlparams.Add(pIcd10_code);

            this.isComma(sql);
            sql.Append(" NAME=:name ");
            OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
            pName.Direction = ParameterDirection.Input;
            pName.Value = nameList.ToArray();
            sqlparams.Add(pName);

            this.isComma(sql);
            sql.Append(" EN_NAME=:en_name ");
            OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
            pEn_name.Direction = ParameterDirection.Input;
            pEn_name.Value = en_nameList.ToArray();
            sqlparams.Add(pEn_name);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_icd10ParamList.Count, sqlparams.ToArray());
            if (jc_icd10ParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_icd10ParamCondition">条件对象</param>
        /// <param name="jc_icd10ParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_icd10 jc_icd10ParamCondition, Jc_icd10 jc_icd10ParamUpdate, OracleConnection con)
        {
            if ((null!=jc_icd10ParamCondition.Id&&"!=jc_icd10ParamCondition.Id)||(null!=jc_icd10ParamUpdate.Id&&"!=jc_icd10ParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_ICD10 SET ");
            if (null != jc_icd10ParamUpdate.Icd10_code &&  ""!= jc_icd10ParamUpdate.Icd10_code)
            {
                this.isComma(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10ParamUpdate.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != jc_icd10ParamUpdate.Name &&  ""!= jc_icd10ParamUpdate.Name)
            {
                this.isComma(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10ParamUpdate.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_icd10ParamUpdate.En_name &&  ""!= jc_icd10ParamUpdate.En_name)
            {
                this.isComma(sql);
                sql.Append(" EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10ParamUpdate.En_name;
                sqlparams.Add(pEn_name);

            }
                        
            if (null != jc_icd10ParamUpdate.Pym &&  ""!= jc_icd10ParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10ParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_icd10ParamUpdate.Wbm &&  ""!= jc_icd10ParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10ParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_icd10ParamUpdate.Zfbz &&  ""!= jc_icd10ParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10ParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_icd10ParamCondition.Icd10_code &&  ""!= jc_icd10ParamCondition.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10ParamCondition.Icd10_code;
                sqlparams.Add(pIcd10_code);

            }
                        
            if (null != jc_icd10ParamCondition.Name &&  ""!= jc_icd10ParamCondition.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10ParamCondition.Name;
                sqlparams.Add(pName);

            }
                        
            if (null != jc_icd10ParamCondition.En_name &&  ""!= jc_icd10ParamCondition.En_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10ParamCondition.En_name;
                sqlparams.Add(pEn_name);

            }
                        
            if (null != jc_icd10ParamCondition.Pym &&  ""!= jc_icd10ParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10ParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_icd10ParamCondition.Wbm &&  ""!= jc_icd10ParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10ParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_icd10ParamCondition.Zfbz &&  ""!= jc_icd10ParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10ParamCondition.Zfbz;
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
        /// <returns>Jc_icd10</returns>
        public Jc_icd10 findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ICD10 A ");
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
        /// <param name="jc_icd10Param"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_icd10ParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_icd10对象集合list</returns>
        public List<object> find(Jc_icd10 jc_icd10Param, Model.Common.PageInfo page,Jc_icd10 jc_icd10ParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_icd10对象，标示查询所有数据
            if (null == jc_icd10Param)
            {
                jc_icd10Param = new Jc_icd10();
            }
            if (null!=jc_icd10Param.Id&&""!=jc_icd10Param.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_icd10> jc_icd10ParamList = new List<Jc_icd10>();//接收查询出的Jc_icd10对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_icd10 jc_icd10Param, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ICD10 A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_icd10Param.Icd10_code && "" != jc_icd10Param.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10Param.Icd10_code;
                sqlparams.Add(pIcd10_code);
            }
                
            if (null != jc_icd10Param.Name && "" != jc_icd10Param.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10Param.Name;
                sqlparams.Add(pName);
            }
                
            if (null != jc_icd10Param.En_name && "" != jc_icd10Param.En_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10Param.En_name;
                sqlparams.Add(pEn_name);
            }
                
            if (null != jc_icd10Param.Pym && "" != jc_icd10Param.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10Param.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != jc_icd10Param.Wbm && "" != jc_icd10Param.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10Param.Wbm;
                sqlparams.Add(pWbm);
            }
                
            if (null != jc_icd10Param.Zfbz && "" != jc_icd10Param.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10Param.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_icd10ParamLike!=null)
            {

                if (null != jc_icd10ParamLike.Icd10_code && "" != jc_icd10ParamLike.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE LIKE '%'||:icd10_code||'%' ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = jc_icd10ParamLike.Icd10_code;
                    sqlparams.Add(pIcd10_code);
                }
                
                if (null != jc_icd10ParamLike.Name && "" != jc_icd10ParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_icd10ParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != jc_icd10ParamLike.En_name && "" != jc_icd10ParamLike.En_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EN_NAME LIKE '%'||:en_name||'%' ");
                    OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                    pEn_name.Direction = ParameterDirection.Input;
                    pEn_name.Value = jc_icd10ParamLike.En_name;
                    sqlparams.Add(pEn_name);
                }
                
                if (null != jc_icd10ParamLike.Pym && "" != jc_icd10ParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_icd10ParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_icd10ParamLike.Wbm && "" != jc_icd10ParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_icd10ParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_icd10ParamLike.Zfbz && "" != jc_icd10ParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_icd10ParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_icd10>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_icd10>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_icd10ParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_icd10ParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_icd10ParamList);//把List<Jc_icd10>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_icd10 jc_icd10Param,Jc_icd10 jc_icd10ParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_icd10对象，标示查询所有数据
            if (null == jc_icd10Param)
            {
                jc_icd10Param = new Jc_icd10();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_ICD10 A");
                if (null != jc_icd10Param.Icd10_code && "" != jc_icd10Param.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE=:icd10_code ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Value = jc_icd10Param.Icd10_code;
                sqlparams.Add(pIcd10_code);
                }
                
                if (null != jc_icd10Param.Name && "" != jc_icd10Param.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME=:name ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Value = jc_icd10Param.Name;
                sqlparams.Add(pName);
                }
                
                if (null != jc_icd10Param.En_name && "" != jc_icd10Param.En_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EN_NAME=:en_name ");
                    OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Value = jc_icd10Param.En_name;
                sqlparams.Add(pEn_name);
                }
                
                if (null != jc_icd10Param.Pym && "" != jc_icd10Param.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_icd10Param.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != jc_icd10Param.Wbm && "" != jc_icd10Param.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_icd10Param.Wbm;
                sqlparams.Add(pWbm);
                }
                
                if (null != jc_icd10Param.Zfbz && "" != jc_icd10Param.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_icd10Param.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_icd10ParamLike!=null)
            {

                if (null != jc_icd10ParamLike.Icd10_code && "" != jc_icd10ParamLike.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE LIKE '%'||:icd10_code||'%' ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = jc_icd10ParamLike.Icd10_code;
                    sqlparams.Add(pIcd10_code);
                }
                
                if (null != jc_icd10ParamLike.Name && "" != jc_icd10ParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_icd10ParamLike.Name;
                    sqlparams.Add(pName);
                }
                
                if (null != jc_icd10ParamLike.En_name && "" != jc_icd10ParamLike.En_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EN_NAME LIKE '%'||:en_name||'%' ");
                    OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                    pEn_name.Direction = ParameterDirection.Input;
                    pEn_name.Value = jc_icd10ParamLike.En_name;
                    sqlparams.Add(pEn_name);
                }
                
                if (null != jc_icd10ParamLike.Pym && "" != jc_icd10ParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_icd10ParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_icd10ParamLike.Wbm && "" != jc_icd10ParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_icd10ParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_icd10ParamLike.Zfbz && "" != jc_icd10ParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_icd10ParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_icd10Param"></param>
        /// <returns></returns>
        public bool save(Jc_icd10 jc_icd10Param,OracleConnection con)
        {
            if ("" != jc_icd10Param.Id && null != jc_icd10Param.Id)
            {
                //修改
                return this.updateById(jc_icd10Param,con);
            }
            else
            {
                //新增
                return this.insert(jc_icd10Param,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_icd10 dataSetToModel(DataRow row)
        {
            Jc_icd10 jc_icd10Param = new Jc_icd10();
            jc_icd10Param.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_icd10Param.Icd10_code = Convert.ToString(row["ICD10_CODE"]).Trim(); 
            jc_icd10Param.Name = Convert.ToString(row["NAME"]).Trim(); 
            jc_icd10Param.En_name = Convert.ToString(row["EN_NAME"]).Trim(); 
            jc_icd10Param.Pym = Convert.ToString(row["PYM"]).Trim(); 
            jc_icd10Param.Wbm = Convert.ToString(row["WBM"]).Trim(); 
            jc_icd10Param.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_icd10Param;
        }

       
        
        //*******************在此以后添加新的方法start

        //*******************在此以后添加新的方法end



        public List<object> findForFast(Jc_icd10 jc_icd10Param, Model.Common.PageInfo page, Jc_icd10 jc_icd10ParamLike, List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_icd10对象，标示查询所有数据
            if (null == jc_icd10Param)
            {
                jc_icd10Param = new Jc_icd10();
            }
            if (null != jc_icd10Param.Id && "" != jc_icd10Param.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_icd10> jc_icd10ParamList = new List<Jc_icd10>();//接收查询出的Jc_icd10对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_icd10 jc_icd10Param, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_ICD10 A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_icd10Param.Icd10_code && "" != jc_icd10Param.Icd10_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ICD10_CODE=:icd10_code ");
                OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                pIcd10_code.Direction = ParameterDirection.Input;
                pIcd10_code.Value = jc_icd10Param.Icd10_code;
                sqlparams.Add(pIcd10_code);
            }

            if (null != jc_icd10Param.Name && "" != jc_icd10Param.Name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NAME=:name ");
                OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                pName.Direction = ParameterDirection.Input;
                pName.Value = jc_icd10Param.Name;
                sqlparams.Add(pName);
            }

            if (null != jc_icd10Param.En_name && "" != jc_icd10Param.En_name)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.EN_NAME=:en_name ");
                OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                pEn_name.Direction = ParameterDirection.Input;
                pEn_name.Value = jc_icd10Param.En_name;
                sqlparams.Add(pEn_name);
            }

            if (null != jc_icd10Param.Pym && "" != jc_icd10Param.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_icd10Param.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_icd10Param.Wbm && "" != jc_icd10Param.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_icd10Param.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_icd10Param.Zfbz && "" != jc_icd10Param.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_icd10Param.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_icd10ParamLike != null)
            {

                if (null != jc_icd10ParamLike.Icd10_code && "" != jc_icd10ParamLike.Icd10_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ICD10_CODE LIKE '%'||:icd10_code||'%' ");
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = jc_icd10ParamLike.Icd10_code;
                    sqlparams.Add(pIcd10_code);
                }

                if (null != jc_icd10ParamLike.Name && "" != jc_icd10ParamLike.Name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NAME LIKE '%'||:name||'%' ");
                    OracleParameter pName = new OracleParameter(":name", OracleDbType.NVarchar2);
                    pName.Direction = ParameterDirection.Input;
                    pName.Value = jc_icd10ParamLike.Name;
                    sqlparams.Add(pName);
                }

                if (null != jc_icd10ParamLike.En_name && "" != jc_icd10ParamLike.En_name)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.EN_NAME LIKE '%'||:en_name||'%' ");
                    OracleParameter pEn_name = new OracleParameter(":en_name", OracleDbType.NVarchar2);
                    pEn_name.Direction = ParameterDirection.Input;
                    pEn_name.Value = jc_icd10ParamLike.En_name;
                    sqlparams.Add(pEn_name);
                }

                if (null != jc_icd10ParamLike.Pym && "" != jc_icd10ParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' OR A.ICD10_CODE LIKE '%'||:icd10_code||'%'");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_icd10ParamLike.Pym;
                    sqlparams.Add(pPym);
                    OracleParameter pIcd10_code = new OracleParameter(":icd10_code", OracleDbType.NVarchar2);
                    pIcd10_code.Direction = ParameterDirection.Input;
                    pIcd10_code.Value = jc_icd10ParamLike.Pym;
                    sqlparams.Add(pIcd10_code);
                }

                if (null != jc_icd10ParamLike.Wbm && "" != jc_icd10ParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_icd10ParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_icd10ParamLike.Zfbz && "" != jc_icd10ParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_icd10ParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_icd10>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_icd10>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_icd10ParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_icd10ParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_icd10ParamList);//把List<Jc_icd10>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

    }
}


