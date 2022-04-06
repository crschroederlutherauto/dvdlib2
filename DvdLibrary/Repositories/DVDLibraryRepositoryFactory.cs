using DvdLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace DvdLibrary.Repositories
{
    public static class DVDLibraryRepositoryFactory
    {
        public static IDVDRepository CreateDvdRepository()
        {
            switch (ConfigurationManager.AppSettings["mode"].ToLower())
            {
                case "prod":
                    return new DvdLibraryRepository();
                case "test":
                    return new MockDVDRepository();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}