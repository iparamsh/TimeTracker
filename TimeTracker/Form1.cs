namespace TimeTracker
{
    public partial class Form1 : Form
    {
       
        DateTime thisDay = DateTime.Today;
        string todaysDate = "";
        private FileOperations fileOperation = new FileOperations();
        private string moneyPerHour = @"C:/moneyPerHour.txt";
        private string timeTrack = @"C:/timeTrack.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Calculations calculations = new Calculations(fileOperation, timeTrack, moneyPerHour);
            todaysDate = thisDay.ToString("d");
            dateLBL.Text = "Todays date: " + todaysDate;
            fileOperation.createFileIfNotCreated(moneyPerHour);
            fileOperation.createFileIfNotCreated(timeTrack);
            changeCurrentMoneyPerHourLBL();
            totalHoursLBL.Text = "Total hours: " + calculations.getTotalHours(timeTrack).ToString();
            expectedPaycheckLBL.Text = "Expected paycheck: $" + calculations.calculatePaycheck().ToString();
        }

        private void trackTimeBtn(object sender, EventArgs e)
        {
            string log = todaysDate + " " + timeInTB.Text + "-" + timeOutTB.Text + "|" + breakTimeTB.Text;
            fileOperation.addLogToFile(timeTrack, log);
            MessageBox.Show("Time was tracked!");
            this.Close(); 
        }

        private void changeMoneyPerHourBTN_Click(object sender, EventArgs e)
        {
            fileOperation.writeToFileAndDelete(moneyPerHour, MoneyPerHourLB.Text);
            changeCurrentMoneyPerHourLBL();
        }

        private void changeCurrentMoneyPerHourLBL()
        {
            timePerHourLBL.Text = "Current: " + fileOperation.checkMoneyPerHour(moneyPerHour) + "$";
        }

        private void FlashHoursBTN_Click(object sender, EventArgs e)
        {
            fileOperation.deleteFile(timeTrack);
            totalHoursLBL.Text = "Total hours: 0";
            expectedPaycheckLBL.Text = "Expected paycheck: $0";
            MessageBox.Show("Work time hours flashed!");
        }
    }
}