using Data.Infrastructure;
using Domain.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consoles
{
    public class Program
    {
        static void Main(string[] args)
        {
            idea i = new idea();
            category k = new category();
            
            //IdeaServices ideas = new IdeaServices();
            //UserServices users = new UserServices();
            CategoryServices categeorys = new CategoryServices();
            
            categeorys.Add(k);
            categeorys.Commit();
            



        //i.category = categeorys.GetById(2);
            //i.user = users.GetById(4);

            //ideas.Add(i);
            // ideas.Commit();
          
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);

        }
    }
}
