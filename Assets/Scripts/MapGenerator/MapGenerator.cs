using System;

namespace genField
{
    class MapGenerator
    {
        private int countElem = 0;
        private int countImagesInType = 0;
        private int countTypes = 0;
        public Field field;

        public MapGenerator() { }

        public int mapFromString(String[,] map, int width, int height)
        {
            field = new Field(width, height);

            for(int i = 0; i < height; i++)
                for(int j = 0; j < width; j++)
                    if(map[i,j] == "1")
                        countElem++;

            

            if(countElem % 4 == 0) { countTypes = countElem / 4; countImagesInType = 4; }
            else if(countElem % 2 == 0) { countTypes = countElem / 2; countImagesInType = 2; }
            else { return -1; }

            field.initField(countTypes,countImagesInType, false);

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    if (map[i, j] == "1")
                        field.array[i, j].setState(1);

            field.generateField();
            
            return 0;
        }

        public int mapFromFile()
        {

            return 0;
        }
    }
}
