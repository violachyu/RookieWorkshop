using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RookieWorkshop.DataAccess;

namespace RookieWorkshop.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _context;

        public DataRepository(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Data GetData(int Id)
        {
            return _context.Data.SingleOrDefault(a => a.Data_Id == Id);
        }

        public void AddData(Data data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            _context.Data.Add(data);

            Save();
        }
        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
