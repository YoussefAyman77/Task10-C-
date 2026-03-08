using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class DatatypeOperations
    {
        public static void Transform(List<string> arr, Func<string, string> Transformer)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = Transformer(arr[i]);
            }
        }
        public static int TransformInt(int a, int b, Func<int, int, int> Transformer)
        {
            return Transformer(a, b);
        }
        public static List<R> TransformGen<T, R>(List<T> arr, Func<T, R> Transformer)
        {
            List<R> ret = new List<R>();
            for (int i = 0; i < arr.Count; i++)
            {
                ret.Add(Transformer(arr[i]));
            }
            return ret;
        }
        public static void TransformPritner<T>(List<T> arr, Action<T> Transformer)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Transformer(arr[i]);
            }
        }
        public static List<T> TransformE<T>(List<T> arr, Predicate<T> Transformer)
        {
            List<T> ret = new List<T>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (Transformer(arr[i]))
                    ret.Add(arr[i]);
            }
            return ret;
        }

    }
}
