using EmployeeTimesheetManagement.Features;
using System.Xml.Serialization;

namespace EmployeeTimesheetManagement;

public partial class MainForm : Form
{
    public Timesheet AppTimeSheet = new Timesheet();
    public MainForm()
    {
        InitializeComponent();

        //Load timesheet from Timesheet.json
        AppTimeSheet = TimeSheetDataStorage.LoadTimeSheetFromStorage();
    }
    private void TimeRecordButton_Click(object sender, EventArgs e)
    {
        ClockManagementForm cfrm = new ClockManagementForm(AppTimeSheet);
        cfrm.ShowDialog();
    }
    private void ManageEmployeeButton_Click(Object sender, EventArgs e)
    {
        TimeSheetDataStorage.SaveTimeSheetToStorage(AppTimeSheet);
        EmployeeForm form = new EmployeeForm(AppTimeSheet);
        form.ShowDialog();
    }
    private void MainForm_FormClosing(FormClosingEventArgs e) { TimeSheetDataStorage.SaveTimeSheetToStorage(AppTimeSheet); }
}