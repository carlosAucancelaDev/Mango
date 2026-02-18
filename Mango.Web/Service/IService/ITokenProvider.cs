namespace Mango.Web.Service.IService
{
    public interface ITokenProvider
    {
        void SetToken(string token);
        string? Gettoken();
        void ClearToken();
    }
}
