using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SITA_MultiProject16.Entities
{
    /// <summary>
    /// Response Entity for Service Endpoint
    /// </summary>
    public class SaveResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}
