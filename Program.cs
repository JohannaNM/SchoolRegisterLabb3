using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SchoolRegisterLabb3.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegisterLabb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var run = new Run();
            run.RunMenu();
           
        }


    }
}