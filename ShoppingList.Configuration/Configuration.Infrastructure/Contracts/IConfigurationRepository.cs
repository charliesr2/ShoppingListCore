using Configuration.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Infrastructure.Contracts
{
    public interface IConfigurationRepository
    {
        ApiUrlsEntityDto GetApiUrls();  
    }
}
