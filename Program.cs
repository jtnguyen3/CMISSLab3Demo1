Console.Clear();
System.Console.WriteLine("Welcome to the Spring Break Planner!");
Menu();

static void Menu()
{
    string vibe = GetSpringBreakVibe();
    while (vibe.ToUpper() != "EXIT")
    {
        string destination = GetDestinationRecommendation(vibe);
        string activity = GetActivityRecommendation(destination);
        System.Console.WriteLine(DisplaySpringBreakDetails(vibe, destination, activity));
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        vibe = GetSpringBreakVibe();
    }
}

static string GetSpringBreakVibe()
{
    System.Console.WriteLine("What kind of vibe do you want for your trip?");
    System.Console.WriteLine("(Relaxing, Adventurous, Party, Luxurious)\n\"EXIT\" to exit.");
    string userInput = Console.ReadLine();
    return userInput;
}

static string GetDestinationRecommendation(string vibe)
{
    switch (vibe.ToUpper())
    {
        case "RELAXING":
            return "Maldives Beach Resort";
        case "ADVENTUROUS":
            return "Rocky Mountain National Park";
        case "PARTY":
            return "Miami, FL";
        case "LUXURIOUS":
            return "Monte Carlo, Monaco";
        default:
            return "SOMETHING WENT REALLY WRONG...";
    }
}

static string GetActivityRecommendation(string destination)
{
    switch (destination)
    {
        case "Maldives Beach Resort":
            return "Sunset Yoga on the Beach";
        case "Rocky Mountain National Park":
            return "Hiking to Emerald Lake";
        case "Miami, FL":
            return "Nightlife at South Beach";
        case "Monte Carlo, Monaco":
            return "Yacht Cruise along the Riviera";
        default:
            return "SOMETHING BAD";
    }
}

static string DisplaySpringBreakDetails(string vibe, string destination, string activity)
{
    return $"Based off of your desired vibe of \"{vibe}\", I recommend going to {destination} and (a) {activity}";
}