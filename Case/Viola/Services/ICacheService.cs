namespace RookieWorkshop.Services
{
    public interface ICacheService
    {
        string GetData(int input);

        void SetData(int input, string value);
    }
}