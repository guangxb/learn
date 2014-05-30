using System;
using System.Data;

namespace RedGlovePermission.IDAL
{
	/// <summary>
	/// ҵ���߼���Users ��ժҪ˵����
	/// </summary>
	public interface IUsers
	{		
        /// <summary>
        /// �û��Ƿ����
        /// </summary>
        bool UserExists(string UserName);

        /// <summary>
        /// ����һ�����û�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int CreateUser(RedGlovePermission.Model.Users model);
        
        /// <summary>
        /// �û���¼���
        /// </summary>
        bool CheckLogin(string UserName,string pwd);

        /// <summary>
        /// �����û���¼ʱ��
        /// </summary>
        /// <param name="id"></param>
        void UpdateLoginTime(int id);

        /// <summary>
        /// �ж��û�ԭ�����Ƿ���ȷ
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="pwd">ԭ����</param>
        /// <returns></returns>
        bool VerifyPassword(int id, string pwd);
        
        /// <summary>
        /// �����û�����
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="pwd">������</param>
        /// <returns></returns>
        bool ChangePassword(int id, string pwd);
      
        /// <summary>
        /// ���°�ȫ��Ϣ
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="question">����</param>
        /// <param name="answer">��</param>
        /// <returns></returns>
        bool ChangeSecureInfo(int id, string question, string answer);      

        /// <summary>
        /// ɾ���û�
        /// </summary>
        /// <param name="UserID">�û�ID</param>
        bool DeleteUser(int UserID);
        
        /// <summary>
        /// ����ID�õ��û�����ʵ��
        /// </summary>
        RedGlovePermission.Model.Users GetUserModel(int UserID);
       
        /// <summary>
        /// �����û����õ��û�����ʵ��
        /// </summary>
        RedGlovePermission.Model.Users GetUserModel(string UserName);

        /// <summary>
        /// ��������б�
        /// </summary>
        DataSet GetUserList(string strWhere, string strOrder);
	}
}

