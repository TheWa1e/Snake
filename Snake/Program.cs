using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Verticalline v1 = new Verticalline(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake) fSnake;

            Horizontalline h1 = new Horizontalline(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }

            Console.ReadLine();
            



            //Console.SetBufferSize(80, 25);

            /*Horizontalline upLine = new Horizontalline(0, 78, 0, '+');
            Horizontalline downLine = new Horizontalline(0, 78, 24, '+');
            Verticalline leftLine = new Verticalline(0, 24, 0, '+');
            Verticalline rightLine = new Verticalline(0, 24, 78, '+');  
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(77, 23, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Console.CursorVisible = false;

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }*/
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
