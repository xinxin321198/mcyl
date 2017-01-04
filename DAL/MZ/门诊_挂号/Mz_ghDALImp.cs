

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
using Model.JC;

namespace DAL.MZ.门诊_挂号
{
    /// <summary>
    ///数据库访问层的Mz_gh实现类
    ///此类由代码生成器生成
    ///表名：MZ_GH
    ///生成日期：2015-12-30 17:18:23
    /// 

    ///作者：罗新鑫
    ///联系电话：15087010221
    ///联系邮箱：362527240@qq.com
        
    /// </summary>
    public class Mz_ghDALImp :Base.BasDAL,Mz_ghDAL
    {

        /// <summary>
        /// 插入一条数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="mz_ghParam">要插入的mz_ghParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insert(Mz_gh mz_ghParam,OracleConnection con)
        {
            if (""==mz_ghParam.Id||null==mz_ghParam.Id)
            {
                mz_ghParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            
            StringBuilder sql = new StringBuilder("INSERT INTO MZ_GH(id,lsh,fk_jc_jm,brxm,brcsrq,brxb,brsfzh,brlxdh,brxzz_xzqh,brxzz_detail,brlx_code,fk_jc_kswh,fk_jc_renyuan,ghlx_code,ghrq,state_code,zfbz) VALUES(:id,:lsh,:fk_jc_jm,:brxm,:brcsrq,:brxb,:brsfzh,:brlxdh,:brxzz_xzqh,:brxzz_detail,:brlx_code,:fk_jc_kswh,:fk_jc_renyuan,:ghlx_code,:ghrq,:state_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = mz_ghParam.Id;
            sqlparams.Add(pId);
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = mz_ghParam.Lsh;
            sqlparams.Add(pLsh);
            OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
            pFk_jc_jm.Direction = ParameterDirection.Input;
            pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
            sqlparams.Add(pFk_jc_jm);
            OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
            pBrxm.Direction = ParameterDirection.Input;
            pBrxm.Value = mz_ghParam.Brxm;
            sqlparams.Add(pBrxm);
            OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
            pBrcsrq.Direction = ParameterDirection.Input;
            pBrcsrq.Value = mz_ghParam.Brcsrq;
            sqlparams.Add(pBrcsrq);
            OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
            pBrxb.Direction = ParameterDirection.Input;
            pBrxb.Value = mz_ghParam.Brxb;
            sqlparams.Add(pBrxb);
            OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
            pBrsfzh.Direction = ParameterDirection.Input;
            pBrsfzh.Value = mz_ghParam.Brsfzh;
            sqlparams.Add(pBrsfzh);
            OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
            pBrlxdh.Direction = ParameterDirection.Input;
            pBrlxdh.Value = mz_ghParam.Brlxdh;
            sqlparams.Add(pBrlxdh);
            OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
            pBrxzz_xzqh.Direction = ParameterDirection.Input;
            pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
            sqlparams.Add(pBrxzz_xzqh);
            OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
            pBrxzz_detail.Direction = ParameterDirection.Input;
            pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
            sqlparams.Add(pBrxzz_detail);
            OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
            pBrlx_code.Direction = ParameterDirection.Input;
            pBrlx_code.Value = mz_ghParam.Brlx_code;
            sqlparams.Add(pBrlx_code);
            OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
            pFk_jc_kswh.Direction = ParameterDirection.Input;
            pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
            sqlparams.Add(pFk_jc_kswh);
            OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
            pFk_jc_renyuan.Direction = ParameterDirection.Input;
            pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
            sqlparams.Add(pFk_jc_renyuan);
            OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
            pGhlx_code.Direction = ParameterDirection.Input;
            pGhlx_code.Value = mz_ghParam.Ghlx_code;
            sqlparams.Add(pGhlx_code);
            OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
            pGhrq.Direction = ParameterDirection.Input;
            pGhrq.Value = mz_ghParam.Ghrq;
            sqlparams.Add(pGhrq);
            OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
            pState_code.Direction = ParameterDirection.Input;
            pState_code.Value = mz_ghParam.State_code;
            sqlparams.Add(pState_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = mz_ghParam.Zfbz;
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
        /// 插入一条数据，流水号使用sequences，时间是插入数据库的当前时间（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 主键为null时，自动生成主键guid，一般不直接调用此方法，请调用save方法进行单条数据的插入和修改       
        /// </summary>
        /// <param name="mz_ghParam">要插入的mz_ghParam对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数为1时成功）</returns>
        public bool insertForSequences(Mz_gh mz_ghParam, OracleConnection con)
        {
            if ("" == mz_ghParam.Id || null == mz_ghParam.Id)
            {
                mz_ghParam.Id = Model.Common.GUIDHelper.getGuid();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO MZ_GH(id,lsh,fk_jc_jm,brxm,brcsrq,brxb,brsfzh,brlxdh,brxzz_xzqh,brxzz_detail,brlx_code,fk_jc_kswh,fk_jc_renyuan,ghlx_code,ghrq,state_code,zfbz) VALUES(:id,mz_ghlsh.nextval,:fk_jc_jm,:brxm,:brcsrq,:brxb,:brsfzh,:brlxdh,:brxzz_xzqh,:brxzz_detail,:brlx_code,:fk_jc_kswh,:fk_jc_renyuan,:ghlx_code,SYSDATE,:state_code,:zfbz)");

            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = mz_ghParam.Id;
            sqlparams.Add(pId);
            //OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            //pLsh.Direction = ParameterDirection.Input;
            //pLsh.Value = mz_ghParam.Lsh;
            //sqlparams.Add(pLsh);
            OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
            pFk_jc_jm.Direction = ParameterDirection.Input;
            pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
            sqlparams.Add(pFk_jc_jm);
            OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
            pBrxm.Direction = ParameterDirection.Input;
            pBrxm.Value = mz_ghParam.Brxm;
            sqlparams.Add(pBrxm);
            OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
            pBrcsrq.Direction = ParameterDirection.Input;
            pBrcsrq.Value = mz_ghParam.Brcsrq;
            sqlparams.Add(pBrcsrq);
            OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
            pBrxb.Direction = ParameterDirection.Input;
            pBrxb.Value = mz_ghParam.Brxb;
            sqlparams.Add(pBrxb);
            OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
            pBrsfzh.Direction = ParameterDirection.Input;
            pBrsfzh.Value = mz_ghParam.Brsfzh;
            sqlparams.Add(pBrsfzh);
            OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
            pBrlxdh.Direction = ParameterDirection.Input;
            pBrlxdh.Value = mz_ghParam.Brlxdh;
            sqlparams.Add(pBrlxdh);
            OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
            pBrxzz_xzqh.Direction = ParameterDirection.Input;
            pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
            sqlparams.Add(pBrxzz_xzqh);
            OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
            pBrxzz_detail.Direction = ParameterDirection.Input;
            pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
            sqlparams.Add(pBrxzz_detail);
            OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
            pBrlx_code.Direction = ParameterDirection.Input;
            pBrlx_code.Value = mz_ghParam.Brlx_code;
            sqlparams.Add(pBrlx_code);
            OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
            pFk_jc_kswh.Direction = ParameterDirection.Input;
            pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
            sqlparams.Add(pFk_jc_kswh);
            OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
            pFk_jc_renyuan.Direction = ParameterDirection.Input;
            pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
            sqlparams.Add(pFk_jc_renyuan);
            OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
            pGhlx_code.Direction = ParameterDirection.Input;
            pGhlx_code.Value = mz_ghParam.Ghlx_code;
            sqlparams.Add(pGhlx_code);
            //OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
            //pGhrq.Direction = ParameterDirection.Input;
            //pGhrq.Value = mz_ghParam.Ghrq;
            //sqlparams.Add(pGhrq);
            OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
            pState_code.Direction = ParameterDirection.Input;
            pState_code.Value = mz_ghParam.State_code;
            sqlparams.Add(pState_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = mz_ghParam.Zfbz;
            sqlparams.Add(pZfbz);
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
        /// <param name="mz_ghParamList">要插入的mz_ghParam对象的集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否添加成功（影响的行数等于保存的对象的数量时成功）</returns>
        public bool inertBatch(List<Mz_gh> mz_ghParamList, OracleConnection con)
        {
            if (mz_ghParamList.Count == 0)
            {
                return true;
            }

            List<string> idList = new List<string>();

            List<decimal?> lshList = new List<decimal?>();

            List<string> fk_jc_jmList = new List<string>();

            List<string> brxmList = new List<string>();

            List<DateTime?> brcsrqList = new List<DateTime?>();

            List<string> brxbList = new List<string>();

            List<string> brsfzhList = new List<string>();

            List<string> brlxdhList = new List<string>();

            List<string> brxzz_xzqhList = new List<string>();

            List<string> brxzz_detailList = new List<string>();

            List<string> brlx_codeList = new List<string>();

            List<string> fk_jc_kswhList = new List<string>();

            List<string> fk_jc_renyuanList = new List<string>();

            List<string> ghlx_codeList = new List<string>();

            List<DateTime?> ghrqList = new List<DateTime?>();

            List<string> state_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < mz_ghParamList.Count; i++)
            {
                Mz_gh mz_ghParam = mz_ghParamList[i];
                if ("" == mz_ghParam.Id || null == mz_ghParam.Id)
                {
                    mz_ghParam.Id = Model.Common.GUIDHelper.getGuid();
                }

            idList.Add(mz_ghParam.Id);

            lshList.Add(mz_ghParam.Lsh);

            fk_jc_jmList.Add(mz_ghParam.Fk_jc_jm);

            brxmList.Add(mz_ghParam.Brxm);

            brcsrqList.Add(mz_ghParam.Brcsrq);

            brxbList.Add(mz_ghParam.Brxb);

            brsfzhList.Add(mz_ghParam.Brsfzh);

            brlxdhList.Add(mz_ghParam.Brlxdh);

            brxzz_xzqhList.Add(mz_ghParam.Brxzz_xzqh);

            brxzz_detailList.Add(mz_ghParam.Brxzz_detail);

            brlx_codeList.Add(mz_ghParam.Brlx_code);

            fk_jc_kswhList.Add(mz_ghParam.Fk_jc_kswh);

            fk_jc_renyuanList.Add(mz_ghParam.Fk_jc_renyuan);

            ghlx_codeList.Add(mz_ghParam.Ghlx_code);

            ghrqList.Add(mz_ghParam.Ghrq);

            state_codeList.Add(mz_ghParam.State_code);

            zfbzList.Add(mz_ghParam.Zfbz);

            }

            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("INSERT INTO MZ_GH(id,lsh,fk_jc_jm,brxm,brcsrq,brxb,brsfzh,brlxdh,brxzz_xzqh,brxzz_detail,brlx_code,fk_jc_kswh,fk_jc_renyuan,ghlx_code,ghrq,state_code,zfbz) VALUES(:id,:lsh,:fk_jc_jm,:brxm,:brcsrq,:brxb,:brsfzh,:brlxdh,:brxzz_xzqh,:brxzz_detail,:brlx_code,:fk_jc_kswh,:fk_jc_renyuan,:ghlx_code,:ghrq,:state_code,:zfbz)");
            
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Direction = ParameterDirection.Input;
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = lshList.ToArray();
            sqlparams.Add(pLsh);
            OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
            pFk_jc_jm.Direction = ParameterDirection.Input;
            pFk_jc_jm.Value = fk_jc_jmList.ToArray();
            sqlparams.Add(pFk_jc_jm);
            OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
            pBrxm.Direction = ParameterDirection.Input;
            pBrxm.Value = brxmList.ToArray();
            sqlparams.Add(pBrxm);
            OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
            pBrcsrq.Direction = ParameterDirection.Input;
            pBrcsrq.Value = brcsrqList.ToArray();
            sqlparams.Add(pBrcsrq);
            OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
            pBrxb.Direction = ParameterDirection.Input;
            pBrxb.Value = brxbList.ToArray();
            sqlparams.Add(pBrxb);
            OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
            pBrsfzh.Direction = ParameterDirection.Input;
            pBrsfzh.Value = brsfzhList.ToArray();
            sqlparams.Add(pBrsfzh);
            OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
            pBrlxdh.Direction = ParameterDirection.Input;
            pBrlxdh.Value = brlxdhList.ToArray();
            sqlparams.Add(pBrlxdh);
            OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
            pBrxzz_xzqh.Direction = ParameterDirection.Input;
            pBrxzz_xzqh.Value = brxzz_xzqhList.ToArray();
            sqlparams.Add(pBrxzz_xzqh);
            OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
            pBrxzz_detail.Direction = ParameterDirection.Input;
            pBrxzz_detail.Value = brxzz_detailList.ToArray();
            sqlparams.Add(pBrxzz_detail);
            OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
            pBrlx_code.Direction = ParameterDirection.Input;
            pBrlx_code.Value = brlx_codeList.ToArray();
            sqlparams.Add(pBrlx_code);
            OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
            pFk_jc_kswh.Direction = ParameterDirection.Input;
            pFk_jc_kswh.Value = fk_jc_kswhList.ToArray();
            sqlparams.Add(pFk_jc_kswh);
            OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
            pFk_jc_renyuan.Direction = ParameterDirection.Input;
            pFk_jc_renyuan.Value = fk_jc_renyuanList.ToArray();
            sqlparams.Add(pFk_jc_renyuan);
            OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
            pGhlx_code.Direction = ParameterDirection.Input;
            pGhlx_code.Value = ghlx_codeList.ToArray();
            sqlparams.Add(pGhlx_code);
            OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
            pGhrq.Direction = ParameterDirection.Input;
            pGhrq.Value = ghrqList.ToArray();
            sqlparams.Add(pGhrq);
            OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
            pState_code.Direction = ParameterDirection.Input;
            pState_code.Value = state_codeList.ToArray();
            sqlparams.Add(pState_code);
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);
            bool result = false;
            int flag = -1;
            flag = OracleHelper.ExecuteBatch(sql.ToString(), con, mz_ghParamList.Count, sqlparams.ToArray());
            if (mz_ghParamList.Count == flag)
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
            StringBuilder sql = new StringBuilder("DELETE MZ_GH WHERE ID=:id");
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
            StringBuilder sql = new StringBuilder("DELETE MZ_GH WHERE ID=:id");
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
        /// <param name="mz_ghParamCondition">删除的条件</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>无法确定删除的行数（影响行数大于等于0就算成功）</returns>
        public bool deleteByOtherCondition(Mz_gh mz_ghParamCondition, OracleConnection con)
        {
            if (null!=mz_ghParamCondition.Id&&""!=mz_ghParamCondition.Id)
            {
                throw new Exception("不允许指定参数的ID，如果要根据ID删除数据请调用deleteById或者deleteByIdBatch方法；错误出自：deleteByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            StringBuilder sql = new StringBuilder("DELETE MZ_GH ");

            if (null != mz_ghParamCondition.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = mz_ghParamCondition.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_jm &&  ""!= mz_ghParamCondition.Fk_jc_jm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Direction = ParameterDirection.Input;
                pFk_jc_jm.Value = mz_ghParamCondition.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);

            }
                        
            if (null != mz_ghParamCondition.Brxm &&  ""!= mz_ghParamCondition.Brxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Direction = ParameterDirection.Input;
                pBrxm.Value = mz_ghParamCondition.Brxm;
                sqlparams.Add(pBrxm);

            }
                        
            if (DateTime.MinValue != mz_ghParamCondition.Brcsrq &&null != mz_ghParamCondition.Brcsrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRCSRQ=:brcsrq ");
                OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Direction = ParameterDirection.Input;
                pBrcsrq.Value = mz_ghParamCondition.Brcsrq;
                sqlparams.Add(pBrcsrq);

            }
                        
            if (null != mz_ghParamCondition.Brxb &&  ""!= mz_ghParamCondition.Brxb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Direction = ParameterDirection.Input;
                pBrxb.Value = mz_ghParamCondition.Brxb;
                sqlparams.Add(pBrxb);

            }
                        
            if (null != mz_ghParamCondition.Brsfzh &&  ""!= mz_ghParamCondition.Brsfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Direction = ParameterDirection.Input;
                pBrsfzh.Value = mz_ghParamCondition.Brsfzh;
                sqlparams.Add(pBrsfzh);

            }
                        
            if (null != mz_ghParamCondition.Brlxdh &&  ""!= mz_ghParamCondition.Brlxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Direction = ParameterDirection.Input;
                pBrlxdh.Value = mz_ghParamCondition.Brlxdh;
                sqlparams.Add(pBrlxdh);

            }
                        
            if (null != mz_ghParamCondition.Brxzz_xzqh &&  ""!= mz_ghParamCondition.Brxzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Direction = ParameterDirection.Input;
                pBrxzz_xzqh.Value = mz_ghParamCondition.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);

            }
                        
            if (null != mz_ghParamCondition.Brxzz_detail &&  ""!= mz_ghParamCondition.Brxzz_detail)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Direction = ParameterDirection.Input;
                pBrxzz_detail.Value = mz_ghParamCondition.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);

            }
                        
            if (null != mz_ghParamCondition.Brlx_code &&  ""!= mz_ghParamCondition.Brlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Direction = ParameterDirection.Input;
                pBrlx_code.Value = mz_ghParamCondition.Brlx_code;
                sqlparams.Add(pBrlx_code);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_kswh &&  ""!= mz_ghParamCondition.Fk_jc_kswh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Direction = ParameterDirection.Input;
                pFk_jc_kswh.Value = mz_ghParamCondition.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_renyuan &&  ""!= mz_ghParamCondition.Fk_jc_renyuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Direction = ParameterDirection.Input;
                pFk_jc_renyuan.Value = mz_ghParamCondition.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);

            }
                        
            if (null != mz_ghParamCondition.Ghlx_code &&  ""!= mz_ghParamCondition.Ghlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Direction = ParameterDirection.Input;
                pGhlx_code.Value = mz_ghParamCondition.Ghlx_code;
                sqlparams.Add(pGhlx_code);

            }
                        
            if (DateTime.MinValue != mz_ghParamCondition.Ghrq &&null != mz_ghParamCondition.Ghrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GHRQ=:ghrq ");
                OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Direction = ParameterDirection.Input;
                pGhrq.Value = mz_ghParamCondition.Ghrq;
                sqlparams.Add(pGhrq);

            }
                        
            if (null != mz_ghParamCondition.State_code &&  ""!= mz_ghParamCondition.State_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Direction = ParameterDirection.Input;
                pState_code.Value = mz_ghParamCondition.State_code;
                sqlparams.Add(pState_code);

            }
                        
            if (null != mz_ghParamCondition.Zfbz &&  ""!= mz_ghParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_ghParamCondition.Zfbz;
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
        /// <param name="mz_ghParam"></param>
        /// <returns>影响的行数</returns>
        public bool updateById(Mz_gh mz_ghParam,OracleConnection con)
        {
            if ("" == mz_ghParam.Id || null == mz_ghParam.Id)
            {
                throw new Exception("ID不允许为空，请赋值后调用；错误出自：updateById");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_GH SET ");
            if (null != mz_ghParam.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = mz_ghParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != mz_ghParam.Fk_jc_jm &&  ""!= mz_ghParam.Fk_jc_jm)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Direction = ParameterDirection.Input;
                pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);

            }
                        
            if (null != mz_ghParam.Brxm &&  ""!= mz_ghParam.Brxm)
            {
                this.isComma(sql);
                sql.Append(" BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Direction = ParameterDirection.Input;
                pBrxm.Value = mz_ghParam.Brxm;
                sqlparams.Add(pBrxm);

            }
                        
            if (DateTime.MinValue != mz_ghParam.Brcsrq &&null != mz_ghParam.Brcsrq)
            {
                this.isComma(sql);
                sql.Append(" BRCSRQ=:brcsrq ");
                OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Direction = ParameterDirection.Input;
                pBrcsrq.Value = mz_ghParam.Brcsrq;
                sqlparams.Add(pBrcsrq);

            }
                        
            if (null != mz_ghParam.Brxb &&  ""!= mz_ghParam.Brxb)
            {
                this.isComma(sql);
                sql.Append(" BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Direction = ParameterDirection.Input;
                pBrxb.Value = mz_ghParam.Brxb;
                sqlparams.Add(pBrxb);

            }
                        
            if (null != mz_ghParam.Brsfzh &&  ""!= mz_ghParam.Brsfzh)
            {
                this.isComma(sql);
                sql.Append(" BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Direction = ParameterDirection.Input;
                pBrsfzh.Value = mz_ghParam.Brsfzh;
                sqlparams.Add(pBrsfzh);

            }
                        
            if (null != mz_ghParam.Brlxdh &&  ""!= mz_ghParam.Brlxdh)
            {
                this.isComma(sql);
                sql.Append(" BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Direction = ParameterDirection.Input;
                pBrlxdh.Value = mz_ghParam.Brlxdh;
                sqlparams.Add(pBrlxdh);

            }
                        
            if (null != mz_ghParam.Brxzz_xzqh &&  ""!= mz_ghParam.Brxzz_xzqh)
            {
                this.isComma(sql);
                sql.Append(" BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Direction = ParameterDirection.Input;
                pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);

            }
                        
            if (null != mz_ghParam.Brxzz_detail &&  ""!= mz_ghParam.Brxzz_detail)
            {
                this.isComma(sql);
                sql.Append(" BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Direction = ParameterDirection.Input;
                pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);

            }
                        
            if (null != mz_ghParam.Brlx_code &&  ""!= mz_ghParam.Brlx_code)
            {
                this.isComma(sql);
                sql.Append(" BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Direction = ParameterDirection.Input;
                pBrlx_code.Value = mz_ghParam.Brlx_code;
                sqlparams.Add(pBrlx_code);

            }
                        
            if (null != mz_ghParam.Fk_jc_kswh &&  ""!= mz_ghParam.Fk_jc_kswh)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Direction = ParameterDirection.Input;
                pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);

            }
                        
            if (null != mz_ghParam.Fk_jc_renyuan &&  ""!= mz_ghParam.Fk_jc_renyuan)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Direction = ParameterDirection.Input;
                pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);

            }
                        
            if (null != mz_ghParam.Ghlx_code &&  ""!= mz_ghParam.Ghlx_code)
            {
                this.isComma(sql);
                sql.Append(" GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Direction = ParameterDirection.Input;
                pGhlx_code.Value = mz_ghParam.Ghlx_code;
                sqlparams.Add(pGhlx_code);

            }
                        
            if (DateTime.MinValue != mz_ghParam.Ghrq &&null != mz_ghParam.Ghrq)
            {
                this.isComma(sql);
                sql.Append(" GHRQ=:ghrq ");
                OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Direction = ParameterDirection.Input;
                pGhrq.Value = mz_ghParam.Ghrq;
                sqlparams.Add(pGhrq);

            }
                        
            if (null != mz_ghParam.State_code &&  ""!= mz_ghParam.State_code)
            {
                this.isComma(sql);
                sql.Append(" STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Direction = ParameterDirection.Input;
                pState_code.Value = mz_ghParam.State_code;
                sqlparams.Add(pState_code);

            }
                        
            if (null != mz_ghParam.Zfbz &&  ""!= mz_ghParam.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_ghParam.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = mz_ghParam.Id;
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
        /// <param name="mz_ghParamList">要修改的Mz_gh对象集合</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>是否删除成功（影响的行数等于要修改的对象数量时成功）</returns>
        public bool updateByIdBatch(List<Mz_gh> mz_ghParamList, OracleConnection con)
        {


            List<string> idList = new List<string>();

            List<decimal?> lshList = new List<decimal?>();

            List<string> fk_jc_jmList = new List<string>();

            List<string> brxmList = new List<string>();

            List<DateTime?> brcsrqList = new List<DateTime?>();

            List<string> brxbList = new List<string>();

            List<string> brsfzhList = new List<string>();

            List<string> brlxdhList = new List<string>();

            List<string> brxzz_xzqhList = new List<string>();

            List<string> brxzz_detailList = new List<string>();

            List<string> brlx_codeList = new List<string>();

            List<string> fk_jc_kswhList = new List<string>();

            List<string> fk_jc_renyuanList = new List<string>();

            List<string> ghlx_codeList = new List<string>();

            List<DateTime?> ghrqList = new List<DateTime?>();

            List<string> state_codeList = new List<string>();

            List<string> zfbzList = new List<string>();

            for (int i = 0; i < mz_ghParamList.Count; i++)
            {
                Mz_gh mz_ghParam = mz_ghParamList[i];
                if ("" == mz_ghParam.Id || null == mz_ghParam.Id)
                {
                    throw new Exception("下标为" + i + "的数据，ID不能为空，请赋值后调用；错误出自：updateByIdBatch");
                }

            idList.Add(mz_ghParam.Id);

            lshList.Add(mz_ghParam.Lsh);

            fk_jc_jmList.Add(mz_ghParam.Fk_jc_jm);

            brxmList.Add(mz_ghParam.Brxm);

            brcsrqList.Add(mz_ghParam.Brcsrq);

            brxbList.Add(mz_ghParam.Brxb);

            brsfzhList.Add(mz_ghParam.Brsfzh);

            brlxdhList.Add(mz_ghParam.Brlxdh);

            brxzz_xzqhList.Add(mz_ghParam.Brxzz_xzqh);

            brxzz_detailList.Add(mz_ghParam.Brxzz_detail);

            brlx_codeList.Add(mz_ghParam.Brlx_code);

            fk_jc_kswhList.Add(mz_ghParam.Fk_jc_kswh);

            fk_jc_renyuanList.Add(mz_ghParam.Fk_jc_renyuan);

            ghlx_codeList.Add(mz_ghParam.Ghlx_code);

            ghrqList.Add(mz_ghParam.Ghrq);

            state_codeList.Add(mz_ghParam.State_code);

            zfbzList.Add(mz_ghParam.Zfbz);

            }


            
            List<OracleParameter> sqlparams = new List<OracleParameter>();

            StringBuilder sql = new StringBuilder("UPDATE MZ_GH SET ");
            this.isComma(sql);
            sql.Append(" LSH=:lsh ");
            OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
            pLsh.Direction = ParameterDirection.Input;
            pLsh.Value = lshList.ToArray();
            sqlparams.Add(pLsh);

            this.isComma(sql);
            sql.Append(" FK_JC_JM=:fk_jc_jm ");
            OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
            pFk_jc_jm.Direction = ParameterDirection.Input;
            pFk_jc_jm.Value = fk_jc_jmList.ToArray();
            sqlparams.Add(pFk_jc_jm);

            this.isComma(sql);
            sql.Append(" BRXM=:brxm ");
            OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
            pBrxm.Direction = ParameterDirection.Input;
            pBrxm.Value = brxmList.ToArray();
            sqlparams.Add(pBrxm);

            this.isComma(sql);
            sql.Append(" BRCSRQ=:brcsrq ");
            OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
            pBrcsrq.Direction = ParameterDirection.Input;
            pBrcsrq.Value = brcsrqList.ToArray();
            sqlparams.Add(pBrcsrq);

            this.isComma(sql);
            sql.Append(" BRXB=:brxb ");
            OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
            pBrxb.Direction = ParameterDirection.Input;
            pBrxb.Value = brxbList.ToArray();
            sqlparams.Add(pBrxb);

            this.isComma(sql);
            sql.Append(" BRSFZH=:brsfzh ");
            OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
            pBrsfzh.Direction = ParameterDirection.Input;
            pBrsfzh.Value = brsfzhList.ToArray();
            sqlparams.Add(pBrsfzh);

            this.isComma(sql);
            sql.Append(" BRLXDH=:brlxdh ");
            OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
            pBrlxdh.Direction = ParameterDirection.Input;
            pBrlxdh.Value = brlxdhList.ToArray();
            sqlparams.Add(pBrlxdh);

            this.isComma(sql);
            sql.Append(" BRXZZ_XZQH=:brxzz_xzqh ");
            OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
            pBrxzz_xzqh.Direction = ParameterDirection.Input;
            pBrxzz_xzqh.Value = brxzz_xzqhList.ToArray();
            sqlparams.Add(pBrxzz_xzqh);

            this.isComma(sql);
            sql.Append(" BRXZZ_DETAIL=:brxzz_detail ");
            OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
            pBrxzz_detail.Direction = ParameterDirection.Input;
            pBrxzz_detail.Value = brxzz_detailList.ToArray();
            sqlparams.Add(pBrxzz_detail);

            this.isComma(sql);
            sql.Append(" BRLX_CODE=:brlx_code ");
            OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
            pBrlx_code.Direction = ParameterDirection.Input;
            pBrlx_code.Value = brlx_codeList.ToArray();
            sqlparams.Add(pBrlx_code);

            this.isComma(sql);
            sql.Append(" FK_JC_KSWH=:fk_jc_kswh ");
            OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
            pFk_jc_kswh.Direction = ParameterDirection.Input;
            pFk_jc_kswh.Value = fk_jc_kswhList.ToArray();
            sqlparams.Add(pFk_jc_kswh);

            this.isComma(sql);
            sql.Append(" FK_JC_RENYUAN=:fk_jc_renyuan ");
            OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
            pFk_jc_renyuan.Direction = ParameterDirection.Input;
            pFk_jc_renyuan.Value = fk_jc_renyuanList.ToArray();
            sqlparams.Add(pFk_jc_renyuan);

            this.isComma(sql);
            sql.Append(" GHLX_CODE=:ghlx_code ");
            OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
            pGhlx_code.Direction = ParameterDirection.Input;
            pGhlx_code.Value = ghlx_codeList.ToArray();
            sqlparams.Add(pGhlx_code);

            this.isComma(sql);
            sql.Append(" GHRQ=:ghrq ");
            OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
            pGhrq.Direction = ParameterDirection.Input;
            pGhrq.Value = ghrqList.ToArray();
            sqlparams.Add(pGhrq);

            this.isComma(sql);
            sql.Append(" STATE_CODE=:state_code ");
            OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
            pState_code.Direction = ParameterDirection.Input;
            pState_code.Value = state_codeList.ToArray();
            sqlparams.Add(pState_code);

            this.isComma(sql);
            sql.Append(" ZFBZ=:zfbz ");
            OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
            pZfbz.Direction = ParameterDirection.Input;
            pZfbz.Value = zfbzList.ToArray();
            sqlparams.Add(pZfbz);

            sql.Append(" WHERE ID=:id ");
            OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
            pId.Value = idList.ToArray();
            sqlparams.Add(pId);
            bool result = false;
            int flag = OracleHelper.ExecuteBatch(sql.ToString(), con,mz_ghParamList.Count, sqlparams.ToArray());
            if (mz_ghParamList.Count == flag)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 根据更新的条件，更新数据（如果需要供事务使用就传入OracleConnection对象，如果不供就传入null，方法自动生成OracleConnection对象）
        /// 不指定ID，如果要根据ID来更新数据，请使用updateForId方法
        /// </summary>
        /// <param name="mz_ghParamCondition">条件对象</param>
        /// <param name="mz_ghParamUpdate">要更新的数据对象</param>
        /// <param name="con">Oracle连接对象（为null时自动生成）</param>
        /// <returns>影响的行数不确定（不为-1就正确）</returns>
        public bool updateByOtherCondition(Mz_gh mz_ghParamCondition, Mz_gh mz_ghParamUpdate, OracleConnection con)
        {
            if ((null!=mz_ghParamCondition.Id&&"!=mz_ghParamCondition.Id)||(null!=mz_ghParamUpdate.Id&&"!=mz_ghParamUpdate.Id))
            {
                throw new Exception("此方法不允许指定参数的ID，数据库中的ID不允许修改，如需根据ID修改数据，请调用updateById或updateByIdBatch方法；错误出自：updateByOtherCondition");
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();
            //添加要修改的值
            StringBuilder sql = new StringBuilder("UPDATE MZ_GH SET ");
            if (null != mz_ghParamUpdate.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = mz_ghParamUpdate.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != mz_ghParamUpdate.Fk_jc_jm &&  ""!= mz_ghParamUpdate.Fk_jc_jm)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Direction = ParameterDirection.Input;
                pFk_jc_jm.Value = mz_ghParamUpdate.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);

            }
                        
            if (null != mz_ghParamUpdate.Brxm &&  ""!= mz_ghParamUpdate.Brxm)
            {
                this.isComma(sql);
                sql.Append(" BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Direction = ParameterDirection.Input;
                pBrxm.Value = mz_ghParamUpdate.Brxm;
                sqlparams.Add(pBrxm);

            }
                        
            if (DateTime.MinValue != mz_ghParamUpdate.Brcsrq &&null != mz_ghParamUpdate.Brcsrq)
            {
                this.isComma(sql);
                sql.Append(" BRCSRQ=:brcsrq ");
                OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Direction = ParameterDirection.Input;
                pBrcsrq.Value = mz_ghParamUpdate.Brcsrq;
                sqlparams.Add(pBrcsrq);

            }
                        
            if (null != mz_ghParamUpdate.Brxb &&  ""!= mz_ghParamUpdate.Brxb)
            {
                this.isComma(sql);
                sql.Append(" BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Direction = ParameterDirection.Input;
                pBrxb.Value = mz_ghParamUpdate.Brxb;
                sqlparams.Add(pBrxb);

            }
                        
            if (null != mz_ghParamUpdate.Brsfzh &&  ""!= mz_ghParamUpdate.Brsfzh)
            {
                this.isComma(sql);
                sql.Append(" BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Direction = ParameterDirection.Input;
                pBrsfzh.Value = mz_ghParamUpdate.Brsfzh;
                sqlparams.Add(pBrsfzh);

            }
                        
            if (null != mz_ghParamUpdate.Brlxdh &&  ""!= mz_ghParamUpdate.Brlxdh)
            {
                this.isComma(sql);
                sql.Append(" BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Direction = ParameterDirection.Input;
                pBrlxdh.Value = mz_ghParamUpdate.Brlxdh;
                sqlparams.Add(pBrlxdh);

            }
                        
            if (null != mz_ghParamUpdate.Brxzz_xzqh &&  ""!= mz_ghParamUpdate.Brxzz_xzqh)
            {
                this.isComma(sql);
                sql.Append(" BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Direction = ParameterDirection.Input;
                pBrxzz_xzqh.Value = mz_ghParamUpdate.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);

            }
                        
            if (null != mz_ghParamUpdate.Brxzz_detail &&  ""!= mz_ghParamUpdate.Brxzz_detail)
            {
                this.isComma(sql);
                sql.Append(" BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Direction = ParameterDirection.Input;
                pBrxzz_detail.Value = mz_ghParamUpdate.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);

            }
                        
            if (null != mz_ghParamUpdate.Brlx_code &&  ""!= mz_ghParamUpdate.Brlx_code)
            {
                this.isComma(sql);
                sql.Append(" BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Direction = ParameterDirection.Input;
                pBrlx_code.Value = mz_ghParamUpdate.Brlx_code;
                sqlparams.Add(pBrlx_code);

            }
                        
            if (null != mz_ghParamUpdate.Fk_jc_kswh &&  ""!= mz_ghParamUpdate.Fk_jc_kswh)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Direction = ParameterDirection.Input;
                pFk_jc_kswh.Value = mz_ghParamUpdate.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);

            }
                        
            if (null != mz_ghParamUpdate.Fk_jc_renyuan &&  ""!= mz_ghParamUpdate.Fk_jc_renyuan)
            {
                this.isComma(sql);
                sql.Append(" FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Direction = ParameterDirection.Input;
                pFk_jc_renyuan.Value = mz_ghParamUpdate.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);

            }
                        
            if (null != mz_ghParamUpdate.Ghlx_code &&  ""!= mz_ghParamUpdate.Ghlx_code)
            {
                this.isComma(sql);
                sql.Append(" GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Direction = ParameterDirection.Input;
                pGhlx_code.Value = mz_ghParamUpdate.Ghlx_code;
                sqlparams.Add(pGhlx_code);

            }
                        
            if (DateTime.MinValue != mz_ghParamUpdate.Ghrq &&null != mz_ghParamUpdate.Ghrq)
            {
                this.isComma(sql);
                sql.Append(" GHRQ=:ghrq ");
                OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Direction = ParameterDirection.Input;
                pGhrq.Value = mz_ghParamUpdate.Ghrq;
                sqlparams.Add(pGhrq);

            }
                        
            if (null != mz_ghParamUpdate.State_code &&  ""!= mz_ghParamUpdate.State_code)
            {
                this.isComma(sql);
                sql.Append(" STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Direction = ParameterDirection.Input;
                pState_code.Value = mz_ghParamUpdate.State_code;
                sqlparams.Add(pState_code);

            }
                        
            if (null != mz_ghParamUpdate.Zfbz &&  ""!= mz_ghParamUpdate.Zfbz)
            {
                this.isComma(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_ghParamUpdate.Zfbz;
                sqlparams.Add(pZfbz);

            }
                        
            //添加条件的参数
            
            if (null != mz_ghParamCondition.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = mz_ghParamCondition.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_jm &&  ""!= mz_ghParamCondition.Fk_jc_jm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Direction = ParameterDirection.Input;
                pFk_jc_jm.Value = mz_ghParamCondition.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);

            }
                        
            if (null != mz_ghParamCondition.Brxm &&  ""!= mz_ghParamCondition.Brxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Direction = ParameterDirection.Input;
                pBrxm.Value = mz_ghParamCondition.Brxm;
                sqlparams.Add(pBrxm);

            }
                        
            if (DateTime.MinValue != mz_ghParamCondition.Brcsrq &&null != mz_ghParamCondition.Brcsrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRCSRQ=:brcsrq ");
                OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Direction = ParameterDirection.Input;
                pBrcsrq.Value = mz_ghParamCondition.Brcsrq;
                sqlparams.Add(pBrcsrq);

            }
                        
            if (null != mz_ghParamCondition.Brxb &&  ""!= mz_ghParamCondition.Brxb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Direction = ParameterDirection.Input;
                pBrxb.Value = mz_ghParamCondition.Brxb;
                sqlparams.Add(pBrxb);

            }
                        
            if (null != mz_ghParamCondition.Brsfzh &&  ""!= mz_ghParamCondition.Brsfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Direction = ParameterDirection.Input;
                pBrsfzh.Value = mz_ghParamCondition.Brsfzh;
                sqlparams.Add(pBrsfzh);

            }
                        
            if (null != mz_ghParamCondition.Brlxdh &&  ""!= mz_ghParamCondition.Brlxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Direction = ParameterDirection.Input;
                pBrlxdh.Value = mz_ghParamCondition.Brlxdh;
                sqlparams.Add(pBrlxdh);

            }
                        
            if (null != mz_ghParamCondition.Brxzz_xzqh &&  ""!= mz_ghParamCondition.Brxzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Direction = ParameterDirection.Input;
                pBrxzz_xzqh.Value = mz_ghParamCondition.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);

            }
                        
            if (null != mz_ghParamCondition.Brxzz_detail &&  ""!= mz_ghParamCondition.Brxzz_detail)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Direction = ParameterDirection.Input;
                pBrxzz_detail.Value = mz_ghParamCondition.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);

            }
                        
            if (null != mz_ghParamCondition.Brlx_code &&  ""!= mz_ghParamCondition.Brlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Direction = ParameterDirection.Input;
                pBrlx_code.Value = mz_ghParamCondition.Brlx_code;
                sqlparams.Add(pBrlx_code);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_kswh &&  ""!= mz_ghParamCondition.Fk_jc_kswh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Direction = ParameterDirection.Input;
                pFk_jc_kswh.Value = mz_ghParamCondition.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);

            }
                        
            if (null != mz_ghParamCondition.Fk_jc_renyuan &&  ""!= mz_ghParamCondition.Fk_jc_renyuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Direction = ParameterDirection.Input;
                pFk_jc_renyuan.Value = mz_ghParamCondition.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);

            }
                        
            if (null != mz_ghParamCondition.Ghlx_code &&  ""!= mz_ghParamCondition.Ghlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Direction = ParameterDirection.Input;
                pGhlx_code.Value = mz_ghParamCondition.Ghlx_code;
                sqlparams.Add(pGhlx_code);

            }
                        
            if (DateTime.MinValue != mz_ghParamCondition.Ghrq &&null != mz_ghParamCondition.Ghrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" GHRQ=:ghrq ");
                OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Direction = ParameterDirection.Input;
                pGhrq.Value = mz_ghParamCondition.Ghrq;
                sqlparams.Add(pGhrq);

            }
                        
            if (null != mz_ghParamCondition.State_code &&  ""!= mz_ghParamCondition.State_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Direction = ParameterDirection.Input;
                pState_code.Value = mz_ghParamCondition.State_code;
                sqlparams.Add(pState_code);

            }
                        
            if (null != mz_ghParamCondition.Zfbz &&  ""!= mz_ghParamCondition.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_ghParamCondition.Zfbz;
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
        /// <returns>Mz_gh</returns>
        public Mz_gh findById(string id)
        {
            if (""==id||null==id)
            {
                throw new Exception("ID不能为空，请赋值后调用；错误出自：findById");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_GH A ");
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
        /// <param name="mz_ghParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="mz_ghParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Mz_gh对象集合list</returns>
        public List<object> find(Mz_gh mz_ghParam, Model.Common.PageInfo page,Mz_gh mz_ghParamLike,List<SortInfo> sortList)
        {

            //如果没有传查询条件参数，就new一个空的Mz_gh对象，标示查询所有数据
            if (null == mz_ghParam)
            {
                mz_ghParam = new Mz_gh();
            }
            if (null!=mz_ghParam.Id&&""!=mz_ghParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }
            List<Mz_gh> mz_ghParamList = new List<Mz_gh>();//接收查询出的Mz_gh对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjects(Mz_gh mz_ghParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");
            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_GH A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");
            //新建一个方法，在此加入多表连接的语句end
            
            
            if (null != mz_ghParam.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Direction = ParameterDirection.Input;
                pLsh.Value = mz_ghParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
            if (null != mz_ghParam.Fk_jc_jm && "" != mz_ghParam.Fk_jc_jm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Direction = ParameterDirection.Input;
                pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);
            }
                
            if (null != mz_ghParam.Brxm && "" != mz_ghParam.Brxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Direction = ParameterDirection.Input;
                pBrxm.Value = mz_ghParam.Brxm;
                sqlparams.Add(pBrxm);
            }
                
                if (DateTime.MinValue != mz_ghParam.Brcsrq &&null != mz_ghParam.Brcsrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRCSRQ=:brcsrq ");
                    OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Direction = ParameterDirection.Input;
                pBrcsrq.Value = mz_ghParam.Brcsrq;
                sqlparams.Add(pBrcsrq);
                }
                
            if (null != mz_ghParam.Brxb && "" != mz_ghParam.Brxb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Direction = ParameterDirection.Input;
                pBrxb.Value = mz_ghParam.Brxb;
                sqlparams.Add(pBrxb);
            }
                
            if (null != mz_ghParam.Brsfzh && "" != mz_ghParam.Brsfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Direction = ParameterDirection.Input;
                pBrsfzh.Value = mz_ghParam.Brsfzh;
                sqlparams.Add(pBrsfzh);
            }
                
            if (null != mz_ghParam.Brlxdh && "" != mz_ghParam.Brlxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Direction = ParameterDirection.Input;
                pBrlxdh.Value = mz_ghParam.Brlxdh;
                sqlparams.Add(pBrlxdh);
            }
                
            if (null != mz_ghParam.Brxzz_xzqh && "" != mz_ghParam.Brxzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Direction = ParameterDirection.Input;
                pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);
            }
                
            if (null != mz_ghParam.Brxzz_detail && "" != mz_ghParam.Brxzz_detail)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Direction = ParameterDirection.Input;
                pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);
            }
                
            if (null != mz_ghParam.Brlx_code && "" != mz_ghParam.Brlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Direction = ParameterDirection.Input;
                pBrlx_code.Value = mz_ghParam.Brlx_code;
                sqlparams.Add(pBrlx_code);
            }
                
            if (null != mz_ghParam.Fk_jc_kswh && "" != mz_ghParam.Fk_jc_kswh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Direction = ParameterDirection.Input;
                pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);
            }
                
            if (null != mz_ghParam.Fk_jc_renyuan && "" != mz_ghParam.Fk_jc_renyuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Direction = ParameterDirection.Input;
                pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);
            }
                
            if (null != mz_ghParam.Ghlx_code && "" != mz_ghParam.Ghlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Direction = ParameterDirection.Input;
                pGhlx_code.Value = mz_ghParam.Ghlx_code;
                sqlparams.Add(pGhlx_code);
            }
                
                if (DateTime.MinValue != mz_ghParam.Ghrq &&null != mz_ghParam.Ghrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHRQ=:ghrq ");
                    OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Direction = ParameterDirection.Input;
                pGhrq.Value = mz_ghParam.Ghrq;
                sqlparams.Add(pGhrq);
                }
                
            if (null != mz_ghParam.State_code && "" != mz_ghParam.State_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Direction = ParameterDirection.Input;
                pState_code.Value = mz_ghParam.State_code;
                sqlparams.Add(pState_code);
            }
                
            if (null != mz_ghParam.Zfbz && "" != mz_ghParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Direction = ParameterDirection.Input;
                pZfbz.Value = mz_ghParam.Zfbz;
                sqlparams.Add(pZfbz);
            }
                
            if(mz_ghParamLike!=null)
            {

                if (null != mz_ghParamLike.Fk_jc_jm && "" != mz_ghParamLike.Fk_jc_jm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_JM LIKE '%'||:fk_jc_jm||'%' ");
                    OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                    pFk_jc_jm.Direction = ParameterDirection.Input;
                    pFk_jc_jm.Value = mz_ghParamLike.Fk_jc_jm;
                    sqlparams.Add(pFk_jc_jm);
                }
                
                if (null != mz_ghParamLike.Brxm && "" != mz_ghParamLike.Brxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXM LIKE '%'||:brxm||'%' ");
                    OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                    pBrxm.Direction = ParameterDirection.Input;
                    pBrxm.Value = mz_ghParamLike.Brxm;
                    sqlparams.Add(pBrxm);
                }
                
                if (null != mz_ghParamLike.Brxb && "" != mz_ghParamLike.Brxb)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXB LIKE '%'||:brxb||'%' ");
                    OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                    pBrxb.Direction = ParameterDirection.Input;
                    pBrxb.Value = mz_ghParamLike.Brxb;
                    sqlparams.Add(pBrxb);
                }
                
                if (null != mz_ghParamLike.Brsfzh && "" != mz_ghParamLike.Brsfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRSFZH LIKE '%'||:brsfzh||'%' ");
                    OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                    pBrsfzh.Direction = ParameterDirection.Input;
                    pBrsfzh.Value = mz_ghParamLike.Brsfzh;
                    sqlparams.Add(pBrsfzh);
                }
                
                if (null != mz_ghParamLike.Brlxdh && "" != mz_ghParamLike.Brlxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLXDH LIKE '%'||:brlxdh||'%' ");
                    OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                    pBrlxdh.Direction = ParameterDirection.Input;
                    pBrlxdh.Value = mz_ghParamLike.Brlxdh;
                    sqlparams.Add(pBrlxdh);
                }
                
                if (null != mz_ghParamLike.Brxzz_xzqh && "" != mz_ghParamLike.Brxzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_XZQH LIKE '%'||:brxzz_xzqh||'%' ");
                    OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                    pBrxzz_xzqh.Direction = ParameterDirection.Input;
                    pBrxzz_xzqh.Value = mz_ghParamLike.Brxzz_xzqh;
                    sqlparams.Add(pBrxzz_xzqh);
                }
                
                if (null != mz_ghParamLike.Brxzz_detail && "" != mz_ghParamLike.Brxzz_detail)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_DETAIL LIKE '%'||:brxzz_detail||'%' ");
                    OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                    pBrxzz_detail.Direction = ParameterDirection.Input;
                    pBrxzz_detail.Value = mz_ghParamLike.Brxzz_detail;
                    sqlparams.Add(pBrxzz_detail);
                }
                
                if (null != mz_ghParamLike.Brlx_code && "" != mz_ghParamLike.Brlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLX_CODE LIKE '%'||:brlx_code||'%' ");
                    OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                    pBrlx_code.Direction = ParameterDirection.Input;
                    pBrlx_code.Value = mz_ghParamLike.Brlx_code;
                    sqlparams.Add(pBrlx_code);
                }
                
                if (null != mz_ghParamLike.Fk_jc_kswh && "" != mz_ghParamLike.Fk_jc_kswh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_KSWH LIKE '%'||:fk_jc_kswh||'%' ");
                    OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                    pFk_jc_kswh.Direction = ParameterDirection.Input;
                    pFk_jc_kswh.Value = mz_ghParamLike.Fk_jc_kswh;
                    sqlparams.Add(pFk_jc_kswh);
                }
                
                if (null != mz_ghParamLike.Fk_jc_renyuan && "" != mz_ghParamLike.Fk_jc_renyuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_RENYUAN LIKE '%'||:fk_jc_renyuan||'%' ");
                    OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                    pFk_jc_renyuan.Direction = ParameterDirection.Input;
                    pFk_jc_renyuan.Value = mz_ghParamLike.Fk_jc_renyuan;
                    sqlparams.Add(pFk_jc_renyuan);
                }
                
                if (null != mz_ghParamLike.Ghlx_code && "" != mz_ghParamLike.Ghlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHLX_CODE LIKE '%'||:ghlx_code||'%' ");
                    OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                    pGhlx_code.Direction = ParameterDirection.Input;
                    pGhlx_code.Value = mz_ghParamLike.Ghlx_code;
                    sqlparams.Add(pGhlx_code);
                }
                
                if (null != mz_ghParamLike.State_code && "" != mz_ghParamLike.State_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.STATE_CODE LIKE '%'||:state_code||'%' ");
                    OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                    pState_code.Direction = ParameterDirection.Input;
                    pState_code.Value = mz_ghParamLike.State_code;
                    sqlparams.Add(pState_code);
                }
                
                if (null != mz_ghParamLike.Zfbz && "" != mz_ghParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_ghParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            this.addSort(sql, sortList);//排序
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Mz_gh>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Mz_gh>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                //mz_ghParamList.Add(this.dataSetContactObjectsToModel(row));
                mz_ghParamList.Add(this.dataSetToModel(row));
            }
            
             //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(mz_ghParamList);//把List<Mz_gh>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }

        
        
        /// <summary>
        /// 根据条件得到集合的数量
        /// 第二个条件是模糊查询的条件
        /// </summary>
        /// <returns>int</returns>
        public int getCount(Mz_gh mz_ghParam,Mz_gh mz_ghParamLike)
        {
            //如果没有传查询条件参数，就new一个空的Mz_gh对象，标示查询所有数据
            if (null == mz_ghParam)
            {
                mz_ghParam = new Mz_gh();
            }
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT COUNT(ID) FROM MZ_GH A");
            if (null != mz_ghParam.Lsh)
            {
                this.isComma(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Value = mz_ghParam.Lsh;
                sqlparams.Add(pLsh);

            }
                        
                if (null != mz_ghParam.Fk_jc_jm && "" != mz_ghParam.Fk_jc_jm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_JM=:fk_jc_jm ");
                    OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);
                }
                
                if (null != mz_ghParam.Brxm && "" != mz_ghParam.Brxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXM=:brxm ");
                    OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Value = mz_ghParam.Brxm;
                sqlparams.Add(pBrxm);
                }
                
                if (DateTime.MinValue != mz_ghParam.Brcsrq &&null != mz_ghParam.Brcsrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRCSRQ=:brcsrq ");
                    OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Value = mz_ghParam.Brcsrq;
                sqlparams.Add(pBrcsrq);
                }
                
                if (null != mz_ghParam.Brxb && "" != mz_ghParam.Brxb)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXB=:brxb ");
                    OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Value = mz_ghParam.Brxb;
                sqlparams.Add(pBrxb);
                }
                
                if (null != mz_ghParam.Brsfzh && "" != mz_ghParam.Brsfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRSFZH=:brsfzh ");
                    OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Value = mz_ghParam.Brsfzh;
                sqlparams.Add(pBrsfzh);
                }
                
                if (null != mz_ghParam.Brlxdh && "" != mz_ghParam.Brlxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLXDH=:brlxdh ");
                    OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Value = mz_ghParam.Brlxdh;
                sqlparams.Add(pBrlxdh);
                }
                
                if (null != mz_ghParam.Brxzz_xzqh && "" != mz_ghParam.Brxzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_XZQH=:brxzz_xzqh ");
                    OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);
                }
                
                if (null != mz_ghParam.Brxzz_detail && "" != mz_ghParam.Brxzz_detail)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_DETAIL=:brxzz_detail ");
                    OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);
                }
                
                if (null != mz_ghParam.Brlx_code && "" != mz_ghParam.Brlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLX_CODE=:brlx_code ");
                    OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Value = mz_ghParam.Brlx_code;
                sqlparams.Add(pBrlx_code);
                }
                
                if (null != mz_ghParam.Fk_jc_kswh && "" != mz_ghParam.Fk_jc_kswh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_KSWH=:fk_jc_kswh ");
                    OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);
                }
                
                if (null != mz_ghParam.Fk_jc_renyuan && "" != mz_ghParam.Fk_jc_renyuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_RENYUAN=:fk_jc_renyuan ");
                    OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);
                }
                
                if (null != mz_ghParam.Ghlx_code && "" != mz_ghParam.Ghlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHLX_CODE=:ghlx_code ");
                    OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Value = mz_ghParam.Ghlx_code;
                sqlparams.Add(pGhlx_code);
                }
                
                if (DateTime.MinValue != mz_ghParam.Ghrq &&null != mz_ghParam.Ghrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHRQ=:ghrq ");
                    OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Value = mz_ghParam.Ghrq;
                sqlparams.Add(pGhrq);
                }
                
                if (null != mz_ghParam.State_code && "" != mz_ghParam.State_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.STATE_CODE=:state_code ");
                    OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Value = mz_ghParam.State_code;
                sqlparams.Add(pState_code);
                }
                
                if (null != mz_ghParam.Zfbz && "" != mz_ghParam.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Value = mz_ghParam.Zfbz;
                sqlparams.Add(pZfbz);
                }
                
            if(mz_ghParamLike!=null)
            {

                if (null != mz_ghParamLike.Fk_jc_jm && "" != mz_ghParamLike.Fk_jc_jm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_JM LIKE '%'||:fk_jc_jm||'%' ");
                    OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                    pFk_jc_jm.Direction = ParameterDirection.Input;
                    pFk_jc_jm.Value = mz_ghParamLike.Fk_jc_jm;
                    sqlparams.Add(pFk_jc_jm);
                }
                
                if (null != mz_ghParamLike.Brxm && "" != mz_ghParamLike.Brxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXM LIKE '%'||:brxm||'%' ");
                    OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                    pBrxm.Direction = ParameterDirection.Input;
                    pBrxm.Value = mz_ghParamLike.Brxm;
                    sqlparams.Add(pBrxm);
                }
                
                if (null != mz_ghParamLike.Brxb && "" != mz_ghParamLike.Brxb)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXB LIKE '%'||:brxb||'%' ");
                    OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                    pBrxb.Direction = ParameterDirection.Input;
                    pBrxb.Value = mz_ghParamLike.Brxb;
                    sqlparams.Add(pBrxb);
                }
                
                if (null != mz_ghParamLike.Brsfzh && "" != mz_ghParamLike.Brsfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRSFZH LIKE '%'||:brsfzh||'%' ");
                    OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                    pBrsfzh.Direction = ParameterDirection.Input;
                    pBrsfzh.Value = mz_ghParamLike.Brsfzh;
                    sqlparams.Add(pBrsfzh);
                }
                
                if (null != mz_ghParamLike.Brlxdh && "" != mz_ghParamLike.Brlxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLXDH LIKE '%'||:brlxdh||'%' ");
                    OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                    pBrlxdh.Direction = ParameterDirection.Input;
                    pBrlxdh.Value = mz_ghParamLike.Brlxdh;
                    sqlparams.Add(pBrlxdh);
                }
                
                if (null != mz_ghParamLike.Brxzz_xzqh && "" != mz_ghParamLike.Brxzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_XZQH LIKE '%'||:brxzz_xzqh||'%' ");
                    OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                    pBrxzz_xzqh.Direction = ParameterDirection.Input;
                    pBrxzz_xzqh.Value = mz_ghParamLike.Brxzz_xzqh;
                    sqlparams.Add(pBrxzz_xzqh);
                }
                
                if (null != mz_ghParamLike.Brxzz_detail && "" != mz_ghParamLike.Brxzz_detail)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_DETAIL LIKE '%'||:brxzz_detail||'%' ");
                    OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                    pBrxzz_detail.Direction = ParameterDirection.Input;
                    pBrxzz_detail.Value = mz_ghParamLike.Brxzz_detail;
                    sqlparams.Add(pBrxzz_detail);
                }
                
                if (null != mz_ghParamLike.Brlx_code && "" != mz_ghParamLike.Brlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLX_CODE LIKE '%'||:brlx_code||'%' ");
                    OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                    pBrlx_code.Direction = ParameterDirection.Input;
                    pBrlx_code.Value = mz_ghParamLike.Brlx_code;
                    sqlparams.Add(pBrlx_code);
                }
                
                if (null != mz_ghParamLike.Fk_jc_kswh && "" != mz_ghParamLike.Fk_jc_kswh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_KSWH LIKE '%'||:fk_jc_kswh||'%' ");
                    OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                    pFk_jc_kswh.Direction = ParameterDirection.Input;
                    pFk_jc_kswh.Value = mz_ghParamLike.Fk_jc_kswh;
                    sqlparams.Add(pFk_jc_kswh);
                }
                
                if (null != mz_ghParamLike.Fk_jc_renyuan && "" != mz_ghParamLike.Fk_jc_renyuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_RENYUAN LIKE '%'||:fk_jc_renyuan||'%' ");
                    OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                    pFk_jc_renyuan.Direction = ParameterDirection.Input;
                    pFk_jc_renyuan.Value = mz_ghParamLike.Fk_jc_renyuan;
                    sqlparams.Add(pFk_jc_renyuan);
                }
                
                if (null != mz_ghParamLike.Ghlx_code && "" != mz_ghParamLike.Ghlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHLX_CODE LIKE '%'||:ghlx_code||'%' ");
                    OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                    pGhlx_code.Direction = ParameterDirection.Input;
                    pGhlx_code.Value = mz_ghParamLike.Ghlx_code;
                    sqlparams.Add(pGhlx_code);
                }
                
                if (null != mz_ghParamLike.State_code && "" != mz_ghParamLike.State_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.STATE_CODE LIKE '%'||:state_code||'%' ");
                    OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                    pState_code.Direction = ParameterDirection.Input;
                    pState_code.Value = mz_ghParamLike.State_code;
                    sqlparams.Add(pState_code);
                }
                
                if (null != mz_ghParamLike.Zfbz && "" != mz_ghParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_ghParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }
                
            }

