using DZ._20220724.Film.Models;
using System.Collections.Generic;

namespace DZ._20220724.Film.Interfaces
{
    public interface IRepository
    {
        List<Movie> Show();
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DelMovie(int Id);
        void AddSessionList(int Id, string addSession);
        void DelSessionList(int Id, string delSession);
        Movie DetailsMovie(int Id);
        List<Movie> SearchMovie(string filter,string searchString);
        //List<Movie> SearchMovie(string searchString);
    }
}
