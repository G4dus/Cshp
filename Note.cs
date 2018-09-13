
//get drive info

using System;
using System.IO;

 public static void Main()
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            Console.WriteLine("Drive {0}", d.Name);
            Console.WriteLine("  Drive type: {0}", d.DriveType);
            if (d.IsReady == true)
            {
                Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                Console.WriteLine("  File system: {0}", d.DriveFormat);
                Console.WriteLine(
                    "  Available space to current user:{0, 15} bytes", 
                    d.AvailableFreeSpace);

                Console.WriteLine(
                    "  Total available space:          {0, 15} bytes",
                    d.TotalFreeSpace);

                Console.WriteLine(
                    "  Total size of drive:            {0, 15} bytes ",
                    d.TotalSize);
            }
        }
    }

--------------------------------------------------------------------------------

//capture screenshot

ScreenCapture sc = new ScreenCapture();
// capture entire screen, and save it to a file
Image img = sc.CaptureScreen();
// display image in a Picture control named imageDisplay
this.imageDisplay.Image = img;
// capture this window, and save it
sc.CaptureWindowToFile(this.Handle,"C:\\temp2.gif",ImageFormat.Gif);

--------------------------------------------------------------------------------

//hidden folder


string path = @"c:\folders\newfolder";
if (!Directory.Exists(path)) 
{ 
DirectoryInfo di = Directory.CreateDirectory(path); 
di.Attributes = FileAttributes.Directory | FileAttributes.Hidden; 
}

--------------------------------------------------------------------------------
 
 //
