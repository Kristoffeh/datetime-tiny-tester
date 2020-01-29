using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            DateTime startTime = date1.Value;
            DateTime endTime = date2.Value;

            TimeSpan span = endTime.Subtract(startTime);

            // --------- START --------- //
            // On a date to int conversion
            // If 0.5 or less, it is converted as 0.
            // Otherwise it is converted as a 1.
            // --------- END --------- //

            var overtime = span.TotalMinutes - 465;

            lbldate.Text = "Overtime: " + string.Format("{0:0.##}", Convert.ToInt32(overtime)) + " minutes";
            // Console.WriteLine("Time difference: " + string.Format("{0:0.##}", Convert.ToInt32(span.TotalMinutes)) + " minutes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime defStart = Convert.ToDateTime("08:00");
            DateTime defEnd = Convert.ToDateTime("15:45");

            TimeSpan defspan = defEnd.Subtract(defStart);
            lbldefault.Text = "Normal day: " + defspan.TotalMinutes.ToString() + " minutes";
        }
    }
}
