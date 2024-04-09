// temp<= freesing cold
// temp>o AND temp <=10 - cold
// temp>10 ANG temo <=15 chilly
// t >15 and >20 - Warm
// t>20 and <30 - hot
// t > 30 -boiling hot

Console.WriteLine("Sisesta temperatuur:");
int temp = Int32.Parse(Console.ReadLine());

if(temp>30)
{ Console.WriteLine("Kuum"); }
else if(temp<=30&&temp>20)
{
    Console.WriteLine("Paras");
}
else if(temp<=20&&temp>0)
{
    Console.WriteLine("külm");
}