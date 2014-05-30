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
	/// ҵ���߼���Users ��ժҪ˵����
	/// </summary>
	public class Users
	{
        private readonly IUsers dal = DataAccess.CreateUsers();
		public Users()
		{}

        /// <summary>
        /// �û��Ƿ����
        /// </summary>
        public bool UserExists(string UserName)
        {
            return dal.UserExists(UserName);
        }

        /// <summary>
        /// ����һ�����û�
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int CreateUser(RedGlovePermission.Model.Users model)
        {
            return dal.CreateUser(model);
        }

        /// <summary>
        /// �û���¼���
        /// </summary>
        public bool CheckLogin(string UserName,string pwd)
        {
            return dal.CheckLogin(UserName, pwd);
        }

        /// <summary>
        /// �����û���¼ʱ��
        /// </summary>
        /// <param name="id"></param>
        public void UpdateLoginTime(int id)
        {
            dal.UpdateLoginTime(id);
        }

        /// <summary>
        /// �ж��û�ԭ�����Ƿ���ȷ
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="pwd">ԭ����</param>
        /// <returns></returns>
        public bool VerifyPassword(int id, string pwd)
        {
            return dal.VerifyPassword(id, pwd);
        }

        /// <summary>
        /// �����û�����
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="pwd">������</param>
        /// <returns></returns>
        public bool ChangePassword(int id, string pwd)
        {
            return dal.ChangePassword(id, pwd);
        }

        /// <summary>
        /// ���°�ȫ��Ϣ
        /// </summary>
        /// <param name="id">�û�ID</param>
        /// <param name="question">����</param>
        /// <param name="answer">��</param>
        /// <returns></returns>
        public bool ChangeSecureInfo(int id, string question, string answer)
        {
            return dal.ChangeSecureInfo(id, question, answer);
        }

        /// <summary>
        /// ɾ���û�
        /// </summary>
        /// <param name="UserID">�û�ID</param>
        public bool DeleteUser(int UserID)
        {
            return dal.DeleteUser(UserID);
        }

        /// <summary>
        /// ����ID�õ��û�����ʵ��
        /// </summary>
        public RedGlovePermission.Model.Users GetUserModel(int UserID)
        {
            return dal.GetUserModel(UserID);
        }

        /// <summary>
        /// �����û����õ��û�����ʵ��
        /// </summary>
        public RedGlovePermission.Model.Users GetUserModel(string UserName)
        {
            return dal.GetUserModel(UserName);
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetUserList(string strWhere,string strOrder)
        {
            return dal.GetUserList(strWhere,strOrder);
        }
	}
}

