﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Creaxu.Shared
{
    public class ApiResponse<T> : ApiResponse
    {
        public T Data { get; set; }
    }
}
