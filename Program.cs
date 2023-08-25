Console.WriteLine("Iveskite 3 skirtingus skaicius: ");
float number = Convert.ToSingle(Console.ReadLine());
float number2 = Convert.ToSingle(Console.ReadLine());
float number3 = Convert.ToSingle(Console.ReadLine());

if ((number + number2) >= number3 &&
   (number + number3) >= number2 &&
   (number2 + number3) >= number)
{
    Console.WriteLine("Galima sudaryti trikampį");
}
else
{
    Console.WriteLine("Negalima sudaryti trikampio");
}