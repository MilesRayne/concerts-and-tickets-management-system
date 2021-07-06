using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    //List of all possible operations
    public enum Operation
    {
        Login,
        GetPerformersByQuery,
        GetAllPerformers,
        Register,
        GetAllAddresses,
        SaveConcert,
        GetAllGenres,
        SavePerformer,
        GetConcertsOfPerformer,
        GetAllConcerts,
        GetConcertsByQuery,
        GetPerformersOfConcert,
        DeleteConcert,
        BuyTicket,
        UpdateConcert,
        GetTickets
    }
}
