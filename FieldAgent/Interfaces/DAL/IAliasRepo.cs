using FieldAgent.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.CORE.Interfaces.DAL
{
    public interface IAliasRepo
    {
        Response<Alias> Insert(Alias alias);
        Response Update(Alias alias);
        Response Delete(int aliasId);
        Response<Alias> Get(int aliasId);
        Response<List<Alias>> GetByAgent(int agentId);
    }
}
