using System;
using System.Windows.Forms;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
            orderListview.FullRowSelect = true;
        }

        private void buynowButton_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("Something");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");
            item1.SubItems.Add("SubItem1d");
            item1.SubItems.Add("SubItem1e");
            orderListview.Items.Add(item1);
        }

        private void buyatButton_Click(object sender, EventArgs e)
        {
            // jimmy choo
        }

        private void orderListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void orderListview_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("Something");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");
            item1.SubItems.Add("SubItem1d");
            item1.SubItems.Add("SubItem1e");
            orderListview.Items.Add(item1);
        }
    }
}
