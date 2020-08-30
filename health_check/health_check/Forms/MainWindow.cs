using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_check.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddNewRecord_Click(object sender, EventArgs e)
        {
            disableAllButtons();

            Application.EnableVisualStyles();
            AddNewRecordWindow addNewRecordWindow = new AddNewRecordWindow();
            addNewRecordWindow.Show();

        }

        // ****** UTILS ********// 
        private void disableAllButtons()
        {
            this.BtnAddNewRecord.Enabled = false;
        }
    }
}
