using System.Configuration;

namespace EmployeeTimesheetManagement;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    protected override void OnFormClosing(FormClosingEventArgs e) {
        MainForm_FormClosing(e);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        EmployeeTimesheetManagerLabel = new Label();
        ManageEmployeeButton = new Button();
        TimeRecordButton = new Button();
        SuspendLayout();
        // 
        // EmployeeTimesheetManagerLabel
        // 
        EmployeeTimesheetManagerLabel.AutoSize = true;
        EmployeeTimesheetManagerLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        EmployeeTimesheetManagerLabel.Location = new Point(288, 70);
        EmployeeTimesheetManagerLabel.Name = "EmployeeTimesheetManagerLabel";
        EmployeeTimesheetManagerLabel.Size = new Size(557, 54);
        EmployeeTimesheetManagerLabel.TabIndex = 1;
        EmployeeTimesheetManagerLabel.Text = "Employee Timesheet Manager";
        // 
        // ManageEmployeeButton
        // 
        ManageEmployeeButton.Location = new Point(435, 266);
        ManageEmployeeButton.Name = "ManageEmployeeButton";
        ManageEmployeeButton.Size = new Size(267, 64);
        ManageEmployeeButton.TabIndex = 2;
        ManageEmployeeButton.Text = "Manage Employee";
        ManageEmployeeButton.UseVisualStyleBackColor = true;
        ManageEmployeeButton.Click += ManageEmployeeButton_Click;
        // 
        // TimeRecordButton
        // 
        TimeRecordButton.Location = new Point(435, 174);
        TimeRecordButton.Name = "TimeRecordButton";
        TimeRecordButton.Size = new Size(267, 61);
        TimeRecordButton.TabIndex = 3;
        TimeRecordButton.Text = "Time Record";
        TimeRecordButton.UseVisualStyleBackColor = true;
        TimeRecordButton.Click += TimeRecordButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1156, 626);
        Controls.Add(TimeRecordButton);
        Controls.Add(ManageEmployeeButton);
        Controls.Add(EmployeeTimesheetManagerLabel);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainForm";
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
}

    #endregion

    private Label EmployeeTimesheetManagerLabel;
    private Button ManageEmployeeButton;
    private Button TimeRecordButton;
}