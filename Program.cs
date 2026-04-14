using fourteenthtry;
PizzaOrder pizzaOrder = new PizzaOrder(
    name: "Felichita",
    price: 150,
    quantity: 2,
    size: "Large"
);

PizzaOrder pizzaOrder2 = new PizzaOrder(
    name: "Margarita",
    price: 130,
    quantity: 3,
    size: "Medium"
);
//
SushiOrder sushiOrder = new SushiOrder(
    name: "Nagasaki",
    price: 15,
    quantity: 3,
    sets: 4
);
//
HealtyOrder healtyOrder = new HealtyOrder(
    name: "Salad",
    price: 8,
    quantity: 1,
    moreMoney: "Extra Dressing"
);

List<FoodOrder> orders = new List<FoodOrder>()
{
    pizzaOrder,
    pizzaOrder2,
    sushiOrder,
    healtyOrder
};


int max = orders.Max(order => order.GetPrice);

foreach (var order in orders)
{
    Console.WriteLine("=================================");
    order.GetInfo();
    if(order.GetPrice == max)
        Console.WriteLine("Це замовлення має максимальну цiну!");
    Console.WriteLine("---------------");
    order.CalculateTotalPrice();
    Console.WriteLine("---------------");
    order.GetDeliveryTime();

    Console.WriteLine("=================================");
}



Console.WriteLine("Максимальна цiна: " + max);

double average = orders.Average(order => order.GetPrice);
Console.WriteLine("Середня цiна: " + average);