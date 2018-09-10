using Configuration.Infrastructure.Contracts;
using Configuration.Library.Contracts;
using Configuration.Library.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Library.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _configurationRepository;

        public ConfigurationService(IConfigurationRepository configurationRepository)
        {
            _configurationRepository = configurationRepository;
        }

        public ApiUrlsResponseDto GetApiUrls()
        {
            var apiUrls = _configurationRepository.GetApiUrls();
            return new ApiUrlsResponseDto(apiUrls);
        }
    }
}
