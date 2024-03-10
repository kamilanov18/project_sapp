namespace Models.DTOs.Auth
{
    public enum LoginResponseStatusEnum
    {
        Success,
        InvalidPassword,
        NoEmailFound,
        FirstTimeLogin
    }
}