            this.b_isWhere = false;
            return Int32.Parse(OracleHelper.ExecuteScalar(sql.ToString(),sqlparams.ToArray()).ToString());
        }


        /// <summary>
        /// 通用的保存方法，根据用户传入的参数，有ID为修改，没有ID为新增(手动生成OracleConnection对象，此方法用于事务，使用事务必须使用同一个OracleConnection对象)
        /// </summary>
        /// <param name="mz_ghParam"></param>
        /// <returns></returns>
        public bool save(Mz_gh mz_ghParam,OracleConnection con)
        {
            if ("" != mz_ghParam.Id && null != mz_ghParam.Id)
            {
                //修改
                return this.updateById(mz_ghParam,con);
            }
            else
            {
                //新增
                return this.insert(mz_ghParam,con);
            }
        }

        /// <summary>
        /// 把dataset中的一行转换为model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Mz_gh dataSetToModel(DataRow row)
        {
            Mz_gh mz_ghParam = new Mz_gh();
            mz_ghParam.Id = Convert.ToString(row["ID"]).Trim(); 
            mz_ghParam.Lsh =  (decimal?)this.convertDBNullValue(row["LSH"]);
            mz_ghParam.Fk_jc_jm = Convert.ToString(row["FK_JC_JM"]).Trim(); 
            mz_ghParam.Brxm = Convert.ToString(row["BRXM"]).Trim(); 
            mz_ghParam.Brcsrq =  (DateTime?)this.convertDBNullValue(row["BRCSRQ"]);
            mz_ghParam.Brxb = Convert.ToString(row["BRXB"]).Trim(); 
            mz_ghParam.Brsfzh = Convert.ToString(row["BRSFZH"]).Trim(); 
            mz_ghParam.Brlxdh = Convert.ToString(row["BRLXDH"]).Trim(); 
            mz_ghParam.Brxzz_xzqh = Convert.ToString(row["BRXZZ_XZQH"]).Trim(); 
            mz_ghParam.Brxzz_detail = Convert.ToString(row["BRXZZ_DETAIL"]).Trim(); 
            mz_ghParam.Brlx_code = Convert.ToString(row["BRLX_CODE"]).Trim(); 
            mz_ghParam.Fk_jc_kswh = Convert.ToString(row["FK_JC_KSWH"]).Trim(); 
            mz_ghParam.Fk_jc_renyuan = Convert.ToString(row["FK_JC_RENYUAN"]).Trim(); 
            mz_ghParam.Ghlx_code = Convert.ToString(row["GHLX_CODE"]).Trim(); 
            mz_ghParam.Ghrq =  (DateTime?)this.convertDBNullValue(row["GHRQ"]);
            mz_ghParam.State_code = Convert.ToString(row["STATE_CODE"]).Trim(); 
            mz_ghParam.Zfbz = Convert.ToString(row["ZFBZ"]).Trim(); 
            
            return mz_ghParam;
        }

       
        
