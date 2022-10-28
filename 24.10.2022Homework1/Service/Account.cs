using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace Service
{
    public class Account 
    {
        public void AccountCheck()
        {
            Console.Write("Gmail-i daxil edin : ");
            string login = Console.ReadLine();
            Console.Write("Passwordu daxil edin : ");
            string password = Console.ReadLine();
            if(password == "test@code.edu.az")
            {
                if(password == "test12345")
                {
                    Console.WriteLine("Giris ugurlu");
                }
                
            }
            Console.WriteLine("Duzgun daxil et");
        }
    }
}