using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreetLight.Models
{
    public class ResultModel
    {
        public enum ResultCodeType
        {
            Success = 200,
            Error = 400
        }

        public ResultCodeType Status { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public static ResultModel BuildSuccess(object result)
        {
            ResultModel resultModel = new ResultModel();
            resultModel.Status = ResultCodeType.Success;
            resultModel.Result = result;
            return resultModel;
        }

        public static ResultModel BuildError(string message)
        {
            ResultModel resultModel = new ResultModel();
            resultModel.Status = ResultCodeType.Error;
            resultModel.Message = message;
            return resultModel;
        }
    }
}