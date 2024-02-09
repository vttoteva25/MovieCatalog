using MC.ApplicationServices.Messaging;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MC.ApplicationServices
{
    public class ResponseServiceBase
    {
        public BusinessStatusCodeEnum StatusCode { get; set; }
    }
}
