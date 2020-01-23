using System.Collections.Generic;

namespace PokemonAPI.Models
{
    public class PokemonList
    {
        public int count { get; set; }
        public object next { get; set; }
        public string previous { get; set; }
        public List<Result> results { get; set; }
    }

}

public class Result
{
    public string name { get; set; }
    public string url { get; set; }
}
