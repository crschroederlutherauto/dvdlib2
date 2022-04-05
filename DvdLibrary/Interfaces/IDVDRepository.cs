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
    }
}
