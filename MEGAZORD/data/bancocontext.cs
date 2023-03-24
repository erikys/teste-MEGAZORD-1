using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace MEGAZORD.data
{
    public class bancocontext : DBContext
    {
        public bancocontext(DbContextOptions<bancocontext> options) : base(options) 
    }
}
