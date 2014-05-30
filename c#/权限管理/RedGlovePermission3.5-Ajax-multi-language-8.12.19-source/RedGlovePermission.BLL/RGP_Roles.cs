using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

using RedGlovePermission.Lib;
using RedGlovePermission.Model;
using RedGlovePermission.DALFactory;
using RedGlovePermission.IDAL;

namespace RedGlovePermission.BLL
{
	/// <summary>
	/// ҵ���߼���RGP_Roles ��ժҪ˵����
	/// </summary>
	public class RGP_Roles
	{
        private readonly IRGP_Roles dal = DataAccess.CreateRGP_Roles();

		public RGP_Roles()
		{ }

        #region ��ɫ����

        /// <summary>
        /// �жϽ�ɫ�Ƿ����
        /// </summary>
        /// <param name="RoleName">��ɫ����</param>
        /// <param name="RoleGroupID">��ɫ����ID</param>
        /// <returns></returns>
        public bool RoleExists(string RoleName, int RoleGroupID)
        {
            return dal.RoleExists(RoleName, RoleGroupID);
        }

        /// <summary>
        /// ���ӽ�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
        public int CreateRole(RedGlovePermission.Model.RGP_Roles model)
        {
            return dal.CreateRole(model);
        }

        /// <summary>
        /// ���½�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
        public bool UpdateRole(RedGlovePermission.Model.RGP_Roles model)
        {
            return dal.UpdateRole(model);
        }

        /// <summary>
        /// ɾ����ɫ
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        public int DeleteRole(int RoleID)
        {
            return dal.DeleteRole(RoleID);
        }

        /// <summary>
        /// ��ȡ��ɫʵ��
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Roles GetRoleModel(int RoleID)
        {
            return dal.GetRoleModel(RoleID);
        }

        /// <summary>
        /// ��ý�ɫ�����б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetRoleList(string strWhere, string strOrder)
        {
            return dal.GetRoleList(strWhere, strOrder);
        }

        #endregion

        #region ��ɫ��Ȩ

        /// <summary>
        /// �жϼ�¼�Ƿ����
        /// </summary>
        public bool RoleAuthorityExists(RedGlovePermission.Model.RGP_RoleAuthorityList model)
        {
            return dal.RoleAuthorityExists(model);
        }

        /// <summary>
        /// �޸Ľ�ɫģ��Ȩ��
        /// </summary>
        public bool UpdateRoleAuthority(ArrayList list)
        {
            return dal.UpdateRoleAuthority(list);
        }

        /// <summary>
        /// �޸��û�ģ��Ȩ��
        /// </summary>
        public bool UpdateUserAuthority(ArrayList list)
        {
            return dal.UpdateUserAuthority(list);
        }

        /// <summary>
        /// ��ȡ��ɫ��ģ��Ȩ��
        /// </summary>
        public DataSet GetRoleAuthorityList(int RoleID, int ModuleID)
        {
            return dal.GetRoleAuthorityList(RoleID, ModuleID);
        }

        /// <summary>
        /// ��ȡ�û���ģ��Ȩ��
        /// </summary>
        public DataSet GetUserAuthorityList(int UserID, int ModuleID)
        {
            return dal.GetUserAuthorityList(UserID, ModuleID);
        }

        #endregion
    }
}

