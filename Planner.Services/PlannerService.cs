using Microsoft.EntityFrameworkCore;
using Planner.Services.Interfaces;
using PlannerApp.Dal;
using PlannerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace Planner.Services
{
    public class PlannerService : IPlansInterface
    {

        private readonly IConfiguration _configuration;

        #region Property
        private readonly PlannerDBContext db;
        #endregion

        #region Constructor
        public PlannerService(PlannerDBContext plannerDBContext,IConfiguration config)
        {
            db = plannerDBContext;
            _configuration = config;
        }
        #endregion

        public async Task<List<Plans>> GetAllPlans()
        {
            return await db.Plans.ToListAsync();
        }


    }
}
