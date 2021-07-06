using Common;
using ControllerBL;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Socket client;
        private readonly BindingList<User> users;

        private User loggedInUser;
        public ClientHandler(Socket client, System.ComponentModel.BindingList<User> users)
        {
            this.client = client;
            this.users = users;
        }

        public void StartHandler()
        {
            try
            {
                NetworkStream stream = new NetworkStream(client);
                BinaryFormatter formatter = new BinaryFormatter();
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response;
                    try
                    {
                        response = ProcessRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response = new Response();
                        response.IsSuccessful = false;
                        response.Error = ex.Message;
                    }
                    formatter.Serialize(stream, response);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                users.Remove(loggedInUser);

            }
            catch (SerializationException)
            {
                Console.WriteLine("Doslo je do prekida veze");
                //obratiti paznju na EventHandler FrmMain FormClosed (ako zatvorimo glavnu formu, i prakticno se izlogujemo, prekidamo vezu sa serverom
                //drugi nacin bi bio da posaljemo zahtev sa operacijom logout, tako da klijent ostane povezan
                users.Remove(loggedInUser);

            }
        }

        private Response ProcessRequest(Request request)
        {
            Response response = new Response();
            response.IsSuccessful = true;
            switch (request.Operation)
            {
                case Operation.Login:
                    response.Result = Controller.Instance.Login((User)request.RequestObject);
                    loggedInUser = (User)response.Result;
                    users.Add(loggedInUser);
                    break;
                case Operation.GetPerformersByQuery:
                    response.Result = Controller.Instance.GetPerformersByQuery((string)request.RequestObject);
                    break;
                case Operation.GetAllPerformers:
                    response.Result = Controller.Instance.GetAllPerformers();
                    break;
                case Operation.Register:
                    response.Result = Controller.Instance.Register((User)request.RequestObject);
                    loggedInUser = (User)response.Result;
                    users.Add(loggedInUser);
                    break;
                case Operation.GetAllAddresses:
                    response.Result = Controller.Instance.GetAllAddresses();
                    break;
                case Operation.SaveConcert:
                    response.Result = Controller.Instance.SaveConcert((Concert)request.RequestObject);
                    break;
                case Operation.GetAllGenres:
                    response.Result = Controller.Instance.GetAllGenres();
                    break;
                case Operation.SavePerformer:
                    response.Result = Controller.Instance.SavePerformer((Performer)request.RequestObject);
                    break;
                case Operation.GetConcertsOfPerformer:
                    response.Result = Controller.Instance.GetConcertsOfPerformer((Performer)request.RequestObject);
                    break;
                case Operation.GetPerformersOfConcert:
                    response.Result = Controller.Instance.GetPerformersOfConcert((Concert)request.RequestObject);
                    break;
                case Operation.GetAllConcerts:
                    response.Result = Controller.Instance.GetAllConcerts();
                    break;
                case Operation.GetConcertsByQuery:
                    response.Result = Controller.Instance.GetConcertsByQuery((string)request.RequestObject);
                    break;
                case Operation.DeleteConcert:
                    response.Result = Controller.Instance.DeleteConcert((Concert)request.RequestObject);
                    break;
                case Operation.BuyTicket:
                    response.Result = Controller.Instance.BuyTicket((Concert)request.RequestObject, loggedInUser);
                    break;
                case Operation.UpdateConcert:
                    response.Result = Controller.Instance.UpdateConcert((Concert)request.RequestObject);
                    break;
                case Operation.GetTickets:
                    response.Result = Controller.Instance.GetTickets((User)request.RequestObject);
                    break;

            }
            return response;
        }

        internal void Stop()
        {
            client.Close();
        }
    }
}
