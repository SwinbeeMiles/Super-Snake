using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 1024, 768);
            //SwinGame.ShowSwinGameSplashScreen();
            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
				//SwinGame.DrawFramerate(0,0);

				//Draw onto the screen

				FoodGenerator.LetThereBeFood (10);
				Edgy.LineEdge ();
				SnakeModel.DrawSnake ();
				GameControl.SnakeController ();
				GameControl.SnakeMovement ();
                SwinGame.RefreshScreen(60);
            }
        }
    }
}