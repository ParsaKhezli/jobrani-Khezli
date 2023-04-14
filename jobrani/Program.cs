
using jobrani.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

string adress1 = @"E:/orders.csv";
string adress2 = @"E:/ODD.csv";
string adress3 = @"E:/prime.csv";
string adress4 = @"E:/mirror.csv";

StreamReader sr = new StreamReader(adress1);
StreamWriter sw = new StreamWriter(adress2);
StreamWriter sw2 = new StreamWriter(adress3);
StreamWriter sw3 = new StreamWriter(adress4);


string line;
int Calculationodd(int ID_Customer) 
{
    int ID_Customer = 0;
    int x = ID_Customer;
    int y = x % 2;
    line = sr.ReadLine();
      if (y != 0)
    {
        sw.WriteLine(line);
    }
}
    int mirror(int ID_Customer)
{
    int x = ID_Customer;

    int reversedx = 0;
    int originalx = x;

    while(x >0)
    {
        int digit = x % 10;
        reversedx = (reversedx * 10) + digit;
        x/= 10;

    }
    if (reversedx == originalx)
    {
        sw2.Write(line);
    }


}



int Isprime(int ID_Customer)
{
    int x = (ID_Customer);
    for (int i = 0; i < x; i++)
    {
        if (x % i == 0)
        { break; }

        return i;
    }
    sw3 = new StreamWriter(adress3);
}
class  Data
{
    public int ID_Customer { get; set; }
    
    public string adress1 { get; set; }

    public Data(string adress1)
    {
        this.adress1 = adress1;
    }
    public string adress2 { get; set; }
    
    public string adress3 { get; set;}
    public string adress4 { get; set;}
}





    



//class Odd 
//{
//    public void odd()
//    {
//        int x = ID_Customer;
        
        
//        int y = x % 2 ;


//        if (y != 0) 
//        {
//            StreamReader sr = new StreamReader(adress1);
//            StreamWriter sw = new StreamWriter(adress2);




//        }
//    }
//}



