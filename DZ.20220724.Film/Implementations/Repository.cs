using DZ._20220724.Film.Interfaces;
using DZ._20220724.Film.Models;
using System.Collections.Generic;
using System.Linq;

namespace DZ._20220724.Film.Implementations
{
    public class Repository : IRepository
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie {  Id=1, Title="Початок", Produser="Крістофер Нолан", Style="Фантастика",
                ShortDescription="Фільм «Початок» розповідає про найхитріших грабіжників, які влаштували полювання на ідеї. Злодіїв не цікавлять гроші, коштовності та інші матеріальні блага. Вони проникають у глибини людської підсвідомості через сон, конструюючи необхідну їм реальність.",
                SessionList=new List<string>{"10:30","12:00" ,"12:30" ,"15:00" ,"16:30" } },
            new Movie {  Id=2, Title="Гра тіней", Produser="Марк Вільямс", Style="Трилер",
                ShortDescription="Тревіс Блок багато років віддав службі у ФБР, але зараз пішов на заслужений відпочинок. Небезпечна і складна робота не дозволила йому стати добрим батьком, і тепер він хоче бути люблячим і дбайливим дідусем для онуки. Ось тільки служба не залишає його.",
                SessionList=new List<string>{"12:30","14:00" ,"15:30" ,"17:00" ,"18:30" } },
            new Movie {  Id=3, Title="Найманець", Produser="Тарік Салех", Style="Бойовик",
                ShortDescription="Служба в армії з дитинства була мрією Джеймса Ріда, а зелений берет – предметом гордості. Але після отриманих поранень його «послуги» стали непотрібні, і людина, що має військовий досвід, лишається в стороні.",
                SessionList=new List<string>{ "16:30", "18:00", "19:30", "21:00", "22:30" } },
            new Movie {  Id=4, Title="Джек Раян: Теорія хаосу", Produser="Кеннет Брана", Style="Трилер",
                ShortDescription="Рядовий аналітик ЦРУ Джек Райан приїжджає в Москву, щоб вирішити просту задачу: йому потрібно перевірити операції компанії, які належить мільярдерові Віктору Черевін.",
                SessionList=new List<string>{"10:30","12:00" ,"12:30" ,"15:00" ,"16:30" } },
            new Movie {  Id=5, Title="Той, що танцює з вовками", Produser="Кевін Костнер", Style="Вестерн",
                ShortDescription="Дії фільму відбуваються в Сполучених Штатах Америки за часів Громадянської війни. Джон Данбар - американський лейтенант, після поранення переводиться по службі в тихіше місце. Нове місце його служби - це віддалений маленький форт. Обставини склалися не найкращим чином для головного героя. У форті він залишився зовсім один і йому доведеться виживати в умовах суворої природи.",
                SessionList=new List<string>{"16:30","18:00" ,"19:30" ,"21:00" ,"22:30" } }
        };
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void AddSessionList(int Id, string addSession)
        {
            foreach (var movie in movies)
            {
                if (movie.Id==Id)
                {
                    movie.SessionList.Add(addSession);
                }
            }
            //movies.Where(m => m.Id == Id).Add(session);
            //foreach (var movie in movies)
            //{
            //    if (movie.Id = )
            //    {

            //    }
            //}
        }

        public void DelMovie(int Id)
        {
            Movie movieDel = DetailsMovie(Id);
            movies.Remove(movieDel);
        }

        public void DelSessionList(int Id, string delSession)
        {
            foreach (var movie in movies)
            {
                if (movie.Id == Id)
                {
                    movie.SessionList.Remove(delSession);
                }
            }
        }

        public Movie DetailsMovie(int Id)
        {
            return movies.FirstOrDefault(m => m.Id == Id);
        }

        public void EditMovie(Movie movie)
        {
            foreach (var itemMovie in movies)
            {
                if (itemMovie.Id == movie.Id)
                {
                    itemMovie.Title = movie.Title;
                    itemMovie.Produser = movie.Produser;
                    itemMovie.Style = movie.Style;
                    itemMovie.ShortDescription = movie.ShortDescription;
                    itemMovie.SessionList = movie.SessionList;
                }
            }
        }

        public List<Movie> SearchMovie(string filter, string searchString)
        {

            if (searchString == null || filter == null)
            {
                return null;
            }
            if (filter == "Title")
                return movies.Where(m => m.Title!.Contains(searchString)).ToList();
            else if (filter == "Produser")
                return movies.Where(m => m.Produser!.Contains(searchString)).ToList();
            else if (filter == "Style")
                return movies.Where(m => m.Style!.Contains(searchString)).ToList();
            else if (filter == "ShortDescription")
                return movies.Where(m => m.ShortDescription!.Contains(searchString)).ToList();
            else if (filter == "SessionList")
                return movies.Where(m => m.SessionList!.Contains(searchString)).ToList();
            else return null;
        }


        public List<Movie> Show()
        {
            return movies;
        }
    }
}
