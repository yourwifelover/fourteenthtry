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

pizzaOrder.CalculateTotalPrice();
pizzaOrder.GetDeliveryTime();
pizzaOrder2.CalculateTotalPrice();
pizzaOrder2.GetDeliveryTime();

sushiOrder.CalculateTotalPrice();
sushiOrder.GetDeliveryTime();

healtyOrder.CalculateTotalPrice();
healtyOrder.GetDeliveryTime();

