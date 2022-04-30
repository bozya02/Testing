using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Pharmacy
{
    public class PharmacyClass
    {
        public string Address { get; set; }
        public Dictionary<Medicine, int> Medicines { get; set; }
        public PharmacyClass(string address)
        {
            Address = address;
            Medicines = new Dictionary<Medicine, int>();
        }

        public List<Medicine> GetMedicinesByName(string name)
        {
            return Medicines.Keys.Cast<Medicine>().Where(x=> x.Name == name).ToList();
        }
        public List<Medicine> GetMedicinesByProducer(string producer)
        {
            return Medicines.Keys.Cast<Medicine>().Where(x=> x.Producer == producer).ToList();
        }
        public Medicine GetMostExponsiveMedicine()
        {
            return Medicines.Keys.Where(x=> x.Price== Medicines.Keys.Max(x=> x.Price)).FirstOrDefault();
        }
        public List<Medicine> GetSortedMedicines(bool desc = false)
        {
            var medicines = Medicines.Keys.OrderBy(x => x.Price).ToList();

            if (desc)
                medicines.Reverse();

            return medicines;
        }
        public List<Medicine> GetMedicinesInPaharmacy()
        {
            return Medicines.Keys.ToList();
        }
    }
}
