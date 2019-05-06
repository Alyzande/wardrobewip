using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartW.Data.DAO
{
    public class SmartWDAO : IDAO.ISmartWDAO
    {
        private b3012222Entities _context;
        public SmartWDAO()
        {
            _context = new b3012222Entities();
        }
            //{ _context = new b3012222Entities(); }

            public IList<GarmentWear> GetGarmentWear(string Garment) { 

            IQueryable<GarmentWear> _Garment;
            _Garment = from GarmentWear
                       in _context.GarmentWear
                       select GarmentWear;
            return _Garment.ToList<Data.GarmentWear>();
        }

        public IList<Data.Garment> GetGarment()
        {
            IQueryable<Data.Garment> _Garment;
            _Garment = from Garment
                       in _context.Garment
                       select Garment;
            return _Garment.ToList<Data.Garment>();
        }

        public IList<Data.Garment> GetUserGarment(string id)
        {
            IQueryable<Data.Garment> _Garment;
            _Garment = from Garment
                       in _context.Garment
                       where Garment.UserID==id
                       select Garment;
            return _Garment.ToList<Data.Garment>();
        }

    }

}
