namespace EmployeeTimesheetManagement;

partial class ClockManagementForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        ClockManagementForm_Closing(e);
    }
    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        ClockFormLabel = new Label();
        currentTimeLabel = new Label();
        CardnoLabel = new Label();
        cardnoTextBox = new TextBox();
        clockinButton = new Button();
        clockoutButton = new Button();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // ClockFormLabel
        // 
        ClockFormLabel.AutoSize = true;
        ClockFormLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        ClockFormLabel.Location = new Point(325, 55);
        ClockFormLabel.Name = "ClockFormLabel";
        ClockFormLabel.Size = new Size(200, 46);
        ClockFormLabel.TabIndex = 0;
        ClockFormLabel.Text = "Clock Form";
        // 
        // currentTimeLabel
        // 
        currentTimeLabel.AutoSize = true;
        currentTimeLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
        currentTimeLabel.Location = new Point(252, 137);
        currentTimeLabel.Name = "currentTimeLabel";
        currentTimeLabel.Size = new Size(99, 46);
        currentTimeLabel.TabIndex = 1;
        currentTimeLabel.Text = "Time";
        currentTimeLabel.TextAlign = ContentAlignment.TopCenter;
        currentTimeLabel.Click += currentTimeLabel_Click;
        // 
        // CardnoLabel
        // 
        CardnoLabel.AutoSize = true;
        CardnoLabel.Location = new Point(178, 264);
        CardnoLabel.Name = "CardnoLabel";
        CardnoLabel.Size = new Size(107, 32);
        CardnoLabel.TabIndex = 2;
        CardnoLabel.Text = "Card No:";
        // 
        // cardnoTextBox
        // 
        cardnoTextBox.Location = new Point(291, 257);
        cardnoTextBox.Name = "cardnoTextBox";
        cardnoTextBox.Size = new Size(327, 39);
        cardnoTextBox.TabIndex = 3;
        // 
        // clockinButton
        // 
        clockinButton.Location = new Point(252, 345);
        clockinButton.Name = "clockinButton";
        clockinButton.Size = new Size(136, 39);
        clockinButton.TabIndex = 4;
        clockinButton.Text = "Time-in";
        clockinButton.UseVisualStyleBackColor = true;
        clockinButton.Click += clockinButton_Click;
        // 
        // clockoutButton
        // 
        clockoutButton.Location = new Point(461, 345);
        clockoutButton.Name = "clockoutButton";
        clockoutButton.Size = new Size(136, 39);
        clockoutButton.TabIndex = 5;
        clockoutButton.Text = "Time-out";
        clockoutButton.UseVisualStyleBackColor = true;
        clockoutButton.Click += clockoutButton_Click;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 10;
        timer1.Tick += timer_tick;
        // 
        // ClockManagementForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(823, 480);
        Controls.Add(clockoutButton);
        Controls.Add(clockinButton);
        Controls.Add(cardnoTextBox);
        Controls.Add(CardnoLabel);
        Controls.Add(currentTimeLabel);
        Controls.Add(ClockFormLabel);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4);
        Name = "ClockManagementForm";
        Text = "ClockManagementForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private void ClockinButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Label ClockFormLabel;
    private Label currentTimeLabel;
    private Label CardnoLabel;
    private TextBox cardnoTextBox;
    private Button clockinButton;
    private Button clockoutButton;
    private System.Windows.Forms.Timer timer1;
}