using Domain;
using Storage;
using Storage.Implementation.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.PerformerSO;
using SystemOperations.UserSO;
using SystemOperations.AddressSO;
using SystemOperations.ConcertSO;
using SystemOperations.TicketSO;

namespace ControllerBL
{
    public class Controller
    {
        private IGenericRepository repository;

        public User User { get; set; }

        #region singleton
        private static Controller instance;

        private static object _lock = new object();
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Controller();
                        }
                    }
                }
                return instance;
            }
        }

        private Controller()
        {
            repository = new GenericRepository();
        }
        #endregion

        public User Login(User user)
        {

            LoginSO so = new LoginSO();
            so.ExecuteTemplate(user);
            return so.Result;
        }
        public User Register(User user)
        {
            RegisterSO so = new RegisterSO();
            so.ExecuteTemplate(user);
            return so.Result;
        }

        public List<Performer> GetPerformersByQuery(string query)
        {
            PerformersByQuerySO so = new PerformersByQuerySO();
            Performer p = new Performer
            {
                ArtistName = query
            };
            so.ExecuteTemplate(p, "ArtistName");
            return so.Result;
        }

        public object GetConcertsByQuery(string query)
        {
            ConcertsByQuerySO so = new ConcertsByQuerySO();
            Concert c = new Concert
            {
                Name = query
            };
            so.ExecuteTemplate(c, "c.name");
            return so.Result;
        }

        public List<Performer> GetAllPerformers()
        {
            GetAllPerformersSO so = new GetAllPerformersSO();
            so.ExecuteTemplate(new Performer());
            return so.Result;
        }

        public object GetAllAddresses()
        {
            GetAllAddressesSO so = new GetAllAddressesSO();
            so.ExecuteTemplate(new Address());
            return so.Result;
        }

        public Concert SaveConcert(Concert concert)
        {
            SaveConcertSO so = new SaveConcertSO();
            so.ExecuteTemplate(concert);
            return so.Result;
        }

        public List<Genre> GetAllGenres()
        {
            GetAllGenresSO so = new GetAllGenresSO();
            so.ExecuteTemplate(new Genre());
            return so.Result;
        }

        public Performer SavePerformer(Performer p)
        {
            SavePerformerSO so = new SavePerformerSO();
            so.ExecuteTemplate(p);
            return so.Result;
        }

        public List<Concert> GetConcertsOfPerformer(Performer p)
        {
            GetConcertsOfPerformerSO so = new GetConcertsOfPerformerSO();
            so.ExecuteTemplate(p);
            return so.Result;
        }

        public object GetAllConcerts()
        {
            GetAllConcertsSO so = new GetAllConcertsSO();
            so.ExecuteTemplate(new Concert());
            return so.Result;
        }

        public object GetPerformersOfConcert(Concert c)
        {
            GetPerformersOfConcertSO so = new GetPerformersOfConcertSO();
            so.ExecuteTemplate(c);
            return so.Result;
        }

        public object DeleteConcert(Concert c)
        {
            DeleteConcertSO so = new DeleteConcertSO();
            so.ExecuteTemplate(c);
            return so.Result;
        }

        public object BuyTicket(Concert c, User u)
        {
            BuyTicketSO so = new BuyTicketSO(u);
            so.ExecuteTemplate(c);
            return so.Result;
        }

        public object UpdateConcert(Concert c)
        {
            UpdateConcertSO so = new UpdateConcertSO();
            so.ExecuteTemplate(c);
            return so.Result;
        }

        public List<TicketProfileDTO> GetTickets(User u)
        {
            GetTicketsSO so = new GetTicketsSO();
            so.ExecuteTemplate(u);
            return so.Result;
        }
    }
}
