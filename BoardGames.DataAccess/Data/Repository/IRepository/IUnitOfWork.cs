﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BoardGames.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        //ICategoryRepository Category { get; }

        void Save();
    }
}
