// string[] names = {"Rowena", "Robin", "Bao"};

// foreach(string name in names){
//     Console.WriteLine(name);
// }

// Console.WriteLine("***********************");

// int[] inventory = {200, 450, 700, 175, 250};

// int result = 0;
// int bin = 0;

// foreach(int i in inventory){
//     result += i;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {i} items (Running total: {result})");
// }

// Console.WriteLine($"We have {result} items in inventory");

string[] orderId = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

string[] fraudOrders = new string[5];

int position = 0;

foreach(string order in orderId){
    if(order.StartsWith("B")){
       fraudOrders[position] = order;
       position++; 
    }
}

foreach(string order in fraudOrders){
    Console.WriteLine(order);
}