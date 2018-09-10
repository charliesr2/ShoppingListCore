using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Infrastructure.Entities
{
    public class ConfigurationEntity
    {
        public int ID { get; set; }
        public string Key{ get; set; }
        public string Value { get; set; }
        public string ValueType { get; set; }
    }
}
