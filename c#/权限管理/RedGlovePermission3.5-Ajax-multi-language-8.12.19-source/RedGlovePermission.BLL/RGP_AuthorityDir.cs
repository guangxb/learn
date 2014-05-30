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
	/// ҵ���߼���RGP_AuthorityDir ��ժҪ˵����
	/// </summary>
	public class RGP_AuthorityDir
	{
        private readonly IRGP_AuthorityDir dal = DataAccess.CreateRGP_AuthorityDir();

		public RGP_AuthorityDir()
		{}

        /// <summary>
        /// �ж�Ȩ�ޱ�ʶ�����
        /// </summary>
        /// <param name="AuthorityTag">Ȩ�ޱ�ʶ</param>
        /// <returns></returns>
        public bool Exists(string AuthorityTag)
        {
            return dal.Exists(AuthorityTag);
        }

        /// <summary>
        /// ����һ��Ȩ��
        /// </summary>
        /// <param name="model">Ȩ��ʵ����</param>
        /// <returns></returns>
        public bool CreateAuthority(RedGlovePermission.Model.RGP_AuthorityDir model)
        {
            return dal.CreateAuthority(model);
        }

        /// <summary>
        /// ����ָ����Ȩ��
        /// </summary>
        /// <param name="model">Ȩ��ʵ����</param>
        /// <returns></returns>
        public bool UpdateAuthority(RedGlovePermission.Model.RGP_AuthorityDir model)
        {
            return dal.UpdateAuthority(model);
        }

        /// <summary>
        /// ɾ��һ��Ȩ��
        /// </summary>
        /// <param name="AuthorityID">Ȩ��ID</param>
        /// <returns></returns>
        public bool DeleteAuthority(int AuthorityID)
        {
            return dal.DeleteAuthority(AuthorityID);
        }

        /// <summary>
        /// �õ�һ��Ȩ��ʵ��
        /// </summary>
        /// <param name="AuthorityID">Ȩ��ID</param>
        /// <returns></returns>
        public RedGlovePermission.Model.RGP_AuthorityDir GetAuthorityModel(int AuthorityID)
        {
            return dal.GetAuthorityModel(AuthorityID);
        }

        /// <summary>
        /// ���Ȩ�������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        public DataSet GetAuthorityList(string strWhere, string strOrder)
        {
            return dal.GetAuthorityList(strWhere, strOrder);
        }
	}
}

