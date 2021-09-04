using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Enums;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private List<IBakedFood> bakedFoods;
        private List<IDrink> drinks;
        private List<ITable> tables;

        private decimal totalIncome = 0;

        public Controller()
        {
            this.bakedFoods = new List<IBakedFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
        }
        
        public string AddDrink(string type, string name, int portion, string brand)
        {
            if (type == "Tea")
            {
                this.drinks.Add(new Tea(name, portion, brand));
            }

            if (type == "Water")
            {
                this.drinks.Add(new Water(name, portion, brand));
            }
            
            return $"Added {name} ({brand}) to the drink menu";
        }

        // e.g. Bread White 2.90
        public string AddFood(string type, string name, decimal price)
        {
            if (type == "Bread")
            {
                this.bakedFoods.Add(new Bread(name, price));
            }

            if (type == "Cake")
            {
                this.bakedFoods.Add(new Cake(name, price));
            }

            return $"Added {name} ({type}) to the menu";
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            //if (type == "InsideTable")
            if (type == TableType.InsideTable.ToString())
            {
                this.tables.Add(new InsideTable(tableNumber, capacity));
            }

            //if (type == "OutsideTable")
            if (type == TableType.OutsideTable.ToString())
            {
                this.tables.Add(new OutsideTable(tableNumber, capacity));
            }
            
            return $"Added table number {tableNumber} in the bakery";
        }

        public string GetFreeTablesInfo()
        {
            StringBuilder sb = new StringBuilder();
            
            List<ITable> freeTables =  tables.Where(t => !t.IsReserved).ToList();

            foreach (ITable table in freeTables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            //return $"Total income: {totalIncome:f2}lv"
            return string.Format(OutputMessages.TotalIncome, totalIncome);
        }

        public string LeaveTable(int tableNumber)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            decimal bill = table.GetBill() + table.Price;
            totalIncome += bill; // IMPORTANT
            table.Clear();

            return $"Table: {tableNumber}\r\n" + 
                $"Bill: {bill:f2}";
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            if (table == null)
            {
                //return $"Could not find table {tableNumber}";               
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            IDrink drink = drinks.FirstOrDefault(d => d.Name == drinkName && d.Brand == drinkBrand);

            if (drink == null)
            {
                //return $"There is no {drinkName} {drinkBrand} available";
                return string.Format(OutputMessages.NonExistentDrink, drinkName, drinkBrand);
            }

            table.OrderDrink(drink);

            return $"Table {tableNumber} ordered {drinkName} {drinkBrand}";           
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            ITable table = tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            
            if (table == null)
            {
                //return $"Could not find table {tableNumber}";               
                return string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }

            IBakedFood food = bakedFoods.FirstOrDefault(f => f.Name == foodName);

            if (food == null)
            {
                //return $"No {foodName} in the menu";
                return string.Format(OutputMessages.NonExistentFood, foodName);
            }

            table.OrderFood(food);

            //return $"Table {tableNumber} ordered {foodName}";
            return string.Format(OutputMessages.FoodOrderSuccessful, tableNumber, foodName);
        }

        public string ReserveTable(int numberOfPeople)
        {
            ITable table = tables.FirstOrDefault(t => !t.IsReserved && t.Capacity >= numberOfPeople);
            
            if (table == null)
            {
                return $"No available table for {numberOfPeople} people";
            }
            else
            {
                table.Reserve(numberOfPeople);
                return $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
            }
        }
    }
}
