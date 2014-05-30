using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using RedGlovePermission.DBUtility;
using RedGlovePermission.IDAL;

namespace RedGlovePermission.MySqlDAL
{
	/// <summary>
    /// ����������ݷ�����
	/// </summary>
	public class RGP_Groups:IRGP_Groups
	{
		public RGP_Groups()
		{}
		#region  ��Ա����

		/// <summary>
        /// �жϷ����Ƿ����
		/// </summary>
		/// <param name="GroupName">��������</param>
		/// <returns></returns>
		public bool Exists(string GroupName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RGP_Groups");
            strSql.Append(" where GroupName=?GroupName ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?GroupName", MySqlDbType.VarChar,30)};
            parameters[0].Value = GroupName;

			return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        public bool CreateGroup(RedGlovePermission.Model.RGP_Groups model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RGP_Groups(");
			strSql.Append("GroupName,GroupOrder,GroupDescription)");
			strSql.Append(" values (");
			strSql.Append("?GroupName,?GroupOrder,?GroupDescription)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?GroupName", MySqlDbType.VarChar,30),
					new MySqlParameter("?GroupOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?GroupDescription", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.GroupOrder;
			parameters[2].Value = model.GroupDescription;

            if (RedGlovePermission.DBUtility.MySqlHelper.ExecuteSql(strSql.ToString(), parameters) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        public bool UpdateGroup(RedGlovePermission.Model.RGP_Groups model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RGP_Groups set ");
			strSql.Append("GroupName=?GroupName,");
			strSql.Append("GroupOrder=?GroupOrder,");
			strSql.Append("GroupDescription=?GroupDescription");
			strSql.Append(" where GroupID=?GroupID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?GroupID", MySqlDbType.Int32,11),
					new MySqlParameter("?GroupName", MySqlDbType.VarChar,30),
					new MySqlParameter("?GroupOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?GroupDescription", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.GroupID;
			parameters[1].Value = model.GroupName;
			parameters[2].Value = model.GroupOrder;
			parameters[3].Value = model.GroupDescription;

            if (RedGlovePermission.DBUtility.MySqlHelper.ExecuteSql(strSql.ToString(), parameters) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        public int DeleteGroup(int GroupID)
		{
            int ret = 0;
            string strSql1 = "Select RoleID from RGP_Roles where RoleGroupID=?GroupID"; //�鿴Ӧ�����Ƿ���ڽ�ɫ
            string strSql2 = "Select UserID from Users where UserGroup=?GroupID";        //�鿴Ӧ�����Ƿ�����û�
            string strSql3 = "delete from RGP_Groups where GroupID=?GroupID";            

			MySqlParameter[] parameters = {
					new MySqlParameter("?GroupID", MySqlDbType.Int32,11)};
			parameters[0].Value = GroupID;

            if (!RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql1.ToString(), parameters))
            {
                if (!RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql2.ToString(), parameters))
                {
                    if (RedGlovePermission.DBUtility.MySqlHelper.ExecuteSql(strSql3.ToString(), parameters) >= 1)
                    {
                        ret = 1;//ɾ���ɹ�
                    }
                }
                else
                {
                    ret = 2;//���û�������ɾ��
                }
            }
            else
            {
                ret = 3;//�н�ɫ������ɾ��
            }

            return ret;
		}

		/// <summary>
        /// �õ�һ������ʵ��
		/// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Groups GetGroupModel(int GroupID)
		{			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select GroupID,GroupName,GroupOrder,GroupDescription from RGP_Groups ");
			strSql.Append(" where GroupID=?GroupID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?GroupID", MySqlDbType.Int32,11)};
			parameters[0].Value = GroupID;

			RedGlovePermission.Model.RGP_Groups model=new RedGlovePermission.Model.RGP_Groups();
			DataSet ds=RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(ds.Tables[0].Rows[0]["GroupID"].ToString());
				}
				model.GroupName=ds.Tables[0].Rows[0]["GroupName"].ToString();
				if(ds.Tables[0].Rows[0]["GroupOrder"].ToString()!="")
				{
					model.GroupOrder=int.Parse(ds.Tables[0].Rows[0]["GroupOrder"].ToString());
				}
				model.GroupDescription=ds.Tables[0].Rows[0]["GroupDescription"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetGroupList(string strWhere, string strOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_Groups ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            if (strOrder.Trim() != "")
            {
                strSql.Append(" " + strOrder);
            }

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

		#endregion  ��Ա����
	}
}

