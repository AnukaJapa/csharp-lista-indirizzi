// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText("C:\\Users\\anuka\\Desktop\\github\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    string[] array = riga.Split(",");
    
   string name = array[0];
   string surname = array[1];
   string street = array[2];
   string city = array[3];  
   string province = array[4];
   string zip = array[5];

   Indirizzo indirizzo1 = new Indirizzo(name,surname,street,city, province,zip);

}
