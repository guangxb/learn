using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_UserAuthorityList ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_RoleAuthorityList
	{
		public RGP_RoleAuthorityList()
		{}

		private int _id;
        private int _userid;
		private int _roleid;
		private int _moduleid;
		private string _authoritytag;
        private bool _flag;
		/// <summary>
		/// ���
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
        /// <summary>
        /// �û�ID
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
		/// <summary>
		/// ��ɫID
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// ģ��ID
		/// </summary>
		public int ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// Ȩ�ޱ�ʶ
		/// </summary>
		public string AuthorityTag
		{
			set{ _authoritytag=value;}
			get{return _authoritytag;}
		}
        /// <summary>
        /// �ж��������Ƿ���������ڸ��û�������Ȩʱ���ж�
        /// 1Ϊ����0Ϊ����ֹ
        /// </summary>
        public bool Flag
        {
            set { _flag = value; }
            get { return _flag; }
        }

	}
}

