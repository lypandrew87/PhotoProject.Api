using System.Collections.Generic;
using PhotoProject.Api.Interface;
using PhotoProject.Api.ServiceModel.Types;

namespace PhotoProject.Api.Manager
{
    public class PhotoManager : IPhotoManager
    {
        IPhotoRepository _photoRepository; 
        public PhotoManager(IPhotoRepository photoRepository) {
            _photoRepository = photoRepository; 
        }

        public List<PhotoUrl> GetPhotoUrls(string category)
        {
            return  _photoRepository.GetPhotoUrls(category);
        }
    }
}
