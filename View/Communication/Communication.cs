using Common;
using View.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace View.Communication
{
    public class Communication
    {

        #region basic stuff
        //instance of Communication class
        private static Communication instance;
        private Socket socket;
        private CommunicationClient client;


        private Communication()
        {

        }
        #endregion

        #region singleton
        //Singleton pattern
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }

        


        #endregion

        internal User Login(string username, string password)
        {
            Request request = new Request()
            {
                Operation = Operation.Login,
                RequestObject = new User { Username = username, Password = password }
            };
            client.SendRequest(request);
            return (User)client.GetResponseResult();
        }

        internal List<Performer> GetPerformersOfConcert(Concert c)
        {
            Request request = new Request()
            {
                Operation = Operation.GetPerformersOfConcert,
                RequestObject = c
            };
            client.SendRequest(request);
            return (List<Performer>)client.GetResponseResult();
        }

        internal List<Concert> GetConcertsOfPerformer(Performer selectedPerformer)
        {
            Request request = new Request()
            {
                Operation = Operation.GetConcertsOfPerformer,
                RequestObject = selectedPerformer
            };
            client.SendRequest(request);
            return (List<Concert>)client.GetResponseResult();
        }

        internal List<Address> GetAddresses()
        {
            Request request = new Request()
            {
                Operation = Operation.GetAllAddresses
            };
            client.SendRequest(request);
            return (List<Address>)client.GetResponseResult();
        }

        internal List<Performer> GetPerformers()
        {
            Request request = new Request()
            {
                Operation = Operation.GetAllPerformers
            };
            client.SendRequest(request);
            return (List<Performer>)client.GetResponseResult();
        }

        internal List<Concert> GetConcerts()
        {
            Request request = new Request()
            {
                Operation = Operation.GetAllConcerts
            };
            client.SendRequest(request);
            return (List<Concert>)client.GetResponseResult();
        }

        internal List<Genre> GetGenres()
        {
            Request request = new Request()
            {
                Operation = Operation.GetAllGenres
            };
            client.SendRequest(request);
            return (List<Genre>)client.GetResponseResult();
        }

        internal List<TicketProfileDTO> GetTickets(User u)
        {
            Request request = new Request()
            {
                Operation = Operation.GetTickets,
                RequestObject = u
            };
            client.SendRequest(request);
            return (List<TicketProfileDTO>)client.GetResponseResult();
        }


        internal User Register(string username, string password, string name, string surname, string email)
        {
            Request request = new Request()
            {
                Operation = Operation.Register,
                RequestObject = new User { Username = username, Password = password, Name = name, Surname = surname, Email = email }
            };
            client.SendRequest(request);
            return (User)client.GetResponseResult();
        }

        internal List<Performer> GetPerformersByQuery(string query)
        {
            Request request = new Request()
            {
                Operation = Operation.GetPerformersByQuery,
                RequestObject = query
            };
            client.SendRequest(request);
            return (List<Performer>)client.GetResponseResult();
        }

        internal List<Concert> GetConcertsByQuery(string query)
        {
            Request request = new Request()
            {
                Operation = Operation.GetConcertsByQuery,
                RequestObject = query
            };
            client.SendRequest(request);
            return (List<Concert>)client.GetResponseResult();
        }

        internal Concert SaveConcert(Concert concert)
        {
            Request request = new Request()
            {
                Operation = Operation.SaveConcert,
                RequestObject = concert
            };
            client.SendRequest(request);
            return (Concert)client.GetResponseResult();
        }

        internal Concert DeleteConcert(Concert c)
        {
            Request request = new Request()
            {
                Operation = Operation.DeleteConcert,
                RequestObject = c
            };
            client.SendRequest(request);
            return (Concert)client.GetResponseResult();
        }

        internal Ticket BuyTicket(Concert concert)
        {
            Request request = new Request()
            {
                Operation = Operation.BuyTicket,
                RequestObject = concert
            };
            client.SendRequest(request);
            return (Ticket)client.GetResponseResult();
        }

        internal Concert UpdateConcert(Concert concert)
        {
            Request request = new Request()
            {
                Operation = Operation.UpdateConcert,
                RequestObject = concert
            };
            client.SendRequest(request);
            return (Concert)client.GetResponseResult();
        }

        internal Performer SavePerformer(Performer p)
        {
            Request request = new Request()
            {
                Operation = Operation.SavePerformer,
                RequestObject = p
            };
            client.SendRequest(request);
            return (Performer)client.GetResponseResult();
        }

        #region connect/disconnect        
        public void Connect()
        {
            if (socket != null && socket.Connected)
            {
                return;
            }
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9937);
            client = new CommunicationClient(socket);

        }

        internal void Disconnect()
        {
            socket.Close();
            socket = null;
        }

        


        #endregion
    }
}
