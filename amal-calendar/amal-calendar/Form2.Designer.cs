namespace amal_calendar
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createCalButton = new Button();
            openCalButton = new Button();
            calNameLabel = new Label();
            calNameTextbox = new TextBox();
            availableCalListbox = new ListBox();
            availableCalLabel = new Label();
            logoutButton = new Button();
            deleteCalendarButton = new Button();
            SuspendLayout();
            // 
            // createCalButton
            // 
            createCalButton.BackColor = Color.Ivory;
            createCalButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            createCalButton.Location = new Point(21, 222);
            createCalButton.Name = "createCalButton";
            createCalButton.Size = new Size(274, 120);
            createCalButton.TabIndex = 0;
            createCalButton.Text = "Create New Calendar";
            createCalButton.UseVisualStyleBackColor = false;
            createCalButton.Click += createCalButton_Click;
            // 
            // openCalButton
            // 
            openCalButton.BackColor = Color.Ivory;
            openCalButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            openCalButton.Location = new Point(318, 222);
            openCalButton.Name = "openCalButton";
            openCalButton.Size = new Size(261, 55);
            openCalButton.TabIndex = 1;
            openCalButton.Text = "Open Selected Calendar";
            openCalButton.UseVisualStyleBackColor = false;
            openCalButton.Click += openCalButton_Click;
            // 
            // calNameLabel
            // 
            calNameLabel.AutoSize = true;
            calNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            calNameLabel.Location = new Point(63, 49);
            calNameLabel.Name = "calNameLabel";
            calNameLabel.Size = new Size(192, 35);
            calNameLabel.TabIndex = 2;
            calNameLabel.Text = "Calendar Name:";
            // 
            // calNameTextbox
            // 
            calNameTextbox.BackColor = Color.NavajoWhite;
            calNameTextbox.Location = new Point(21, 99);
            calNameTextbox.Name = "calNameTextbox";
            calNameTextbox.Size = new Size(274, 27);
            calNameTextbox.TabIndex = 3;
            // 
            // availableCalListbox
            // 
            availableCalListbox.BackColor = Color.NavajoWhite;
            availableCalListbox.FormattingEnabled = true;
            availableCalListbox.ItemHeight = 20;
            availableCalListbox.Location = new Point(325, 99);
            availableCalListbox.Name = "availableCalListbox";
            availableCalListbox.Size = new Size(249, 104);
            availableCalListbox.TabIndex = 4;
            // 
            // availableCalLabel
            // 
            availableCalLabel.AutoSize = true;
            availableCalLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            availableCalLabel.Location = new Point(325, 49);
            availableCalLabel.Name = "availableCalLabel";
            availableCalLabel.Size = new Size(236, 35);
            availableCalLabel.TabIndex = 5;
            availableCalLabel.Text = "Available Calendars:";
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Ivory;
            logoutButton.Location = new Point(498, 12);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(81, 27);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // deleteCalendarButton
            // 
            deleteCalendarButton.BackColor = Color.Ivory;
            deleteCalendarButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deleteCalendarButton.Location = new Point(319, 283);
            deleteCalendarButton.Name = "deleteCalendarButton";
            deleteCalendarButton.Size = new Size(260, 59);
            deleteCalendarButton.TabIndex = 7;
            deleteCalendarButton.Text = "Delete Selected Calendar";
            deleteCalendarButton.UseVisualStyleBackColor = false;
            deleteCalendarButton.Click += deleteCalendarButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(607, 382);
            Controls.Add(deleteCalendarButton);
            Controls.Add(logoutButton);
            Controls.Add(availableCalLabel);
            Controls.Add(availableCalListbox);
            Controls.Add(calNameTextbox);
            Controls.Add(calNameLabel);
            Controls.Add(openCalButton);
            Controls.Add(createCalButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createCalButton;
        private Button openCalButton;
        private Label calNameLabel;
        private TextBox calNameTextbox;
        private ListBox availableCalListbox;
        private Label availableCalLabel;
        private Button logoutButton;
        private Button deleteCalendarButton;
    }
}