// Condition Blocks

    // string username = "mustafaakipek";
    // string password = "12345";

    // if (username != "mustafaakipek") {
    //     Console.WriteLine("The username is wrong");
    // } else if (password != "12345") {
    //     Console.WriteLine("The password is wrong");
    // }
    // else {
    //     Console.WriteLine("The entry was successful");
    // }

// Switch

    // Console.Write("Please enter a number between 0-7: ");
    // int day = Convert.ToInt32(Console.ReadLine());

    // switch(day) {
    //     case 0:
    //         Console.WriteLine("Sunday");
    //         break;
    //     case 1:
    //         Console.WriteLine("Monday");
    //         break;
    //     case 2:
    //         Console.WriteLine("Tuesday");
    //         break;
    //     case 3:
    //         Console.WriteLine("Wednesday");
    //         break;
    //     case 4:
    //         Console.WriteLine("Thursday");
    //         break;
    //     case 5:
    //         Console.WriteLine("Friday");
    //         break;
    //     case 6:
    //         Console.WriteLine("Saturday");
    //         break;
        
    //     default:
    //         Console.WriteLine("The wrong day");
    //         break;
    // }

// Ternary

int number = -9;

var result = (number % 2 == 0) ?
                (number > 0) ? "the number is positive double":"the number is negative double":
                (number > 0) ? "the number is positive single":"the number is negative single";

Console.WriteLine(result);