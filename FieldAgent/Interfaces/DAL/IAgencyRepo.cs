using FieldAgent.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.CORE.Interfaces.DAL
{
    public interface IAgencyRepo
    {
        Response<Agency> Insert(Agency agency);
        Response Update(Agency agency);
        Response Delete(int agencyId);
        Response<Agency> Get(int agencyId);
        Response<List<Agency>> GetAll();
    }
}
