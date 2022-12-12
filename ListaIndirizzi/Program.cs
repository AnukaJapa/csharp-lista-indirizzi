// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

StreamReader file = File.OpenText("C:\\Users\\anuka\\Desktop\\github\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    string[] array = riga.Split(",");

    if (array.Length == 6)
    {
        string name = array[0];
        string surname = array[1];
        string street = array[2];
        string city = array[3];
        string province = array[4];
        string zip = array[5];

        Indirizzo indirizzo = new Indirizzo(name, surname, street, city, province, zip);
        listaIndirizzi.Add(indirizzo);
    } else if (array.Length == 7)
    {
        string name = array[0];
        string middleName = array[1];
        string surname = array[2];
        string street = array[3];
        string city = array[4];
        string province = array[5];
        string zip = array[6];

        Indirizzo indirizzo = new Indirizzo(name, middleName, surname, street,city,province,zip);

        listaIndirizzi.Add(indirizzo);
    } else if (array.Length == 4){
        string name = array[0];
        string city = array[1];
        string province = array[2];
        string zip = array[3];

        Indirizzo indirizzo = new Indirizzo(name,city, province, zip);

        listaIndirizzi.Add(indirizzo);
    }


}
file.Close();

foreach (Indirizzo elemento in listaIndirizzi)
{
    Console.WriteLine(elemento.ToString());
} 
