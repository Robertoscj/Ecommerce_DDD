﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceGenericApp<T> where T : class
    {
        Task add(T Objeto);

        Task Update(T Objeto);

        Task Delete(T Objeto);

        Task<T> GetEntityById(int Id);

        Task<List<T>> List();
    }
}
