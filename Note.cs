
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

//capture screenshot -WORKS

            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save("test.jpg", ImageFormat.Jpeg);
            }

          //  Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                bitmap.Save("C:\\Users\\....................", ImageFormat.Jpeg);
            }


--------------------------------------------------------------------------------

//hidden folder


string path = @"c:\folders\newfolder";
if (!Directory.Exists(path)) 
{ 
DirectoryInfo di = Directory.CreateDirectory(path); 
di.Attributes = FileAttributes.Directory | FileAttributes.Hidden; 
}

--------------------------------------------------------------------------------
 
 //hidden file
 
 File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden);

--------------------------------------------------------------------------------

 //
