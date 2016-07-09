﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.company.sales.domain.generic
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
