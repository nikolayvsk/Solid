using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    // Відповідь: Принцип єдиного обов'язку. Single responsibility principle
    class Item
    {

    }

    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get { return itemList; }

            set { itemList = value; }
        }
    }

    class OrderCalculate
    {
        public void CalculateTotalSum()
        {
            /*...*/
        }

        public void GetItemCount()
        {
            /*...*/
        }
    }

    class OrderManager
    {
        public void GetItems()
        {
            /*...*/
        }

        public void AddItem(Item item)
        {
            /*...*/
        }

        public void DeleteItem(Item item)
        {
            /*...*/
        }
    }

    class Printer
    {
        public void PrintOrder()
        {
            /*...*/
        }

        public void ShowOrder()
        {
            /*...*/
        }
    }

    class OrderManipulations
    {
        public void Load()
        {
            /*...*/
        }

        public void Save()
        {
            /*...*/
        }

        public void Update()
        {
            /*...*/
        }

        public void Delete()
        {
            /*...*/
        }
    }
}

class Program
    {
        static void Main()
        {
        }
    }
}
