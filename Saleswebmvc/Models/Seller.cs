﻿using System.Linq;
using System.Collections.Generic;

namespace Saleswebmvc.Models


{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirtDate { get; set; }
        public double BaseSalary { get; set; }        
        public Department Department { get; set; }
        public ICollection<SallesRecord>Sales { get; set; } = new List<SallesRecord>();

        public Seller() { }

        public Seller(int id, string name, string email, DateTime birtDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirtDate = birtDate;
            BaseSalary = baseSalary;
            Department = department;
        }

    public void AddSales(SallesRecord sr)
    {
        Sales.Add(sr);
    }
    public void RemoveSales(SallesRecord sr)
        {

        Sales.Remove(sr);
        }
    
      
  public double TotalSales(DateTime initial, DateTime final)
        {

            return Sales.Where(sr=> sr.Date>= initial && sr.Date <= final).Sum(sr=>sr.Amount);

        }  
    
       }


    }




