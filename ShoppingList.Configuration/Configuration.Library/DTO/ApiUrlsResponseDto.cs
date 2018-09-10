using Configuration.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Library.DTO
{
    public class ApiUrlsResponseDto
    {
        public ApiUrlsResponseDto(){ }

        public ApiUrlsResponseDto(ApiUrlsEntityDto apiUrlsEntityDto)
        {
            UrlName = apiUrlsEntityDto.UrlName;
            EndPoint = apiUrlsEntityDto.EndPoint;
        }

        public string UrlName { get; set; }
        public string EndPoint { get; set; }
    }
}