        //*******************在此以后添加新的方法start
        #region DAL层的implement,实现，start

        /// <summary>
        /// 把dataset中的一行转换为model, 包括相关联的外键对象
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private Mz_gh dataSetContactObjectsToModel(DataRow row)
        {
            Mz_gh mz_ghParam = this.dataSetToModel(row);

            #region 添加Jc_jm类别实体对象
            Jc_jm jc_jm = new Jc_jm();
            jc_jm.Id = Convert.ToString(row["JM_ID"]).Trim();
            jc_jm.Sfzh = Convert.ToString(row["JM_SFZH"]).Trim();
            jc_jm.Xm = Convert.ToString(row["JM_XM"]).Trim();
            jc_jm.Xb_code = Convert.ToString(row["JM_XB_CODE"]).Trim();
            jc_jm.Csrq = (DateTime?)this.convertDBNullValue(row["JM_CSRQ"]);
            jc_jm.Mz_code = Convert.ToString(row["JM_MZ_CODE"]).Trim();
            jc_jm.Xx_code = Convert.ToString(row["JM_XX_CODE"]).Trim();
            jc_jm.Rh_code = Convert.ToString(row["JM_RH_CODE"]).Trim();
            jc_jm.Csdz = Convert.ToString(row["JM_CSDZ"]).Trim();
            jc_jm.Hjdz = Convert.ToString(row["JM_HJDZ"]).Trim();
            jc_jm.Xzz_xzqh = Convert.ToString(row["JM_XZZ_XZQH"]).Trim();
            jc_jm.Xzz_xiang_xi_di_zhi = Convert.ToString(row["JM_XZZ_XIANG_XI_DI_ZHI"]).Trim();
            jc_jm.Gzdw_xx = Convert.ToString(row["JM_GZDW_XX"]).Trim();
            jc_jm.Zy_code = Convert.ToString(row["JM_ZY_CODE"]).Trim();
            jc_jm.Zy = Convert.ToString(row["JM_ZY"]).Trim();
            jc_jm.Wh_code = Convert.ToString(row["JM_WH_CODE"]).Trim();
            jc_jm.Hyzk_code = Convert.ToString(row["JM_HYZK_CODE"]).Trim();
            jc_jm.Lxdh = Convert.ToString(row["JM_LXDH"]).Trim();
            jc_jm.Jhr_xm = Convert.ToString(row["JM_JHR_XM"]).Trim();
            jc_jm.Jhr_dh = Convert.ToString(row["JM_JHR_DH"]).Trim();
            jc_jm.Nhbm = Convert.ToString(row["JM_NHBM"]).Trim();
            jc_jm.Ybkh = Convert.ToString(row["JM_YBKH"]).Trim();
            jc_jm.Cjkh = Convert.ToString(row["JM_CJKH"]).Trim();
            jc_jm.Zfzh = Convert.ToString(row["JM_ZFZH"]).Trim();
            jc_jm.Jkdabh = Convert.ToString(row["JM_JKDABH"]).Trim();
            jc_jm.Pym = Convert.ToString(row["JM_PYM"]).Trim();
            jc_jm.Wbm = Convert.ToString(row["JM_WBM"]).Trim();
            jc_jm.Zfbz = Convert.ToString(row["JM_ZFBZ"]).Trim();

            mz_ghParam.Jc_jm = jc_jm;
            #endregion 添加Jc_jm类别实体对象

            //添加代码类别实体对象,病人类型对象
            Jc_code brlxCode = new Jc_code();
            brlxCode.Id = Convert.ToString(row["BRLX_CODE_ID"]).Trim();
            brlxCode.Name = Convert.ToString(row["BRLX_CODE_NAME"]).Trim();
            brlxCode.Value = Convert.ToString(row["BRLX_CODE_VALUE"]).Trim();
            brlxCode.Fk_code_type = Convert.ToString(row["BRLX_CODE_FKCODETYPE"]).Trim();
            brlxCode.Zfbz = Convert.ToString(row["BRLX_CODE_ZFBZ"]).Trim();
            brlxCode.Remark = Convert.ToString(row["BRLX_CODE_REMARK"]).Trim();
            mz_ghParam.BrlxCode = brlxCode;

            #region 添加Jc_kswh类别实体对象
            Jc_kswh jc_kswh = new Jc_kswh();
            jc_kswh.Id = Convert.ToString(row["JH_ID"]).Trim();
            jc_kswh.Ksbh = Convert.ToString(row["JH_KSBH"]).Trim();
            jc_kswh.Ksmc = Convert.ToString(row["JH_KSMC"]).Trim();
            jc_kswh.Mzbz_code = Convert.ToString(row["JH_MZBZ_CODE"]).Trim();
            jc_kswh.Zybz_code = Convert.ToString(row["JH_ZYBZ_CODE"]).Trim();
            jc_kswh.Ykbz_code = Convert.ToString(row["JH_YKBZ_CODE"]).Trim();
            jc_kswh.Yfbz_code = Convert.ToString(row["JH_YFBZ_CODE"]).Trim();
            jc_kswh.Yjbz_code = Convert.ToString(row["JH_YJBZ_CODE"]).Trim();
            jc_kswh.Ssbz_code = Convert.ToString(row["JH_SSBZ_CODE"]).Trim();
            jc_kswh.Zfbz = Convert.ToString(row["JH_ZFBZ"]).Trim();

            mz_ghParam.Jc_kswh = jc_kswh;
            #endregion 添加Jc_kswh类别实体对象

            #region 添加Jc_renyuan类别实体对象
            Jc_renyuan jc_renyuan = new Jc_renyuan();
            jc_renyuan.Id = Convert.ToString(row["JN_ID"]).Trim();
            jc_renyuan.Xm = Convert.ToString(row["JN_XM"]).Trim();
            jc_renyuan.Xb_code = Convert.ToString(row["JN_XB_CODE"]).Trim();
            jc_renyuan.Mz_code = Convert.ToString(row["JN_MZ_CODE"]).Trim();
            jc_renyuan.Csrq = (DateTime?)this.convertDBNullValue(row["JN_CSRQ"]);
            jc_renyuan.Sfzh = Convert.ToString(row["JN_SFZH"]).Trim();
            jc_renyuan.Zzmm_code = Convert.ToString(row["JN_ZZMM_CODE"]).Trim();
            jc_renyuan.Hyzk_code = Convert.ToString(row["JN_HYZK_CODE"]).Trim();
            jc_renyuan.Byxx = Convert.ToString(row["JN_BYXX"]).Trim();
            jc_renyuan.Xl_code = Convert.ToString(row["JN_XL_CODE"]).Trim();
            jc_renyuan.Cjgzsj = (DateTime?)this.convertDBNullValue(row["JN_CJGZSJ"]);
            jc_renyuan.Zy = Convert.ToString(row["JN_ZY"]).Trim();
            jc_renyuan.Jg = Convert.ToString(row["JN_JG"]).Trim();
            jc_renyuan.Dz = Convert.ToString(row["JN_DZ"]).Trim();
            jc_renyuan.Lxdh = Convert.ToString(row["JN_LXDH"]).Trim();
            jc_renyuan.Qq = Convert.ToString(row["JN_QQ"]).Trim();
            jc_renyuan.Yx = Convert.ToString(row["JN_YX"]).Trim();
            jc_renyuan.Bz = Convert.ToString(row["JN_BZ"]).Trim();
            jc_renyuan.Pym = Convert.ToString(row["JN_PYM"]).Trim();
            jc_renyuan.Wbm = Convert.ToString(row["JN_WBM"]).Trim();
            jc_renyuan.Rylx_code = Convert.ToString(row["JN_RYLX_CODE"]).Trim();
            jc_renyuan.Zfbz = Convert.ToString(row["JN_ZFBZ"]).Trim();

            mz_ghParam.Jc_renyuan = jc_renyuan;
            #endregion 添加Jc_renyuan类别实体对象

            //添加代码类别实体对象,挂号类型（关联代码表）对象
            Jc_code ghlxCode = new Jc_code();
            ghlxCode.Id = Convert.ToString(row["GHLX_CODE_ID"]).Trim();
            ghlxCode.Name = Convert.ToString(row["GHLX_CODE_NAME"]).Trim();
            ghlxCode.Value = Convert.ToString(row["GHLX_CODE_VALUE"]).Trim();
            ghlxCode.Fk_code_type = Convert.ToString(row["GHLX_CODE_FKCODETYPE"]).Trim();
            ghlxCode.Zfbz = Convert.ToString(row["GHLX_CODE_ZFBZ"]).Trim();
            ghlxCode.Remark = Convert.ToString(row["GHLX_CODE_REMARK"]).Trim();
            mz_ghParam.GhlxCode = ghlxCode;

            //添加代码类别实体对象,挂号状态对象
            Jc_code stateCode = new Jc_code();
            stateCode.Id = Convert.ToString(row["STATE_CODE_ID"]).Trim();
            stateCode.Name = Convert.ToString(row["STATE_CODE_NAME"]).Trim();
            stateCode.Value = Convert.ToString(row["STATE_CODE_VALUE"]).Trim();
            stateCode.Fk_code_type = Convert.ToString(row["STATE_CODE_FKCODETYPE"]).Trim();
            stateCode.Zfbz = Convert.ToString(row["STATE_CODE_ZFBZ"]).Trim();
            stateCode.Remark = Convert.ToString(row["STATE_CODE_REMARK"]).Trim();
            mz_ghParam.StateCode = stateCode;

            return mz_ghParam;
        }



