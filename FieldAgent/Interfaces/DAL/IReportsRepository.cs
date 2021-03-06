using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.CORE.DTOs
{
    public interface IReportsRepository
    {
        Response<List<TopAgentListItem>> GetTopAgents();
        Response<List<PensionListItem>> GetPensionList(int agencyId);
        Response<List<ClearanceAuditListItem>> AuditClearance(int securityClearanceId, int agencyId);
    }
}
