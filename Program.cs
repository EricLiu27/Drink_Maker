Soda Coke = new Soda("Coke", "black", 36, 150, false);
Coffee Black = new Coffee("Black", "black", 100, 50, "dark", "coffee beans");
Wine DontKnowAlotAboutWine = new Wine("Huh", "red", 75, 200, "Across seas", 1875);

List<Drink> AllDrinks = new List<Drink>();
AllDrinks.Add(Coke);
AllDrinks.Add(Black);
AllDrinks.Add(DontKnowAlotAboutWine);

foreach (Drink drinks in AllDrinks)
{
    drinks.ShowDrink();
}