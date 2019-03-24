using System;
using System.Data.Entity;

namespace WebApp.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string SurveyTitle { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
    }
}