using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_AuthorityDir ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_AuthorityDir
	{
		public RGP_AuthorityDir()
		{}
		#region Model
		private int _authorityid;
		private string _authorityname;
		private string _authoritytag;
		private string _authoritydescription;
		private int _authorityorder;
		/// <summary>
		/// Ȩ��ID
		/// </summary>
		public int AuthorityID
		{
			set{ _authorityid=value;}
			get{return _authorityid;}
		}
		/// <summary>
		/// Ȩ������
		/// </summary>
		public string AuthorityName
		{
			set{ _authorityname=value;}
			get{return _authorityname;}
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
		/// ˵��
		/// </summary>
		public string AuthorityDescription
		{
			set{ _authoritydescription=value;}
			get{return _authoritydescription;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int AuthorityOrder
		{
			set{ _authorityorder=value;}
			get{return _authorityorder;}
		}
		#endregion Model

	}
}

