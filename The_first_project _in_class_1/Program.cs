
//  פונקציה שאחראית לבחירת הפעולה 
List<int> my_list = new List<int> { 1, 2, 3, 4, 5 };
static void menu(List<int> my_list)
{
    Console.WriteLine("choice 1 or 2 or 3or 4 or5 or6 or 7 or 8 or 9 or 10");
    bool my_bool = true;
    while (my_bool == true)
    {
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Replacing_the_list(my_list);
                break;
            case 2:
                BBB();
                break;
            case 3:
                CCC();
                break;
            case 4:
                DDD();
                break;
            case 5:
                EEE();
                break;
            case 6:
                FFF();
                break;
            case 7:
                GGG();
                break;
            case 8:
                HHH();
                break;
            case 9:
                III();
                break;
            case 10:
                my_bool = false;
                Console.WriteLine("Exit");
                break;
        }
    }

    static void Replacing_the_list(List<int> my_list) // Replacing the list with a new list
    {
        for (int i = 0; i < my_list.Count; i++)
        {
            my_list[i] = my_list[i] +1;
            Console.WriteLine(my_list[i]);
        }
        
    }


    static void BBB()
    {
        Console.WriteLine("this bbb");
    }

    static void CCC()
    {
        Console.WriteLine("this ccc");
    }

    static void DDD()
    {
        Console.WriteLine("this ddd");
    }

    static void EEE()
    {
        Console.WriteLine("this eee");
    }

    static void FFF()
    {
        Console.WriteLine("this fff");
    }

    static void GGG()
    {
        Console.WriteLine("this ggg");
    }

    static void HHH()
    {
        Console.WriteLine("this hhh");
    }

    static void III()
    {
        Console.WriteLine("this iii");
    }
}
menu(my_list);