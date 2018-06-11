using Funq;
using PhotoProject.Api.Interface;
using PhotoProject.Api.Manager;
using PhotoProject.Api.Repository;

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
            container.RegisterAutoWiredAs<PhotoRepository, IPhotoRepository>(); 
            #endregion
        }
    }
}