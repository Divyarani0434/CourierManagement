// Write a  program that checks whether a given order is delivered or not based
// on its status (e.g., "Processing," "Delivered," "Cancelled"). Use if-else statements for this.
String status = "Delivered";
if (status == "Delivered")
{
    Console.WriteLine("The order has been delivered.");
}
else if (status == "Processing")
{
    Console.WriteLine("The order is still being processed.");
}
else if (status == "Cancelled")
{
    Console.WriteLine("The order has been cancelled.");
}
else
{
    Console.WriteLine("Invalid order status.");
}




//Implement a switch-case statement to categorize parcels based on their weight into "Light," "Medium," or "Heavy.
double parcelWeight = 4.5;

String category;

switch ((int)parcelWeight)
{
    case 0:
        category = "Light";
        break;
    case 1:
        category = "Light";
        break;
    case 2:
        category = "Light";
        break;
    case 3:
        category = "Medium";
        break;
    case 4:
        category = "Medium";
        break;
    case 5:
        category = "Medium";
        break;
    default:
        category = "Heavy";
        break;
}



Console.WriteLine("Parcel category: " + category);

//Implement User Authentication
// Create a login system for employees and customers using Java controlflow statements

String storedPassword = "hashed_password";
String enteredPassword;
Console.WriteLine("Enter your password: ");
enteredPassword = Console.ReadLine();
if (enteredPassword == storedPassword)

{
    Console.WriteLine("Authentication successful. Welcome!");
}
else
{
    Console.WriteLine("Authentication failed. Please try again.");
}


