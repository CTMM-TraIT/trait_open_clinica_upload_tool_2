namespace OCDataImporter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxSE = new System.Windows.Forms.ComboBox();
            this.comboBoxCRF = new System.Windows.Forms.ComboBox();
            this.comboBoxIT = new System.Windows.Forms.ComboBox();
            this.comboBoxGR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonStartConversion = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGStudyDataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGOCTargetItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGIsSubjectId = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGIsDate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGSex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGPID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGDOB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGSTD = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CopyCurrentTarget = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabelBuildDG = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelWarningCounter = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonConfPars = new System.Windows.Forms.Button();
            this.buttonBackToBegin = new System.Windows.Forms.Button();
            this.linkbuttonSHCols = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbUploadWhen_NotStarted = new System.Windows.Forms.CheckBox();
            this.rbStatusAfterUploadDataEntryStarted = new System.Windows.Forms.RadioButton();
            this.rbInitialDataBaseStatus_StillEmpty = new System.Windows.Forms.RadioButton();
            this.gbProgramParameters = new System.Windows.Forms.GroupBox();
            this.statusAfterUpload = new System.Windows.Forms.GroupBox();
            this.rbStatusAfterUploadMarkedComplete = new System.Windows.Forms.RadioButton();
            this.checkBoxDup = new System.Windows.Forms.CheckBox();
            this.tbLocationEvent = new System.Windows.Forms.TextBox();
            this.lbLocationEvent = new System.Windows.Forms.Label();
            this.textBoxMaxLines = new System.Windows.Forms.TextBox();
            this.lbMaxLines = new System.Windows.Forms.Label();
            this.gbStartDateEmpty = new System.Windows.Forms.GroupBox();
            this.radioButtonNoEVT = new System.Windows.Forms.RadioButton();
            this.radioButtonUseTD = new System.Windows.Forms.RadioButton();
            this.tbGenderCodeFemale = new System.Windows.Forms.TextBox();
            this.lbGenderCodeFemale = new System.Windows.Forms.Label();
            this.tbSubjectSexM = new System.Windows.Forms.TextBox();
            this.lbGenderCodeMale = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lbDefaultSex = new System.Windows.Forms.Label();
            this.cbDateFormat = new System.Windows.Forms.ComboBox();
            this.lbDateFormat = new System.Windows.Forms.Label();
            this.gbInitialStatusCRFs = new System.Windows.Forms.GroupBox();
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted = new System.Windows.Forms.RadioButton();
            this.gbUploadWhenCRFStatus = new System.Windows.Forms.GroupBox();
            this.cbUploadWhen_DataEntryComplete = new System.Windows.Forms.CheckBox();
            this.cbUploadWhen_DataEntryStarted = new System.Windows.Forms.CheckBox();
            this.gbInputFiles = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProgramParameters.SuspendLayout();
            this.statusAfterUpload.SuspendLayout();
            this.gbStartDateEmpty.SuspendLayout();
            this.gbInitialStatusCRFs.SuspendLayout();
            this.gbUploadWhenCRFStatus.SuspendLayout();
            this.gbInputFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSE
            // 
            this.comboBoxSE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSE.FormattingEnabled = true;
            this.comboBoxSE.Location = new System.Drawing.Point(21, 563);
            this.comboBoxSE.Name = "comboBoxSE";
            this.comboBoxSE.Size = new System.Drawing.Size(209, 21);
            this.comboBoxSE.Sorted = true;
            this.comboBoxSE.TabIndex = 20;
            this.comboBoxSE.SelectedIndexChanged += new System.EventHandler(this.comboBoxSE_SelectedIndexChanged);
            // 
            // comboBoxCRF
            // 
            this.comboBoxCRF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCRF.DropDownWidth = 161;
            this.comboBoxCRF.FormattingEnabled = true;
            this.comboBoxCRF.Location = new System.Drawing.Point(236, 563);
            this.comboBoxCRF.Name = "comboBoxCRF";
            this.comboBoxCRF.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCRF.Sorted = true;
            this.comboBoxCRF.TabIndex = 21;
            this.comboBoxCRF.SelectedIndexChanged += new System.EventHandler(this.comboBoxCRF_SelectedIndexChanged);
            // 
            // comboBoxIT
            // 
            this.comboBoxIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIT.DropDownWidth = 161;
            this.comboBoxIT.FormattingEnabled = true;
            this.comboBoxIT.Location = new System.Drawing.Point(660, 563);
            this.comboBoxIT.Name = "comboBoxIT";
            this.comboBoxIT.Size = new System.Drawing.Size(562, 21);
            this.comboBoxIT.Sorted = true;
            this.comboBoxIT.TabIndex = 23;
            this.comboBoxIT.SelectedIndexChanged += new System.EventHandler(this.comboBoxIT_SelectedIndexChanged);
            // 
            // comboBoxGR
            // 
            this.comboBoxGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGR.DropDownWidth = 161;
            this.comboBoxGR.FormattingEnabled = true;
            this.comboBoxGR.Location = new System.Drawing.Point(438, 563);
            this.comboBoxGR.Name = "comboBoxGR";
            this.comboBoxGR.Size = new System.Drawing.Size(216, 21);
            this.comboBoxGR.Sorted = true;
            this.comboBoxGR.TabIndex = 22;
            this.comboBoxGR.SelectedIndexChanged += new System.EventHandler(this.comboBoxGR_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(812, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OCMetaData file (XML), Study Data file (TXT) and label-oid file (OID), separated " +
    "by a \';\' or use \'Browse\' button. The label-oid file is optional.";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(6, 29);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(891, 21);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(902, 29);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // buttonStartConversion
            // 
            this.buttonStartConversion.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStartConversion.Enabled = false;
            this.buttonStartConversion.Location = new System.Drawing.Point(726, 592);
            this.buttonStartConversion.Name = "buttonStartConversion";
            this.buttonStartConversion.Size = new System.Drawing.Size(80, 23);
            this.buttonStartConversion.TabIndex = 27;
            this.buttonStartConversion.Text = "Start";
            this.buttonStartConversion.UseVisualStyleBackColor = false;
            this.buttonStartConversion.Click += new System.EventHandler(this.buttonStartConversion_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(104, 621);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1117, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(44, 653);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(1067, 101);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(820, 591);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Progress";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(983, 29);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(135, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Read Input Files";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Study Event";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "CRF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Group";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGStudyDataCol,
            this.DGOCTargetItem,
            this.DGIsSubjectId,
            this.DGIsDate,
            this.DGSex,
            this.DGPID,
            this.DGDOB,
            this.DGSTD,
            this.CopyCurrentTarget});
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1203, 284);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DGStudyDataCol
            // 
            this.DGStudyDataCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGStudyDataCol.HeaderText = "Study Data Column";
            this.DGStudyDataCol.Name = "DGStudyDataCol";
            this.DGStudyDataCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGStudyDataCol.ToolTipText = "Study data colomns based on the first line of data file";
            // 
            // DGOCTargetItem
            // 
            this.DGOCTargetItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGOCTargetItem.HeaderText = "OC Target Item";
            this.DGOCTargetItem.Name = "DGOCTargetItem";
            // 
            // DGIsSubjectId
            // 
            this.DGIsSubjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGIsSubjectId.HeaderText = "Study Subject ID?";
            this.DGIsSubjectId.Name = "DGIsSubjectId";
            this.DGIsSubjectId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGIsSubjectId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGIsSubjectId.ToolTipText = "Is this field (part of) subject id?";
            this.DGIsSubjectId.Width = 106;
            // 
            // DGIsDate
            // 
            this.DGIsDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGIsDate.HeaderText = "Date?";
            this.DGIsDate.Name = "DGIsDate";
            this.DGIsDate.ToolTipText = "Is this field a date field?";
            this.DGIsDate.Visible = false;
            // 
            // DGSex
            // 
            this.DGSex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGSex.HeaderText = "Subject Sex?";
            this.DGSex.Name = "DGSex";
            this.DGSex.ToolTipText = "Is this field the Subject\'s sex?";
            this.DGSex.Width = 79;
            // 
            // DGPID
            // 
            this.DGPID.HeaderText = "Subject Person ID?";
            this.DGPID.Name = "DGPID";
            this.DGPID.Width = 71;
            // 
            // DGDOB
            // 
            this.DGDOB.HeaderText = "Subject Date of Birth?";
            this.DGDOB.Name = "DGDOB";
            this.DGDOB.Width = 71;
            // 
            // DGSTD
            // 
            this.DGSTD.HeaderText = "Subject start date?";
            this.DGSTD.Name = "DGSTD";
            this.DGSTD.Width = 71;
            // 
            // CopyCurrentTarget
            // 
            this.CopyCurrentTarget.HeaderText = "CopyTarget";
            this.CopyCurrentTarget.Name = "CopyCurrentTarget";
            this.CopyCurrentTarget.Text = "CopyTarget";
            this.CopyCurrentTarget.UseColumnTextForLinkValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Item";
            // 
            // linkLabelBuildDG
            // 
            this.linkLabelBuildDG.AutoSize = true;
            this.linkLabelBuildDG.Location = new System.Drawing.Point(486, 597);
            this.linkLabelBuildDG.Name = "linkLabelBuildDG";
            this.linkLabelBuildDG.Size = new System.Drawing.Size(91, 13);
            this.linkLabelBuildDG.TabIndex = 25;
            this.linkLabelBuildDG.TabStop = true;
            this.linkLabelBuildDG.Text = "Match columns";
            this.linkLabelBuildDG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBuildDG_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(595, 596);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unmatch columns";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelWarningCounter
            // 
            this.labelWarningCounter.AutoSize = true;
            this.labelWarningCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarningCounter.Location = new System.Drawing.Point(51, 596);
            this.labelWarningCounter.Name = "labelWarningCounter";
            this.labelWarningCounter.Size = new System.Drawing.Size(0, 13);
            this.labelWarningCounter.TabIndex = 93;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 547);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 96;
            this.label17.Text = "OC Target:";
            // 
            // buttonConfPars
            // 
            this.buttonConfPars.Location = new System.Drawing.Point(1094, 144);
            this.buttonConfPars.Name = "buttonConfPars";
            this.buttonConfPars.Size = new System.Drawing.Size(102, 28);
            this.buttonConfPars.TabIndex = 18;
            this.buttonConfPars.Text = "Confirm";
            this.buttonConfPars.UseVisualStyleBackColor = true;
            this.buttonConfPars.Click += new System.EventHandler(this.buttonConfPars_Click);
            // 
            // buttonBackToBegin
            // 
            this.buttonBackToBegin.Location = new System.Drawing.Point(919, 590);
            this.buttonBackToBegin.Name = "buttonBackToBegin";
            this.buttonBackToBegin.Size = new System.Drawing.Size(142, 23);
            this.buttonBackToBegin.TabIndex = 29;
            this.buttonBackToBegin.Text = "Back To Beginning";
            this.buttonBackToBegin.UseVisualStyleBackColor = true;
            this.buttonBackToBegin.Click += new System.EventHandler(this.buttonBackToBegin_Click);
            // 
            // linkbuttonSHCols
            // 
            this.linkbuttonSHCols.AutoSize = true;
            this.linkbuttonSHCols.Location = new System.Drawing.Point(274, 597);
            this.linkbuttonSHCols.Name = "linkbuttonSHCols";
            this.linkbuttonSHCols.Size = new System.Drawing.Size(180, 13);
            this.linkbuttonSHCols.TabIndex = 24;
            this.linkbuttonSHCols.TabStop = true;
            this.linkbuttonSHCols.Text = "Hide Subject Related Columns";
            this.linkbuttonSHCols.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkbuttonSHCols_LinkClicked);
            // 
            // cbUploadWhen_NotStarted
            // 
            this.cbUploadWhen_NotStarted.AutoSize = true;
            this.cbUploadWhen_NotStarted.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cbUploadWhen_NotStarted.Location = new System.Drawing.Point(6, 15);
            this.cbUploadWhen_NotStarted.Name = "cbUploadWhen_NotStarted";
            this.cbUploadWhen_NotStarted.Size = new System.Drawing.Size(111, 17);
            this.cbUploadWhen_NotStarted.TabIndex = 15;
            this.cbUploadWhen_NotStarted.Text = "Not Started     ";
            this.toolTip1.SetToolTip(this.cbUploadWhen_NotStarted, "Hallo This is the Help");
            this.cbUploadWhen_NotStarted.UseVisualStyleBackColor = true;
            // 
            // rbStatusAfterUploadDataEntryStarted
            // 
            this.rbStatusAfterUploadDataEntryStarted.AutoSize = true;
            this.rbStatusAfterUploadDataEntryStarted.Checked = true;
            this.rbStatusAfterUploadDataEntryStarted.Enabled = false;
            this.rbStatusAfterUploadDataEntryStarted.Image = ((System.Drawing.Image)(resources.GetObject("rbStatusAfterUploadDataEntryStarted.Image")));
            this.rbStatusAfterUploadDataEntryStarted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbStatusAfterUploadDataEntryStarted.Location = new System.Drawing.Point(9, 20);
            this.rbStatusAfterUploadDataEntryStarted.Name = "rbStatusAfterUploadDataEntryStarted";
            this.rbStatusAfterUploadDataEntryStarted.Size = new System.Drawing.Size(257, 17);
            this.rbStatusAfterUploadDataEntryStarted.TabIndex = 15;
            this.rbStatusAfterUploadDataEntryStarted.TabStop = true;
            this.rbStatusAfterUploadDataEntryStarted.Tag = "0";
            this.rbStatusAfterUploadDataEntryStarted.Text = "Initial data entry (Data entry Started)    ";
            this.toolTip1.SetToolTip(this.rbStatusAfterUploadDataEntryStarted, "Complete indicates data entry of this CRF is \r\ncompleted (after upload)\r\n\r\nSelect" +
        "ing Initial Data entry indicates this CRF \r\ndata is not yet completed (after upl" +
        "oad)");
            this.rbStatusAfterUploadDataEntryStarted.UseVisualStyleBackColor = true;
            // 
            // rbInitialDataBaseStatus_StillEmpty
            // 
            this.rbInitialDataBaseStatus_StillEmpty.AutoSize = true;
            this.rbInitialDataBaseStatus_StillEmpty.Checked = true;
            this.rbInitialDataBaseStatus_StillEmpty.Image = ((System.Drawing.Image)(resources.GetObject("rbInitialDataBaseStatus_StillEmpty.Image")));
            this.rbInitialDataBaseStatus_StillEmpty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbInitialDataBaseStatus_StillEmpty.Location = new System.Drawing.Point(7, 14);
            this.rbInitialDataBaseStatus_StillEmpty.Name = "rbInitialDataBaseStatus_StillEmpty";
            this.rbInitialDataBaseStatus_StillEmpty.Size = new System.Drawing.Size(329, 17);
            this.rbInitialDataBaseStatus_StillEmpty.TabIndex = 13;
            this.rbInitialDataBaseStatus_StillEmpty.TabStop = true;
            this.rbInitialDataBaseStatus_StillEmpty.Text = "OpenClinica database is still empty for these CRFs    ";
            this.toolTip1.SetToolTip(this.rbInitialDataBaseStatus_StillEmpty, resources.GetString("rbInitialDataBaseStatus_StillEmpty.ToolTip"));
            this.rbInitialDataBaseStatus_StillEmpty.UseVisualStyleBackColor = true;
            this.rbInitialDataBaseStatus_StillEmpty.CheckedChanged += new System.EventHandler(this.rbOCDataBaseStatus_StillEmpty_CheckedChanged);
            // 
            // gbProgramParameters
            // 
            this.gbProgramParameters.Controls.Add(this.statusAfterUpload);
            this.gbProgramParameters.Controls.Add(this.checkBoxDup);
            this.gbProgramParameters.Controls.Add(this.tbLocationEvent);
            this.gbProgramParameters.Controls.Add(this.lbLocationEvent);
            this.gbProgramParameters.Controls.Add(this.buttonConfPars);
            this.gbProgramParameters.Controls.Add(this.textBoxMaxLines);
            this.gbProgramParameters.Controls.Add(this.lbMaxLines);
            this.gbProgramParameters.Controls.Add(this.gbStartDateEmpty);
            this.gbProgramParameters.Controls.Add(this.tbGenderCodeFemale);
            this.gbProgramParameters.Controls.Add(this.lbGenderCodeFemale);
            this.gbProgramParameters.Controls.Add(this.tbSubjectSexM);
            this.gbProgramParameters.Controls.Add(this.lbGenderCodeMale);
            this.gbProgramParameters.Controls.Add(this.cbSex);
            this.gbProgramParameters.Controls.Add(this.lbDefaultSex);
            this.gbProgramParameters.Controls.Add(this.cbDateFormat);
            this.gbProgramParameters.Controls.Add(this.lbDateFormat);
            this.gbProgramParameters.Controls.Add(this.gbInitialStatusCRFs);
            this.gbProgramParameters.Controls.Add(this.gbUploadWhenCRFStatus);
            this.gbProgramParameters.Location = new System.Drawing.Point(12, 68);
            this.gbProgramParameters.Name = "gbProgramParameters";
            this.gbProgramParameters.Size = new System.Drawing.Size(1223, 183);
            this.gbProgramParameters.TabIndex = 116;
            this.gbProgramParameters.TabStop = false;
            this.gbProgramParameters.Text = "Program Parameters";
            this.toolTip1.SetToolTip(this.gbProgramParameters, resources.GetString("gbProgramParameters.ToolTip"));
            // 
            // statusAfterUpload
            // 
            this.statusAfterUpload.Controls.Add(this.rbStatusAfterUploadMarkedComplete);
            this.statusAfterUpload.Controls.Add(this.rbStatusAfterUploadDataEntryStarted);
            this.statusAfterUpload.Location = new System.Drawing.Point(607, 87);
            this.statusAfterUpload.Name = "statusAfterUpload";
            this.statusAfterUpload.Size = new System.Drawing.Size(276, 68);
            this.statusAfterUpload.TabIndex = 120;
            this.statusAfterUpload.TabStop = false;
            this.statusAfterUpload.Text = "  CRF Status after upload  ";
            // 
            // rbStatusAfterUploadMarkedComplete
            // 
            this.rbStatusAfterUploadMarkedComplete.AutoSize = true;
            this.rbStatusAfterUploadMarkedComplete.Enabled = false;
            this.rbStatusAfterUploadMarkedComplete.Location = new System.Drawing.Point(9, 39);
            this.rbStatusAfterUploadMarkedComplete.Name = "rbStatusAfterUploadMarkedComplete";
            this.rbStatusAfterUploadMarkedComplete.Size = new System.Drawing.Size(126, 17);
            this.rbStatusAfterUploadMarkedComplete.TabIndex = 16;
            this.rbStatusAfterUploadMarkedComplete.Tag = "1";
            this.rbStatusAfterUploadMarkedComplete.Text = "Marked Complete";
            this.rbStatusAfterUploadMarkedComplete.UseVisualStyleBackColor = true;
            // 
            // checkBoxDup
            // 
            this.checkBoxDup.AutoSize = true;
            this.checkBoxDup.Location = new System.Drawing.Point(907, 87);
            this.checkBoxDup.Name = "checkBoxDup";
            this.checkBoxDup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDup.Size = new System.Drawing.Size(224, 17);
            this.checkBoxDup.TabIndex = 17;
            this.checkBoxDup.Text = "Check duplicate study subject ID\'s";
            this.checkBoxDup.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxDup.UseVisualStyleBackColor = true;
            // 
            // tbLocationEvent
            // 
            this.tbLocationEvent.Location = new System.Drawing.Point(648, 54);
            this.tbLocationEvent.Name = "tbLocationEvent";
            this.tbLocationEvent.Size = new System.Drawing.Size(151, 21);
            this.tbLocationEvent.TabIndex = 12;
            // 
            // lbLocationEvent
            // 
            this.lbLocationEvent.AutoSize = true;
            this.lbLocationEvent.Location = new System.Drawing.Point(580, 59);
            this.lbLocationEvent.Name = "lbLocationEvent";
            this.lbLocationEvent.Size = new System.Drawing.Size(59, 13);
            this.lbLocationEvent.TabIndex = 118;
            this.lbLocationEvent.Text = "Location:";
            // 
            // textBoxMaxLines
            // 
            this.textBoxMaxLines.Location = new System.Drawing.Point(518, 54);
            this.textBoxMaxLines.Name = "textBoxMaxLines";
            this.textBoxMaxLines.Size = new System.Drawing.Size(51, 21);
            this.textBoxMaxLines.TabIndex = 11;
            this.textBoxMaxLines.Text = "0";
            // 
            // lbMaxLines
            // 
            this.lbMaxLines.AutoSize = true;
            this.lbMaxLines.Location = new System.Drawing.Point(6, 59);
            this.lbMaxLines.Name = "lbMaxLines";
            this.lbMaxLines.Size = new System.Drawing.Size(504, 13);
            this.lbMaxLines.TabIndex = 119;
            this.lbMaxLines.Text = "Split the ODM file where each contains  the following number of subjects (0 = no " +
    "split) ";
            // 
            // gbStartDateEmpty
            // 
            this.gbStartDateEmpty.Controls.Add(this.radioButtonNoEVT);
            this.gbStartDateEmpty.Controls.Add(this.radioButtonUseTD);
            this.gbStartDateEmpty.Location = new System.Drawing.Point(907, 17);
            this.gbStartDateEmpty.Name = "gbStartDateEmpty";
            this.gbStartDateEmpty.Size = new System.Drawing.Size(304, 55);
            this.gbStartDateEmpty.TabIndex = 118;
            this.gbStartDateEmpty.TabStop = false;
            this.gbStartDateEmpty.Text = "  If Subject start date is empty in data file:  ";
            // 
            // radioButtonNoEVT
            // 
            this.radioButtonNoEVT.AutoSize = true;
            this.radioButtonNoEVT.Location = new System.Drawing.Point(12, 34);
            this.radioButtonNoEVT.Name = "radioButtonNoEVT";
            this.radioButtonNoEVT.Size = new System.Drawing.Size(201, 17);
            this.radioButtonNoEVT.TabIndex = 10;
            this.radioButtonNoEVT.TabStop = true;
            this.radioButtonNoEVT.Text = "Do not generate Event records";
            this.radioButtonNoEVT.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseTD
            // 
            this.radioButtonUseTD.AutoSize = true;
            this.radioButtonUseTD.Location = new System.Drawing.Point(12, 16);
            this.radioButtonUseTD.Name = "radioButtonUseTD";
            this.radioButtonUseTD.Size = new System.Drawing.Size(117, 17);
            this.radioButtonUseTD.TabIndex = 9;
            this.radioButtonUseTD.TabStop = true;
            this.radioButtonUseTD.Text = "Use todays date";
            this.radioButtonUseTD.UseVisualStyleBackColor = true;
            // 
            // tbGenderCodeFemale
            // 
            this.tbGenderCodeFemale.Location = new System.Drawing.Point(836, 22);
            this.tbGenderCodeFemale.Name = "tbGenderCodeFemale";
            this.tbGenderCodeFemale.Size = new System.Drawing.Size(50, 21);
            this.tbGenderCodeFemale.TabIndex = 8;
            // 
            // lbGenderCodeFemale
            // 
            this.lbGenderCodeFemale.AutoSize = true;
            this.lbGenderCodeFemale.Location = new System.Drawing.Point(708, 25);
            this.lbGenderCodeFemale.Name = "lbGenderCodeFemale";
            this.lbGenderCodeFemale.Size = new System.Drawing.Size(116, 13);
            this.lbGenderCodeFemale.TabIndex = 118;
            this.lbGenderCodeFemale.Text = "Gender Code for f:";
            // 
            // tbSubjectSexM
            // 
            this.tbSubjectSexM.Location = new System.Drawing.Point(645, 19);
            this.tbSubjectSexM.Name = "tbSubjectSexM";
            this.tbSubjectSexM.Size = new System.Drawing.Size(57, 21);
            this.tbSubjectSexM.TabIndex = 7;
            // 
            // lbGenderCodeMale
            // 
            this.lbGenderCodeMale.AutoSize = true;
            this.lbGenderCodeMale.Location = new System.Drawing.Point(515, 25);
            this.lbGenderCodeMale.Name = "lbGenderCodeMale";
            this.lbGenderCodeMale.Size = new System.Drawing.Size(127, 13);
            this.lbGenderCodeMale.TabIndex = 118;
            this.lbGenderCodeMale.Text = "Gender Code for m: ";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "f",
            "m"});
            this.cbSex.Location = new System.Drawing.Point(448, 20);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(60, 21);
            this.cbSex.TabIndex = 6;
            // 
            // lbDefaultSex
            // 
            this.lbDefaultSex.AutoSize = true;
            this.lbDefaultSex.Location = new System.Drawing.Point(304, 25);
            this.lbDefaultSex.Name = "lbDefaultSex";
            this.lbDefaultSex.Size = new System.Drawing.Size(138, 13);
            this.lbDefaultSex.TabIndex = 118;
            this.lbDefaultSex.Text = "Default sex of subjects";
            // 
            // cbDateFormat
            // 
            this.cbDateFormat.FormattingEnabled = true;
            this.cbDateFormat.Items.AddRange(new object[] {
            "--select--",
            "day-month-year",
            "month-day-year",
            "year-month-day"});
            this.cbDateFormat.Location = new System.Drawing.Point(171, 19);
            this.cbDateFormat.Name = "cbDateFormat";
            this.cbDateFormat.Size = new System.Drawing.Size(121, 21);
            this.cbDateFormat.TabIndex = 5;
            // 
            // lbDateFormat
            // 
            this.lbDateFormat.AutoSize = true;
            this.lbDateFormat.Location = new System.Drawing.Point(5, 22);
            this.lbDateFormat.Name = "lbDateFormat";
            this.lbDateFormat.Size = new System.Drawing.Size(160, 13);
            this.lbDateFormat.TabIndex = 115;
            this.lbDateFormat.Text = "Date format in study items";
            // 
            // gbInitialStatusCRFs
            // 
            this.gbInitialStatusCRFs.Controls.Add(this.rbInitialDataBaseStatus_StillEmpty);
            this.gbInitialStatusCRFs.Controls.Add(this.rbInitialDataBaseStatus_DataEntryAllreadyStarted);
            this.gbInitialStatusCRFs.Location = new System.Drawing.Point(18, 87);
            this.gbInitialStatusCRFs.Name = "gbInitialStatusCRFs";
            this.gbInitialStatusCRFs.Size = new System.Drawing.Size(349, 63);
            this.gbInitialStatusCRFs.TabIndex = 114;
            this.gbInitialStatusCRFs.TabStop = false;
            this.gbInitialStatusCRFs.Text = "Status OpenClinica Database:";
            // 
            // rbInitialDataBaseStatus_DataEntryAllreadyStarted
            // 
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.AutoSize = true;
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.Location = new System.Drawing.Point(7, 35);
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.Name = "rbInitialDataBaseStatus_DataEntryAllreadyStarted";
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.Size = new System.Drawing.Size(265, 17);
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.TabIndex = 14;
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.Text = "Data entry already started for these CRFs";
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.UseVisualStyleBackColor = true;
            this.rbInitialDataBaseStatus_DataEntryAllreadyStarted.CheckedChanged += new System.EventHandler(this.rbOCDataBaseStatus_DataEntryAllreadyStarted_CheckedChanged);
            // 
            // gbUploadWhenCRFStatus
            // 
            this.gbUploadWhenCRFStatus.Controls.Add(this.cbUploadWhen_DataEntryComplete);
            this.gbUploadWhenCRFStatus.Controls.Add(this.cbUploadWhen_NotStarted);
            this.gbUploadWhenCRFStatus.Controls.Add(this.cbUploadWhen_DataEntryStarted);
            this.gbUploadWhenCRFStatus.Location = new System.Drawing.Point(384, 84);
            this.gbUploadWhenCRFStatus.Name = "gbUploadWhenCRFStatus";
            this.gbUploadWhenCRFStatus.Size = new System.Drawing.Size(202, 88);
            this.gbUploadWhenCRFStatus.TabIndex = 115;
            this.gbUploadWhenCRFStatus.TabStop = false;
            this.gbUploadWhenCRFStatus.Text = "  Upload if current CRF status  ";
            // 
            // cbUploadWhen_DataEntryComplete
            // 
            this.cbUploadWhen_DataEntryComplete.AutoSize = true;
            this.cbUploadWhen_DataEntryComplete.Location = new System.Drawing.Point(6, 61);
            this.cbUploadWhen_DataEntryComplete.Name = "cbUploadWhen_DataEntryComplete";
            this.cbUploadWhen_DataEntryComplete.Size = new System.Drawing.Size(146, 17);
            this.cbUploadWhen_DataEntryComplete.TabIndex = 14;
            this.cbUploadWhen_DataEntryComplete.Text = "Data Entry Complete";
            this.cbUploadWhen_DataEntryComplete.UseVisualStyleBackColor = true;
            this.cbUploadWhen_DataEntryComplete.CheckedChanged += new System.EventHandler(this.warningStateChange);
            // 
            // cbUploadWhen_DataEntryStarted
            // 
            this.cbUploadWhen_DataEntryStarted.AutoSize = true;
            this.cbUploadWhen_DataEntryStarted.Location = new System.Drawing.Point(6, 38);
            this.cbUploadWhen_DataEntryStarted.Name = "cbUploadWhen_DataEntryStarted";
            this.cbUploadWhen_DataEntryStarted.Size = new System.Drawing.Size(133, 17);
            this.cbUploadWhen_DataEntryStarted.TabIndex = 16;
            this.cbUploadWhen_DataEntryStarted.Text = "Data Entry Started";
            this.cbUploadWhen_DataEntryStarted.UseVisualStyleBackColor = true;
            // 
            // gbInputFiles
            // 
            this.gbInputFiles.Controls.Add(this.button_start);
            this.gbInputFiles.Controls.Add(this.buttonBrowse);
            this.gbInputFiles.Controls.Add(this.textBoxInput);
            this.gbInputFiles.Controls.Add(this.label3);
            this.gbInputFiles.Location = new System.Drawing.Point(11, -2);
            this.gbInputFiles.Name = "gbInputFiles";
            this.gbInputFiles.Size = new System.Drawing.Size(1223, 70);
            this.gbInputFiles.TabIndex = 117;
            this.gbInputFiles.TabStop = false;
            this.gbInputFiles.Text = "  Input Files  ";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(1140, 695);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 766);
            this.Controls.Add(this.gbInputFiles);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.linkbuttonSHCols);
            this.Controls.Add(this.buttonBackToBegin);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelWarningCounter);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkLabelBuildDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStartConversion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGR);
            this.Controls.Add(this.comboBoxCRF);
            this.Controls.Add(this.comboBoxSE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbProgramParameters);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OCDataImporter - Provided by VU Medical Center, dept. of Pathology, Amsterdam";
            this.toolTip1.SetToolTip(this, "asdfasdfasfsadfa");
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProgramParameters.ResumeLayout(false);
            this.gbProgramParameters.PerformLayout();
            this.statusAfterUpload.ResumeLayout(false);
            this.statusAfterUpload.PerformLayout();
            this.gbStartDateEmpty.ResumeLayout(false);
            this.gbStartDateEmpty.PerformLayout();
            this.gbInitialStatusCRFs.ResumeLayout(false);
            this.gbInitialStatusCRFs.PerformLayout();
            this.gbUploadWhenCRFStatus.ResumeLayout(false);
            this.gbUploadWhenCRFStatus.PerformLayout();
            this.gbInputFiles.ResumeLayout(false);
            this.gbInputFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonStartConversion;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxIT; 
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSE;
        private System.Windows.Forms.ComboBox comboBoxCRF;
        private System.Windows.Forms.ComboBox comboBoxGR;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabelBuildDG;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelWarningCounter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonConfPars;
        private System.Windows.Forms.Button buttonBackToBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGStudyDataCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGOCTargetItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGIsSubjectId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGIsDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGSex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGPID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGDOB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGSTD;
        private System.Windows.Forms.DataGridViewLinkColumn CopyCurrentTarget;
        private System.Windows.Forms.LinkLabel linkbuttonSHCols;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbInitialDataBaseStatus_StillEmpty;
        private System.Windows.Forms.RadioButton rbInitialDataBaseStatus_DataEntryAllreadyStarted;
        private System.Windows.Forms.GroupBox gbInitialStatusCRFs;
        private System.Windows.Forms.GroupBox gbProgramParameters;
        private System.Windows.Forms.GroupBox gbInputFiles;
        private System.Windows.Forms.Label lbDefaultSex;
        private System.Windows.Forms.ComboBox cbDateFormat;
        private System.Windows.Forms.Label lbDateFormat;
        private System.Windows.Forms.TextBox tbLocationEvent;
        private System.Windows.Forms.Label lbLocationEvent;
        private System.Windows.Forms.TextBox textBoxMaxLines;
        private System.Windows.Forms.Label lbMaxLines;
        private System.Windows.Forms.GroupBox gbStartDateEmpty;
        private System.Windows.Forms.RadioButton radioButtonNoEVT;
        private System.Windows.Forms.RadioButton radioButtonUseTD;
        private System.Windows.Forms.TextBox tbGenderCodeFemale;
        private System.Windows.Forms.Label lbGenderCodeFemale;
        private System.Windows.Forms.TextBox tbSubjectSexM;
        private System.Windows.Forms.Label lbGenderCodeMale;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.CheckBox checkBoxDup;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox statusAfterUpload;
        private System.Windows.Forms.RadioButton rbStatusAfterUploadMarkedComplete;
        private System.Windows.Forms.RadioButton rbStatusAfterUploadDataEntryStarted;
        private System.Windows.Forms.CheckBox cbUploadWhen_DataEntryStarted;
        private System.Windows.Forms.CheckBox cbUploadWhen_NotStarted;
        private System.Windows.Forms.CheckBox cbUploadWhen_DataEntryComplete;
        private System.Windows.Forms.GroupBox gbUploadWhenCRFStatus;
    }
}

