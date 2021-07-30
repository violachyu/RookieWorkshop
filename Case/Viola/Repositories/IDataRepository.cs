using RookieWorkshop.DataAccess;
using RookieWorkshop.Entities;

namespace RookieWorkshop.Repositories
{
    public interface IDataRepository
    {
        DataEntity GetData(int Id);

        void AddData(Data data);

        bool Save();
    }
}