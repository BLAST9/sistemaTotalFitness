using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BDGenerator
{
    class Program
    {
        static void Main(string[] args)
        { //Se crea una instancia de BD Model
            using (var db = new BDModel())
            {
                Console.WriteLine("PRECIONE ENTER PARA CREAR LA BD...!!!");
                Console.ReadKey();

                try
                {
                    //Si no existe la BD se manda a decir que cree una nueva
                    db.Database.CreateIfNotExists();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                finally
                {
                    Console.WriteLine("[Proceso finalizado]");
                    Console.ReadKey();
                }
            }
        }
    }
}
