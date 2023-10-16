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
        //private int rowLength;
        //private int columnLength;
        //private Point startingPoint;
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
    }
}
