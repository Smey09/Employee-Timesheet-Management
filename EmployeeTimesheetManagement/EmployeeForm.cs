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

public partial class EmployeeForm : Form
{
    Timesheet timeSheet;
    public EmployeeForm(Timesheet timeSheet)
    {
        InitializeComponent();
        this.timeSheet = timeSheet;

        LoadToGrid(true);
        identityTextBox.Enabled = false;
        fullnameTextBox.Enabled = false;
        positionTextBox.Enabled = false;
        cardnoTextBox.Enabled = false;
        updateButton.Enabled = false;
        saveButton.Enabled = false;
        DeleteButton.Enabled = false;

    }

    private void addnewButton_Click(object sender, EventArgs e)
    {
        identityTextBox.Clear();
        fullnameTextBox.Clear();
        positionTextBox.Clear();
        cardnoTextBox.Clear();
        fullnameTextBox.Focus(); 
        fullnameTextBox.Enabled = true;
        positionTextBox.Enabled = true;
        cardnoTextBox.Enabled = true;
        saveButton.Enabled = true;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        string cardNo = cardnoTextBox.Text.Trim();
        try
        {
            int foundIndex = timeSheet.GetAllEmployees(true).FindIndex(em => em.CardNo == cardnoTextBox.Text.Trim());
            if (foundIndex == -1) {
                var emp = new Employee(
                    fullnameTextBox.Text.Trim(),
                    positionTextBox.Text.Trim(),
                    cardnoTextBox.Text.Trim()
                    );
                timeSheet.AddEmployee(emp);
                saveButton.Enabled = false;
            }
            else 
                MessageBox.Show("The CardNo is already used. Please try a different CardNo");
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
        finally
        {
            addnewButton.Enabled = true;
            LoadToGrid(true);
        }
    }
    private void LoadToGrid()
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = timeSheet.GetAllEmployees();
        dataGridView1.Refresh();
    }
    private void LoadToGrid(bool isSimpleVersion)
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = timeSheet.GetAllEmployees(isSimpleVersion);
        dataGridView1.Refresh();

    }
    private void updateButton_Click(object sender, EventArgs e)
    {
        try
        {
            timeSheet.UpdateEmployee(identityTextBox.Text, fullnameTextBox.Text, positionTextBox.Text);
            LoadToGrid(true);
        }
        catch (ArgumentException Ae)
        {
            MessageBox.Show(Ae.Message);
        }
        finally
        {
            addnewButton.Enabled = true;
            saveButton.Enabled = true;
            updateButton.Enabled = false;
        }
    }
    private void DeleteButton_Click(object sender, EventArgs e)
    {
        Guid id = new Guid(identityTextBox.Text);
        timeSheet.RemoveEmployee(id);
        LoadToGrid(true);
        DeleteButton.Enabled = false;
        updateButton.Enabled = false;
    }
    private void dataGridView1_SelectionChanged(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
        {
            identityTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
            fullnameTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
            positionTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cardnoTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
            fullnameTextBox.Enabled = true;
            positionTextBox.Enabled = true;
            cardnoTextBox.Enabled = false;
            addnewButton.Enabled = true;
            saveButton.Enabled = false;
            updateButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
    }

    private void EmployeeForm_Closing(FormClosingEventArgs e) {
        TimeSheetDataStorage.SaveTimeSheetToStorage(timeSheet);
    }
}
