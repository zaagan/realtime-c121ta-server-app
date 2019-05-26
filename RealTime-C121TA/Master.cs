using AxFPCLOCK_SVRLib;
using RealTime_C121TA.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RealTime_C121TA
{
    public partial class Master : Form
    {

        private int nIndex = 0;

        private const string TXT_OPEN_NETWORK = "Open Network";
        private const string TXT_CLOSE_NETWORK = "Close Network";

        public Master()
        {
            InitializeComponent();
            Helpers.InitializeListView(listView1);

        }


        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        { Helpers.DrawLineInFooter(pnlHeader, Color.FromArgb(204, 204, 204), 2); }

        private void btnOpenServerNetwork_Click(object sender, EventArgs e)
        {
            try
            {
                string str = this.tbxHostPort.Text;
                int nPort = 0;
                int.TryParse(str, out nPort);

                if (nPort <= 0)
                {
                    Helpers.DisplayMessage("Enter a valid port no.", false);
                    return;
                }

                if (btnOpenServerNetwork.Text == TXT_OPEN_NETWORK)
                {
                    int result = fpClockServer.OpenNetwork(nPort);

                    if (result == 1)
                    {
                        btnOpenServerNetwork.Text = TXT_CLOSE_NETWORK;

                    }
                    else
                    {
                       Helpers.DisplayMessage("Unable to start the server. Status Code: " + result, false, "Initialization Failed");
                    }
                }
                else
                {
                    int result = fpClockServer.CloseNetwork(nPort);
                    if (result == 0)
                    {
                        btnOpenServerNetwork.Text = TXT_OPEN_NETWORK;
                    }
                    else
                    {
                        Helpers.DisplayMessage("Unable to disconnect. Status Code: " + result, false, "Failed to disconnect");

                    }

                }

            }
            catch (Exception ex)
            {
                Helpers.DisplayMessage(ex.Message, false);
            }

        }

    

        private void axFPCLOCK_Svr1_OnReceiveGLogData_1(object sender, _DFPCLOCK_SvrEvents_OnReceiveGLogDataEvent e)
        {
            String strKey = Convert.ToString(nIndex + 1);
            String str = e.anSEnrollNumber.ToString("D8");

            this.listView1.BeginUpdate();

            
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = strKey;

            listViewItem.SubItems.Add(str);

            str = Helpers.FormString(e.anVerifyMode, e.anSEnrollNumber);
            listViewItem.SubItems.Add(str);

            if (e.anInOutMode == 1)
            {
                str = "OUT";
            }
            else if (0 == e.anInOutMode)
            {
                str = "IN";
            }
            else
            {
                str = "--";
            }
            listViewItem.SubItems.Add(str);

            str = Convert.ToString(e.anLogDate.ToString("yyyy/MM/dd HH:mm"));
            listViewItem.SubItems.Add(str);

            listViewItem.SubItems.Add(e.astrDeviceIP);

            str = Convert.ToString(e.anDevicePort);
            listViewItem.SubItems.Add(str);

            str = Convert.ToString(e.vnDeviceID);
            listViewItem.SubItems.Add(str);

            str = Convert.ToString(e.linkindex);
            listViewItem.SubItems.Add(str);

            this.listView1.Items.Add(listViewItem);

            this.listView1.Update();

            this.listView1.EnsureVisible(nIndex);
            this.listView1.EndUpdate(); 

            int nResult = 1;

            fpClockServer.SendResultandTime(e.linkindex, e.vnDeviceID, e.anSEnrollNumber, nResult);

            nIndex++;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
           nIndex = 0;
           listView1.Items.Clear();
        }
      
  
    }
}
