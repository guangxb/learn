using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_ModuleAuthorityList ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_ModuleAuthorityList
	{
		public RGP_ModuleAuthorityList()
		{}
		#region Model
		private int _id;
		private int _moduleid;
		private string _authoritytag;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		#endregion Model

	}
}

