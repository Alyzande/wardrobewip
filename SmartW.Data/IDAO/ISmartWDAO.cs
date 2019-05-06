using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartW.Data.IDAO
{
    public interface ISmartWDAO
    {
        //IList<SmartW.Data.Garment> GetGarment();

        IList<GarmentWear> GetGarmentWear(string Garment);

        IList<Garment> GetUserGarment(string id);

    }


}
