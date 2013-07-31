using System;
using System.Collections.Generic;
using System.Threading;

class ConsoleFallingRocksGame
{       
        
    struct element
    {
        public int x, y;
        public char c;
        public ConsoleColor color;
    }

    public static void PrintOnPosition(int x,int y, char c,ConsoleColor color=ConsoleColor.DarkGreen) 
    {
        Console.SetCursorPosition(x,y);
        Console.ForegroundColor=color;
        Console.Write(c);
    }
    public static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {        
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;

        int lives = 5;
        int speed = 100;
        int scoreVar = 0;
        element dwarf = new element();
        dwarf.x = 9;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = '#';
        dwarf.color = ConsoleColor.Yellow;

        Random rGenerator = new Random();
        List<element> elements=new List<element>();
        char[] symbols = { '@', '%', '&', '!', '*', '$','O' };
        ConsoleColor [] colors= {ConsoleColor.White,ConsoleColor.Green,ConsoleColor.Red};

        while (true)
        {
            bool hitted = false;
            //User Control
            while(Console.KeyAvailable)
            {
                
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key==ConsoleKey.LeftArrow)
                {
                    if(dwarf.x - 1 >= 0){
                    dwarf.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if(dwarf.x+1 <= 19){
                    dwarf.x += 1;
                    }
                }
            }
            if(speed<270)
            {
            speed++;
            }

            //Element's creating
            int chance = rGenerator.Next(1,100);
            if (chance < 5)
            {
                element rock = new element();
                rock.x = rGenerator.Next(0, 20);
                rock.y = 0;
                rock.c = symbols[6];
                rock.color = colors[rGenerator.Next(0, 3)];
                elements.Add(rock);
            }
            else if (chance<10)
            {
                element rock = new element();
                rock.x = rGenerator.Next(0, 20);
                rock.y = 0;
                rock.c = symbols[4];
                rock.color = colors[rGenerator.Next(0, 3)];
                elements.Add(rock);
            }
            else if(chance<30)
            {
                element rock = new element();
                rock.x = rGenerator.Next(0, 20);
                rock.y = 0;
                rock.c = symbols[5];
                rock.color = colors[rGenerator.Next(0, 3)];
                elements.Add(rock);
            }
            else
            {
                element rock = new element();
                rock.x = rGenerator.Next(0, 20);
                rock.y = 0;
                rock.c = symbols[rGenerator.Next(0, 4)];
                rock.color = colors[rGenerator.Next(0, 3)];
                elements.Add(rock);
            }
            //Score Counting
            scoreVar++;
            

            
            //Console Clearing
            Console.Clear();


            //Console Redraw
            List<element> newElements=new List<element>();
            for (int i = 0; i < elements.Count; i++ )
            {
                element oldElement = elements[i];
                element newElement =new element();
                newElement.x = oldElement.x;
                newElement.y =oldElement.y + 1;
                newElement.c = oldElement.c;
                newElement.color = oldElement.color;
                if(newElement.y==dwarf.y && newElement.x==dwarf.x)
                {
                    if (newElement.c == '*')
                    {
                        if(speed>=50)
                        {
                        speed = speed - 50;
                        }
                    }
                    else if(newElement.c=='$')
                    {
                        scoreVar = scoreVar + 50;
                    }
                    else if(newElement.c=='O')
                    {
                        lives++;
                    }
                    else
                    {
                        hitted = true;
                        lives--;
                    }
                }
                if(newElement.y<Console.WindowHeight)
                {
                   
                newElements.Add(newElement);
                }
            }
            elements = newElements;
            foreach (var rocks in elements)
            {
                PrintOnPosition(rocks.x, rocks.y, rocks.c, rocks.color);
            }

            if (hitted)
            {
                Console.Beep();
                elements.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            }

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintOnPosition(20, i, '|', ConsoleColor.White);
            }
            //Print Info
            if(lives==0)
            {
                PrintStringOnPosition(20, 6, "GAME OVER!!!");
                PrintStringOnPosition(20, 7, "Your Score is:" + scoreVar + "\n\n");
                return;
            }

            PrintStringOnPosition(32, 0, "FallingRocks", ConsoleColor.Yellow);

            PrintStringOnPosition(34, 2, "Score:" + scoreVar);

            PrintStringOnPosition(34, 4, "Lives:"+lives);

            PrintStringOnPosition(34, 6, "Speed:"+speed);

            PrintStringOnPosition(25, 10, "Hints: O are extra life!",ConsoleColor.Yellow);
            PrintStringOnPosition(32, 11, "$ are extra points!", ConsoleColor.Yellow);
            PrintStringOnPosition(32, 12, "* are speed slow down!", ConsoleColor.Yellow);
            Thread.Sleep(400-speed);
        }
    }

}
