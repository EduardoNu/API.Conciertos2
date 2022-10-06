using API.Conciertos.DataAccess.DataAccess.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Conciertos.DataAccess
{
    public class App
    {


        private static IDataAccess dataAccess;

        public static IDataAccess DataAccess
        {
            get
            {
                if(App.dataAccess == null) 
                {
                    App.dataAccess = new MockDataAccess();
                }

                return App.dataAccess;
            }
        }
    }
}
