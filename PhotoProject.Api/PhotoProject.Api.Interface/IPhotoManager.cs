using System.Collections.Generic;

namespace PhotoProject.Api.Interface
{
    public interface IPhotoManager
    {
        List<string> GetPhotoUrls(string category);
    }
}
