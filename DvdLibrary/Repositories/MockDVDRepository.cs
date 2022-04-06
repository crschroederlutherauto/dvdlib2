using DvdLibrary.Interfaces;
using DvdLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibrary.Repositories
{
    public class MockDVDRepository : IDVDRepository
    {
        private static List<Dvd> _dvds = new List<Dvd>() { new Dvd() { DvdID=1, Director="George Lucas", ReleaseYear="1977", Title="Star Wars", Notes="", Rating="PG"} };
        public static int IDindex = 2;

        public int Create(Dvd dvd)
        {
            dvd.DvdID = IDindex;
            IDindex++;
            _dvds.Add(dvd);
            return dvd.DvdID;
        }

        public List<Dvd> GetByTitle(string searchTerm)
        {
            return _dvds.Where(d => d.Title.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        public List<Dvd> GetByReleaseYear(string searchTerm)
        {
            return _dvds.Where(d => d.ReleaseYear.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        public List<Dvd> GetByDirector(string searchTerm)
        {
            return _dvds.Where(d => d.Director.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        public List<Dvd> GetByRating(string searchTerm)
        {
            return _dvds.Where(d => d.Rating.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        public void Delete(int dvdID)
        {
            _dvds.RemoveAll(d => d.DvdID == dvdID);
        }

        public List<Dvd> GetAll()
        {
            return _dvds;
        }

        public Dvd GetByID(int id)
        {
            return _dvds.First(d => d.DvdID == id);
        }

        public void Update(Dvd dvd)
        {
            Delete(dvd.DvdID);
            _dvds.Add(dvd);
        }
    }
}