using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace CyberChatbotApplication
{
    internal class Casslogo
    {
        public Casslogo()
        {
            string asciiPath = AppDomain.CurrentDomain.BaseDirectory;

            string newAsciiPath = asciiPath.Replace("bin\\Debug", "");

            string fullPath = Path.Combine(newAsciiPath, "C:\\Users\\RC_Student_lab\\source\\repos\\CyberChatbotApplication\\ascii_folder\\locked.jpeg");

            Bitmap image = new Bitmap(fullPath);
            image = new Bitmap(image, new Size(35,25) );

            for ( int height = 0; height < image.Height ; height++) 
            {
                for ( int width = 0; width < image.Width ; width++) 
                {
                    
                    Color pixelColor = image.GetPixel(width, height);
                    int color = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiDesgin = color > 200 ? ',': color > 150 ? '*' : color > 100 ? '0' : color > 50 ? '#' : '@' ;
                    Console.Write(asciiDesgin);
                  
  

                }
                Console.WriteLine();
            }//endof for loop
        
        
        }
    }
}