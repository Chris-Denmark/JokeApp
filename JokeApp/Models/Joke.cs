using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeApp.Models
{
    public class Joke
    {
        public int id { get; set; }
        public int JokeQuestion { get; set; }
        public int JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
