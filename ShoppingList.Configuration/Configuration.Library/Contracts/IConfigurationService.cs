using Configuration.Library.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Library.Contracts
{
    public interface IConfigurationService
    {
        ApiUrlsResponseDto GetApiUrls();
    }
}
