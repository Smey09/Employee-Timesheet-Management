using EmployeeTimesheetManagement.Entity;
using EmployeeTimesheetManagement.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTimesheetManagement;

public partial class ClockManagementForm : Form
{
    Timesheet timeSheet;
    public ClockManagementForm(Timesheet timeSheet)
    {
        this.timeSheet = timeSheet;
        InitializeComponent();
    }
    private void timer_tick(object sender, EventArgs e)
    {
        currentTimeLabel.Text = DateTime.Now.ToString();
    }
    private void clockinButton_Click(object sender, EventArgs e)
    {
        try
        {
            timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 0));
            ShowMessage("Time-in Successfully", true);
        }
        catch (ArgumentException Ae)
        {
            ShowMessage(Ae.Message, false);
        }
    }
    private void clockoutButton_Click(Object sender, EventArgs e)
    {
        try
        {
            timeSheet.LogEmployee(cardnoTextBox.Text, new Log(DateTime.Now, 1));
            ShowMessage("Time-out Successfully", true);
        }
        catch (ArgumentException Ae)
        {
            ShowMessage(Ae.Message, false);
        }
    }
    private void ShowMessage(string message, bool Issucceed)
    {
        if (Issucceed)
        {
            MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        cardnoTextBox.Clear();
        cardnoTextBox.Focus();
    }
    private void currentTimeLabel_Click(object sender, EventArgs e)
    {

    }
    private void ClockManagementForm_Closing(FormClosingEventArgs e)
    {
        TimeSheetDataStorage.SaveTimeSheetToStorage(timeSheet);
    }
}
