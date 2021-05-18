    using System;
using System.IO;


    /// <summary>
    ///    Class to create an upper case copy of a file
    /// </summary>
    public class CopyFileUpper
    {
		public static void Main()
		{
        string sFrom;
        string sTo;
        StreamReader srFrom;
        StreamWriter swTo;
        Console.WriteLine("Copy from: ");
        sFrom = Console.ReadLine();
        Console.WriteLine("Copy to: ");
        sTo = Console.ReadLine();
        Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);
        try
        {
            srFrom = new StreamReader (sFrom);
            swTo = new StreamWriter (sTo);
            while (srFrom.Peek () != -1)
            {
                string sBuffer = srFrom.ReadLine();
                sBuffer = sBuffer.ToUpper();
                swTo.WriteLine(sBuffer);
            }
            swTo.Close();
            srFrom.Close();
        }
        catch (FileNotFoundException) 
        {
            Console.WriteLine("Input file not found");
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected exeption");
            Console.WriteLine(e.ToString());
        }
        Console.Read();
		}       
    }
