using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Credit;

namespace Unity.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<ICreditCard, MasterCard>();

            container.RegisterType<ICreditCard, MasterCard>(new InjectionProperty("ChargeCount", 5));
            //container.RegisterType<ICreditCard, MasterCard>("DefaultCard");

            //var card = new MasterCard();
            //container.RegisterInstance(card);

            var shopper = container.Resolve<Shopper>();
            //var shopper = container.Resolve<Shopper>(new ParameterOverride("creditCard", new Visa()));

            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCard);

            Console.ReadLine();
        }
    }
}
