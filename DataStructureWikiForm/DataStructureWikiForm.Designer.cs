namespace DataStructureWikiForm
{
    partial class DataStructureWikiForm
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
            components = new System.ComponentModel.Container();
            TextBoxFeedback = new TextBox();
            label5 = new Label();
            ListViewWiki = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBoxControls = new GroupBox();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            ButtonAdd = new Button();
            groupBoxFile = new GroupBox();
            ButtonSave = new Button();
            ButtonOpen = new Button();
            TextBoxSearch = new TextBox();
            label6 = new Label();
            ButtonSearch = new Button();
            label7 = new Label();
            label4 = new Label();
            TextBoxDefinition = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBoxStructure = new TextBox();
            TextBoxCategory = new TextBox();
            TextBoxName = new TextBox();
            groupBoxReset = new GroupBox();
            ButtonReset = new Button();
            toolTip1 = new ToolTip(components);
            groupBoxControls.SuspendLayout();
            groupBoxFile.SuspendLayout();
            groupBoxReset.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxFeedback
            // 
            TextBoxFeedback.Location = new Point(35, 415);
            TextBoxFeedback.Name = "TextBoxFeedback";
            TextBoxFeedback.ReadOnly = true;
            TextBoxFeedback.Size = new Size(728, 23);
            TextBoxFeedback.TabIndex = 8;
            toolTip1.SetToolTip(TextBoxFeedback, "Description of Operations Will Show Here");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 397);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Feedback";
            // 
            // ListViewWiki
            // 
            ListViewWiki.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            ListViewWiki.Location = new Point(431, 75);
            ListViewWiki.Name = "ListViewWiki";
            ListViewWiki.Size = new Size(341, 319);
            ListViewWiki.TabIndex = 14;
            toolTip1.SetToolTip(ListViewWiki, "Contents of Wiki");
            ListViewWiki.UseCompatibleStateImageBehavior = false;
            ListViewWiki.View = View.Details;
            ListViewWiki.SelectedIndexChanged += ListViewWiki_SelectedIndexChanged;
            ListViewWiki.Click += ListViewWiki_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Category";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Structure";
            columnHeader3.Width = 110;
            // 
            // groupBoxControls
            // 
            groupBoxControls.Controls.Add(ButtonDelete);
            groupBoxControls.Controls.Add(ButtonEdit);
            groupBoxControls.Controls.Add(ButtonAdd);
            groupBoxControls.Location = new Point(271, 12);
            groupBoxControls.Name = "groupBoxControls";
            groupBoxControls.Size = new Size(154, 165);
            groupBoxControls.TabIndex = 15;
            groupBoxControls.TabStop = false;
            groupBoxControls.Text = "Data Controls";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(37, 116);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 2;
            ButtonDelete.Text = "Delete";
            toolTip1.SetToolTip(ButtonDelete, "Delete Selection");
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(37, 71);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(75, 23);
            ButtonEdit.TabIndex = 1;
            ButtonEdit.Text = "Edit";
            toolTip1.SetToolTip(ButtonEdit, "Edit Selection");
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(37, 26);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(75, 23);
            ButtonAdd.TabIndex = 0;
            ButtonAdd.Text = "Add";
            toolTip1.SetToolTip(ButtonAdd, "Add to Wiki");
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // groupBoxFile
            // 
            groupBoxFile.Controls.Add(ButtonSave);
            groupBoxFile.Controls.Add(ButtonOpen);
            groupBoxFile.Location = new Point(271, 183);
            groupBoxFile.Name = "groupBoxFile";
            groupBoxFile.Size = new Size(154, 155);
            groupBoxFile.TabIndex = 16;
            groupBoxFile.TabStop = false;
            groupBoxFile.Text = "File Controls";
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(37, 94);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 2;
            ButtonSave.Text = "Save";
            toolTip1.SetToolTip(ButtonSave, "Save the Wiki to File");
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(37, 40);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(75, 23);
            ButtonOpen.TabIndex = 1;
            ButtonOpen.Text = "Open";
            toolTip1.SetToolTip(ButtonOpen, "Open a File");
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(431, 30);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(260, 23);
            TextBoxSearch.TabIndex = 17;
            toolTip1.SetToolTip(TextBoxSearch, "Enter Search Key");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(431, 12);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 18;
            label6.Text = "Search List:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(697, 30);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(75, 23);
            ButtonSearch.TabIndex = 20;
            ButtonSearch.Text = "Search";
            toolTip1.SetToolTip(ButtonSearch, "Press to Search");
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(431, 57);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 21;
            label7.Text = "List of Data Structures";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 154);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 29;
            label4.Text = "Definition";
            // 
            // TextBoxDefinition
            // 
            TextBoxDefinition.Location = new Point(24, 172);
            TextBoxDefinition.Multiline = true;
            TextBoxDefinition.Name = "TextBoxDefinition";
            TextBoxDefinition.Size = new Size(241, 222);
            TextBoxDefinition.TabIndex = 28;
            toolTip1.SetToolTip(TextBoxDefinition, "Enter Definition");
            TextBoxDefinition.DoubleClick += Double_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 105);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 27;
            label3.Text = "Structure Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 26;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 25;
            label1.Text = "Data Structure Name";
            // 
            // TextBoxStructure
            // 
            TextBoxStructure.Location = new Point(24, 123);
            TextBoxStructure.Name = "TextBoxStructure";
            TextBoxStructure.Size = new Size(241, 23);
            TextBoxStructure.TabIndex = 24;
            toolTip1.SetToolTip(TextBoxStructure, "Enter Structure Type");
            TextBoxStructure.DoubleClick += Double_Click;
            // 
            // TextBoxCategory
            // 
            TextBoxCategory.Location = new Point(24, 74);
            TextBoxCategory.Name = "TextBoxCategory";
            TextBoxCategory.Size = new Size(241, 23);
            TextBoxCategory.TabIndex = 23;
            toolTip1.SetToolTip(TextBoxCategory, "Enter Category Type");
            TextBoxCategory.DoubleClick += Double_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(24, 30);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(241, 23);
            TextBoxName.TabIndex = 22;
            toolTip1.SetToolTip(TextBoxName, "Enter Data Structure Name");
            TextBoxName.DoubleClick += Double_Click;
            // 
            // groupBoxReset
            // 
            groupBoxReset.Controls.Add(ButtonReset);
            groupBoxReset.Location = new Point(271, 338);
            groupBoxReset.Name = "groupBoxReset";
            groupBoxReset.Size = new Size(154, 56);
            groupBoxReset.TabIndex = 30;
            groupBoxReset.TabStop = false;
            // 
            // ButtonReset
            // 
            ButtonReset.Location = new Point(37, 20);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(75, 23);
            ButtonReset.TabIndex = 0;
            ButtonReset.Text = "Reset";
            toolTip1.SetToolTip(ButtonReset, "Reset Wiki");
            ButtonReset.UseVisualStyleBackColor = true;
            ButtonReset.Click += ButtonReset_Click;
            // 
            // DataStructureWikiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxReset);
            Controls.Add(label4);
            Controls.Add(TextBoxDefinition);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxStructure);
            Controls.Add(TextBoxCategory);
            Controls.Add(TextBoxName);
            Controls.Add(label7);
            Controls.Add(ButtonSearch);
            Controls.Add(label6);
            Controls.Add(TextBoxSearch);
            Controls.Add(groupBoxFile);
            Controls.Add(groupBoxControls);
            Controls.Add(ListViewWiki);
            Controls.Add(label5);
            Controls.Add(TextBoxFeedback);
            Name = "DataStructureWikiForm";
            Text = "Data Structure Wiki";
            groupBoxControls.ResumeLayout(false);
            groupBoxFile.ResumeLayout(false);
            groupBoxReset.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBoxFeedback;
        private Label label5;
        private ListView ListViewWiki;
        private GroupBox groupBoxControls;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Button ButtonAdd;
        private GroupBox groupBoxFile;
        private Button ButtonSave;
        private Button ButtonOpen;
        private TextBox TextBoxSearch;
        private Label label6;
        private Button ButtonSearch;
        private Label label7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label4;
        private TextBox TextBoxDefinition;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TextBoxStructure;
        private TextBox TextBoxCategory;
        private TextBox TextBoxName;
        private GroupBox groupBoxReset;
        private Button ButtonReset;
        private ToolTip toolTip1;
    }
}