

while (true)
{
    Console.WriteLine("1 - Task 1\n2 - Task 2\n3 - Task 3\n4 - Task 4\nElse - Exit");
    string choise = Console.ReadLine();
    TicTacToe.TicTacToe toe = new TicTacToe.TicTacToe();
    MorzeTranslator.MorzeTranslator translator = new MorzeTranslator.MorzeTranslator();
    if ( choise == "1")
    {
        toe.playWithComputer();
    }
    else if( choise == "2")
    {
        toe.playWithPlayer();
    }
    else if ( choise == "3")
    {
        Console.WriteLine("Enter the text");
        translator.translateToMorze(Console.ReadLine());
    }
    else if (choise == "4")
    {
        Console.WriteLine("Enter the text");
        translator.translateToNormal(Console.ReadLine());
    }
    else
    {
        break;
    }
}

namespace TicTacToe
{
    public class TicTacToe
    {
        public string[] field = new string[9];

        public void playWithComputer()
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = "";
            }
            Random random = new Random();
            if (random.Next(0, 1) == 0)
            {
                while (true)
                {
                    Console.WriteLine("It's your turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "X";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Computer win");
                        break;
                    }
                    Console.WriteLine("It's computer's turn now");
                    while (true)
                    {
                        string choise = (random.Next(1, 9)).ToString();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "0";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Computer win");
                        break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("It's computer's turn now");
                    while (true)
                    {
                        string choise = (random.Next(1, 9)).ToString();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "X";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Computer win");
                        break;
                    }
                    Console.WriteLine("It's your turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "0";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("You win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Computer win");
                        break;
                    }
                }
            }
        }

        public void playWithPlayer()
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = "";
            }
            Random random = new Random();
            if (random.Next(0, 1) == 0)
            {
                while (true)
                {
                    Console.WriteLine("It's first player's turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "X";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("First player win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Second player win");
                        break;
                    }
                    Console.WriteLine("It's second player's turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "0";
                                break;
                            }
                        }

                    }
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("First player win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("Second player win");
                        break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("It's second player's turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "X";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("Second player win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("First player win");
                        break;
                    }
                    Console.WriteLine("It's first player's turn now. Choise 1 to 9");
                    while (true)
                    {
                        string choise = Console.ReadLine();
                        if (int.Parse(choise) > 9 || int.Parse(choise) < 1)
                        {
                            Console.WriteLine("This cell does not exist");
                        }
                        else
                        {
                            if (field[int.Parse(choise) - 1] == "X" || field[int.Parse(choise) - 1] == "0")
                            {
                                Console.WriteLine("This cell is occupied");
                            }
                            else
                            {
                                field[int.Parse(choise) - 1] = "0";
                                break;
                            }
                        }

                    }
                    Console.WriteLine($"{field[0]} | {field[1]} | {field[2]}\n{field[3]} | {field[4]} | {field[5]}\n{field[6]} | {field[7]} | {field[8]}\n");
                    if ((field[0] == "X" && field[1] == "X" && field[2] == "X") || (field[3] == "X" && field[4] == "X" && field[5] == "X") || (field[6] == "X" && field[7] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[3] == "X" && field[6] == "X") || (field[1] == "X" && field[4] == "X" && field[7] == "X") || (field[2] == "X" && field[5] == "X" && field[8] == "X") ||
                        (field[0] == "X" && field[4] == "X" && field[8] == "X") || (field[2] == "X" && field[4] == "X" && field[6] == "X"))
                    {
                        Console.WriteLine("Second player win");
                        break;
                    }
                    else if ((field[0] == "0" && field[1] == "0" && field[2] == "0") || (field[3] == "0" && field[4] == "0" && field[5] == "0") || (field[6] == "0" && field[7] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[3] == "0" && field[6] == "0") || (field[1] == "0" && field[4] == "0" && field[7] == "0") || (field[2] == "0" && field[5] == "0" && field[8] == "0") ||
                        (field[0] == "0" && field[4] == "0" && field[8] == "0") || (field[2] == "0" && field[4] == "0" && field[6] == "0"))
                    {
                        Console.WriteLine("First player win");
                        break;
                    }
                }
            }
        }
    }
}

namespace MorzeTranslator
{
    class MorzeTranslator
    {
        public string Text_N { get; set; }
        public string Text_M { get; set; }
        public void translateToNormal(string text)
        {
            string[] English = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] EMorze = { " .- ", " -... ", " -.-. ", " -.. ", " . ", " ..-. ", " --. ", " .... ", " .. ", " .--- ", " -.- ", " .-.. ", " -- ", " -. ", " --- ", " .--. ", " --.- ", " .-. ", " ... ", " - ", " ..- ", " ...- ", " .-- ", " -..- ", " -.-- ", " --.. " };

            string morseWords = text;
            for (int i = 0; i < morseWords.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    morseWords = morseWords.Replace(EMorze[j], English[j]);
                }

            }
            Console.WriteLine(morseWords);
        }

        public void translateToMorze(string text)
        {

            string[] English = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] EMorze = { " .- ", " -... ", " -.-. ", " -.. ", " . ", " ..-. ", " --. ", " .... ", " .. ", " .--- ", " -.- ", " .-.. ", " -- ", " -. ", " --- ", " .--. ", " --.- ", " .-. ", " ... ", " - ", " ..- ", " ...- ", " .-- ", " -..- ", " -.-- ", " --.. " };

            string morseWords = text;
                for (int j = 0; j < 26; j++)
                {
                    morseWords = morseWords.ToUpper().Replace(English[j], EMorze[j]);
                }
                Console.WriteLine(morseWords);
        }
    }
}