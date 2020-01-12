using DnDCharacterCreator.Model;
using DnDCharacterCreator.Model.Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharacter(CreateCharacter());
            Console.ReadKey();
        }

        private static void PrintCharacter(Character character)
        {
            Console.WriteLine($"Your name is {character.GetName()}");
            Console.WriteLine($"Your Race is {character.GetRace().GetType().Name}");
            Console.WriteLine($"Your Speed is {character.GetSpeed()}");
            Console.WriteLine($"Your Size is {character.GetSize()}");
            Console.WriteLine($"{character.Ability.GetAbilities()}");
        }

        private static Character CreateCharacter()
        {
            Character character = new Character();
            Console.WriteLine("What's your Name?");
            character.SetName(Console.ReadLine());
            //Console.WriteLine($"Pick your Str from {String.Join(",",character.Ability.GetStandardArray())}");
            //Int32.TryParse(Console.ReadLine(), out int str);
            //Console.WriteLine($"Pick your Dex from {String.Join(",", character.Ability.GetStandardArray(str))}");
            //Int32.TryParse(Console.ReadLine(), out int dex);
            //Console.WriteLine($"Pick your Con from {String.Join(",", character.Ability.GetStandardArray(dex))}");
            //Int32.TryParse(Console.ReadLine(), out int con);
            //Console.WriteLine($"Pick your Int from {String.Join(",", character.Ability.GetStandardArray(con))}");
            //Int32.TryParse(Console.ReadLine(), out int @int);
            //Console.WriteLine($"Pick your Wis from {String.Join(",", character.Ability.GetStandardArray(@int))}");
            //Int32.TryParse(Console.ReadLine(), out int wis);
            //Console.WriteLine($"Pick your Cha from {String.Join(",", character.Ability.GetStandardArray(wis))}");
            //Int32.TryParse(Console.ReadLine(), out int cha);

            //character.Ability = new Ability(str, dex, con, @int, wis, cha);
            Console.WriteLine("What's your Race?");
            character.SetRace(GetRace($"DnDCharacterCreator.Model.Races.{Console.ReadLine()}"));

            return character;
        }

        private static ISubRace GetRace(string race)
        {
            race = race.Replace(" ", "");
            Type t = Type.GetType(race);
            return (ISubRace) Activator.CreateInstance(t);
        }
    }
}
