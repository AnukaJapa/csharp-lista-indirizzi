using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {
        string name;
        string middleName;
        string surname;
        string street;
        string city;
        string province;
        string zip;

        public Indirizzo(string name, string city, string province, string zip)
        {

            this.name = name;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {

            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }

        public Indirizzo(string name, string middleName, string surname, string street, string city, string province, string zip)
        {
            this.name = name;
            this.middleName = middleName;
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
        public string GetMiddleName()
        {
            return this.middleName;
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
        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
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
            string descr = $@"
          name: {this.name}";
if(this.middleName == null) 
            { 
            }else
            {
                descr += $@"
          middleName:{this.middleName}";

            }

if (this.surname == null)
            {
            } else
            {
                descr += $@"
          surname:{this.surname}";
            }

if(this.street == null)
            {
            }else
            {
            descr += $@"
          street:{this.street}";

            }

            descr+= $@"
          city: {IsEmpty(this.city)}
          province: {IsEmpty(this.province)}
          zip: {IsEmpty(this.zip)}
";
           
            return descr;
        }
      
        //private methods

        private string IsEmpty(string value)
        {
            if(value == "" || value == null)
            {
                return "is not indicated";
            } else
            {
                return value;
            }
        }
    }



}
