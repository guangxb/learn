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
	/// ҵ���߼���RGP_Modules ��ժҪ˵����
	/// </summary>
	public class RGP_Modules
	{
        private readonly IRGP_Modules dal = DataAccess.CreateRGP_Modules();

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
            return dal.ModuleTypeExists(ModuleTypeName);
        }

        /// <summary>
        /// ����һ��ģ�����
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        public int CreateModuleType(RedGlovePermission.Model.RGP_ModuleType model)
        {
            return dal.CreateModuleType(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ�����ʵ����</param>
        /// <returns></returns>
        public bool UpdateModuleType(RedGlovePermission.Model.RGP_ModuleType model)
        {
            return dal.UpdateModuleType(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        public int DeleteModuleType(int ModuleTypeID)
        {
            return dal.DeleteModuleType(ModuleTypeID);
        }

        /// <summary>
        /// �õ�һ��ģ�����ʵ��
        /// </summary>
        /// <param name="ModuleTypeID">ģ�����ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_ModuleType GetModuleTypeModel(int ModuleTypeID)
        {
            return dal.GetModuleTypeModel(ModuleTypeID);
        }

        /// <summary>
        /// ���ģ����������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetModuleTypeList(string strWhere)
        {
            return dal.GetModuleTypeList(strWhere);
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
            return dal.ModuleExists(ModuleTag);
        }

        /// <summary>
        /// ����ʱ�ж�ģ���Ƿ����
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <param name="ModuleName">ģ������</param>
        /// <returns></returns>
        public bool UpdateExists(int ModuleID, string ModuleTag)
        {
            return dal.UpdateExists(ModuleID, ModuleTag);
        }

        /// <summary>
        /// ����һ��ģ��
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        public int CreateModule(RedGlovePermission.Model.RGP_Modules model)
        {
            return dal.CreateModule(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">ģ��ʵ����</param>
        /// <returns></returns>
        public int UpdateModule(RedGlovePermission.Model.RGP_Modules model)
        {
            return dal.UpdateModule(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public bool DeleteModule(int ModuleID)
        {
            return dal.DeleteModule(ModuleID);
        }

        /// <summary>
        /// �õ�һ��ģ��ʵ��
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Modules GetModuleModel(int ModuleID)
        {
            return dal.GetModuleModel(ModuleID);
        }

        /// <summary>
        /// ���ģ�������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetModuleList(string strWhere)
        {
            return dal.GetModuleList(strWhere);
        }

        /// <summary>
        /// ��ȡģ��ID
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        public int GetModuleID(string ModuleTag)
        {
            return dal.GetModuleID(ModuleTag);
        }

        /// <summary>
        /// ģ���Ƿ�ر�
        /// </summary>
        /// <param name="ModuleTag">ģ���ʶ</param>
        /// <returns></returns>
        public bool IsModule(string ModuleTag)
        {
            return dal.IsModule(ModuleTag);
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
            return dal.CreateAuthorityList(list);
        }

        /// <summary>
        /// ����ģ��Ȩ��
        /// </summary>
        public bool UpdateAuthorityList(ArrayList list)
        {
            return dal.UpdateAuthorityList(list);
        }

        /// <summary>
        /// ɾ��ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public bool DeleteAuthority(int ModuleID)
        {
            return dal.DeleteAuthority(ModuleID);
        }

        /// <summary>
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public DataSet GetAuthorityList(int ModuleID)
        {
            return dal.GetAuthorityList(ModuleID);
        }

        /// <summary>
        /// ���ָ��ģ���Ȩ���б�
        /// </summary>
        /// <param name="ModuleID">ģ��ID</param>
        /// <returns></returns>
        public DataSet GetAuthorityNameList(int ModuleID)
        {
            return dal.GetAuthorityNameList(ModuleID);
        }

        #endregion
    }
}

