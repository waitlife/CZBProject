﻿using CZB.IDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_IncomeRecord
    /// </summary>
    public partial class FX_IncomeRecord : IFX_IncomeRecord
    {
        public FX_IncomeRecord()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("IncomeRecordId", "FX_IncomeRecord");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int IncomeRecordId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_IncomeRecord");
            strSql.Append(" where IncomeRecordId=@IncomeRecordId");
            SqlParameter[] parameters = {
                    new SqlParameter("@IncomeRecordId", SqlDbType.Int,4)
            };
            parameters[0].Value = IncomeRecordId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_IncomeRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_IncomeRecord(");
            strSql.Append("IncomeType,AgentId,ComeFromAgentID,SellerId,PolicyId,InsureCode,InsureType,PolicyAmount,FinalAmount,TotalAmount,TotalRoyaltyRatio,RoyaltyRatio,CommissionAmount,CreateTime,CityCode)");
            strSql.Append(" values (");
            strSql.Append("@IncomeType,@AgentId,@ComeFromAgentID,@SellerId,@PolicyId,@InsureCode,@InsureType,@PolicyAmount,@FinalAmount,@TotalAmount,@TotalRoyaltyRatio,@RoyaltyRatio,@CommissionAmount,@CreateTime,@CityCode)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@IncomeType", SqlDbType.Int,4),
                    new SqlParameter("@AgentId", SqlDbType.Int,4),
                    new SqlParameter("@ComeFromAgentID", SqlDbType.Int,4),
                    new SqlParameter("@SellerId", SqlDbType.Int,4),
                    new SqlParameter("@PolicyId", SqlDbType.Int,4),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureType", SqlDbType.Int,4),
                    new SqlParameter("@PolicyAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@FinalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@TotalRoyaltyRatio", SqlDbType.Decimal,9),
                    new SqlParameter("@RoyaltyRatio", SqlDbType.Decimal,9),
                    new SqlParameter("@CommissionAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.IncomeType;
            parameters[1].Value = model.AgentId;
            parameters[2].Value = model.ComeFromAgentID;
            parameters[3].Value = model.SellerId;
            parameters[4].Value = model.PolicyId;
            parameters[5].Value = model.InsureCode;
            parameters[6].Value = model.InsureType;
            parameters[7].Value = model.PolicyAmount;
            parameters[8].Value = model.FinalAmount;
            parameters[9].Value = model.TotalAmount;
            parameters[10].Value = model.TotalRoyaltyRatio;
            parameters[11].Value = model.RoyaltyRatio;
            parameters[12].Value = model.CommissionAmount;
            parameters[13].Value = model.CreateTime;
            parameters[14].Value = model.CityCode;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 获取下级收益
        /// </summary>
        /// <returns></returns>
        public DataSet GetCommissionAmount(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(CommissionAmount) as num from FX_IncomeRecord where AgentId = @agentId and IncomeType=2 ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@agentId",agentId)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        /// <summary>
        /// 销售个人总收益
        /// </summary>
        /// <param name="agentId">销售编号</param>
        /// <returns></returns>
        public DataSet GetIncomeRecord(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(CommissionAmount) as num from FX_IncomeRecord where AgentId = @agentId ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@agentId",agentId)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_IncomeRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_IncomeRecord set ");
            strSql.Append("IncomeType=@IncomeType,");
            strSql.Append("AgentId=@AgentId,");
            strSql.Append("ComeFromAgentID=@ComeFromAgentID,");
            strSql.Append("SellerId=@SellerId,");
            strSql.Append("PolicyId=@PolicyId,");
            strSql.Append("InsureCode=@InsureCode,");
            strSql.Append("InsureType=@InsureType,");
            strSql.Append("PolicyAmount=@PolicyAmount,");
            strSql.Append("FinalAmount=@FinalAmount,");
            strSql.Append("TotalAmount=@TotalAmount,");
            strSql.Append("TotalRoyaltyRatio=@TotalRoyaltyRatio,");
            strSql.Append("RoyaltyRatio=@RoyaltyRatio,");
            strSql.Append("CommissionAmount=@CommissionAmount,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("CityCode=@CityCode");
            strSql.Append(" where IncomeRecordId=@IncomeRecordId");
            SqlParameter[] parameters = {
                    new SqlParameter("@IncomeType", SqlDbType.Int,4),
                    new SqlParameter("@AgentId", SqlDbType.Int,4),
                    new SqlParameter("@ComeFromAgentID", SqlDbType.Int,4),
                    new SqlParameter("@SellerId", SqlDbType.Int,4),
                    new SqlParameter("@PolicyId", SqlDbType.Int,4),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureType", SqlDbType.Int,4),
                    new SqlParameter("@PolicyAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@FinalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@TotalRoyaltyRatio", SqlDbType.Decimal,9),
                    new SqlParameter("@RoyaltyRatio", SqlDbType.Decimal,9),
                    new SqlParameter("@CommissionAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@IncomeRecordId", SqlDbType.Int,4)};
            parameters[0].Value = model.IncomeType;
            parameters[1].Value = model.AgentId;
            parameters[2].Value = model.ComeFromAgentID;
            parameters[3].Value = model.SellerId;
            parameters[4].Value = model.PolicyId;
            parameters[5].Value = model.InsureCode;
            parameters[6].Value = model.InsureType;
            parameters[7].Value = model.PolicyAmount;
            parameters[8].Value = model.FinalAmount;
            parameters[9].Value = model.TotalAmount;
            parameters[10].Value = model.TotalRoyaltyRatio;
            parameters[11].Value = model.RoyaltyRatio;
            parameters[12].Value = model.CommissionAmount;
            parameters[13].Value = model.CreateTime;
            parameters[14].Value = model.CityCode;
            parameters[15].Value = model.IncomeRecordId;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IncomeRecordId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_IncomeRecord ");
            strSql.Append(" where IncomeRecordId=@IncomeRecordId");
            SqlParameter[] parameters = {
                    new SqlParameter("@IncomeRecordId", SqlDbType.Int,4)
            };
            parameters[0].Value = IncomeRecordId;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IncomeRecordIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_IncomeRecord ");
            strSql.Append(" where IncomeRecordId in (" + IncomeRecordIdlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select IncomeRecordId,IncomeType,AgentId,ComeFromAgentID,SellerId,PolicyId,InsureCode,InsureType,PolicyAmount,FinalAmount,TotalAmount,TotalRoyaltyRatio,RoyaltyRatio,CommissionAmount,CreateTime,CityCode ");
            strSql.Append(" FROM FX_IncomeRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" IncomeRecordId,IncomeType,AgentId,ComeFromAgentID,SellerId,PolicyId,InsureCode,InsureType,PolicyAmount,FinalAmount,TotalAmount,TotalRoyaltyRatio,RoyaltyRatio,CommissionAmount,CreateTime,CityCode ");
            strSql.Append(" FROM FX_IncomeRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM FX_IncomeRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.IncomeRecordId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_IncomeRecord T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 我的收益列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetIncomeRecordList(int agentId, string where)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  select a.FacePic headImg,a.TrueName name,ir.IncomeType [type], ir.CreateTime createTime , ");
            strSql.Append("  ir.commissionAmount [money],p.FX_PolicyNo PolicyNo ,ir.InsureType from FX_IncomeRecord ir  ");
            strSql.Append("  inner join FX_Policy p on ir.PolicyId = p.PolicyId  ");
            strSql.Append("  inner join FX_Agent a on a.agentId = p.AgentId ");
            strSql.Append("  where ir.agentId=@agentId ");

            if (!string.IsNullOrEmpty(where))
            {
                strSql.Append(where);
            }
            strSql.Append(" order by ir.CreateTime desc ");
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@agentId",SqlDbType.Int,4)
            };
            parameters[0].Value = agentId;
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        #endregion  ExtensionMethod
    }
}
