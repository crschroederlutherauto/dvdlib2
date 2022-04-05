using DvdLibrary.Interfaces;
using DvdLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibrary.Repository
{
    public class MockDVDRepository : IDVDRepository
    {
        private static List<Dvd> _dvds = new List<Dvd>();

        public int Create(Dvd dvd)
        {
            throw new NotImplementedException();
        }

        public void Delete(int dvdID)
        {
            throw new NotImplementedException();
        }

        public List<Dvd> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dvd GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Dvd dvd)
        {
            throw new NotImplementedException();
        }
    }
}