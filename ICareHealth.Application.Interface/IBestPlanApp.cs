﻿using ICareHealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICareHealth.Application.Interface
{
    public interface IBestPlanApp
    {
        User GetMyBestPlan(User user);
    }
}
