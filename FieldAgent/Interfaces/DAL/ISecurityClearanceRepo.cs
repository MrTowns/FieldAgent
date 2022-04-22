using FieldAgent.CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.CORE.Interfaces.DAL
{
    public interface ISecurityClearanceRepo
    {
        Response<SecurityClearance> Get(int securityClearanceId);
        Response<List<SecurityClearance>> GetAll();
    }
}
