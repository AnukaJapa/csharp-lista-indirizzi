using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {
        string name;
        string surname;
        string street;
        string city;
        string province;
        string zip;

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        //GETTERS

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return city;
        }
        public string GetProvince()
        {
            return this.province;
        }

        public string GetZip()
        {
            return this.zip;
        }
        //SETTERS
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

        public void SetProvince(string province)
        {
            this.province = province;
        }

        public void SetZip(string zip)
        {
            this.zip = zip;
        }

        //override
        public override string ToString()
        {
            string descrizione = $@"
          name: {this.name}
          surname: {this.surname}
          street: {this.street}
          city: {this.city}
          province: {this.province}
          zip: {this.zip}
";

            return descrizione;
        }
      

    }



}
