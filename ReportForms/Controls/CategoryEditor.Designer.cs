namespace ReportForms
{
    partial class CategoryEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxLoadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selfGuidedHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statutoryLoadTotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lizWithoutDivisionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lizWithDivisionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.termProjectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfGuidedHoursNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryLoadTotalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizWithoutDivisionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizWithDivisionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование категории";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.indexTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 287);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Индекс:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // indexTextBox
            // 
            this.indexTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indexTextBox.Location = new System.Drawing.Point(69, 3);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(182, 20);
            this.indexTextBox.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleTextBox.Location = new System.Drawing.Point(69, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(182, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Учебная нагрузка";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maxLoadNumericUpDown, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.selfGuidedHoursNumericUpDown, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 53);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Максимальная:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Самостоятельная работа:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxLoadNumericUpDown
            // 
            this.maxLoadNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxLoadNumericUpDown.Location = new System.Drawing.Point(148, 3);
            this.maxLoadNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxLoadNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.maxLoadNumericUpDown.Name = "maxLoadNumericUpDown";
            this.maxLoadNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.maxLoadNumericUpDown.TabIndex = 0;
            // 
            // selfGuidedHoursNumericUpDown
            // 
            this.selfGuidedHoursNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selfGuidedHoursNumericUpDown.Location = new System.Drawing.Point(148, 29);
            this.selfGuidedHoursNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.selfGuidedHoursNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.selfGuidedHoursNumericUpDown.Name = "selfGuidedHoursNumericUpDown";
            this.selfGuidedHoursNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.selfGuidedHoursNumericUpDown.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обязательная нагрузка";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lizWithDivisionNumericUpDown, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.statutoryLoadTotalNumericUpDown, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lizWithoutDivisionNumericUpDown, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.termProjectNumericUpDown, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(242, 98);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Всего:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "ЛИЗ без деления:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statutoryLoadTotalNumericUpDown
            // 
            this.statutoryLoadTotalNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statutoryLoadTotalNumericUpDown.Location = new System.Drawing.Point(128, 3);
            this.statutoryLoadTotalNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.statutoryLoadTotalNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.statutoryLoadTotalNumericUpDown.Name = "statutoryLoadTotalNumericUpDown";
            this.statutoryLoadTotalNumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.statutoryLoadTotalNumericUpDown.TabIndex = 0;
            // 
            // lizWithoutDivisionNumericUpDown
            // 
            this.lizWithoutDivisionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lizWithoutDivisionNumericUpDown.Location = new System.Drawing.Point(128, 29);
            this.lizWithoutDivisionNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lizWithoutDivisionNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.lizWithoutDivisionNumericUpDown.Name = "lizWithoutDivisionNumericUpDown";
            this.lizWithoutDivisionNumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.lizWithoutDivisionNumericUpDown.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "ЛИЗ с делением:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Курс. проект (работа):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lizWithDivisionNumericUpDown
            // 
            this.lizWithDivisionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lizWithDivisionNumericUpDown.Location = new System.Drawing.Point(128, 55);
            this.lizWithDivisionNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lizWithDivisionNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.lizWithDivisionNumericUpDown.Name = "lizWithDivisionNumericUpDown";
            this.lizWithDivisionNumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.lizWithDivisionNumericUpDown.TabIndex = 2;
            // 
            // termProjectNumericUpDown
            // 
            this.termProjectNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termProjectNumericUpDown.Location = new System.Drawing.Point(128, 75);
            this.termProjectNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.termProjectNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.termProjectNumericUpDown.Name = "termProjectNumericUpDown";
            this.termProjectNumericUpDown.Size = new System.Drawing.Size(111, 20);
            this.termProjectNumericUpDown.TabIndex = 3;
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.applyButton.Location = new System.Drawing.Point(176, 256);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 28);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // CategoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryEditor";
            this.Size = new System.Drawing.Size(263, 322);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLoadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfGuidedHoursNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryLoadTotalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizWithoutDivisionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lizWithDivisionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxLoadNumericUpDown;
        private System.Windows.Forms.NumericUpDown selfGuidedHoursNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown lizWithDivisionNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown statutoryLoadTotalNumericUpDown;
        private System.Windows.Forms.NumericUpDown lizWithoutDivisionNumericUpDown;
        private System.Windows.Forms.NumericUpDown termProjectNumericUpDown;
        private System.Windows.Forms.Button applyButton;
    }
}
