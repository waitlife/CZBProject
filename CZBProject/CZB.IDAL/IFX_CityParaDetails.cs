﻿using System;
using System.Data;
namespace CZB.IDAL
{
	/// <summary>
	/// 接口层FX_CityParaDetails
	/// </summary>
	public interface IFX_CityParaDetails
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int CityParaDetailsId);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(CZB.Model.FX_CityParaDetails model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(CZB.Model.FX_CityParaDetails model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int CityParaDetailsId);
		bool DeleteList(string CityParaDetailsIdlist );
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
        #region  MethodEx
        /// <summary>
        /// 获取销售目标
        /// </summary>
        /// <param name="cityCode"></param>
        /// <param name="paraCode"></param>
        /// <returns></returns>
        DataSet GetListByCode(string cityCode, string paraCode);
        #endregion  MethodEx
    } 
}
