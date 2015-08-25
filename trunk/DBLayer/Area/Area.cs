using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Ziuziu.Common;
using Ziuziu.IDAL;
using ZiuZiu.DBUtility;

namespace Ziuziu.DBLayer 
{
    public class Area : Ziuziu.IDAL.IArea
    {
        private string tableName = "Area";

        // 保存地区信息
        public int Save(Ziuziu.Model.Area pArea, ActionProvider pActionProvider)
        {
            SqlParameter[] parameters = SqlHelper.GetCachedParameters("Ziuziu.DBLayer.Area.Save");
            if (parameters == null)
            {
                parameters = new SqlParameter[]{
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@AreaName", SqlDbType.NVarChar,50),
					new SqlParameter("@AreaCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Flag", SqlDbType.Bit,1),
					new SqlParameter("@ShortName", SqlDbType.NVarChar,50),
                    new SqlParameter("@aProvider", SqlDbType.Int,4),
                    new SqlParameter("@ReturnValue",SqlDbType.Int)};

                parameters[6].Direction = ParameterDirection.ReturnValue;
                SqlHelper.CacheParameters("Ziuziu.DBLayer.Area.Save", parameters);
            }
            parameters[0].Value = pArea.ID;
            parameters[1].Value = pArea.AreaName;
            parameters[2].Value = pArea.AreaCode;
            parameters[3].Value = pArea.Flag;
            parameters[4].Value = pArea.ShortName;
            parameters[5].Value = (int)pActionProvider;
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(SqlHelper.ConnectionStringMain))
                {
                    sqlConn.Open();

                    SqlHelper.ExecuteNonQuery(sqlConn, CommandType.StoredProcedure, "Area_InsertUpdate", parameters);

                    int Result = int.Parse(parameters[6].Value.ToString());

                    switch (Result)
                    {
                        case 0:

                            return int.Parse(parameters[0].Value.ToString());

                        case -300:

                            return -11;

                        default:

                            return -30;
                    }
                }
            }
            catch (Exception ex)
            {
                //MyErrorXml.WiterErrorToXml(ex);
                return -31;
            }


        }

        // 获得一条地区信息
        public Ziuziu.Model.Area GetModel(Ziuziu.Model.Area pAreaInfo)
        {
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ID", SqlDbType.Int, 4) };
            parameters[0].Value = pAreaInfo.ID;
            Ziuziu.Model.Area pAreaModel = new Ziuziu.Model.Area();
            try
            {
                using (DataSet ds = SqlHelper.FillDataSet(SqlHelper.ConnectionStringMain, CommandType.StoredProcedure, "Area_SelectByID", parameters))
                {
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                        {
                            pAreaInfo.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                        }
                        else
                        {
                            return null;
                        }
                        pAreaInfo.AreaName = ds.Tables[0].Rows[0]["AreaName"].ToString();
                        pAreaInfo.AreaCode = ds.Tables[0].Rows[0]["AreaCode"].ToString();
                        pAreaInfo.Flag = bool.Parse(ds.Tables[0].Rows[0]["Flag"].ToString());
                        pAreaInfo.ShortName = ds.Tables[0].Rows[0]["ShortName"].ToString();
                        return pAreaInfo;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                //MyErrorXml.WiterErrorToXml(ex);
                return null;
            }
        }

        // 获取地区信息列表
        public List<Ziuziu.Model.Area> GetList(Ziuziu.Model.Area pAreaInfo, Ziuziu.Model.PageFullInfo pPageFullInfo)
        {
            //SqlConnection sqlConn = null;
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" IsDelete=0 ");// 组合查询条件
            if (pAreaInfo.ID != 0)
                sbWhere.Append(" And ID = " + pAreaInfo.ID);// 编号
            if (!string.IsNullOrEmpty(pAreaInfo.AreaName) && (pAreaInfo.AreaName).Trim() != "")
                sbWhere.Append(" And AreaName like '%" + pAreaInfo.AreaName + "%'");// 名称
            if (pAreaInfo.Flag)
                sbWhere.Append(" And aFlag = 1");// 标志：信息
            else
                sbWhere.Append(" And aFlag = 0");// 标志：图片

            SqlParameter[] parameters = SqlHelper.GetCachedParameters("Ziuziu.DBLayer.Area.List");
            if (parameters == null)
            {
                parameters = new SqlParameter[]{
                    new SqlParameter("@tblName",SqlDbType.VarChar,255),
                    new SqlParameter("@strflds",SqlDbType.VarChar,1000),
                    new SqlParameter("@fldName",SqlDbType.VarChar,255),
                    new SqlParameter("@strWhere",SqlDbType.VarChar,1000),
                    new SqlParameter("@strOrderby",SqlDbType.VarChar,200),
                    new SqlParameter("@PageSize",SqlDbType.Int,4),
                    new SqlParameter("@PageIndex",SqlDbType.Int,4)
                };
                SqlHelper.CacheParameters("Ziuziu.DBLayer.Area.List", parameters);
            }
            parameters[0].Value = tableName;
            parameters[1].Value = "o.id,o.AreaName,o.AreaCode,o.flag,o.ShortName";
            parameters[2].Value = "id";
            parameters[3].Value = sbWhere;
            parameters[4].Value = " order by id desc";
            parameters[5].Value =pPageFullInfo.PageSize;
            parameters[6].Value = pPageFullInfo.PageIndex;


            // 返回的集合
            List<Ziuziu.Model.Area> list = new List<Ziuziu.Model.Area>();
            // 取数据填充
            try
            {
                using (SqlDataReader sdr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringMain, CommandType.StoredProcedure, "GetRecordByPageOrder", parameters))
                {
                    int[] RowNumber = new int[] {
                        sdr.GetOrdinal("ID"),  
                        sdr.GetOrdinal("AreaName"),
                        sdr.GetOrdinal("AreaCode"),
                        sdr.GetOrdinal("flag"),
                        sdr.GetOrdinal("ShortName")         
                    };

                    while (sdr.Read())
                    {
                        Ziuziu.Model.Area spcfi = new Ziuziu.Model.Area();
                        spcfi.ID = sdr.GetInt32(RowNumber[0]);
                        spcfi.AreaName = sdr.GetString(RowNumber[1]);
                        spcfi.AreaCode = sdr.GetString(RowNumber[2]);
                        spcfi.Flag = sdr.GetBoolean(RowNumber[3]);
                        spcfi.ShortName = sdr.GetString(RowNumber[4]);
                       
                        list.Add(spcfi);
                    }

                    sdr.Close();

                    return list;
                }
            }
            catch (Exception ex)
            {
                //WK.HYW.Utility.MyErrorXml.WiterErrorToXml(ex);
                return null;
            }

        }

        // 批量处理
        public int Batch(string pIDList, ActionProvider pActionProvider)
        {
            SqlParameter[] parameters = SqlHelper.GetCachedParameters("Ziuziu.DBLayer.Area.Batch");
            if (parameters == null)
            {
                parameters = new SqlParameter[]{
                    new SqlParameter("@TableName", SqlDbType.NVarChar, 30),
                    new SqlParameter("@Column", SqlDbType.NVarChar, 50),
                    new SqlParameter("@ColumnValue", SqlDbType.NVarChar, 50),
                    new SqlParameter("@PrimaryKey", SqlDbType.NVarChar, 50),
                    new SqlParameter("@PrimaryValueList", SqlDbType.NVarChar, 500)//此处可以批多个以,隔开
                };
                SqlHelper.CacheParameters("Ziuziu.DBLayer.Area.Batch", parameters);
            }
            parameters[0].Value = tableName;
            switch (pActionProvider)
            {
                case ActionProvider.Delete:// 删除
                    parameters[1].Value = "IsDelete";
                    parameters[2].Value = 1;
                    break;

                default:
                    return -101; //parameters[2].Value = string.Empty;
                //break;
            }
            parameters[3].Value = "ID";
            parameters[4].Value = pIDList;
            try
            {
                using (SqlConnection SqlConn = new SqlConnection(SqlHelper.ConnectionStringMain))
                {
                    SqlConn.Open();

                    int Result = SqlHelper.ExecuteNonQuery(SqlConn, CommandType.StoredProcedure, "Batch", parameters);

                    if (Result == 0)
                    {
                        return 0;
                    }
                    else if (Result == -1)
                    {
                        return 0;
                    }
                    else
                    {
                        return -30;
                    }
                }
            }
            catch (Exception ex)
            {
                //MyErrorXml.WiterErrorToXml(ex);

                return -31;
            }
        }
    }
}
