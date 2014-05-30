using System;
using System.Collections;
using System.Data;

namespace RedGlovePermission.IDAL
{
    public interface IRGP_Roles
	{

        #region ��ɫ����

        /// <summary>
        /// �жϽ�ɫ�Ƿ����
        /// </summary>
        /// <param name="RoleName">��ɫ����</param>
        /// <param name="RoleGroupID">��ɫ����ID</param>
        /// <returns></returns>
        bool RoleExists(string RoleName, int RoleGroupID);

        /// <summary>
        /// ���ӽ�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
        int CreateRole(RedGlovePermission.Model.RGP_Roles model);

        /// <summary>
        /// ���½�ɫ
        /// </summary>
        /// <param name="model">��ɫʵ����</param>
        /// <returns></returns>
        bool UpdateRole(RedGlovePermission.Model.RGP_Roles model);

        /// <summary>
        /// ɾ����ɫ
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        int DeleteRole(int RoleID);

        /// <summary>
        /// ��ȡ��ɫʵ��
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        RedGlovePermission.Model.RGP_Roles GetRoleModel(int RoleID);

        /// <summary>
        /// ��ý�ɫ�����б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        DataSet GetRoleList(string strWhere, string strOrder);

        #endregion

        #region ��ɫ��Ȩ

        /// <summary>
        /// �жϼ�¼�Ƿ����
        /// </summary>
        bool RoleAuthorityExists(RedGlovePermission.Model.RGP_RoleAuthorityList model);

        /// <summary>
        /// �޸Ľ�ɫģ��Ȩ��
        /// </summary>
        bool UpdateRoleAuthority(ArrayList list);

        /// <summary>
        /// �޸��û�ģ��Ȩ��
        /// </summary>
        bool UpdateUserAuthority(ArrayList list);

        /// <summary>
        /// ��ȡ��ɫ��ģ��Ȩ��
        /// </summary>
        DataSet GetRoleAuthorityList(int RoleID, int ModuleID);

        /// <summary>
        /// ��ȡ�û���ģ��Ȩ��
        /// </summary>
        DataSet GetUserAuthorityList(int UserID, int ModuleID);

        #endregion
    }
}

