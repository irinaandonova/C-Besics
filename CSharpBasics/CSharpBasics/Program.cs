﻿using System;
using System.Buffers;
using System.Drawing;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Appliance
        {
            public string Color { get; set; }
            public string Room { get; set; }
            public string Owner;

            public Appliance(string owner)
            {
                Owner = owner;
            }

            public virtual void Use()
            {
                Console.WriteLine($"Appliance is in use");
            }
            public void Repair()
            {
                Console.WriteLine($"Applience is repaired");
            }
            public void InstallIntoRoom(string room)
            {
                Room = room;
            }
            public void SellApplience(string buyer)
            {
                Owner = buyer;
            }
        }
        //Inheritance
        public class Dishwasher : Appliance
        {
            public Dishwasher(string owner, string brand) : base(owner)
            {
                Brand = brand;
            }

            public int Capasity { get; }
            public string Brand { get; }
            //Overriding
            public override void Use()
            {
                Console.WriteLine("Dishwasher is washing dishes");
            }
            //Overloading
            public void Wash()
            {
                Console.WriteLine("Dishwasher is using self cleaning program");
            }
            public void Wash(uint dishes)
            {
                if(dishes == 0)
                    {
                    Console.WriteLine("Dishwasher is whaing a dish");
                    }
                else
                {
                    Console.WriteLine($"Dishwasher is washing {dishes}");

                }
            }
        }      
    }
}
