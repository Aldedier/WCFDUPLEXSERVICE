using System;
using System.ServiceModel;

namespace ClienteDuplex
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallBackHandler());

            CalculatorServiceClient client = new CalculatorServiceClient(instanceContext);

            client.AddTo(5D);
            client.SubstractFrom(3D);
            client.MultiplyBy(12D);
            client.DivideBy(2D);

            client.Clear();
            Console.ReadLine();
            client.Close();

            Console.WriteLine("Terminado");
            Console.ReadKey();

        }

        private class CallBackHandler : ICalculatorServiceCallback
        {
            public CallBackHandler()
            {
            }

            public void Equal(double result) =>
                Console.WriteLine($"result {result}");

            public void Equation(string eqn) =>
                Console.WriteLine($"equation {eqn}");
        }
    }
}
