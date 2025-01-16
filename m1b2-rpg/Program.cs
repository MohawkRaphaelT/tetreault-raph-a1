// Get player name, remember it
Console.WriteLine("Hello traveller! What is your name?");
string playerName = Console.ReadLine();

// Get player gold
Console.WriteLine("How much gold do you have?");
int goldAmount = int.Parse(Console.ReadLine());

//
Console.WriteLine("We have your bronze sword ready. That will be 15 gold.");
if (goldAmount >= 15)
{
    Console.WriteLine($"Thank you for your purchase!");
    // Deduct gold
    goldAmount -= 15;
    // Update player on gold count
    Console.WriteLine($"You have {goldAmount} gold left.");
}
else
{
    Console.WriteLine($"{playerName}, you don't have enough gold!");
}