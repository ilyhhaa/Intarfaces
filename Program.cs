using System;

namespace Interfaces
{
    abstract class Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public void Display() => Console.WriteLine($"Здоровье юнита = {Health} , урон юнита = {Damage}");
        public void DisplayName() => Console.WriteLine(Name);
    }
    class Acolyte:Unit,IAcolyte
    {
        
        public Acolyte()
        {
            
            this.Name = IAcolyte.Name;
            DisplayName();
            this.Health = IAcolyte.Health;
            this.Damage = IAcolyte.Damage;
            Display();
            Phrase();

        }
        public void Phrase() => Console.WriteLine("Нужно больше золота");
    }

    class Peon:Unit,IPeon 
    {
        
        public Peon()
        {
            
            this.Name = IPeon.Name;
            DisplayName();
            this.Health = IPeon.Health;
            this.Damage = IPeon.Damage;
            Display();
            Phrase();

        }
        public void Phrase() => Console.WriteLine("Не могу стоять, пока другие работают... Пойду полежу.");


    }
    class Peasant : Unit, IPeasant
    {

        public Peasant()
        {
            
            this.Name = IPeasant.Name;
            DisplayName();
            this.Health = IPeasant.Health;
            this.Damage = IPeasant.Damage;
            Display();
            Phrase();

        }
        public void Phrase() => Console.WriteLine("Опять работа?");


    }
    class Wisp : Unit, IWisp
    {

        public Wisp()
        {
            
            this.Name = IWisp.Name;
            DisplayName();
            this.Health = IWisp.Health;
            this.Damage = IWisp.Damage;
            Display();
            Phrase();

        }
        public void Phrase() => Console.WriteLine(".оО");


    }
    class Program
    {
        static void Main(string[] args)
        {

            Acolyte acolyte = new Acolyte();
            Peon peon = new Peon();
            Peasant peasant = new Peasant();
            Wisp wisp = new Wisp();




        }
    }
}
    
   

