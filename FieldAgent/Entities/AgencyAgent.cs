using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.CORE.Entities
{
    public class AgencyAgent
    {
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public int AgencyId { get; set; }
        public Agency Agency { get; set; }
        public Guid BadgeId { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }
        public bool IsActive { get; set; }
        public int SecurityClearanceId { get; set; }
        public SecurityClearance SecurityClearance { get; set; }
    }
}
