using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RookieWorkshop.DataAccess;
using RookieWorkshop.Entities;

namespace RookieWorkshop.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;

        public DataRepository(
            DataContext context,
            IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            this._mapper = mapper;
        }

        public DataEntity GetData(int Id)
        {
            var rawData = _context.Data.SingleOrDefault(a => a.Data_Id == Id);
            var result = this._mapper.Map<DataEntity>(rawData);

            return result;
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
