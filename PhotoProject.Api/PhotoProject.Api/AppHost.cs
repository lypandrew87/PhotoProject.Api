using Funq;
using ServiceStack;
using PhotoProject.Api.ServiceDefinition;
using PhotoProject.Api.ServiceDefinition;
using ServiceStack.Api.Swagger;

namespace PhotoProject.Api
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("PhotoProject.Api", typeof(PhotoService).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            ContainerManager.Register(container);
            InitializePlugins(container);
        }
        public void InitializePlugins(Container container)
        {
            this.Plugins.Add(new CorsFeature());
            this.Plugins.Add(new SwaggerFeature());
        }
    }
}