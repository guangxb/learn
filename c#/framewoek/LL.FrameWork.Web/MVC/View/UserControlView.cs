﻿using System;
using System.Globalization;
using System.IO;

using LL.FrameWork.Core.Infrastructure.IOC;

namespace LL.FrameWork.Web.MVC
{
    /// <summary>
    /// 用户控件视图
    /// </summary>
    public class UserControlView : DynamicView
    {
        public UserControlView(ControllerContext controllerContext, string viewPath)
            : this(controllerContext, viewPath, null)
        { }
        public UserControlView(ControllerContext controllerContext, string viewPath, IViewPageActivator viewPageActivator)
            : this(controllerContext, viewPath, viewPageActivator, null)
        { }
        public UserControlView(ControllerContext controllerContext, string viewPath, IViewPageActivator viewPageActivator, IDependencyResolver dependencyResolver)
            : base(controllerContext, viewPath, viewPageActivator, dependencyResolver)
        { }

        protected override void RenderView(ViewContext viewContext, TextWriter writer, object instance)
        {
            ViewUserControl viewUserControl = instance as ViewUserControl;
            if (viewUserControl != null)
            {
                this.RenderViewUserControl(viewContext, viewUserControl);
            }
            else
            {
                throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "视图:{0}必须派生于ViewUserControl, ViewUserControl<TModel>", new object[]
			    {
				    base.ViewPath
			    }));
            }
        }

        private void RenderViewUserControl(ViewContext context, ViewUserControl control)
        {
            control.ViewContext = context;
            control.RenderView(context);
        }
    }
}