int age;

Console.WriteLine("Entrez votre âge :");
string input = Console.ReadLine();

if (int.TryParse(input, out age))  
{
    if (age < 15)
    {
        Console.WriteLine("Il a moins de 15 ans.");
    }
    else if (age >= 18 && age <= 30)
    {
        Console.WriteLine("Il a entre 18 et 30 ans.");
    }
    else if (age > 45)
    {
        Console.WriteLine("Il a plus de 45 ans.");
    }
    else if (age < 18)
    {
        Console.WriteLine("Il a moins de 18 ans.");
    }
    else if (age > 20)
    {
        Console.WriteLine("Il a plus de 20 ans.");
    }
    else
    {
        Console.WriteLine("Il a moins de 20 ans.");
    }
}
else
{
    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier.");
}
