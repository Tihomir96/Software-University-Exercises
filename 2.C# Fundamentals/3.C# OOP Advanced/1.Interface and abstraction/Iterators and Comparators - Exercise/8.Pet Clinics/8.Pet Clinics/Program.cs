using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using _8.Pet_Clinics.Entities;

namespace _8.Pet_Clinics
{
    public class Program
    {
        private static Dictionary<string,Pet> allPets=new Dictionary<string, Pet>();
        private static Dictionary<string, Clinic> allClinics = new Dictionary<string, Clinic>();

        public static void Main()
        {
            int cmmdsCount = int.Parse(Console.ReadLine());
            for (int index = 0; index < cmmdsCount; index++)
            {
                var cmmdTokens = Console.ReadLine().Split(new [] {' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                string cmmdType = cmmdTokens[0];
                cmmdTokens.RemoveAt(0);
                switch (cmmdType)
                {
                    case "Create":
                        CreateEntity(cmmdTokens);
                        break;
                    case "Add":
                        AddPetToClinic(cmmdTokens[0],cmmdTokens[1]);
                        break;
                    case "Release":
                        ReleasePetFromClinic(cmmdTokens[0]);                    
                        break;
                    case "HasEmptyRooms":
                        CheckForEmptyRooms(cmmdTokens[0]);
                        break;
                    case "Print":
                        PrintInfo(cmmdTokens);
                        break;                        
                }
            }
        }

        private static void PrintInfo(List<string> cmmdTokens)
        {
            var currClinic = allClinics[cmmdTokens[0]];
            string result = null;

            if (cmmdTokens.Count == 1)
            {
                result =currClinic.Print();
            }
            else
            {
                int room = int.Parse(cmmdTokens[1])-1;
                result = currClinic.Print(room);
            }
            Console.WriteLine(result);
        }

        private static void CheckForEmptyRooms(string clinicName)
        {
            var currClinic = allClinics[clinicName];

            Console.WriteLine(currClinic.HasEmptyRooms());
        }

        private static void ReleasePetFromClinic(string clinicName)
        {
            var currClinic = allClinics[clinicName];
            Console.WriteLine(currClinic.TryReleasePet());
        }

        private static void AddPetToClinic(string petName, string clinicName)
        {
            var currPet = allPets[petName];
            var currClinic = allClinics[clinicName];
            if (currClinic.TryAddPet(currPet))
            {
                Console.WriteLine(true);
                allPets.Remove(petName);
                return;
            }
            Console.WriteLine(false);
        }

        private static void CreateEntity(List<string> cmmdTokens)
        {
            var entityType = cmmdTokens[0];
            if (entityType == "Pet")
            {
                string name = cmmdTokens[1];
                int age = int.Parse(cmmdTokens[2]);
                string kind = cmmdTokens[3];
                var pet = new Pet(name, age, kind);
                allPets.Add(name, pet);
            }
            else
            {
                var name = cmmdTokens[1];
                int rooms = int.Parse(cmmdTokens[2]);
                try
                {
                    var clinic = new Clinic(name, rooms);
                    allClinics.Add(name, clinic);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }

        }
    }
}
