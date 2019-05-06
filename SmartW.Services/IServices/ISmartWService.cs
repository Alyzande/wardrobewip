using SmartW.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartW.Services.IServices
{
    public interface ISmartWService
    {
        IList<GarmentWear> GetGarmentWear(string Garment);

        IList<Data.Wears> GetUserGarment(int id);
    }
}
