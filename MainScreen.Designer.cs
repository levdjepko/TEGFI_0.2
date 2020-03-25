namespace TEGFI_3
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadExpenses_button = new System.Windows.Forms.Button();
            this.addExpense_Button = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modifyExpense_Button = new System.Windows.Forms.Button();
            this.deleteExpense_Button = new System.Windows.Forms.Button();
            this.oneTime_Button = new System.Windows.Forms.RadioButton();
            this.monthlyButton = new System.Windows.Forms.RadioButton();
            this.selectedRowsButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenYears_1 = new System.Windows.Forms.Label();
            this.tenYears_Amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_Button.Location = new System.Drawing.Point(864, 363);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 0;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(397, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 258);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loadExpenses_button
            // 
            this.loadExpenses_button.Location = new System.Drawing.Point(397, 346);
            this.loadExpenses_button.Name = "loadExpenses_button";
            this.loadExpenses_button.Size = new System.Drawing.Size(147, 30);
            this.loadExpenses_button.TabIndex = 2;
            this.loadExpenses_button.Text = "Load All Expenses";
            this.loadExpenses_button.UseVisualStyleBackColor = true;
            this.loadExpenses_button.Click += new System.EventHandler(this.loadExpenses_button_Click);
            // 
            // addExpense_Button
            // 
            this.addExpense_Button.Location = new System.Drawing.Point(54, 105);
            this.addExpense_Button.Name = "addExpense_Button";
            this.addExpense_Button.Size = new System.Drawing.Size(155, 41);
            this.addExpense_Button.TabIndex = 3;
            this.addExpense_Button.Text = "Add expense";
            this.addExpense_Button.UseVisualStyleBackColor = true;
            this.addExpense_Button.Click += new System.EventHandler(this.addExpense_Button_Click);
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountBox.Location = new System.Drawing.Point(110, 69);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(125, 26);
            this.amountBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount";
            // 
            // modifyExpense_Button
            // 
            this.modifyExpense_Button.Location = new System.Drawing.Point(54, 158);
            this.modifyExpense_Button.Name = "modifyExpense_Button";
            this.modifyExpense_Button.Size = new System.Drawing.Size(155, 41);
            this.modifyExpense_Button.TabIndex = 6;
            this.modifyExpense_Button.Text = "Modify expense";
            this.modifyExpense_Button.UseVisualStyleBackColor = true;
            this.modifyExpense_Button.Click += new System.EventHandler(this.modifyExpense_Button_Click);
            // 
            // deleteExpense_Button
            // 
            this.deleteExpense_Button.Location = new System.Drawing.Point(54, 211);
            this.deleteExpense_Button.Name = "deleteExpense_Button";
            this.deleteExpense_Button.Size = new System.Drawing.Size(155, 41);
            this.deleteExpense_Button.TabIndex = 7;
            this.deleteExpense_Button.Text = "Delete expense";
            this.deleteExpense_Button.UseVisualStyleBackColor = true;
            this.deleteExpense_Button.Click += new System.EventHandler(this.deleteExpense_Button_Click);
            // 
            // oneTime_Button
            // 
            this.oneTime_Button.AutoSize = true;
            this.oneTime_Button.Checked = true;
            this.oneTime_Button.Location = new System.Drawing.Point(264, 105);
            this.oneTime_Button.Name = "oneTime_Button";
            this.oneTime_Button.Size = new System.Drawing.Size(67, 17);
            this.oneTime_Button.TabIndex = 8;
            this.oneTime_Button.TabStop = true;
            this.oneTime_Button.Text = "One-time";
            this.oneTime_Button.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            this.monthlyButton.AutoSize = true;
            this.monthlyButton.Location = new System.Drawing.Point(264, 129);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(62, 17);
            this.monthlyButton.TabIndex = 9;
            this.monthlyButton.Text = "Monthly";
            this.monthlyButton.UseVisualStyleBackColor = true;
            // 
            // selectedRowsButton
            // 
            this.selectedRowsButton.Location = new System.Drawing.Point(172, 306);
            this.selectedRowsButton.Name = "selectedRowsButton";
            this.selectedRowsButton.Size = new System.Drawing.Size(75, 23);
            this.selectedRowsButton.TabIndex = 10;
            this.selectedRowsButton.Text = "button1";
            this.selectedRowsButton.UseVisualStyleBackColor = true;
            this.selectedRowsButton.Click += new System.EventHandler(this.selectedRowsButton_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(624, 22);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(158, 20);
            this.userName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "User name";
            // 
            // tenYears_1
            // 
            this.tenYears_1.AutoSize = true;
            this.tenYears_1.Location = new System.Drawing.Point(261, 158);
            this.tenYears_1.Name = "tenYears_1";
            this.tenYears_1.Size = new System.Drawing.Size(59, 13);
            this.tenYears_1.TabIndex = 13;
            this.tenYears_1.Text = "Ten Years:";
            // 
            // tenYears_Amount
            // 
            this.tenYears_Amount.AutoSize = true;
            this.tenYears_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenYears_Amount.Location = new System.Drawing.Point(264, 185);
            this.tenYears_Amount.Name = "tenYears_Amount";
            this.tenYears_Amount.Size = new System.Drawing.Size(0, 16);
            this.tenYears_Amount.TabIndex = 14;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(973, 409);
            this.Controls.Add(this.tenYears_Amount);
            this.Controls.Add(this.tenYears_1);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedRowsButton);
            this.Controls.Add(this.monthlyButton);
            this.Controls.Add(this.oneTime_Button);
            this.Controls.Add(this.deleteExpense_Button);
            this.Controls.Add(this.modifyExpense_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.addExpense_Button);
            this.Controls.Add(this.loadExpenses_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exit_Button);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadExpenses_button;
        private System.Windows.Forms.Button addExpense_Button;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifyExpense_Button;
        private System.Windows.Forms.Button deleteExpense_Button;
        private System.Windows.Forms.RadioButton oneTime_Button;
        private System.Windows.Forms.RadioButton monthlyButton;
        private System.Windows.Forms.Button selectedRowsButton;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tenYears_1;
        private System.Windows.Forms.Label tenYears_Amount;
    }
}