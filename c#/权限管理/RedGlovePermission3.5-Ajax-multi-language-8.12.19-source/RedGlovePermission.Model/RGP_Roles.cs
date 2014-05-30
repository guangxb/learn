using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_Roles ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_Roles
	{
		public RGP_Roles()
		{}
		#region Model
		private int _roleid;
		private int _rolegroupid;
		private string _rolename;
		private string _roledescription;
		/// <summary>
		/// ��ɫID
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// ����ID
		/// </summary>
		public int RoleGroupID
		{
			set{ _rolegroupid=value;}
			get{return _rolegroupid;}
		}
		/// <summary>
		/// ��ɫ����
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// ˵��
		/// </summary>
		public string RoleDescription
		{
			set{ _roledescription=value;}
			get{return _roledescription;}
		}
		#endregion Model

	}
}

