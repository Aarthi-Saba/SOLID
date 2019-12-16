using System;

namespace SolidPrinciples
{
    public class Program
    {
       // private static Computer _computer;
        public static void Main()
        {
            IComputer comp = new Computer();
            TestComputer.TestProcess(comp);
        }
    }

    public class TestComputer
    {
        public static void TestProcess(IComputer comp)
        {
            Console.WriteLine($"Power supply : {comp.ProducePower()}");
            Console.WriteLine($"Cpu process : {comp.Calculate()}");
            Console.WriteLine($"RAM : {comp.StoringData()}");
            Console.WriteLine($"HardDrive : {comp.WritingData()}");
            Console.WriteLine($"Motherboard : {comp.Motherboarding()}");
        }
    }
    public interface IComputer : IPower,IHarddrive,IRam,ICpu,IMotherboard
    {
    }

    public interface IMotherboard
    {
        public string Motherboarding();
    }

    public interface ICpu
    {
        public string Calculate();
    }

    public interface IHarddrive
    {
        public string WritingData();
    }

    public interface IRam
    {
        public string StoringData();
    }

    public interface IPower
    {
        public string ProducePower();
    }

    public class Computer : IComputer
    {
        public string Calculate()
        {
            return "Calculating";
        }

        public string Motherboarding()
        {
            return "Connecting everything";
        }

        public string ProducePower()
        {
            return "Producing Power";
        }

        public string StoringData()
        {
            return "Storing Data";
        }

        public string WritingData()
        {
            return "Writing Data";
        }
    }
}
