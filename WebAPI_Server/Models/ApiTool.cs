using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace WebAPI_Server.Models
{
    public static class ApiTool
    {
        public enum Method
        {
            GET,
            POST,
        }

        public static JsonResponse Result(bool success, string message, object data = null, ModelStateDictionary modelState = null)
        {
            if (modelState != null)
            {
                if (!string.IsNullOrWhiteSpace(message))
                    message += " ";

                message += string.Join("", modelState.SelectMany(sm => sm.Value.Errors.Select(s => s.ErrorMessage)));
            }

            return new JsonResponse
            {
                Success = success,
                Message = message,
                Payload = data
            };
        }
    }

    public class JsonResponse
    {
        /// <summary>
        /// 執行結果
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 執行回應訊息(success message or exception message)
        /// </summary>
        public string Message { get; set; }

        public object Payload { get; set; }
    }

    public class ApiError
    {
        public int StatusCode { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
}