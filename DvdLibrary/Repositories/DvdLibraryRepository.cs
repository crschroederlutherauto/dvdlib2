using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DvdLibrary.Helpers;
using DvdLibrary.Interfaces;
using DvdLibrary.Models;

namespace DvdLibrary.Repositories
{
    public class DvdLibraryRepository: IDVDRepository
    {

        public List<Dvd> GetAll()
        {
            List<Dvd> dvds = new List<Dvd>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetAll]";
            cmd.CommandType = CommandType.StoredProcedure;

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dvd dvd = new Dvd();

                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");

                        dvds.Add(dvd);
                    }
                }
            }
            return dvds;
        }

        public List<Dvd> GetByRating(string searchText)
        {
            List<Dvd> dvds = new List<Dvd>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetByRating]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchText", searchText);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dvd dvd = new Dvd();

                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");

                        dvds.Add(dvd);
                    }
                }
            }
            return dvds;
        }

        public List<Dvd> GetByDirector(string searchText)
        {
            List<Dvd> dvds = new List<Dvd>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetByDirector]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchText", searchText);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dvd dvd = new Dvd();

                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");

                        dvds.Add(dvd);
                    }
                }
            }
            return dvds;
        }

        public List<Dvd> GetByReleaseYear(string searchText)
        {
            List<Dvd> dvds = new List<Dvd>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetByReleaseYear]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchText", searchText);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dvd dvd = new Dvd();

                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");

                        dvds.Add(dvd);
                    }
                }
            }
            return dvds;
        }

        public List<Dvd> GetByTitle(string searchText)
        {
            List<Dvd> dvds = new List<Dvd>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetByTitle]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@searchText", searchText);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dvd dvd = new Dvd();

                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");

                        dvds.Add(dvd);
                    }
                }
            }
            return dvds;
        }

        public Dvd GetByID(int id)
        {
            Dvd dvd = new Dvd();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[GetByID]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dvdID", id);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dvd.Director = ViewModelMappingHelper.Parse<string>(reader, "Director");
                        dvd.DvdID = ViewModelMappingHelper.Parse<int>(reader, "DvdID");
                        dvd.Notes = ViewModelMappingHelper.Parse<string>(reader, "Notes");
                        dvd.Rating = ViewModelMappingHelper.Parse<string>(reader, "Rating");
                        dvd.ReleaseYear = ViewModelMappingHelper.Parse<string>(reader, "ReleaseYear");
                        dvd.Title = ViewModelMappingHelper.Parse<string>(reader, "Title");
                    }
                }
            }
            return dvd;
        }

        public void Update(Dvd dvd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[Update]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dvdID", dvd.DvdID);
            cmd.Parameters.AddWithValue("@director", dvd.Director);
            cmd.Parameters.AddWithValue("@notes", dvd.Notes);
            cmd.Parameters.AddWithValue("@rating", dvd.Rating);
            cmd.Parameters.AddWithValue("@releaseYear", dvd.ReleaseYear);
            cmd.Parameters.AddWithValue("@title", dvd.Title);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int dvdID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[Delete]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dvdID", dvdID);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public int Create (Dvd dvd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[Create]";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@director", dvd.Director);
            cmd.Parameters.AddWithValue("@notes", dvd.Notes);
            cmd.Parameters.AddWithValue("@rating", dvd.Rating);
            cmd.Parameters.AddWithValue("@releaseYear", dvd.ReleaseYear);
            cmd.Parameters.AddWithValue("@title", dvd.Title);

            using (cmd.Connection = SqlConnectionHelper.GetConnection())
            {
                cmd.Connection.Open();

                object id = cmd.ExecuteScalar();

                return int.Parse(id.ToString());
            }
        }
    }
}