using System;
using System.Collections.Generic;
using System.Numerics;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Remove(3);
            var count = list.Count;

        }
    }
    //public static T Add<T>(T num1, T num2) where T : INumber<T>
    //{
    //    return num1 + num2;
    //}
    public class GenericList<T>
    {
        private readonly List<T> _items = new();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public int Count => _items.Count;
    }
}
