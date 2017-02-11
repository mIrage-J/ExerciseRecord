namespace ExerciseRecord
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Start = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recordGird = new System.Windows.Forms.DataGridView();
            this.addRowButton = new System.Windows.Forms.Button();
            this.removeRowButton = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.stratButton = new System.Windows.Forms.Button();
            this.endTimingButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerForStripStatus = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Start
            // 
            this.Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(40, 22);
            this.Start.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 32);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 21);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // recordGird
            // 
            this.recordGird.AllowUserToAddRows = false;
            this.recordGird.BackgroundColor = System.Drawing.SystemColors.Window;
            this.recordGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGird.Location = new System.Drawing.Point(12, 68);
            this.recordGird.Name = "recordGird";
            this.recordGird.RowTemplate.Height = 23;
            this.recordGird.Size = new System.Drawing.Size(863, 320);
            this.recordGird.TabIndex = 2;
            this.recordGird.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordGird_CellValueChanged);
            this.recordGird.CurrentCellDirtyStateChanged += new System.EventHandler(this.recordGird_CurrentCellDirtyStateChanged);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(225, 26);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(118, 36);
            this.addRowButton.TabIndex = 3;
            this.addRowButton.Text = "Add";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButoon_Click);
            // 
            // removeRowButton
            // 
            this.removeRowButton.Location = new System.Drawing.Point(349, 26);
            this.removeRowButton.Name = "removeRowButton";
            this.removeRowButton.Size = new System.Drawing.Size(127, 36);
            this.removeRowButton.TabIndex = 4;
            this.removeRowButton.Text = "Remove";
            this.removeRowButton.UseVisualStyleBackColor = true;
            this.removeRowButton.Click += new System.EventHandler(this.removeRowButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(748, 26);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 36);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "(abandoned)Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // stratButton
            // 
            this.stratButton.Location = new System.Drawing.Point(482, 26);
            this.stratButton.Name = "stratButton";
            this.stratButton.Size = new System.Drawing.Size(127, 36);
            this.stratButton.TabIndex = 6;
            this.stratButton.Text = "Start\nTiming";
            this.stratButton.UseVisualStyleBackColor = true;
            this.stratButton.Click += new System.EventHandler(this.stratButton_Click);
            // 
            // endTimingButton
            // 
            this.endTimingButton.Location = new System.Drawing.Point(615, 26);
            this.endTimingButton.Name = "endTimingButton";
            this.endTimingButton.Size = new System.Drawing.Size(127, 36);
            this.endTimingButton.TabIndex = 7;
            this.endTimingButton.Text = "End\nTiming";
            this.endTimingButton.UseVisualStyleBackColor = true;
            this.endTimingButton.Click += new System.EventHandler(this.endTimingButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerStripStatusLabel
            // 
            this.timerStripStatusLabel.Name = "timerStripStatusLabel";
            this.timerStripStatusLabel.Size = new System.Drawing.Size(41, 17);
            this.timerStripStatusLabel.Text = "Timer";
            // 
            // timerForStripStatus
            // 
            this.timerForStripStatus.Interval = 500;
            this.timerForStripStatus.Tick += new System.EventHandler(this.timerForStripStatus_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataSource = typeof(ExerciseRecord.Entry);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.endTimingButton);
            this.Controls.Add(this.stratButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeRowButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.recordGird);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ExerciseRecord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView recordGird;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button removeRowButton;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ToolStripDropDownButton Start;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button stratButton;
        private System.Windows.Forms.Button endTimingButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timerStripStatusLabel;
        private System.Windows.Forms.Timer timerForStripStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

