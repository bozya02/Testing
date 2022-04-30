using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pharmacy;
using System.Collections.Generic;

namespace PharmacyTests
{
    [TestClass]
    public class PhatmacyTests
    {
        [TestMethod]
        public void GetMedicinesInPharamacyTest()
        {
            var med1 = new Medicine { Name = "нурофен", Price = 300, Producer = "Danone" };
            var med2 = new Medicine { Name = "ношпа", Price = 200, Producer = "Pharm" };
            var med3 = new Medicine { Name = "гексорал", Price = 100, Producer = "Danone" };

            var medicines = new List<Medicine> { med1, med2, med3 };



            var pharmacy = new PharmacyClass("Адресс") 
            {
                Medicines= new Dictionary<Medicine, int>()
                {
                    {med1, 10 },
                    {med2, 10 },
                    {med3, 10 },
                }
            };

            CollectionAssert.AreEqual(medicines, pharmacy.GetMedicinesInPaharmacy());
        }
        [TestMethod]
        public void GetMedicinesByNameTest()
        {
            var med1 = new Medicine { Name = "нурофен", Price = 300, Producer = "Danone" };
            var med2 = new Medicine { Name = "ношпа", Price = 200, Producer = "Pharm" };
            var med3 = new Medicine { Name = "гексорал", Price = 100, Producer = "Danone" };

            var medicines = new List<Medicine> { med1 };



            var pharmacy = new PharmacyClass("Адресс")
            {
                Medicines = new Dictionary<Medicine, int>()
                {
                    {med1, 10 },
                    {med2, 10 },
                    {med3, 10 },
                }
            };

            CollectionAssert.AreEqual(medicines, pharmacy.GetMedicinesByName("нурофен"));
        }
        [TestMethod]
        public void GetMedicinesByProducerTest()
        {
            var med1 = new Medicine { Name = "нурофен", Price = 300, Producer = "Danone" };
            var med2 = new Medicine { Name = "ношпа", Price = 200, Producer = "Pharm" };
            var med3 = new Medicine { Name = "гексорал", Price = 100, Producer = "Danone" };

            var medicines = new List<Medicine> { med1,  med3 };



            var pharmacy = new PharmacyClass("Адресс")
            {
                Medicines = new Dictionary<Medicine, int>()
                {
                    {med1, 10 },
                    {med2, 10 },
                    {med3, 10 },
                }
            };

            CollectionAssert.AreEqual(medicines, pharmacy.GetMedicinesByProducer("Danone"));
        }
        [TestMethod]
        public void GetSortedMedicines()
        {
            var med1 = new Medicine { Name = "нурофен", Price = 300, Producer = "Danone" };
            var med2 = new Medicine { Name = "ношпа", Price = 200, Producer = "Pharm" };
            var med3 = new Medicine { Name = "гексорал", Price = 100, Producer = "Danone" };

            var medicines = new List<Medicine> { med1, med2, med3 };



            var pharmacy = new PharmacyClass("Адресс")
            {
                Medicines = new Dictionary<Medicine, int>()
                {
                    {med1, 10 },
                    {med2, 10 },
                    {med3, 10 },
                }
            };

            CollectionAssert.AreEqual(medicines, pharmacy.GetSortedMedicines(true));
            medicines.Reverse();
            CollectionAssert.AreEqual(medicines, pharmacy.GetSortedMedicines());
        }
        [TestMethod]
        public void  GetMOstExpensiveTest()
        {
            var med1 = new Medicine { Name = "нурофен", Price = 300, Producer = "Danone" };
            var med2 = new Medicine { Name = "ношпа", Price = 200, Producer = "Pharm" };
            var med3 = new Medicine { Name = "гексорал", Price = 100, Producer = "Danone" };

            var medicine = med1;



            var pharmacy = new PharmacyClass("Адресс")
            {
                Medicines = new Dictionary<Medicine, int>()
                {
                    {med1, 10 },
                    {med2, 10 },
                    {med3, 10 },
                }
            };

            Assert.AreEqual(medicine, pharmacy.GetMostExponsiveMedicine());
        }
    }
}
