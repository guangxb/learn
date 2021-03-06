﻿using System;
using LL.Framework.Core.Domain;

namespace LL.Framework.Permission.DomainModel
{

    /// <summary>
    /// 职位
    /// </summary>
    public class Post : EntityBase<string>
    {

        /// <summary>
        /// 职位构造函数
        /// </summary>
        public Post()
        {
            ///Todo
        }
        
        private string m_Name;

        /// <summary>
        /// 岗位名称
        /// </summary>
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }


        private string m_Code;

        /// <summary>
        /// 岗位编码
        /// </summary>
        public string Code
        {
            get { return m_Code; }
            set { m_Code = value; }
        }


        private string m_Reamrk;

        /// <summary>
        /// 备注
        /// </summary>
        public string Reamrk
        {
            get { return m_Reamrk; }
            set { m_Reamrk = value; }
        }

    }

}

