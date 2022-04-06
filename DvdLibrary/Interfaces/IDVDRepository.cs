using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DvdLibrary.Models;

namespace DvdLibrary.Interfaces
{
    public interface IDVDRepository
    {
        List<Dvd> GetAll();
        Dvd GetByID(int id);
        void Update(Dvd dvd);
        void Delete(int dvdID);
        int Create(Dvd dvd);
        List<Dvd> GetByTitle(string searchText);
        List<Dvd> GetByReleaseYear(string searchText);
        List<Dvd> GetByDirector(string searchText);
        List<Dvd> GetByRating(string searchText);
    }
}
