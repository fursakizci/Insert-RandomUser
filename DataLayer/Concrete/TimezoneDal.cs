﻿using DataLayer.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class TimezoneDal:GenericRepository<Timezone,DbUserContext>,ITimezoneDal
    {
    }
}
