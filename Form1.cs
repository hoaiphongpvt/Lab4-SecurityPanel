namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button num = (Button) sender;
            txtSecurityCode.Text += num.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = null;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string pass = txtSecurityCode.Text;
            if (pass.Length == 1)
            {
                lbxAccessLog.Items.Add(dateTime.ToString() + "      " + "Restricted Access");
                return;
            }
            switch (pass)
            {
                case "1645"or"1689":
                    lbxAccessLog.Items.Add(dateTime.ToString() + "      " + "Technicians");
                    break;
                case "8345":
                    lbxAccessLog.Items.Add(dateTime.ToString() + "      " + "Custodians");
                    break;
                case "9998" or "1006" or "1008":
                    lbxAccessLog.Items.Add(dateTime.ToString() + "      " + "Scientist");
                    break ;
                default:
                    lbxAccessLog.Items.Add(dateTime.ToString() + "      " + "Access denied");
                    break;
            }

        }
    }
}