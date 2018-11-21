// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D5236

// File: DescendingZip.cs
// This class provides an IComparer for the Parcel class
// that orders the objects in descending destination zip order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class DescendingZip : Comparer<Parcel>
    {
        // Precondition: None
        // Postcondition: Reverses natural parcel order by destination address zip
        //                When this < p2, method returns negative #
        //                When this == p2, method returns zero
        //                When this > p2, method returns postitive #
        public override int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null) // Both null?
                return 0;                 // Equal

            if (p1 == null) // Only p1 is null?
                return -1;  // null is less than any actual zip

            if (p2 == null) // Only p2 is null?
                return 1;   // Any actual zip is greater than null

            return (-1) * p1.DestinationAddress.Zip.CompareTo(p2.DestinationAddress.Zip); // Reverses natural order
        }
    }
}
