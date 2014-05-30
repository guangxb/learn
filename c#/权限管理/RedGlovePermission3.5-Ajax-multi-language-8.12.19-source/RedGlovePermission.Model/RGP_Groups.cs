using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_Groups ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_Groups
	{
		public RGP_Groups()
		{}
		#region Model
		private int _groupid;
		private string _groupname;
		private int _grouporder;
		private string _groupdescription;
		/// <summary>
		/// ����ID
		/// </summary>
		public int GroupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// ������
		/// </summary>
		public string GroupName
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int GroupOrder
		{
			set{ _grouporder=value;}
			get{return _grouporder;}
		}
		/// <summary>
		/// ˵��
		/// </summary>
		public string GroupDescription
		{
			set{ _groupdescription=value;}
			get{return _groupdescription;}
		}
		#endregion Model

	}
}

