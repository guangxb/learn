using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_ModuleType ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_ModuleType
	{
		public RGP_ModuleType()
		{}
		#region Model
		private int _moduletypeid;
		private string _moduletypename;
		private int _moduletypeorder;
		private string _moduletypedescription;
		/// <summary>
		/// ģ������ID
		/// </summary>
		public int ModuleTypeID
		{
			set{ _moduletypeid=value;}
			get{return _moduletypeid;}
		}
		/// <summary>
		/// ģ����������
		/// </summary>
		public string ModuleTypeName
		{
			set{ _moduletypename=value;}
			get{return _moduletypename;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int ModuleTypeOrder
		{
			set{ _moduletypeorder=value;}
			get{return _moduletypeorder;}
		}
		/// <summary>
		/// ˵��
		/// </summary>
		public string ModuleTypeDescription
		{
			set{ _moduletypedescription=value;}
			get{return _moduletypedescription;}
		}
		#endregion Model

	}
}

