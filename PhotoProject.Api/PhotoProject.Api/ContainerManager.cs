using Funq;
using PhotoProject.Api.Interface;
using PhotoProject.Api.Manager;
using ServiceStack.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoProject.Api
{
    public class ContainerManager
    {
        public static void Register(Container container)
        {
            #region Managers
            container.RegisterAutoWiredAs<PhotoManager, IPhotoManager>();
            #endregion

            #region Repositories

            #endregion
        }
    }
}