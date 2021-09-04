using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace BankSafe.Tests
{
    [TestFixture]
	public class BankVaultTests
    {
        private BankVault vault;
        private Item item;
        
        [SetUp]
        public void Setup()
        {
            vault = new BankVault();
            item = new Item("me", "1");        
        }

        [Test]
        public void WhenCellDoesNotExist_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("no_such_cell", item);
            });

            //Exception ex = Assert.Throws<ArgumentException>(() => 
            //{
            //    vault.AddItem("no_such_cell", item);
            //});

            //Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void WhenCellIsAlreadyTaken_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.AddItem("A2", item); // add the item
                vault.AddItem("A2", new Item("Peter", "3")); // now the cell is already taken
            });

            Assert.AreEqual(ex.Message, "Cell is already taken!");
        }

        [Test]
        public void WhenItemIsAlreadyInCell_ShouldThrowException()
        {
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                vault.AddItem("A2", item); // add the item in cell A2
                vault.AddItem("B3", item); // now try to add the same item in cell B3
            });

            Assert.AreEqual(ex.Message, "Item is already in cell!");
        }

        [Test]
        public void WhenItemIsAddedSuccessfuly_ShouldReturnCorrectMessage()
        {
            string result = vault.AddItem("A2", item);

            Assert.AreEqual(result, $"Item:{item.ItemId} saved successfully!");
        }

        [Test]
        public void WhenItemIsAddedSuccessfuly_ShouldSetItemToCell()
        {
            vault.AddItem("A2", item);

            Assert.AreEqual(item, vault.VaultCells["A2"]);
        }


        [Test]
        public void WhenRemoveCalledAndCellDoesNotExist_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("no_such_cell", item);
            });

            //Exception ex = Assert.Throws<ArgumentException>(() =>
            //{
            //    vault.RemoveItem("no_such_cell", item);
            //});

            //Assert.AreEqual(ex.Message, "Cell doesn't exists!");
        }

        [Test]
        public void WhenRemoveCalledAndItemDoesNotExist_ShouldThrowException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() =>
            {
                vault.RemoveItem("A2", item);
            });

            Assert.AreEqual(ex.Message, "Item in that cell doesn't exists!");
        }

        [Test]
        public void WhenItemIsRemovedSuccessfuly_ShouldReturnCorrectMessage()
        {
            vault.AddItem("A2", item); // first add an item to cell A2 
            string result = vault.RemoveItem("A2", item); // remove the same item from cell A2

            Assert.AreEqual(result, $"Remove item:{item.ItemId} successfully!");
        }

        [Test]
        public void WhenItemIsRemovedSuccessfuly_ShouldSetTheCellToNull()
        {
            vault.AddItem("A2", item); // first add an item to cell A2
            vault.RemoveItem("A2", item); // remove the same item from cell A2

            Assert.AreEqual(null, vault.VaultCells["A2"]);
        }

        [Test]
        public void WhenVaultIsInitialized_ShouldHaveCorrectCells()
        {
            var initialValue = new Dictionary<string, Item>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };

            var initialValuesAsList = initialValue.ToImmutableDictionary().ToList();

            var vaultValuesAsList = vault.VaultCells.ToList();

            for (int i = 0; i < initialValuesAsList.Count; i++)
            {
                Assert.AreEqual(initialValuesAsList[i].Key, vaultValuesAsList[i].Key);
                Assert.AreEqual(initialValuesAsList[i].Value, vaultValuesAsList[i].Value);
            }
        }
    }
}