using System.Collections.Generic;

namespace ConsumindoApiPokemon.Models
{
    public class AbilityModel
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<ResultAbility> results { get; set; }
    }

    public class ResultAbility
    {
        public string name { get; set; }
       // public string url { get; set; }
    }
}
