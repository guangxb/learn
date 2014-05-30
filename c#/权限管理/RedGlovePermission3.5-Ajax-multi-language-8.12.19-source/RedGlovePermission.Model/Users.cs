using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����Users ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class Users
	{
		public Users()
		{}
		#region Model
		private int _userid;
		private string _username;
		private string _password;
		private string _question;
		private string _answer;
		private int _roleid;
		private int _usergroup;
		private DateTime _createtime;
		private DateTime _lastlogintime;
		private int _status;
		private bool _isonline;
		private bool _islimit;
		/// <summary>
		/// �û�ID
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// ��¼�����û�Email
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// �������������
		/// </summary>
		public string Question
		{
			set{ _question=value;}
			get{return _question;}
		}
		/// <summary>
		/// ��������Ĵ�
		/// </summary>
		public string Answer
		{
			set{ _answer=value;}
			get{return _answer;}
		}
		/// <summary>
		/// ��ɫ
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// �û���
		/// </summary>
		public int UserGroup
		{
			set{ _usergroup=value;}
			get{return _usergroup;}
		}
		/// <summary>
		/// �ʻ�����ʱ��
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// ��һ�ε�¼��ʱ��
		/// </summary>
		public DateTime LastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// �û�״̬
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// �Ƿ�����
		/// </summary>
		public bool IsOnline
		{
			set{ _isonline=value;}
			get{return _isonline;}
		}
		/// <summary>
		/// �Ƿ���Ȩ�����ƣ�0Ϊ������
		/// </summary>
		public bool IsLimit
		{
			set{ _islimit=value;}
			get{return _islimit;}
		}
		#endregion Model

	}
}

