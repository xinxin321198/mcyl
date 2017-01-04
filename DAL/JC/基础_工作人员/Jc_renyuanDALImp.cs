

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

namespace DAL.JC.基础_工作人员
{
    /// <summary>
    ///数据库访问层的Jc_renyuan实现类
    ///此类由代码生成器生成
    ///表名：JC_RENYUAN
    ///生成日期：2015-12-02 15:43:29
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_renyuanDALImp :Base.BasDAL,Jc_renyuanDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_renyuanParam">要插入的jc_renyuanParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_renyuan jc_renyuanParam,OracleConnection con)
        {
            if (""==jc_renyuanParam.Id||null==jc_renyuanParam.Id)
            {
                jc_renyuanParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_RENYUAN(id,xm,xb_code,mz_code,csrq,sfzh,zzmm_code,hyzk_code,byxx,xl_code,cjgzsj,zy,jg,dz,lxdh,qq,yx,bz,pym,wbm,rylx_code,zfbz) VALUES(:id,:xm,:xb_code,:mz_code,:csrq,:sfzh,:zzmm_code,:hyzk_code,:byxx,:xl_code,:cjgzsj,:zy,:jg,:dz,:lxdh,:qq,:yx,:bz,:pym,:wbm,:rylx_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_renyuanParam.Id;
            sqlparams.Add(pId);
            OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
            pXm.Direction = ParameterDirection.Input;
            pXm.Value = jc_renyuanParam.Xm;
            sqlparams.Add(pXm);
            OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
            pXb_code.Direction = ParameterDirection.Input;
            pXb_code.Value = jc_renyuanParam.Xb_code;
            sqlparams.Add(pXb_code);
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = jc_renyuanParam.Mz_code;
            sqlparams.Add(pMz_code);
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = jc_renyuanParam.Csrq;
            sqlparams.Add(pCsrq);
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = jc_renyuanParam.Sfzh;
            sqlparams.Add(pSfzh);
            OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
            pZzmm_code.Direction = ParameterDirection.Input;
            pZzmm_code.Value = jc_renyuanParam.Zzmm_code;
            sqlparams.Add(pZzmm_code);
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = jc_renyuanParam.Hyzk_code;
            sqlparams.Add(pHyzk_code);
            OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
            pByxx.Direction = ParameterDirection.Input;
            pByxx.Value = jc_renyuanParam.Byxx;
            sqlparams.Add(pByxx);
            OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
            pXl_code.Direction = ParameterDirection.Input;
            pXl_code.Value = jc_renyuanParam.Xl_code;
            sqlparams.Add(pXl_code);
            OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
            pCjgzsj.Direction = ParameterDirection.Input;
            pCjgzsj.Value = jc_renyuanParam.Cjgzsj;
            sqlparams.Add(pCjgzsj);
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = jc_renyuanParam.Zy;
            sqlparams.Add(pZy);
            OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
            pJg.Direction = ParameterDirection.Input;
            pJg.Value = jc_renyuanParam.Jg;
            sqlparams.Add(pJg);
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = jc_renyuanParam.Dz;
            sqlparams.Add(pDz);
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = jc_renyuanParam.Lxdh;
            sqlparams.Add(pLxdh);
            OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
            pQq.Direction = ParameterDirection.Input;
            pQq.Value = jc_renyuanParam.Qq;
            sqlparams.Add(pQq);
            OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
            pYx.Direction = ParameterDirection.Input;
            pYx.Value = jc_renyuanParam.Yx;
            sqlparams.Add(pYx);
            OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
            pBz.Direction = ParameterDirection.Input;
            pBz.Value = jc_renyuanParam.Bz;
            sqlparams.Add(pBz);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_renyuanParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_renyuanParam.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
            pRylx_code.Direction = ParameterDirection.Input;
            pRylx_code.Value = jc_renyuanParam.Rylx_code;
            sqlparams.Add(pRylx_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_renyuanParam.Zfbz;
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
        /// <param name="jc_renyuanParamList">要插入的jc_renyuanParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_renyuan> jc_renyuanParamList, OracleConnection con)
        {
            if (jc_renyuanParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> xmList = new List<string>();

            List<string> xb_codeList = new List<string>();

            List<string> mz_codeList = new List<string>();

            List<DateTime?> csrqList = new List<DateTime?>();

            List<string> sfzhList = new List<string>();

            List<string> zzmm_codeList = new List<string>();

            List<string> hyzk_codeList = new List<string>();

            List<string> byxxList = new List<string>();

            List<string> xl_codeList = new List<string>();

            List<DateTime?> cjgzsjList = new List<DateTime?>();

            List<string> zyList = new List<string>();

            List<string> jgList = new List<string>();

            List<string> dzList = new List<string>();

            List<string> lxdhList = new List<string>();

            List<string> qqList = new List<string>();

            List<string> yxList = new List<string>();

            List<string> bzList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> rylx_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_renyuanParamList.Count; i++)
            {
                Jc_renyuan jc_renyuanParam = jc_renyuanParamList[i];
                if ("" == jc_renyuanParam.Id || null == jc_renyuanParam.Id)
                {
                    jc_renyuanParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_renyuanParam.Id);

            xmList.Add(jc_renyuanParam.Xm);

            xb_codeList.Add(jc_renyuanParam.Xb_code);

            mz_codeList.Add(jc_renyuanParam.Mz_code);

            csrqList.Add(jc_renyuanParam.Csrq);

            sfzhList.Add(jc_renyuanParam.Sfzh);

            zzmm_codeList.Add(jc_renyuanParam.Zzmm_code);

            hyzk_codeList.Add(jc_renyuanParam.Hyzk_code);

            byxxList.Add(jc_renyuanParam.Byxx);

            xl_codeList.Add(jc_renyuanParam.Xl_code);

            cjgzsjList.Add(jc_renyuanParam.Cjgzsj);

            zyList.Add(jc_renyuanParam.Zy);

            jgList.Add(jc_renyuanParam.Jg);

            dzList.Add(jc_renyuanParam.Dz);

            lxdhList.Add(jc_renyuanParam.Lxdh);

            qqList.Add(jc_renyuanParam.Qq);

            yxList.Add(jc_renyuanParam.Yx);

            bzList.Add(jc_renyuanParam.Bz);

            pymList.Add(jc_renyuanParam.Pym);

            wbmList.Add(jc_renyuanParam.Wbm);

            rylx_codeList.Add(jc_renyuanParam.Rylx_code);

            zfbzList.Add(jc_renyuanParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_RENYUAN(id,xm,xb_code,mz_code,csrq,sfzh,zzmm_code,hyzk_code,byxx,xl_code,cjgzsj,zy,jg,dz,lxdh,qq,yx,bz,pym,wbm,rylx_code,zfbz) VALUES(:id,:xm,:xb_code,:mz_code,:csrq,:sfzh,:zzmm_code,:hyzk_code,:byxx,:xl_code,:cjgzsj,:zy,:jg,:dz,:lxdh,:qq,:yx,:bz,:pym,:wbm,:rylx_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
            pXm.Direction = ParameterDirection.Input;
            pXm.Value = xmList.ToArray();
            sqlparams.Add(pXm);
            OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
            pXb_code.Direction = ParameterDirection.Input;
            pXb_code.Value = xb_codeList.ToArray();
            sqlparams.Add(pXb_code);
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = mz_codeList.ToArray();
            sqlparams.Add(pMz_code);
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = csrqList.ToArray();
            sqlparams.Add(pCsrq);
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = sfzhList.ToArray();
            sqlparams.Add(pSfzh);
            OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
            pZzmm_code.Direction = ParameterDirection.Input;
            pZzmm_code.Value = zzmm_codeList.ToArray();
            sqlparams.Add(pZzmm_code);
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = hyzk_codeList.ToArray();
            sqlparams.Add(pHyzk_code);
            OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
            pByxx.Direction = ParameterDirection.Input;
            pByxx.Value = byxxList.ToArray();
            sqlparams.Add(pByxx);
            OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
            pXl_code.Direction = ParameterDirection.Input;
            pXl_code.Value = xl_codeList.ToArray();
            sqlparams.Add(pXl_code);
            OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
            pCjgzsj.Direction = ParameterDirection.Input;
            pCjgzsj.Value = cjgzsjList.ToArray();
            sqlparams.Add(pCjgzsj);
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = zyList.ToArray();
            sqlparams.Add(pZy);
            OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
            pJg.Direction = ParameterDirection.Input;
            pJg.Value = jgList.ToArray();
            sqlparams.Add(pJg);
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = dzList.ToArray();
            sqlparams.Add(pDz);
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = lxdhList.ToArray();
            sqlparams.Add(pLxdh);
            OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
            pQq.Direction = ParameterDirection.Input;
            pQq.Value = qqList.ToArray();
            sqlparams.Add(pQq);
            OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
            pYx.Direction = ParameterDirection.Input;
            pYx.Value = yxList.ToArray();
            sqlparams.Add(pYx);
            OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
            pBz.Direction = ParameterDirection.Input;
            pBz.Value = bzList.ToArray();
            sqlparams.Add(pBz);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = pymList.ToArray();
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = wbmList.ToArray();
            sqlparams.Add(pWbm);
            OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
            pRylx_code.Direction = ParameterDirection.Input;
            pRylx_code.Value = rylx_codeList.ToArray();
            sqlparams.Add(pRylx_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_renyuanParamList.Count, sqlparams.ToArray());
            if (jc_renyuanParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN WHERE ID=:id");
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
        /// <param name="jc_renyuanParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_renyuan jc_renyuanParamCondition, OracleConnection con)
        {
            if (null!=jc_renyuanParamCondition.Id&&""!=jc_renyuanParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_RENYUAN ");

            if (null != jc_renyuanParamCondition.Xm &&  ""!= jc_renyuanParamCondition.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_renyuanParamCondition.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_renyuanParamCondition.Xb_code &&  ""!= jc_renyuanParamCondition.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_renyuanParamCondition.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (null != jc_renyuanParamCondition.Mz_code &&  ""!= jc_renyuanParamCondition.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_renyuanParamCondition.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamCondition.Csrq &&null != jc_renyuanParamCondition.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_renyuanParamCondition.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_renyuanParamCondition.Sfzh &&  ""!= jc_renyuanParamCondition.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_renyuanParamCondition.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_renyuanParamCondition.Zzmm_code &&  ""!= jc_renyuanParamCondition.Zzmm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Direction = ParameterDirection.Input;
                pZzmm_code.Value = jc_renyuanParamCondition.Zzmm_code;
                sqlparams.Add(pZzmm_code);

            }
                        
            if (null != jc_renyuanParamCondition.Hyzk_code &&  ""!= jc_renyuanParamCondition.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_renyuanParamCondition.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_renyuanParamCondition.Byxx &&  ""!= jc_renyuanParamCondition.Byxx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Direction = ParameterDirection.Input;
                pByxx.Value = jc_renyuanParamCondition.Byxx;
                sqlparams.Add(pByxx);

            }
                        
            if (null != jc_renyuanParamCondition.Xl_code &&  ""!= jc_renyuanParamCondition.Xl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Direction = ParameterDirection.Input;
                pXl_code.Value = jc_renyuanParamCondition.Xl_code;
                sqlparams.Add(pXl_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamCondition.Cjgzsj &&null != jc_renyuanParamCondition.Cjgzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJGZSJ=:cjgzsj ");
                OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Direction = ParameterDirection.Input;
                pCjgzsj.Value = jc_renyuanParamCondition.Cjgzsj;
                sqlparams.Add(pCjgzsj);

            }
                        
            if (null != jc_renyuanParamCondition.Zy &&  ""!= jc_renyuanParamCondition.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_renyuanParamCondition.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_renyuanParamCondition.Jg &&  ""!= jc_renyuanParamCondition.Jg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Direction = ParameterDirection.Input;
                pJg.Value = jc_renyuanParamCondition.Jg;
                sqlparams.Add(pJg);

            }
                        
            if (null != jc_renyuanParamCondition.Dz &&  ""!= jc_renyuanParamCondition.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_renyuanParamCondition.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_renyuanParamCondition.Lxdh &&  ""!= jc_renyuanParamCondition.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_renyuanParamCondition.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_renyuanParamCondition.Qq &&  ""!= jc_renyuanParamCondition.Qq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Direction = ParameterDirection.Input;
                pQq.Value = jc_renyuanParamCondition.Qq;
                sqlparams.Add(pQq);

            }
                        
            if (null != jc_renyuanParamCondition.Yx &&  ""!= jc_renyuanParamCondition.Yx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Direction = ParameterDirection.Input;
                pYx.Value = jc_renyuanParamCondition.Yx;
                sqlparams.Add(pYx);

            }
                        
            if (null != jc_renyuanParamCondition.Bz &&  ""!= jc_renyuanParamCondition.Bz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Direction = ParameterDirection.Input;
                pBz.Value = jc_renyuanParamCondition.Bz;
                sqlparams.Add(pBz);

            }
                        
            if (null != jc_renyuanParamCondition.Pym &&  ""!= jc_renyuanParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_renyuanParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_renyuanParamCondition.Wbm &&  ""!= jc_renyuanParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_renyuanParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_renyuanParamCondition.Rylx_code &&  ""!= jc_renyuanParamCondition.Rylx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Direction = ParameterDirection.Input;
                pRylx_code.Value = jc_renyuanParamCondition.Rylx_code;
                sqlparams.Add(pRylx_code);

            }
                        
            if (null != jc_renyuanParamCondition.Zfbz &&  ""!= jc_renyuanParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuanParamCondition.Zfbz;
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
        /// <param name="jc_renyuanParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_renyuan jc_renyuanParam,OracleConnection con)
        {
            if ("" == jc_renyuanParam.Id || null == jc_renyuanParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN SET ");
            if (null != jc_renyuanParam.Xm &&  ""!= jc_renyuanParam.Xm)
            {
                this.isComma(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_renyuanParam.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_renyuanParam.Xb_code &&  ""!= jc_renyuanParam.Xb_code)
            {
                this.isComma(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_renyuanParam.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (null != jc_renyuanParam.Mz_code &&  ""!= jc_renyuanParam.Mz_code)
            {
                this.isComma(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_renyuanParam.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParam.Csrq &&null != jc_renyuanParam.Csrq)
            {
                this.isComma(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_renyuanParam.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_renyuanParam.Sfzh &&  ""!= jc_renyuanParam.Sfzh)
            {
                this.isComma(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_renyuanParam.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_renyuanParam.Zzmm_code &&  ""!= jc_renyuanParam.Zzmm_code)
            {
                this.isComma(sql);
                sql.Append(" ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Direction = ParameterDirection.Input;
                pZzmm_code.Value = jc_renyuanParam.Zzmm_code;
                sqlparams.Add(pZzmm_code);

            }
                        
            if (null != jc_renyuanParam.Hyzk_code &&  ""!= jc_renyuanParam.Hyzk_code)
            {
                this.isComma(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_renyuanParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_renyuanParam.Byxx &&  ""!= jc_renyuanParam.Byxx)
            {
                this.isComma(sql);
                sql.Append(" BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Direction = ParameterDirection.Input;
                pByxx.Value = jc_renyuanParam.Byxx;
                sqlparams.Add(pByxx);

            }
                        
            if (null != jc_renyuanParam.Xl_code &&  ""!= jc_renyuanParam.Xl_code)
            {
                this.isComma(sql);
                sql.Append(" XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Direction = ParameterDirection.Input;
                pXl_code.Value = jc_renyuanParam.Xl_code;
                sqlparams.Add(pXl_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParam.Cjgzsj &&null != jc_renyuanParam.Cjgzsj)
            {
                this.isComma(sql);
                sql.Append(" CJGZSJ=:cjgzsj ");
                OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Direction = ParameterDirection.Input;
                pCjgzsj.Value = jc_renyuanParam.Cjgzsj;
                sqlparams.Add(pCjgzsj);

            }
                        
            if (null != jc_renyuanParam.Zy &&  ""!= jc_renyuanParam.Zy)
            {
                this.isComma(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_renyuanParam.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_renyuanParam.Jg &&  ""!= jc_renyuanParam.Jg)
            {
                this.isComma(sql);
                sql.Append(" JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Direction = ParameterDirection.Input;
                pJg.Value = jc_renyuanParam.Jg;
                sqlparams.Add(pJg);

            }
                        
            if (null != jc_renyuanParam.Dz &&  ""!= jc_renyuanParam.Dz)
            {
                this.isComma(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_renyuanParam.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_renyuanParam.Lxdh &&  ""!= jc_renyuanParam.Lxdh)
            {
                this.isComma(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_renyuanParam.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_renyuanParam.Qq &&  ""!= jc_renyuanParam.Qq)
            {
                this.isComma(sql);
                sql.Append(" QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Direction = ParameterDirection.Input;
                pQq.Value = jc_renyuanParam.Qq;
                sqlparams.Add(pQq);

            }
                        
            if (null != jc_renyuanParam.Yx &&  ""!= jc_renyuanParam.Yx)
            {
                this.isComma(sql);
                sql.Append(" YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Direction = ParameterDirection.Input;
                pYx.Value = jc_renyuanParam.Yx;
                sqlparams.Add(pYx);

            }
                        
            if (null != jc_renyuanParam.Bz &&  ""!= jc_renyuanParam.Bz)
            {
                this.isComma(sql);
                sql.Append(" BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Direction = ParameterDirection.Input;
                pBz.Value = jc_renyuanParam.Bz;
                sqlparams.Add(pBz);

            }
                        
            if (null != jc_renyuanParam.Pym &&  ""!= jc_renyuanParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_renyuanParam.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_renyuanParam.Wbm &&  ""!= jc_renyuanParam.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_renyuanParam.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_renyuanParam.Rylx_code &&  ""!= jc_renyuanParam.Rylx_code)
            {
                this.isComma(sql);
                sql.Append(" RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Direction = ParameterDirection.Input;
                pRylx_code.Value = jc_renyuanParam.Rylx_code;
                sqlparams.Add(pRylx_code);

            }
                        
            if (null != jc_renyuanParam.Zfbz &&  ""!= jc_renyuanParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuanParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_renyuanParam.Id;
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
        /// <param name="jc_renyuanParamList">要修改的Jc_renyuan对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_renyuan> jc_renyuanParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> xmList = new List<string>();

            List<string> xb_codeList = new List<string>();

            List<string> mz_codeList = new List<string>();

            List<DateTime?> csrqList = new List<DateTime?>();

            List<string> sfzhList = new List<string>();

            List<string> zzmm_codeList = new List<string>();

            List<string> hyzk_codeList = new List<string>();

            List<string> byxxList = new List<string>();

            List<string> xl_codeList = new List<string>();

            List<DateTime?> cjgzsjList = new List<DateTime?>();

            List<string> zyList = new List<string>();

            List<string> jgList = new List<string>();

            List<string> dzList = new List<string>();

            List<string> lxdhList = new List<string>();

            List<string> qqList = new List<string>();

            List<string> yxList = new List<string>();

            List<string> bzList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> rylx_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_renyuanParamList.Count; i++)
            {
                Jc_renyuan jc_renyuanParam = jc_renyuanParamList[i];
                if ("" == jc_renyuanParam.Id || null == jc_renyuanParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_renyuanParam.Id);

            xmList.Add(jc_renyuanParam.Xm);

            xb_codeList.Add(jc_renyuanParam.Xb_code);

            mz_codeList.Add(jc_renyuanParam.Mz_code);

            csrqList.Add(jc_renyuanParam.Csrq);

            sfzhList.Add(jc_renyuanParam.Sfzh);

            zzmm_codeList.Add(jc_renyuanParam.Zzmm_code);

            hyzk_codeList.Add(jc_renyuanParam.Hyzk_code);

            byxxList.Add(jc_renyuanParam.Byxx);

            xl_codeList.Add(jc_renyuanParam.Xl_code);

            cjgzsjList.Add(jc_renyuanParam.Cjgzsj);

            zyList.Add(jc_renyuanParam.Zy);

            jgList.Add(jc_renyuanParam.Jg);

            dzList.Add(jc_renyuanParam.Dz);

            lxdhList.Add(jc_renyuanParam.Lxdh);

            qqList.Add(jc_renyuanParam.Qq);

            yxList.Add(jc_renyuanParam.Yx);

            bzList.Add(jc_renyuanParam.Bz);

            pymList.Add(jc_renyuanParam.Pym);

            wbmList.Add(jc_renyuanParam.Wbm);

            rylx_codeList.Add(jc_renyuanParam.Rylx_code);

            zfbzList.Add(jc_renyuanParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN SET ");
            this.isComma(sql);
            sql.Append(" XM=:xm ");
            OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
            pXm.Direction = ParameterDirection.Input;
            pXm.Value = xmList.ToArray();
            sqlparams.Add(pXm);

            this.isComma(sql);
            sql.Append(" XB_CODE=:xb_code ");
            OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
            pXb_code.Direction = ParameterDirection.Input;
            pXb_code.Value = xb_codeList.ToArray();
            sqlparams.Add(pXb_code);

            this.isComma(sql);
            sql.Append(" MZ_CODE=:mz_code ");
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = mz_codeList.ToArray();
            sqlparams.Add(pMz_code);

            this.isComma(sql);
            sql.Append(" CSRQ=:csrq ");
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = csrqList.ToArray();
            sqlparams.Add(pCsrq);

            this.isComma(sql);
            sql.Append(" SFZH=:sfzh ");
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = sfzhList.ToArray();
            sqlparams.Add(pSfzh);

            this.isComma(sql);
            sql.Append(" ZZMM_CODE=:zzmm_code ");
            OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
            pZzmm_code.Direction = ParameterDirection.Input;
            pZzmm_code.Value = zzmm_codeList.ToArray();
            sqlparams.Add(pZzmm_code);

            this.isComma(sql);
            sql.Append(" HYZK_CODE=:hyzk_code ");
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = hyzk_codeList.ToArray();
            sqlparams.Add(pHyzk_code);

            this.isComma(sql);
            sql.Append(" BYXX=:byxx ");
            OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
            pByxx.Direction = ParameterDirection.Input;
            pByxx.Value = byxxList.ToArray();
            sqlparams.Add(pByxx);

            this.isComma(sql);
            sql.Append(" XL_CODE=:xl_code ");
            OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
            pXl_code.Direction = ParameterDirection.Input;
            pXl_code.Value = xl_codeList.ToArray();
            sqlparams.Add(pXl_code);

            this.isComma(sql);
            sql.Append(" CJGZSJ=:cjgzsj ");
            OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
            pCjgzsj.Direction = ParameterDirection.Input;
            pCjgzsj.Value = cjgzsjList.ToArray();
            sqlparams.Add(pCjgzsj);

            this.isComma(sql);
            sql.Append(" ZY=:zy ");
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = zyList.ToArray();
            sqlparams.Add(pZy);

            this.isComma(sql);
            sql.Append(" JG=:jg ");
            OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
            pJg.Direction = ParameterDirection.Input;
            pJg.Value = jgList.ToArray();
            sqlparams.Add(pJg);

            this.isComma(sql);
            sql.Append(" DZ=:dz ");
            OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
            pDz.Direction = ParameterDirection.Input;
            pDz.Value = dzList.ToArray();
            sqlparams.Add(pDz);

            this.isComma(sql);
            sql.Append(" LXDH=:lxdh ");
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = lxdhList.ToArray();
            sqlparams.Add(pLxdh);

            this.isComma(sql);
            sql.Append(" QQ=:qq ");
            OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
            pQq.Direction = ParameterDirection.Input;
            pQq.Value = qqList.ToArray();
            sqlparams.Add(pQq);

            this.isComma(sql);
            sql.Append(" YX=:yx ");
            OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
            pYx.Direction = ParameterDirection.Input;
            pYx.Value = yxList.ToArray();
            sqlparams.Add(pYx);

            this.isComma(sql);
            sql.Append(" BZ=:bz ");
            OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
            pBz.Direction = ParameterDirection.Input;
            pBz.Value = bzList.ToArray();
            sqlparams.Add(pBz);

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
            sql.Append(" RYLX_CODE=:rylx_code ");
            OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
            pRylx_code.Direction = ParameterDirection.Input;
            pRylx_code.Value = rylx_codeList.ToArray();
            sqlparams.Add(pRylx_code);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_renyuanParamList.Count, sqlparams.ToArray());
            if (jc_renyuanParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_renyuanParamCondition">条件对象</param>
        /// <param name="jc_renyuanParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_renyuan jc_renyuanParamCondition, Jc_renyuan jc_renyuanParamUpdate, OracleConnection con)
        {
            if ((null!=jc_renyuanParamCondition.Id&&"!=jc_renyuanParamCondition.Id)||(null!=jc_renyuanParamUpdate.Id&&"!=jc_renyuanParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_RENYUAN SET ");
            if (null != jc_renyuanParamUpdate.Xm &&  ""!= jc_renyuanParamUpdate.Xm)
            {
                this.isComma(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_renyuanParamUpdate.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_renyuanParamUpdate.Xb_code &&  ""!= jc_renyuanParamUpdate.Xb_code)
            {
                this.isComma(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_renyuanParamUpdate.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (null != jc_renyuanParamUpdate.Mz_code &&  ""!= jc_renyuanParamUpdate.Mz_code)
            {
                this.isComma(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_renyuanParamUpdate.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamUpdate.Csrq &&null != jc_renyuanParamUpdate.Csrq)
            {
                this.isComma(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_renyuanParamUpdate.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_renyuanParamUpdate.Sfzh &&  ""!= jc_renyuanParamUpdate.Sfzh)
            {
                this.isComma(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_renyuanParamUpdate.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_renyuanParamUpdate.Zzmm_code &&  ""!= jc_renyuanParamUpdate.Zzmm_code)
            {
                this.isComma(sql);
                sql.Append(" ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Direction = ParameterDirection.Input;
                pZzmm_code.Value = jc_renyuanParamUpdate.Zzmm_code;
                sqlparams.Add(pZzmm_code);

            }
                        
            if (null != jc_renyuanParamUpdate.Hyzk_code &&  ""!= jc_renyuanParamUpdate.Hyzk_code)
            {
                this.isComma(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_renyuanParamUpdate.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_renyuanParamUpdate.Byxx &&  ""!= jc_renyuanParamUpdate.Byxx)
            {
                this.isComma(sql);
                sql.Append(" BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Direction = ParameterDirection.Input;
                pByxx.Value = jc_renyuanParamUpdate.Byxx;
                sqlparams.Add(pByxx);

            }
                        
            if (null != jc_renyuanParamUpdate.Xl_code &&  ""!= jc_renyuanParamUpdate.Xl_code)
            {
                this.isComma(sql);
                sql.Append(" XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Direction = ParameterDirection.Input;
                pXl_code.Value = jc_renyuanParamUpdate.Xl_code;
                sqlparams.Add(pXl_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamUpdate.Cjgzsj &&null != jc_renyuanParamUpdate.Cjgzsj)
            {
                this.isComma(sql);
                sql.Append(" CJGZSJ=:cjgzsj ");
                OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Direction = ParameterDirection.Input;
                pCjgzsj.Value = jc_renyuanParamUpdate.Cjgzsj;
                sqlparams.Add(pCjgzsj);

            }
                        
            if (null != jc_renyuanParamUpdate.Zy &&  ""!= jc_renyuanParamUpdate.Zy)
            {
                this.isComma(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_renyuanParamUpdate.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_renyuanParamUpdate.Jg &&  ""!= jc_renyuanParamUpdate.Jg)
            {
                this.isComma(sql);
                sql.Append(" JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Direction = ParameterDirection.Input;
                pJg.Value = jc_renyuanParamUpdate.Jg;
                sqlparams.Add(pJg);

            }
                        
            if (null != jc_renyuanParamUpdate.Dz &&  ""!= jc_renyuanParamUpdate.Dz)
            {
                this.isComma(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_renyuanParamUpdate.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_renyuanParamUpdate.Lxdh &&  ""!= jc_renyuanParamUpdate.Lxdh)
            {
                this.isComma(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_renyuanParamUpdate.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_renyuanParamUpdate.Qq &&  ""!= jc_renyuanParamUpdate.Qq)
            {
                this.isComma(sql);
                sql.Append(" QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Direction = ParameterDirection.Input;
                pQq.Value = jc_renyuanParamUpdate.Qq;
                sqlparams.Add(pQq);

            }
                        
            if (null != jc_renyuanParamUpdate.Yx &&  ""!= jc_renyuanParamUpdate.Yx)
            {
                this.isComma(sql);
                sql.Append(" YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Direction = ParameterDirection.Input;
                pYx.Value = jc_renyuanParamUpdate.Yx;
                sqlparams.Add(pYx);

            }
                        
            if (null != jc_renyuanParamUpdate.Bz &&  ""!= jc_renyuanParamUpdate.Bz)
            {
                this.isComma(sql);
                sql.Append(" BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Direction = ParameterDirection.Input;
                pBz.Value = jc_renyuanParamUpdate.Bz;
                sqlparams.Add(pBz);

            }
                        
            if (null != jc_renyuanParamUpdate.Pym &&  ""!= jc_renyuanParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_renyuanParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_renyuanParamUpdate.Wbm &&  ""!= jc_renyuanParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_renyuanParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_renyuanParamUpdate.Rylx_code &&  ""!= jc_renyuanParamUpdate.Rylx_code)
            {
                this.isComma(sql);
                sql.Append(" RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Direction = ParameterDirection.Input;
                pRylx_code.Value = jc_renyuanParamUpdate.Rylx_code;
                sqlparams.Add(pRylx_code);

            }
                        
            if (null != jc_renyuanParamUpdate.Zfbz &&  ""!= jc_renyuanParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuanParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_renyuanParamCondition.Xm &&  ""!= jc_renyuanParamCondition.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_renyuanParamCondition.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_renyuanParamCondition.Xb_code &&  ""!= jc_renyuanParamCondition.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_renyuanParamCondition.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (null != jc_renyuanParamCondition.Mz_code &&  ""!= jc_renyuanParamCondition.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_renyuanParamCondition.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamCondition.Csrq &&null != jc_renyuanParamCondition.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_renyuanParamCondition.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_renyuanParamCondition.Sfzh &&  ""!= jc_renyuanParamCondition.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_renyuanParamCondition.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_renyuanParamCondition.Zzmm_code &&  ""!= jc_renyuanParamCondition.Zzmm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Direction = ParameterDirection.Input;
                pZzmm_code.Value = jc_renyuanParamCondition.Zzmm_code;
                sqlparams.Add(pZzmm_code);

            }
                        
            if (null != jc_renyuanParamCondition.Hyzk_code &&  ""!= jc_renyuanParamCondition.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_renyuanParamCondition.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_renyuanParamCondition.Byxx &&  ""!= jc_renyuanParamCondition.Byxx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Direction = ParameterDirection.Input;
                pByxx.Value = jc_renyuanParamCondition.Byxx;
                sqlparams.Add(pByxx);

            }
                        
            if (null != jc_renyuanParamCondition.Xl_code &&  ""!= jc_renyuanParamCondition.Xl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Direction = ParameterDirection.Input;
                pXl_code.Value = jc_renyuanParamCondition.Xl_code;
                sqlparams.Add(pXl_code);

            }
                        
            if (DateTime.MinValue != jc_renyuanParamCondition.Cjgzsj &&null != jc_renyuanParamCondition.Cjgzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJGZSJ=:cjgzsj ");
                OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Direction = ParameterDirection.Input;
                pCjgzsj.Value = jc_renyuanParamCondition.Cjgzsj;
                sqlparams.Add(pCjgzsj);

            }
                        
            if (null != jc_renyuanParamCondition.Zy &&  ""!= jc_renyuanParamCondition.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_renyuanParamCondition.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_renyuanParamCondition.Jg &&  ""!= jc_renyuanParamCondition.Jg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Direction = ParameterDirection.Input;
                pJg.Value = jc_renyuanParamCondition.Jg;
                sqlparams.Add(pJg);

            }
                        
            if (null != jc_renyuanParamCondition.Dz &&  ""!= jc_renyuanParamCondition.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_renyuanParamCondition.Dz;
                sqlparams.Add(pDz);

            }
                        
            if (null != jc_renyuanParamCondition.Lxdh &&  ""!= jc_renyuanParamCondition.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_renyuanParamCondition.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_renyuanParamCondition.Qq &&  ""!= jc_renyuanParamCondition.Qq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Direction = ParameterDirection.Input;
                pQq.Value = jc_renyuanParamCondition.Qq;
                sqlparams.Add(pQq);

            }
                        
            if (null != jc_renyuanParamCondition.Yx &&  ""!= jc_renyuanParamCondition.Yx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Direction = ParameterDirection.Input;
                pYx.Value = jc_renyuanParamCondition.Yx;
                sqlparams.Add(pYx);

            }
                        
            if (null != jc_renyuanParamCondition.Bz &&  ""!= jc_renyuanParamCondition.Bz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Direction = ParameterDirection.Input;
                pBz.Value = jc_renyuanParamCondition.Bz;
                sqlparams.Add(pBz);

            }
                        
            if (null != jc_renyuanParamCondition.Pym &&  ""!= jc_renyuanParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_renyuanParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_renyuanParamCondition.Wbm &&  ""!= jc_renyuanParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_renyuanParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_renyuanParamCondition.Rylx_code &&  ""!= jc_renyuanParamCondition.Rylx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Direction = ParameterDirection.Input;
                pRylx_code.Value = jc_renyuanParamCondition.Rylx_code;
                sqlparams.Add(pRylx_code);

            }
                        
            if (null != jc_renyuanParamCondition.Zfbz &&  ""!= jc_renyuanParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuanParamCondition.Zfbz;
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
        /// <returns>Jc_renyuan</returns>
        public Jc_renyuan findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN A ");
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
        /// <param name="jc_renyuanParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_renyuanParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_renyuan对象集合list</returns>
        public List<object> find(Jc_renyuan jc_renyuanParam, Model.Common.PageInfo page,Jc_renyuan jc_renyuanParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_renyuan对象，标示查询所有数据
            if (null == jc_renyuanParam)
            {
                jc_renyuanParam = new Jc_renyuan();
            }
            if (null!=jc_renyuanParam.Id&&""!=jc_renyuanParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_renyuan> jc_renyuanParamList = new List<Jc_renyuan>();//接收查询出的Jc_renyuan对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_renyuan jc_renyuanParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_renyuanParam.Xm && "" != jc_renyuanParam.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_renyuanParam.Xm;
                sqlparams.Add(pXm);
            }
                
            if (null != jc_renyuanParam.Xb_code && "" != jc_renyuanParam.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_renyuanParam.Xb_code;
                sqlparams.Add(pXb_code);
            }
                
            if (null != jc_renyuanParam.Mz_code && "" != jc_renyuanParam.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_renyuanParam.Mz_code;
                sqlparams.Add(pMz_code);
            }
                
                if (DateTime.MinValue != jc_renyuanParam.Csrq &&null != jc_renyuanParam.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_renyuanParam.Csrq;
                sqlparams.Add(pCsrq);
                }
                
            if (null != jc_renyuanParam.Sfzh && "" != jc_renyuanParam.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_renyuanParam.Sfzh;
                sqlparams.Add(pSfzh);
            }
                
            if (null != jc_renyuanParam.Zzmm_code && "" != jc_renyuanParam.Zzmm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Direction = ParameterDirection.Input;
                pZzmm_code.Value = jc_renyuanParam.Zzmm_code;
                sqlparams.Add(pZzmm_code);
            }
                
            if (null != jc_renyuanParam.Hyzk_code && "" != jc_renyuanParam.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_renyuanParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
            }
                
            if (null != jc_renyuanParam.Byxx && "" != jc_renyuanParam.Byxx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Direction = ParameterDirection.Input;
                pByxx.Value = jc_renyuanParam.Byxx;
                sqlparams.Add(pByxx);
            }
                
            if (null != jc_renyuanParam.Xl_code && "" != jc_renyuanParam.Xl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Direction = ParameterDirection.Input;
                pXl_code.Value = jc_renyuanParam.Xl_code;
                sqlparams.Add(pXl_code);
            }
                
                if (DateTime.MinValue != jc_renyuanParam.Cjgzsj &&null != jc_renyuanParam.Cjgzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJGZSJ=:cjgzsj ");
                    OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Direction = ParameterDirection.Input;
                pCjgzsj.Value = jc_renyuanParam.Cjgzsj;
                sqlparams.Add(pCjgzsj);
                }
                
            if (null != jc_renyuanParam.Zy && "" != jc_renyuanParam.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_renyuanParam.Zy;
                sqlparams.Add(pZy);
            }
                
            if (null != jc_renyuanParam.Jg && "" != jc_renyuanParam.Jg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Direction = ParameterDirection.Input;
                pJg.Value = jc_renyuanParam.Jg;
                sqlparams.Add(pJg);
            }
                
            if (null != jc_renyuanParam.Dz && "" != jc_renyuanParam.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Direction = ParameterDirection.Input;
                pDz.Value = jc_renyuanParam.Dz;
                sqlparams.Add(pDz);
            }
                
            if (null != jc_renyuanParam.Lxdh && "" != jc_renyuanParam.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_renyuanParam.Lxdh;
                sqlparams.Add(pLxdh);
            }
                
            if (null != jc_renyuanParam.Qq && "" != jc_renyuanParam.Qq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Direction = ParameterDirection.Input;
                pQq.Value = jc_renyuanParam.Qq;
                sqlparams.Add(pQq);
            }
                
            if (null != jc_renyuanParam.Yx && "" != jc_renyuanParam.Yx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Direction = ParameterDirection.Input;
                pYx.Value = jc_renyuanParam.Yx;
                sqlparams.Add(pYx);
            }
                
            if (null != jc_renyuanParam.Bz && "" != jc_renyuanParam.Bz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Direction = ParameterDirection.Input;
                pBz.Value = jc_renyuanParam.Bz;
                sqlparams.Add(pBz);
            }
                
            if (null != jc_renyuanParam.Pym && "" != jc_renyuanParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_renyuanParam.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != jc_renyuanParam.Wbm && "" != jc_renyuanParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_renyuanParam.Wbm;
                sqlparams.Add(pWbm);
            }
                
            if (null != jc_renyuanParam.Rylx_code && "" != jc_renyuanParam.Rylx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Direction = ParameterDirection.Input;
                pRylx_code.Value = jc_renyuanParam.Rylx_code;
                sqlparams.Add(pRylx_code);
            }
                
            if (null != jc_renyuanParam.Zfbz && "" != jc_renyuanParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_renyuanParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_renyuanParamLike!=null)
            {

                if (null != jc_renyuanParamLike.Xm && "" != jc_renyuanParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_renyuanParamLike.Xm;
                    sqlparams.Add(pXm);
                }
                
                if (null != jc_renyuanParamLike.Xb_code && "" != jc_renyuanParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_renyuanParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }
                
                if (null != jc_renyuanParamLike.Mz_code && "" != jc_renyuanParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_renyuanParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }
                
                if (null != jc_renyuanParamLike.Sfzh && "" != jc_renyuanParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_renyuanParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }
                
                if (null != jc_renyuanParamLike.Zzmm_code && "" != jc_renyuanParamLike.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZZMM_CODE LIKE '%'||:zzmm_code||'%' ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Direction = ParameterDirection.Input;
                    pZzmm_code.Value = jc_renyuanParamLike.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }
                
                if (null != jc_renyuanParamLike.Hyzk_code && "" != jc_renyuanParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_renyuanParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_renyuanParamLike.Byxx && "" != jc_renyuanParamLike.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BYXX LIKE '%'||:byxx||'%' ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Direction = ParameterDirection.Input;
                    pByxx.Value = jc_renyuanParamLike.Byxx;
                    sqlparams.Add(pByxx);
                }
                
                if (null != jc_renyuanParamLike.Xl_code && "" != jc_renyuanParamLike.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XL_CODE LIKE '%'||:xl_code||'%' ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Direction = ParameterDirection.Input;
                    pXl_code.Value = jc_renyuanParamLike.Xl_code;
                    sqlparams.Add(pXl_code);
                }
                
                if (null != jc_renyuanParamLike.Zy && "" != jc_renyuanParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_renyuanParamLike.Zy;
                    sqlparams.Add(pZy);
                }
                
                if (null != jc_renyuanParamLike.Jg && "" != jc_renyuanParamLike.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JG LIKE '%'||:jg||'%' ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Direction = ParameterDirection.Input;
                    pJg.Value = jc_renyuanParamLike.Jg;
                    sqlparams.Add(pJg);
                }
                
                if (null != jc_renyuanParamLike.Dz && "" != jc_renyuanParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_renyuanParamLike.Dz;
                    sqlparams.Add(pDz);
                }
                
                if (null != jc_renyuanParamLike.Lxdh && "" != jc_renyuanParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_renyuanParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }
                
                if (null != jc_renyuanParamLike.Qq && "" != jc_renyuanParamLike.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.QQ LIKE '%'||:qq||'%' ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Direction = ParameterDirection.Input;
                    pQq.Value = jc_renyuanParamLike.Qq;
                    sqlparams.Add(pQq);
                }
                
                if (null != jc_renyuanParamLike.Yx && "" != jc_renyuanParamLike.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YX LIKE '%'||:yx||'%' ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Direction = ParameterDirection.Input;
                    pYx.Value = jc_renyuanParamLike.Yx;
                    sqlparams.Add(pYx);
                }
                
                if (null != jc_renyuanParamLike.Bz && "" != jc_renyuanParamLike.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BZ LIKE '%'||:bz||'%' ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Direction = ParameterDirection.Input;
                    pBz.Value = jc_renyuanParamLike.Bz;
                    sqlparams.Add(pBz);
                }
                
                if (null != jc_renyuanParamLike.Pym && "" != jc_renyuanParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_renyuanParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_renyuanParamLike.Wbm && "" != jc_renyuanParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_renyuanParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_renyuanParamLike.Rylx_code && "" != jc_renyuanParamLike.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RYLX_CODE LIKE '%'||:rylx_code||'%' ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Direction = ParameterDirection.Input;
                    pRylx_code.Value = jc_renyuanParamLike.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }
                
                if (null != jc_renyuanParamLike.Zfbz && "" != jc_renyuanParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuanParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_renyuan>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_renyuan>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_renyuanParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_renyuanParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_renyuanParamList);//把List<Jc_renyuan>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_renyuan jc_renyuanParam,Jc_renyuan jc_renyuanParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_renyuan对象，标示查询所有数据
            if (null == jc_renyuanParam)
            {
                jc_renyuanParam = new Jc_renyuan();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_RENYUAN A");
                if (null != jc_renyuanParam.Xm && "" != jc_renyuanParam.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Value = jc_renyuanParam.Xm;
                sqlparams.Add(pXm);
                }
                
                if (null != jc_renyuanParam.Xb_code && "" != jc_renyuanParam.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Value = jc_renyuanParam.Xb_code;
                sqlparams.Add(pXb_code);
                }
                
                if (null != jc_renyuanParam.Mz_code && "" != jc_renyuanParam.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Value = jc_renyuanParam.Mz_code;
                sqlparams.Add(pMz_code);
                }
                
                if (DateTime.MinValue != jc_renyuanParam.Csrq &&null != jc_renyuanParam.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Value = jc_renyuanParam.Csrq;
                sqlparams.Add(pCsrq);
                }
                
                if (null != jc_renyuanParam.Sfzh && "" != jc_renyuanParam.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Value = jc_renyuanParam.Sfzh;
                sqlparams.Add(pSfzh);
                }
                
                if (null != jc_renyuanParam.Zzmm_code && "" != jc_renyuanParam.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZZMM_CODE=:zzmm_code ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Value = jc_renyuanParam.Zzmm_code;
                sqlparams.Add(pZzmm_code);
                }
                
                if (null != jc_renyuanParam.Hyzk_code && "" != jc_renyuanParam.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Value = jc_renyuanParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_renyuanParam.Byxx && "" != jc_renyuanParam.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BYXX=:byxx ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Value = jc_renyuanParam.Byxx;
                sqlparams.Add(pByxx);
                }
                
                if (null != jc_renyuanParam.Xl_code && "" != jc_renyuanParam.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XL_CODE=:xl_code ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Value = jc_renyuanParam.Xl_code;
                sqlparams.Add(pXl_code);
                }
                
                if (DateTime.MinValue != jc_renyuanParam.Cjgzsj &&null != jc_renyuanParam.Cjgzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJGZSJ=:cjgzsj ");
                    OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Value = jc_renyuanParam.Cjgzsj;
                sqlparams.Add(pCjgzsj);
                }
                
                if (null != jc_renyuanParam.Zy && "" != jc_renyuanParam.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Value = jc_renyuanParam.Zy;
                sqlparams.Add(pZy);
                }
                
                if (null != jc_renyuanParam.Jg && "" != jc_renyuanParam.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JG=:jg ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Value = jc_renyuanParam.Jg;
                sqlparams.Add(pJg);
                }
                
                if (null != jc_renyuanParam.Dz && "" != jc_renyuanParam.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ=:dz ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Value = jc_renyuanParam.Dz;
                sqlparams.Add(pDz);
                }
                
                if (null != jc_renyuanParam.Lxdh && "" != jc_renyuanParam.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Value = jc_renyuanParam.Lxdh;
                sqlparams.Add(pLxdh);
                }
                
                if (null != jc_renyuanParam.Qq && "" != jc_renyuanParam.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.QQ=:qq ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Value = jc_renyuanParam.Qq;
                sqlparams.Add(pQq);
                }
                
                if (null != jc_renyuanParam.Yx && "" != jc_renyuanParam.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YX=:yx ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Value = jc_renyuanParam.Yx;
                sqlparams.Add(pYx);
                }
                
                if (null != jc_renyuanParam.Bz && "" != jc_renyuanParam.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BZ=:bz ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Value = jc_renyuanParam.Bz;
                sqlparams.Add(pBz);
                }
                
                if (null != jc_renyuanParam.Pym && "" != jc_renyuanParam.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_renyuanParam.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != jc_renyuanParam.Wbm && "" != jc_renyuanParam.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_renyuanParam.Wbm;
                sqlparams.Add(pWbm);
                }
                
                if (null != jc_renyuanParam.Rylx_code && "" != jc_renyuanParam.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RYLX_CODE=:rylx_code ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Value = jc_renyuanParam.Rylx_code;
                sqlparams.Add(pRylx_code);
                }
                
                if (null != jc_renyuanParam.Zfbz && "" != jc_renyuanParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_renyuanParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_renyuanParamLike!=null)
            {

                if (null != jc_renyuanParamLike.Xm && "" != jc_renyuanParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_renyuanParamLike.Xm;
                    sqlparams.Add(pXm);
                }
                
                if (null != jc_renyuanParamLike.Xb_code && "" != jc_renyuanParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_renyuanParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }
                
                if (null != jc_renyuanParamLike.Mz_code && "" != jc_renyuanParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_renyuanParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }
                
                if (null != jc_renyuanParamLike.Sfzh && "" != jc_renyuanParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_renyuanParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }
                
                if (null != jc_renyuanParamLike.Zzmm_code && "" != jc_renyuanParamLike.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZZMM_CODE LIKE '%'||:zzmm_code||'%' ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Direction = ParameterDirection.Input;
                    pZzmm_code.Value = jc_renyuanParamLike.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }
                
                if (null != jc_renyuanParamLike.Hyzk_code && "" != jc_renyuanParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_renyuanParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_renyuanParamLike.Byxx && "" != jc_renyuanParamLike.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BYXX LIKE '%'||:byxx||'%' ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Direction = ParameterDirection.Input;
                    pByxx.Value = jc_renyuanParamLike.Byxx;
                    sqlparams.Add(pByxx);
                }
                
                if (null != jc_renyuanParamLike.Xl_code && "" != jc_renyuanParamLike.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XL_CODE LIKE '%'||:xl_code||'%' ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Direction = ParameterDirection.Input;
                    pXl_code.Value = jc_renyuanParamLike.Xl_code;
                    sqlparams.Add(pXl_code);
                }
                
                if (null != jc_renyuanParamLike.Zy && "" != jc_renyuanParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_renyuanParamLike.Zy;
                    sqlparams.Add(pZy);
                }
                
                if (null != jc_renyuanParamLike.Jg && "" != jc_renyuanParamLike.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JG LIKE '%'||:jg||'%' ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Direction = ParameterDirection.Input;
                    pJg.Value = jc_renyuanParamLike.Jg;
                    sqlparams.Add(pJg);
                }
                
                if (null != jc_renyuanParamLike.Dz && "" != jc_renyuanParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_renyuanParamLike.Dz;
                    sqlparams.Add(pDz);
                }
                
                if (null != jc_renyuanParamLike.Lxdh && "" != jc_renyuanParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_renyuanParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }
                
                if (null != jc_renyuanParamLike.Qq && "" != jc_renyuanParamLike.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.QQ LIKE '%'||:qq||'%' ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Direction = ParameterDirection.Input;
                    pQq.Value = jc_renyuanParamLike.Qq;
                    sqlparams.Add(pQq);
                }
                
                if (null != jc_renyuanParamLike.Yx && "" != jc_renyuanParamLike.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YX LIKE '%'||:yx||'%' ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Direction = ParameterDirection.Input;
                    pYx.Value = jc_renyuanParamLike.Yx;
                    sqlparams.Add(pYx);
                }
                
                if (null != jc_renyuanParamLike.Bz && "" != jc_renyuanParamLike.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BZ LIKE '%'||:bz||'%' ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Direction = ParameterDirection.Input;
                    pBz.Value = jc_renyuanParamLike.Bz;
                    sqlparams.Add(pBz);
                }
                
                if (null != jc_renyuanParamLike.Pym && "" != jc_renyuanParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_renyuanParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_renyuanParamLike.Wbm && "" != jc_renyuanParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_renyuanParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_renyuanParamLike.Rylx_code && "" != jc_renyuanParamLike.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RYLX_CODE LIKE '%'||:rylx_code||'%' ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Direction = ParameterDirection.Input;
                    pRylx_code.Value = jc_renyuanParamLike.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }
                
                if (null != jc_renyuanParamLike.Zfbz && "" != jc_renyuanParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuanParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_renyuanParam"></param>
        /// <returns></returns>
        public bool save(Jc_renyuan jc_renyuanParam,OracleConnection con)
        {
            if ("" != jc_renyuanParam.Id && null != jc_renyuanParam.Id)
            {
                //修改
                return this.updateById(jc_renyuanParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_renyuanParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_renyuan dataSetToModel(DataRow row)
        {
            Jc_renyuan jc_renyuanParam = new Jc_renyuan();
            jc_renyuanParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_renyuanParam.Xm = Convert.ToString(row["XM"]).Trim(); 
            jc_renyuanParam.Xb_code = Convert.ToString(row["XB_CODE"]).Trim(); 
            jc_renyuanParam.Mz_code = Convert.ToString(row["MZ_CODE"]).Trim(); 
            jc_renyuanParam.Csrq =  (DateTime?)this.convertDBNullValue(row["CSRQ"]);
            jc_renyuanParam.Sfzh = Convert.ToString(row["SFZH"]).Trim(); 
            jc_renyuanParam.Zzmm_code = Convert.ToString(row["ZZMM_CODE"]).Trim(); 
            jc_renyuanParam.Hyzk_code = Convert.ToString(row["HYZK_CODE"]).Trim(); 
            jc_renyuanParam.Byxx = Convert.ToString(row["BYXX"]).Trim(); 
            jc_renyuanParam.Xl_code = Convert.ToString(row["XL_CODE"]).Trim(); 
            jc_renyuanParam.Cjgzsj =  (DateTime?)this.convertDBNullValue(row["CJGZSJ"]);
            jc_renyuanParam.Zy = Convert.ToString(row["ZY"]).Trim(); 
            jc_renyuanParam.Jg = Convert.ToString(row["JG"]).Trim(); 
            jc_renyuanParam.Dz = Convert.ToString(row["DZ"]).Trim(); 
            jc_renyuanParam.Lxdh = Convert.ToString(row["LXDH"]).Trim(); 
            jc_renyuanParam.Qq = Convert.ToString(row["QQ"]).Trim(); 
            jc_renyuanParam.Yx = Convert.ToString(row["YX"]).Trim(); 
            jc_renyuanParam.Bz = Convert.ToString(row["BZ"]).Trim(); 
            jc_renyuanParam.Pym = Convert.ToString(row["PYM"]).Trim(); 
            jc_renyuanParam.Wbm = Convert.ToString(row["WBM"]).Trim(); 
            jc_renyuanParam.Rylx_code = Convert.ToString(row["RYLX_CODE"]).Trim(); 
            jc_renyuanParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_renyuanParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_renyuan dataSetContactObjectsToModel(DataRow row)
        {
            Jc_renyuan jc_renyuanParam = this.dataSetToModel(row);

            //添加代码类别实体对象,性别（关联基础字典表）对象
            Jc_code xbCode = new Jc_code();
            xbCode.Id = Convert.ToString(row["XB_CODE_ID"]).Trim();
            xbCode.Name = Convert.ToString(row["XB_CODE_NAME"]).Trim();
            xbCode.Value = Convert.ToString(row["XB_CODE_VALUE"]).Trim();
            xbCode.Fk_code_type = Convert.ToString(row["XB_CODE_FKCODETYPE"]).Trim();
            xbCode.Zfbz = Convert.ToString(row["XB_CODE_ZFBZ"]).Trim();
            xbCode.Remark = Convert.ToString(row["XB_CODE_REMARK"]).Trim();
            jc_renyuanParam.XbCode = xbCode;

            //添加代码类别实体对象,民族（关联基础字典表）对象
            Jc_code mzCode = new Jc_code();
            mzCode.Id = Convert.ToString(row["MZ_CODE_ID"]).Trim();
            mzCode.Name = Convert.ToString(row["MZ_CODE_NAME"]).Trim();
            mzCode.Value = Convert.ToString(row["MZ_CODE_VALUE"]).Trim();
            mzCode.Fk_code_type = Convert.ToString(row["MZ_CODE_FKCODETYPE"]).Trim();
            mzCode.Zfbz = Convert.ToString(row["MZ_CODE_ZFBZ"]).Trim();
            mzCode.Remark = Convert.ToString(row["MZ_CODE_REMARK"]).Trim();
            jc_renyuanParam.MzCode = mzCode;

            //添加代码类别实体对象,政治面貌（关联基础字典表）对象
            Jc_code zzmmCode = new Jc_code();
            zzmmCode.Id = Convert.ToString(row["ZZMM_CODE_ID"]).Trim();
            zzmmCode.Name = Convert.ToString(row["ZZMM_CODE_NAME"]).Trim();
            zzmmCode.Value = Convert.ToString(row["ZZMM_CODE_VALUE"]).Trim();
            zzmmCode.Fk_code_type = Convert.ToString(row["ZZMM_CODE_FKCODETYPE"]).Trim();
            zzmmCode.Zfbz = Convert.ToString(row["ZZMM_CODE_ZFBZ"]).Trim();
            zzmmCode.Remark = Convert.ToString(row["ZZMM_CODE_REMARK"]).Trim();
            jc_renyuanParam.ZzmmCode = zzmmCode;

            //添加代码类别实体对象,婚姻状况（关联基础字典表）对象
            Jc_code hyzkCode = new Jc_code();
            hyzkCode.Id = Convert.ToString(row["HYZK_CODE_ID"]).Trim();
            hyzkCode.Name = Convert.ToString(row["HYZK_CODE_NAME"]).Trim();
            hyzkCode.Value = Convert.ToString(row["HYZK_CODE_VALUE"]).Trim();
            hyzkCode.Fk_code_type = Convert.ToString(row["HYZK_CODE_FKCODETYPE"]).Trim();
            hyzkCode.Zfbz = Convert.ToString(row["HYZK_CODE_ZFBZ"]).Trim();
            hyzkCode.Remark = Convert.ToString(row["HYZK_CODE_REMARK"]).Trim();
            jc_renyuanParam.HyzkCode = hyzkCode;

            //添加代码类别实体对象,学历（关联基础字典表）对象
            Jc_code xlCode = new Jc_code();
            xlCode.Id = Convert.ToString(row["XL_CODE_ID"]).Trim();
            xlCode.Name = Convert.ToString(row["XL_CODE_NAME"]).Trim();
            xlCode.Value = Convert.ToString(row["XL_CODE_VALUE"]).Trim();
            xlCode.Fk_code_type = Convert.ToString(row["XL_CODE_FKCODETYPE"]).Trim();
            xlCode.Zfbz = Convert.ToString(row["XL_CODE_ZFBZ"]).Trim();
            xlCode.Remark = Convert.ToString(row["XL_CODE_REMARK"]).Trim();
            jc_renyuanParam.XlCode = xlCode;

            //添加代码类别实体对象,人员类型（关联基础字典表）对象
            Jc_code rylxCode = new Jc_code();
            rylxCode.Id = Convert.ToString(row["RYLX_CODE_ID"]).Trim();
            rylxCode.Name = Convert.ToString(row["RYLX_CODE_NAME"]).Trim();
            rylxCode.Value = Convert.ToString(row["RYLX_CODE_VALUE"]).Trim();
            rylxCode.Fk_code_type = Convert.ToString(row["RYLX_CODE_FKCODETYPE"]).Trim();
            rylxCode.Zfbz = Convert.ToString(row["RYLX_CODE_ZFBZ"]).Trim();
            rylxCode.Remark = Convert.ToString(row["RYLX_CODE_REMARK"]).Trim();
            jc_renyuanParam.RylxCode = rylxCode;

            return jc_renyuanParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_renyuan</returns>
        public Jc_renyuan findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_XB_CODE.ID AS XB_CODE_ID,TT_XB_CODE.NAME AS XB_CODE_NAME,TT_XB_CODE.VALUE AS XB_CODE_VALUE,TT_XB_CODE.FK_CODE_TYPE AS XB_CODE_FKCODETYPE,TT_XB_CODE.ZFBZ AS XB_CODE_ZFBZ,TT_XB_CODE.REMARK AS XB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_MZ_CODE.ID AS MZ_CODE_ID,TT_MZ_CODE.NAME AS MZ_CODE_NAME,TT_MZ_CODE.VALUE AS MZ_CODE_VALUE,TT_MZ_CODE.FK_CODE_TYPE AS MZ_CODE_FKCODETYPE,TT_MZ_CODE.ZFBZ AS MZ_CODE_ZFBZ,TT_MZ_CODE.REMARK AS MZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZZMM_CODE.ID AS ZZMM_CODE_ID,TT_ZZMM_CODE.NAME AS ZZMM_CODE_NAME,TT_ZZMM_CODE.VALUE AS ZZMM_CODE_VALUE,TT_ZZMM_CODE.FK_CODE_TYPE AS ZZMM_CODE_FKCODETYPE,TT_ZZMM_CODE.ZFBZ AS ZZMM_CODE_ZFBZ,TT_ZZMM_CODE.REMARK AS ZZMM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_HYZK_CODE.ID AS HYZK_CODE_ID,TT_HYZK_CODE.NAME AS HYZK_CODE_NAME,TT_HYZK_CODE.VALUE AS HYZK_CODE_VALUE,TT_HYZK_CODE.FK_CODE_TYPE AS HYZK_CODE_FKCODETYPE,TT_HYZK_CODE.ZFBZ AS HYZK_CODE_ZFBZ,TT_HYZK_CODE.REMARK AS HYZK_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XL_CODE.ID AS XL_CODE_ID,TT_XL_CODE.NAME AS XL_CODE_NAME,TT_XL_CODE.VALUE AS XL_CODE_VALUE,TT_XL_CODE.FK_CODE_TYPE AS XL_CODE_FKCODETYPE,TT_XL_CODE.ZFBZ AS XL_CODE_ZFBZ,TT_XL_CODE.REMARK AS XL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_RYLX_CODE.ID AS RYLX_CODE_ID,TT_RYLX_CODE.NAME AS RYLX_CODE_NAME,TT_RYLX_CODE.VALUE AS RYLX_CODE_VALUE,TT_RYLX_CODE.FK_CODE_TYPE AS RYLX_CODE_FKCODETYPE,TT_RYLX_CODE.ZFBZ AS RYLX_CODE_ZFBZ,TT_RYLX_CODE.REMARK AS RYLX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.性别类型值 + @"')) TT_XB_CODE
                        ON A.XB_CODE = TT_XB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.民族类型值 + @"')) TT_MZ_CODE
                        ON A.MZ_CODE = TT_MZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.政治面貌类型值 + @"')) TT_ZZMM_CODE
                        ON A.ZZMM_CODE = TT_ZZMM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.婚姻状况类型值 + @"')) TT_HYZK_CODE
                        ON A.HYZK_CODE = TT_HYZK_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.学历类型值 + @"')) TT_XL_CODE
                        ON A.XL_CODE = TT_XL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.工作人员类型 + @"')) TT_RYLX_CODE
                        ON A.RYLX_CODE = TT_RYLX_CODE.VALUE
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
        /// <param name="jc_renyuanParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_renyuanParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_renyuan对象集合list</returns>
        public List<object> findContactObjects(Jc_renyuan jc_renyuanParam, Model.Common.PageInfo page, Jc_renyuan jc_renyuanParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_renyuan对象，标示查询所有数据
            if (null == jc_renyuanParam)
            {
                jc_renyuanParam = new Jc_renyuan();
            }
            if (null != jc_renyuanParam.Id && "" != jc_renyuanParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_renyuan> jc_renyuanParamList = new List<Jc_renyuan>();//接收查询出的Jc_renyuan对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_renyuan jc_renyuanParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_XB_CODE.ID AS XB_CODE_ID,TT_XB_CODE.NAME AS XB_CODE_NAME,TT_XB_CODE.VALUE AS XB_CODE_VALUE,TT_XB_CODE.FK_CODE_TYPE AS XB_CODE_FKCODETYPE,TT_XB_CODE.ZFBZ AS XB_CODE_ZFBZ,TT_XB_CODE.REMARK AS XB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_MZ_CODE.ID AS MZ_CODE_ID,TT_MZ_CODE.NAME AS MZ_CODE_NAME,TT_MZ_CODE.VALUE AS MZ_CODE_VALUE,TT_MZ_CODE.FK_CODE_TYPE AS MZ_CODE_FKCODETYPE,TT_MZ_CODE.ZFBZ AS MZ_CODE_ZFBZ,TT_MZ_CODE.REMARK AS MZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZZMM_CODE.ID AS ZZMM_CODE_ID,TT_ZZMM_CODE.NAME AS ZZMM_CODE_NAME,TT_ZZMM_CODE.VALUE AS ZZMM_CODE_VALUE,TT_ZZMM_CODE.FK_CODE_TYPE AS ZZMM_CODE_FKCODETYPE,TT_ZZMM_CODE.ZFBZ AS ZZMM_CODE_ZFBZ,TT_ZZMM_CODE.REMARK AS ZZMM_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_HYZK_CODE.ID AS HYZK_CODE_ID,TT_HYZK_CODE.NAME AS HYZK_CODE_NAME,TT_HYZK_CODE.VALUE AS HYZK_CODE_VALUE,TT_HYZK_CODE.FK_CODE_TYPE AS HYZK_CODE_FKCODETYPE,TT_HYZK_CODE.ZFBZ AS HYZK_CODE_ZFBZ,TT_HYZK_CODE.REMARK AS HYZK_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XL_CODE.ID AS XL_CODE_ID,TT_XL_CODE.NAME AS XL_CODE_NAME,TT_XL_CODE.VALUE AS XL_CODE_VALUE,TT_XL_CODE.FK_CODE_TYPE AS XL_CODE_FKCODETYPE,TT_XL_CODE.ZFBZ AS XL_CODE_ZFBZ,TT_XL_CODE.REMARK AS XL_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_RYLX_CODE.ID AS RYLX_CODE_ID,TT_RYLX_CODE.NAME AS RYLX_CODE_NAME,TT_RYLX_CODE.VALUE AS RYLX_CODE_VALUE,TT_RYLX_CODE.FK_CODE_TYPE AS RYLX_CODE_FKCODETYPE,TT_RYLX_CODE.ZFBZ AS RYLX_CODE_ZFBZ,TT_RYLX_CODE.REMARK AS RYLX_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_RENYUAN A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.性别类型值 + @"')) TT_XB_CODE
                        ON A.XB_CODE = TT_XB_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.民族类型值 + @"')) TT_MZ_CODE
                        ON A.MZ_CODE = TT_MZ_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.政治面貌类型值 + @"')) TT_ZZMM_CODE
                        ON A.ZZMM_CODE = TT_ZZMM_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.婚姻状况类型值 + @"')) TT_HYZK_CODE
                        ON A.HYZK_CODE = TT_HYZK_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.学历类型值 + @"')) TT_XL_CODE
                        ON A.XL_CODE = TT_XL_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.工作人员类型 + @"')) TT_RYLX_CODE
                        ON A.RYLX_CODE = TT_RYLX_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_renyuanParam.Xm && "" != jc_renyuanParam.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Value = jc_renyuanParam.Xm;
                sqlparams.Add(pXm);
            }

            if (null != jc_renyuanParam.Xb_code && "" != jc_renyuanParam.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Value = jc_renyuanParam.Xb_code;
                sqlparams.Add(pXb_code);
            }

            if (null != jc_renyuanParam.Mz_code && "" != jc_renyuanParam.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Value = jc_renyuanParam.Mz_code;
                sqlparams.Add(pMz_code);
            }

            if (DateTime.MinValue != jc_renyuanParam.Csrq && null != jc_renyuanParam.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Value = jc_renyuanParam.Csrq;
                sqlparams.Add(pCsrq);
            }

            if (null != jc_renyuanParam.Sfzh && "" != jc_renyuanParam.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Value = jc_renyuanParam.Sfzh;
                sqlparams.Add(pSfzh);
            }

            if (null != jc_renyuanParam.Zzmm_code && "" != jc_renyuanParam.Zzmm_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZZMM_CODE=:zzmm_code ");
                OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                pZzmm_code.Value = jc_renyuanParam.Zzmm_code;
                sqlparams.Add(pZzmm_code);
            }

            if (null != jc_renyuanParam.Hyzk_code && "" != jc_renyuanParam.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Value = jc_renyuanParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
            }

            if (null != jc_renyuanParam.Byxx && "" != jc_renyuanParam.Byxx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BYXX=:byxx ");
                OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                pByxx.Value = jc_renyuanParam.Byxx;
                sqlparams.Add(pByxx);
            }

            if (null != jc_renyuanParam.Xl_code && "" != jc_renyuanParam.Xl_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XL_CODE=:xl_code ");
                OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                pXl_code.Value = jc_renyuanParam.Xl_code;
                sqlparams.Add(pXl_code);
            }

            if (DateTime.MinValue != jc_renyuanParam.Cjgzsj && null != jc_renyuanParam.Cjgzsj)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJGZSJ=:cjgzsj ");
                OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                pCjgzsj.Value = jc_renyuanParam.Cjgzsj;
                sqlparams.Add(pCjgzsj);
            }

            if (null != jc_renyuanParam.Zy && "" != jc_renyuanParam.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Value = jc_renyuanParam.Zy;
                sqlparams.Add(pZy);
            }

            if (null != jc_renyuanParam.Jg && "" != jc_renyuanParam.Jg)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JG=:jg ");
                OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                pJg.Value = jc_renyuanParam.Jg;
                sqlparams.Add(pJg);
            }

            if (null != jc_renyuanParam.Dz && "" != jc_renyuanParam.Dz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.DZ=:dz ");
                OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                pDz.Value = jc_renyuanParam.Dz;
                sqlparams.Add(pDz);
            }

            if (null != jc_renyuanParam.Lxdh && "" != jc_renyuanParam.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Value = jc_renyuanParam.Lxdh;
                sqlparams.Add(pLxdh);
            }

            if (null != jc_renyuanParam.Qq && "" != jc_renyuanParam.Qq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.QQ=:qq ");
                OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                pQq.Value = jc_renyuanParam.Qq;
                sqlparams.Add(pQq);
            }

            if (null != jc_renyuanParam.Yx && "" != jc_renyuanParam.Yx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YX=:yx ");
                OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                pYx.Value = jc_renyuanParam.Yx;
                sqlparams.Add(pYx);
            }

            if (null != jc_renyuanParam.Bz && "" != jc_renyuanParam.Bz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BZ=:bz ");
                OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                pBz.Value = jc_renyuanParam.Bz;
                sqlparams.Add(pBz);
            }

            if (null != jc_renyuanParam.Pym && "" != jc_renyuanParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_renyuanParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_renyuanParam.Wbm && "" != jc_renyuanParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_renyuanParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_renyuanParam.Rylx_code && "" != jc_renyuanParam.Rylx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.RYLX_CODE=:rylx_code ");
                OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                pRylx_code.Value = jc_renyuanParam.Rylx_code;
                sqlparams.Add(pRylx_code);
            }

            if (null != jc_renyuanParam.Zfbz && "" != jc_renyuanParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_renyuanParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_renyuanParamLike != null)
            {

                if (null != jc_renyuanParamLike.Xm && "" != jc_renyuanParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_renyuanParamLike.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != jc_renyuanParamLike.Xb_code && "" != jc_renyuanParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_renyuanParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (null != jc_renyuanParamLike.Mz_code && "" != jc_renyuanParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_renyuanParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (null != jc_renyuanParamLike.Sfzh && "" != jc_renyuanParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_renyuanParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != jc_renyuanParamLike.Zzmm_code && "" != jc_renyuanParamLike.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZZMM_CODE LIKE '%'||:zzmm_code||'%' ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Direction = ParameterDirection.Input;
                    pZzmm_code.Value = jc_renyuanParamLike.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }

                if (null != jc_renyuanParamLike.Hyzk_code && "" != jc_renyuanParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_renyuanParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != jc_renyuanParamLike.Byxx && "" != jc_renyuanParamLike.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BYXX LIKE '%'||:byxx||'%' ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Direction = ParameterDirection.Input;
                    pByxx.Value = jc_renyuanParamLike.Byxx;
                    sqlparams.Add(pByxx);
                }

                if (null != jc_renyuanParamLike.Xl_code && "" != jc_renyuanParamLike.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XL_CODE LIKE '%'||:xl_code||'%' ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Direction = ParameterDirection.Input;
                    pXl_code.Value = jc_renyuanParamLike.Xl_code;
                    sqlparams.Add(pXl_code);
                }

                if (null != jc_renyuanParamLike.Zy && "" != jc_renyuanParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_renyuanParamLike.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != jc_renyuanParamLike.Jg && "" != jc_renyuanParamLike.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JG LIKE '%'||:jg||'%' ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Direction = ParameterDirection.Input;
                    pJg.Value = jc_renyuanParamLike.Jg;
                    sqlparams.Add(pJg);
                }

                if (null != jc_renyuanParamLike.Dz && "" != jc_renyuanParamLike.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.DZ LIKE '%'||:dz||'%' ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Direction = ParameterDirection.Input;
                    pDz.Value = jc_renyuanParamLike.Dz;
                    sqlparams.Add(pDz);
                }

                if (null != jc_renyuanParamLike.Lxdh && "" != jc_renyuanParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_renyuanParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != jc_renyuanParamLike.Qq && "" != jc_renyuanParamLike.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.QQ LIKE '%'||:qq||'%' ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Direction = ParameterDirection.Input;
                    pQq.Value = jc_renyuanParamLike.Qq;
                    sqlparams.Add(pQq);
                }

                if (null != jc_renyuanParamLike.Yx && "" != jc_renyuanParamLike.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YX LIKE '%'||:yx||'%' ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Direction = ParameterDirection.Input;
                    pYx.Value = jc_renyuanParamLike.Yx;
                    sqlparams.Add(pYx);
                }

                if (null != jc_renyuanParamLike.Bz && "" != jc_renyuanParamLike.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BZ LIKE '%'||:bz||'%' ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Direction = ParameterDirection.Input;
                    pBz.Value = jc_renyuanParamLike.Bz;
                    sqlparams.Add(pBz);
                }

                if (null != jc_renyuanParamLike.Pym && "" != jc_renyuanParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_renyuanParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_renyuanParamLike.Wbm && "" != jc_renyuanParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_renyuanParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_renyuanParamLike.Rylx_code && "" != jc_renyuanParamLike.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RYLX_CODE LIKE '%'||:rylx_code||'%' ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Direction = ParameterDirection.Input;
                    pRylx_code.Value = jc_renyuanParamLike.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }

                if (null != jc_renyuanParamLike.Zfbz && "" != jc_renyuanParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_renyuanParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (jc_renyuanParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_renyuan>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_renyuan>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_renyuanParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_renyuanParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_renyuanParamList);//把List<Jc_renyuan>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        #endregion
        //*******************在此以后添加新的方法end
        
    }
}


