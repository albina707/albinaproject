
        Console.WriteLine("exc 1:");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());

        if (a1 == b1)
        {
            Console.WriteLine("the numbers are equal");
        }
        else if (a1 > b1)
        {
            Console.WriteLine("the first number is greater than the second");
        }
        else
        {
            Console.WriteLine("the first number is less than the second");
        }


        Console.WriteLine("exc 2:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 5 && number < 10)
        {
            Console.WriteLine("the number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("unknown number");
        }


        
        Console.WriteLine("exc 3:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number2 == 5 || number2 == 10)
        {
            Console.WriteLine("the number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("unknown number");
        }


       
        Console.WriteLine("exc 4:");
        double deposit = Convert.ToDouble(Console.ReadLine());

        if (deposit < 100)
        {
            deposit = deposit + deposit * 0.05;
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            deposit = deposit + deposit * 0.07;
        }
        else
        {
            deposit = deposit + deposit * 0.10;
        }

        Console.WriteLine(deposit);


        
        Console.WriteLine("exc 5:");
        double deposit2 = Convert.ToDouble(Console.ReadLine());

        if (deposit2 < 100)
        {
            deposit2 = deposit2 + deposit2 * 0.05;
        }
        else if (deposit2 >= 100 && deposit2 <= 200)
        {
            deposit2 = deposit2 + deposit2 * 0.07;
        }
        else
        {
            deposit2 = deposit2 + deposit2 * 0.10;
        }

        deposit2 = deposit2 + 15;
        Console.WriteLine(deposit2);


        
        Console.WriteLine("exc 6:");
        Console.WriteLine("pls write operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                {
                    Console.WriteLine("Addition");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Subtraction");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Multiplication");
                    break;
                }
            default:
                {
                    Console.WriteLine("Operation is undefined");
                    break;
                }
        }


        
        Console.WriteLine("exc 7:");
        Console.WriteLine("pls write operation number: 1.Addition 2.Subtraction 3.Multiplication");

        int op = Convert.ToInt32(Console.ReadLine());
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case 1:
                {
                    Console.WriteLine(x + y);
                    break;
                }
            case 2:
                {
                    Console.WriteLine(x - y);
                    break;
                }
            case 3:
                {
                    Console.WriteLine(x * y);
                    break;
                }
            default:
                {
                    Console.WriteLine("operation is undefined");
                    break;
                }
        }