        /// <summary>
        /// 查找指定ID的用户,得到相关联的外键对象的方法
        /// </summary>
        /// <remarks>如果id为null、id重复、id未找到就抛异常</remarks>
        /// <returns>Mz_gh</returns>
        public Mz_gh findContactObjectsById(string id)
        {
            if ("" == id || null == id)
            {
                throw new Exception("主键ID不能为空，请赋值");
            }
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findContactObjectsById，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_JM.ID AS JM_ID
            ,TT_JC_JM.SFZH AS JM_SFZH
            ,TT_JC_JM.XM AS JM_XM
            ,TT_JC_JM.XB_CODE AS JM_XB_CODE
            ,TT_JC_JM.CSRQ AS JM_CSRQ
            ,TT_JC_JM.MZ_CODE AS JM_MZ_CODE
            ,TT_JC_JM.XX_CODE AS JM_XX_CODE
            ,TT_JC_JM.RH_CODE AS JM_RH_CODE
            ,TT_JC_JM.CSDZ AS JM_CSDZ
            ,TT_JC_JM.HJDZ AS JM_HJDZ
            ,TT_JC_JM.XZZ_XZQH AS JM_XZZ_XZQH
            ,TT_JC_JM.XZZ_XIANG_XI_DI_ZHI AS JM_XZZ_XIANG_XI_DI_ZHI
            ,TT_JC_JM.GZDW_XX AS JM_GZDW_XX
            ,TT_JC_JM.ZY_CODE AS JM_ZY_CODE
            ,TT_JC_JM.ZY AS JM_ZY
            ,TT_JC_JM.WH_CODE AS JM_WH_CODE
            ,TT_JC_JM.HYZK_CODE AS JM_HYZK_CODE
            ,TT_JC_JM.LXDH AS JM_LXDH
            ,TT_JC_JM.JHR_XM AS JM_JHR_XM
            ,TT_JC_JM.JHR_DH AS JM_JHR_DH
            ,TT_JC_JM.NHBM AS JM_NHBM
            ,TT_JC_JM.YBKH AS JM_YBKH
            ,TT_JC_JM.CJKH AS JM_CJKH
            ,TT_JC_JM.ZFZH AS JM_ZFZH
            ,TT_JC_JM.JKDABH AS JM_JKDABH
            ,TT_JC_JM.PYM AS JM_PYM
            ,TT_JC_JM.WBM AS JM_WBM
            ,TT_JC_JM.ZFBZ AS JM_ZFBZ
            ");

            sql.Append(@"
            ,TT_BRLX_CODE.ID AS BRLX_CODE_ID,TT_BRLX_CODE.NAME AS BRLX_CODE_NAME,TT_BRLX_CODE.VALUE AS BRLX_CODE_VALUE,TT_BRLX_CODE.FK_CODE_TYPE AS BRLX_CODE_FKCODETYPE,TT_BRLX_CODE.ZFBZ AS BRLX_CODE_ZFBZ,TT_BRLX_CODE.REMARK AS BRLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_JC_KSWH.ID AS JH_ID
            ,TT_JC_KSWH.KSBH AS JH_KSBH
            ,TT_JC_KSWH.KSMC AS JH_KSMC
            ,TT_JC_KSWH.MZBZ_CODE AS JH_MZBZ_CODE
            ,TT_JC_KSWH.ZYBZ_CODE AS JH_ZYBZ_CODE
            ,TT_JC_KSWH.YKBZ_CODE AS JH_YKBZ_CODE
            ,TT_JC_KSWH.YFBZ_CODE AS JH_YFBZ_CODE
            ,TT_JC_KSWH.YJBZ_CODE AS JH_YJBZ_CODE
            ,TT_JC_KSWH.SSBZ_CODE AS JH_SSBZ_CODE
            ,TT_JC_KSWH.ZFBZ AS JH_ZFBZ
            ");

            sql.Append(@"
            ,TT_JC_RENYUAN.ID AS JN_ID
            ,TT_JC_RENYUAN.XM AS JN_XM
            ,TT_JC_RENYUAN.XB_CODE AS JN_XB_CODE
            ,TT_JC_RENYUAN.MZ_CODE AS JN_MZ_CODE
            ,TT_JC_RENYUAN.CSRQ AS JN_CSRQ
            ,TT_JC_RENYUAN.SFZH AS JN_SFZH
            ,TT_JC_RENYUAN.ZZMM_CODE AS JN_ZZMM_CODE
            ,TT_JC_RENYUAN.HYZK_CODE AS JN_HYZK_CODE
            ,TT_JC_RENYUAN.BYXX AS JN_BYXX
            ,TT_JC_RENYUAN.XL_CODE AS JN_XL_CODE
            ,TT_JC_RENYUAN.CJGZSJ AS JN_CJGZSJ
            ,TT_JC_RENYUAN.ZY AS JN_ZY
            ,TT_JC_RENYUAN.JG AS JN_JG
            ,TT_JC_RENYUAN.DZ AS JN_DZ
            ,TT_JC_RENYUAN.LXDH AS JN_LXDH
            ,TT_JC_RENYUAN.QQ AS JN_QQ
            ,TT_JC_RENYUAN.YX AS JN_YX
            ,TT_JC_RENYUAN.BZ AS JN_BZ
            ,TT_JC_RENYUAN.PYM AS JN_PYM
            ,TT_JC_RENYUAN.WBM AS JN_WBM
            ,TT_JC_RENYUAN.RYLX_CODE AS JN_RYLX_CODE
            ,TT_JC_RENYUAN.ZFBZ AS JN_ZFBZ
            ");

            sql.Append(@"
            ,TT_GHLX_CODE.ID AS GHLX_CODE_ID,TT_GHLX_CODE.NAME AS GHLX_CODE_NAME,TT_GHLX_CODE.VALUE AS GHLX_CODE_VALUE,TT_GHLX_CODE.FK_CODE_TYPE AS GHLX_CODE_FKCODETYPE,TT_GHLX_CODE.ZFBZ AS GHLX_CODE_ZFBZ,TT_GHLX_CODE.REMARK AS GHLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_STATE_CODE.ID AS STATE_CODE_ID,TT_STATE_CODE.NAME AS STATE_CODE_NAME,TT_STATE_CODE.VALUE AS STATE_CODE_VALUE,TT_STATE_CODE.FK_CODE_TYPE AS STATE_CODE_FKCODETYPE,TT_STATE_CODE.ZFBZ AS STATE_CODE_ZFBZ,TT_STATE_CODE.REMARK AS STATE_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_GH A ");
            //新建一个方法，在此加入多表连接的语句start
            //sql.Append("LEFT JOIN 外键表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_JM TT_JC_JM 
            ON A.FK_JC_JM = TT_JC_JM.ID

            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.病人类型 + @"')) TT_BRLX_CODE
                        ON A.BRLX_CODE = TT_BRLX_CODE.VALUE
            ");

            sql.Append(@"
            LEFT JOIN JC_KSWH TT_JC_KSWH 
            ON A.FK_JC_KSWH = TT_JC_KSWH.ID

            ");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_JC_RENYUAN = TT_JC_RENYUAN.ID

            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.挂号_类型 + @"')) TT_GHLX_CODE
                        ON A.GHLX_CODE = TT_GHLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.挂号_状态 + @"')) TT_STATE_CODE
                        ON A.STATE_CODE = TT_STATE_CODE.VALUE
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
        /// <param name="mz_ghParam"></param>
        /// <param name="page">分页对象</param>
        ///<param name="mz_ghParamLike">模糊查询参数</param>
        ///<param name="sortList">排序参数对象的集合</param>
        /// <returns>满足条件的所有Mz_gh对象集合list</returns>
        public List<object> findContactObjects(Mz_gh mz_ghParam, Model.Common.PageInfo page, Mz_gh mz_ghParamLike, List<SortInfo> sortList)
        {
            //如果没有传查询条件参数，就new一个空的Mz_gh对象，标示查询所有数据
            if (null == mz_ghParam)
            {
                mz_ghParam = new Mz_gh();
            }
            if (null != mz_ghParam.Id && "" != mz_ghParam.Id)
            {
                throw new Exception("此方法不允许指定参数ID，如果需要根据ID查询数据，请调用findById方法；错误出自：find");
            }

            List<Mz_gh> mz_ghParamList = new List<Mz_gh>();//接收查询出的Mz_gh对象集合
            List<OracleParameter> sqlparams = new List<OracleParameter>();//保存参数的集合
            StringBuilder sql = new StringBuilder("SELECT A.* ");
            //新建方法findAllContactObjects(Mz_gh mz_ghParam, Model.Common.PageInfo page)，在此加入多表连接要显示的项start
            //sql.Append(",B.字段一,B.字段二,B.字段三");

            sql.Append(@"
            ,TT_JC_JM.ID AS JM_ID
            ,TT_JC_JM.SFZH AS JM_SFZH
            ,TT_JC_JM.XM AS JM_XM
            ,TT_JC_JM.XB_CODE AS JM_XB_CODE
            ,TT_JC_JM.CSRQ AS JM_CSRQ
            ,TT_JC_JM.MZ_CODE AS JM_MZ_CODE
            ,TT_JC_JM.XX_CODE AS JM_XX_CODE
            ,TT_JC_JM.RH_CODE AS JM_RH_CODE
            ,TT_JC_JM.CSDZ AS JM_CSDZ
            ,TT_JC_JM.HJDZ AS JM_HJDZ
            ,TT_JC_JM.XZZ_XZQH AS JM_XZZ_XZQH
            ,TT_JC_JM.XZZ_XIANG_XI_DI_ZHI AS JM_XZZ_XIANG_XI_DI_ZHI
            ,TT_JC_JM.GZDW_XX AS JM_GZDW_XX
            ,TT_JC_JM.ZY_CODE AS JM_ZY_CODE
            ,TT_JC_JM.ZY AS JM_ZY
            ,TT_JC_JM.WH_CODE AS JM_WH_CODE
            ,TT_JC_JM.HYZK_CODE AS JM_HYZK_CODE
            ,TT_JC_JM.LXDH AS JM_LXDH
            ,TT_JC_JM.JHR_XM AS JM_JHR_XM
            ,TT_JC_JM.JHR_DH AS JM_JHR_DH
            ,TT_JC_JM.NHBM AS JM_NHBM
            ,TT_JC_JM.YBKH AS JM_YBKH
            ,TT_JC_JM.CJKH AS JM_CJKH
            ,TT_JC_JM.ZFZH AS JM_ZFZH
            ,TT_JC_JM.JKDABH AS JM_JKDABH
            ,TT_JC_JM.PYM AS JM_PYM
            ,TT_JC_JM.WBM AS JM_WBM
            ,TT_JC_JM.ZFBZ AS JM_ZFBZ
            ");

            sql.Append(@"
            ,TT_BRLX_CODE.ID AS BRLX_CODE_ID,TT_BRLX_CODE.NAME AS BRLX_CODE_NAME,TT_BRLX_CODE.VALUE AS BRLX_CODE_VALUE,TT_BRLX_CODE.FK_CODE_TYPE AS BRLX_CODE_FKCODETYPE,TT_BRLX_CODE.ZFBZ AS BRLX_CODE_ZFBZ,TT_BRLX_CODE.REMARK AS BRLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_JC_KSWH.ID AS JH_ID
            ,TT_JC_KSWH.KSBH AS JH_KSBH
            ,TT_JC_KSWH.KSMC AS JH_KSMC
            ,TT_JC_KSWH.MZBZ_CODE AS JH_MZBZ_CODE
            ,TT_JC_KSWH.ZYBZ_CODE AS JH_ZYBZ_CODE
            ,TT_JC_KSWH.YKBZ_CODE AS JH_YKBZ_CODE
            ,TT_JC_KSWH.YFBZ_CODE AS JH_YFBZ_CODE
            ,TT_JC_KSWH.YJBZ_CODE AS JH_YJBZ_CODE
            ,TT_JC_KSWH.SSBZ_CODE AS JH_SSBZ_CODE
            ,TT_JC_KSWH.ZFBZ AS JH_ZFBZ
            ");

            sql.Append(@"
            ,TT_JC_RENYUAN.ID AS JN_ID
            ,TT_JC_RENYUAN.XM AS JN_XM
            ,TT_JC_RENYUAN.XB_CODE AS JN_XB_CODE
            ,TT_JC_RENYUAN.MZ_CODE AS JN_MZ_CODE
            ,TT_JC_RENYUAN.CSRQ AS JN_CSRQ
            ,TT_JC_RENYUAN.SFZH AS JN_SFZH
            ,TT_JC_RENYUAN.ZZMM_CODE AS JN_ZZMM_CODE
            ,TT_JC_RENYUAN.HYZK_CODE AS JN_HYZK_CODE
            ,TT_JC_RENYUAN.BYXX AS JN_BYXX
            ,TT_JC_RENYUAN.XL_CODE AS JN_XL_CODE
            ,TT_JC_RENYUAN.CJGZSJ AS JN_CJGZSJ
            ,TT_JC_RENYUAN.ZY AS JN_ZY
            ,TT_JC_RENYUAN.JG AS JN_JG
            ,TT_JC_RENYUAN.DZ AS JN_DZ
            ,TT_JC_RENYUAN.LXDH AS JN_LXDH
            ,TT_JC_RENYUAN.QQ AS JN_QQ
            ,TT_JC_RENYUAN.YX AS JN_YX
            ,TT_JC_RENYUAN.BZ AS JN_BZ
            ,TT_JC_RENYUAN.PYM AS JN_PYM
            ,TT_JC_RENYUAN.WBM AS JN_WBM
            ,TT_JC_RENYUAN.RYLX_CODE AS JN_RYLX_CODE
            ,TT_JC_RENYUAN.ZFBZ AS JN_ZFBZ
            ");

            sql.Append(@"
            ,TT_GHLX_CODE.ID AS GHLX_CODE_ID,TT_GHLX_CODE.NAME AS GHLX_CODE_NAME,TT_GHLX_CODE.VALUE AS GHLX_CODE_VALUE,TT_GHLX_CODE.FK_CODE_TYPE AS GHLX_CODE_FKCODETYPE,TT_GHLX_CODE.ZFBZ AS GHLX_CODE_ZFBZ,TT_GHLX_CODE.REMARK AS GHLX_CODE_REMARK
            ");

            sql.Append(@"
            ,TT_STATE_CODE.ID AS STATE_CODE_ID,TT_STATE_CODE.NAME AS STATE_CODE_NAME,TT_STATE_CODE.VALUE AS STATE_CODE_VALUE,TT_STATE_CODE.FK_CODE_TYPE AS STATE_CODE_FKCODETYPE,TT_STATE_CODE.ZFBZ AS STATE_CODE_ZFBZ,TT_STATE_CODE.REMARK AS STATE_CODE_REMARK
            ");

            //新建方法，在此加入多表连接要显示的项end
            sql.Append(" FROM MZ_GH A ");
            //新建一个方法，在此加入多表连接的语句start
            ////sql.Append(" LEFT JOIN 表名 B ON A.外键=B.ID");

            sql.Append(@"
            LEFT JOIN JC_JM TT_JC_JM 
            ON A.FK_JC_JM = TT_JC_JM.ID

            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.病人类型 + @"')) TT_BRLX_CODE
                        ON A.BRLX_CODE = TT_BRLX_CODE.VALUE
            ");

            sql.Append(@"
            LEFT JOIN JC_KSWH TT_JC_KSWH 
            ON A.FK_JC_KSWH = TT_JC_KSWH.ID

            ");

            sql.Append(@"
            LEFT JOIN JC_RENYUAN TT_JC_RENYUAN 
            ON A.FK_JC_RENYUAN = TT_JC_RENYUAN.ID

            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.挂号_类型 + @"')) TT_GHLX_CODE
                        ON A.GHLX_CODE = TT_GHLX_CODE.VALUE
            ");

            sql.Append(@" 
                        LEFT JOIN 
                        (SELECT X.* FROM JC_CODE X WHERE X.FK_CODE_TYPE IN (SELECT Y.ID FROM JC_CODE_TYPE Y WHERE Y.VALUE='" + Model.Common.CommonCode.代码类型值.挂号_状态 + @"')) TT_STATE_CODE
                        ON A.STATE_CODE = TT_STATE_CODE.VALUE
            ");

            //新建一个方法，在此加入多表连接的语句end


            if (null != mz_ghParam.Lsh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" LSH=:lsh ");
                OracleParameter pLsh = new OracleParameter(":lsh", OracleDbType.Decimal);
                pLsh.Value = mz_ghParam.Lsh;
                sqlparams.Add(pLsh);

            }

            if (null != mz_ghParam.Fk_jc_jm && "" != mz_ghParam.Fk_jc_jm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_JM=:fk_jc_jm ");
                OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                pFk_jc_jm.Value = mz_ghParam.Fk_jc_jm;
                sqlparams.Add(pFk_jc_jm);
            }

            if (null != mz_ghParam.Brxm && "" != mz_ghParam.Brxm)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXM=:brxm ");
                OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                pBrxm.Value = mz_ghParam.Brxm;
                sqlparams.Add(pBrxm);
            }

            if (DateTime.MinValue != mz_ghParam.Brcsrq && null != mz_ghParam.Brcsrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRCSRQ=:brcsrq ");
                OracleParameter pBrcsrq = new OracleParameter(":brcsrq", OracleDbType.Date);
                pBrcsrq.Value = mz_ghParam.Brcsrq;
                sqlparams.Add(pBrcsrq);
            }

            if (null != mz_ghParam.Brxb && "" != mz_ghParam.Brxb)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXB=:brxb ");
                OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                pBrxb.Value = mz_ghParam.Brxb;
                sqlparams.Add(pBrxb);
            }

            if (null != mz_ghParam.Brsfzh && "" != mz_ghParam.Brsfzh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRSFZH=:brsfzh ");
                OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                pBrsfzh.Value = mz_ghParam.Brsfzh;
                sqlparams.Add(pBrsfzh);
            }

            if (null != mz_ghParam.Brlxdh && "" != mz_ghParam.Brlxdh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRLXDH=:brlxdh ");
                OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                pBrlxdh.Value = mz_ghParam.Brlxdh;
                sqlparams.Add(pBrlxdh);
            }

            if (null != mz_ghParam.Brxzz_xzqh && "" != mz_ghParam.Brxzz_xzqh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXZZ_XZQH=:brxzz_xzqh ");
                OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                pBrxzz_xzqh.Value = mz_ghParam.Brxzz_xzqh;
                sqlparams.Add(pBrxzz_xzqh);
            }

            if (null != mz_ghParam.Brxzz_detail && "" != mz_ghParam.Brxzz_detail)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRXZZ_DETAIL=:brxzz_detail ");
                OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                pBrxzz_detail.Value = mz_ghParam.Brxzz_detail;
                sqlparams.Add(pBrxzz_detail);
            }

            if (null != mz_ghParam.Brlx_code && "" != mz_ghParam.Brlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.BRLX_CODE=:brlx_code ");
                OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                pBrlx_code.Value = mz_ghParam.Brlx_code;
                sqlparams.Add(pBrlx_code);
            }

            if (null != mz_ghParam.Fk_jc_kswh && "" != mz_ghParam.Fk_jc_kswh)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_KSWH=:fk_jc_kswh ");
                OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                pFk_jc_kswh.Value = mz_ghParam.Fk_jc_kswh;
                sqlparams.Add(pFk_jc_kswh);
            }

            if (null != mz_ghParam.Fk_jc_renyuan && "" != mz_ghParam.Fk_jc_renyuan)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.FK_JC_RENYUAN=:fk_jc_renyuan ");
                OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                pFk_jc_renyuan.Value = mz_ghParam.Fk_jc_renyuan;
                sqlparams.Add(pFk_jc_renyuan);
            }

            if (null != mz_ghParam.Ghlx_code && "" != mz_ghParam.Ghlx_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GHLX_CODE=:ghlx_code ");
                OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                pGhlx_code.Value = mz_ghParam.Ghlx_code;
                sqlparams.Add(pGhlx_code);
            }

            if (DateTime.MinValue != mz_ghParam.Ghrq && null != mz_ghParam.Ghrq)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.GHRQ=:ghrq ");
                OracleParameter pGhrq = new OracleParameter(":ghrq", OracleDbType.Date);
                pGhrq.Value = mz_ghParam.Ghrq;
                sqlparams.Add(pGhrq);
            }

            if (null != mz_ghParam.State_code && "" != mz_ghParam.State_code)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.STATE_CODE=:state_code ");
                OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                pState_code.Value = mz_ghParam.State_code;
                sqlparams.Add(pState_code);
            }

            if (null != mz_ghParam.Zfbz && "" != mz_ghParam.Zfbz)
            {
                this.isAnd(sql);
                this.isWhere(sql);
                sql.Append(" A.ZFBZ=:zfbz ");
                OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                pZfbz.Value = mz_ghParam.Zfbz;
                sqlparams.Add(pZfbz);
            }

            if (mz_ghParamLike != null)
            {

                if (null != mz_ghParamLike.Fk_jc_jm && "" != mz_ghParamLike.Fk_jc_jm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_JM LIKE '%'||:fk_jc_jm||'%' ");
                    OracleParameter pFk_jc_jm = new OracleParameter(":fk_jc_jm", OracleDbType.Varchar2);
                    pFk_jc_jm.Direction = ParameterDirection.Input;
                    pFk_jc_jm.Value = mz_ghParamLike.Fk_jc_jm;
                    sqlparams.Add(pFk_jc_jm);
                }

                if (null != mz_ghParamLike.Brxm && "" != mz_ghParamLike.Brxm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXM LIKE '%'||:brxm||'%' ");
                    OracleParameter pBrxm = new OracleParameter(":brxm", OracleDbType.NVarchar2);
                    pBrxm.Direction = ParameterDirection.Input;
                    pBrxm.Value = mz_ghParamLike.Brxm;
                    sqlparams.Add(pBrxm);
                }

                if (null != mz_ghParamLike.Brxb && "" != mz_ghParamLike.Brxb)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXB LIKE '%'||:brxb||'%' ");
                    OracleParameter pBrxb = new OracleParameter(":brxb", OracleDbType.NVarchar2);
                    pBrxb.Direction = ParameterDirection.Input;
                    pBrxb.Value = mz_ghParamLike.Brxb;
                    sqlparams.Add(pBrxb);
                }

                if (null != mz_ghParamLike.Brsfzh && "" != mz_ghParamLike.Brsfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRSFZH LIKE '%'||:brsfzh||'%' ");
                    OracleParameter pBrsfzh = new OracleParameter(":brsfzh", OracleDbType.NVarchar2);
                    pBrsfzh.Direction = ParameterDirection.Input;
                    pBrsfzh.Value = mz_ghParamLike.Brsfzh;
                    sqlparams.Add(pBrsfzh);
                }

                if (null != mz_ghParamLike.Brlxdh && "" != mz_ghParamLike.Brlxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLXDH LIKE '%'||:brlxdh||'%' ");
                    OracleParameter pBrlxdh = new OracleParameter(":brlxdh", OracleDbType.NVarchar2);
                    pBrlxdh.Direction = ParameterDirection.Input;
                    pBrlxdh.Value = mz_ghParamLike.Brlxdh;
                    sqlparams.Add(pBrlxdh);
                }

                if (null != mz_ghParamLike.Brxzz_xzqh && "" != mz_ghParamLike.Brxzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_XZQH LIKE '%'||:brxzz_xzqh||'%' ");
                    OracleParameter pBrxzz_xzqh = new OracleParameter(":brxzz_xzqh", OracleDbType.NVarchar2);
                    pBrxzz_xzqh.Direction = ParameterDirection.Input;
                    pBrxzz_xzqh.Value = mz_ghParamLike.Brxzz_xzqh;
                    sqlparams.Add(pBrxzz_xzqh);
                }

                if (null != mz_ghParamLike.Brxzz_detail && "" != mz_ghParamLike.Brxzz_detail)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRXZZ_DETAIL LIKE '%'||:brxzz_detail||'%' ");
                    OracleParameter pBrxzz_detail = new OracleParameter(":brxzz_detail", OracleDbType.NVarchar2);
                    pBrxzz_detail.Direction = ParameterDirection.Input;
                    pBrxzz_detail.Value = mz_ghParamLike.Brxzz_detail;
                    sqlparams.Add(pBrxzz_detail);
                }

                if (null != mz_ghParamLike.Brlx_code && "" != mz_ghParamLike.Brlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.BRLX_CODE LIKE '%'||:brlx_code||'%' ");
                    OracleParameter pBrlx_code = new OracleParameter(":brlx_code", OracleDbType.Varchar2);
                    pBrlx_code.Direction = ParameterDirection.Input;
                    pBrlx_code.Value = mz_ghParamLike.Brlx_code;
                    sqlparams.Add(pBrlx_code);
                }

                if (null != mz_ghParamLike.Fk_jc_kswh && "" != mz_ghParamLike.Fk_jc_kswh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_KSWH LIKE '%'||:fk_jc_kswh||'%' ");
                    OracleParameter pFk_jc_kswh = new OracleParameter(":fk_jc_kswh", OracleDbType.Varchar2);
                    pFk_jc_kswh.Direction = ParameterDirection.Input;
                    pFk_jc_kswh.Value = mz_ghParamLike.Fk_jc_kswh;
                    sqlparams.Add(pFk_jc_kswh);
                }

                if (null != mz_ghParamLike.Fk_jc_renyuan && "" != mz_ghParamLike.Fk_jc_renyuan)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.FK_JC_RENYUAN LIKE '%'||:fk_jc_renyuan||'%' ");
                    OracleParameter pFk_jc_renyuan = new OracleParameter(":fk_jc_renyuan", OracleDbType.Varchar2);
                    pFk_jc_renyuan.Direction = ParameterDirection.Input;
                    pFk_jc_renyuan.Value = mz_ghParamLike.Fk_jc_renyuan;
                    sqlparams.Add(pFk_jc_renyuan);
                }

                if (null != mz_ghParamLike.Ghlx_code && "" != mz_ghParamLike.Ghlx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.GHLX_CODE LIKE '%'||:ghlx_code||'%' ");
                    OracleParameter pGhlx_code = new OracleParameter(":ghlx_code", OracleDbType.Varchar2);
                    pGhlx_code.Direction = ParameterDirection.Input;
                    pGhlx_code.Value = mz_ghParamLike.Ghlx_code;
                    sqlparams.Add(pGhlx_code);
                }

                if (null != mz_ghParamLike.State_code && "" != mz_ghParamLike.State_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.STATE_CODE LIKE '%'||:state_code||'%' ");
                    OracleParameter pState_code = new OracleParameter(":state_code", OracleDbType.Varchar2);
                    pState_code.Direction = ParameterDirection.Input;
                    pState_code.Value = mz_ghParamLike.State_code;
                    sqlparams.Add(pState_code);
                }

                if (null != mz_ghParamLike.Zfbz && "" != mz_ghParamLike.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" A.ZFBZ LIKE '%'||:zfbz||'%' ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.Varchar2);
                    pZfbz.Direction = ParameterDirection.Input;
                    pZfbz.Value = mz_ghParamLike.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != mz_ghParam.Jc_jm)
            {

                if (null != mz_ghParam.Jc_jm.Id && null != mz_ghParam.Jc_jm.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = mz_ghParam.Jc_jm.Id;
                    sqlparams.Add(pId);
                }

                if (null != mz_ghParam.Jc_jm.Sfzh && null != mz_ghParam.Jc_jm.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Value = mz_ghParam.Jc_jm.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != mz_ghParam.Jc_jm.Xm && null != mz_ghParam.Jc_jm.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Value = mz_ghParam.Jc_jm.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != mz_ghParam.Jc_jm.Xb_code && null != mz_ghParam.Jc_jm.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Value = mz_ghParam.Jc_jm.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (DateTime.MinValue != mz_ghParam.Jc_jm.Csrq && null != mz_ghParam.Jc_jm.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                    pCsrq.Value = mz_ghParam.Jc_jm.Csrq;
                    sqlparams.Add(pCsrq);
                }

                if (null != mz_ghParam.Jc_jm.Mz_code && null != mz_ghParam.Jc_jm.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Value = mz_ghParam.Jc_jm.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (null != mz_ghParam.Jc_jm.Xx_code && null != mz_ghParam.Jc_jm.Xx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.XX_CODE=:xx_code ");
                    OracleParameter pXx_code = new OracleParameter(":xx_code", OracleDbType.NVarchar2);
                    pXx_code.Value = mz_ghParam.Jc_jm.Xx_code;
                    sqlparams.Add(pXx_code);
                }

                if (null != mz_ghParam.Jc_jm.Rh_code && null != mz_ghParam.Jc_jm.Rh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.RH_CODE=:rh_code ");
                    OracleParameter pRh_code = new OracleParameter(":rh_code", OracleDbType.NVarchar2);
                    pRh_code.Value = mz_ghParam.Jc_jm.Rh_code;
                    sqlparams.Add(pRh_code);
                }

                if (null != mz_ghParam.Jc_jm.Csdz && null != mz_ghParam.Jc_jm.Csdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.CSDZ=:csdz ");
                    OracleParameter pCsdz = new OracleParameter(":csdz", OracleDbType.NVarchar2);
                    pCsdz.Value = mz_ghParam.Jc_jm.Csdz;
                    sqlparams.Add(pCsdz);
                }

                if (null != mz_ghParam.Jc_jm.Hjdz && null != mz_ghParam.Jc_jm.Hjdz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.HJDZ=:hjdz ");
                    OracleParameter pHjdz = new OracleParameter(":hjdz", OracleDbType.NVarchar2);
                    pHjdz.Value = mz_ghParam.Jc_jm.Hjdz;
                    sqlparams.Add(pHjdz);
                }

                if (null != mz_ghParam.Jc_jm.Xzz_xzqh && null != mz_ghParam.Jc_jm.Xzz_xzqh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.XZZ_XZQH=:xzz_xzqh ");
                    OracleParameter pXzz_xzqh = new OracleParameter(":xzz_xzqh", OracleDbType.NVarchar2);
                    pXzz_xzqh.Value = mz_ghParam.Jc_jm.Xzz_xzqh;
                    sqlparams.Add(pXzz_xzqh);
                }

                if (null != mz_ghParam.Jc_jm.Xzz_xiang_xi_di_zhi && null != mz_ghParam.Jc_jm.Xzz_xiang_xi_di_zhi)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.XZZ_XIANG_XI_DI_ZHI=:xzz_xiang_xi_di_zhi ");
                    OracleParameter pXzz_xiang_xi_di_zhi = new OracleParameter(":xzz_xiang_xi_di_zhi", OracleDbType.NVarchar2);
                    pXzz_xiang_xi_di_zhi.Value = mz_ghParam.Jc_jm.Xzz_xiang_xi_di_zhi;
                    sqlparams.Add(pXzz_xiang_xi_di_zhi);
                }

                if (null != mz_ghParam.Jc_jm.Gzdw_xx && null != mz_ghParam.Jc_jm.Gzdw_xx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.GZDW_XX=:gzdw_xx ");
                    OracleParameter pGzdw_xx = new OracleParameter(":gzdw_xx", OracleDbType.NVarchar2);
                    pGzdw_xx.Value = mz_ghParam.Jc_jm.Gzdw_xx;
                    sqlparams.Add(pGzdw_xx);
                }

                if (null != mz_ghParam.Jc_jm.Zy_code && null != mz_ghParam.Jc_jm.Zy_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.ZY_CODE=:zy_code ");
                    OracleParameter pZy_code = new OracleParameter(":zy_code", OracleDbType.NVarchar2);
                    pZy_code.Value = mz_ghParam.Jc_jm.Zy_code;
                    sqlparams.Add(pZy_code);
                }

                if (null != mz_ghParam.Jc_jm.Zy && null != mz_ghParam.Jc_jm.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Value = mz_ghParam.Jc_jm.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != mz_ghParam.Jc_jm.Wh_code && null != mz_ghParam.Jc_jm.Wh_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.WH_CODE=:wh_code ");
                    OracleParameter pWh_code = new OracleParameter(":wh_code", OracleDbType.NVarchar2);
                    pWh_code.Value = mz_ghParam.Jc_jm.Wh_code;
                    sqlparams.Add(pWh_code);
                }

                if (null != mz_ghParam.Jc_jm.Hyzk_code && null != mz_ghParam.Jc_jm.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Value = mz_ghParam.Jc_jm.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != mz_ghParam.Jc_jm.Lxdh && null != mz_ghParam.Jc_jm.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Value = mz_ghParam.Jc_jm.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != mz_ghParam.Jc_jm.Jhr_xm && null != mz_ghParam.Jc_jm.Jhr_xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.JHR_XM=:jhr_xm ");
                    OracleParameter pJhr_xm = new OracleParameter(":jhr_xm", OracleDbType.NVarchar2);
                    pJhr_xm.Value = mz_ghParam.Jc_jm.Jhr_xm;
                    sqlparams.Add(pJhr_xm);
                }

                if (null != mz_ghParam.Jc_jm.Jhr_dh && null != mz_ghParam.Jc_jm.Jhr_dh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.JHR_DH=:jhr_dh ");
                    OracleParameter pJhr_dh = new OracleParameter(":jhr_dh", OracleDbType.NVarchar2);
                    pJhr_dh.Value = mz_ghParam.Jc_jm.Jhr_dh;
                    sqlparams.Add(pJhr_dh);
                }

                if (null != mz_ghParam.Jc_jm.Nhbm && null != mz_ghParam.Jc_jm.Nhbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.NHBM=:nhbm ");
                    OracleParameter pNhbm = new OracleParameter(":nhbm", OracleDbType.NVarchar2);
                    pNhbm.Value = mz_ghParam.Jc_jm.Nhbm;
                    sqlparams.Add(pNhbm);
                }

                if (null != mz_ghParam.Jc_jm.Ybkh && null != mz_ghParam.Jc_jm.Ybkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.YBKH=:ybkh ");
                    OracleParameter pYbkh = new OracleParameter(":ybkh", OracleDbType.NVarchar2);
                    pYbkh.Value = mz_ghParam.Jc_jm.Ybkh;
                    sqlparams.Add(pYbkh);
                }

                if (null != mz_ghParam.Jc_jm.Cjkh && null != mz_ghParam.Jc_jm.Cjkh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.CJKH=:cjkh ");
                    OracleParameter pCjkh = new OracleParameter(":cjkh", OracleDbType.NVarchar2);
                    pCjkh.Value = mz_ghParam.Jc_jm.Cjkh;
                    sqlparams.Add(pCjkh);
                }

                if (null != mz_ghParam.Jc_jm.Zfzh && null != mz_ghParam.Jc_jm.Zfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.ZFZH=:zfzh ");
                    OracleParameter pZfzh = new OracleParameter(":zfzh", OracleDbType.NVarchar2);
                    pZfzh.Value = mz_ghParam.Jc_jm.Zfzh;
                    sqlparams.Add(pZfzh);
                }

                if (null != mz_ghParam.Jc_jm.Jkdabh && null != mz_ghParam.Jc_jm.Jkdabh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.JKDABH=:jkdabh ");
                    OracleParameter pJkdabh = new OracleParameter(":jkdabh", OracleDbType.NVarchar2);
                    pJkdabh.Value = mz_ghParam.Jc_jm.Jkdabh;
                    sqlparams.Add(pJkdabh);
                }

                if (null != mz_ghParam.Jc_jm.Pym && null != mz_ghParam.Jc_jm.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Value = mz_ghParam.Jc_jm.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != mz_ghParam.Jc_jm.Wbm && null != mz_ghParam.Jc_jm.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Value = mz_ghParam.Jc_jm.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != mz_ghParam.Jc_jm.Zfbz && null != mz_ghParam.Jc_jm.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_JM.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = mz_ghParam.Jc_jm.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != mz_ghParam.Jc_kswh)
            {

                if (null != mz_ghParam.Jc_kswh.Id && null != mz_ghParam.Jc_kswh.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = mz_ghParam.Jc_kswh.Id;
                    sqlparams.Add(pId);
                }

                if (null != mz_ghParam.Jc_kswh.Ksbh && null != mz_ghParam.Jc_kswh.Ksbh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.KSBH=:ksbh ");
                    OracleParameter pKsbh = new OracleParameter(":ksbh", OracleDbType.NVarchar2);
                    pKsbh.Value = mz_ghParam.Jc_kswh.Ksbh;
                    sqlparams.Add(pKsbh);
                }

                if (null != mz_ghParam.Jc_kswh.Ksmc && null != mz_ghParam.Jc_kswh.Ksmc)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.KSMC=:ksmc ");
                    OracleParameter pKsmc = new OracleParameter(":ksmc", OracleDbType.NVarchar2);
                    pKsmc.Value = mz_ghParam.Jc_kswh.Ksmc;
                    sqlparams.Add(pKsmc);
                }

                if (null != mz_ghParam.Jc_kswh.Mzbz_code && null != mz_ghParam.Jc_kswh.Mzbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.MZBZ_CODE=:mzbz_code ");
                    OracleParameter pMzbz_code = new OracleParameter(":mzbz_code", OracleDbType.NVarchar2);
                    pMzbz_code.Value = mz_ghParam.Jc_kswh.Mzbz_code;
                    sqlparams.Add(pMzbz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Zybz_code && null != mz_ghParam.Jc_kswh.Zybz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ZYBZ_CODE=:zybz_code ");
                    OracleParameter pZybz_code = new OracleParameter(":zybz_code", OracleDbType.NVarchar2);
                    pZybz_code.Value = mz_ghParam.Jc_kswh.Zybz_code;
                    sqlparams.Add(pZybz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Ykbz_code && null != mz_ghParam.Jc_kswh.Ykbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YKBZ_CODE=:ykbz_code ");
                    OracleParameter pYkbz_code = new OracleParameter(":ykbz_code", OracleDbType.NVarchar2);
                    pYkbz_code.Value = mz_ghParam.Jc_kswh.Ykbz_code;
                    sqlparams.Add(pYkbz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Yfbz_code && null != mz_ghParam.Jc_kswh.Yfbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YFBZ_CODE=:yfbz_code ");
                    OracleParameter pYfbz_code = new OracleParameter(":yfbz_code", OracleDbType.NVarchar2);
                    pYfbz_code.Value = mz_ghParam.Jc_kswh.Yfbz_code;
                    sqlparams.Add(pYfbz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Yjbz_code && null != mz_ghParam.Jc_kswh.Yjbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.YJBZ_CODE=:yjbz_code ");
                    OracleParameter pYjbz_code = new OracleParameter(":yjbz_code", OracleDbType.NVarchar2);
                    pYjbz_code.Value = mz_ghParam.Jc_kswh.Yjbz_code;
                    sqlparams.Add(pYjbz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Ssbz_code && null != mz_ghParam.Jc_kswh.Ssbz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.SSBZ_CODE=:ssbz_code ");
                    OracleParameter pSsbz_code = new OracleParameter(":ssbz_code", OracleDbType.NVarchar2);
                    pSsbz_code.Value = mz_ghParam.Jc_kswh.Ssbz_code;
                    sqlparams.Add(pSsbz_code);
                }

                if (null != mz_ghParam.Jc_kswh.Zfbz && null != mz_ghParam.Jc_kswh.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_KSWH.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = mz_ghParam.Jc_kswh.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            if (null != mz_ghParam.Jc_renyuan)
            {

                if (null != mz_ghParam.Jc_renyuan.Id && null != mz_ghParam.Jc_renyuan.Id)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ID=:id ");
                    OracleParameter pId = new OracleParameter(":id", OracleDbType.Varchar2);
                    pId.Value = mz_ghParam.Jc_renyuan.Id;
                    sqlparams.Add(pId);
                }

                if (null != mz_ghParam.Jc_renyuan.Xm && null != mz_ghParam.Jc_renyuan.Xm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XM=:xm ");
                    OracleParameter pXm = new OracleParameter(":xm", OracleDbType.NVarchar2);
                    pXm.Value = mz_ghParam.Jc_renyuan.Xm;
                    sqlparams.Add(pXm);
                }

                if (null != mz_ghParam.Jc_renyuan.Xb_code && null != mz_ghParam.Jc_renyuan.Xb_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XB_CODE=:xb_code ");
                    OracleParameter pXb_code = new OracleParameter(":xb_code", OracleDbType.NVarchar2);
                    pXb_code.Value = mz_ghParam.Jc_renyuan.Xb_code;
                    sqlparams.Add(pXb_code);
                }

                if (null != mz_ghParam.Jc_renyuan.Mz_code && null != mz_ghParam.Jc_renyuan.Mz_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.MZ_CODE=:mz_code ");
                    OracleParameter pMz_code = new OracleParameter(":mz_code", OracleDbType.NVarchar2);
                    pMz_code.Value = mz_ghParam.Jc_renyuan.Mz_code;
                    sqlparams.Add(pMz_code);
                }

                if (DateTime.MinValue != mz_ghParam.Jc_renyuan.Csrq && null != mz_ghParam.Jc_renyuan.Csrq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CSRQ=:csrq ");
                    OracleParameter pCsrq = new OracleParameter(":csrq", OracleDbType.Date);
                    pCsrq.Value = mz_ghParam.Jc_renyuan.Csrq;
                    sqlparams.Add(pCsrq);
                }

                if (null != mz_ghParam.Jc_renyuan.Sfzh && null != mz_ghParam.Jc_renyuan.Sfzh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.SFZH=:sfzh ");
                    OracleParameter pSfzh = new OracleParameter(":sfzh", OracleDbType.NVarchar2);
                    pSfzh.Value = mz_ghParam.Jc_renyuan.Sfzh;
                    sqlparams.Add(pSfzh);
                }

                if (null != mz_ghParam.Jc_renyuan.Zzmm_code && null != mz_ghParam.Jc_renyuan.Zzmm_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZZMM_CODE=:zzmm_code ");
                    OracleParameter pZzmm_code = new OracleParameter(":zzmm_code", OracleDbType.NVarchar2);
                    pZzmm_code.Value = mz_ghParam.Jc_renyuan.Zzmm_code;
                    sqlparams.Add(pZzmm_code);
                }

                if (null != mz_ghParam.Jc_renyuan.Hyzk_code && null != mz_ghParam.Jc_renyuan.Hyzk_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.HYZK_CODE=:hyzk_code ");
                    OracleParameter pHyzk_code = new OracleParameter(":hyzk_code", OracleDbType.NVarchar2);
                    pHyzk_code.Value = mz_ghParam.Jc_renyuan.Hyzk_code;
                    sqlparams.Add(pHyzk_code);
                }

                if (null != mz_ghParam.Jc_renyuan.Byxx && null != mz_ghParam.Jc_renyuan.Byxx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BYXX=:byxx ");
                    OracleParameter pByxx = new OracleParameter(":byxx", OracleDbType.NVarchar2);
                    pByxx.Value = mz_ghParam.Jc_renyuan.Byxx;
                    sqlparams.Add(pByxx);
                }

                if (null != mz_ghParam.Jc_renyuan.Xl_code && null != mz_ghParam.Jc_renyuan.Xl_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.XL_CODE=:xl_code ");
                    OracleParameter pXl_code = new OracleParameter(":xl_code", OracleDbType.NVarchar2);
                    pXl_code.Value = mz_ghParam.Jc_renyuan.Xl_code;
                    sqlparams.Add(pXl_code);
                }

                if (DateTime.MinValue != mz_ghParam.Jc_renyuan.Cjgzsj && null != mz_ghParam.Jc_renyuan.Cjgzsj)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.CJGZSJ=:cjgzsj ");
                    OracleParameter pCjgzsj = new OracleParameter(":cjgzsj", OracleDbType.Date);
                    pCjgzsj.Value = mz_ghParam.Jc_renyuan.Cjgzsj;
                    sqlparams.Add(pCjgzsj);
                }

                if (null != mz_ghParam.Jc_renyuan.Zy && null != mz_ghParam.Jc_renyuan.Zy)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZY=:zy ");
                    OracleParameter pZy = new OracleParameter(":zy", OracleDbType.NVarchar2);
                    pZy.Value = mz_ghParam.Jc_renyuan.Zy;
                    sqlparams.Add(pZy);
                }

                if (null != mz_ghParam.Jc_renyuan.Jg && null != mz_ghParam.Jc_renyuan.Jg)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.JG=:jg ");
                    OracleParameter pJg = new OracleParameter(":jg", OracleDbType.NVarchar2);
                    pJg.Value = mz_ghParam.Jc_renyuan.Jg;
                    sqlparams.Add(pJg);
                }

                if (null != mz_ghParam.Jc_renyuan.Dz && null != mz_ghParam.Jc_renyuan.Dz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.DZ=:dz ");
                    OracleParameter pDz = new OracleParameter(":dz", OracleDbType.NVarchar2);
                    pDz.Value = mz_ghParam.Jc_renyuan.Dz;
                    sqlparams.Add(pDz);
                }

                if (null != mz_ghParam.Jc_renyuan.Lxdh && null != mz_ghParam.Jc_renyuan.Lxdh)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.LXDH=:lxdh ");
                    OracleParameter pLxdh = new OracleParameter(":lxdh", OracleDbType.NVarchar2);
                    pLxdh.Value = mz_ghParam.Jc_renyuan.Lxdh;
                    sqlparams.Add(pLxdh);
                }

                if (null != mz_ghParam.Jc_renyuan.Qq && null != mz_ghParam.Jc_renyuan.Qq)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.QQ=:qq ");
                    OracleParameter pQq = new OracleParameter(":qq", OracleDbType.NVarchar2);
                    pQq.Value = mz_ghParam.Jc_renyuan.Qq;
                    sqlparams.Add(pQq);
                }

                if (null != mz_ghParam.Jc_renyuan.Yx && null != mz_ghParam.Jc_renyuan.Yx)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.YX=:yx ");
                    OracleParameter pYx = new OracleParameter(":yx", OracleDbType.NVarchar2);
                    pYx.Value = mz_ghParam.Jc_renyuan.Yx;
                    sqlparams.Add(pYx);
                }

                if (null != mz_ghParam.Jc_renyuan.Bz && null != mz_ghParam.Jc_renyuan.Bz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.BZ=:bz ");
                    OracleParameter pBz = new OracleParameter(":bz", OracleDbType.NVarchar2);
                    pBz.Value = mz_ghParam.Jc_renyuan.Bz;
                    sqlparams.Add(pBz);
                }

                if (null != mz_ghParam.Jc_renyuan.Pym && null != mz_ghParam.Jc_renyuan.Pym)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.PYM=:pym ");
                    OracleParameter pPym = new OracleParameter(":pym", OracleDbType.NVarchar2);
                    pPym.Value = mz_ghParam.Jc_renyuan.Pym;
                    sqlparams.Add(pPym);
                }

                if (null != mz_ghParam.Jc_renyuan.Wbm && null != mz_ghParam.Jc_renyuan.Wbm)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.WBM=:wbm ");
                    OracleParameter pWbm = new OracleParameter(":wbm", OracleDbType.NVarchar2);
                    pWbm.Value = mz_ghParam.Jc_renyuan.Wbm;
                    sqlparams.Add(pWbm);
                }

                if (null != mz_ghParam.Jc_renyuan.Rylx_code && null != mz_ghParam.Jc_renyuan.Rylx_code)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.RYLX_CODE=:rylx_code ");
                    OracleParameter pRylx_code = new OracleParameter(":rylx_code", OracleDbType.NVarchar2);
                    pRylx_code.Value = mz_ghParam.Jc_renyuan.Rylx_code;
                    sqlparams.Add(pRylx_code);
                }

                if (null != mz_ghParam.Jc_renyuan.Zfbz && null != mz_ghParam.Jc_renyuan.Zfbz)
                {
                    this.isAnd(sql);
                    this.isWhere(sql);
                    sql.Append(" TT_JC_RENYUAN.ZFBZ=:zfbz ");
                    OracleParameter pZfbz = new OracleParameter(":zfbz", OracleDbType.NVarchar2);
                    pZfbz.Value = mz_ghParam.Jc_renyuan.Zfbz;
                    sqlparams.Add(pZfbz);
                }

            }

            this.b_isWhere = false;
            //排序
            this.addSort(sql, sortList);
            //*******分页start1*********如果分页对象为空，则全部数据查出，如果不为空
            List<object> returnList = new List<object>();//返回的List,索引0为List<Mz_gh>对象,索引1为Model.Common.PageInfo分页信息对象
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
            //把每一行数据转换为一个对象放入List<Mz_gh>中
            for (int i = 0; i < rows.Count; i++)
            {
                DataRow row = rows[i];
                mz_ghParamList.Add(this.dataSetContactObjectsToModel(row));
                //mz_ghParamList.Add(this.dataSetToModel(row));
            }

            //*******分页start2*********如果没有传入分页对象，则新建一个分页对象当做返回值
            if (null == page)
            {
                page = new Model.Common.PageInfo();
                page.AllCount = rows.Count;
            }
            returnList.Add(mz_ghParamList);//把List<Mz_gh>放入List<object>中第一个
            returnList.Add(page);//把page对象放入List<object>中第二个
            //*******分页end2*********
            return returnList;
        }
        #endregion DAL层的implement,实现，end

        


        //*******************在此以后添加新的方法end
        
    }
}


