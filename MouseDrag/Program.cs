using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;


//  This changes the amount of pixels it takes for a drag event/action to happen. Default for windows is 4 pixals.
// Must logout/login to get it to take effect.
// Registry Keys being modified are:
//  HKEY_CURRENT_USER\Control Panel\Desktop\DragHeight
//  HKEY_CURRENT_USER\Control Panel\Desktop\DragWidth
// Written By Jacob Shelhamer
// Date 8/22/2019


namespace MouseDrag
{
    class MouseDragDrop
    {

        // Static path in the registry
        const string hkey = "HKEY_CURRENT_USER";
        const string path = "Control Panel\\Desktop";
        const string keyName = hkey + "\\" + path;

        // Get and return current drag hieght and width values
        public static Tuple<string, string> CurrentDrag()
        {
            //these values are strings values, even though it is a number
            string currentHeight = (string)Registry.GetValue(keyName, "DragHeight", "Drag Height Not Found");
            string currentWidth = (string)Registry.GetValue(keyName, "DragWidth", "Drag Width Not Found");

            //verify we can ready the registry and exit if not
            if (Convert.ToInt32(currentHeight) != Convert.ToInt32(currentWidth))
            {
                string eCode = "ERROR: ";
                string eString = "Unable to read registry value";
                var errorCode = new Tuple<string, string>(eCode, eString);
                return errorCode;
            }
            else
            {
                //return current values
                var getData = new Tuple<string, string>(currentHeight, currentWidth);
                return getData;
            }
        }

        //set drag height and width to the same value. Maybe i'll add more functionality later to update each individually. Would be super easy.
        public void SetDragValues(int updateDrag)
        {
            Registry.SetValue(keyName, "DragHeight", updateDrag, RegistryValueKind.String);
            Registry.SetValue(keyName, "DragWidth", updateDrag, RegistryValueKind.String);
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        //I can't believe this is what I started with and now it is something I am proud of.
        
        //static void Main()
        //{

        //    string currentHeight = (string)Registry.GetValue(keyName, "DragHeight", "Drag Height Not Found");
        //    string currentWidth = (string)Registry.GetValue(keyName, "DragWidth", "Drag Width Not Found");
        //    Console.WriteLine("DragHeight currently is: " + currentHeight);
        //    Console.WriteLine("DragWidth currently is: " + currentWidth);

        //    Console.WriteLine("Would you like to change this value? Y/N");
        //    string changeValue = Console.ReadLine();


        //    if (changeValue != "Y" )
        //    {
        //        if (changeValue != "N")
        //        {
        //            Console.WriteLine("Incorrect Selection");
        //            Console.WriteLine(changeValue + " Was enetered, Please try again");
        //        }

        //        Console.WriteLine("Values will not be updated.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter the new value: ");
        //        int updateDrag = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("New value entered: " + updateDrag);
        //        Console.WriteLine("Is this correct? Y/N");
        //        string confirmUpdate = Console.ReadLine();

        //        if (confirmUpdate != "Y")
        //        {
        //            Console.WriteLine("No changes have been made.");
        //        }
        //        else
        //        {
        //            Registry.SetValue(keyName, "DragHeight", updateDrag, RegistryValueKind.String);
        //            Registry.SetValue(keyName, "DragWidth", updateDrag, RegistryValueKind.String);
        //            Console.WriteLine("Update Complete");
        //        }

        //    }

        //    Console.ReadKey(true);
        //}


    }
}
