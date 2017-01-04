

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

namespace DAL.JC.基础_供应商
{
    /// <summary>
    ///数据库访问层的Jc_gys实现类
    ///此类由代码生成器生成
    ///表名：JC_GYS
    ///生成日期：2015/12/15 11:47:02
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_gysDALImp :Base.BasDAL,Jc_gysDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_gysParam">要插入的jc_gysParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_gys jc_gysParam,OracleConnection con)
        {
            if (""==jc_gysParam.Id||null==jc_gysParam.Id)
            {
                jc_gysParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_GYS(id,gysbh,gysmc,pym,wbm,lx_code,dz,lxr,dh,zfbz) VALUES(:id,:gysbh,:gysmc,:pym,:wbm,:lx_code,:dz,:lxr,:dh,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_gysParam.Id;
            sqlparams.Add(pId);
            OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
            pGysbh.Direction = ParameterDirection.Input;
            pGysbh.Value = jc_gysParam.Gysbh;
            sqlparams.Add(pGysbh);
            OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
            pGysmc.Direction = ParameterDirection.Input;
            pGysmc.Value = jc_gysParam.Gysmc;
            sqlparams.Add(pGysmc);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_gysParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_gysParam.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = jc_gysParam.Lx_code;
            sqlparams.Add(pLx_code);
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = jc_gysParam.Dz;
            sqlparams.Add(pDz);
            OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
            pLxr.Direction = ParameterDirection.Input;
            pLxr.Value = jc_gysParam.Lxr;
            sqlparams.Add(pLxr);
            OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
            pDh.Direction = ParameterDirection.Input;
            pDh.Value = jc_gysParam.Dh;
            sqlparams.Add(pDh);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_gysParam.Zfbz;
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
        /// <param name="jc_gysParamList">要插入的jc_gysParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_gys> jc_gysParamList, OracleConnection con)
        {
            if (jc_gysParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> gysbhList = new List<string>();

            List<string> gysmcList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> lx_codeList = new List<string>();

            List<string> dzList = new List<string>();

            List<string> lxrList = new List<string>();

            List<string> dhList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_gysParamList.Count; i++)
            {
                Jc_gys jc_gysParam = jc_gysParamList[i];
                if ("" == jc_gysParam.Id || null == jc_gysParam.Id)
                {
                    jc_gysParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_gysParam.Id);

            gysbhList.Add(jc_gysParam.Gysbh);

            gysmcList.Add(jc_gysParam.Gysmc);

            pymList.Add(jc_gysParam.Pym);

            wbmList.Add(jc_gysParam.Wbm);

            lx_codeList.Add(jc_gysParam.Lx_code);

            dzList.Add(jc_gysParam.Dz);

            lxrList.Add(jc_gysParam.Lxr);

            dhList.Add(jc_gysParam.Dh);

            zfbzList.Add(jc_gysParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_GYS(id,gysbh,gysmc,pym,wbm,lx_code,dz,lxr,dh,zfbz) VALUES(:id,:gysbh,:gysmc,:pym,:wbm,:lx_code,:dz,:lxr,:dh,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
            pGysbh.Direction = ParameterDirection.Input;
            pGysbh.Value = gysbhList.ToArray();
            sqlparams.Add(pGysbh);
            OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
            pGysmc.Direction = ParameterDirection.Input;
            pGysmc.Value = gysmcList.ToArray();
            sqlparams.Add(pGysmc);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = lx_codeList.ToArray();
            sqlparams.Add(pLx_code);
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = dzList.ToArray();
            sqlparams.Add(pDz);
            OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
            pLxr.Direction = ParameterDirection.Input;
            pLxr.Value = lxrList.ToArray();
            sqlparams.Add(pLxr);
            OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
            pDh.Direction = ParameterDirection.Input;
            pDh.Value = dhList.ToArray();
            sqlparams.Add(pDh);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_gysParamList.Count, sqlparams.ToArray());
            if (jc_gysParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_GYS WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_GYS WHERE ID=:id");
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
        /// <param name="jc_gysParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_gys jc_gysParamCondition, OracleConnection con)
        {
            if (null!=jc_gysParamCondition.Id&&""!=jc_gysParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_GYS ");

            if (null != jc_gysParamCondition.Gysbh &&  ""!= jc_gysParamCondition.Gysbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Direction = ParameterDirection.Input;
                pGysbh.Value = jc_gysParamCondition.Gysbh;
                sqlparams.Add(pGysbh);

            }
                        
            if (null != jc_gysParamCondition.Gysmc &&  ""!= jc_gysParamCondition.Gysmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Direction = ParameterDirection.Input;
                pGysmc.Value = jc_gysParamCondition.Gysmc;
                sqlparams.Add(pGysmc);

            }
                        
            if (null != jc_gysParamCondition.Pym &&  ""!= jc_gysParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_gysParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_gysParamCondition.Wbm &&  ""!= jc_gysParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_gysParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_gysParamCondition.Lx_code &&  ""!= jc_gysParamCondition.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = jc_gysParamCondition.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != jc_gysParamCondition.Dz &&  ""!= jc_gysParamCondition.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_gysParamCondition.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_gysParamCondition.Lxr &&  ""!= jc_gysParamCondition.Lxr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Direction = ParameterDirection.Input;
                pLxr.Value = jc_gysParamCondition.Lxr;
                sqlparams.Add(pLxr);

            }
                        
            if (null != jc_gysParamCondition.Dh &&  ""!= jc_gysParamCondition.Dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Direction = ParameterDirection.Input;
                pDh.Value = jc_gysParamCondition.Dh;
                sqlparams.Add(pDh);

            }
                        
            if (null != jc_gysParamCondition.Zfbz &&  ""!= jc_gysParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_gysParamCondition.Zfbz;
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
        /// <param name="jc_gysParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_gys jc_gysParam,OracleConnection con)
        {
            if ("" == jc_gysParam.Id || null == jc_gysParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_GYS SET ");
            if (null != jc_gysParam.Gysbh &&  ""!= jc_gysParam.Gysbh)
            {
                this.isComma(sql);
                sql.Append(" GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Direction = ParameterDirection.Input;
                pGysbh.Value = jc_gysParam.Gysbh;
                sqlparams.Add(pGysbh);

            }
                        
            if (null != jc_gysParam.Gysmc &&  ""!= jc_gysParam.Gysmc)
            {
                this.isComma(sql);
                sql.Append(" GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Direction = ParameterDirection.Input;
                pGysmc.Value = jc_gysParam.Gysmc;
                sqlparams.Add(pGysmc);

            }
                        
            if (null != jc_gysParam.Pym &&  ""!= jc_gysParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_gysParam.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_gysParam.Wbm &&  ""!= jc_gysParam.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_gysParam.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_gysParam.Lx_code &&  ""!= jc_gysParam.Lx_code)
            {
                this.isComma(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = jc_gysParam.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != jc_gysParam.Dz &&  ""!= jc_gysParam.Dz)
            {
                this.isComma(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_gysParam.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_gysParam.Lxr &&  ""!= jc_gysParam.Lxr)
            {
                this.isComma(sql);
                sql.Append(" LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Direction = ParameterDirection.Input;
                pLxr.Value = jc_gysParam.Lxr;
                sqlparams.Add(pLxr);

            }
                        
            if (null != jc_gysParam.Dh &&  ""!= jc_gysParam.Dh)
            {
                this.isComma(sql);
                sql.Append(" DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Direction = ParameterDirection.Input;
                pDh.Value = jc_gysParam.Dh;
                sqlparams.Add(pDh);

            }
                        
            if (null != jc_gysParam.Zfbz &&  ""!= jc_gysParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_gysParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_gysParam.Id;
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
        /// <param name="jc_gysParamList">要修改的Jc_gys对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_gys> jc_gysParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> gysbhList = new List<string>();

            List<string> gysmcList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> lx_codeList = new List<string>();

            List<string> dzList = new List<string>();

            List<string> lxrList = new List<string>();

            List<string> dhList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_gysParamList.Count; i++)
            {
                Jc_gys jc_gysParam = jc_gysParamList[i];
                if ("" == jc_gysParam.Id || null == jc_gysParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_gysParam.Id);

            gysbhList.Add(jc_gysParam.Gysbh);

            gysmcList.Add(jc_gysParam.Gysmc);

            pymList.Add(jc_gysParam.Pym);

            wbmList.Add(jc_gysParam.Wbm);

            lx_codeList.Add(jc_gysParam.Lx_code);

            dzList.Add(jc_gysParam.Dz);

            lxrList.Add(jc_gysParam.Lxr);

            dhList.Add(jc_gysParam.Dh);

            zfbzList.Add(jc_gysParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_GYS SET ");
            this.isComma(sql);
            sql.Append(" GYSBH=:gysbh ");
            OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
            pGysbh.Direction = ParameterDirection.Input;
            pGysbh.Value = gysbhList.ToArray();
            sqlparams.Add(pGysbh);

            this.isComma(sql);
            sql.Append(" GYSMC=:gysmc ");
            OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
            pGysmc.Direction = ParameterDirection.Input;
            pGysmc.Value = gysmcList.ToArray();
            sqlparams.Add(pGysmc);

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
            sql.Append(" LX_CODE=:lx_code ");
            OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
            pLx_code.Direction = ParameterDirection.Input;
            pLx_code.Value = lx_codeList.ToArray();
            sqlparams.Add(pLx_code);

            this.isComma(sql);
            sql.Append(" DZ=:dz ");
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = dzList.ToArray();
            sqlparams.Add(pDz);

            this.isComma(sql);
            sql.Append(" LXR=:lxr ");
            OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
            pLxr.Direction = ParameterDirection.Input;
            pLxr.Value = lxrList.ToArray();
            sqlparams.Add(pLxr);

            this.isComma(sql);
            sql.Append(" DH=:dh ");
            OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
            pDh.Direction = ParameterDirection.Input;
            pDh.Value = dhList.ToArray();
            sqlparams.Add(pDh);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_gysParamList.Count, sqlparams.ToArray());
            if (jc_gysParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_gysParamCondition">条件对象</param>
        /// <param name="jc_gysParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_gys jc_gysParamCondition, Jc_gys jc_gysParamUpdate, OracleConnection con)
        {
            if ((null!=jc_gysParamCondition.Id&&"!=jc_gysParamCondition.Id)||(null!=jc_gysParamUpdate.Id&&"!=jc_gysParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_GYS SET ");
            if (null != jc_gysParamUpdate.Gysbh &&  ""!= jc_gysParamUpdate.Gysbh)
            {
                this.isComma(sql);
                sql.Append(" GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Direction = ParameterDirection.Input;
                pGysbh.Value = jc_gysParamUpdate.Gysbh;
                sqlparams.Add(pGysbh);

            }
                        
            if (null != jc_gysParamUpdate.Gysmc &&  ""!= jc_gysParamUpdate.Gysmc)
            {
                this.isComma(sql);
                sql.Append(" GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Direction = ParameterDirection.Input;
                pGysmc.Value = jc_gysParamUpdate.Gysmc;
                sqlparams.Add(pGysmc);

            }
                        
            if (null != jc_gysParamUpdate.Pym &&  ""!= jc_gysParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_gysParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_gysParamUpdate.Wbm &&  ""!= jc_gysParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_gysParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_gysParamUpdate.Lx_code &&  ""!= jc_gysParamUpdate.Lx_code)
            {
                this.isComma(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = jc_gysParamUpdate.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != jc_gysParamUpdate.Dz &&  ""!= jc_gysParamUpdate.Dz)
            {
                this.isComma(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_gysParamUpdate.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_gysParamUpdate.Lxr &&  ""!= jc_gysParamUpdate.Lxr)
            {
                this.isComma(sql);
                sql.Append(" LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Direction = ParameterDirection.Input;
                pLxr.Value = jc_gysParamUpdate.Lxr;
                sqlparams.Add(pLxr);

            }
                        
            if (null != jc_gysParamUpdate.Dh &&  ""!= jc_gysParamUpdate.Dh)
            {
                this.isComma(sql);
                sql.Append(" DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Direction = ParameterDirection.Input;
                pDh.Value = jc_gysParamUpdate.Dh;
                sqlparams.Add(pDh);

            }
                        
            if (null != jc_gysParamUpdate.Zfbz &&  ""!= jc_gysParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_gysParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_gysParamCondition.Gysbh &&  ""!= jc_gysParamCondition.Gysbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Direction = ParameterDirection.Input;
                pGysbh.Value = jc_gysParamCondition.Gysbh;
                sqlparams.Add(pGysbh);

            }
                        
            if (null != jc_gysParamCondition.Gysmc &&  ""!= jc_gysParamCondition.Gysmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Direction = ParameterDirection.Input;
                pGysmc.Value = jc_gysParamCondition.Gysmc;
                sqlparams.Add(pGysmc);

            }
                        
            if (null != jc_gysParamCondition.Pym &&  ""!= jc_gysParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_gysParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_gysParamCondition.Wbm &&  ""!= jc_gysParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_gysParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_gysParamCondition.Lx_code &&  ""!= jc_gysParamCondition.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = jc_gysParamCondition.Lx_code;
                sqlparams.Add(pLx_code);

            }
                        
            if (null != jc_gysParamCondition.Dz &&  ""!= jc_gysParamCondition.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_gysParamCondition.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_gysParamCondition.Lxr &&  ""!= jc_gysParamCondition.Lxr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Direction = ParameterDirection.Input;
                pLxr.Value = jc_gysParamCondition.Lxr;
                sqlparams.Add(pLxr);

            }
                        
            if (null != jc_gysParamCondition.Dh &&  ""!= jc_gysParamCondition.Dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Direction = ParameterDirection.Input;
                pDh.Value = jc_gysParamCondition.Dh;
                sqlparams.Add(pDh);

            }
                        
            if (null != jc_gysParamCondition.Zfbz &&  ""!= jc_gysParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_gysParamCondition.Zfbz;
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
        /// <returns>Jc_gys</returns>
        public Jc_gys findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_GYS A ");
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
        /// <param name="jc_gysParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_gysParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_gys对象集合list</returns>
        public List<object> find(Jc_gys jc_gysParam, Model.Common.PageInfo page,Jc_gys jc_gysParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_gys对象，标示查询所有数据
            if (null == jc_gysParam)
            {
                jc_gysParam = new Jc_gys();
            }
            if (null!=jc_gysParam.Id&&""!=jc_gysParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_gys> jc_gysParamList = new List<Jc_gys>();//接收查询出的Jc_gys对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_gys jc_gysParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_GYS A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_gysParam.Gysbh && "" != jc_gysParam.Gysbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Direction = ParameterDirection.Input;
                pGysbh.Value = jc_gysParam.Gysbh;
                sqlparams.Add(pGysbh);
            }
                
            if (null != jc_gysParam.Gysmc && "" != jc_gysParam.Gysmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Direction = ParameterDirection.Input;
                pGysmc.Value = jc_gysParam.Gysmc;
                sqlparams.Add(pGysmc);
            }
                
            if (null != jc_gysParam.Pym && "" != jc_gysParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_gysParam.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != jc_gysParam.Wbm && "" != jc_gysParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_gysParam.Wbm;
                sqlparams.Add(pWbm);
            }
                
            if (null != jc_gysParam.Lx_code && "" != jc_gysParam.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Direction = ParameterDirection.Input;
                pLx_code.Value = jc_gysParam.Lx_code;
                sqlparams.Add(pLx_code);
            }
                
            if (null != jc_gysParam.Dz && "" != jc_gysParam.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_gysParam.Dz;
                sqlparams.Add(pDz);
            }
                
            if (null != jc_gysParam.Lxr && "" != jc_gysParam.Lxr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Direction = ParameterDirection.Input;
                pLxr.Value = jc_gysParam.Lxr;
                sqlparams.Add(pLxr);
            }
                
            if (null != jc_gysParam.Dh && "" != jc_gysParam.Dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Direction = ParameterDirection.Input;
                pDh.Value = jc_gysParam.Dh;
                sqlparams.Add(pDh);
            }
                
            if (null != jc_gysParam.Zfbz && "" != jc_gysParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_gysParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_gysParamLike!=null)
            {

                if (null != jc_gysParamLike.Gysbh && "" != jc_gysParamLike.Gysbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSBH LIKE '%'||:gysbh||'%' ");
                    OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                    pGysbh.Direction = ParameterDirection.Input;
                    pGysbh.Value = jc_gysParamLike.Gysbh;
                    sqlparams.Add(pGysbh);
                }
                
                if (null != jc_gysParamLike.Gysmc && "" != jc_gysParamLike.Gysmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSMC LIKE '%'||:gysmc||'%' ");
                    OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                    pGysmc.Direction = ParameterDirection.Input;
                    pGysmc.Value = jc_gysParamLike.Gysmc;
                    sqlparams.Add(pGysmc);
                }
                
                if (null != jc_gysParamLike.Pym && "" != jc_gysParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_gysParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_gysParamLike.Wbm && "" != jc_gysParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_gysParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_gysParamLike.Lx_code && "" != jc_gysParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = jc_gysParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }
                
                if (null != jc_gysParamLike.Dz && "" != jc_gysParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_gysParamLike.Dz;
                    sqlparams.Add(pDz);
                }
                
                if (null != jc_gysParamLike.Lxr && "" != jc_gysParamLike.Lxr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXR LIKE '%'||:lxr||'%' ");
                    OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                    pLxr.Direction = ParameterDirection.Input;
                    pLxr.Value = jc_gysParamLike.Lxr;
                    sqlparams.Add(pLxr);
                }
                
                if (null != jc_gysParamLike.Dh && "" != jc_gysParamLike.Dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DH LIKE '%'||:dh||'%' ");
                    OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                    pDh.Direction = ParameterDirection.Input;
                    pDh.Value = jc_gysParamLike.Dh;
                    sqlparams.Add(pDh);
                }
                
                if (null != jc_gysParamLike.Zfbz && "" != jc_gysParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_gysParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_gys>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_gys>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_gysParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_gysParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_gysParamList);//把List<Jc_gys>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_gys jc_gysParam,Jc_gys jc_gysParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_gys对象，标示查询所有数据
            if (null == jc_gysParam)
            {
                jc_gysParam = new Jc_gys();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_GYS A");
                if (null != jc_gysParam.Gysbh && "" != jc_gysParam.Gysbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSBH=:gysbh ");
                    OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Value = jc_gysParam.Gysbh;
                sqlparams.Add(pGysbh);
                }
                
                if (null != jc_gysParam.Gysmc && "" != jc_gysParam.Gysmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSMC=:gysmc ");
                    OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Value = jc_gysParam.Gysmc;
                sqlparams.Add(pGysmc);
                }
                
                if (null != jc_gysParam.Pym && "" != jc_gysParam.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_gysParam.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != jc_gysParam.Wbm && "" != jc_gysParam.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_gysParam.Wbm;
                sqlparams.Add(pWbm);
                }
                
                if (null != jc_gysParam.Lx_code && "" != jc_gysParam.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE=:lx_code ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Value = jc_gysParam.Lx_code;
                sqlparams.Add(pLx_code);
                }
                
                if (null != jc_gysParam.Dz && "" != jc_gysParam.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ=:dz ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Value = jc_gysParam.Dz;
                sqlparams.Add(pDz);
                }
                
                if (null != jc_gysParam.Lxr && "" != jc_gysParam.Lxr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXR=:lxr ");
                    OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Value = jc_gysParam.Lxr;
                sqlparams.Add(pLxr);
                }
                
                if (null != jc_gysParam.Dh && "" != jc_gysParam.Dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DH=:dh ");
                    OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Value = jc_gysParam.Dh;
                sqlparams.Add(pDh);
                }
                
                if (null != jc_gysParam.Zfbz && "" != jc_gysParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_gysParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_gysParamLike!=null)
            {

                if (null != jc_gysParamLike.Gysbh && "" != jc_gysParamLike.Gysbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSBH LIKE '%'||:gysbh||'%' ");
                    OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                    pGysbh.Direction = ParameterDirection.Input;
                    pGysbh.Value = jc_gysParamLike.Gysbh;
                    sqlparams.Add(pGysbh);
                }
                
                if (null != jc_gysParamLike.Gysmc && "" != jc_gysParamLike.Gysmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSMC LIKE '%'||:gysmc||'%' ");
                    OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                    pGysmc.Direction = ParameterDirection.Input;
                    pGysmc.Value = jc_gysParamLike.Gysmc;
                    sqlparams.Add(pGysmc);
                }
                
                if (null != jc_gysParamLike.Pym && "" != jc_gysParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_gysParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_gysParamLike.Wbm && "" != jc_gysParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_gysParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_gysParamLike.Lx_code && "" != jc_gysParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = jc_gysParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }
                
                if (null != jc_gysParamLike.Dz && "" != jc_gysParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_gysParamLike.Dz;
                    sqlparams.Add(pDz);
                }
                
                if (null != jc_gysParamLike.Lxr && "" != jc_gysParamLike.Lxr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXR LIKE '%'||:lxr||'%' ");
                    OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                    pLxr.Direction = ParameterDirection.Input;
                    pLxr.Value = jc_gysParamLike.Lxr;
                    sqlparams.Add(pLxr);
                }
                
                if (null != jc_gysParamLike.Dh && "" != jc_gysParamLike.Dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DH LIKE '%'||:dh||'%' ");
                    OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                    pDh.Direction = ParameterDirection.Input;
                    pDh.Value = jc_gysParamLike.Dh;
                    sqlparams.Add(pDh);
                }
                
                if (null != jc_gysParamLike.Zfbz && "" != jc_gysParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_gysParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_gysParam"></param>
        /// <returns></returns>
        public bool save(Jc_gys jc_gysParam,OracleConnection con)
        {
            if ("" != jc_gysParam.Id && null != jc_gysParam.Id)
            {
                //修改
                return this.updateById(jc_gysParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_gysParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_gys dataSetToModel(DataRow row)
        {
            Jc_gys jc_gysParam = new Jc_gys();
            jc_gysParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_gysParam.Gysbh = Convert.ToString(row["GYSBH"]).Trim(); 
            jc_gysParam.Gysmc = Convert.ToString(row["GYSMC"]).Trim(); 
            jc_gysParam.Pym = Convert.ToString(row["PYM"]).Trim(); 
            jc_gysParam.Wbm = Convert.ToString(row["WBM"]).Trim(); 
            jc_gysParam.Lx_code = Convert.ToString(row["LX_CODE"]).Trim(); 
            jc_gysParam.Dz = Convert.ToString(row["DZ"]).Trim(); 
            jc_gysParam.Lxr = Convert.ToString(row["LXR"]).Trim(); 
            jc_gysParam.Dh = Convert.ToString(row["DH"]).Trim(); 
            jc_gysParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_gysParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_gys dataSetContactObjectsToModel(DataRow row)
        {
            Jc_gys jc_gysParam = this.dataSetToModel(row);

            //添加代码类别实体对象,类型（关联代码表）对象
            Jc_code lxCode = new Jc_code();
            lxCode.Id = Convert.ToString(row["LX_CODE_ID"]).Trim();
            lxCode.Name = Convert.ToString(row["LX_CODE_NAME"]).Trim();
            lxCode.Value = Convert.ToString(row["LX_CODE_VALUE"]).Trim();
            lxCode.Fk_code_type = Convert.ToString(row["LX_CODE_FKCODETYPE"]).Trim();
            lxCode.Zfbz = Convert.ToString(row["LX_CODE_ZFBZ"]).Trim();
            lxCode.Remark = Convert.ToString(row["LX_CODE_REMARK"]).Trim();
            jc_gysParam.LxCode = lxCode;

            return jc_gysParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_gys</returns>
        public Jc_gys findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LX_CODE.ID AS LX_CODE_ID,TT_LX_CODE.NAME AS LX_CODE_NAME,TT_LX_CODE.VALUE AS LX_CODE_VALUE,TT_LX_CODE.FK_CODE_TYPE AS LX_CODE_FKCODETYPE,TT_LX_CODE.ZFBZ AS LX_CODE_ZFBZ,TT_LX_CODE.REMARK AS LX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_GYS A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.供应商类型 + @"')) TT_LX_CODE
                        ON A.LX_CODE = TT_LX_CODE.VALUE
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
        /// <param name="jc_gysParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_gysParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_gys对象集合list</returns>
        public List<object> findContactObjects(Jc_gys jc_gysParam, Model.Common.PageInfo page, Jc_gys jc_gysParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_gys对象，标示查询所有数据
            if (null == jc_gysParam)
            {
                jc_gysParam = new Jc_gys();
            }
            if (null != jc_gysParam.Id && "" != jc_gysParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_gys> jc_gysParamList = new List<Jc_gys>();//接收查询出的Jc_gys对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_gys jc_gysParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_LX_CODE.ID AS LX_CODE_ID,TT_LX_CODE.NAME AS LX_CODE_NAME,TT_LX_CODE.VALUE AS LX_CODE_VALUE,TT_LX_CODE.FK_CODE_TYPE AS LX_CODE_FKCODETYPE,TT_LX_CODE.ZFBZ AS LX_CODE_ZFBZ,TT_LX_CODE.REMARK AS LX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_GYS A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.供应商类型 + @"')) TT_LX_CODE
                        ON A.LX_CODE = TT_LX_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_gysParam.Gysbh && "" != jc_gysParam.Gysbh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYSBH=:gysbh ");
                OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                pGysbh.Value = jc_gysParam.Gysbh;
                sqlparams.Add(pGysbh);
            }

            if (null != jc_gysParam.Gysmc && "" != jc_gysParam.Gysmc)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GYSMC=:gysmc ");
                OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                pGysmc.Value = jc_gysParam.Gysmc;
                sqlparams.Add(pGysmc);
            }

            if (null != jc_gysParam.Pym && "" != jc_gysParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_gysParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_gysParam.Wbm && "" != jc_gysParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_gysParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_gysParam.Lx_code && "" != jc_gysParam.Lx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LX_CODE=:lx_code ");
                OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                pLx_code.Value = jc_gysParam.Lx_code;
                sqlparams.Add(pLx_code);
            }

            if (null != jc_gysParam.Dz && "" != jc_gysParam.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Value = jc_gysParam.Dz;
                sqlparams.Add(pDz);
            }

            if (null != jc_gysParam.Lxr && "" != jc_gysParam.Lxr)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXR=:lxr ");
                OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                pLxr.Value = jc_gysParam.Lxr;
                sqlparams.Add(pLxr);
            }

            if (null != jc_gysParam.Dh && "" != jc_gysParam.Dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DH=:dh ");
                OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                pDh.Value = jc_gysParam.Dh;
                sqlparams.Add(pDh);
            }

            if (null != jc_gysParam.Zfbz && "" != jc_gysParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_gysParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_gysParamLike != null)
            {

                if (null != jc_gysParamLike.Gysbh && "" != jc_gysParamLike.Gysbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSBH LIKE '%'||:gysbh||'%' ");
                    OracleParameter pGysbh = new OracleParameter(":gysbh", OracleDbType.NVarchar2);
                    pGysbh.Direction = ParameterDirection.Input;
                    pGysbh.Value = jc_gysParamLike.Gysbh;
                    sqlparams.Add(pGysbh);
                }

                if (null != jc_gysParamLike.Gysmc && "" != jc_gysParamLike.Gysmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GYSMC LIKE '%'||:gysmc||'%' ");
                    OracleParameter pGysmc = new OracleParameter(":gysmc", OracleDbType.NVarchar2);
                    pGysmc.Direction = ParameterDirection.Input;
                    pGysmc.Value = jc_gysParamLike.Gysmc;
                    sqlparams.Add(pGysmc);
                }

                if (null != jc_gysParamLike.Pym && "" != jc_gysParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_gysParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_gysParamLike.Wbm && "" != jc_gysParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_gysParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_gysParamLike.Lx_code && "" != jc_gysParamLike.Lx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LX_CODE LIKE '%'||:lx_code||'%' ");
                    OracleParameter pLx_code = new OracleParameter(":lx_code", OracleDbType.NVarchar2);
                    pLx_code.Direction = ParameterDirection.Input;
                    pLx_code.Value = jc_gysParamLike.Lx_code;
                    sqlparams.Add(pLx_code);
                }

                if (null != jc_gysParamLike.Dz && "" != jc_gysParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_gysParamLike.Dz;
                    sqlparams.Add(pDz);
                }

                if (null != jc_gysParamLike.Lxr && "" != jc_gysParamLike.Lxr)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXR LIKE '%'||:lxr||'%' ");
                    OracleParameter pLxr = new OracleParameter(":lxr", OracleDbType.NVarchar2);
                    pLxr.Direction = ParameterDirection.Input;
                    pLxr.Value = jc_gysParamLike.Lxr;
                    sqlparams.Add(pLxr);
                }

                if (null != jc_gysParamLike.Dh && "" != jc_gysParamLike.Dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DH LIKE '%'||:dh||'%' ");
                    OracleParameter pDh = new OracleParameter(":dh", OracleDbType.NVarchar2);
                    pDh.Direction = ParameterDirection.Input;
                    pDh.Value = jc_gysParamLike.Dh;
                    sqlparams.Add(pDh);
                }

                if (null != jc_gysParamLike.Zfbz && "" != jc_gysParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_gysParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_gys>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_gys>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_gysParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_gysParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_gysParamList);//把List<Jc_gys>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end


        //*******************在此以后添加新的方法end
        
    }
}


