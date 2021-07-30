using RookieWorkshop.DataAccess;

namespace RookieWorkshop.Repositories
{
    public interface IDataRepository
    {
        Data GetData(int Id);

        void AddData(Data data);

        bool Save();
    }
}