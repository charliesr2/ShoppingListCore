using Configuration.Infrastructure.Contracts;
using Configuration.Infrastructure.DAO.Contexts;
using Configuration.Infrastructure.DTO;
using Configuration.Infrastructure.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Configuration.Infrastructure
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        public ApiUrlsEntityDto GetApiUrls()
        {
            using (var context = new ConfigurationContext())
            {
                var result = context.Configurations
                    .FirstOrDefault(c => c.Key == "Urls")
                    .Value;

                return JsonConvert.DeserializeObject<ApiUrlsEntityDto>(result);
            }
        }
    }
}
