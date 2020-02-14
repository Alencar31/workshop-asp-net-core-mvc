﻿using SalesWebMvc2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2017.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc2017Context _context;

        public SellerService(SalesWebMvc2017Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
