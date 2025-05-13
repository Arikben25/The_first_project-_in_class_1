
//  פונקציה שאחראית לבחירת הפעולה 
using System.Collections.Generic;

List<int> my_list = new List<int> { 2,1,3,4,5,6 };

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
                List_display(my_list);
                break;
            case 3:
                Display_a_list_in_reverse_order(my_list);
                break;
            case 4:
                sort_list(my_list);
                break;
            case 5:
                max_num_in_list(my_list);
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

    static void Replacing_the_list(List<int> list) // Replacing the list with a new list
    {
        list = new List<int> { 11, 22, 33, 44 };
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine(list);
    }


    static void List_display(List<int> my_list)
    {
        foreach (int i in my_list)
        {
            Console.WriteLine(i);
        }
    }

    static void Display_a_list_in_reverse_order(List<int>list)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(list[i]);
        }

    }

    static void sort_list(List<int>list)
    {
        list.Sort();
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }

    static void max_num_in_list(List<int> list)
    {
        list.Sort();
        Console.WriteLine(list[list.Count-1]);
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

