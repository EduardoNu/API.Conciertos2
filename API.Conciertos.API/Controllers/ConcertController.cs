using API.Conciertos.BusinessLogic.Concerts;
using API.Conciertos.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Linq.Expressions;

namespace API.Conciertos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcertController : ControllerBase
    {
        private readonly ConcertBL concertBL;
        public ConcertController()
        {
            concertBL = new ConcertBL();
        }


        [HttpGet()]
        [Route("GetConcerts")]

        public async Task<List<Concert>> GetConcerts()
        {
            List<Concert> list = new List<Concert>();
            try
            {
                list = await concertBL.GetConcerts();

                
            }
            
            catch(Exception ex)
            { 

            }
            return list;
        }

        [HttpPost()]
        [Route("PostConcert")]

        public async Task<Concert>  PostConcert(int id)
        {
            return await concertBL.GetConcertById(id);
        }
    }
}
