using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorsAndCasts
{
    public struct Vector
    {
        public double x, y, z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector(Vector rhs)
        {
            x = rhs.x;
            y = rhs.y;
            z = rhs.z;
        }

        public override string ToString()
        {
            return "( " + x + " , " + y + " , " + z + " )";
        }

        public override bool Equals(object obj)
        {
            return this == (Vector)obj;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        public static Vector operator +(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.x += rhs.x;
            result.y += rhs.y;
            result.z += rhs.z;

            return result;
        }
        public static double operator *(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            return (result.x * rhs.x) + (result.y * rhs.y) + (result.z * rhs.z);
        }
        public static Vector operator *(int value, Vector vect)
        {

            vect.x *= value;
            vect.y *= value;
            vect.z *= value;

            return vect;
        }
        public static Vector operator *(Vector vect, int value)
        {
            return value * vect;
        }

        public static bool operator ==(Vector vec1, Vector vec2)
        {
            return vec1.x == vec2.x && vec1.y == vec2.y && vec1.z == vec2.z;
        }
        public static bool operator !=(Vector vec1, Vector vec2)
        {
            return vec1.x != vec2.x || vec1.y != vec2.y || vec1.z != vec2.z;
        }
        // Write your operator overloads here...
    }
}
