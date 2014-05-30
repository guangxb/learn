using System;
using System.Data;
using System.Collections.Generic;

using RedGlovePermission.Lib;
using RedGlovePermission.Model;
using RedGlovePermission.DALFactory;
using RedGlovePermission.IDAL;

namespace RedGlovePermission.BLL
{
	/// <summary>
	/// ҵ���߼���RGP_Groups ��ժҪ˵����
	/// </summary>
	public class RGP_Groups
	{
        private readonly IRGP_Groups dal = DataAccess.CreateRGP_Groups();

		public RGP_Groups()
		{}

        /// <summary>
        /// �жϷ����Ƿ����
        /// </summary>
        /// <param name="GroupName">��������</param>
        /// <returns></returns>
        public bool Exists(string GroupName)
        {
            return dal.Exists(GroupName);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        public bool CreateGroup(RedGlovePermission.Model.RGP_Groups model)
        {
            return dal.CreateGroup(model);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        /// <param name="model">����ʵ����</param>
        /// <returns></returns>
        public bool UpdateGroup(RedGlovePermission.Model.RGP_Groups model)
        {
            return dal.UpdateGroup(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        public int DeleteGroup(int GroupID)
        {
            return dal.DeleteGroup(GroupID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        /// <param name="GroupID">����ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_Groups GetGroupModel(int GroupID)
        {
            return dal.GetGroupModel(GroupID);
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetGroupList(string strWhere, string strOrder)
        {
            return dal.GetGroupList(strWhere, strOrder);
        }
    }
}

