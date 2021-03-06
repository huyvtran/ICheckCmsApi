﻿using iCheckAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iCheckAPI.Repositories
{
    public class ConducteurRepo : IConducteurRepo
    {
        private readonly icheckcmsContext _context;
        public ConducteurRepo(icheckcmsContext context)
        {
            _context = context;
        }
        public Conducteur GetConducteurByCIN(string cin)
        {
            return _context.Conducteur.FirstOrDefault(x => x.Cin == cin);
        }

        public Conducteur GetConducteurByNumBadge(string numBadge)
        {
            return _context.Conducteur.FirstOrDefault(x => x.NumBadge == numBadge);
        }

        public async Task Create(Conducteur conducteur)
        {
            _context.Conducteur.Add(conducteur);
            await _context.SaveChangesAsync();
        }


    }

    public interface IConducteurRepo
    {
        Conducteur GetConducteurByCIN(string cin);
        Conducteur GetConducteurByNumBadge(string numBadge);


        Task Create(Conducteur conducteur);
    }
}
