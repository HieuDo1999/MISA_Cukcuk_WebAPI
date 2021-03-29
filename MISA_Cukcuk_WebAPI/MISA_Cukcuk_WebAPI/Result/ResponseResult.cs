using MISA_Cukcuk_WebAPI.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA_Cukcuk_WebAPI.Result
{
    public class ResponseResult
    {
        public string DevMsg { get; set; }

        public string UserMsg { get; set; }

        public ErrorCode ErrorCode { get; set; } = ErrorCode.NONE;

        public string MoreInfo { get; set; }

        public  string TraceId { get; set; }

        public object Data { get; set; }

        public void OnException(ResponseResult result)
        {
            result.UserMsg = Resource.Message.ExceptionUser;
        }
    }
}
