namespace Importer
{
    /// <summary>
    /// Class Main.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Main
    {
        /// <summary>
        /// The components
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes of the resources (other than memory) used by the <see cref="T:System.Windows.Forms.Form" />.
        /// </summary>
        /// <param name="disposing"><see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Forms

        /// <summary>
        /// Initializes the component.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.FileLabel = new System.Windows.Forms.Label();
            this.FileTextbox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FailLabel = new System.Windows.Forms.Label();
            this.SuccessfulLabel = new System.Windows.Forms.Label();
            this.FailText = new System.Windows.Forms.TextBox();
            this.SuccessfulText = new System.Windows.Forms.TextBox();
            this.NowExecutingLabel = new System.Windows.Forms.Label();
            this.NowExecutingText = new System.Windows.Forms.TextBox();
            this.FoundLabel = new System.Windows.Forms.Label();
            this.FoundText = new System.Windows.Forms.TextBox();
            this.ErrorLogLabel = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.TextBox();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.txtConn = new System.Windows.Forms.TextBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.GetTablesButton = new System.Windows.Forms.Button();
            this.TablesDropdown = new System.Windows.Forms.ComboBox();
            this.GatherButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolbarStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SaveToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveErrorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFailedQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetFieldsButton = new System.Windows.Forms.Button();
            this.ColumnsList = new System.Windows.Forms.ListBox();
            this.InDatabaseLabel = new System.Windows.Forms.Label();
            this.SingleFieldAddButton = new System.Windows.Forms.Button();
            this.AllFieldsAddButton = new System.Windows.Forms.Button();
            this.AllFieldsRemoveButton = new System.Windows.Forms.Button();
            this.SingleFieldRemoveButton = new System.Windows.Forms.Button();
            this.InQueryLabel = new System.Windows.Forms.Label();
            this.QueryFieldsList = new System.Windows.Forms.ListBox();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.InstructionsText = new System.Windows.Forms.TextBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.GoPictureBoxButton = new System.Windows.Forms.PictureBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoPictureBoxButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(22, 9);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(26, 13);
            this.FileLabel.TabIndex = 0;
            this.FileLabel.Text = "File:";
            // 
            // FileTextbox
            // 
            this.FileTextbox.Location = new System.Drawing.Point(63, 6);
            this.FileTextbox.Name = "FileTextbox";
            this.FileTextbox.Size = new System.Drawing.Size(607, 20);
            this.FileTextbox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(676, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Filter = "csv files | *.csv";
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Location = new System.Drawing.Point(7, 500);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(29, 13);
            this.FailLabel.TabIndex = 4;
            this.FailLabel.Text = "FAIL";
            // 
            // SuccessfulLabel
            // 
            this.SuccessfulLabel.AutoSize = true;
            this.SuccessfulLabel.Location = new System.Drawing.Point(7, 530);
            this.SuccessfulLabel.Name = "SuccessfulLabel";
            this.SuccessfulLabel.Size = new System.Drawing.Size(77, 13);
            this.SuccessfulLabel.TabIndex = 5;
            this.SuccessfulLabel.Text = "SUCCESSFUL";
            this.SuccessfulLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // FailText
            // 
            this.FailText.ForeColor = System.Drawing.Color.Red;
            this.FailText.Location = new System.Drawing.Point(89, 497);
            this.FailText.Name = "FailText";
            this.FailText.ReadOnly = true;
            this.FailText.Size = new System.Drawing.Size(100, 20);
            this.FailText.TabIndex = 6;
            // 
            // SuccessfulText
            // 
            this.SuccessfulText.ForeColor = System.Drawing.Color.Lime;
            this.SuccessfulText.Location = new System.Drawing.Point(89, 527);
            this.SuccessfulText.Name = "SuccessfulText";
            this.SuccessfulText.ReadOnly = true;
            this.SuccessfulText.Size = new System.Drawing.Size(100, 20);
            this.SuccessfulText.TabIndex = 7;
            // 
            // NowExecutingLabel
            // 
            this.NowExecutingLabel.AutoSize = true;
            this.NowExecutingLabel.Location = new System.Drawing.Point(220, 468);
            this.NowExecutingLabel.Name = "NowExecutingLabel";
            this.NowExecutingLabel.Size = new System.Drawing.Size(54, 26);
            this.NowExecutingLabel.TabIndex = 8;
            this.NowExecutingLabel.Text = "Now\r\nExecuting";
            // 
            // NowExecutingText
            // 
            this.NowExecutingText.Location = new System.Drawing.Point(280, 465);
            this.NowExecutingText.Multiline = true;
            this.NowExecutingText.Name = "NowExecutingText";
            this.NowExecutingText.ReadOnly = true;
            this.NowExecutingText.Size = new System.Drawing.Size(471, 56);
            this.NowExecutingText.TabIndex = 9;
            // 
            // FoundLabel
            // 
            this.FoundLabel.AutoSize = true;
            this.FoundLabel.Location = new System.Drawing.Point(7, 468);
            this.FoundLabel.Name = "FoundLabel";
            this.FoundLabel.Size = new System.Drawing.Size(45, 13);
            this.FoundLabel.TabIndex = 10;
            this.FoundLabel.Text = "FOUND";
            // 
            // FoundText
            // 
            this.FoundText.Location = new System.Drawing.Point(89, 465);
            this.FoundText.Name = "FoundText";
            this.FoundText.ReadOnly = true;
            this.FoundText.Size = new System.Drawing.Size(100, 20);
            this.FoundText.TabIndex = 11;
            // 
            // ErrorLogLabel
            // 
            this.ErrorLogLabel.AutoSize = true;
            this.ErrorLogLabel.Location = new System.Drawing.Point(228, 527);
            this.ErrorLogLabel.Name = "ErrorLogLabel";
            this.ErrorLogLabel.Size = new System.Drawing.Size(46, 13);
            this.ErrorLogLabel.TabIndex = 12;
            this.ErrorLogLabel.Text = "Error log";
            // 
            // ErrorText
            // 
            this.ErrorText.Location = new System.Drawing.Point(280, 527);
            this.ErrorText.Multiline = true;
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.ReadOnly = true;
            this.ErrorText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorText.Size = new System.Drawing.Size(471, 132);
            this.ErrorText.TabIndex = 13;
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.AutoSize = true;
            this.ConnectionStringLabel.Location = new System.Drawing.Point(64, 81);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(88, 13);
            this.ConnectionStringLabel.TabIndex = 14;
            this.ConnectionStringLabel.Text = "ConnectionString";
            // 
            // txtConn
            // 
            this.txtConn.Location = new System.Drawing.Point(63, 97);
            this.txtConn.Name = "txtConn";
            this.txtConn.Size = new System.Drawing.Size(607, 20);
            this.txtConn.TabIndex = 15;
            this.txtConn.Text = "Data Source=(local);Initial Catalog=Location;User Id=dev_user;Password=PasswordAb" +
    "c123;";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(60, 138);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(37, 13);
            this.TableLabel.TabIndex = 16;
            this.TableLabel.Text = "Table:";
            // 
            // GetTablesButton
            // 
            this.GetTablesButton.Location = new System.Drawing.Point(676, 97);
            this.GetTablesButton.Name = "GetTablesButton";
            this.GetTablesButton.Size = new System.Drawing.Size(75, 23);
            this.GetTablesButton.TabIndex = 17;
            this.GetTablesButton.Text = "Get Tables";
            this.GetTablesButton.UseVisualStyleBackColor = true;
            this.GetTablesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // TablesDropdown
            // 
            this.TablesDropdown.FormattingEnabled = true;
            this.TablesDropdown.Location = new System.Drawing.Point(100, 133);
            this.TablesDropdown.Name = "TablesDropdown";
            this.TablesDropdown.Size = new System.Drawing.Size(136, 21);
            this.TablesDropdown.TabIndex = 18;
            // 
            // GatherButton
            // 
            this.GatherButton.Image = global::Importer.Properties.Resources._1291915867_data_transport;
            this.GatherButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GatherButton.Location = new System.Drawing.Point(63, 32);
            this.GatherButton.Name = "GatherButton";
            this.GatherButton.Size = new System.Drawing.Size(104, 45);
            this.GatherButton.TabIndex = 3;
            this.GatherButton.Text = "Gather";
            this.GatherButton.UseVisualStyleBackColor = true;
            this.GatherButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolbarStatusLabel,
            this.SaveToolStripSplitButton});
            this.StatusStrip.Location = new System.Drawing.Point(0, 683);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(763, 22);
            this.StatusStrip.TabIndex = 19;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // ToolbarStatusLabel
            // 
            this.ToolbarStatusLabel.Name = "ToolbarStatusLabel";
            this.ToolbarStatusLabel.Size = new System.Drawing.Size(54, 17);
            this.ToolbarStatusLabel.Text = "Ready ....";
            // 
            // SaveToolStripSplitButton
            // 
            this.SaveToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveErrorLogToolStripMenuItem,
            this.SaveFailedQueriesToolStripMenuItem});
            this.SaveToolStripSplitButton.Image = global::Importer.Properties.Resources._1291949056_disk;
            this.SaveToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripSplitButton.Name = "SaveToolStripSplitButton";
            this.SaveToolStripSplitButton.Size = new System.Drawing.Size(32, 20);
            this.SaveToolStripSplitButton.Text = "toolStripSplitButton1";
            // 
            // SaveErrorLogToolStripMenuItem
            // 
            this.SaveErrorLogToolStripMenuItem.Name = "SaveErrorLogToolStripMenuItem";
            this.SaveErrorLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveErrorLogToolStripMenuItem.Text = "Save error log";
            this.SaveErrorLogToolStripMenuItem.Click += new System.EventHandler(this.saveErrorLogToolStripMenuItem_Click);
            // 
            // SaveFailedQueriesToolStripMenuItem
            // 
            this.SaveFailedQueriesToolStripMenuItem.Name = "SaveFailedQueriesToolStripMenuItem";
            this.SaveFailedQueriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveFailedQueriesToolStripMenuItem.Text = "Save failed Queries";
            this.SaveFailedQueriesToolStripMenuItem.Click += new System.EventHandler(this.saveFailedQueriesToolStripMenuItem_Click);
            // 
            // GetFieldsButton
            // 
            this.GetFieldsButton.Location = new System.Drawing.Point(242, 131);
            this.GetFieldsButton.Name = "GetFieldsButton";
            this.GetFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.GetFieldsButton.TabIndex = 20;
            this.GetFieldsButton.Text = "Get Fields";
            this.GetFieldsButton.UseVisualStyleBackColor = true;
            this.GetFieldsButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ColumnsList
            // 
            this.ColumnsList.FormattingEnabled = true;
            this.ColumnsList.Location = new System.Drawing.Point(63, 180);
            this.ColumnsList.Name = "ColumnsList";
            this.ColumnsList.Size = new System.Drawing.Size(169, 147);
            this.ColumnsList.TabIndex = 21;
            // 
            // InDatabaseLabel
            // 
            this.InDatabaseLabel.AutoSize = true;
            this.InDatabaseLabel.Location = new System.Drawing.Point(60, 164);
            this.InDatabaseLabel.Name = "InDatabaseLabel";
            this.InDatabaseLabel.Size = new System.Drawing.Size(65, 13);
            this.InDatabaseLabel.TabIndex = 22;
            this.InDatabaseLabel.Text = "In Database";
            // 
            // SingleFieldAddButton
            // 
            this.SingleFieldAddButton.Location = new System.Drawing.Point(241, 192);
            this.SingleFieldAddButton.Name = "SingleFieldAddButton";
            this.SingleFieldAddButton.Size = new System.Drawing.Size(33, 23);
            this.SingleFieldAddButton.TabIndex = 23;
            this.SingleFieldAddButton.Text = ">";
            this.SingleFieldAddButton.UseVisualStyleBackColor = true;
            this.SingleFieldAddButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // AllFieldsAddButton
            // 
            this.AllFieldsAddButton.Location = new System.Drawing.Point(241, 221);
            this.AllFieldsAddButton.Name = "AllFieldsAddButton";
            this.AllFieldsAddButton.Size = new System.Drawing.Size(33, 23);
            this.AllFieldsAddButton.TabIndex = 24;
            this.AllFieldsAddButton.Text = ">>";
            this.AllFieldsAddButton.UseVisualStyleBackColor = true;
            this.AllFieldsAddButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // AllFieldsRemoveButton
            // 
            this.AllFieldsRemoveButton.Location = new System.Drawing.Point(241, 250);
            this.AllFieldsRemoveButton.Name = "AllFieldsRemoveButton";
            this.AllFieldsRemoveButton.Size = new System.Drawing.Size(33, 23);
            this.AllFieldsRemoveButton.TabIndex = 25;
            this.AllFieldsRemoveButton.Text = "<<";
            this.AllFieldsRemoveButton.UseVisualStyleBackColor = true;
            this.AllFieldsRemoveButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // SingleFieldRemoveButton
            // 
            this.SingleFieldRemoveButton.Location = new System.Drawing.Point(241, 279);
            this.SingleFieldRemoveButton.Name = "SingleFieldRemoveButton";
            this.SingleFieldRemoveButton.Size = new System.Drawing.Size(33, 23);
            this.SingleFieldRemoveButton.TabIndex = 26;
            this.SingleFieldRemoveButton.Text = "<";
            this.SingleFieldRemoveButton.UseVisualStyleBackColor = true;
            this.SingleFieldRemoveButton.Click += new System.EventHandler(this.button8_Click);
            // 
            // InQueryLabel
            // 
            this.InQueryLabel.AutoSize = true;
            this.InQueryLabel.Location = new System.Drawing.Point(276, 164);
            this.InQueryLabel.Name = "InQueryLabel";
            this.InQueryLabel.Size = new System.Drawing.Size(47, 13);
            this.InQueryLabel.TabIndex = 27;
            this.InQueryLabel.Text = "In Query";
            // 
            // QueryFieldsList
            // 
            this.QueryFieldsList.FormattingEnabled = true;
            this.QueryFieldsList.Location = new System.Drawing.Point(280, 180);
            this.QueryFieldsList.Name = "QueryFieldsList";
            this.QueryFieldsList.Size = new System.Drawing.Size(169, 147);
            this.QueryFieldsList.TabIndex = 28;
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.Location = new System.Drawing.Point(323, 131);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFieldsButton.TabIndex = 29;
            this.ClearFieldsButton.Text = "Clear Fields";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            this.ClearFieldsButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // InstructionsText
            // 
            this.InstructionsText.Location = new System.Drawing.Point(455, 192);
            this.InstructionsText.Multiline = true;
            this.InstructionsText.Name = "InstructionsText";
            this.InstructionsText.ReadOnly = true;
            this.InstructionsText.Size = new System.Drawing.Size(296, 135);
            this.InstructionsText.TabIndex = 30;
            this.InstructionsText.TextChanged += new System.EventHandler(this.InstructionsText_TextChanged);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Location = new System.Drawing.Point(455, 176);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(61, 13);
            this.InstructionsLabel.TabIndex = 31;
            this.InstructionsLabel.Text = "Instructions";
            // 
            // GoPictureBoxButton
            // 
            this.GoPictureBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoPictureBoxButton.Image = global::Importer.Properties.Resources._1291923764_Perspective_Button___Go;
            this.GoPictureBoxButton.Location = new System.Drawing.Point(280, 333);
            this.GoPictureBoxButton.Name = "GoPictureBoxButton";
            this.GoPictureBoxButton.Size = new System.Drawing.Size(128, 128);
            this.GoPictureBoxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GoPictureBoxButton.TabIndex = 32;
            this.GoPictureBoxButton.TabStop = false;
            this.GoPictureBoxButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.GoPictureBoxButton.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.GoPictureBoxButton.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 705);
            this.Controls.Add(this.GoPictureBoxButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.InstructionsText);
            this.Controls.Add(this.ClearFieldsButton);
            this.Controls.Add(this.QueryFieldsList);
            this.Controls.Add(this.InQueryLabel);
            this.Controls.Add(this.SingleFieldRemoveButton);
            this.Controls.Add(this.AllFieldsRemoveButton);
            this.Controls.Add(this.AllFieldsAddButton);
            this.Controls.Add(this.SingleFieldAddButton);
            this.Controls.Add(this.InDatabaseLabel);
            this.Controls.Add(this.ColumnsList);
            this.Controls.Add(this.GetFieldsButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TablesDropdown);
            this.Controls.Add(this.GetTablesButton);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.txtConn);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ErrorLogLabel);
            this.Controls.Add(this.FoundText);
            this.Controls.Add(this.FoundLabel);
            this.Controls.Add(this.NowExecutingText);
            this.Controls.Add(this.NowExecutingLabel);
            this.Controls.Add(this.SuccessfulText);
            this.Controls.Add(this.FailText);
            this.Controls.Add(this.SuccessfulLabel);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.GatherButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileTextbox);
            this.Controls.Add(this.FileLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "IMPORTER";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoPictureBoxButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox FileTextbox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button GatherButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.Label SuccessfulLabel;
        private System.Windows.Forms.TextBox FailText;
        private System.Windows.Forms.TextBox SuccessfulText;
        private System.Windows.Forms.Label NowExecutingLabel;
        private System.Windows.Forms.TextBox NowExecutingText;
        private System.Windows.Forms.Label FoundLabel;
        private System.Windows.Forms.TextBox FoundText;
        private System.Windows.Forms.Label ErrorLogLabel;
        private System.Windows.Forms.TextBox ErrorText;
        private System.Windows.Forms.Label ConnectionStringLabel;
        private System.Windows.Forms.TextBox txtConn;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button GetTablesButton;
        private System.Windows.Forms.ComboBox TablesDropdown;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolbarStatusLabel;
        private System.Windows.Forms.Button GetFieldsButton;
        private System.Windows.Forms.ListBox ColumnsList;
        private System.Windows.Forms.Label InDatabaseLabel;
        private System.Windows.Forms.Button SingleFieldAddButton;
        private System.Windows.Forms.Button AllFieldsAddButton;
        private System.Windows.Forms.Button AllFieldsRemoveButton;
        private System.Windows.Forms.Button SingleFieldRemoveButton;
        private System.Windows.Forms.Label InQueryLabel;
        private System.Windows.Forms.ListBox QueryFieldsList;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.TextBox InstructionsText;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.PictureBox GoPictureBoxButton;
        private System.Windows.Forms.ToolStripSplitButton SaveToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem SaveErrorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFailedQueriesToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

