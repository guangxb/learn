using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using RedGlovePermission.DBUtility;
using RedGlovePermission.IDAL;

namespace RedGlovePermission.MySqlDAL
{
	/// <summary>
    /// ��ɫ�������ݷ�����
	/// </summary>
	public class RGP_Roles:IRGP_Roles
	{
		public RGP_Roles()
		{ }

        #region ��ɫ����

        /// <summary>
        /// �жϽ�ɫ�Ƿ����
        /// </summary>
        /// <param name="RoleName">��ɫ����</param>
        /// <param name="RoleGroupID">��ɫ����ID</param>
        /// <returns></returns>
        public bool RoleExists(string RoleName,int RoleGroupID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RGP_Roles");
            strSql.Append(" where RoleName=?RoleName and RoleGroupID=?RoleGroupID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleName", MySqlDbType.VarChar,30),
                    new MySqlParameter("?RoleGroupID", MySqlDbType.Int32,11)};
            parameters[0].Value = RoleName;
            parameters[1].Value = RoleGroupID;

			return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// ���ӽ�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
		public int CreateRole(RedGlovePermission.Model.RGP_Roles model)
        {
            int ret = 0;
            if (!RoleExists(model.RoleName, model.RoleGroupID))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into RGP_Roles(");
                strSql.Append("RoleGroupID,RoleName,RoleDescription)");
                strSql.Append(" values (");
                strSql.Append("?RoleGroupID,?RoleName,?RoleDescription)");
                MySqlParameter[] parameters = {
					new MySqlParameter("?RoleGroupID", MySqlDbType.Int32,11),
					new MySqlParameter("?RoleName", MySqlDbType.VarChar,30),
					new MySqlParameter("?RoleDescription", MySqlDbType.VarChar,50)};
                parameters[0].Value = model.RoleGroupID;
                parameters[1].Value = model.RoleName;
                parameters[2].Value = model.RoleDescription;

                if (RedGlovePermission.DBUtility.MySqlHelper.ExecuteSql(strSql.ToString(), parameters) >= 1)
                {
                    ret = 1;
                }
            }
            else
            {
                ret = 2;
            }

            return ret;
        }

        /// <summary>
        /// ���½�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
        public bool UpdateRole(RedGlovePermission.Model.RGP_Roles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RGP_Roles set ");
            strSql.Append("RoleGroupID=?RoleGroupID,");
			strSql.Append("RoleName=?RoleName,");
			strSql.Append("RoleDescription=?RoleDescription");
			strSql.Append(" where RoleID=?RoleID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int32,11),
					new MySqlParameter("?RoleGroupID", MySqlDbType.Int32,11),
					new MySqlParameter("?RoleName", MySqlDbType.VarChar,30),
					new MySqlParameter("?RoleDescription", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.RoleID;
            parameters[1].Value = model.RoleGroupID;
			parameters[2].Value = model.RoleName;
			parameters[3].Value = model.RoleDescription;

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
        /// ɾ����ɫ
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        public int DeleteRole(int RoleID)
		{	
            int ret=0;
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int32,11)};
			parameters[0].Value = RoleID;

            string strSql1 = "Select userid from Users where RoleID=?RoleID";
            
            //ɾ����ɫ��ͬʱɾ����ص�Ȩ��
            ArrayList list = new ArrayList();
            list.Add("delete from RGP_RoleAuthorityList where RoleID=" + RoleID.ToString());
            list.Add("delete from RGP_Roles where RoleID=" + RoleID.ToString());            

            if (!RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql1, parameters))
            {
                try
                {
                    RedGlovePermission.DBUtility.MySqlHelper.ExecuteSqlTran(list);
                    ret = 1;
                }
                catch
                {
                    ;
                }
            }
            else
            {
                ret = 2;
            }
            return ret;
		}

