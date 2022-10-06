using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Conciertos.Entities
{
    public class Concert
    {
        public int Id { get; set; } 


        public int Day { get; set; }

        public string Event { get; set; }

        public string Ubication { get; set; }   

        public string Hour { get; set; }

        public int Price { get; set; }

        public int Age { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }
    }
}
