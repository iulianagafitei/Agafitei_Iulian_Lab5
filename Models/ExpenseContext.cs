using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agafitei_Iulian_Lab5.Models;

namespace Agafitei_Iulian_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Agafitei_Iulian_Lab5.Models.Budget> Budget { get; set; }

    }
}
