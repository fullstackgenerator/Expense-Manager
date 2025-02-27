namespace Expense_Manager
{
    partial class expenseManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            labelVendorsEntry = new Label();
            labelDateEntry = new Label();
            labelAmountEntry = new Label();
            comboBoxVendorsEntry = new ComboBox();
            dateTimePickerEntry = new DateTimePicker();
            numericUpDownAmountEntry = new NumericUpDown();
            comboBoxVendorsFilter = new ComboBox();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            labelDateFrom = new Label();
            labelDateTo = new Label();
            buttonConfirmFilter = new Button();
            buttonResetFilter = new Button();
            buttonConfirmEntry = new Button();
            buttonDeleteEntry = new Button();
            buttonEditEntry = new Button();
            buttonCloseApp = new Button();
            labelVendorsFilter = new Label();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountEntry).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 393);
            dataGridView1.TabIndex = 0;
            // 
            // labelVendorsEntry
            // 
            labelVendorsEntry.AutoSize = true;
            labelVendorsEntry.Location = new Point(469, 28);
            labelVendorsEntry.Name = "labelVendorsEntry";
            labelVendorsEntry.Size = new Size(102, 20);
            labelVendorsEntry.TabIndex = 1;
            labelVendorsEntry.Text = "Select vendor:";
            // 
            // labelDateEntry
            // 
            labelDateEntry.AutoSize = true;
            labelDateEntry.Location = new Point(469, 81);
            labelDateEntry.Name = "labelDateEntry";
            labelDateEntry.Size = new Size(86, 20);
            labelDateEntry.TabIndex = 2;
            labelDateEntry.Text = "Select date:";
            // 
            // labelAmountEntry
            // 
            labelAmountEntry.AutoSize = true;
            labelAmountEntry.Location = new Point(469, 129);
            labelAmountEntry.Name = "labelAmountEntry";
            labelAmountEntry.Size = new Size(65, 20);
            labelAmountEntry.TabIndex = 3;
            labelAmountEntry.Text = "Amount:";
            // 
            // comboBoxVendorsEntry
            // 
            comboBoxVendorsEntry.FormattingEnabled = true;
            comboBoxVendorsEntry.Location = new Point(586, 25);
            comboBoxVendorsEntry.Name = "comboBoxVendorsEntry";
            comboBoxVendorsEntry.Size = new Size(205, 28);
            comboBoxVendorsEntry.TabIndex = 5;
            // 
            // dateTimePickerEntry
            // 
            dateTimePickerEntry.Location = new Point(586, 76);
            dateTimePickerEntry.Name = "dateTimePickerEntry";
            dateTimePickerEntry.Size = new Size(205, 27);
            dateTimePickerEntry.TabIndex = 6;
            // 
            // numericUpDownAmountEntry
            // 
            numericUpDownAmountEntry.Location = new Point(673, 127);
            numericUpDownAmountEntry.Name = "numericUpDownAmountEntry";
            numericUpDownAmountEntry.Size = new Size(118, 27);
            numericUpDownAmountEntry.TabIndex = 7;
            // 
            // comboBoxVendorsFilter
            // 
            comboBoxVendorsFilter.FormattingEnabled = true;
            comboBoxVendorsFilter.Location = new Point(586, 276);
            comboBoxVendorsFilter.Name = "comboBoxVendorsFilter";
            comboBoxVendorsFilter.Size = new Size(205, 28);
            comboBoxVendorsFilter.TabIndex = 8;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(541, 327);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(250, 27);
            dateTimePickerFrom.TabIndex = 9;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(541, 375);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(250, 27);
            dateTimePickerTo.TabIndex = 10;
            // 
            // labelDateFrom
            // 
            labelDateFrom.AutoSize = true;
            labelDateFrom.Location = new Point(469, 332);
            labelDateFrom.Name = "labelDateFrom";
            labelDateFrom.Size = new Size(46, 20);
            labelDateFrom.TabIndex = 11;
            labelDateFrom.Text = "From:";
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(469, 380);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(28, 20);
            labelDateTo.TabIndex = 12;
            labelDateTo.Text = "To:";
            // 
            // buttonConfirmFilter
            // 
            buttonConfirmFilter.Location = new Point(673, 422);
            buttonConfirmFilter.Name = "buttonConfirmFilter";
            buttonConfirmFilter.Size = new Size(118, 29);
            buttonConfirmFilter.TabIndex = 13;
            buttonConfirmFilter.Text = "confirm filter";
            buttonConfirmFilter.UseVisualStyleBackColor = true;
            // 
            // buttonResetFilter
            // 
            buttonResetFilter.Location = new Point(541, 422);
            buttonResetFilter.Name = "buttonResetFilter";
            buttonResetFilter.Size = new Size(118, 29);
            buttonResetFilter.TabIndex = 14;
            buttonResetFilter.Text = "reset filter";
            buttonResetFilter.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmEntry
            // 
            buttonConfirmEntry.Location = new Point(673, 175);
            buttonConfirmEntry.Name = "buttonConfirmEntry";
            buttonConfirmEntry.Size = new Size(118, 29);
            buttonConfirmEntry.TabIndex = 15;
            buttonConfirmEntry.Text = "confirm";
            buttonConfirmEntry.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEntry
            // 
            buttonDeleteEntry.Location = new Point(541, 223);
            buttonDeleteEntry.Name = "buttonDeleteEntry";
            buttonDeleteEntry.Size = new Size(118, 29);
            buttonDeleteEntry.TabIndex = 16;
            buttonDeleteEntry.Text = "delete";
            buttonDeleteEntry.UseVisualStyleBackColor = true;
            // 
            // buttonEditEntry
            // 
            buttonEditEntry.Location = new Point(541, 175);
            buttonEditEntry.Name = "buttonEditEntry";
            buttonEditEntry.Size = new Size(118, 29);
            buttonEditEntry.TabIndex = 17;
            buttonEditEntry.Text = "edit";
            buttonEditEntry.UseVisualStyleBackColor = true;
            // 
            // buttonCloseApp
            // 
            buttonCloseApp.BackColor = SystemColors.ButtonHighlight;
            buttonCloseApp.Location = new Point(673, 223);
            buttonCloseApp.Name = "buttonCloseApp";
            buttonCloseApp.Size = new Size(118, 29);
            buttonCloseApp.TabIndex = 18;
            buttonCloseApp.Text = "close";
            buttonCloseApp.UseVisualStyleBackColor = false;
            // 
            // labelVendorsFilter
            // 
            labelVendorsFilter.AutoSize = true;
            labelVendorsFilter.Location = new Point(469, 279);
            labelVendorsFilter.Name = "labelVendorsFilter";
            labelVendorsFilter.Size = new Size(101, 20);
            labelVendorsFilter.TabIndex = 19;
            labelVendorsFilter.Text = "Filter vendors:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotal.Location = new Point(25, 426);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(107, 20);
            labelTotal.TabIndex = 20;
            labelTotal.Text = "Total amount:";
            // 
            // expenseManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(812, 473);
            Controls.Add(labelTotal);
            Controls.Add(labelVendorsFilter);
            Controls.Add(buttonCloseApp);
            Controls.Add(buttonEditEntry);
            Controls.Add(buttonDeleteEntry);
            Controls.Add(buttonConfirmEntry);
            Controls.Add(buttonResetFilter);
            Controls.Add(buttonConfirmFilter);
            Controls.Add(labelDateTo);
            Controls.Add(labelDateFrom);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(comboBoxVendorsFilter);
            Controls.Add(numericUpDownAmountEntry);
            Controls.Add(dateTimePickerEntry);
            Controls.Add(comboBoxVendorsEntry);
            Controls.Add(labelAmountEntry);
            Controls.Add(labelDateEntry);
            Controls.Add(labelVendorsEntry);
            Controls.Add(dataGridView1);
            Name = "expenseManager";
            Text = "Expense Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmountEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelVendorsEntry;
        private Label labelDateEntry;
        private Label labelAmountEntry;
        private ComboBox comboBoxVendorsEntry;
        private DateTimePicker dateTimePickerEntry;
        private NumericUpDown numericUpDownAmountEntry;
        private ComboBox comboBoxVendorsFilter;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label labelDateFrom;
        private Label labelDateTo;
        private Button buttonConfirmFilter;
        private Button buttonResetFilter;
        private Button buttonConfirmEntry;
        private Button buttonDeleteEntry;
        private Button buttonEditEntry;
        private Button buttonCloseApp;
        private Label labelVendorsFilter;
        private Label labelTotal;
    }
}
