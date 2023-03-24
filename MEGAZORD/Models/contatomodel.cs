using Microsoft.AspNetCore.Mvc;

namespace MEGAZORD.Models
{
    public class contatomodel : Controller
    {
        public int id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string celular { get; set; }

        public string cpf { get; set; }     
    }
}
