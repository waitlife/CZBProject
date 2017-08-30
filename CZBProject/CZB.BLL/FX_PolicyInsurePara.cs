﻿using System;
using System.Data;
using System.Collections.Generic;
namespace CZB.BLL
{
    /// <summary>
    /// FX_PolicyInsurePara
    /// </summary>
    public partial class FX_PolicyInsurePara
    {
        private readonly DAL.SqlServer.DataProvider.FX_PolicyInsurePara dal = new DAL.SqlServer.DataProvider.FX_PolicyInsurePara();
        public FX_PolicyInsurePara()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FX_PolicyInsureMoneyParaID)
        {
            return dal.Exists(FX_PolicyInsureMoneyParaID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_PolicyInsurePara model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_PolicyInsurePara model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int FX_PolicyInsureMoneyParaID)
        {

            return dal.Delete(FX_PolicyInsureMoneyParaID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string FX_PolicyInsureMoneyParaIDlist)
        {
            return dal.DeleteList(FX_PolicyInsureMoneyParaIDlist);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 获取一条数据
        /// </summary>
        /// <param name="policyId">保单编号</param>
        /// <returns></returns>
        public DataSet GetList(int policyId)
        {
            return dal.GetList(policyId);
        }
        #endregion  ExtensionMethod
    }
}
