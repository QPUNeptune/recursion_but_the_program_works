using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

 namespace recursion_but_the_program_works
 {
 	public class recursion
 	{
        public double geometric_progression_percentage_positive_growth(double u1, double r, ulong n)
        {
            return u1*Math.Pow((r/100)+1, n);
        }
        public double geometric_progression_percentage_negative_growth(double u1, double r, ulong n)
        {
            return u1*Math.Pow(1-(r/100), n);
        }
        public double geometric_progression(double u1, double r, ulong n)
        {
            return u1*Math.Pow(r, n-1);
        }
        public double arithmetic_progression(double u1, double r, ulong n)
        {
            return u1+((n-1)*r);
        }
 	}
 }