using ServiceStack;
using PhotoProject.Api.ServiceModel;
using PhotoProject.Api.Interface;
using PhotoProject.Api.ServiceModel.Types;

namespace PhotoProject.Api.ServiceDefinition
{
    public class PhotoService : Service
    {
        IPhotoManager _photoManager; 
        public PhotoService(IPhotoManager photoManager) {
            _photoManager = photoManager; 
        }

        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }

        public GetPhotoUrlsResponse Get(GetPhotoUrl request)
        {
            _photoManager.GetPhotoUrls(request.Category);
            return null; 
        }

    }
}