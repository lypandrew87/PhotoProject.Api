using PhotoProject.Api.ServiceModel.Types;
using System.Collections.Generic;

namespace PhotoProject.Api.Interface
{
    public interface IPhotoRepository
    {
        List<PhotoUrl> GetPhotoUrls(string category);
    }
}
