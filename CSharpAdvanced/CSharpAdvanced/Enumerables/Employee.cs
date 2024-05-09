using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerables
{
    public class Employee : IEnumerable<PayItem>
    {
        private readonly List<PayItem> _payItems = new();
        public string Name { get; set; }
        public void AddPayItem(string name, int value)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            _payItems.Add(new PayItem { Name = name, Value = value });
        }
        public PayItem this[int index]
        {
            get => _payItems[index];
        }
        //It can be called without a loop
        //public IEnumerator<PayItem> GetPayItems()
        //{
        //    Console.WriteLine("GetPayItems called");
        //    return _payItems.GetEnumerator();
        //}
        //Function that contains yield doesn't already called until there is a loop 
        public IEnumerator<PayItem> GetEnumerator()
        {
            //Console.WriteLine("GetEnumerator called");

            foreach (var payItem in _payItems)
            {
                yield return payItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
