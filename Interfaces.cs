using System;
namespace Interfaces
{
    public interface IAcolyte
    {
        const string Name = "Прислужник";
        const int Health = 220;
        const int Damage = 10;
        void Phrase();
        
        
    }
    public interface IPeasant
    {
        const string Name = "Рабочий";
        const int Health = 220;
        const int Damage = 6;
        void Phrase();
        
    }
    public interface IPeon
    {
        const string Name = "Раб";
        const int Health = 250;
        const int Damage = 8;
        void Phrase();
        

    }
    public interface IWisp
    {
        const string Name = "Светлячок";
        const int Health = 120;
        const int Damage = 0;
        void Phrase();
        
    }
}
