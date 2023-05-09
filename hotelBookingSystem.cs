﻿Console.WriteLine("Welcome to Hotel Booking System!\n" );

Console.WriteLine("Menu: ");
Console.WriteLine("1. Book a hotel room");
Console.WriteLine("2. View hotel rooms");
Console.WriteLine("3. Exit");

System.Console.Write("Enter the number (1-3): ");
string? selectedMenu = Console.ReadLine();

switch(selectedMenu) {
    case "1":
        System.Console.WriteLine("\nAvailable Hotel Rooms: ");

        for (int i = 100; i <= 110; i++) System.Console.Write(" " + i + " ");

        System.Console.Write("\nEnter the room number: ");
        string? roomNumber = Console.ReadLine();

        System.Console.WriteLine("\nYou have successfully booked Room " + roomNumber + "!");

    break;
    
    case "2":
        System.Console.WriteLine("\nHotel Rooms: ");

        for (int i = 100; i <= 110; i++) System.Console.Write(" " + i + " ");

    break;

    case "3":
        System.Console.WriteLine("\nThank you for using Hotel Booking System!");
    break;

    default:
        System.Console.WriteLine("\n Invalid number! Please try again.\n");

        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Book a hotel room");
        Console.WriteLine("2. View available rooms");
        Console.WriteLine("3. Exit");

        System.Console.Write("Enter the number (1-3): ");
        selectedMenu = Console.ReadLine();
    break;
}