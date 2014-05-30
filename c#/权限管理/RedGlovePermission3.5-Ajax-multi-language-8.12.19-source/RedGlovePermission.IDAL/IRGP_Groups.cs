using System;
using System.Data;

namespace RedGlovePermission.IDAL
{
    public interface IRGP_Groups
	{
        /// <summary>
        /// �жϷ����Ƿ����
        /// </summary>
        /// <param name="GroupName">��������</param>
        /// <returns></returns>
        bool Exists(string GroupName);

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        bool CreateGroup(RedGlovePermission.Model.RGP_Groups model);

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        bool UpdateGroup(RedGlovePermission.Model.RGP_Groups model);

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        int DeleteGroup(int GroupID);

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        RedGlovePermission.Model.RGP_Groups GetGroupModel(int GroupID);

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        DataSet GetGroupList(string strWhere, string strOrder);

    }
}

