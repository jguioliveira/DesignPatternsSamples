using GO.Patterns.FactoryMethod;
using GO.Patterns.Gateway;
using GO.Patterns.Strategy;
using GO.Patterns.TemplateMethod.Figure;
using System;
namespace DP.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy
            IMask cpf = MaskGateway.GetMask(MaskType.CPF);
            Console.WriteLine(MaskApply.FormatApply(cpf, "77693284621"));

            IMask cnpj = MaskGateway.GetMask(MaskType.CNPJ);
            Console.WriteLine(MaskApply.FormatApply(cnpj, "17630236000104"));

            //TemplateMethod
            Figure square = new Square(10);
            square.ShowInfo();

            Figure rectangle = new Rectangle(5, 10);
            rectangle.ShowInfo();

            //Factory Method
            Console.WriteLine("Peter is an user with the following permissions: ");
            User peter = User.CreateUser(UserType.Administrator);
            
            Console.WriteLine("Joseph is an user with the following permissions: ");
            User joseph = User.CreateUser(UserType.Supervisor);

            Console.ReadKey();


        }
    }
}
