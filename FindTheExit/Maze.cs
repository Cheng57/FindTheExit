using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindTheExit;
using DoublyLinkedLists;
using System.IO;

namespace FindTheExit
{

    class Maze
    {
        private char[][] charMaze;

        public Point StartingPoint
        {
            get; set;
        }


        public int RowLength
        {
            get; set;
        }


        public int ColumnLength
        {
            get; set;
        }

        public Maze(string fileName)
        {
            try
            {

                StreamReader reader = new StreamReader(fileName);


                string line;
                int row = 0;

                //Add 'line = reader.ReadLine()' in the while condition statement so that it will read line by line each loop.
                while ((line = reader.ReadLine()) != null)
                {
                    if (row == 0)
                    {
                        string[] size = line.Split(' ');

                        RowLength = int.Parse(size[0]);
                        ColumnLength = int.Parse(size[1]);

                        charMaze = new char[RowLength][];
                        for (int i = 0; i < RowLength; i++)
                        {
                            charMaze[i] = new char[ColumnLength];
                        }
                    }

                    else if (row == 1)
                    {
                        string[] startPoint = line.Split(' ');

                        StartingPoint = new Point(int.Parse(startPoint[0]), int.Parse(startPoint[1]));
                    }
                    else
                    {
                        char[] rowChars = line.ToCharArray();

                        if (rowChars.Length != ColumnLength)
                        {
                            throw new ArgumentException("Invalid maze dimensions in the file.");
                        }

                        Array.Copy(rowChars, charMaze[row - 2], rowChars.Length);

                    }

                    row++;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the maze file: " + e.Message);
            }
        }

        public char[][] GetMaze()
        {
            return charMaze;
        }

        public Maze(int startingRow, int startingColumn, char[][] existingMaze)
        {
            if (startingRow < 0 || startingColumn < 0)
            {
                throw new IndexOutOfRangeException("Negative startingRow or negative startingColumn is not allowed.");
            }

            //Starting point is on the Exit that is represented by the character E.
            if (existingMaze[startingRow][startingColumn] == 'E')
            {
                throw new ApplicationException("Starting point is not allowed to be on the exit.");
            }

            //Starting point is on the Wall that is represented by the character W.
            if (existingMaze[startingRow][startingColumn] == 'W')
            {
                throw new ApplicationException("Starting point is not allowed to be on the wall.");
            }

            StartingPoint = new Point(startingRow, startingColumn);

            RowLength = existingMaze.Length;
            ColumnLength = existingMaze[0].Length;

            charMaze = existingMaze;
        }

        public string PrintMaze()
        {
            string mazeOutput = "";

            for (int i = 0; i < RowLength; i++)
            {
                for (int j = 0; j < ColumnLength; j++)
                {
                    mazeOutput += charMaze[i][j];
                }

                // No '\n' added after the last iteration of the inner loop.
                if (i < RowLength - 1)
                {
                    mazeOutput += "\n";
                }
            }

            return mazeOutput;
        }
    }
}
