using Myuzeek.Core.Enums;

namespace Myuzeek.Core.Response_Models;

public class BaseResponseModel<TResult> where TResult : class
{
    public BaseResponseModel()
    {
        Success = true;
        ResultCode = 0;
        ResultMessage = ErrorMessages.Messages[ResultCode];
        ResultObject = null;
    }

    public BaseResponseModel(bool success, ErrorCode resultCode, string? resultMessage = null, TResult? resultObject = null)
    {
        Success = success;
        ResultCode = resultCode;
        ResultMessage = resultMessage ?? ErrorMessages.Messages[ResultCode];
        ResultObject = resultObject;
    }

    public bool Success { get; set; }

    public ErrorCode ResultCode { get; set; }

    public string ResultMessage { get; set; }

    public TResult? ResultObject { get; set; }
}
