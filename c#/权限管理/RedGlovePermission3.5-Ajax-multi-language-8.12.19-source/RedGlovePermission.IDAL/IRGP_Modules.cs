using System;
using System.Collections;
using System.Data;

namespace RedGlovePermission.IDAL
{
    public interface IRGP_Modules
	{

        #region ģ�����

        /// <summary>
        /// �ж�ģ������Ƿ����
        /// </summary>
        /// <param name="ModuleTypeName">ģ���������</param>
        /// <returns></returns>
        bool ModuleTypeExists(string ModuleTypeName);

        /// <summary>
        /// ����һ��ģ�����
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        int CreateModuleType(RedGlovePermission.Model.RGP_ModuleType model);

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        bool UpdateModuleType(RedGlovePermission.Model.RGP_ModuleType model);

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        int DeleteModuleType(int ModuleTypeID);

        /// <summary>
        /// �õ�һ��ģ�����ʵ��
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        RedGlovePermission.Model.RGP_ModuleType GetModuleTypeModel(int ModuleTypeID);

        /// <summary>
        /// ���ģ����������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        DataSet GetModuleTypeList(string strWhere);

        #endregion

        #region ģ�����
        /// <summary>
        /// �ж�ģ���Ƿ����
        /// </summary>
        /// <param name="ModuleName">ģ������</param>
        /// <returns></returns>
        bool ModuleExists(string ModuleTag);

        /// <summary>
        /// ����ʱ�ж�ģ���Ƿ����
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <param name="ModuleName">ģ������</param>
        /// <returns></returns>
        bool UpdateExists(int ModuleID, string ModuleTag);

        /// <summary>
        /// ����һ��ģ��
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        int CreateModule(RedGlovePermission.Model.RGP_Modules model);

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        int UpdateModule(RedGlovePermission.Model.RGP_Modules model);

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        bool DeleteModule(int ModuleID);

        /// <summary>
        /// �õ�һ��ģ��ʵ��
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        RedGlovePermission.Model.RGP_Modules GetModuleModel(int ModuleID);

        /// <summary>
        /// ���ģ�������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        DataSet GetModuleList(string strWhere);

        /// <summary>
        /// ��ȡģ��ID
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        int GetModuleID(string ModuleTag);

        /// <summary>
        /// ģ���Ƿ�ر�
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        bool IsModule(string ModuleTag);

        #endregion

        #region ģ����Ȩ

        /// <summary>
        /// ����ģ��Ȩ��
        /// </summary>
        /// <param name="list">Ȩ���б�</param>
        /// <returns></returns>
        bool CreateAuthorityList(ArrayList list);

        /// <summary>
        /// ����ģ��Ȩ��
        /// </summary>
        bool UpdateAuthorityList(ArrayList list);

        /// <summary>
        /// ɾ��ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        bool DeleteAuthority(int ModuleID);

        /// <summary>
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        DataSet GetAuthorityList(int ModuleID);

        /// <summary>
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        DataSet GetAuthorityNameList(int ModuleID);

        #endregion
    }
}

