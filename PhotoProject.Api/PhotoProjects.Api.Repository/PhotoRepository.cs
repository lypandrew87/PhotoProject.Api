using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PhotoProject.Api.Interface;
using PhotoProject.Api.ServiceModel.Types;
using System.Configuration;

namespace PhotoProject.Api.Repository
{
    public class PhotoRepository : IPhotoRepository
    {

        public List<PhotoUrl> GetPhotoUrls(string category)
        {
            List<PhotoUrl> photoUrls = new List<PhotoUrl>();
            string connectionString = ConfigurationManager.ConnectionStrings["PhotoProject"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(
                             "[dbo].[GetUrlsByCategory]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("Category", category));
                    connection.Open();
                    SqlDataReader result = command.ExecuteReader();
                    while (result.Read())
                    {
                        photoUrls.Add(new PhotoUrl
                        {
                            Url = result.GetString(result.GetOrdinal("Url")),
                            Catogory = result.GetString(result.GetOrdinal("Category"))
                        });
                    }
                }
            }
            return photoUrls; 
        }
    }
}
