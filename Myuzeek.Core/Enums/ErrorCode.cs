namespace Myuzeek.Core.Enums;

public enum ErrorCode
{
    OK = 0,
    DefaultError = 1,
    UserAlreadyExists = 2,
    UserNotFound = 3,
    UserCouldNotBeSignedIn = 4,
}

public static class ErrorMessages
{
    public static Dictionary<ErrorCode, string> Messages { get; } = new()
    {
        [ErrorCode.OK] = "SUCCESS",
        [ErrorCode.DefaultError] = "ERROR: INTERNAL SERVER ERROR",
        [ErrorCode.UserAlreadyExists] = "ERROR: A USER WITH THIS EMAIL ALREADY EXISTS",
        [ErrorCode.UserNotFound] = "ERROR: NO USER WITH GIVEN CREDENTIALS EXISTS",
        [ErrorCode.UserCouldNotBeSignedIn] = "ERROR: USER COULD NOT BE SIGNED IN"
    };
}
