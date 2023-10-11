namespace GUI_Features
{
    partial class FormGUIFeatures
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
            this.TextBoxBikeModel = new System.Windows.Forms.TextBox();
            this.labelBikeModel = new System.Windows.Forms.Label();
            this.groupBoxManufacturer = new System.Windows.Forms.GroupBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.radioButtonYamaha = new System.Windows.Forms.RadioButton();
            this.radioButtonKawasaki = new System.Windows.Forms.RadioButton();
            this.radioButtonSuzuki = new System.Windows.Forms.RadioButton();
            this.radioButtonHonda = new System.Windows.Forms.RadioButton();
            this.ComboBoxStyle = new System.Windows.Forms.ComboBox();
            this.labelStyle = new System.Windows.Forms.Label();
            this.numericUpDownEngine = new System.Windows.Forms.NumericUpDown();
            this.labelEngin = new System.Windows.Forms.Label();
            this.ListViewBikeDisplay = new System.Windows.Forms.ListView();
            this.columnHeaderBikeModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEngine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonAddNewBike = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonFindBike = new System.Windows.Forms.Button();
            this.groupBoxAccessories = new System.Windows.Forms.GroupBox();
            this.checkBoxMount = new System.Windows.Forms.CheckBox();
            this.checkBoxCruise = new System.Windows.Forms.CheckBox();
            this.checkBoxUSB = new System.Windows.Forms.CheckBox();
            this.statusStripMsg = new System.Windows.Forms.StatusStrip();
            this.ErrorMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEngine)).BeginInit();
            this.groupBoxAccessories.SuspendLayout();
            this.statusStripMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxBikeModel
            // 
            this.TextBoxBikeModel.Location = new System.Drawing.Point(12, 12);
            this.TextBoxBikeModel.Name = "TextBoxBikeModel";
            this.TextBoxBikeModel.Size = new System.Drawing.Size(121, 20);
            this.TextBoxBikeModel.TabIndex = 0;
            // 
            // labelBikeModel
            // 
            this.labelBikeModel.AutoSize = true;
            this.labelBikeModel.Location = new System.Drawing.Point(139, 15);
            this.labelBikeModel.Name = "labelBikeModel";
            this.labelBikeModel.Size = new System.Drawing.Size(60, 13);
            this.labelBikeModel.TabIndex = 1;
            this.labelBikeModel.Text = "Bike Model";
            // 
            // groupBoxManufacturer
            // 
            this.groupBoxManufacturer.Controls.Add(this.radioButtonOther);
            this.groupBoxManufacturer.Controls.Add(this.radioButtonYamaha);
            this.groupBoxManufacturer.Controls.Add(this.radioButtonKawasaki);
            this.groupBoxManufacturer.Controls.Add(this.radioButtonSuzuki);
            this.groupBoxManufacturer.Controls.Add(this.radioButtonHonda);
            this.groupBoxManufacturer.Location = new System.Drawing.Point(12, 48);
            this.groupBoxManufacturer.Name = "groupBoxManufacturer";
            this.groupBoxManufacturer.Size = new System.Drawing.Size(99, 140);
            this.groupBoxManufacturer.TabIndex = 2;
            this.groupBoxManufacturer.TabStop = false;
            this.groupBoxManufacturer.Text = "Manufacturer";
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(19, 111);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOther.TabIndex = 4;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonYamaha
            // 
            this.radioButtonYamaha.AutoSize = true;
            this.radioButtonYamaha.Location = new System.Drawing.Point(19, 88);
            this.radioButtonYamaha.Name = "radioButtonYamaha";
            this.radioButtonYamaha.Size = new System.Drawing.Size(64, 17);
            this.radioButtonYamaha.TabIndex = 3;
            this.radioButtonYamaha.TabStop = true;
            this.radioButtonYamaha.Text = "Yamaha";
            this.radioButtonYamaha.UseVisualStyleBackColor = true;
            // 
            // radioButtonKawasaki
            // 
            this.radioButtonKawasaki.AutoSize = true;
            this.radioButtonKawasaki.Location = new System.Drawing.Point(19, 65);
            this.radioButtonKawasaki.Name = "radioButtonKawasaki";
            this.radioButtonKawasaki.Size = new System.Drawing.Size(71, 17);
            this.radioButtonKawasaki.TabIndex = 2;
            this.radioButtonKawasaki.TabStop = true;
            this.radioButtonKawasaki.Text = "Kawasaki";
            this.radioButtonKawasaki.UseVisualStyleBackColor = true;
            // 
            // radioButtonSuzuki
            // 
            this.radioButtonSuzuki.AutoSize = true;
            this.radioButtonSuzuki.Location = new System.Drawing.Point(19, 42);
            this.radioButtonSuzuki.Name = "radioButtonSuzuki";
            this.radioButtonSuzuki.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSuzuki.TabIndex = 1;
            this.radioButtonSuzuki.TabStop = true;
            this.radioButtonSuzuki.Text = "Suzuki";
            this.radioButtonSuzuki.UseVisualStyleBackColor = true;
            // 
            // radioButtonHonda
            // 
            this.radioButtonHonda.AutoSize = true;
            this.radioButtonHonda.Location = new System.Drawing.Point(19, 19);
            this.radioButtonHonda.Name = "radioButtonHonda";
            this.radioButtonHonda.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHonda.TabIndex = 0;
            this.radioButtonHonda.TabStop = true;
            this.radioButtonHonda.Text = "Honda";
            this.radioButtonHonda.UseVisualStyleBackColor = true;
            // 
            // ComboBoxStyle
            // 
            this.ComboBoxStyle.FormattingEnabled = true;
            this.ComboBoxStyle.Items.AddRange(new object[] {
            "",
            "Adventure",
            "Naked",
            "Off Road",
            "Sports",
            "Tourer",
            "Unknown"});
            this.ComboBoxStyle.Location = new System.Drawing.Point(48, 201);
            this.ComboBoxStyle.Name = "ComboBoxStyle";
            this.ComboBoxStyle.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStyle.Sorted = true;
            this.ComboBoxStyle.TabIndex = 3;
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Location = new System.Drawing.Point(9, 204);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(30, 13);
            this.labelStyle.TabIndex = 4;
            this.labelStyle.Text = "Style";
            // 
            // numericUpDownEngine
            // 
            this.numericUpDownEngine.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEngine.Location = new System.Drawing.Point(105, 230);
            this.numericUpDownEngine.Maximum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.numericUpDownEngine.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.numericUpDownEngine.Name = "numericUpDownEngine";
            this.numericUpDownEngine.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownEngine.TabIndex = 5;
            this.numericUpDownEngine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownEngine.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // labelEngin
            // 
            this.labelEngin.AutoSize = true;
            this.labelEngin.Location = new System.Drawing.Point(9, 232);
            this.labelEngin.Name = "labelEngin";
            this.labelEngin.Size = new System.Drawing.Size(84, 13);
            this.labelEngin.TabIndex = 6;
            this.labelEngin.Text = "Engine Capacity";
            // 
            // ListViewBikeDisplay
            // 
            this.ListViewBikeDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBikeModel,
            this.columnHeaderManufacturer,
            this.columnHeaderStyle,
            this.columnHeaderEngine});
            this.ListViewBikeDisplay.FullRowSelect = true;
            this.ListViewBikeDisplay.HideSelection = false;
            this.ListViewBikeDisplay.Location = new System.Drawing.Point(249, 12);
            this.ListViewBikeDisplay.Name = "ListViewBikeDisplay";
            this.ListViewBikeDisplay.Size = new System.Drawing.Size(374, 238);
            this.ListViewBikeDisplay.TabIndex = 7;
            this.ListViewBikeDisplay.UseCompatibleStateImageBehavior = false;
            this.ListViewBikeDisplay.View = System.Windows.Forms.View.Details;
            this.ListViewBikeDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewBikeDisplay_MouseClick);
            // 
            // columnHeaderBikeModel
            // 
            this.columnHeaderBikeModel.Text = "Bike Model";
            this.columnHeaderBikeModel.Width = 110;
            // 
            // columnHeaderManufacturer
            // 
            this.columnHeaderManufacturer.Text = "Manufacturer";
            this.columnHeaderManufacturer.Width = 90;
            // 
            // columnHeaderStyle
            // 
            this.columnHeaderStyle.Text = "Style";
            this.columnHeaderStyle.Width = 80;
            // 
            // columnHeaderEngine
            // 
            this.columnHeaderEngine.Text = "Engine Cap.";
            this.columnHeaderEngine.Width = 80;
            // 
            // ButtonAddNewBike
            // 
            this.ButtonAddNewBike.Location = new System.Drawing.Point(13, 256);
            this.ButtonAddNewBike.Name = "ButtonAddNewBike";
            this.ButtonAddNewBike.Size = new System.Drawing.Size(120, 35);
            this.ButtonAddNewBike.TabIndex = 8;
            this.ButtonAddNewBike.Text = "Add New Bike";
            this.ButtonAddNewBike.UseVisualStyleBackColor = true;
            this.ButtonAddNewBike.Click += new System.EventHandler(this.ButtonAddNewBike_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(330, 262);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(411, 262);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 10;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonFindBike
            // 
            this.ButtonFindBike.Location = new System.Drawing.Point(249, 262);
            this.ButtonFindBike.Name = "ButtonFindBike";
            this.ButtonFindBike.Size = new System.Drawing.Size(75, 23);
            this.ButtonFindBike.TabIndex = 11;
            this.ButtonFindBike.Text = "Find Bike";
            this.ButtonFindBike.UseVisualStyleBackColor = true;
            this.ButtonFindBike.Click += new System.EventHandler(this.ButtonFindBike_Click);
            // 
            // groupBoxAccessories
            // 
            this.groupBoxAccessories.Controls.Add(this.checkBoxMount);
            this.groupBoxAccessories.Controls.Add(this.checkBoxCruise);
            this.groupBoxAccessories.Controls.Add(this.checkBoxUSB);
            this.groupBoxAccessories.Location = new System.Drawing.Point(126, 48);
            this.groupBoxAccessories.Name = "groupBoxAccessories";
            this.groupBoxAccessories.Size = new System.Drawing.Size(108, 105);
            this.groupBoxAccessories.TabIndex = 12;
            this.groupBoxAccessories.TabStop = false;
            this.groupBoxAccessories.Text = "Accessories";
            // 
            // checkBoxMount
            // 
            this.checkBoxMount.AutoSize = true;
            this.checkBoxMount.Location = new System.Drawing.Point(6, 66);
            this.checkBoxMount.Name = "checkBoxMount";
            this.checkBoxMount.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMount.TabIndex = 2;
            this.checkBoxMount.Text = "Phone Mnt";
            this.checkBoxMount.UseVisualStyleBackColor = true;
            // 
            // checkBoxCruise
            // 
            this.checkBoxCruise.AutoSize = true;
            this.checkBoxCruise.Location = new System.Drawing.Point(6, 43);
            this.checkBoxCruise.Name = "checkBoxCruise";
            this.checkBoxCruise.Size = new System.Drawing.Size(76, 17);
            this.checkBoxCruise.TabIndex = 1;
            this.checkBoxCruise.Text = "Cruise Cntl";
            this.checkBoxCruise.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSB
            // 
            this.checkBoxUSB.AutoSize = true;
            this.checkBoxUSB.Location = new System.Drawing.Point(6, 20);
            this.checkBoxUSB.Name = "checkBoxUSB";
            this.checkBoxUSB.Size = new System.Drawing.Size(48, 17);
            this.checkBoxUSB.TabIndex = 0;
            this.checkBoxUSB.Text = "USB";
            this.checkBoxUSB.UseVisualStyleBackColor = true;
            // 
            // statusStripMsg
            // 
            this.statusStripMsg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrorMsg});
            this.statusStripMsg.Location = new System.Drawing.Point(0, 318);
            this.statusStripMsg.Name = "statusStripMsg";
            this.statusStripMsg.Size = new System.Drawing.Size(644, 22);
            this.statusStripMsg.TabIndex = 13;
            this.statusStripMsg.Text = "statusStrip1";
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(88, 17);
            this.ErrorMsg.Text = "Status Message";
            // 
            // FormGUIFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 340);
            this.Controls.Add(this.statusStripMsg);
            this.Controls.Add(this.groupBoxAccessories);
            this.Controls.Add(this.ButtonFindBike);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonAddNewBike);
            this.Controls.Add(this.ListViewBikeDisplay);
            this.Controls.Add(this.labelEngin);
            this.Controls.Add(this.numericUpDownEngine);
            this.Controls.Add(this.labelStyle);
            this.Controls.Add(this.ComboBoxStyle);
            this.Controls.Add(this.groupBoxManufacturer);
            this.Controls.Add(this.labelBikeModel);
            this.Controls.Add(this.TextBoxBikeModel);
            this.Name = "FormGUIFeatures";
            this.Text = "GUI Features";
            this.groupBoxManufacturer.ResumeLayout(false);
            this.groupBoxManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEngine)).EndInit();
            this.groupBoxAccessories.ResumeLayout(false);
            this.groupBoxAccessories.PerformLayout();
            this.statusStripMsg.ResumeLayout(false);
            this.statusStripMsg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxBikeModel;
        private System.Windows.Forms.Label labelBikeModel;
        private System.Windows.Forms.GroupBox groupBoxManufacturer;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.RadioButton radioButtonYamaha;
        private System.Windows.Forms.RadioButton radioButtonKawasaki;
        private System.Windows.Forms.RadioButton radioButtonSuzuki;
        private System.Windows.Forms.RadioButton radioButtonHonda;
        private System.Windows.Forms.ComboBox ComboBoxStyle;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.NumericUpDown numericUpDownEngine;
        private System.Windows.Forms.Label labelEngin;
        private System.Windows.Forms.ListView ListViewBikeDisplay;
        private System.Windows.Forms.ColumnHeader columnHeaderBikeModel;
        private System.Windows.Forms.ColumnHeader columnHeaderManufacturer;
        private System.Windows.Forms.ColumnHeader columnHeaderStyle;
        private System.Windows.Forms.ColumnHeader columnHeaderEngine;
        private System.Windows.Forms.Button ButtonAddNewBike;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonFindBike;
        private System.Windows.Forms.GroupBox groupBoxAccessories;
        private System.Windows.Forms.CheckBox checkBoxMount;
        private System.Windows.Forms.CheckBox checkBoxCruise;
        private System.Windows.Forms.CheckBox checkBoxUSB;
        private System.Windows.Forms.StatusStrip statusStripMsg;
        private System.Windows.Forms.ToolStripStatusLabel ErrorMsg;
    }
}

