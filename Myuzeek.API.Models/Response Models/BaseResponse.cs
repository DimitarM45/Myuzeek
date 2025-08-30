namespace Myuzeek.API.Models.Response_Models;

public class BaseResponse<T>
{
    public bool Success { get; set; }

    public string StatusCode { get; set; }

    public T Body { get; set; }
}
