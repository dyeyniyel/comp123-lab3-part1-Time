You will learn about enums, static members and default arguments.

![image](https://github.com/dyeyniyel/comp123-lab3-part1-Time/assets/158533198/897fc23c-ebfb-4600-8460-6858fc155945)

![image](https://github.com/dyeyniyel/comp123-lab3-part1-Time/assets/158533198/93ca9f44-bc89-4f3f-8a8e-c99ad25dfbe4)

![image](https://github.com/dyeyniyel/comp123-lab3-part1-Time/assets/158533198/8e481430-f45b-4cc6-89d0-6bcf7f6859d9)

Test Harness

Insert the following code statements in your Program.cs file:







//create a list to store the objects

List<Time> times = new List<Time>() 

  { 

    new Time(9, 35),

    new Time(18, 5),

    new Time(20, 500),

    new Time(10),

    new Time()

  };





//display all the objects

TimeFormat format = TimeFormat.Hour12;

Console.WriteLine($"\n\nTime format is {format}");

foreach (Time t in times)

{

    Console.WriteLine(t);

}



//change the format of the output

format = TimeFormat.Mil;

Console.WriteLine($"\n\nSetting time format to {format}");

//SetFormat(TimeFormat) is a class member, so you need the type to access it

Time.SetFormat(format);

//again display all the objects

foreach (Time t in times)

{

    Console.WriteLine(t);

}



//change the format of the output

format = TimeFormat.Hour24;

Console.WriteLine($"\n\nSetting time format to {format}");

//SetFormat(TimeFormat) is a class member, so you need the type to access it

Time.SetFormat(format);

foreach (Time t in times)

{ 

    Console.WriteLine(t);

}


![image](https://github.com/dyeyniyel/comp123-lab3-part1-Time/assets/158533198/1a91a8d6-7a7c-4023-a082-138936b2684c)



