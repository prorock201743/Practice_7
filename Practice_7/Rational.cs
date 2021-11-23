using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    class Rational : Pair
    {
        public Rational(int first, int second) : base(first, second)
        {
            First = first;
            Second = second;
        }
        public static Rational operator +(Rational firstrational, Rational secondrational) => new Rational(

            (firstrational.First * secondrational.Second) + (firstrational.Second * secondrational.First),
            firstrational.Second * secondrational.Second
            );
        public static Rational operator /(Rational firstrational, Rational secondrational) => new Rational(

            firstrational.First * secondrational.Second,
            firstrational.Second * secondrational.First
            );
        public static Rational operator -(Rational firstrational, Rational secondrational) => new Rational(

          (firstrational.First * secondrational.Second) - (firstrational.Second * secondrational.First),
          firstrational.Second * secondrational.Second
          );

        public static string ToString(Rational rational)
        {
            return $"({rational.First}), ({rational.Second})";
        }
    }
}
