﻿using Core.Common.Contracts;
using Planilla.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planilla.Data.Contracts
{
    public interface IFondoPensionesRepository : IDataRepository<FondoPensiones>
    {
        FondoPensiones AddFondoPensionesComplete(FondoPensiones entity);
    }
}
