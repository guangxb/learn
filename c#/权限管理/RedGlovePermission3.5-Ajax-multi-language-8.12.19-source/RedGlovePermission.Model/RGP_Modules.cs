using System;
namespace RedGlovePermission.Model
{
	/// <summary>
	/// ʵ����RGP_Modules ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class RGP_Modules
	{
		public RGP_Modules()
		{}
		#region Model
		private int _moduleid;
		private int _moduletypeid;
		private string _modulename;
		private string _moduletag;
		private string _moduleurl;
		private bool _moduledisabled;
		private int _moduleorder;
		private string _moduledescription;
        private bool _ismenu;
		/// <summary>
		/// ģ��ID
		/// </summary>
		public int ModuleID
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		/// <summary>
		/// ģ������
		/// </summary>
		public int ModuleTypeID
		{
			set{ _moduletypeid=value;}
			get{return _moduletypeid;}
		}
		/// <summary>
		/// ģ������
		/// </summary>
		public string ModuleName
		{
			set{ _modulename=value;}
			get{return _modulename;}
		}
		/// <summary>
		/// ģ���ʶ
		/// </summary>
		public string ModuleTag
		{
			set{ _moduletag=value;}
			get{return _moduletag;}
		}
		/// <summary>
		/// ģ���ַ
		/// </summary>
		public string ModuleURL
		{
			set{ _moduleurl=value;}
			get{return _moduleurl;}
		}
		/// <summary>
		/// �Ƿ����
		/// </summary>
		public bool ModuleDisabled
		{
			set{ _moduledisabled=value;}
			get{return _moduledisabled;}
		}
		/// <summary>
		/// ����
		/// </summary>
		public int ModuleOrder
		{
			set{ _moduleorder=value;}
			get{return _moduleorder;}
		}
		/// <summary>
		/// ˵��
		/// </summary>
		public string ModuleDescription
		{
			set{ _moduledescription=value;}
			get{return _moduledescription;}
		}
        /// <summary>
        /// �Ƿ���ʾ�ڵ����˵���
        /// </summary>
        public bool IsMenu
        {
            set { _ismenu = value; }
            get { return _ismenu; }
        }
		#endregion Model

	}
}

