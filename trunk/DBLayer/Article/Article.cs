using System;
using System.Collections.Generic;
using System.Text;
using Ziuziu.IDAL;
using Ziuziu.Common;
using ZiuZiu.DBUtility;
using System.Data.SqlClient;
using System.Data;
namespace Ziuziu.DBLayer.Article
{
    public class Article : IArticle
    {
        /// <summary>
        /// 添加信息
        /// </summary>
        public int Add(Article pArticleFullInfo, ActionProvider pActionProvider)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Article(");
            strSql.Append("Title,Content,AddDate,IP,UserID,ClassID,Summary,TotalHits,IsDraft,UpdateDate,IsCheck,IsDelete,IsCommon)");
            strSql.Append(" values (");
            strSql.Append("@Title,@Content,@AddDate,@IP,@UserID,@ClassID,@Summary,@TotalHits,@IsDraft,@UpdateDate,@IsCheck,@IsDelete,@IsCommon)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IP", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@Summary", SqlDbType.NVarChar,500),
					new SqlParameter("@TotalHits", SqlDbType.Int,4),
					new SqlParameter("@IsDraft", SqlDbType.Bit,1),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@IsCheck", SqlDbType.Bit,1),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@IsCommon", SqlDbType.Int,4)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.Content;
            parameters[2].Value = model.AddDate;
            parameters[3].Value = model.IP;
            parameters[4].Value = model.UserID;
            parameters[5].Value = model.ClassID;
            parameters[6].Value = model.Summary;
            parameters[7].Value = model.TotalHits;
            parameters[8].Value = model.IsDraft;
            parameters[9].Value = model.UpdateDate;
            parameters[10].Value = model.IsCheck;
            parameters[11].Value = model.IsDelete;
            parameters[12].Value = model.IsCommon;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
         /// <summary>
        /// 更新信息
        /// </summary>
        public void Update(Article pArticleFullInfo, ActionProvider pActionProvider)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("Title=@Title,");
            strSql.Append("Content=@Content,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("IP=@IP,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("ClassID=@ClassID,");
            strSql.Append("Summary=@Summary,");
            strSql.Append("TotalHits=@TotalHits,");
            strSql.Append("IsDraft=@IsDraft,");
            strSql.Append("UpdateDate=@UpdateDate,");
            strSql.Append("IsCheck=@IsCheck,");
            strSql.Append("IsDelete=@IsDelete,");
            strSql.Append("IsCommon=@IsCommon");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@Content", SqlDbType.Text),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@IP", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@Summary", SqlDbType.NVarChar,500),
					new SqlParameter("@TotalHits", SqlDbType.Int,4),
					new SqlParameter("@IsDraft", SqlDbType.Bit,1),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@IsCheck", SqlDbType.Bit,1),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@IsCommon", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Title;
            parameters[2].Value = model.Content;
            parameters[3].Value = model.AddDate;
            parameters[4].Value = model.IP;
            parameters[5].Value = model.UserID;
            parameters[6].Value = model.ClassID;
            parameters[7].Value = model.Summary;
            parameters[8].Value = model.TotalHits;
            parameters[9].Value = model.IsDraft;
            parameters[10].Value = model.UpdateDate;
            parameters[11].Value = model.IsCheck;
            parameters[12].Value = model.IsDelete;
            parameters[13].Value = model.IsCommon;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获得一条信息
        /// </summary>
        /// <param name="pID"></param>
        /// <returns></returns>
        public Article GetModel(int pID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Title,Content,AddDate,IP,UserID,ClassID,Summary,TotalHits,IsDraft,UpdateDate,IsCheck,IsDelete,IsCommon from Article ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = pID;

            Article model = new Article();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                model.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                model.IP = ds.Tables[0].Rows[0]["IP"].ToString();
                if (ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassID"].ToString() != "")
                {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                model.Summary = ds.Tables[0].Rows[0]["Summary"].ToString();
                if (ds.Tables[0].Rows[0]["TotalHits"].ToString() != "")
                {
                    model.TotalHits = int.Parse(ds.Tables[0].Rows[0]["TotalHits"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsDraft"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDraft"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDraft"].ToString().ToLower() == "true"))
                    {
                        model.IsDraft = true;
                    }
                    else
                    {
                        model.IsDraft = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["UpdateDate"].ToString() != "")
                {
                    model.UpdateDate = DateTime.Parse(ds.Tables[0].Rows[0]["UpdateDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsCheck"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCheck"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCheck"].ToString().ToLower() == "true"))
                    {
                        model.IsCheck = true;
                    }
                    else
                    {
                        model.IsCheck = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsDelete"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDelete"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDelete"].ToString().ToLower() == "true"))
                    {
                        model.IsDelete = true;
                    }
                    else
                    {
                        model.IsDelete = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCommon"].ToString() != "")
                {
                    model.IsCommon = int.Parse(ds.Tables[0].Rows[0]["IsCommon"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取信息列表
        /// </summary>
        public List<Article> GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Title,Content,AddDate,IP,UserID,ClassID,Summary,TotalHits,IsDraft,UpdateDate,IsCheck,IsDelete,IsCommon ");
            strSql.Append(" FROM Article ");
            strSql.Append(" where IsDraft=0 AND IsCheck=1 AND IsDelete=0");            
            SqlParameter[] parameters = {};

            List<Article> ArticleList=new List<Article>();

            SqlDataReader dr=SqlHelper.ExecuteReader(SqlHelper.ConnectionStringMain,CommandType.Text,strSql,parameters);
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Article model = new Article();
                    if (ds.Tables[0].Rows[i]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                    }
                    model.Title = ds.Tables[0].Rows[i]["Title"].ToString();
                    model.Content = ds.Tables[0].Rows[i]["Content"].ToString();
                    if (ds.Tables[0].Rows[i]["AddDate"].ToString() != "")
                    {
                        model.AddDate = DateTime.Parse(ds.Tables[0].Rows[i]["AddDate"].ToString());
                    }
                    model.IP = ds.Tables[0].Rows[i]["IP"].ToString();
                    if (ds.Tables[0].Rows[i]["UserID"].ToString() != "")
                    {
                        model.UserID = int.Parse(ds.Tables[0].Rows[i]["UserID"].ToString());
                    }
                    if (ds.Tables[0].Rows[i]["ClassID"].ToString() != "")
                    {
                        model.ClassID = int.Parse(ds.Tables[0].Rows[i]["ClassID"].ToString());
                    }
                    model.Summary = ds.Tables[0].Rows[i]["Summary"].ToString();
                    if (ds.Tables[0].Rows[i]["TotalHits"].ToString() != "")
                    {
                        model.TotalHits = int.Parse(ds.Tables[0].Rows[i]["TotalHits"].ToString());
                    }
                    if (ds.Tables[0].Rows[i]["IsDraft"].ToString() != "")
                    {
                        if ((ds.Tables[0].Rows[i]["IsDraft"].ToString() == "1") || (ds.Tables[0].Rows[i]["IsDraft"].ToString().ToLower() == "true"))
                        {
                            model.IsDraft = true;
                        }
                        else
                        {
                            model.IsDraft = false;
                        }
                    }
                    if (ds.Tables[0].Rows[i]["UpdateDate"].ToString() != "")
                    {
                        model.UpdateDate = DateTime.Parse(ds.Tables[0].Rows[i]["UpdateDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[i]["IsCheck"].ToString() != "")
                    {
                        if ((ds.Tables[0].Rows[i]["IsCheck"].ToString() == "1") || (ds.Tables[0].Rows[i]["IsCheck"].ToString().ToLower() == "true"))
                        {
                            model.IsCheck = true;
                        }
                        else
                        {
                            model.IsCheck = false;
                        }
                    }
                    if (ds.Tables[0].Rows[i]["IsDelete"].ToString() != "")
                    {
                        if ((ds.Tables[0].Rows[i]["IsDelete"].ToString() == "1") || (ds.Tables[0].Rows[i]["IsDelete"].ToString().ToLower() == "true"))
                        {
                            model.IsDelete = true;
                        }
                        else
                        {
                            model.IsDelete = false;
                        }
                    }
                    if (ds.Tables[0].Rows[i]["IsCommon"].ToString() != "")
                    {
                        model.IsCommon = int.Parse(ds.Tables[0].Rows[i]["IsCommon"].ToString());
                    }
                }

                ArticleList.Add(article);
            }


            return ArticleList;
        }

        // 批量处理
        public int Batch(string pIDList, ActionProvider pActionProvider)
        { }
    }
}
