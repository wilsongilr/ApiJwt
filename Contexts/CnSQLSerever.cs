using ApiJwt.Models.Matic;
using Microsoft.EntityFrameworkCore;
using System;

namespace ApiJwt.Contexts
{
    public class CnSQLSerever:DbContext 
    {
        public CnSQLSerever(DbContextOptions<CnSQLSerever> options) : base(options) 
        {
        
        }
        public DbSet<ITHTicket> ITHticket  { get; set; }


    }
}
