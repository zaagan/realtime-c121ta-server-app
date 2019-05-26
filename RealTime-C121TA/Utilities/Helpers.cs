using System.Drawing;
using System.Windows.Forms;

namespace RealTime_C121TA.Utilities
{
    public class Helpers
    {

        public static void DisplayMessage(string message, bool isOK, string caption = "")
        {
            if (isOK)
            {
                MessageBox.Show(message, caption);
            }
            else
            {
                MessageBox.Show(message, "Error occured");
            }
        }



        public static void DrawLineInFooter(Control control, Color color, int thickness)
        {
            int y = control.Height;
            DrawLine(control, color, 0, y, control.Width, y, thickness);
        }

        public static void DrawLine(Control control, Color color, int x, int y, int x1, int y1, int thickness)
        {
            Graphics graphicsObj = control.CreateGraphics();
            graphicsObj.DrawLine(new Pen(color, thickness), x, y, x1, y1);
        }
        public static void InitializeListView(ListView listView1)
        {
            listView1.Columns.Add(" ", 40, HorizontalAlignment.Left);        
            listView1.Columns.Add("EnrollNo", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("VerifyMode", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("InOut", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("DateTime", 140, HorizontalAlignment.Left);
            listView1.Columns.Add("IP", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Port", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("DevID", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("SerialNo", 60, HorizontalAlignment.Left);

        }

        public static string FormString(int nVerify, int nEnrollNum)
        {
            int nAction = nVerify % 8;
            if (nEnrollNum == 0)
            {
                switch (nAction)
                {
                    case 0:
                        return "Closed";
                    //break;
                    case 1:
                        return "Opened";
                    // break;
                    case 2:
                        return "HandOpen";
                    // break;
                    case 3:
                        return "ProcOpen";
                    // break;
                    case 4:
                        return "ProcClose";
                    // break;
                    case 5:
                        return "IllegalOpen";
                    //break;
                    case 6:
                        return "IlleagalRemove";
                    //break;
                    case 7:
                        return "Alarm";
                    //break;
                    case 8:
                        return "--";
                        //break;
                }
            }
            else
            {
                switch (nAction)
                {
                    case 0:
                        return "Normal";
                    //break;

                    case 1:
                        return "f1";
                    //break;

                    case 2:
                        return "f2";
                    //break;

                    case 3:
                        return "f3";
                    //break;

                    case 4:
                        return "f4";
                    // break;

                    case 5:
                        return "in";
                    // break;

                    case 6:
                        return "out";
                    //break;

                    case 7:
                        return "--";
                        //break;
                }
            }

            return "Not my fault";
        }

    }
}
