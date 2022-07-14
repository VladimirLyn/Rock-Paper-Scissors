

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputPlayer, InputCPU;
            int randomInt;
            bool PlayAgain = true;

            while (PlayAgain == true )
            {
                int ScoreCPU = 0;
                int ScorePlayer = 0;

                while (ScorePlayer < 3 && ScoreCPU < 3)
                {
                    Console.WriteLine("Выберите Камень, Бумагу или Ножницы");
                    InputPlayer = Console.ReadLine();

                    Random rand = new Random();
                    randomInt = rand.Next(1, 4);
                    switch (randomInt)
                    {
                        case 1:
                            InputCPU = "Камень";
                            Console.WriteLine("Компьютер выбрал Камень");

                            if (InputPlayer == "Камень")
                            {
                                Console.WriteLine("Ничья");
                            }
                            else if (InputPlayer == "Бумага")
                            {
                                Console.WriteLine("Вы победили");
                                ScorePlayer++;
                            }
                            else if (InputPlayer == "Ножницы")
                            {
                                Console.WriteLine("Вы проиграли");
                                ScoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не правильно ");

                            }
                            break;

                        case 2:
                            InputCPU = "Бумага";
                            Console.WriteLine("Компьютер выбрал Бумагу");

                            if (InputPlayer == "Бумага")
                            {
                                Console.WriteLine("Ничья");
                            }
                            else if (InputPlayer == "Ножницы")
                            {
                                Console.WriteLine("Вы победили");
                                ScorePlayer++;
                            }
                            else if (InputPlayer == "Камень")
                            {
                                Console.WriteLine("Вы проиграли");
                                ScoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не правильно ");

                            }
                            break;

                        case 3:
                            InputCPU = "Ножницы";
                            Console.WriteLine("Компьютер выбрал Ножницы");

                            if (InputPlayer == "Ножницы")
                            {
                                Console.WriteLine("Ничья");
                            }
                            else if (InputPlayer == "Камень")
                            {
                                Console.WriteLine("Вы победили");
                                ScorePlayer++;
                            }
                            else if (InputPlayer == "Бумага")
                            {
                                Console.WriteLine("Вы проиграли");
                                ScoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не правильно ");

                            }
                            break;

                        default: break;
                    }
                }

                if (ScorePlayer == 3)
                {
                    Console.WriteLine("Вы победили, счёт: Вы: " + ScorePlayer.ToString() + " Компьюпер: " + ScoreCPU.ToString());
                }
                else if (ScoreCPU == 3)
                {
                    Console.WriteLine("Вы проиграли, счёт: Вы: " + ScorePlayer.ToString() + " Компьюпер: " + ScoreCPU.ToString());
                }

                Console.WriteLine("Хотите сыграть ещё ?");
                string Again = Console.ReadLine();
               
                    if (Again == "Да" || Again == "да")
                    {
                        PlayAgain = true;
                    }
                    else if (Again == "Нет" || Again == "нет")
                    {
                        PlayAgain = false;
                    }
                    else
                    {
                    PlayAgain = true;
                    }
                

            }
        }
    }
}