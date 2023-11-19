﻿using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_domain;

namespace myfinance_web_dotnet_infra;

public class MyFinanceDbContext : DbContext
{

    public DbSet<PlanoConta> PlanoConta {get; set;}
    public DbSet<Transacao> Transacao {get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-QB722AQ\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;");
    }
}
