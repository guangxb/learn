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
    /// ����ģ�����ݷ�����
    /// </summary>
    public class RGP_Modules:IRGP_Modules
    {
        public RGP_Modules()
        { }

        #region ģ�����
        /// <summary>
        /// �ж�ģ������Ƿ����
        /// </summary>
        /// <param name="ModuleTypeName">ģ���������</param>
        /// <returns></returns>
        public bool ModuleTypeExists(string ModuleTypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RGP_ModuleType");
            strSql.Append(" where ModuleTypeName=?ModuleTypeName ");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeName", MySqlDbType.VarChar,30)};
            parameters[0].Value = ModuleTypeName;

            return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ����һ��ģ�����
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        public int CreateModuleType(RedGlovePermission.Model.RGP_ModuleType model)
        {
            int ret = 0;
            if (!ModuleTypeExists(model.ModuleTypeName))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into RGP_ModuleType(");
                strSql.Append("ModuleTypeName,ModuleTypeOrder,ModuleTypeDescription)");
                strSql.Append(" values (");
                strSql.Append("?ModuleTypeName,?ModuleTypeOrder,?ModuleTypeDescription)");
                MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeName", MySqlDbType.VarChar,30),
					new MySqlParameter("?ModuleTypeOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleTypeDescription", MySqlDbType.VarChar,50)};
                parameters[0].Value = model.ModuleTypeName;
                parameters[1].Value = model.ModuleTypeOrder;
                parameters[2].Value = model.ModuleTypeDescription;

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
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        public bool UpdateModuleType(RedGlovePermission.Model.RGP_ModuleType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RGP_ModuleType set ");
            strSql.Append("ModuleTypeName=?ModuleTypeName,");
            strSql.Append("ModuleTypeOrder=?ModuleTypeOrder,");
            strSql.Append("ModuleTypeDescription=?ModuleTypeDescription");
            strSql.Append(" where ModuleTypeID=?ModuleTypeID");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleTypeName", MySqlDbType.VarChar,30),
					new MySqlParameter("?ModuleTypeOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleTypeDescription", MySqlDbType.VarChar,50)};
            parameters[0].Value = model.ModuleTypeID;
            parameters[1].Value = model.ModuleTypeName;
            parameters[2].Value = model.ModuleTypeOrder;
            parameters[3].Value = model.ModuleTypeDescription;

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
        /// ɾ��ģ�����
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        public int DeleteModuleType(int ModuleTypeID)
        {
            int ret = 0;
            string strSql1 = "Select ModuleID from RGP_Modules where ModuleTypeID=?ModuleTypeID";
            string strSql2 = "delete from RGP_ModuleType where ModuleTypeID=?ModuleTypeID";

            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeID", MySqlDbType.Int32,11)};
            parameters[0].Value = ModuleTypeID;

            if (!RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql1, parameters))
            {
                if (RedGlovePermission.DBUtility.MySqlHelper.ExecuteSql(strSql2, parameters) >= 1) { ret = 1; }
            }
            else
            {
                ret = 2;
            }
            return ret;
        }

        /// <summary>
        /// �õ�һ��ģ�����ʵ��
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_ModuleType GetModuleTypeModel(int ModuleTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from RGP_ModuleType ");
            strSql.Append(" where ModuleTypeID=?ModuleTypeID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeID", MySqlDbType.Int32,11)};
            parameters[0].Value = ModuleTypeID;

            RedGlovePermission.Model.RGP_ModuleType model = new RedGlovePermission.Model.RGP_ModuleType();
            DataSet ds = RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ModuleTypeID"].ToString() != "")
                {
                    model.ModuleTypeID = int.Parse(ds.Tables[0].Rows[0]["ModuleTypeID"].ToString());
                }
                model.ModuleTypeName = ds.Tables[0].Rows[0]["ModuleTypeName"].ToString();
                if (ds.Tables[0].Rows[0]["ModuleTypeOrder"].ToString() != "")
                {
                    model.ModuleTypeOrder = int.Parse(ds.Tables[0].Rows[0]["ModuleTypeOrder"].ToString());
                }
                model.ModuleTypeDescription = ds.Tables[0].Rows[0]["ModuleTypeDescription"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ���ģ����������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetModuleTypeList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_ModuleType ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by ModuleTypeOrder asc");

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        #endregion

        #region ģ�����
        /// <summary>
        /// �ж�ģ���Ƿ����
        /// </summary>
        /// <param name="ModuleName">ģ������</param>
        /// <returns></returns>
        public bool ModuleExists(string ModuleTag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RGP_Modules");
            strSql.Append(" where ModuleTag=?ModuleTag");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50)};
            parameters[0].Value = ModuleTag;

            return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ����ʱ�ж�ģ���Ƿ����
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <param name="ModuleName">ģ������</param>
        /// <returns></returns>
        public bool UpdateExists(int ModuleID, string ModuleTag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from RGP_Modules");
            strSql.Append(" where ModuleID<>?ModuleID and ModuleTag=?ModuleTag");
            MySqlParameter[] parameters = {
                    new MySqlParameter("?ModuleID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50)};
            parameters[0].Value = ModuleID;
            parameters[1].Value = ModuleTag;

            return RedGlovePermission.DBUtility.MySqlHelper.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ����һ��ģ��
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        public int CreateModule(RedGlovePermission.Model.RGP_Modules model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RGP_Modules(");
            strSql.Append("ModuleTypeID,ModuleName,ModuleTag,ModuleURL,ModuleDisabled,ModuleOrder,ModuleDescription,IsMenu)");
            strSql.Append(" values (");
            strSql.Append("?ModuleTypeID,?ModuleName,?ModuleTag,?ModuleURL,?ModuleDisabled,?ModuleOrder,?ModuleDescription,?IsMenu)");
            strSql.Append(";select LAST_INSERT_ID()");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTypeID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleName", MySqlDbType.VarChar,30),
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50),
					new MySqlParameter("?ModuleURL", MySqlDbType.VarChar,500),
					new MySqlParameter("?ModuleDisabled", MySqlDbType.Bit,1),
					new MySqlParameter("?ModuleOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleDescription", MySqlDbType.VarChar,50),
                    new MySqlParameter("?IsMenu", MySqlDbType.Bit,1)};
            parameters[0].Value = model.ModuleTypeID;
            parameters[1].Value = model.ModuleName;
            parameters[2].Value = model.ModuleTag;
            parameters[3].Value = model.ModuleURL;
            parameters[4].Value = model.ModuleDisabled;
            parameters[5].Value = model.ModuleOrder;
            parameters[6].Value = model.ModuleDescription;
            parameters[7].Value = model.IsMenu;

            object obj = RedGlovePermission.DBUtility.MySqlHelper.GetSingle(strSql.ToString(), parameters);
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
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        public int UpdateModule(RedGlovePermission.Model.RGP_Modules model)
        {
            int ret = 0;
            if (!UpdateExists(model.ModuleID, model.ModuleTag))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update RGP_Modules set ");
                strSql.Append("ModuleTypeID=?ModuleTypeID,");
                strSql.Append("ModuleName=?ModuleName,");
                strSql.Append("ModuleTag=?ModuleTag,");
                strSql.Append("ModuleURL=?ModuleURL,");
                strSql.Append("ModuleDisabled=?ModuleDisabled,");
                strSql.Append("ModuleOrder=?ModuleOrder,");
                strSql.Append("ModuleDescription=?ModuleDescription");
                strSql.Append(" where ModuleID=?ModuleID ");
                MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleTypeID", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleName", MySqlDbType.VarChar,30),
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50),
					new MySqlParameter("?ModuleURL", MySqlDbType.VarChar,500),
					new MySqlParameter("?ModuleDisabled", MySqlDbType.Bit,1),
					new MySqlParameter("?ModuleOrder", MySqlDbType.Int32,11),
					new MySqlParameter("?ModuleDescription", MySqlDbType.VarChar,50)};
                parameters[0].Value = model.ModuleID;
                parameters[1].Value = model.ModuleTypeID;
                parameters[2].Value = model.ModuleName;
                parameters[3].Value = model.ModuleTag;
                parameters[4].Value = model.ModuleURL;
                parameters[5].Value = model.ModuleDisabled;
                parameters[6].Value = model.ModuleOrder;
                parameters[7].Value = model.ModuleDescription;

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
        /// ɾ��ģ�飬�Լ���Ӧ��Ȩ��
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public bool DeleteModule(int ModuleID)
        {
            ArrayList List = new ArrayList();
            List.Add("delete from RGP_Modules where ModuleID=" + ModuleID.ToString());
            List.Add("delete from RGP_ModuleAuthorityList where ModuleID=" + ModuleID.ToString());
            try
            {
                RedGlovePermission.DBUtility.MySqlHelper.ExecuteSqlTran(List);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// �õ�һ��ģ��ʵ��
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Modules GetModuleModel(int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from RGP_Modules ");
            strSql.Append(" where ModuleID=?ModuleID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleID", MySqlDbType.Int32,11)};
            parameters[0].Value = ModuleID;

            RedGlovePermission.Model.RGP_Modules model = new RedGlovePermission.Model.RGP_Modules();
            DataSet ds = RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ModuleID"].ToString() != "")
                {
                    model.ModuleID = int.Parse(ds.Tables[0].Rows[0]["ModuleID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModuleTypeID"].ToString() != "")
                {
                    model.ModuleTypeID = int.Parse(ds.Tables[0].Rows[0]["ModuleTypeID"].ToString());
                }
                model.ModuleName = ds.Tables[0].Rows[0]["ModuleName"].ToString();
                model.ModuleTag = ds.Tables[0].Rows[0]["ModuleTag"].ToString();
                model.ModuleURL = ds.Tables[0].Rows[0]["ModuleURL"].ToString();
                if (ds.Tables[0].Rows[0]["ModuleDisabled"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["ModuleDisabled"].ToString() == "1") || (ds.Tables[0].Rows[0]["ModuleDisabled"].ToString().ToLower() == "true"))
                    {
                        model.ModuleDisabled = true;
                    }
                    else
                    {
                        model.ModuleDisabled = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["ModuleOrder"].ToString() != "")
                {
                    model.ModuleOrder = int.Parse(ds.Tables[0].Rows[0]["ModuleOrder"].ToString());
                }
                model.ModuleDescription = ds.Tables[0].Rows[0]["ModuleDescription"].ToString();

                if (ds.Tables[0].Rows[0]["IsMenu"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsMenu"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsMenu"].ToString().ToLower() == "true"))
                    {
                        model.IsMenu = true;
                    }
                    else
                    {
                        model.IsMenu = false;
                    }
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ���ģ�������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetModuleList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * FROM RGP_Modules ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" order by ModuleOrder asc");

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// ��ȡģ��ID
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        public int GetModuleID(string ModuleTag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ModuleID from RGP_Modules where ModuleTag=?ModuleTag");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50)};
            parameters[0].Value = ModuleTag;

            object obj = RedGlovePermission.DBUtility.MySqlHelper.GetSingle(strSql.ToString(), parameters);
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
        /// ģ���Ƿ�ر�
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        public bool IsModule(string ModuleTag)
        {
            bool ret = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ModuleDisabled from RGP_Modules where ModuleTag=?ModuleTag");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleTag", MySqlDbType.VarChar,50)};
            parameters[0].Value = ModuleTag;

            object obj = RedGlovePermission.DBUtility.MySqlHelper.GetSingle(strSql.ToString(), parameters);
            if (obj != null)
            {
                if ((obj.ToString() == "1") || (obj.ToString().ToLower() == "true"))
                    ret = true;
            }
            return ret;
        }

        #endregion

        #region ģ����Ȩ

        /// <summary>
        /// ����ģ��Ȩ��
        /// </summary>
        /// <param name="list">Ȩ���б�</param>
        /// <returns></returns>
        public bool CreateAuthorityList(ArrayList list)
        {
            ArrayList AuthorityList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split('|');
                AuthorityList.Add("insert into RGP_ModuleAuthorityList(ModuleID,AuthorityTag) values (" + val[0] + ",'" + val[1] + "')");
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
        /// ����ģ��Ȩ��
        /// </summary>
        public bool UpdateAuthorityList(ArrayList list)
        {
            ArrayList AuthorityList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split('|');
                if (val[2] == "0")//���Ϊ0��ɾ��Ȩ��
                {
                    //ɾ��ģ��Ȩ��
                    AuthorityList.Add("delete from RGP_ModuleAuthorityList where ModuleID=" + val[0] + " and AuthorityTag='" + val[1] + "'");
                    //ɾ����ɫ����Ӧ��ģ���ʶ��Ȩ��
                    AuthorityList.Add("delete from RGP_RoleAuthorityList where ModuleID=" + val[0] + " and AuthorityTag='" + val[1] + "'");
                }
                else
                {
                    AuthorityList.Add("insert into RGP_ModuleAuthorityList(ModuleID,AuthorityTag) values (" + val[0] + ",'" + val[1] + "')");
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
        /// ɾ��ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public bool DeleteAuthority(int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RGP_ModuleAuthorityList ");
            strSql.Append(" where ModuleID=?ModuleID ");
            MySqlParameter[] parameters = {
					new MySqlParameter("?ModuleID", MySqlDbType.Int32,11)};
            parameters[0].Value = ModuleID;

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
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public DataSet GetAuthorityList(int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from RGP_ModuleAuthorityList where ModuleID=" + ModuleID.ToString());

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public DataSet GetAuthorityNameList(int ModuleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT RGP_ModuleAuthorityList.*, RGP_AuthorityDir.AuthorityName FROM RGP_ModuleAuthorityList INNER JOIN RGP_AuthorityDir ON RGP_ModuleAuthorityList.AuthorityTag = RGP_AuthorityDir.AuthorityTag where ModuleID=" + ModuleID.ToString());

            return RedGlovePermission.DBUtility.MySqlHelper.Query(strSql.ToString());
        }

        #endregion
    }
}