// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D5236

// File: TestParcels.cs
// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Ivy Cat", "1234 Catnip St.",
                "Meowville", "KY", 56789); // Test Address 5
            Address a6 = new Address("Mia Dog", "9876 Bone St.",
                "Growlsville", "NY", 78463); // Test Address 6
            Address a7 = new Address("Rex Paw", "321 Treats Blvd.", "Apt. 6",
                "Barksville", "TN", 31254); // Test Address 7
            Address a8 = new Address("Athena Slithers", "587 Snake Rd.", "Apt. 23",
                "Hissington", "LA", 87436); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M); // Test Letter 1
            Letter letter2 = new Letter(a5, a6, 5M);    // Test Letter 2
            Letter letter3 = new Letter(a8, a7, 2.50M); // Test Letter 3
            Letter letter4 = new Letter(a6, a8, 4M);    // Test Letter 4

            GroundPackage gp1 = new GroundPackage(a2, a1, 5, 6, 7, 8);      // Test GroundPackage 1
            GroundPackage gp2 = new GroundPackage(a4, a2, 75, 75, 75, 50);  // Test GroundPackage 2
            GroundPackage gp3 = new GroundPackage(a3, a4, 14, 10, 5, 12.5); // Test GroundPackage 3
            GroundPackage gp4 = new GroundPackage(a5, a8, 20, 30, 30, 45);  // Test GroundPackage 4

            NextDayAirPackage ndap1 = new NextDayAirPackage(a4, a3, 50, 50, 50, 25, 10);  // Test NextDayAirPackage 1
            NextDayAirPackage ndap2 = new NextDayAirPackage(a1, a3, 25, 25, 25, 100, 8);  // Test NextDayAirPackage 2
            NextDayAirPackage ndap3 = new NextDayAirPackage(a2, a4, 50, 50, 50, 100, 15); // Test NextDayAirPackage 3
            NextDayAirPackage ndap4 = new NextDayAirPackage(a1, a3, 25, 15, 15,           // Test NextDayAirPackage 4
                85, 7.50M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a3, a2, 50, 25, 50, 30,   // Test TwoDayAirPackage 1
                TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a4, a1, 10, 10, 10, 10,   // Test TwoDayAirPackage 2
                TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Test TwoDayAirPackage 3
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap4 = new TwoDayAirPackage(a7, a6, 50, 75, 60, 80,   // Test TwoDayAirPackage 4
                TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(letter4);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(gp4);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(ndap4);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);
            parcels.Add(tdap4);

            Console.Out.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(); // Sort - ascending by cost
            Console.Out.WriteLine("Sorted List (ascending by cost):"); 
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new DescendingZip()); // Sort - descending by destination zip using specified Comparer
            Console.Out.WriteLine("Sorted List (descending by destination zip):"); 
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            parcels.Sort(new AscTypeDescCost()); // Sort - ascending by type then descending by cost using specified Comparer
            Console.Out.WriteLine("Sorted List (ascending by type then descending by cost):"); 
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();
        }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
