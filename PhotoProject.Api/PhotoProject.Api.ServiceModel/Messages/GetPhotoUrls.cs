using PhotoProject.Api.ServiceModel.Messages;
using PhotoProject.Api.ServiceModel.Types;
using ServiceStack;

namespace PhotoProject.Api.ServiceModel
{
    [Route(Routes.GetPhotoUrls, "GET")]
    public class GetPhotoUrl : IReturn<GetPhotoUrlsResponse>
    {
        public string Category { get; set; }
    }
}
