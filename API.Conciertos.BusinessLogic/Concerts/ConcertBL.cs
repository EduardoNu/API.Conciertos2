using API.Conciertos.DataAccess;
using API.Conciertos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Conciertos.BusinessLogic.Concerts
{
    public class ConcertBL
    {

        public async Task<List<Concert>> GetConcerts()
        {
            return await App.DataAccess.GetConcerts();
        }

        public async Task<Concert> GetConcertById(int id)
        {
            return await App.DataAccess.GetConcerts(id);
        }
    }
}
