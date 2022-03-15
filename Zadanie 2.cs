// See https://aka.ms/new-console-template for more information



menu:
Console.Clear();
Console.WriteLine("Kalkulator figur geometrycznych. Wybierz co chcesz obliczyć :\n");
Console.WriteLine("[1]. Objętość prostopadłościanu");
Console.WriteLine("[2]. Pole koła");
Console.WriteLine("[3]. Objętość stożka");
Console.WriteLine("[4]. Pole trójkąta");
Console.WriteLine("[5]. Wyjście");

int menu = Convert.ToInt32(Console.ReadLine());


switch (menu)
{
    case 1:
        Console.Clear();
        Console.WriteLine("Podaj pierwszy bok prostopadłościanu :");
        double perwszyBokProstopad = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj drugi bok prostopadłościanu :");
        double drugiBokProstopad = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wysokość prostopadłościanu :");
        double wysokoscProstopad = double.Parse(Console.ReadLine());

        double wynikProstopad = perwszyBokProstopad * drugiBokProstopad * wysokoscProstopad;
        Console.WriteLine("Objętość prostopadłościanu wynosi : {0}", wynikProstopad);
        Console.WriteLine("Wciśnij obojętnie jaki przycisk, aby wrócić do menu :");
        Console.ReadKey();
        goto menu;
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("Podaj promień koła :");
        double promienKola = double.Parse(Console.ReadLine());

        double wynikKola = 3.14 * (promienKola * promienKola);
        Console.WriteLine("Pole koła wynosi : {0}", wynikKola);

        Console.WriteLine("Wciśnij obojętnie jaki przycisk, aby wrócić do menu :");
        Console.ReadKey();
        goto menu;
        break;

    case 3:
        Console.Clear();
        Console.WriteLine("Podaj promień stożka :");
        double promienStozka = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wysokość stożka :");
        double wysokoscStozka = double.Parse(Console.ReadLine());

        double wynikStozka = 1/3d * 3.14d * (promienStozka * promienStozka) * wysokoscStozka;
        Console.WriteLine("Objętość stożka wynosi : {0}", wynikStozka);

        Console.WriteLine("Wciśnij obojętnie jaki przycisk, aby wrócić do menu :");
        Console.ReadKey();
        goto menu;
        break;

    case 4:
        Console.Clear();
        Console.WriteLine("Podaj bok trójkąta :");
        double bokTrojkata = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wysokość trójkąta :");
        double wysokoscTrojkata = int.Parse(Console.ReadLine());

        double wynikTrojkata = 1 / 2d * bokTrojkata * wysokoscTrojkata;
        Console.WriteLine("Pole trójkąta wynosi : {0}", wynikTrojkata);


        Console.WriteLine("Wciśnij obojętnie jaki przycisk, aby wrócić do menu :");
        Console.ReadKey();
        goto menu;
        break;

    case 5:
        Console.Clear();
        Console.WriteLine("Czy na pewno chcesz wyjść? Potwierdź (T), aby wyjść");
        string wybor = Console.ReadLine();

        if (wybor == "T")
        {
            Environment.Exit(0);
        }

        else
        {
            goto menu;
        }
        break;
}







