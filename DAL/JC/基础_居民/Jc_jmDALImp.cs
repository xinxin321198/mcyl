

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

namespace DAL.JC.基础_居民
{
    /// <summary>
    ///数据库访问层的Jc_jm实现类
    ///此类由代码生成器生成
    ///表名：JC_JM
    ///生成日期：2015-12-02 16:17:23
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Jc_jmDALImp :Base.BasDAL,Jc_jmDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="jc_jmParam">要插入的jc_jmParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Jc_jm jc_jmParam,OracleConnection con)
        {
            if (""==jc_jmParam.Id||null==jc_jmParam.Id)
            {
                jc_jmParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO JC_JM(id,sfzh,xm,xb_code,csrq,mz_code,xx_code,rh_code,csdz,hjdz,xzz_xzqh,xzz_xiang_xi_di_zhi,gzdw_xx,zy_code,zy,wh_code,hyzk_code,lxdh,jhr_xm,jhr_dh,nhbm,ybkh,cjkh,zfzh,jkdabh,pym,wbm,zfbz) VALUES(:id,:sfzh,:xm,:xb_code,:csrq,:mz_code,:xx_code,:rh_code,:csdz,:hjdz,:xzz_xzqh,:xzz_xiang_xi_di_zhi,:gzdw_xx,:zy_code,:zy,:wh_code,:hyzk_code,:lxdh,:jhr_xm,:jhr_dh,:nhbm,:ybkh,:cjkh,:zfzh,:jkdabh,:pym,:wbm,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = jc_jmParam.Id;
            sqlparams.Add(pId);
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = jc_jmParam.Sfzh;
            sqlparams.Add(pSfzh);
            OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
            pXm.Direction = ParameterDirection.Input;
            pXm.Value = jc_jmParam.Xm;
            sqlparams.Add(pXm);
            OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
            pXb_code.Direction = ParameterDirection.Input;
            pXb_code.Value = jc_jmParam.Xb_code;
            sqlparams.Add(pXb_code);
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = jc_jmParam.Csrq;
            sqlparams.Add(pCsrq);
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = jc_jmParam.Mz_code;
            sqlparams.Add(pMz_code);
            OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
            pXx_code.Direction = ParameterDirection.Input;
            pXx_code.Value = jc_jmParam.Xx_code;
            sqlparams.Add(pXx_code);
            OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
            pRh_code.Direction = ParameterDirection.Input;
            pRh_code.Value = jc_jmParam.Rh_code;
            sqlparams.Add(pRh_code);
            OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
            pCsdz.Direction = ParameterDirection.Input;
            pCsdz.Value = jc_jmParam.Csdz;
            sqlparams.Add(pCsdz);
            OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
            pHjdz.Direction = ParameterDirection.Input;
            pHjdz.Value = jc_jmParam.Hjdz;
            sqlparams.Add(pHjdz);
            OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
            pXzz_xzqh.Direction = ParameterDirection.Input;
            pXzz_xzqh.Value = jc_jmParam.Xzz_xzqh;
            sqlparams.Add(pXzz_xzqh);
            OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
            pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
            pXzz_xiang_xi_di_zhi.Value = jc_jmParam.Xzz_xiang_xi_di_zhi;
            sqlparams.Add(pXzz_xiang_xi_di_zhi);
            OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
            pGzdw_xx.Direction = ParameterDirection.Input;
            pGzdw_xx.Value = jc_jmParam.Gzdw_xx;
            sqlparams.Add(pGzdw_xx);
            OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
            pZy_code.Direction = ParameterDirection.Input;
            pZy_code.Value = jc_jmParam.Zy_code;
            sqlparams.Add(pZy_code);
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = jc_jmParam.Zy;
            sqlparams.Add(pZy);
            OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
            pWh_code.Direction = ParameterDirection.Input;
            pWh_code.Value = jc_jmParam.Wh_code;
            sqlparams.Add(pWh_code);
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = jc_jmParam.Hyzk_code;
            sqlparams.Add(pHyzk_code);
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = jc_jmParam.Lxdh;
            sqlparams.Add(pLxdh);
            OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
            pJhr_xm.Direction = ParameterDirection.Input;
            pJhr_xm.Value = jc_jmParam.Jhr_xm;
            sqlparams.Add(pJhr_xm);
            OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
            pJhr_dh.Direction = ParameterDirection.Input;
            pJhr_dh.Value = jc_jmParam.Jhr_dh;
            sqlparams.Add(pJhr_dh);
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = jc_jmParam.Nhbm;
            sqlparams.Add(pNhbm);
            OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
            pYbkh.Direction = ParameterDirection.Input;
            pYbkh.Value = jc_jmParam.Ybkh;
            sqlparams.Add(pYbkh);
            OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
            pCjkh.Direction = ParameterDirection.Input;
            pCjkh.Value = jc_jmParam.Cjkh;
            sqlparams.Add(pCjkh);
            OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
            pZfzh.Direction = ParameterDirection.Input;
            pZfzh.Value = jc_jmParam.Zfzh;
            sqlparams.Add(pZfzh);
            OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
            pJkdabh.Direction = ParameterDirection.Input;
            pJkdabh.Value = jc_jmParam.Jkdabh;
            sqlparams.Add(pJkdabh);
            OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
            pPym.Direction = ParameterDirection.Input;
            pPym.Value = jc_jmParam.Pym;
            sqlparams.Add(pPym);
            OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
            pWbm.Direction = ParameterDirection.Input;
            pWbm.Value = jc_jmParam.Wbm;
            sqlparams.Add(pWbm);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = jc_jmParam.Zfbz;
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
        /// <param name="jc_jmParamList">要插入的jc_jmParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Jc_jm> jc_jmParamList, OracleConnection con)
        {
            if (jc_jmParamList.Count == 0)
            {
                return true;
            }
            List<string> idList = new List<string>();

            List<string> sfzhList = new List<string>();

            List<string> xmList = new List<string>();

            List<string> xb_codeList = new List<string>();

            List<DateTime?> csrqList = new List<DateTime?>();

            List<string> mz_codeList = new List<string>();

            List<string> xx_codeList = new List<string>();

            List<string> rh_codeList = new List<string>();

            List<string> csdzList = new List<string>();

            List<string> hjdzList = new List<string>();

            List<string> xzz_xzqhList = new List<string>();

            List<string> xzz_xiang_xi_di_zhiList = new List<string>();

            List<string> gzdw_xxList = new List<string>();

            List<string> zy_codeList = new List<string>();

            List<string> zyList = new List<string>();

            List<string> wh_codeList = new List<string>();

            List<string> hyzk_codeList = new List<string>();

            List<string> lxdhList = new List<string>();

            List<string> jhr_xmList = new List<string>();

            List<string> jhr_dhList = new List<string>();

            List<string> nhbmList = new List<string>();

            List<string> ybkhList = new List<string>();

            List<string> cjkhList = new List<string>();

            List<string> zfzhList = new List<string>();

            List<string> jkdabhList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_jmParamList.Count; i++)
            {
                Jc_jm jc_jmParam = jc_jmParamList[i];
                if ("" == jc_jmParam.Id || null == jc_jmParam.Id)
                {
                    jc_jmParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(jc_jmParam.Id);

            sfzhList.Add(jc_jmParam.Sfzh);

            xmList.Add(jc_jmParam.Xm);

            xb_codeList.Add(jc_jmParam.Xb_code);

            csrqList.Add(jc_jmParam.Csrq);

            mz_codeList.Add(jc_jmParam.Mz_code);

            xx_codeList.Add(jc_jmParam.Xx_code);

            rh_codeList.Add(jc_jmParam.Rh_code);

            csdzList.Add(jc_jmParam.Csdz);

            hjdzList.Add(jc_jmParam.Hjdz);

            xzz_xzqhList.Add(jc_jmParam.Xzz_xzqh);

            xzz_xiang_xi_di_zhiList.Add(jc_jmParam.Xzz_xiang_xi_di_zhi);

            gzdw_xxList.Add(jc_jmParam.Gzdw_xx);

            zy_codeList.Add(jc_jmParam.Zy_code);

            zyList.Add(jc_jmParam.Zy);

            wh_codeList.Add(jc_jmParam.Wh_code);

            hyzk_codeList.Add(jc_jmParam.Hyzk_code);

            lxdhList.Add(jc_jmParam.Lxdh);

            jhr_xmList.Add(jc_jmParam.Jhr_xm);

            jhr_dhList.Add(jc_jmParam.Jhr_dh);

            nhbmList.Add(jc_jmParam.Nhbm);

            ybkhList.Add(jc_jmParam.Ybkh);

            cjkhList.Add(jc_jmParam.Cjkh);

            zfzhList.Add(jc_jmParam.Zfzh);

            jkdabhList.Add(jc_jmParam.Jkdabh);

            pymList.Add(jc_jmParam.Pym);

            wbmList.Add(jc_jmParam.Wbm);

            zfbzList.Add(jc_jmParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO JC_JM(id,sfzh,xm,xb_code,csrq,mz_code,xx_code,rh_code,csdz,hjdz,xzz_xzqh,xzz_xiang_xi_di_zhi,gzdw_xx,zy_code,zy,wh_code,hyzk_code,lxdh,jhr_xm,jhr_dh,nhbm,ybkh,cjkh,zfzh,jkdabh,pym,wbm,zfbz) VALUES(:id,:sfzh,:xm,:xb_code,:csrq,:mz_code,:xx_code,:rh_code,:csdz,:hjdz,:xzz_xzqh,:xzz_xiang_xi_di_zhi,:gzdw_xx,:zy_code,:zy,:wh_code,:hyzk_code,:lxdh,:jhr_xm,:jhr_dh,:nhbm,:ybkh,:cjkh,:zfzh,:jkdabh,:pym,:wbm,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = sfzhList.ToArray();
            sqlparams.Add(pSfzh);
            OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
            pXm.Direction = ParameterDirection.Input;
            pXm.Value = xmList.ToArray();
            sqlparams.Add(pXm);
            OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
            pXb_code.Direction = ParameterDirection.Input;
            pXb_code.Value = xb_codeList.ToArray();
            sqlparams.Add(pXb_code);
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = csrqList.ToArray();
            sqlparams.Add(pCsrq);
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = mz_codeList.ToArray();
            sqlparams.Add(pMz_code);
            OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
            pXx_code.Direction = ParameterDirection.Input;
            pXx_code.Value = xx_codeList.ToArray();
            sqlparams.Add(pXx_code);
            OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
            pRh_code.Direction = ParameterDirection.Input;
            pRh_code.Value = rh_codeList.ToArray();
            sqlparams.Add(pRh_code);
            OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
            pCsdz.Direction = ParameterDirection.Input;
            pCsdz.Value = csdzList.ToArray();
            sqlparams.Add(pCsdz);
            OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
            pHjdz.Direction = ParameterDirection.Input;
            pHjdz.Value = hjdzList.ToArray();
            sqlparams.Add(pHjdz);
            OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
            pXzz_xzqh.Direction = ParameterDirection.Input;
            pXzz_xzqh.Value = xzz_xzqhList.ToArray();
            sqlparams.Add(pXzz_xzqh);
            OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
            pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
            pXzz_xiang_xi_di_zhi.Value = xzz_xiang_xi_di_zhiList.ToArray();
            sqlparams.Add(pXzz_xiang_xi_di_zhi);
            OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
            pGzdw_xx.Direction = ParameterDirection.Input;
            pGzdw_xx.Value = gzdw_xxList.ToArray();
            sqlparams.Add(pGzdw_xx);
            OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
            pZy_code.Direction = ParameterDirection.Input;
            pZy_code.Value = zy_codeList.ToArray();
            sqlparams.Add(pZy_code);
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = zyList.ToArray();
            sqlparams.Add(pZy);
            OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
            pWh_code.Direction = ParameterDirection.Input;
            pWh_code.Value = wh_codeList.ToArray();
            sqlparams.Add(pWh_code);
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = hyzk_codeList.ToArray();
            sqlparams.Add(pHyzk_code);
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = lxdhList.ToArray();
            sqlparams.Add(pLxdh);
            OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
            pJhr_xm.Direction = ParameterDirection.Input;
            pJhr_xm.Value = jhr_xmList.ToArray();
            sqlparams.Add(pJhr_xm);
            OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
            pJhr_dh.Direction = ParameterDirection.Input;
            pJhr_dh.Value = jhr_dhList.ToArray();
            sqlparams.Add(pJhr_dh);
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = nhbmList.ToArray();
            sqlparams.Add(pNhbm);
            OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
            pYbkh.Direction = ParameterDirection.Input;
            pYbkh.Value = ybkhList.ToArray();
            sqlparams.Add(pYbkh);
            OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
            pCjkh.Direction = ParameterDirection.Input;
            pCjkh.Value = cjkhList.ToArray();
            sqlparams.Add(pCjkh);
            OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
            pZfzh.Direction = ParameterDirection.Input;
            pZfzh.Value = zfzhList.ToArray();
            sqlparams.Add(pZfzh);
            OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
            pJkdabh.Direction = ParameterDirection.Input;
            pJkdabh.Value = jkdabhList.ToArray();
            sqlparams.Add(pJkdabh);
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
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, jc_jmParamList.Count, sqlparams.ToArray());
            if (jc_jmParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE JC_JM WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE JC_JM WHERE ID=:id");
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
        /// <param name="jc_jmParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Jc_jm jc_jmParamCondition, OracleConnection con)
        {
            if (null!=jc_jmParamCondition.Id&&""!=jc_jmParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE JC_JM ");

            if (null != jc_jmParamCondition.Sfzh &&  ""!= jc_jmParamCondition.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_jmParamCondition.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_jmParamCondition.Xm &&  ""!= jc_jmParamCondition.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_jmParamCondition.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_jmParamCondition.Xb_code &&  ""!= jc_jmParamCondition.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_jmParamCondition.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (DateTime.MinValue != jc_jmParamCondition.Csrq &&null != jc_jmParamCondition.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_jmParamCondition.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_jmParamCondition.Mz_code &&  ""!= jc_jmParamCondition.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_jmParamCondition.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (null != jc_jmParamCondition.Xx_code &&  ""!= jc_jmParamCondition.Xx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Direction = ParameterDirection.Input;
                pXx_code.Value = jc_jmParamCondition.Xx_code;
                sqlparams.Add(pXx_code);

            }
                        
            if (null != jc_jmParamCondition.Rh_code &&  ""!= jc_jmParamCondition.Rh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Direction = ParameterDirection.Input;
                pRh_code.Value = jc_jmParamCondition.Rh_code;
                sqlparams.Add(pRh_code);

            }
                        
            if (null != jc_jmParamCondition.Csdz &&  ""!= jc_jmParamCondition.Csdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Direction = ParameterDirection.Input;
                pCsdz.Value = jc_jmParamCondition.Csdz;
                sqlparams.Add(pCsdz);

            }
                        
            if (null != jc_jmParamCondition.Hjdz &&  ""!= jc_jmParamCondition.Hjdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Direction = ParameterDirection.Input;
                pHjdz.Value = jc_jmParamCondition.Hjdz;
                sqlparams.Add(pHjdz);

            }
                        
            if (null != jc_jmParamCondition.Xzz_xzqh &&  ""!= jc_jmParamCondition.Xzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Direction = ParameterDirection.Input;
                pXzz_xzqh.Value = jc_jmParamCondition.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);

            }
                        
            if (null != jc_jmParamCondition.Xzz_xiang_xi_di_zhi &&  ""!= jc_jmParamCondition.Xzz_xiang_xi_di_zhi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                pXzz_xiang_xi_di_zhi.Value = jc_jmParamCondition.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);

            }
                        
            if (null != jc_jmParamCondition.Gzdw_xx &&  ""!= jc_jmParamCondition.Gzdw_xx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Direction = ParameterDirection.Input;
                pGzdw_xx.Value = jc_jmParamCondition.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);

            }
                        
            if (null != jc_jmParamCondition.Zy_code &&  ""!= jc_jmParamCondition.Zy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Direction = ParameterDirection.Input;
                pZy_code.Value = jc_jmParamCondition.Zy_code;
                sqlparams.Add(pZy_code);

            }
                        
            if (null != jc_jmParamCondition.Zy &&  ""!= jc_jmParamCondition.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_jmParamCondition.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_jmParamCondition.Wh_code &&  ""!= jc_jmParamCondition.Wh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Direction = ParameterDirection.Input;
                pWh_code.Value = jc_jmParamCondition.Wh_code;
                sqlparams.Add(pWh_code);

            }
                        
            if (null != jc_jmParamCondition.Hyzk_code &&  ""!= jc_jmParamCondition.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_jmParamCondition.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_jmParamCondition.Lxdh &&  ""!= jc_jmParamCondition.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_jmParamCondition.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_jmParamCondition.Jhr_xm &&  ""!= jc_jmParamCondition.Jhr_xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Direction = ParameterDirection.Input;
                pJhr_xm.Value = jc_jmParamCondition.Jhr_xm;
                sqlparams.Add(pJhr_xm);

            }
                        
            if (null != jc_jmParamCondition.Jhr_dh &&  ""!= jc_jmParamCondition.Jhr_dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Direction = ParameterDirection.Input;
                pJhr_dh.Value = jc_jmParamCondition.Jhr_dh;
                sqlparams.Add(pJhr_dh);

            }
                        
            if (null != jc_jmParamCondition.Nhbm &&  ""!= jc_jmParamCondition.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_jmParamCondition.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_jmParamCondition.Ybkh &&  ""!= jc_jmParamCondition.Ybkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Direction = ParameterDirection.Input;
                pYbkh.Value = jc_jmParamCondition.Ybkh;
                sqlparams.Add(pYbkh);

            }
                        
            if (null != jc_jmParamCondition.Cjkh &&  ""!= jc_jmParamCondition.Cjkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Direction = ParameterDirection.Input;
                pCjkh.Value = jc_jmParamCondition.Cjkh;
                sqlparams.Add(pCjkh);

            }
                        
            if (null != jc_jmParamCondition.Zfzh &&  ""!= jc_jmParamCondition.Zfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Direction = ParameterDirection.Input;
                pZfzh.Value = jc_jmParamCondition.Zfzh;
                sqlparams.Add(pZfzh);

            }
                        
            if (null != jc_jmParamCondition.Jkdabh &&  ""!= jc_jmParamCondition.Jkdabh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Direction = ParameterDirection.Input;
                pJkdabh.Value = jc_jmParamCondition.Jkdabh;
                sqlparams.Add(pJkdabh);

            }
                        
            if (null != jc_jmParamCondition.Pym &&  ""!= jc_jmParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_jmParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_jmParamCondition.Wbm &&  ""!= jc_jmParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_jmParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_jmParamCondition.Zfbz &&  ""!= jc_jmParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_jmParamCondition.Zfbz;
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
        /// <param name="jc_jmParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Jc_jm jc_jmParam,OracleConnection con)
        {
            if ("" == jc_jmParam.Id || null == jc_jmParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_JM SET ");
            if (null != jc_jmParam.Sfzh &&  ""!= jc_jmParam.Sfzh)
            {
                this.isComma(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_jmParam.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_jmParam.Xm &&  ""!= jc_jmParam.Xm)
            {
                this.isComma(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_jmParam.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_jmParam.Xb_code &&  ""!= jc_jmParam.Xb_code)
            {
                this.isComma(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_jmParam.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (DateTime.MinValue != jc_jmParam.Csrq &&null != jc_jmParam.Csrq)
            {
                this.isComma(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_jmParam.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_jmParam.Mz_code &&  ""!= jc_jmParam.Mz_code)
            {
                this.isComma(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_jmParam.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (null != jc_jmParam.Xx_code &&  ""!= jc_jmParam.Xx_code)
            {
                this.isComma(sql);
                sql.Append(" XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Direction = ParameterDirection.Input;
                pXx_code.Value = jc_jmParam.Xx_code;
                sqlparams.Add(pXx_code);

            }
                        
            if (null != jc_jmParam.Rh_code &&  ""!= jc_jmParam.Rh_code)
            {
                this.isComma(sql);
                sql.Append(" RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Direction = ParameterDirection.Input;
                pRh_code.Value = jc_jmParam.Rh_code;
                sqlparams.Add(pRh_code);

            }
                        
            if (null != jc_jmParam.Csdz &&  ""!= jc_jmParam.Csdz)
            {
                this.isComma(sql);
                sql.Append(" CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Direction = ParameterDirection.Input;
                pCsdz.Value = jc_jmParam.Csdz;
                sqlparams.Add(pCsdz);

            }
                        
            if (null != jc_jmParam.Hjdz &&  ""!= jc_jmParam.Hjdz)
            {
                this.isComma(sql);
                sql.Append(" HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Direction = ParameterDirection.Input;
                pHjdz.Value = jc_jmParam.Hjdz;
                sqlparams.Add(pHjdz);

            }
                        
            if (null != jc_jmParam.Xzz_xzqh &&  ""!= jc_jmParam.Xzz_xzqh)
            {
                this.isComma(sql);
                sql.Append(" XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Direction = ParameterDirection.Input;
                pXzz_xzqh.Value = jc_jmParam.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);

            }
                        
            if (null != jc_jmParam.Xzz_xiang_xi_di_zhi &&  ""!= jc_jmParam.Xzz_xiang_xi_di_zhi)
            {
                this.isComma(sql);
                sql.Append(" XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                pXzz_xiang_xi_di_zhi.Value = jc_jmParam.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);

            }
                        
            if (null != jc_jmParam.Gzdw_xx &&  ""!= jc_jmParam.Gzdw_xx)
            {
                this.isComma(sql);
                sql.Append(" GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Direction = ParameterDirection.Input;
                pGzdw_xx.Value = jc_jmParam.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);

            }
                        
            if (null != jc_jmParam.Zy_code &&  ""!= jc_jmParam.Zy_code)
            {
                this.isComma(sql);
                sql.Append(" ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Direction = ParameterDirection.Input;
                pZy_code.Value = jc_jmParam.Zy_code;
                sqlparams.Add(pZy_code);

            }
                        
            if (null != jc_jmParam.Zy &&  ""!= jc_jmParam.Zy)
            {
                this.isComma(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_jmParam.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_jmParam.Wh_code &&  ""!= jc_jmParam.Wh_code)
            {
                this.isComma(sql);
                sql.Append(" WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Direction = ParameterDirection.Input;
                pWh_code.Value = jc_jmParam.Wh_code;
                sqlparams.Add(pWh_code);

            }
                        
            if (null != jc_jmParam.Hyzk_code &&  ""!= jc_jmParam.Hyzk_code)
            {
                this.isComma(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_jmParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_jmParam.Lxdh &&  ""!= jc_jmParam.Lxdh)
            {
                this.isComma(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_jmParam.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_jmParam.Jhr_xm &&  ""!= jc_jmParam.Jhr_xm)
            {
                this.isComma(sql);
                sql.Append(" JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Direction = ParameterDirection.Input;
                pJhr_xm.Value = jc_jmParam.Jhr_xm;
                sqlparams.Add(pJhr_xm);

            }
                        
            if (null != jc_jmParam.Jhr_dh &&  ""!= jc_jmParam.Jhr_dh)
            {
                this.isComma(sql);
                sql.Append(" JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Direction = ParameterDirection.Input;
                pJhr_dh.Value = jc_jmParam.Jhr_dh;
                sqlparams.Add(pJhr_dh);

            }
                        
            if (null != jc_jmParam.Nhbm &&  ""!= jc_jmParam.Nhbm)
            {
                this.isComma(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_jmParam.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_jmParam.Ybkh &&  ""!= jc_jmParam.Ybkh)
            {
                this.isComma(sql);
                sql.Append(" YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Direction = ParameterDirection.Input;
                pYbkh.Value = jc_jmParam.Ybkh;
                sqlparams.Add(pYbkh);

            }
                        
            if (null != jc_jmParam.Cjkh &&  ""!= jc_jmParam.Cjkh)
            {
                this.isComma(sql);
                sql.Append(" CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Direction = ParameterDirection.Input;
                pCjkh.Value = jc_jmParam.Cjkh;
                sqlparams.Add(pCjkh);

            }
                        
            if (null != jc_jmParam.Zfzh &&  ""!= jc_jmParam.Zfzh)
            {
                this.isComma(sql);
                sql.Append(" ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Direction = ParameterDirection.Input;
                pZfzh.Value = jc_jmParam.Zfzh;
                sqlparams.Add(pZfzh);

            }
                        
            if (null != jc_jmParam.Jkdabh &&  ""!= jc_jmParam.Jkdabh)
            {
                this.isComma(sql);
                sql.Append(" JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Direction = ParameterDirection.Input;
                pJkdabh.Value = jc_jmParam.Jkdabh;
                sqlparams.Add(pJkdabh);

            }
                        
            if (null != jc_jmParam.Pym &&  ""!= jc_jmParam.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_jmParam.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_jmParam.Wbm &&  ""!= jc_jmParam.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_jmParam.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_jmParam.Zfbz &&  ""!= jc_jmParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_jmParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = jc_jmParam.Id;
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
        /// <param name="jc_jmParamList">要修改的Jc_jm对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Jc_jm> jc_jmParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<string> sfzhList = new List<string>();

            List<string> xmList = new List<string>();

            List<string> xb_codeList = new List<string>();

            List<DateTime?> csrqList = new List<DateTime?>();

            List<string> mz_codeList = new List<string>();

            List<string> xx_codeList = new List<string>();

            List<string> rh_codeList = new List<string>();

            List<string> csdzList = new List<string>();

            List<string> hjdzList = new List<string>();

            List<string> xzz_xzqhList = new List<string>();

            List<string> xzz_xiang_xi_di_zhiList = new List<string>();

            List<string> gzdw_xxList = new List<string>();

            List<string> zy_codeList = new List<string>();

            List<string> zyList = new List<string>();

            List<string> wh_codeList = new List<string>();

            List<string> hyzk_codeList = new List<string>();

            List<string> lxdhList = new List<string>();

            List<string> jhr_xmList = new List<string>();

            List<string> jhr_dhList = new List<string>();

            List<string> nhbmList = new List<string>();

            List<string> ybkhList = new List<string>();

            List<string> cjkhList = new List<string>();

            List<string> zfzhList = new List<string>();

            List<string> jkdabhList = new List<string>();

            List<string> pymList = new List<string>();

            List<string> wbmList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < jc_jmParamList.Count; i++)
            {
                Jc_jm jc_jmParam = jc_jmParamList[i];
                if ("" == jc_jmParam.Id || null == jc_jmParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(jc_jmParam.Id);

            sfzhList.Add(jc_jmParam.Sfzh);

            xmList.Add(jc_jmParam.Xm);

            xb_codeList.Add(jc_jmParam.Xb_code);

            csrqList.Add(jc_jmParam.Csrq);

            mz_codeList.Add(jc_jmParam.Mz_code);

            xx_codeList.Add(jc_jmParam.Xx_code);

            rh_codeList.Add(jc_jmParam.Rh_code);

            csdzList.Add(jc_jmParam.Csdz);

            hjdzList.Add(jc_jmParam.Hjdz);

            xzz_xzqhList.Add(jc_jmParam.Xzz_xzqh);

            xzz_xiang_xi_di_zhiList.Add(jc_jmParam.Xzz_xiang_xi_di_zhi);

            gzdw_xxList.Add(jc_jmParam.Gzdw_xx);

            zy_codeList.Add(jc_jmParam.Zy_code);

            zyList.Add(jc_jmParam.Zy);

            wh_codeList.Add(jc_jmParam.Wh_code);

            hyzk_codeList.Add(jc_jmParam.Hyzk_code);

            lxdhList.Add(jc_jmParam.Lxdh);

            jhr_xmList.Add(jc_jmParam.Jhr_xm);

            jhr_dhList.Add(jc_jmParam.Jhr_dh);

            nhbmList.Add(jc_jmParam.Nhbm);

            ybkhList.Add(jc_jmParam.Ybkh);

            cjkhList.Add(jc_jmParam.Cjkh);

            zfzhList.Add(jc_jmParam.Zfzh);

            jkdabhList.Add(jc_jmParam.Jkdabh);

            pymList.Add(jc_jmParam.Pym);

            wbmList.Add(jc_jmParam.Wbm);

            zfbzList.Add(jc_jmParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE JC_JM SET ");
            this.isComma(sql);
            sql.Append(" SFZH=:sfzh ");
            OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
            pSfzh.Direction = ParameterDirection.Input;
            pSfzh.Value = sfzhList.ToArray();
            sqlparams.Add(pSfzh);

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
            sql.Append(" CSRQ=:csrq ");
            OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
            pCsrq.Direction = ParameterDirection.Input;
            pCsrq.Value = csrqList.ToArray();
            sqlparams.Add(pCsrq);

            this.isComma(sql);
            sql.Append(" MZ_CODE=:mz_code ");
            OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
            pMz_code.Direction = ParameterDirection.Input;
            pMz_code.Value = mz_codeList.ToArray();
            sqlparams.Add(pMz_code);

            this.isComma(sql);
            sql.Append(" XX_CODE=:xx_code ");
            OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
            pXx_code.Direction = ParameterDirection.Input;
            pXx_code.Value = xx_codeList.ToArray();
            sqlparams.Add(pXx_code);

            this.isComma(sql);
            sql.Append(" RH_CODE=:rh_code ");
            OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
            pRh_code.Direction = ParameterDirection.Input;
            pRh_code.Value = rh_codeList.ToArray();
            sqlparams.Add(pRh_code);

            this.isComma(sql);
            sql.Append(" CSDZ=:csdz ");
            OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
            pCsdz.Direction = ParameterDirection.Input;
            pCsdz.Value = csdzList.ToArray();
            sqlparams.Add(pCsdz);

            this.isComma(sql);
            sql.Append(" HJDZ=:hjdz ");
            OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
            pHjdz.Direction = ParameterDirection.Input;
            pHjdz.Value = hjdzList.ToArray();
            sqlparams.Add(pHjdz);

            this.isComma(sql);
            sql.Append(" XZZ_XZQH=:xzz_xzqh ");
            OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
            pXzz_xzqh.Direction = ParameterDirection.Input;
            pXzz_xzqh.Value = xzz_xzqhList.ToArray();
            sqlparams.Add(pXzz_xzqh);

            this.isComma(sql);
            sql.Append(" XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
            OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
            pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
            pXzz_xiang_xi_di_zhi.Value = xzz_xiang_xi_di_zhiList.ToArray();
            sqlparams.Add(pXzz_xiang_xi_di_zhi);

            this.isComma(sql);
            sql.Append(" GZDW_XX=:gzdw_xx ");
            OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
            pGzdw_xx.Direction = ParameterDirection.Input;
            pGzdw_xx.Value = gzdw_xxList.ToArray();
            sqlparams.Add(pGzdw_xx);

            this.isComma(sql);
            sql.Append(" ZY_CODE=:zy_code ");
            OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
            pZy_code.Direction = ParameterDirection.Input;
            pZy_code.Value = zy_codeList.ToArray();
            sqlparams.Add(pZy_code);

            this.isComma(sql);
            sql.Append(" ZY=:zy ");
            OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
            pZy.Direction = ParameterDirection.Input;
            pZy.Value = zyList.ToArray();
            sqlparams.Add(pZy);

            this.isComma(sql);
            sql.Append(" WH_CODE=:wh_code ");
            OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
            pWh_code.Direction = ParameterDirection.Input;
            pWh_code.Value = wh_codeList.ToArray();
            sqlparams.Add(pWh_code);

            this.isComma(sql);
            sql.Append(" HYZK_CODE=:hyzk_code ");
            OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
            pHyzk_code.Direction = ParameterDirection.Input;
            pHyzk_code.Value = hyzk_codeList.ToArray();
            sqlparams.Add(pHyzk_code);

            this.isComma(sql);
            sql.Append(" LXDH=:lxdh ");
            OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
            pLxdh.Direction = ParameterDirection.Input;
            pLxdh.Value = lxdhList.ToArray();
            sqlparams.Add(pLxdh);

            this.isComma(sql);
            sql.Append(" JHR_XM=:jhr_xm ");
            OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
            pJhr_xm.Direction = ParameterDirection.Input;
            pJhr_xm.Value = jhr_xmList.ToArray();
            sqlparams.Add(pJhr_xm);

            this.isComma(sql);
            sql.Append(" JHR_DH=:jhr_dh ");
            OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
            pJhr_dh.Direction = ParameterDirection.Input;
            pJhr_dh.Value = jhr_dhList.ToArray();
            sqlparams.Add(pJhr_dh);

            this.isComma(sql);
            sql.Append(" NHBM=:nhbm ");
            OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
            pNhbm.Direction = ParameterDirection.Input;
            pNhbm.Value = nhbmList.ToArray();
            sqlparams.Add(pNhbm);

            this.isComma(sql);
            sql.Append(" YBKH=:ybkh ");
            OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
            pYbkh.Direction = ParameterDirection.Input;
            pYbkh.Value = ybkhList.ToArray();
            sqlparams.Add(pYbkh);

            this.isComma(sql);
            sql.Append(" CJKH=:cjkh ");
            OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
            pCjkh.Direction = ParameterDirection.Input;
            pCjkh.Value = cjkhList.ToArray();
            sqlparams.Add(pCjkh);

            this.isComma(sql);
            sql.Append(" ZFZH=:zfzh ");
            OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
            pZfzh.Direction = ParameterDirection.Input;
            pZfzh.Value = zfzhList.ToArray();
            sqlparams.Add(pZfzh);

            this.isComma(sql);
            sql.Append(" JKDABH=:jkdabh ");
            OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
            pJkdabh.Direction = ParameterDirection.Input;
            pJkdabh.Value = jkdabhList.ToArray();
            sqlparams.Add(pJkdabh);

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
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,jc_jmParamList.Count, sqlparams.ToArray());
            if (jc_jmParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="jc_jmParamCondition">条件对象</param>
        /// <param name="jc_jmParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Jc_jm jc_jmParamCondition, Jc_jm jc_jmParamUpdate, OracleConnection con)
        {
            if ((null!=jc_jmParamCondition.Id&&"!=jc_jmParamCondition.Id)||(null!=jc_jmParamUpdate.Id&&"!=jc_jmParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE JC_JM SET ");
            if (null != jc_jmParamUpdate.Sfzh &&  ""!= jc_jmParamUpdate.Sfzh)
            {
                this.isComma(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_jmParamUpdate.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_jmParamUpdate.Xm &&  ""!= jc_jmParamUpdate.Xm)
            {
                this.isComma(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_jmParamUpdate.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_jmParamUpdate.Xb_code &&  ""!= jc_jmParamUpdate.Xb_code)
            {
                this.isComma(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_jmParamUpdate.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (DateTime.MinValue != jc_jmParamUpdate.Csrq &&null != jc_jmParamUpdate.Csrq)
            {
                this.isComma(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_jmParamUpdate.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_jmParamUpdate.Mz_code &&  ""!= jc_jmParamUpdate.Mz_code)
            {
                this.isComma(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_jmParamUpdate.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (null != jc_jmParamUpdate.Xx_code &&  ""!= jc_jmParamUpdate.Xx_code)
            {
                this.isComma(sql);
                sql.Append(" XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Direction = ParameterDirection.Input;
                pXx_code.Value = jc_jmParamUpdate.Xx_code;
                sqlparams.Add(pXx_code);

            }
                        
            if (null != jc_jmParamUpdate.Rh_code &&  ""!= jc_jmParamUpdate.Rh_code)
            {
                this.isComma(sql);
                sql.Append(" RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Direction = ParameterDirection.Input;
                pRh_code.Value = jc_jmParamUpdate.Rh_code;
                sqlparams.Add(pRh_code);

            }
                        
            if (null != jc_jmParamUpdate.Csdz &&  ""!= jc_jmParamUpdate.Csdz)
            {
                this.isComma(sql);
                sql.Append(" CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Direction = ParameterDirection.Input;
                pCsdz.Value = jc_jmParamUpdate.Csdz;
                sqlparams.Add(pCsdz);

            }
                        
            if (null != jc_jmParamUpdate.Hjdz &&  ""!= jc_jmParamUpdate.Hjdz)
            {
                this.isComma(sql);
                sql.Append(" HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Direction = ParameterDirection.Input;
                pHjdz.Value = jc_jmParamUpdate.Hjdz;
                sqlparams.Add(pHjdz);

            }
                        
            if (null != jc_jmParamUpdate.Xzz_xzqh &&  ""!= jc_jmParamUpdate.Xzz_xzqh)
            {
                this.isComma(sql);
                sql.Append(" XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Direction = ParameterDirection.Input;
                pXzz_xzqh.Value = jc_jmParamUpdate.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);

            }
                        
            if (null != jc_jmParamUpdate.Xzz_xiang_xi_di_zhi &&  ""!= jc_jmParamUpdate.Xzz_xiang_xi_di_zhi)
            {
                this.isComma(sql);
                sql.Append(" XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                pXzz_xiang_xi_di_zhi.Value = jc_jmParamUpdate.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);

            }
                        
            if (null != jc_jmParamUpdate.Gzdw_xx &&  ""!= jc_jmParamUpdate.Gzdw_xx)
            {
                this.isComma(sql);
                sql.Append(" GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Direction = ParameterDirection.Input;
                pGzdw_xx.Value = jc_jmParamUpdate.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);

            }
                        
            if (null != jc_jmParamUpdate.Zy_code &&  ""!= jc_jmParamUpdate.Zy_code)
            {
                this.isComma(sql);
                sql.Append(" ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Direction = ParameterDirection.Input;
                pZy_code.Value = jc_jmParamUpdate.Zy_code;
                sqlparams.Add(pZy_code);

            }
                        
            if (null != jc_jmParamUpdate.Zy &&  ""!= jc_jmParamUpdate.Zy)
            {
                this.isComma(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_jmParamUpdate.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_jmParamUpdate.Wh_code &&  ""!= jc_jmParamUpdate.Wh_code)
            {
                this.isComma(sql);
                sql.Append(" WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Direction = ParameterDirection.Input;
                pWh_code.Value = jc_jmParamUpdate.Wh_code;
                sqlparams.Add(pWh_code);

            }
                        
            if (null != jc_jmParamUpdate.Hyzk_code &&  ""!= jc_jmParamUpdate.Hyzk_code)
            {
                this.isComma(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_jmParamUpdate.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_jmParamUpdate.Lxdh &&  ""!= jc_jmParamUpdate.Lxdh)
            {
                this.isComma(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_jmParamUpdate.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_jmParamUpdate.Jhr_xm &&  ""!= jc_jmParamUpdate.Jhr_xm)
            {
                this.isComma(sql);
                sql.Append(" JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Direction = ParameterDirection.Input;
                pJhr_xm.Value = jc_jmParamUpdate.Jhr_xm;
                sqlparams.Add(pJhr_xm);

            }
                        
            if (null != jc_jmParamUpdate.Jhr_dh &&  ""!= jc_jmParamUpdate.Jhr_dh)
            {
                this.isComma(sql);
                sql.Append(" JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Direction = ParameterDirection.Input;
                pJhr_dh.Value = jc_jmParamUpdate.Jhr_dh;
                sqlparams.Add(pJhr_dh);

            }
                        
            if (null != jc_jmParamUpdate.Nhbm &&  ""!= jc_jmParamUpdate.Nhbm)
            {
                this.isComma(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_jmParamUpdate.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_jmParamUpdate.Ybkh &&  ""!= jc_jmParamUpdate.Ybkh)
            {
                this.isComma(sql);
                sql.Append(" YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Direction = ParameterDirection.Input;
                pYbkh.Value = jc_jmParamUpdate.Ybkh;
                sqlparams.Add(pYbkh);

            }
                        
            if (null != jc_jmParamUpdate.Cjkh &&  ""!= jc_jmParamUpdate.Cjkh)
            {
                this.isComma(sql);
                sql.Append(" CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Direction = ParameterDirection.Input;
                pCjkh.Value = jc_jmParamUpdate.Cjkh;
                sqlparams.Add(pCjkh);

            }
                        
            if (null != jc_jmParamUpdate.Zfzh &&  ""!= jc_jmParamUpdate.Zfzh)
            {
                this.isComma(sql);
                sql.Append(" ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Direction = ParameterDirection.Input;
                pZfzh.Value = jc_jmParamUpdate.Zfzh;
                sqlparams.Add(pZfzh);

            }
                        
            if (null != jc_jmParamUpdate.Jkdabh &&  ""!= jc_jmParamUpdate.Jkdabh)
            {
                this.isComma(sql);
                sql.Append(" JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Direction = ParameterDirection.Input;
                pJkdabh.Value = jc_jmParamUpdate.Jkdabh;
                sqlparams.Add(pJkdabh);

            }
                        
            if (null != jc_jmParamUpdate.Pym &&  ""!= jc_jmParamUpdate.Pym)
            {
                this.isComma(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_jmParamUpdate.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_jmParamUpdate.Wbm &&  ""!= jc_jmParamUpdate.Wbm)
            {
                this.isComma(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_jmParamUpdate.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_jmParamUpdate.Zfbz &&  ""!= jc_jmParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_jmParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != jc_jmParamCondition.Sfzh &&  ""!= jc_jmParamCondition.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_jmParamCondition.Sfzh;
                sqlparams.Add(pSfzh);

            }
                        
            if (null != jc_jmParamCondition.Xm &&  ""!= jc_jmParamCondition.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_jmParamCondition.Xm;
                sqlparams.Add(pXm);

            }
                        
            if (null != jc_jmParamCondition.Xb_code &&  ""!= jc_jmParamCondition.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_jmParamCondition.Xb_code;
                sqlparams.Add(pXb_code);

            }
                        
            if (DateTime.MinValue != jc_jmParamCondition.Csrq &&null != jc_jmParamCondition.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_jmParamCondition.Csrq;
                sqlparams.Add(pCsrq);

            }
                        
            if (null != jc_jmParamCondition.Mz_code &&  ""!= jc_jmParamCondition.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_jmParamCondition.Mz_code;
                sqlparams.Add(pMz_code);

            }
                        
            if (null != jc_jmParamCondition.Xx_code &&  ""!= jc_jmParamCondition.Xx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Direction = ParameterDirection.Input;
                pXx_code.Value = jc_jmParamCondition.Xx_code;
                sqlparams.Add(pXx_code);

            }
                        
            if (null != jc_jmParamCondition.Rh_code &&  ""!= jc_jmParamCondition.Rh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Direction = ParameterDirection.Input;
                pRh_code.Value = jc_jmParamCondition.Rh_code;
                sqlparams.Add(pRh_code);

            }
                        
            if (null != jc_jmParamCondition.Csdz &&  ""!= jc_jmParamCondition.Csdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Direction = ParameterDirection.Input;
                pCsdz.Value = jc_jmParamCondition.Csdz;
                sqlparams.Add(pCsdz);

            }
                        
            if (null != jc_jmParamCondition.Hjdz &&  ""!= jc_jmParamCondition.Hjdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Direction = ParameterDirection.Input;
                pHjdz.Value = jc_jmParamCondition.Hjdz;
                sqlparams.Add(pHjdz);

            }
                        
            if (null != jc_jmParamCondition.Xzz_xzqh &&  ""!= jc_jmParamCondition.Xzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Direction = ParameterDirection.Input;
                pXzz_xzqh.Value = jc_jmParamCondition.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);

            }
                        
            if (null != jc_jmParamCondition.Xzz_xiang_xi_di_zhi &&  ""!= jc_jmParamCondition.Xzz_xiang_xi_di_zhi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                pXzz_xiang_xi_di_zhi.Value = jc_jmParamCondition.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);

            }
                        
            if (null != jc_jmParamCondition.Gzdw_xx &&  ""!= jc_jmParamCondition.Gzdw_xx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Direction = ParameterDirection.Input;
                pGzdw_xx.Value = jc_jmParamCondition.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);

            }
                        
            if (null != jc_jmParamCondition.Zy_code &&  ""!= jc_jmParamCondition.Zy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Direction = ParameterDirection.Input;
                pZy_code.Value = jc_jmParamCondition.Zy_code;
                sqlparams.Add(pZy_code);

            }
                        
            if (null != jc_jmParamCondition.Zy &&  ""!= jc_jmParamCondition.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_jmParamCondition.Zy;
                sqlparams.Add(pZy);

            }
                        
            if (null != jc_jmParamCondition.Wh_code &&  ""!= jc_jmParamCondition.Wh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Direction = ParameterDirection.Input;
                pWh_code.Value = jc_jmParamCondition.Wh_code;
                sqlparams.Add(pWh_code);

            }
                        
            if (null != jc_jmParamCondition.Hyzk_code &&  ""!= jc_jmParamCondition.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_jmParamCondition.Hyzk_code;
                sqlparams.Add(pHyzk_code);

            }
                        
            if (null != jc_jmParamCondition.Lxdh &&  ""!= jc_jmParamCondition.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_jmParamCondition.Lxdh;
                sqlparams.Add(pLxdh);

            }
                        
            if (null != jc_jmParamCondition.Jhr_xm &&  ""!= jc_jmParamCondition.Jhr_xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Direction = ParameterDirection.Input;
                pJhr_xm.Value = jc_jmParamCondition.Jhr_xm;
                sqlparams.Add(pJhr_xm);

            }
                        
            if (null != jc_jmParamCondition.Jhr_dh &&  ""!= jc_jmParamCondition.Jhr_dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Direction = ParameterDirection.Input;
                pJhr_dh.Value = jc_jmParamCondition.Jhr_dh;
                sqlparams.Add(pJhr_dh);

            }
                        
            if (null != jc_jmParamCondition.Nhbm &&  ""!= jc_jmParamCondition.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_jmParamCondition.Nhbm;
                sqlparams.Add(pNhbm);

            }
                        
            if (null != jc_jmParamCondition.Ybkh &&  ""!= jc_jmParamCondition.Ybkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Direction = ParameterDirection.Input;
                pYbkh.Value = jc_jmParamCondition.Ybkh;
                sqlparams.Add(pYbkh);

            }
                        
            if (null != jc_jmParamCondition.Cjkh &&  ""!= jc_jmParamCondition.Cjkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Direction = ParameterDirection.Input;
                pCjkh.Value = jc_jmParamCondition.Cjkh;
                sqlparams.Add(pCjkh);

            }
                        
            if (null != jc_jmParamCondition.Zfzh &&  ""!= jc_jmParamCondition.Zfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Direction = ParameterDirection.Input;
                pZfzh.Value = jc_jmParamCondition.Zfzh;
                sqlparams.Add(pZfzh);

            }
                        
            if (null != jc_jmParamCondition.Jkdabh &&  ""!= jc_jmParamCondition.Jkdabh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Direction = ParameterDirection.Input;
                pJkdabh.Value = jc_jmParamCondition.Jkdabh;
                sqlparams.Add(pJkdabh);

            }
                        
            if (null != jc_jmParamCondition.Pym &&  ""!= jc_jmParamCondition.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_jmParamCondition.Pym;
                sqlparams.Add(pPym);

            }
                        
            if (null != jc_jmParamCondition.Wbm &&  ""!= jc_jmParamCondition.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_jmParamCondition.Wbm;
                sqlparams.Add(pWbm);

            }
                        
            if (null != jc_jmParamCondition.Zfbz &&  ""!= jc_jmParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_jmParamCondition.Zfbz;
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
        /// <returns>Jc_jm</returns>
        public Jc_jm findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_JM A ");
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
        /// <param name="jc_jmParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_jmParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_jm对象集合list</returns>
        public List<object> find(Jc_jm jc_jmParam, Model.Common.PageInfo page,Jc_jm jc_jmParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Jc_jm对象，标示查询所有数据
            if (null == jc_jmParam)
            {
                jc_jmParam = new Jc_jm();
            }
            if (null!=jc_jmParam.Id&&""!=jc_jmParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Jc_jm> jc_jmParamList = new List<Jc_jm>();//接收查询出的Jc_jm对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Jc_jm jc_jmParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_JM A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != jc_jmParam.Sfzh && "" != jc_jmParam.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Direction = ParameterDirection.Input;
                pSfzh.Value = jc_jmParam.Sfzh;
                sqlparams.Add(pSfzh);
            }
                
            if (null != jc_jmParam.Xm && "" != jc_jmParam.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Direction = ParameterDirection.Input;
                pXm.Value = jc_jmParam.Xm;
                sqlparams.Add(pXm);
            }
                
            if (null != jc_jmParam.Xb_code && "" != jc_jmParam.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Direction = ParameterDirection.Input;
                pXb_code.Value = jc_jmParam.Xb_code;
                sqlparams.Add(pXb_code);
            }
                
                if (DateTime.MinValue != jc_jmParam.Csrq &&null != jc_jmParam.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Direction = ParameterDirection.Input;
                pCsrq.Value = jc_jmParam.Csrq;
                sqlparams.Add(pCsrq);
                }
                
            if (null != jc_jmParam.Mz_code && "" != jc_jmParam.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Direction = ParameterDirection.Input;
                pMz_code.Value = jc_jmParam.Mz_code;
                sqlparams.Add(pMz_code);
            }
                
            if (null != jc_jmParam.Xx_code && "" != jc_jmParam.Xx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Direction = ParameterDirection.Input;
                pXx_code.Value = jc_jmParam.Xx_code;
                sqlparams.Add(pXx_code);
            }
                
            if (null != jc_jmParam.Rh_code && "" != jc_jmParam.Rh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Direction = ParameterDirection.Input;
                pRh_code.Value = jc_jmParam.Rh_code;
                sqlparams.Add(pRh_code);
            }
                
            if (null != jc_jmParam.Csdz && "" != jc_jmParam.Csdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Direction = ParameterDirection.Input;
                pCsdz.Value = jc_jmParam.Csdz;
                sqlparams.Add(pCsdz);
            }
                
            if (null != jc_jmParam.Hjdz && "" != jc_jmParam.Hjdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Direction = ParameterDirection.Input;
                pHjdz.Value = jc_jmParam.Hjdz;
                sqlparams.Add(pHjdz);
            }
                
            if (null != jc_jmParam.Xzz_xzqh && "" != jc_jmParam.Xzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Direction = ParameterDirection.Input;
                pXzz_xzqh.Value = jc_jmParam.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);
            }
                
            if (null != jc_jmParam.Xzz_xiang_xi_di_zhi && "" != jc_jmParam.Xzz_xiang_xi_di_zhi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                pXzz_xiang_xi_di_zhi.Value = jc_jmParam.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);
            }
                
            if (null != jc_jmParam.Gzdw_xx && "" != jc_jmParam.Gzdw_xx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Direction = ParameterDirection.Input;
                pGzdw_xx.Value = jc_jmParam.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);
            }
                
            if (null != jc_jmParam.Zy_code && "" != jc_jmParam.Zy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Direction = ParameterDirection.Input;
                pZy_code.Value = jc_jmParam.Zy_code;
                sqlparams.Add(pZy_code);
            }
                
            if (null != jc_jmParam.Zy && "" != jc_jmParam.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Direction = ParameterDirection.Input;
                pZy.Value = jc_jmParam.Zy;
                sqlparams.Add(pZy);
            }
                
            if (null != jc_jmParam.Wh_code && "" != jc_jmParam.Wh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Direction = ParameterDirection.Input;
                pWh_code.Value = jc_jmParam.Wh_code;
                sqlparams.Add(pWh_code);
            }
                
            if (null != jc_jmParam.Hyzk_code && "" != jc_jmParam.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Direction = ParameterDirection.Input;
                pHyzk_code.Value = jc_jmParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
            }
                
            if (null != jc_jmParam.Lxdh && "" != jc_jmParam.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Direction = ParameterDirection.Input;
                pLxdh.Value = jc_jmParam.Lxdh;
                sqlparams.Add(pLxdh);
            }
                
            if (null != jc_jmParam.Jhr_xm && "" != jc_jmParam.Jhr_xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Direction = ParameterDirection.Input;
                pJhr_xm.Value = jc_jmParam.Jhr_xm;
                sqlparams.Add(pJhr_xm);
            }
                
            if (null != jc_jmParam.Jhr_dh && "" != jc_jmParam.Jhr_dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Direction = ParameterDirection.Input;
                pJhr_dh.Value = jc_jmParam.Jhr_dh;
                sqlparams.Add(pJhr_dh);
            }
                
            if (null != jc_jmParam.Nhbm && "" != jc_jmParam.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Direction = ParameterDirection.Input;
                pNhbm.Value = jc_jmParam.Nhbm;
                sqlparams.Add(pNhbm);
            }
                
            if (null != jc_jmParam.Ybkh && "" != jc_jmParam.Ybkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Direction = ParameterDirection.Input;
                pYbkh.Value = jc_jmParam.Ybkh;
                sqlparams.Add(pYbkh);
            }
                
            if (null != jc_jmParam.Cjkh && "" != jc_jmParam.Cjkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Direction = ParameterDirection.Input;
                pCjkh.Value = jc_jmParam.Cjkh;
                sqlparams.Add(pCjkh);
            }
                
            if (null != jc_jmParam.Zfzh && "" != jc_jmParam.Zfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Direction = ParameterDirection.Input;
                pZfzh.Value = jc_jmParam.Zfzh;
                sqlparams.Add(pZfzh);
            }
                
            if (null != jc_jmParam.Jkdabh && "" != jc_jmParam.Jkdabh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Direction = ParameterDirection.Input;
                pJkdabh.Value = jc_jmParam.Jkdabh;
                sqlparams.Add(pJkdabh);
            }
                
            if (null != jc_jmParam.Pym && "" != jc_jmParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Direction = ParameterDirection.Input;
                pPym.Value = jc_jmParam.Pym;
                sqlparams.Add(pPym);
            }
                
            if (null != jc_jmParam.Wbm && "" != jc_jmParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Direction = ParameterDirection.Input;
                pWbm.Value = jc_jmParam.Wbm;
                sqlparams.Add(pWbm);
            }
                
            if (null != jc_jmParam.Zfbz && "" != jc_jmParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = jc_jmParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(jc_jmParamLike!=null)
            {

                if (null != jc_jmParamLike.Sfzh && "" != jc_jmParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_jmParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }
                
                if (null != jc_jmParamLike.Xm && "" != jc_jmParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_jmParamLike.Xm;
                    sqlparams.Add(pXm);
                }
                
                if (null != jc_jmParamLike.Xb_code && "" != jc_jmParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_jmParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }
                
                if (null != jc_jmParamLike.Mz_code && "" != jc_jmParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_jmParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }
                
                if (null != jc_jmParamLike.Xx_code && "" != jc_jmParamLike.Xx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XX_CODE LIKE '%'||:xx_code||'%' ");
                    OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                    pXx_code.Direction = ParameterDirection.Input;
                    pXx_code.Value = jc_jmParamLike.Xx_code;
                    sqlparams.Add(pXx_code);
                }
                
                if (null != jc_jmParamLike.Rh_code && "" != jc_jmParamLike.Rh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RH_CODE LIKE '%'||:rh_code||'%' ");
                    OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                    pRh_code.Direction = ParameterDirection.Input;
                    pRh_code.Value = jc_jmParamLike.Rh_code;
                    sqlparams.Add(pRh_code);
                }
                
                if (null != jc_jmParamLike.Csdz && "" != jc_jmParamLike.Csdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSDZ LIKE '%'||:csdz||'%' ");
                    OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                    pCsdz.Direction = ParameterDirection.Input;
                    pCsdz.Value = jc_jmParamLike.Csdz;
                    sqlparams.Add(pCsdz);
                }
                
                if (null != jc_jmParamLike.Hjdz && "" != jc_jmParamLike.Hjdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HJDZ LIKE '%'||:hjdz||'%' ");
                    OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                    pHjdz.Direction = ParameterDirection.Input;
                    pHjdz.Value = jc_jmParamLike.Hjdz;
                    sqlparams.Add(pHjdz);
                }
                
                if (null != jc_jmParamLike.Xzz_xzqh && "" != jc_jmParamLike.Xzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XZQH LIKE '%'||:xzz_xzqh||'%' ");
                    OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                    pXzz_xzqh.Direction = ParameterDirection.Input;
                    pXzz_xzqh.Value = jc_jmParamLike.Xzz_xzqh;
                    sqlparams.Add(pXzz_xzqh);
                }
                
                if (null != jc_jmParamLike.Xzz_xiang_xi_di_zhi && "" != jc_jmParamLike.Xzz_xiang_xi_di_zhi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XIANG_XI_DI_ZHI LIKE '%'||:xzz_xiang_xi_di_zhi||'%' ");
                    OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                    pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                    pXzz_xiang_xi_di_zhi.Value = jc_jmParamLike.Xzz_xiang_xi_di_zhi;
                    sqlparams.Add(pXzz_xiang_xi_di_zhi);
                }
                
                if (null != jc_jmParamLike.Gzdw_xx && "" != jc_jmParamLike.Gzdw_xx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GZDW_XX LIKE '%'||:gzdw_xx||'%' ");
                    OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                    pGzdw_xx.Direction = ParameterDirection.Input;
                    pGzdw_xx.Value = jc_jmParamLike.Gzdw_xx;
                    sqlparams.Add(pGzdw_xx);
                }
                
                if (null != jc_jmParamLike.Zy_code && "" != jc_jmParamLike.Zy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY_CODE LIKE '%'||:zy_code||'%' ");
                    OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                    pZy_code.Direction = ParameterDirection.Input;
                    pZy_code.Value = jc_jmParamLike.Zy_code;
                    sqlparams.Add(pZy_code);
                }
                
                if (null != jc_jmParamLike.Zy && "" != jc_jmParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_jmParamLike.Zy;
                    sqlparams.Add(pZy);
                }
                
                if (null != jc_jmParamLike.Wh_code && "" != jc_jmParamLike.Wh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WH_CODE LIKE '%'||:wh_code||'%' ");
                    OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                    pWh_code.Direction = ParameterDirection.Input;
                    pWh_code.Value = jc_jmParamLike.Wh_code;
                    sqlparams.Add(pWh_code);
                }
                
                if (null != jc_jmParamLike.Hyzk_code && "" != jc_jmParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_jmParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_jmParamLike.Lxdh && "" != jc_jmParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_jmParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }
                
                if (null != jc_jmParamLike.Jhr_xm && "" != jc_jmParamLike.Jhr_xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_XM LIKE '%'||:jhr_xm||'%' ");
                    OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                    pJhr_xm.Direction = ParameterDirection.Input;
                    pJhr_xm.Value = jc_jmParamLike.Jhr_xm;
                    sqlparams.Add(pJhr_xm);
                }
                
                if (null != jc_jmParamLike.Jhr_dh && "" != jc_jmParamLike.Jhr_dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_DH LIKE '%'||:jhr_dh||'%' ");
                    OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                    pJhr_dh.Direction = ParameterDirection.Input;
                    pJhr_dh.Value = jc_jmParamLike.Jhr_dh;
                    sqlparams.Add(pJhr_dh);
                }
                
                if (null != jc_jmParamLike.Nhbm && "" != jc_jmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_jmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }
                
                if (null != jc_jmParamLike.Ybkh && "" != jc_jmParamLike.Ybkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBKH LIKE '%'||:ybkh||'%' ");
                    OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                    pYbkh.Direction = ParameterDirection.Input;
                    pYbkh.Value = jc_jmParamLike.Ybkh;
                    sqlparams.Add(pYbkh);
                }
                
                if (null != jc_jmParamLike.Cjkh && "" != jc_jmParamLike.Cjkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJKH LIKE '%'||:cjkh||'%' ");
                    OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                    pCjkh.Direction = ParameterDirection.Input;
                    pCjkh.Value = jc_jmParamLike.Cjkh;
                    sqlparams.Add(pCjkh);
                }
                
                if (null != jc_jmParamLike.Zfzh && "" != jc_jmParamLike.Zfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFZH LIKE '%'||:zfzh||'%' ");
                    OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                    pZfzh.Direction = ParameterDirection.Input;
                    pZfzh.Value = jc_jmParamLike.Zfzh;
                    sqlparams.Add(pZfzh);
                }
                
                if (null != jc_jmParamLike.Jkdabh && "" != jc_jmParamLike.Jkdabh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JKDABH LIKE '%'||:jkdabh||'%' ");
                    OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                    pJkdabh.Direction = ParameterDirection.Input;
                    pJkdabh.Value = jc_jmParamLike.Jkdabh;
                    sqlparams.Add(pJkdabh);
                }
                
                if (null != jc_jmParamLike.Pym && "" != jc_jmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_jmParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_jmParamLike.Wbm && "" != jc_jmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_jmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_jmParamLike.Zfbz && "" != jc_jmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_jmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_jm>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_jm>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //jc_jmParamList.Add(this.dataSetContactObjectsToModel(row));
                jc_jmParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_jmParamList);//把List<Jc_jm>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Jc_jm jc_jmParam,Jc_jm jc_jmParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Jc_jm对象，标示查询所有数据
            if (null == jc_jmParam)
            {
                jc_jmParam = new Jc_jm();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM JC_JM A");
                if (null != jc_jmParam.Sfzh && "" != jc_jmParam.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Value = jc_jmParam.Sfzh;
                sqlparams.Add(pSfzh);
                }
                
                if (null != jc_jmParam.Xm && "" != jc_jmParam.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Value = jc_jmParam.Xm;
                sqlparams.Add(pXm);
                }
                
                if (null != jc_jmParam.Xb_code && "" != jc_jmParam.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Value = jc_jmParam.Xb_code;
                sqlparams.Add(pXb_code);
                }
                
                if (DateTime.MinValue != jc_jmParam.Csrq &&null != jc_jmParam.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Value = jc_jmParam.Csrq;
                sqlparams.Add(pCsrq);
                }
                
                if (null != jc_jmParam.Mz_code && "" != jc_jmParam.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Value = jc_jmParam.Mz_code;
                sqlparams.Add(pMz_code);
                }
                
                if (null != jc_jmParam.Xx_code && "" != jc_jmParam.Xx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XX_CODE=:xx_code ");
                    OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Value = jc_jmParam.Xx_code;
                sqlparams.Add(pXx_code);
                }
                
                if (null != jc_jmParam.Rh_code && "" != jc_jmParam.Rh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RH_CODE=:rh_code ");
                    OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Value = jc_jmParam.Rh_code;
                sqlparams.Add(pRh_code);
                }
                
                if (null != jc_jmParam.Csdz && "" != jc_jmParam.Csdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSDZ=:csdz ");
                    OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Value = jc_jmParam.Csdz;
                sqlparams.Add(pCsdz);
                }
                
                if (null != jc_jmParam.Hjdz && "" != jc_jmParam.Hjdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HJDZ=:hjdz ");
                    OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Value = jc_jmParam.Hjdz;
                sqlparams.Add(pHjdz);
                }
                
                if (null != jc_jmParam.Xzz_xzqh && "" != jc_jmParam.Xzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XZQH=:xzz_xzqh ");
                    OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Value = jc_jmParam.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);
                }
                
                if (null != jc_jmParam.Xzz_xiang_xi_di_zhi && "" != jc_jmParam.Xzz_xiang_xi_di_zhi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                    OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Value = jc_jmParam.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);
                }
                
                if (null != jc_jmParam.Gzdw_xx && "" != jc_jmParam.Gzdw_xx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GZDW_XX=:gzdw_xx ");
                    OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Value = jc_jmParam.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);
                }
                
                if (null != jc_jmParam.Zy_code && "" != jc_jmParam.Zy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY_CODE=:zy_code ");
                    OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Value = jc_jmParam.Zy_code;
                sqlparams.Add(pZy_code);
                }
                
                if (null != jc_jmParam.Zy && "" != jc_jmParam.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Value = jc_jmParam.Zy;
                sqlparams.Add(pZy);
                }
                
                if (null != jc_jmParam.Wh_code && "" != jc_jmParam.Wh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WH_CODE=:wh_code ");
                    OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Value = jc_jmParam.Wh_code;
                sqlparams.Add(pWh_code);
                }
                
                if (null != jc_jmParam.Hyzk_code && "" != jc_jmParam.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Value = jc_jmParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_jmParam.Lxdh && "" != jc_jmParam.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Value = jc_jmParam.Lxdh;
                sqlparams.Add(pLxdh);
                }
                
                if (null != jc_jmParam.Jhr_xm && "" != jc_jmParam.Jhr_xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_XM=:jhr_xm ");
                    OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Value = jc_jmParam.Jhr_xm;
                sqlparams.Add(pJhr_xm);
                }
                
                if (null != jc_jmParam.Jhr_dh && "" != jc_jmParam.Jhr_dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_DH=:jhr_dh ");
                    OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Value = jc_jmParam.Jhr_dh;
                sqlparams.Add(pJhr_dh);
                }
                
                if (null != jc_jmParam.Nhbm && "" != jc_jmParam.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM=:nhbm ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Value = jc_jmParam.Nhbm;
                sqlparams.Add(pNhbm);
                }
                
                if (null != jc_jmParam.Ybkh && "" != jc_jmParam.Ybkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBKH=:ybkh ");
                    OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Value = jc_jmParam.Ybkh;
                sqlparams.Add(pYbkh);
                }
                
                if (null != jc_jmParam.Cjkh && "" != jc_jmParam.Cjkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJKH=:cjkh ");
                    OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Value = jc_jmParam.Cjkh;
                sqlparams.Add(pCjkh);
                }
                
                if (null != jc_jmParam.Zfzh && "" != jc_jmParam.Zfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFZH=:zfzh ");
                    OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Value = jc_jmParam.Zfzh;
                sqlparams.Add(pZfzh);
                }
                
                if (null != jc_jmParam.Jkdabh && "" != jc_jmParam.Jkdabh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JKDABH=:jkdabh ");
                    OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Value = jc_jmParam.Jkdabh;
                sqlparams.Add(pJkdabh);
                }
                
                if (null != jc_jmParam.Pym && "" != jc_jmParam.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_jmParam.Pym;
                sqlparams.Add(pPym);
                }
                
                if (null != jc_jmParam.Wbm && "" != jc_jmParam.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_jmParam.Wbm;
                sqlparams.Add(pWbm);
                }
                
                if (null != jc_jmParam.Zfbz && "" != jc_jmParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_jmParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(jc_jmParamLike!=null)
            {

                if (null != jc_jmParamLike.Sfzh && "" != jc_jmParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_jmParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }
                
                if (null != jc_jmParamLike.Xm && "" != jc_jmParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_jmParamLike.Xm;
                    sqlparams.Add(pXm);
                }
                
                if (null != jc_jmParamLike.Xb_code && "" != jc_jmParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_jmParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }
                
                if (null != jc_jmParamLike.Mz_code && "" != jc_jmParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_jmParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }
                
                if (null != jc_jmParamLike.Xx_code && "" != jc_jmParamLike.Xx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XX_CODE LIKE '%'||:xx_code||'%' ");
                    OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                    pXx_code.Direction = ParameterDirection.Input;
                    pXx_code.Value = jc_jmParamLike.Xx_code;
                    sqlparams.Add(pXx_code);
                }
                
                if (null != jc_jmParamLike.Rh_code && "" != jc_jmParamLike.Rh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RH_CODE LIKE '%'||:rh_code||'%' ");
                    OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                    pRh_code.Direction = ParameterDirection.Input;
                    pRh_code.Value = jc_jmParamLike.Rh_code;
                    sqlparams.Add(pRh_code);
                }
                
                if (null != jc_jmParamLike.Csdz && "" != jc_jmParamLike.Csdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSDZ LIKE '%'||:csdz||'%' ");
                    OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                    pCsdz.Direction = ParameterDirection.Input;
                    pCsdz.Value = jc_jmParamLike.Csdz;
                    sqlparams.Add(pCsdz);
                }
                
                if (null != jc_jmParamLike.Hjdz && "" != jc_jmParamLike.Hjdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HJDZ LIKE '%'||:hjdz||'%' ");
                    OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                    pHjdz.Direction = ParameterDirection.Input;
                    pHjdz.Value = jc_jmParamLike.Hjdz;
                    sqlparams.Add(pHjdz);
                }
                
                if (null != jc_jmParamLike.Xzz_xzqh && "" != jc_jmParamLike.Xzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XZQH LIKE '%'||:xzz_xzqh||'%' ");
                    OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                    pXzz_xzqh.Direction = ParameterDirection.Input;
                    pXzz_xzqh.Value = jc_jmParamLike.Xzz_xzqh;
                    sqlparams.Add(pXzz_xzqh);
                }
                
                if (null != jc_jmParamLike.Xzz_xiang_xi_di_zhi && "" != jc_jmParamLike.Xzz_xiang_xi_di_zhi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XIANG_XI_DI_ZHI LIKE '%'||:xzz_xiang_xi_di_zhi||'%' ");
                    OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                    pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                    pXzz_xiang_xi_di_zhi.Value = jc_jmParamLike.Xzz_xiang_xi_di_zhi;
                    sqlparams.Add(pXzz_xiang_xi_di_zhi);
                }
                
                if (null != jc_jmParamLike.Gzdw_xx && "" != jc_jmParamLike.Gzdw_xx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GZDW_XX LIKE '%'||:gzdw_xx||'%' ");
                    OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                    pGzdw_xx.Direction = ParameterDirection.Input;
                    pGzdw_xx.Value = jc_jmParamLike.Gzdw_xx;
                    sqlparams.Add(pGzdw_xx);
                }
                
                if (null != jc_jmParamLike.Zy_code && "" != jc_jmParamLike.Zy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY_CODE LIKE '%'||:zy_code||'%' ");
                    OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                    pZy_code.Direction = ParameterDirection.Input;
                    pZy_code.Value = jc_jmParamLike.Zy_code;
                    sqlparams.Add(pZy_code);
                }
                
                if (null != jc_jmParamLike.Zy && "" != jc_jmParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_jmParamLike.Zy;
                    sqlparams.Add(pZy);
                }
                
                if (null != jc_jmParamLike.Wh_code && "" != jc_jmParamLike.Wh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WH_CODE LIKE '%'||:wh_code||'%' ");
                    OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                    pWh_code.Direction = ParameterDirection.Input;
                    pWh_code.Value = jc_jmParamLike.Wh_code;
                    sqlparams.Add(pWh_code);
                }
                
                if (null != jc_jmParamLike.Hyzk_code && "" != jc_jmParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_jmParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }
                
                if (null != jc_jmParamLike.Lxdh && "" != jc_jmParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_jmParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }
                
                if (null != jc_jmParamLike.Jhr_xm && "" != jc_jmParamLike.Jhr_xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_XM LIKE '%'||:jhr_xm||'%' ");
                    OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                    pJhr_xm.Direction = ParameterDirection.Input;
                    pJhr_xm.Value = jc_jmParamLike.Jhr_xm;
                    sqlparams.Add(pJhr_xm);
                }
                
                if (null != jc_jmParamLike.Jhr_dh && "" != jc_jmParamLike.Jhr_dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_DH LIKE '%'||:jhr_dh||'%' ");
                    OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                    pJhr_dh.Direction = ParameterDirection.Input;
                    pJhr_dh.Value = jc_jmParamLike.Jhr_dh;
                    sqlparams.Add(pJhr_dh);
                }
                
                if (null != jc_jmParamLike.Nhbm && "" != jc_jmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_jmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }
                
                if (null != jc_jmParamLike.Ybkh && "" != jc_jmParamLike.Ybkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBKH LIKE '%'||:ybkh||'%' ");
                    OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                    pYbkh.Direction = ParameterDirection.Input;
                    pYbkh.Value = jc_jmParamLike.Ybkh;
                    sqlparams.Add(pYbkh);
                }
                
                if (null != jc_jmParamLike.Cjkh && "" != jc_jmParamLike.Cjkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJKH LIKE '%'||:cjkh||'%' ");
                    OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                    pCjkh.Direction = ParameterDirection.Input;
                    pCjkh.Value = jc_jmParamLike.Cjkh;
                    sqlparams.Add(pCjkh);
                }
                
                if (null != jc_jmParamLike.Zfzh && "" != jc_jmParamLike.Zfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFZH LIKE '%'||:zfzh||'%' ");
                    OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                    pZfzh.Direction = ParameterDirection.Input;
                    pZfzh.Value = jc_jmParamLike.Zfzh;
                    sqlparams.Add(pZfzh);
                }
                
                if (null != jc_jmParamLike.Jkdabh && "" != jc_jmParamLike.Jkdabh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JKDABH LIKE '%'||:jkdabh||'%' ");
                    OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                    pJkdabh.Direction = ParameterDirection.Input;
                    pJkdabh.Value = jc_jmParamLike.Jkdabh;
                    sqlparams.Add(pJkdabh);
                }
                
                if (null != jc_jmParamLike.Pym && "" != jc_jmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_jmParamLike.Pym;
                    sqlparams.Add(pPym);
                }
                
                if (null != jc_jmParamLike.Wbm && "" != jc_jmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_jmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }
                
                if (null != jc_jmParamLike.Zfbz && "" != jc_jmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_jmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }
this.b_isWhere = false;return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="jc_jmParam"></param>
        /// <returns></returns>
        public bool save(Jc_jm jc_jmParam,OracleConnection con)
        {
            if ("" != jc_jmParam.Id && null != jc_jmParam.Id)
            {
                //修改
                return this.updateById(jc_jmParam,con);
            }
            else
            {
                //新增
                return this.insert(jc_jmParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_jm dataSetToModel(DataRow row)
        {
            Jc_jm jc_jmParam = new Jc_jm();
            jc_jmParam.Id = Convert.ToString(row["ID"]).Trim(); 
            jc_jmParam.Sfzh = Convert.ToString(row["SFZH"]).Trim(); 
            jc_jmParam.Xm = Convert.ToString(row["XM"]).Trim(); 
            jc_jmParam.Xb_code = Convert.ToString(row["XB_CODE"]).Trim(); 
            jc_jmParam.Csrq =  (DateTime?)this.convertDBNullValue(row["CSRQ"]);
            jc_jmParam.Mz_code = Convert.ToString(row["MZ_CODE"]).Trim(); 
            jc_jmParam.Xx_code = Convert.ToString(row["XX_CODE"]).Trim(); 
            jc_jmParam.Rh_code = Convert.ToString(row["RH_CODE"]).Trim(); 
            jc_jmParam.Csdz = Convert.ToString(row["CSDZ"]).Trim(); 
            jc_jmParam.Hjdz = Convert.ToString(row["HJDZ"]).Trim(); 
            jc_jmParam.Xzz_xzqh = Convert.ToString(row["XZZ_XZQH"]).Trim(); 
            jc_jmParam.Xzz_xiang_xi_di_zhi = Convert.ToString(row["XZZ_XIANG_XI_DI_ZHI"]).Trim(); 
            jc_jmParam.Gzdw_xx = Convert.ToString(row["GZDW_XX"]).Trim(); 
            jc_jmParam.Zy_code = Convert.ToString(row["ZY_CODE"]).Trim(); 
            jc_jmParam.Zy = Convert.ToString(row["ZY"]).Trim(); 
            jc_jmParam.Wh_code = Convert.ToString(row["WH_CODE"]).Trim(); 
            jc_jmParam.Hyzk_code = Convert.ToString(row["HYZK_CODE"]).Trim(); 
            jc_jmParam.Lxdh = Convert.ToString(row["LXDH"]).Trim(); 
            jc_jmParam.Jhr_xm = Convert.ToString(row["JHR_XM"]).Trim(); 
            jc_jmParam.Jhr_dh = Convert.ToString(row["JHR_DH"]).Trim(); 
            jc_jmParam.Nhbm = Convert.ToString(row["NHBM"]).Trim(); 
            jc_jmParam.Ybkh = Convert.ToString(row["YBKH"]).Trim(); 
            jc_jmParam.Cjkh = Convert.ToString(row["CJKH"]).Trim(); 
            jc_jmParam.Zfzh = Convert.ToString(row["ZFZH"]).Trim(); 
            jc_jmParam.Jkdabh = Convert.ToString(row["JKDABH"]).Trim(); 
            jc_jmParam.Pym = Convert.ToString(row["PYM"]).Trim(); 
            jc_jmParam.Wbm = Convert.ToString(row["WBM"]).Trim(); 
            jc_jmParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return jc_jmParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Jc_jm dataSetContactObjectsToModel(DataRow row)
        {
            Jc_jm jc_jmParam = this.dataSetToModel(row);

            //添加代码类别实体对象,性别（关联代码表）对象
            Jc_code xbCode = new Jc_code();
            xbCode.Id = Convert.ToString(row["XB_CODE_ID"]).Trim();
            xbCode.Name = Convert.ToString(row["XB_CODE_NAME"]).Trim();
            xbCode.Value = Convert.ToString(row["XB_CODE_VALUE"]).Trim();
            xbCode.Fk_code_type = Convert.ToString(row["XB_CODE_FKCODETYPE"]).Trim();
            xbCode.Zfbz = Convert.ToString(row["XB_CODE_ZFBZ"]).Trim();
            xbCode.Remark = Convert.ToString(row["XB_CODE_REMARK"]).Trim();
            jc_jmParam.XbCode = xbCode;

            //添加代码类别实体对象,民族（关联代码表）对象
            Jc_code mzCode = new Jc_code();
            mzCode.Id = Convert.ToString(row["MZ_CODE_ID"]).Trim();
            mzCode.Name = Convert.ToString(row["MZ_CODE_NAME"]).Trim();
            mzCode.Value = Convert.ToString(row["MZ_CODE_VALUE"]).Trim();
            mzCode.Fk_code_type = Convert.ToString(row["MZ_CODE_FKCODETYPE"]).Trim();
            mzCode.Zfbz = Convert.ToString(row["MZ_CODE_ZFBZ"]).Trim();
            mzCode.Remark = Convert.ToString(row["MZ_CODE_REMARK"]).Trim();
            jc_jmParam.MzCode = mzCode;

            //添加代码类别实体对象,血型（关联代码表）对象
            Jc_code xxCode = new Jc_code();
            xxCode.Id = Convert.ToString(row["XX_CODE_ID"]).Trim();
            xxCode.Name = Convert.ToString(row["XX_CODE_NAME"]).Trim();
            xxCode.Value = Convert.ToString(row["XX_CODE_VALUE"]).Trim();
            xxCode.Fk_code_type = Convert.ToString(row["XX_CODE_FKCODETYPE"]).Trim();
            xxCode.Zfbz = Convert.ToString(row["XX_CODE_ZFBZ"]).Trim();
            xxCode.Remark = Convert.ToString(row["XX_CODE_REMARK"]).Trim();
            jc_jmParam.XxCode = xxCode;

            //添加代码类别实体对象,rh代码（关联代码表）对象
            Jc_code rhCode = new Jc_code();
            rhCode.Id = Convert.ToString(row["RH_CODE_ID"]).Trim();
            rhCode.Name = Convert.ToString(row["RH_CODE_NAME"]).Trim();
            rhCode.Value = Convert.ToString(row["RH_CODE_VALUE"]).Trim();
            rhCode.Fk_code_type = Convert.ToString(row["RH_CODE_FKCODETYPE"]).Trim();
            rhCode.Zfbz = Convert.ToString(row["RH_CODE_ZFBZ"]).Trim();
            rhCode.Remark = Convert.ToString(row["RH_CODE_REMARK"]).Trim();
            jc_jmParam.RhCode = rhCode;

            //添加代码类别实体对象,职业代码（暂做保留）对象
            Jc_code zyCode = new Jc_code();
            zyCode.Id = Convert.ToString(row["ZY_CODE_ID"]).Trim();
            zyCode.Name = Convert.ToString(row["ZY_CODE_NAME"]).Trim();
            zyCode.Value = Convert.ToString(row["ZY_CODE_VALUE"]).Trim();
            zyCode.Fk_code_type = Convert.ToString(row["ZY_CODE_FKCODETYPE"]).Trim();
            zyCode.Zfbz = Convert.ToString(row["ZY_CODE_ZFBZ"]).Trim();
            zyCode.Remark = Convert.ToString(row["ZY_CODE_REMARK"]).Trim();
            jc_jmParam.ZyCode = zyCode;

            //添加代码类别实体对象,文化代码（关联代码表）对象
            Jc_code whCode = new Jc_code();
            whCode.Id = Convert.ToString(row["WH_CODE_ID"]).Trim();
            whCode.Name = Convert.ToString(row["WH_CODE_NAME"]).Trim();
            whCode.Value = Convert.ToString(row["WH_CODE_VALUE"]).Trim();
            whCode.Fk_code_type = Convert.ToString(row["WH_CODE_FKCODETYPE"]).Trim();
            whCode.Zfbz = Convert.ToString(row["WH_CODE_ZFBZ"]).Trim();
            whCode.Remark = Convert.ToString(row["WH_CODE_REMARK"]).Trim();
            jc_jmParam.WhCode = whCode;

            //添加代码类别实体对象,婚姻状况（关联代码表）对象
            Jc_code hyzkCode = new Jc_code();
            hyzkCode.Id = Convert.ToString(row["HYZK_CODE_ID"]).Trim();
            hyzkCode.Name = Convert.ToString(row["HYZK_CODE_NAME"]).Trim();
            hyzkCode.Value = Convert.ToString(row["HYZK_CODE_VALUE"]).Trim();
            hyzkCode.Fk_code_type = Convert.ToString(row["HYZK_CODE_FKCODETYPE"]).Trim();
            hyzkCode.Zfbz = Convert.ToString(row["HYZK_CODE_ZFBZ"]).Trim();
            hyzkCode.Remark = Convert.ToString(row["HYZK_CODE_REMARK"]).Trim();
            jc_jmParam.HyzkCode = hyzkCode;

            return jc_jmParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Jc_jm</returns>
        public Jc_jm findContactObjectsById(string id)
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
            ,TT_XX_CODE.ID AS XX_CODE_ID,TT_XX_CODE.NAME AS XX_CODE_NAME,TT_XX_CODE.VALUE AS XX_CODE_VALUE,TT_XX_CODE.FK_CODE_TYPE AS XX_CODE_FKCODETYPE,TT_XX_CODE.ZFBZ AS XX_CODE_ZFBZ,TT_XX_CODE.REMARK AS XX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_RH_CODE.ID AS RH_CODE_ID,TT_RH_CODE.NAME AS RH_CODE_NAME,TT_RH_CODE.VALUE AS RH_CODE_VALUE,TT_RH_CODE.FK_CODE_TYPE AS RH_CODE_FKCODETYPE,TT_RH_CODE.ZFBZ AS RH_CODE_ZFBZ,TT_RH_CODE.REMARK AS RH_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZY_CODE.ID AS ZY_CODE_ID,TT_ZY_CODE.NAME AS ZY_CODE_NAME,TT_ZY_CODE.VALUE AS ZY_CODE_VALUE,TT_ZY_CODE.FK_CODE_TYPE AS ZY_CODE_FKCODETYPE,TT_ZY_CODE.ZFBZ AS ZY_CODE_ZFBZ,TT_ZY_CODE.REMARK AS ZY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_WH_CODE.ID AS WH_CODE_ID,TT_WH_CODE.NAME AS WH_CODE_NAME,TT_WH_CODE.VALUE AS WH_CODE_VALUE,TT_WH_CODE.FK_CODE_TYPE AS WH_CODE_FKCODETYPE,TT_WH_CODE.ZFBZ AS WH_CODE_ZFBZ,TT_WH_CODE.REMARK AS WH_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_HYZK_CODE.ID AS HYZK_CODE_ID,TT_HYZK_CODE.NAME AS HYZK_CODE_NAME,TT_HYZK_CODE.VALUE AS HYZK_CODE_VALUE,TT_HYZK_CODE.FK_CODE_TYPE AS HYZK_CODE_FKCODETYPE,TT_HYZK_CODE.ZFBZ AS HYZK_CODE_ZFBZ,TT_HYZK_CODE.REMARK AS HYZK_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_JM A ");
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
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5103_02ABO血型代码 + @"')) TT_XX_CODE
                        ON A.XX_CODE = TT_XX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.RH代码 + @"')) TT_RH_CODE
                        ON A.RH_CODE = TT_RH_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV0207_01职业代码 + @"')) TT_ZY_CODE
                        ON A.ZY_CODE = TT_ZY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.学历类型值 + @"')) TT_WH_CODE
                        ON A.WH_CODE = TT_WH_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.婚姻状况类型值 + @"')) TT_HYZK_CODE
                        ON A.HYZK_CODE = TT_HYZK_CODE.VALUE
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
        /// <param name="jc_jmParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="jc_jmParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Jc_jm对象集合list</returns>
        public List<object> findContactObjects(Jc_jm jc_jmParam, Model.Common.PageInfo page, Jc_jm jc_jmParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Jc_jm对象，标示查询所有数据
            if (null == jc_jmParam)
            {
                jc_jmParam = new Jc_jm();
            }
            if (null != jc_jmParam.Id && "" != jc_jmParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Jc_jm> jc_jmParamList = new List<Jc_jm>();//接收查询出的Jc_jm对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Jc_jm jc_jmParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_XB_CODE.ID AS XB_CODE_ID,TT_XB_CODE.NAME AS XB_CODE_NAME,TT_XB_CODE.VALUE AS XB_CODE_VALUE,TT_XB_CODE.FK_CODE_TYPE AS XB_CODE_FKCODETYPE,TT_XB_CODE.ZFBZ AS XB_CODE_ZFBZ,TT_XB_CODE.REMARK AS XB_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_MZ_CODE.ID AS MZ_CODE_ID,TT_MZ_CODE.NAME AS MZ_CODE_NAME,TT_MZ_CODE.VALUE AS MZ_CODE_VALUE,TT_MZ_CODE.FK_CODE_TYPE AS MZ_CODE_FKCODETYPE,TT_MZ_CODE.ZFBZ AS MZ_CODE_ZFBZ,TT_MZ_CODE.REMARK AS MZ_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_XX_CODE.ID AS XX_CODE_ID,TT_XX_CODE.NAME AS XX_CODE_NAME,TT_XX_CODE.VALUE AS XX_CODE_VALUE,TT_XX_CODE.FK_CODE_TYPE AS XX_CODE_FKCODETYPE,TT_XX_CODE.ZFBZ AS XX_CODE_ZFBZ,TT_XX_CODE.REMARK AS XX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_RH_CODE.ID AS RH_CODE_ID,TT_RH_CODE.NAME AS RH_CODE_NAME,TT_RH_CODE.VALUE AS RH_CODE_VALUE,TT_RH_CODE.FK_CODE_TYPE AS RH_CODE_FKCODETYPE,TT_RH_CODE.ZFBZ AS RH_CODE_ZFBZ,TT_RH_CODE.REMARK AS RH_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_ZY_CODE.ID AS ZY_CODE_ID,TT_ZY_CODE.NAME AS ZY_CODE_NAME,TT_ZY_CODE.VALUE AS ZY_CODE_VALUE,TT_ZY_CODE.FK_CODE_TYPE AS ZY_CODE_FKCODETYPE,TT_ZY_CODE.ZFBZ AS ZY_CODE_ZFBZ,TT_ZY_CODE.REMARK AS ZY_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_WH_CODE.ID AS WH_CODE_ID,TT_WH_CODE.NAME AS WH_CODE_NAME,TT_WH_CODE.VALUE AS WH_CODE_VALUE,TT_WH_CODE.FK_CODE_TYPE AS WH_CODE_FKCODETYPE,TT_WH_CODE.ZFBZ AS WH_CODE_ZFBZ,TT_WH_CODE.REMARK AS WH_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_HYZK_CODE.ID AS HYZK_CODE_ID,TT_HYZK_CODE.NAME AS HYZK_CODE_NAME,TT_HYZK_CODE.VALUE AS HYZK_CODE_VALUE,TT_HYZK_CODE.FK_CODE_TYPE AS HYZK_CODE_FKCODETYPE,TT_HYZK_CODE.ZFBZ AS HYZK_CODE_ZFBZ,TT_HYZK_CODE.REMARK AS HYZK_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM JC_JM A ");
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
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV5103_02ABO血型代码 + @"')) TT_XX_CODE
                        ON A.XX_CODE = TT_XX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.RH代码 + @"')) TT_RH_CODE
                        ON A.RH_CODE = TT_RH_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.CV0207_01职业代码 + @"')) TT_ZY_CODE
                        ON A.ZY_CODE = TT_ZY_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.学历类型值 + @"')) TT_WH_CODE
                        ON A.WH_CODE = TT_WH_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.婚姻状况类型值 + @"')) TT_HYZK_CODE
                        ON A.HYZK_CODE = TT_HYZK_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != jc_jmParam.Sfzh && "" != jc_jmParam.Sfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.SFZH=:sfzh ");
                OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                pSfzh.Value = jc_jmParam.Sfzh;
                sqlparams.Add(pSfzh);
            }

            if (null != jc_jmParam.Xm && "" != jc_jmParam.Xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XM=:xm ");
                OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                pXm.Value = jc_jmParam.Xm;
                sqlparams.Add(pXm);
            }

            if (null != jc_jmParam.Xb_code && "" != jc_jmParam.Xb_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XB_CODE=:xb_code ");
                OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                pXb_code.Value = jc_jmParam.Xb_code;
                sqlparams.Add(pXb_code);
            }

            if (DateTime.MinValue != jc_jmParam.Csrq && null != jc_jmParam.Csrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CSRQ=:csrq ");
                OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                pCsrq.Value = jc_jmParam.Csrq;
                sqlparams.Add(pCsrq);
            }

            if (null != jc_jmParam.Mz_code && "" != jc_jmParam.Mz_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.MZ_CODE=:mz_code ");
                OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                pMz_code.Value = jc_jmParam.Mz_code;
                sqlparams.Add(pMz_code);
            }

            if (null != jc_jmParam.Xx_code && "" != jc_jmParam.Xx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XX_CODE=:xx_code ");
                OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                pXx_code.Value = jc_jmParam.Xx_code;
                sqlparams.Add(pXx_code);
            }

            if (null != jc_jmParam.Rh_code && "" != jc_jmParam.Rh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.RH_CODE=:rh_code ");
                OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                pRh_code.Value = jc_jmParam.Rh_code;
                sqlparams.Add(pRh_code);
            }

            if (null != jc_jmParam.Csdz && "" != jc_jmParam.Csdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CSDZ=:csdz ");
                OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                pCsdz.Value = jc_jmParam.Csdz;
                sqlparams.Add(pCsdz);
            }

            if (null != jc_jmParam.Hjdz && "" != jc_jmParam.Hjdz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HJDZ=:hjdz ");
                OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                pHjdz.Value = jc_jmParam.Hjdz;
                sqlparams.Add(pHjdz);
            }

            if (null != jc_jmParam.Xzz_xzqh && "" != jc_jmParam.Xzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XZZ_XZQH=:xzz_xzqh ");
                OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                pXzz_xzqh.Value = jc_jmParam.Xzz_xzqh;
                sqlparams.Add(pXzz_xzqh);
            }

            if (null != jc_jmParam.Xzz_xiang_xi_di_zhi && "" != jc_jmParam.Xzz_xiang_xi_di_zhi)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                pXzz_xiang_xi_di_zhi.Value = jc_jmParam.Xzz_xiang_xi_di_zhi;
                sqlparams.Add(pXzz_xiang_xi_di_zhi);
            }

            if (null != jc_jmParam.Gzdw_xx && "" != jc_jmParam.Gzdw_xx)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GZDW_XX=:gzdw_xx ");
                OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                pGzdw_xx.Value = jc_jmParam.Gzdw_xx;
                sqlparams.Add(pGzdw_xx);
            }

            if (null != jc_jmParam.Zy_code && "" != jc_jmParam.Zy_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY_CODE=:zy_code ");
                OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                pZy_code.Value = jc_jmParam.Zy_code;
                sqlparams.Add(pZy_code);
            }

            if (null != jc_jmParam.Zy && "" != jc_jmParam.Zy)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZY=:zy ");
                OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                pZy.Value = jc_jmParam.Zy;
                sqlparams.Add(pZy);
            }

            if (null != jc_jmParam.Wh_code && "" != jc_jmParam.Wh_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WH_CODE=:wh_code ");
                OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                pWh_code.Value = jc_jmParam.Wh_code;
                sqlparams.Add(pWh_code);
            }

            if (null != jc_jmParam.Hyzk_code && "" != jc_jmParam.Hyzk_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.HYZK_CODE=:hyzk_code ");
                OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                pHyzk_code.Value = jc_jmParam.Hyzk_code;
                sqlparams.Add(pHyzk_code);
            }

            if (null != jc_jmParam.Lxdh && "" != jc_jmParam.Lxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LXDH=:lxdh ");
                OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                pLxdh.Value = jc_jmParam.Lxdh;
                sqlparams.Add(pLxdh);
            }

            if (null != jc_jmParam.Jhr_xm && "" != jc_jmParam.Jhr_xm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JHR_XM=:jhr_xm ");
                OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                pJhr_xm.Value = jc_jmParam.Jhr_xm;
                sqlparams.Add(pJhr_xm);
            }

            if (null != jc_jmParam.Jhr_dh && "" != jc_jmParam.Jhr_dh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JHR_DH=:jhr_dh ");
                OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                pJhr_dh.Value = jc_jmParam.Jhr_dh;
                sqlparams.Add(pJhr_dh);
            }

            if (null != jc_jmParam.Nhbm && "" != jc_jmParam.Nhbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.NHBM=:nhbm ");
                OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                pNhbm.Value = jc_jmParam.Nhbm;
                sqlparams.Add(pNhbm);
            }

            if (null != jc_jmParam.Ybkh && "" != jc_jmParam.Ybkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.YBKH=:ybkh ");
                OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                pYbkh.Value = jc_jmParam.Ybkh;
                sqlparams.Add(pYbkh);
            }

            if (null != jc_jmParam.Cjkh && "" != jc_jmParam.Cjkh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.CJKH=:cjkh ");
                OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                pCjkh.Value = jc_jmParam.Cjkh;
                sqlparams.Add(pCjkh);
            }

            if (null != jc_jmParam.Zfzh && "" != jc_jmParam.Zfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFZH=:zfzh ");
                OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                pZfzh.Value = jc_jmParam.Zfzh;
                sqlparams.Add(pZfzh);
            }

            if (null != jc_jmParam.Jkdabh && "" != jc_jmParam.Jkdabh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.JKDABH=:jkdabh ");
                OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                pJkdabh.Value = jc_jmParam.Jkdabh;
                sqlparams.Add(pJkdabh);
            }

            if (null != jc_jmParam.Pym && "" != jc_jmParam.Pym)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.PYM=:pym ");
                OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                pPym.Value = jc_jmParam.Pym;
                sqlparams.Add(pPym);
            }

            if (null != jc_jmParam.Wbm && "" != jc_jmParam.Wbm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.WBM=:wbm ");
                OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                pWbm.Value = jc_jmParam.Wbm;
                sqlparams.Add(pWbm);
            }

            if (null != jc_jmParam.Zfbz && "" != jc_jmParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                pZfbz.Value = jc_jmParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (jc_jmParamLike != null)
            {

                if (null != jc_jmParamLike.Sfzh && "" != jc_jmParamLike.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.SFZH LIKE '%'||:sfzh||'%' ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Direction = ParameterDirection.Input;
                    pSfzh.Value = jc_jmParamLike.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != jc_jmParamLike.Xm && "" != jc_jmParamLike.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XM LIKE '%'||:xm||'%' ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Direction = ParameterDirection.Input;
                    pXm.Value = jc_jmParamLike.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != jc_jmParamLike.Xb_code && "" != jc_jmParamLike.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XB_CODE LIKE '%'||:xb_code||'%' ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Direction = ParameterDirection.Input;
                    pXb_code.Value = jc_jmParamLike.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (null != jc_jmParamLike.Mz_code && "" != jc_jmParamLike.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.MZ_CODE LIKE '%'||:mz_code||'%' ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Direction = ParameterDirection.Input;
                    pMz_code.Value = jc_jmParamLike.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (null != jc_jmParamLike.Xx_code && "" != jc_jmParamLike.Xx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XX_CODE LIKE '%'||:xx_code||'%' ");
                    OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                    pXx_code.Direction = ParameterDirection.Input;
                    pXx_code.Value = jc_jmParamLike.Xx_code;
                    sqlparams.Add(pXx_code);
                }

                if (null != jc_jmParamLike.Rh_code && "" != jc_jmParamLike.Rh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.RH_CODE LIKE '%'||:rh_code||'%' ");
                    OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                    pRh_code.Direction = ParameterDirection.Input;
                    pRh_code.Value = jc_jmParamLike.Rh_code;
                    sqlparams.Add(pRh_code);
                }

                if (null != jc_jmParamLike.Csdz && "" != jc_jmParamLike.Csdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CSDZ LIKE '%'||:csdz||'%' ");
                    OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                    pCsdz.Direction = ParameterDirection.Input;
                    pCsdz.Value = jc_jmParamLike.Csdz;
                    sqlparams.Add(pCsdz);
                }

                if (null != jc_jmParamLike.Hjdz && "" != jc_jmParamLike.Hjdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HJDZ LIKE '%'||:hjdz||'%' ");
                    OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                    pHjdz.Direction = ParameterDirection.Input;
                    pHjdz.Value = jc_jmParamLike.Hjdz;
                    sqlparams.Add(pHjdz);
                }

                if (null != jc_jmParamLike.Xzz_xzqh && "" != jc_jmParamLike.Xzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XZQH LIKE '%'||:xzz_xzqh||'%' ");
                    OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                    pXzz_xzqh.Direction = ParameterDirection.Input;
                    pXzz_xzqh.Value = jc_jmParamLike.Xzz_xzqh;
                    sqlparams.Add(pXzz_xzqh);
                }

                if (null != jc_jmParamLike.Xzz_xiang_xi_di_zhi && "" != jc_jmParamLike.Xzz_xiang_xi_di_zhi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.XZZ_XIANG_XI_DI_ZHI LIKE '%'||:xzz_xiang_xi_di_zhi||'%' ");
                    OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                    pXzz_xiang_xi_di_zhi.Direction = ParameterDirection.Input;
                    pXzz_xiang_xi_di_zhi.Value = jc_jmParamLike.Xzz_xiang_xi_di_zhi;
                    sqlparams.Add(pXzz_xiang_xi_di_zhi);
                }

                if (null != jc_jmParamLike.Gzdw_xx && "" != jc_jmParamLike.Gzdw_xx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GZDW_XX LIKE '%'||:gzdw_xx||'%' ");
                    OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                    pGzdw_xx.Direction = ParameterDirection.Input;
                    pGzdw_xx.Value = jc_jmParamLike.Gzdw_xx;
                    sqlparams.Add(pGzdw_xx);
                }

                if (null != jc_jmParamLike.Zy_code && "" != jc_jmParamLike.Zy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY_CODE LIKE '%'||:zy_code||'%' ");
                    OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                    pZy_code.Direction = ParameterDirection.Input;
                    pZy_code.Value = jc_jmParamLike.Zy_code;
                    sqlparams.Add(pZy_code);
                }

                if (null != jc_jmParamLike.Zy && "" != jc_jmParamLike.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZY LIKE '%'||:zy||'%' ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Direction = ParameterDirection.Input;
                    pZy.Value = jc_jmParamLike.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != jc_jmParamLike.Wh_code && "" != jc_jmParamLike.Wh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WH_CODE LIKE '%'||:wh_code||'%' ");
                    OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                    pWh_code.Direction = ParameterDirection.Input;
                    pWh_code.Value = jc_jmParamLike.Wh_code;
                    sqlparams.Add(pWh_code);
                }

                if (null != jc_jmParamLike.Hyzk_code && "" != jc_jmParamLike.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.HYZK_CODE LIKE '%'||:hyzk_code||'%' ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Direction = ParameterDirection.Input;
                    pHyzk_code.Value = jc_jmParamLike.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != jc_jmParamLike.Lxdh && "" != jc_jmParamLike.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.LXDH LIKE '%'||:lxdh||'%' ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Direction = ParameterDirection.Input;
                    pLxdh.Value = jc_jmParamLike.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != jc_jmParamLike.Jhr_xm && "" != jc_jmParamLike.Jhr_xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_XM LIKE '%'||:jhr_xm||'%' ");
                    OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                    pJhr_xm.Direction = ParameterDirection.Input;
                    pJhr_xm.Value = jc_jmParamLike.Jhr_xm;
                    sqlparams.Add(pJhr_xm);
                }

                if (null != jc_jmParamLike.Jhr_dh && "" != jc_jmParamLike.Jhr_dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JHR_DH LIKE '%'||:jhr_dh||'%' ");
                    OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                    pJhr_dh.Direction = ParameterDirection.Input;
                    pJhr_dh.Value = jc_jmParamLike.Jhr_dh;
                    sqlparams.Add(pJhr_dh);
                }

                if (null != jc_jmParamLike.Nhbm && "" != jc_jmParamLike.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.NHBM LIKE '%'||:nhbm||'%' ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Direction = ParameterDirection.Input;
                    pNhbm.Value = jc_jmParamLike.Nhbm;
                    sqlparams.Add(pNhbm);
                }

                if (null != jc_jmParamLike.Ybkh && "" != jc_jmParamLike.Ybkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.YBKH LIKE '%'||:ybkh||'%' ");
                    OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                    pYbkh.Direction = ParameterDirection.Input;
                    pYbkh.Value = jc_jmParamLike.Ybkh;
                    sqlparams.Add(pYbkh);
                }

                if (null != jc_jmParamLike.Cjkh && "" != jc_jmParamLike.Cjkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.CJKH LIKE '%'||:cjkh||'%' ");
                    OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                    pCjkh.Direction = ParameterDirection.Input;
                    pCjkh.Value = jc_jmParamLike.Cjkh;
                    sqlparams.Add(pCjkh);
                }

                if (null != jc_jmParamLike.Zfzh && "" != jc_jmParamLike.Zfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFZH LIKE '%'||:zfzh||'%' ");
                    OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                    pZfzh.Direction = ParameterDirection.Input;
                    pZfzh.Value = jc_jmParamLike.Zfzh;
                    sqlparams.Add(pZfzh);
                }

                if (null != jc_jmParamLike.Jkdabh && "" != jc_jmParamLike.Jkdabh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.JKDABH LIKE '%'||:jkdabh||'%' ");
                    OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                    pJkdabh.Direction = ParameterDirection.Input;
                    pJkdabh.Value = jc_jmParamLike.Jkdabh;
                    sqlparams.Add(pJkdabh);
                }

                if (null != jc_jmParamLike.Pym && "" != jc_jmParamLike.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.PYM LIKE '%'||:pym||'%' ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Direction = ParameterDirection.Input;
                    pPym.Value = jc_jmParamLike.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != jc_jmParamLike.Wbm && "" != jc_jmParamLike.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.WBM LIKE '%'||:wbm||'%' ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Direction = ParameterDirection.Input;
                    pWbm.Value = jc_jmParamLike.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != jc_jmParamLike.Zfbz && "" != jc_jmParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = jc_jmParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (jc_jmParamLike != null)
            {

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Jc_jm>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Jc_jm>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                jc_jmParamList.Add(this.dataSetContactObjectsToModel(row));
                //jc_jmParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(jc_jmParamList);//把List<Jc_jm>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


