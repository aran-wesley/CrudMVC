using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudMVC.Models
{
    public class EscolaContext : DbContext
    {
        public EscolaContext():base("Escola")
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}