﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Caching
{
    public interface ICacheInfo
    {
        bool IsOutdated { get; }
    }
}
