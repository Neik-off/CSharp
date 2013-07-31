using System;

class Bittris
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr=new int[4];
        bool conflict = false;
        string command = "";
        int index = 0;
        bool placed = false;
        int score = 0;
        int partScore = 0;
        bool gameover = false;

        for (int j = 1; j <= n; j++)
        {
            if (index > 3)
            {
                index--;
            }
            if(gameover)
            {
                break;
            }
            if (placed && j % 4 != 0)
            {
                continue;
            }
            else
            {
                placed = false;
            }
            if (j-1%4 == 0||j==1)
            {
                int part= int.Parse(Console.ReadLine());
                index = 0;
                for (int k = 0; k < 8; k++)
                {
                    if (((part >> k) & 1) == 1)
                    {
                        if (((arr[index] >> k) & 1) == 1)
                        {
                            gameover = true;
                            break;
                        }
                        
                    }
                }
                int onecount=0;
                for (int i = 0; i < 8; i++)
                {
                    if (((part >> i) & 1) == 1)
                    {
                        onecount++;
                    }
                }
                partScore = onecount;
                arr[index] |= part;
                index++;
                
            }
            else
            {
                command = Console.ReadLine();
                if(command=="D")
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if (index!=0&&((arr[index-1] >> k) & 1) == 1)
                        {
                            if (((arr[index] >> k) & 1) == 1)
                            {
                                conflict = true;
                                placed = true;
                                score += partScore;
                                break;
                            }
                        }
                    }
                    if (!conflict)
                    {
                        arr[index] |= arr[index - 1];
                        if (arr[index] == 255)
                        {
                            if (index == 3)
                            {
                                arr[3] = arr[2];
                                arr[2] = arr[1];
                                arr[1] = arr[0];
                                arr[0] = 0;
                            }
                            else if (index == 2)
                            {
                                arr[2] = arr[1];
                                arr[1] = arr[0];
                                arr[0] = 0;
                            }
                            else if (index == 1)
                            {
                                arr[1] = arr[0];
                                arr[0] = 0;
                            }
                            else
                            {
                                arr[0] = 0;
                            }
                            score *= 10;
                        }
                        index++;
                        conflict = false;
                    }
                }
                else if(command=="R")
                {
                    if (arr[index] % 2 != 0)
                    {
                    }
                    else
                    {
                        arr[index-1] = arr[index-1] >> 1;
                        for (int k = 0; k < 8; k++)
                        {
                            if (((arr[index - 1] >> k) & 1) == 1)
                            {
                                if (((arr[index] >> k) & 1) == 1)
                                {
                                    conflict = true;
                                    placed = true;
                                    score += partScore;
                                    break;
                                }
                            }
                        }
                        if (!conflict)
                        {
                            arr[index ] |= arr[index - 1];
                            if (arr[index] == 255)
                            {
                                if (index == 3)
                                {
                                    arr[3] = arr[2];
                                    arr[2] = arr[1];
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else if (index == 2)
                                {
                                    arr[2] = arr[1];
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else if (index == 1)
                                {
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else
                                {
                                    arr[0] = 0;
                                }
                                score *= 10;
                            }
                            index++;
                        }
                        conflict = false;
                        
                        
                    }
                }
                else if(command=="L")
                {
                    if (arr[index] >= 128)
                    {
                    }
                    else
                    {
                        arr[index-1] = arr[index-1] << 1;
                        arr[index - 1] = arr[index - 1] >> 1;
                        for (int k = 0; k < 8; k++)
                        {
                            if (((arr[index - 1] >> k) & 1) == 1)
                            {
                                if (((arr[index] >> k) & 1) == 1)
                                {
                                    conflict = true;
                                    placed = true;
                                    score += partScore;
                                    break;
                                }
                            }
                        }
                        if (!conflict)
                        {
                            arr[index] |= arr[index - 1];
                            if (arr[index] == 255)
                            {
                                if (index == 3)
                                {
                                    arr[3] = arr[2];
                                    arr[2] = arr[1];
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else if (index == 2)
                                {
                                    arr[2] = arr[1];
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else if (index == 1)
                                {
                                    arr[1] = arr[0];
                                    arr[0] = 0;
                                }
                                else
                                {
                                    arr[0] = 0;
                                }

                                score *= 10;
                            }
                        }
                        index++;
                    }
                    conflict = false;
                        
                }
                        
            }
        }
        Console.WriteLine(score);
        
    }
}