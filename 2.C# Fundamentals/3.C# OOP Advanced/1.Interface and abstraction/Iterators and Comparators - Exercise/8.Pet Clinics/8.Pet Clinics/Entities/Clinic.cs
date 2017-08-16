using System;
using System.Text;

namespace _8.Pet_Clinics.Entities
{
    public class Clinic
    {
        private int roomsNumber;
        private RoomsRegister roomsRegister;
        private int occupiedRooms;

        public Clinic(string name,int roomsNumber)
        {
            this.Name = name;
            this.RoomsNumber = roomsNumber;
            this.roomsRegister=new RoomsRegister(roomsNumber);
            this.occupiedRooms = 0;
        }

        public string Name { get; set; }
        public int RoomsNumber
        {
            get { return this.roomsNumber; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                this.roomsNumber = value;
            }
        }

        public bool TryAddPet(Pet currPet)
        {
            foreach (var room in this.roomsRegister)
            {
                if (this.roomsRegister[room] == null)
                {
                    this.roomsRegister[room] = currPet;
                    this.occupiedRooms++;
                    return true;
                }                
            }
            return false;

        }

        public bool TryReleasePet()
        {
            int centerRoom = this.RoomsNumber / 2;
            for (int index = 0; index < this.RoomsNumber; index++)
            {
                int curIndex = (centerRoom + index) % this.RoomsNumber;
                if (this.roomsRegister[curIndex] != null)
                {
                    this.roomsRegister[curIndex] = null;
                    this.occupiedRooms--;
                    return true;
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.RoomsNumber;
        }

        public string Print()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.RoomsNumber; i++)
            {
                sb.AppendLine(this.Print(i));
            }
            return sb.ToString().Trim();
        }

        public string Print(int room)
        {
            return this.roomsRegister[room]?.ToString() ??"Room empty";   
        }
    }
}
