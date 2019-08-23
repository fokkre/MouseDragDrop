using System;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Windows.Forms;



namespace MouseDrag
{
    class MouseDragDrop
    {

        // Static path in the registry
        const string hkey = "HKEY_CURRENT_USER";
        const string path = "Control Panel\\Desktop";
        const string keyName = hkey + "\\" + path;

        // Get and return current values
        public static Tuple<string, string> CurrentDrag()
        {
            
            string currentHeight = (string)Registry.GetValue(keyName, "DragHeight", "Drag Height Not Found");
            string currentWidth = (string)Registry.GetValue(keyName, "DragWidth", "Drag Width Not Found");

            if (Convert.ToInt32(currentHeight) != Convert.ToInt32(currentWidth))
            {
                string eCode = "ERROR: ";
                string eString = "Unable to read registry value";
                var errorCode = new Tuple<string, string>(eCode, eString);
                return errorCode;
            }
            else
            {
                var getData = new Tuple<string, string>(currentHeight, currentWidth);
                return getData;
            }
        }

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
