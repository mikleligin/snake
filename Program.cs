using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace packman
{
    
    class Program
    {
        /*static void up_array_method(int[,] array_up)
        {
            for (int i = 0; i < array_up.GetLength(0); i++)
            {
                for (int j = 0; j < array_up.GetLength(1); j++)
                {
                    array_up[i, j] = 0;

                }
            }
            return;
        }
        */
        public static void GameOver()
        {

            Console.Clear();
            Console.WriteLine("Game Over!");
        }

        static void Main(string[] args)
        {
            char[,] place = new char[20, 20];
            for (int i = 0; i < place.GetLength(0); i++)
            {
                for (int j = 0; j < place.GetLength(1); j++)
                {
                    place[j, i] = ' ';
                }
            }
            for (int i = 0; i < place.GetLength(0); i++)
            {
                place[0, i] = '#';
                place[i, 0] = '#';
                place[i, 19] = '#';
                place[19, i] = '#';

            }
            //===============================================================
            int count_x = 10;
            int count_y = 10;
            int right_x_proverka = 0;
            int up_y_proverka = 0;
            int left_x_proverka = 0;
            int down_y_proverka = 0;
            int point=1;
            int up_count = 0;
            int down_count = 1;
            int left_count = 0;
            int right_count = 0;
            int lenth_of_player = 1;
            int up_prov = 0;
            int down_prov = 0;
            int left_prov = 0;
            int right_prov = 0;
            int update_time = 500;
            int[,] array_position = new int[2,999];
            int[,] array_right = new int[1,20];
            int proverka_na_povorot = 0;
            for (int i = 0; i < array_position.GetLength(0); i++)
            {
                for (int j = 0; j < array_position.GetLength(1); j++)
                {
                    array_position[i, j] = 0;
                }
            }
            int step_for_array=-1;
            int point_sleep=1;
            int while_step_array = 0;
            int count_proverka = 0;
            //=================================================================
            ConsoleKeyInfo key;
            while (true)
            {

                System.Threading.Thread.Sleep(update_time);
                /*
                for (int i = 0; i < place.GetLength(0); i++)
                {
                    for (int j = 0; j < place.GetLength(1); j++)
                    {
                       
                        
                        if (place[i, j] != '*' && count_proverka==0)
                        {
                            count_proverka = 1;
                            point_sleep = point_sleep + 1;
                            point = point + 1;
                            lenth_of_player = point;
                            Random random = new Random();
                            int eat_x = random.Next(1, 10);
                            int eat_y = random.Next(1, 10);
                            place[eat_y, eat_x] = '*';
                            
                        }
                        if (place[i, j] == '*')
                        {
                            count_proverka = 1;
                        }
                    }
                }
                for (int i = 0; i < place.GetLength(0); i++)
                {
                    for (int j = 0; j < place.GetLength(1); j++)
                    {
                        if (place[i, j] != '*' && count_proverka==1)
                        {
                            count_proverka = 0;
                        }

                    }
                }

                */

                Console.Clear();

                //Код, который выполняется, когда player не нажимает клавишу
                if (Console.KeyAvailable == false)
                {
                    array_position[0, while_step_array] = count_y;
                    array_position[1, while_step_array] = count_x;

                    if (point_sleep == 0)
                    {
                        //Console.WriteLine("Удаляю координаты");
                        //Console.WriteLine($"y = {array_position[0, step_for_array]}, x = {array_position[1, step_for_array] }");
                        place[array_position[0, step_for_array], array_position[1, step_for_array]] = ' ';
                       // Console.WriteLine($"Удален элемент у = {array_position[0, step_for_array]}, x =  {array_position[1, step_for_array]}");


                    }
                    if (point_sleep >= 1)
                    {
                        //Console.WriteLine("Отнимаю 1");

                        point_sleep = point_sleep - 1;
                    }
                    //Console.WriteLine($"point_sleep={point_sleep}");

                    try
                    {



                        if (right_x_proverka == 1)
                        {
                            
                                up_prov = 1;
                                down_prov = 0;
                                up_count = up_count - 1;
                                left_count = 0;
                                down_count = 0;
                                //Console.WriteLine($"lenth_of_player:{lenth_of_player}");
                                //Console.WriteLine($"Up_Count:{up_count}");

                                right_count = right_count + 1;

                                count_x = count_x + 1;

                                place[count_y, count_x] = '$';
                                place[count_y, count_x - point] = ' ';
                                //Console.WriteLine($"array_up[0, step_for_array {array_position[0, step_for_array]},array_up[1, step_for_array] { array_position[1, step_for_array]}");
                                /*for (int i = 0; i < up_count; i++)
                                {
                                    if (place[array_position[0, step_for_array] - 1, array_position[1, step_for_array]] == '$')
                                    {
                                        step_for_array = i;
                                        continue;
                                    }
                                }
                                place[array_position[0, step_for_array], array_position[1, step_for_array]] = ' ';
                                
                                step_for_array =step_for_array+ 1;
                               */
                                /*
                                //place[count_y, count_x - point] = '-';
                                //Количество ходов вверх считает переменная up_count.
                                if (up_count <= 0)
                                {
                                    place[count_y + lenth_of_player, count_x - right_count] = ' ';
                                    place[count_y , count_x - right_count] = '+';
                                }
                                else
                                {
                                    place[count_y + lenth_of_player, count_x - right_count] = ' ';
                                    place[count_y  + lenth_of_player, count_x - right_count] = '+';
                                }
                              

                                if (lenth_of_player <= 0)
                                {
                                    //lenth_of_player = point;
                                    lenth_of_player = 0;
                                }
                                else
                                {
                                    lenth_of_player = lenth_of_player - 1;
                                }
                                  */
                            
                        }
                        //Если player шел вниз .но до этого шел вправо
                        //if (down_count>0 || down_prov==1)
                        if (down_count > 1 || down_prov == 1 && right_count > 0)
                        {
                            right_x_proverka = 0;
                            //Console.WriteLine($"down_count:{down_count}");
                            //Console.WriteLine($"right_count:{right_count}");
                            down_prov = 1;
                            up_prov = 0;
                            up_count = 0;
                            left_count = 0;
                            //down_count+=1;
                            //Console.WriteLine(lenth_of_player);
                            right_count--;

                            // count_x = count_x + 1;
                            //Уничтожение ПРАВЫХ ходов, которые были сделаны до поворота ВНИЗ 
                            place[count_y, count_x] = '$'; //Ставится змейка
                            if (true)
                            {

                            }
                            place[count_y, count_x - point] = ' ';//убирается ход после змейки, чтобы сохранить размер
                                                                  //позиция игрик - пройденый путь вниз, позиция х - то, сколько прошел вправо
                                                                  //Допустим у=10, длинна 2 , х = 10, прошел вправо 3
                            //place[count_y - down_count, count_x - right_count] = '=';
                            if (lenth_of_player < 0)
                            {
                                lenth_of_player = point;
                            }
                            else
                            {
                                lenth_of_player = lenth_of_player - 1;
                            }
                        }





                        if (up_y_proverka == 1)
                        {
                            right_count = 0;
                            left_count = 0;
                            down_count = 0;
                            //Тоесть в первом ряду пишется координата х
                            //во втором- координата y. up_count постоянно увеличивается на 1, по этому массив делает ход.
                            /* 
                             array_position[0, up_count] = count_y;
                             array_position[1, up_count] = count_x;
                             up_count = up_count + 1;
                            */
                            count_y = count_y - 1;
                            place[count_y, count_x] = '$';
                            place[count_y + point, count_x] = ' ';
                            // place[county + up, countx - lenth] = ' ';

                        }
                        if (left_x_proverka == 1)
                        {
                            right_count = 0;
                            up_count = 0;
                            down_count = 0;
                            left_count += 1;
                            count_x = count_x - 1;
                            place[count_y, count_x] = '$';
                            place[count_y, count_x + point] = ' ';
                        }
                        if (down_y_proverka == 1)
                        {
                            right_count = 0;
                            left_count = 0;
                            up_count = 0;
                            down_count += 1;
                            count_y = count_y + 1;
                            place[count_y, count_x] = '$';
                            place[count_y - point, count_x] = ' ';
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        GameOver();
                        break;
                        throw;
                    }


                    for (int i = 0; i < place.GetLength(0); i++)
                    {
                        for (int j = 0; j < place.GetLength(1); j++)
                        {
                            Console.Write(place[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                //Код, когда игрок нажал клавишу

                else
                {

                    key = Console.ReadKey();
                    //Добавление длинны player-а
                    //D - добавить
                    if (key.Key == ConsoleKey.D)
                    {
                        point_sleep = point_sleep + 1;
                        point = point + 1;
                        lenth_of_player = point;
                    }
					//S - уменьшить скорость
					//A - увеличить скорость
                    if (key.Key == ConsoleKey.S)
                    {
                        update_time -= 200;
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        update_time += 200;
                    }
                    if (key.Key == ConsoleKey.UpArrow)
                    {/*
                        for (int i = 0; i < array_position.GetLength(0); i++)
                        {
                            for (int j = 0; j < array_position.GetLength(1); j++)
                            {
                                array_position[i, j] = 0;

                            }
                        }
                        */
                        lenth_of_player = point;
                        up_prov = 1;
                        left_x_proverka = 0;
                        down_y_proverka = 0;
                        up_y_proverka = 1;
                        right_x_proverka = 0;
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {

                        left_x_proverka = 0;
                        down_y_proverka = 0;
                        up_y_proverka = 0;
                        right_x_proverka = 1;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {

                        lenth_of_player = point;
                        down_prov = 1;
                        left_x_proverka = 0;
                        down_y_proverka = 1;
                        up_y_proverka = 0;
                        right_x_proverka = 0;
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {

                        left_x_proverka = 1;
                        down_y_proverka = 0;
                        up_y_proverka = 0;
                        right_x_proverka = 0;
                    }

                    //Вывод поля в консоль
                    for (int i = 0; i < place.GetLength(0); i++)
                    {
                        for (int j = 0; j < place.GetLength(1); j++)
                        {
                            Console.Write(place[i, j]);
                        }
                        Console.WriteLine();
                    }

                }
            while_step_array++;
            if (point_sleep == 0)
            {
             step_for_array = step_for_array + 1;
            }
                
            }
            
            
        }
    }
}
