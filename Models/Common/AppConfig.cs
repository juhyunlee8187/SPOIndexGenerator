using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithSPODocuments.Models
{
    public class AppConfig
    {
        public string ClientId { get; set; } = string.Empty;
        public string TenantId { get; set; } = string.Empty;
        public string GraphScope { get; set; } = string.Empty;
        public string SiteId { get; set; } = string.Empty;
        public string DriveId { get; set; } = string.Empty;
        public string ACSSearchIndex { get; set; } = string.Empty;
        public string ACSSearchEndpoint { get; set; } = string.Empty;
        public string ACSSearchKey { get; set; } = string.Empty;
    }
}
