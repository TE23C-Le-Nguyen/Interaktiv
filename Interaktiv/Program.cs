
Console.WriteLine("You are at a local bar for a drink after an exhausting day. Bartender is asking for your order. Choose one of 2 oftion: Sweet or Not Sweet");
string name = Console.ReadLine();
name = name.ToLower();

if (name == "sweet")
{
       Console.WriteLine("Great choice Sir");
       Console.WriteLine("Would you like Strong or not Strong ");
       string banana = Console.ReadLine();
       banana = banana.ToLower();

       if (banana == "strong")
              Console.WriteLine("*Recieve Long Island Ice Tea*");
       else if (banana == "not strong")
       {
              Console.WriteLine("*Recieved Aviation*");
       }
}
else  
{
       Console.WriteLine("Understandable");
       Console.WriteLine("Would you like Strong or not Strong ");
       string sigma = Console.ReadLine();
       sigma = sigma.ToLower();
       if (sigma == "strong")
              Console.WriteLine("*Recieved Tequila*");
       else if (sigma == "not strong")
       {
              Console.WriteLine("*Recieved Manhattan*");
       }

}

Console.ReadLine();








// Console.WriteLine("Användanamn");
// string name = Console.ReadLine();
// name = name.ToLower();

// if (name == "nguyen" || name == "martin")
// {
//     Console.WriteLine("Välkommen!");
// //}
// else if (name == "martin")
// {
//     Console.WriteLine("Välkommen!");
// }
// else
// {
//         Console.WriteLine("FU");
// }

// Console.ReadLine();