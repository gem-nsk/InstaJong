using System;

namespace genField
{
    class Field
    {
        private int countTypes;
        private int countImageInType;
        private int width;
        private int height;
        public Cell[,] array;

        public Field(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int initField(int countTypes, int countImageInType, bool allStateOne)
        {
            this.countTypes = countTypes;
            this.countImageInType = countImageInType;
            // инициализация поля игры, установка id каждой ячейке
            array = new Cell[height, width];
            if (width <= 0 || height <= 0) return -1;
            int newId = 1;
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = new Cell();
                    array[i, j].setId(newId);

                    newId += 1;
                }
            //установка всех ячеек в state 1
            if (allStateOne)
            {
                for (int i = 1; i < height - 1; i++)
                    for (int j = 1; j < width - 1; j++)
                    {
                        array[i, j].setState(1);

                    }
            }

            
            return 0;
        }
        // раздача randomNum для каждой ячейки
        public int generateField()
        {
            Random random = new Random();
            int rInt;
            for(int n = 0; n < countTypes; n++)
            {
                for (int k = 0; k < countImageInType; )
                {
                    // rInt - переменная, которая получает случайный id ячейки
                    rInt = random.Next(1, width * height);
                    var coords = findCoordsById(rInt);
                    if(coords.i == 0 && coords.j == 0) // условие, что позиция ячейки не 0,0
                        rInt = random.Next(1, width * height);
                    else if (array[coords.i, coords.j].getState() != 1 || array[coords.i, coords.j].getRandomNum() != 0)// условие, что state ячейки = 1, и что ячейка не занята
                        rInt = random.Next(1, width * height);
                    else {
                        array[coords.i, coords.j].setRandomNum(n+1);
                        k++;
                    }
                }
            }
            return 0;
        }
        //функция поиска позиции ячейки массива по id
        public (int i, int j) findCoordsById(int id)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (array[i, j].getId() == id) return (i, j);
                }
            }

            return (0, 0);
        }
        // функция вывода поля на экран
        public void printField()
        {
            Console.Write("\n");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (array[i, j].getState() == 1) Console.BackgroundColor = ConsoleColor.Red;
                    else if(array[i, j].getState() == 0) Console.BackgroundColor = ConsoleColor.Blue;
                    else Console.BackgroundColor = ConsoleColor.Black;

                    String output = String.Format("{0,3}", array[i, j].getRandomNum().ToString());
                       
                    Console.Write(output);
                }
                Console.Write("\n");
            }
            Console.ReadKey(true);
            Console.Clear();
            
        }
    }
}
