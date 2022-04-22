using FieldAgent.CORE;
using FieldAgent.CORE.Entities;
using FieldAgent.CORE.Interfaces.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAgent.DAL.EF
{
    public class AgentRepo : IAgentRepo
    {

        public DBFactory DbFac { get; set; }

        public AgentRepo(DBFactory dbfac)
        {
            DbFac = dbfac;
        }
        
        
        public Response Delete(int agentId)
        {
            Response res = new Response();
            try
            {
                using (var db = DbFac.GetDbContext())
                {
                    var agent = db.Agent.Where(a => a.AgentId == agentId).FirstOrDefault();
                    if (agent != null)
                    {
                        db.Agent.Remove(agent);
                        db.SaveChanges();
                        res.Success = true;
                    }
                    else
                    {
                        res.Message = "Agent not found";
                        res.Success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }
            return res;

        }

        public Response<Agent> Get(int agentId)
        {
            using (var db = DbFac.GetDbContext())
            {
                Response<Agent> resp = new Response<Agent>();
                var agent = db.Agent.Find(agentId);
                if (agent == null)
                {
                    resp.Message = "Agent not found";
                    resp.Success = false;
                    return resp;
                }
        
                else 
                {
                    resp.Success = true;
                    resp.Data = agent;
                }
                return resp;
            }
        }

        public Response<List<Mission>> GetMissions(int agentId)
        {
            Response<List<Mission>> resp = new Response<List<Mission>>();
            using (var db = DbFac.GetDbContext())
            {
                var agent = db.Agent.Find(agentId);
                if (agent == null)
                {
                    resp.Message = "Agent not found";
                    resp.Success = false;
                    return resp;
                }
                else
                {
                    resp.Success = true;
                    resp.Data = agent.Missions.ToList();
                }
                return resp;
            }

        }

        public Response<Agent> Insert(Agent agent)
        {
            Response<Agent> resp = new Response<Agent>();
            using (var db = DbFac.GetDbContext())
            {
                db.Agent.Add(agent);
                db.SaveChanges();
                resp.Success = true;
                resp.Data = agent;
            }
            return resp;

        }

        //update is not done yet
        public Response Update(Agent agent)
        {
            Response resp = new Response();
            using (var db = DbFac.GetDbContext())
            {
                var agentToUpdate = db.Agent.Where(a => a.AgentId == agent.AgentId).FirstOrDefault();
                if (agentToUpdate == null)
                {
                    resp.Message = "Agent not found";
                    resp.Success = false;
                    return resp;
                }
                else
                {
                    agentToUpdate.AgentId = agent.AgentId;
                }
                return resp;
            }
        }
    }
}
