using FieldAgent.CORE.Entities;
using FieldAgent.DAL;
using FieldAgent.DAL.EF;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;

namespace UnitTest
{
    public class Tests
    {
        AgentRepo db;
        DBFactory dbf;
        Agent Sterling = new Agent()
        {
            AgentId = 8,
            FirstName = "Casar",
            LastName = "Milliere",
            Height = 71,
            DateOfBirth = new DateTime(09/19/1997),
            
        };
        [SetUp]
        public void Setup()
        {
            ConfigProvider cp = new ConfigProvider();
            dbf = new DBFactory(cp.Config, FactoryMode.TEST);
            db = new AgentRepo(dbf);
            dbf.GetDbContext().Database.ExecuteSqlRaw("SetKnownGoodStateAgent");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(Casar.FirstName, db.Get(8).Data.FirstName);
        }
    }
}