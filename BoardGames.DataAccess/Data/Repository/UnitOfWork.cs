﻿using BoardGames.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGames.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        //public ICategoryRepository Category { get; private set; }

        //Grabs a connection to the actual db to connect to this class
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            //Category = new CategoryRepository(_db);
        }



        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
