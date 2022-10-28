using _24._10._2022Homework1.Helpers.Enums;
using Service;
using Service.Services.Interface;
using System;

namespace _24._10._2022Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rolu daxil edin : ");
            Roles roles = new Roles();
            string num1 = Console.ReadLine();
            int RolesId = int.Parse(num1);
            CheckRoles(RolesId);
            if(RolesId == 1)
            {
                Account account = new Account();
                account.AccountCheck();
            }
            else
            {
                Console.Write("Ugursuz giris");
            }
            
        }
        public static void CheckRoles(int Rolesİd)
        {

            switch (Rolesİd)
            {
                case (int)Roles.SuperAdmin:
                    Console.WriteLine("Super Admindir");
                    break;
                case (int)Roles.Admin:
                    Console.WriteLine("Admindir");
                    break ;
                case (int)Roles.Member:
                    Console.WriteLine("Memberdi");
                    break;
                default:
                    Console.WriteLine("Duzgun daxil edilmedi");
                    break;
            }
        }
    }
}
