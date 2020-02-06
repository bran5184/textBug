using System;
namespace textGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ///textBug v1.1 Jan 31st, 2020
            ///By Brandon Sanders 
            #region startup
            //Variables

            //Tells Whether Color Graphics are turned on
            var color = false;
            //Score
            int score = 0;
            //player position (X,Y)
            int posX = 1;
            int posY = 1;
            //Position in Arrays (0-19)
            int dotNum = 0;
            //Player Got To The Dot
            var done = false;
            ConsoleColor oldColor = Console.ForegroundColor;
            //Arrays of x,y coordnites for the dot
            //DotNums:               0   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19
            int[] dotX = new int[] { 15, 10, 04, 05, 18, 14, 26, 09, 33, 06, 23, 09, 02, 29, 10, 26, 20, 19, 28, 32 };
            int[] dotY = new int[] { 17, 06, 12, 14, 08, 16, 01, 04, 17, 02, 15, 17, 02, 08, 07, 02, 17, 11, 01, 16 };
            #endregion
            while (true)
            {
                //Restores the original foreground color
                Console.ForegroundColor = oldColor;
                //Clear Console Window 
                Console.Clear();
                #region map
                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("┌─────────────────────────────────┐");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("│                                 │");
                Console.WriteLine("└─────────────────────────────────┘");
                #endregion
                #region player
                //Player
                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(posX, posY);
                Console.Write("Ω");
                #endregion
                #region Dot
                //Dot
                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                //Sets The Position of the dot
                Console.SetCursorPosition(dotX[dotNum], dotY[dotNum]);
                //The dot itself
                Console.Write("o");
                #endregion
                #region HUD
                //HUD

                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Red;
                //Set cursor position
                Console.SetCursorPosition(0, 19);
                //write version of textBug
                Console.WriteLine("textBug v1.1");
                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Green;
                //write score
                Console.WriteLine("Score: {0}", score);
                if (color == true)
                    Console.ForegroundColor = ConsoleColor.Blue;
                //write controls
                Console.WriteLine("Controls: WASD: Move, C: Color, R:Reset, Q: Quit");
                #endregion
                #region logic
                //Game Logic

                // Simple Automatic Scoring System (SASS)

                // If player is in right position then Done is true 
                if (dotNum == 0)
                {
                    if (posX == 15 & posY == 17)
                    {
                        done = true;
                    }
                }
                if (dotNum == 1)
                {
                    if (posX == 10 & posY == 6)
                    {
                        done = true;
                    }
                }
                if (dotNum == 2)
                {
                    if (posX == 4 & posY == 12)
                    {
                        done = true;
                    }
                }
                if (dotNum == 3)
                {
                    if (posX == 5 & posY == 14)
                    {
                        done = true;
                    }
                }
                if (dotNum == 4)
                {
                    if (posX == 18 & posY == 8)
                    {
                        done = true;
                    }
                }
                if (dotNum == 5)
                {
                    if (posX == 14 & posY == 16)
                    {
                        done = true;
                    }
                }
                if (dotNum == 6)
                {
                    if (posX == 26 & posY == 1)
                    {
                        done = true;
                    }
                }
                if (dotNum == 7)
                {
                    if (posX == 9 & posY == 4)
                    {
                        done = true;
                    }
                }
                if (dotNum == 8)
                {
                    if (posX == 33 & posY == 17)
                    {
                        done = true;
                    }
                }
                if (dotNum == 9)
                {
                    if (posX == 6 & posY == 2)
                    {
                        done = true;
                    }
                }
                if (dotNum == 10)
                {
                    if (posX == 23 & posY == 15)
                    {
                        done = true;
                    }
                }
                if (dotNum == 11)
                {
                    if (posX == 9 & posY == 17)
                    {
                        done = true;
                    }
                }
                if (dotNum == 12)
                {
                    if (posX == 2 & posY == 2)
                    {
                        done = true;
                    }
                }
                if (dotNum == 13)
                {
                    if (posX == 29 & posY == 8)
                    {
                        done = true;
                    }
                }
                if (dotNum == 14)
                {
                    if (posX == 10 & posY == 7)
                    {
                        done = true;
                    }
                }
                if (dotNum == 15)
                {
                    if (posX == 26 & posY == 2)
                    {
                        done = true;
                    }
                }
                if (dotNum == 16)
                {
                    if (posX == 20 & posY == 17)
                    {
                        done = true;
                    }
                }
                if (dotNum == 17)
                {
                    if (posX == 19 & posY == 11)
                    {
                        done = true;
                    }
                }
                if (dotNum == 18)
                {
                    if (posX == 28 & posY == 1)
                    {
                        done = true;
                    }
                }
                if (dotNum == 19)
                {
                    if (posX == 32 & posY == 16)
                    {
                        done = true;
                    }
                }
                //Done
                //Add to the score and goto next dotNum
                if (done == true)
                {
                    //add to score
                    score = score + 1;
                    //if dotNum is more than 19 then dotNum = 0
                    if (dotNum < 19)
                    {
                        //add to dotnum
                        dotNum = dotNum + 1;
                    }
                    else
                    {
                        //set dotNum to 0
                        dotNum = 0;
                    }
                    //set done back to false
                    done = false;
                    continue;
                }
                #endregion
                #region Input
                //Key Input
                var keyPress = Console.ReadKey();

                //Reset
                if (keyPress.Key == ConsoleKey.R)
                {
                    color = false;
                    score = 0;
                    posX = 1;
                    posY = 1;
                    dotNum = 0;
                    done = false;
                    continue;
                }
                //Color Switch
                if (keyPress.Key == ConsoleKey.C)
                {
                    if (color == false)
                    {
                        color = true;
                    }
                    else
                    {
                        color = false;
                    }
                    continue;
                }
                //Quit
                if (keyPress.Key == ConsoleKey.Q)
                {
                    break;
                }
                //Move Up
                if (keyPress.Key == ConsoleKey.W & posY > 1)
                {
                    posY = posY - 1;
                    continue;
                }
                //Move Down
                if (keyPress.Key == ConsoleKey.S & posY < 17)
                {
                    posY = posY + 1;
                    continue;
                }
                //Move Left
                if (keyPress.Key == ConsoleKey.A & posX > 1)
                {
                    posX = posX - 1;
                    continue;
                }
                //Move Right
                if (keyPress.Key == ConsoleKey.D & posX < 33)
                {
                    posX = posX + 1;
                    continue;
                }
                #endregion
                //End of while loop
            }
        }
    }
}