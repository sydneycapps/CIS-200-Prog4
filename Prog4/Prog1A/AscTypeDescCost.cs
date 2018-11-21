// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D5236

// File: AscTypeDescCost.cs
// This class provides an IComparer for the Parcel class
// that orders the objects in ascending Parcel type and
// then descending cost order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    public class AscTypeDescCost : Comparer<Parcel>
    {
        // Precondition: None
        // Postcondition: Reverses natural parcel order by ascending Parcel type and then descending by cost
        //                When this < p2, method returns negative #
        //                When this == p2, method returns zero
        //                When this > p2, method returns postitive #
        public override int Compare(Parcel p1, Parcel p2)
        {
            string pType1 = p1.GetType().ToString(); // Declares p1 Parcel type
            string pType2 = p2.GetType().ToString(); // Declares p2 Parcel typ1

            if (p1 == null && p2 == null) // Both null?
                return 0;                 // Equal

            if (p1 == null) // Only p1 is null?
                return -1;  // null is less than any actual zip

            if (p2 == null) // Only p2 is null?
                return 1;   // Any actual zip is greater than null

            if (pType1.CompareTo(pType2) != 0)   // Different types?
                return pType1.CompareTo(pType2); // Use pType1 & pType2 to decide
            else
                return (-1) * p1.CalcCost().CompareTo(p2.CalcCost()); // Reverses natural order by cost after type
        }
    }
}