        /// <summary>
        /// ��ȡ��ɫʵ��
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Roles GetRoleModel(int RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * from RGP_Roles ");
			strSql.Append(" where RoleID=?RoleID ");
			MySqlParameter[] parameters = {
					new MySqlParameter("?RoleID", MySqlDbType.Int32,11)};
			parameters[0].Value = RoleID;

			RedGlovePermission.Model.RGP_Roles model=new RedGlovePermission.Model.RGP_Roles();
			DataSet ds=RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RoleRoleID"].ToString()!="")
				{
                    model.RoleGroupID = int.Parse(ds.Tables[0].Rows[0]["RoleGroupID"].ToString());
				}
				model.RoleName=ds.Tables[0].Rows[0]["RoleName"].ToString();
				model.RoleDescription=ds.Tables[0].Rows[0]["RoleDescription"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// ��ý�ɫ�����б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetRoleList(string strWhere,string strOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_Roles ");

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

        #endregion

        #region ��ɫ��Ȩ

        /// <summary>
        /// �жϼ�¼�Ƿ����
        /// </summary>
        public bool RoleAuthorityExists(RedGlovePermission.Model.RGP_RoleAuthorityList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RGP_RoleAuthorityList where ");
            if (model.UserID != 0)//�ж��ǽ�ɫȨ�޻����û�Ȩ��
            { strSql.Append("UserID=?UserID"); }
            else
            { strSql.Append("RoleID=?RoleID"); }
            strSql.Append(" and ModuleID=?ModuleID and AuthorityTag=?AuthorityTag");
            MySqlParameter[] parameters = {
                    new MySqlParameter("?UserID", MySqlDbType.Int32,11),
					new MySqlParameter("?RoleID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleID", MySqlDbType.Int32,11),
					new MySqlParameter("?AuthorityTag", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.UserID;
            parameters[1].Value = model.RoleID;
            parameters[2].Value = model.ModuleID;
            parameters[3].Value = model.AuthorityTag;

            return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// �޸Ľ�ɫģ��Ȩ��
        /// </summary>
        public bool UpdateRoleAuthority(ArrayList list)
        {
            ArrayList AuthorityList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split('|');
                if (val[3] == "0")//���Ϊ0��ɾ��Ȩ��
                {
                    AuthorityList.Add("delete from RGP_RoleAuthorityList where RoleID=" + val[0] + " and ModuleID=" + val[1] + " and AuthorityTag='" + val[2] + "'");
                }
                else
                {
                    AuthorityList.Add("insert into RGP_RoleAuthorityList(RoleID,ModuleID,AuthorityTag) values (" + val[0] + "," + val[1] + ",'" + val[2] + "')");
                }
            }

            try
            {
                RedGlovePermission.DBUtility.MySqlHelper.ExecuteSqlTran(AuthorityList);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// �޸��û�ģ��Ȩ��
        /// </summary>
        public bool UpdateUserAuthority(ArrayList list)
        {
            ArrayList AuthorityList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split('|');
                if (val[3] == "0")//���Ϊ0��ɾ��Ȩ��
                {
                    AuthorityList.Add("delete from RGP_RoleAuthorityList where UserID=" + val[0] + " ModuleID=" + val[1] + " and AuthorityTag='" + val[2] + "'");
                }
                else
                {
                    AuthorityList.Add("insert into RGP_RoleAuthorityList(UserID,ModuleID,AuthorityTag) values (" + val[0] + "," + val[1] + ",'" + val[2] + "')");
                }
            }

            try
            {
                RedGlovePermission.DBUtility.MySqlHelper.ExecuteSqlTran(AuthorityList);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// ��ȡ��ɫ��ģ��Ȩ��
        /// </summary>
        public DataSet GetRoleAuthorityList(int RoleID, int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_RoleAuthorityList where RoleID=" + RoleID.ToString() + " and ModuleID=" + ModuleID.ToString());

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ȡ�û���ģ��Ȩ��
        /// </summary>
        public DataSet GetUserAuthorityList(int UserID, int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_RoleAuthorityList where UserID=" + UserID.ToString() + " and ModuleID=" + ModuleID.ToString());

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        #endregion
    }
}

