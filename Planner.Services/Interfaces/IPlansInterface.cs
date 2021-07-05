using PlannerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Services.Interfaces
{
    public interface IPlansInterface
    {

        Task<List<Plans>> GetAllPlans();

    }
}
