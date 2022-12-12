using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        private string Name;
        private string Surname;
        private string Street;
        private string City;
        private string Province;
        private string Zip;

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetSurname()
        {
            return this.Surname;
        }

        public string GetStreet()
        {
            return this.Street;
        }

        public string GetCity()
        {
            return this.City;
        }

        public string GetProvince()
        {
            return this.Province;
        }

        public string GetZip()
        {
            return this.Zip;
        }

        public void SetName(string Name)
        {
            if (this.Name == "undefined")
            {
                this.Name = Name;
            }
        }

        public void SetSurname(string Surname)
        {
            if (this.Surname == "undefined")
            {
                this.Surname = Surname;
            }
        }

        public void SetStreet(string Street)
        {
            if (this.Street == "undefined")
            {
                this.Street = Street;
            }
        }

        public void SetCity(string City)
        {
            if (this.City == "undefined")
            {
                this.City = City;
            }
        }

        public void SetProvince(string Province)
        {
            if (this.Province == "undefined")
            {
                this.Province = Province;
            }
        }

        public void SetZip(string Zip)
        {
            if (this.Zip == "undefined")
            {
                this.Zip = Zip;
            }
        }

        public override string ToString()
        {
            return "\n\n----- "
                   + this.GetName()
                   + " " 
                   + this.GetSurname() 
                   + " -----\n\nStrada: " 
                   + this.GetStreet() 
                   + "\nCittà: " 
                   + this.GetCity() 
                   + "\nProvincia: " 
                   + this.GetProvince() 
                   + "\nZip: " 
                   + this.GetZip();
        }

    }
}
