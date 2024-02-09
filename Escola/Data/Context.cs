using Escola.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Escola.Data
{
    public class Context: DbContext 
    {
        public Context(DbContextOptions<Context> options) : base (options)
        {  
            
           
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
