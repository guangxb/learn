using System;
using System.Data;

namespace RedGlovePermission.IDAL
{
    public interface IRGP_AuthorityDir
	{		
        /// <summary>
        /// �ж�Ȩ�ޱ�ʶ�����
        /// </summary>
        /// <param name="AuthorityTag">Ȩ�ޱ�ʶ</param>
        /// <returns></returns>
        bool Exists(string AuthorityTag);

        /// <summary>
        /// ����һ��Ȩ��
        /// </summary>
        /// <param name="model">Ȩ��ʵ����</param>
        /// <returns></returns>
        bool CreateAuthority(RedGlovePermission.Model.RGP_AuthorityDir model);

        /// <summary>
        /// ����ָ����Ȩ��
        /// </summary>
        /// <param name="model">Ȩ��ʵ����</param>
        /// <returns></returns>
        bool UpdateAuthority(RedGlovePermission.Model.RGP_AuthorityDir model);

        /// <summary>
        /// ɾ��һ��Ȩ��
        /// </summary>
        /// <param name="AuthorityID">Ȩ��ID</param>
        /// <returns></returns>
        bool DeleteAuthority(int AuthorityID);

        /// <summary>
        /// �õ�һ��Ȩ��ʵ��
        /// </summary>
        /// <param name="AuthorityID">Ȩ��ID</param>
        /// <returns></returns>
        RedGlovePermission.Model.RGP_AuthorityDir GetAuthorityModel(int AuthorityID);

        /// <summary>
        /// ���Ȩ�������б�
        /// </summary>
        /// <param name="strWhere">Where����</param>
        /// <param name="strOrder">��������</param>
        /// <returns></returns>
        DataSet GetAuthorityList(string strWhere, string strOrder);
	}
}

