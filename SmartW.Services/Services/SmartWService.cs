using SmartW.Data;
using SmartW.Data.DAO;
using SmartW.Data.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartW.Services.Services
{
    public class SmartWService :
        SmartW.Services.IServices.ISmartWService
    {
        private ISmartWDAO _SmartDAO;
        public SmartWService()
        {
            _SmartDAO = new SmartWDAO(); 
        }


        public IList<Data.Garment> GetGarment()  //???
        {
            return _SmartDAO.GetGarment();  //????
        }

        public IList<GarmentWear> GetGarmentWear(string Garment)
        {
            throw new NotImplementedException();
        }

        public IList<Data.Wears> GetUserGarment(int id)
        {
            return _SmartDAO.GetUserGarment(id);
        }
    }
}
