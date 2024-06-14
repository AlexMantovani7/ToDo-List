namespace ToDo_List
{
    partial class Form_SearchingTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SearchingTask));
            this.mc_Calender = new System.Windows.Forms.MonthCalendar();
            this.tcp_Description = new System.Windows.Forms.TabPage();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.lb_Description = new System.Windows.Forms.Label();
            this.tcp_Priority = new System.Windows.Forms.TabPage();
            this.cb_Priority = new System.Windows.Forms.ComboBox();
            this.lb_Priority = new System.Windows.Forms.Label();
            this.tcp_TaskProgress = new System.Windows.Forms.TabPage();
            this.cb_TaskProgress = new System.Windows.Forms.ComboBox();
            this.lb_TaskProgress = new System.Windows.Forms.Label();
            this.tcp_DatesTask = new System.Windows.Forms.TabPage();
            this.mtxtb_FinalDate = new System.Windows.Forms.MaskedTextBox();
            this.lb_FinalDate = new System.Windows.Forms.Label();
            this.mtxtb_IniticalDate = new System.Windows.Forms.MaskedTextBox();
            this.lb_TaskDates = new System.Windows.Forms.Label();
            this.tcp_Code = new System.Windows.Forms.TabPage();
            this.txtb_Code = new System.Windows.Forms.TextBox();
            this.lb_Code = new System.Windows.Forms.Label();
            this.tc_Search = new System.Windows.Forms.TabControl();
            this.btn_SearchingCode = new System.Windows.Forms.Button();
            this.btn_CloseCalender_FinalDate = new System.Windows.Forms.Button();
            this.btn_CloseCalender_InitialDate = new System.Windows.Forms.Button();
            this.btn_OpenCalender_InitialDate = new System.Windows.Forms.Button();
            this.btn_OpenCalender_FinalDate = new System.Windows.Forms.Button();
            this.btn_SearchingDate = new System.Windows.Forms.Button();
            this.btn_SearchingTaskProgress = new System.Windows.Forms.Button();
            this.btn_SearchingPriority = new System.Windows.Forms.Button();
            this.btn_SearchingDescription = new System.Windows.Forms.Button();
            this.tcp_Description.SuspendLayout();
            this.tcp_Priority.SuspendLayout();
            this.tcp_TaskProgress.SuspendLayout();
            this.tcp_DatesTask.SuspendLayout();
            this.tcp_Code.SuspendLayout();
            this.tc_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // mc_Calender
            // 
            this.mc_Calender.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mc_Calender.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mc_Calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_Calender.Location = new System.Drawing.Point(500, -107);
            this.mc_Calender.MaxSelectionCount = 1;
            this.mc_Calender.Name = "mc_Calender";
            this.mc_Calender.TabIndex = 16;
            this.mc_Calender.Visible = false;
            this.mc_Calender.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_Calender_DateSelected);
            // 
            // tcp_Description
            // 
            this.tcp_Description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tcp_Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcp_Description.Controls.Add(this.txtb_Description);
            this.tcp_Description.Controls.Add(this.lb_Description);
            this.tcp_Description.Controls.Add(this.btn_SearchingDescription);
            this.tcp_Description.Location = new System.Drawing.Point(4, 4);
            this.tcp_Description.Name = "tcp_Description";
            this.tcp_Description.Size = new System.Drawing.Size(742, 76);
            this.tcp_Description.TabIndex = 1;
            this.tcp_Description.Text = "DESCRIÇÃO";
            // 
            // txtb_Description
            // 
            this.txtb_Description.BackColor = System.Drawing.Color.White;
            this.txtb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Description.Location = new System.Drawing.Point(120, 26);
            this.txtb_Description.MaxLength = 50;
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(434, 26);
            this.txtb_Description.TabIndex = 10;
            this.txtb_Description.WordWrap = false;
            this.txtb_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Description_KeyPress);
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.BackColor = System.Drawing.Color.Transparent;
            this.lb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(3, 30);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(115, 18);
            this.lb_Description.TabIndex = 55;
            this.lb_Description.Text = "DESCRIÇÃO :";
            // 
            // tcp_Priority
            // 
            this.tcp_Priority.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tcp_Priority.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcp_Priority.Controls.Add(this.cb_Priority);
            this.tcp_Priority.Controls.Add(this.lb_Priority);
            this.tcp_Priority.Controls.Add(this.btn_SearchingPriority);
            this.tcp_Priority.Location = new System.Drawing.Point(4, 4);
            this.tcp_Priority.Name = "tcp_Priority";
            this.tcp_Priority.Size = new System.Drawing.Size(742, 76);
            this.tcp_Priority.TabIndex = 15;
            this.tcp_Priority.Text = "PRIORIDADE";
            // 
            // cb_Priority
            // 
            this.cb_Priority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Priority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Priority.Items.AddRange(new object[] {
            "ALTA",
            "BAIXA"});
            this.cb_Priority.Location = new System.Drawing.Point(126, 26);
            this.cb_Priority.MaxDropDownItems = 2;
            this.cb_Priority.Name = "cb_Priority";
            this.cb_Priority.Size = new System.Drawing.Size(134, 26);
            this.cb_Priority.TabIndex = 8;
            // 
            // lb_Priority
            // 
            this.lb_Priority.AutoSize = true;
            this.lb_Priority.BackColor = System.Drawing.Color.Transparent;
            this.lb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Priority.Location = new System.Drawing.Point(3, 30);
            this.lb_Priority.Name = "lb_Priority";
            this.lb_Priority.Size = new System.Drawing.Size(119, 18);
            this.lb_Priority.TabIndex = 58;
            this.lb_Priority.Text = "PRIORIDADE :";
            // 
            // tcp_TaskProgress
            // 
            this.tcp_TaskProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tcp_TaskProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcp_TaskProgress.Controls.Add(this.cb_TaskProgress);
            this.tcp_TaskProgress.Controls.Add(this.lb_TaskProgress);
            this.tcp_TaskProgress.Controls.Add(this.btn_SearchingTaskProgress);
            this.tcp_TaskProgress.Location = new System.Drawing.Point(4, 4);
            this.tcp_TaskProgress.Name = "tcp_TaskProgress";
            this.tcp_TaskProgress.Size = new System.Drawing.Size(742, 76);
            this.tcp_TaskProgress.TabIndex = 14;
            this.tcp_TaskProgress.Text = "PROGRESSO TAREFA";
            // 
            // cb_TaskProgress
            // 
            this.cb_TaskProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_TaskProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TaskProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TaskProgress.Items.AddRange(new object[] {
            "ESPERANDO",
            "REALIZANDO",
            "CONCUIDO",
            "CANCELADO"});
            this.cb_TaskProgress.Location = new System.Drawing.Point(132, 26);
            this.cb_TaskProgress.MaxDropDownItems = 4;
            this.cb_TaskProgress.Name = "cb_TaskProgress";
            this.cb_TaskProgress.Size = new System.Drawing.Size(219, 26);
            this.cb_TaskProgress.TabIndex = 6;
            // 
            // lb_TaskProgress
            // 
            this.lb_TaskProgress.AutoSize = true;
            this.lb_TaskProgress.BackColor = System.Drawing.Color.Transparent;
            this.lb_TaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaskProgress.Location = new System.Drawing.Point(3, 30);
            this.lb_TaskProgress.Name = "lb_TaskProgress";
            this.lb_TaskProgress.Size = new System.Drawing.Size(125, 18);
            this.lb_TaskProgress.TabIndex = 58;
            this.lb_TaskProgress.Text = "PROGRESSO :";
            // 
            // tcp_DatesTask
            // 
            this.tcp_DatesTask.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tcp_DatesTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcp_DatesTask.Controls.Add(this.btn_CloseCalender_FinalDate);
            this.tcp_DatesTask.Controls.Add(this.btn_CloseCalender_InitialDate);
            this.tcp_DatesTask.Controls.Add(this.btn_OpenCalender_InitialDate);
            this.tcp_DatesTask.Controls.Add(this.btn_OpenCalender_FinalDate);
            this.tcp_DatesTask.Controls.Add(this.mtxtb_FinalDate);
            this.tcp_DatesTask.Controls.Add(this.lb_FinalDate);
            this.tcp_DatesTask.Controls.Add(this.mtxtb_IniticalDate);
            this.tcp_DatesTask.Controls.Add(this.lb_TaskDates);
            this.tcp_DatesTask.Controls.Add(this.btn_SearchingDate);
            this.tcp_DatesTask.Location = new System.Drawing.Point(4, 4);
            this.tcp_DatesTask.Name = "tcp_DatesTask";
            this.tcp_DatesTask.Size = new System.Drawing.Size(742, 76);
            this.tcp_DatesTask.TabIndex = 13;
            this.tcp_DatesTask.Text = "DATAS TAREFA";
            // 
            // mtxtb_FinalDate
            // 
            this.mtxtb_FinalDate.BackColor = System.Drawing.Color.White;
            this.mtxtb_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtb_FinalDate.Location = new System.Drawing.Point(375, 26);
            this.mtxtb_FinalDate.Mask = "00/00/0000";
            this.mtxtb_FinalDate.Name = "mtxtb_FinalDate";
            this.mtxtb_FinalDate.RejectInputOnFirstFailure = true;
            this.mtxtb_FinalDate.Size = new System.Drawing.Size(86, 26);
            this.mtxtb_FinalDate.TabIndex = 4;
            this.mtxtb_FinalDate.TabStop = false;
            this.mtxtb_FinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtb_FinalDate.ValidatingType = typeof(System.DateTime);
            this.mtxtb_FinalDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtb_FinalDate_KeyPress);
            // 
            // lb_FinalDate
            // 
            this.lb_FinalDate.AutoSize = true;
            this.lb_FinalDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FinalDate.Location = new System.Drawing.Point(315, 30);
            this.lb_FinalDate.Name = "lb_FinalDate";
            this.lb_FinalDate.Size = new System.Drawing.Size(58, 18);
            this.lb_FinalDate.TabIndex = 64;
            this.lb_FinalDate.Text = "FINAL:";
            // 
            // mtxtb_IniticalDate
            // 
            this.mtxtb_IniticalDate.BackColor = System.Drawing.Color.White;
            this.mtxtb_IniticalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtb_IniticalDate.Location = new System.Drawing.Point(146, 26);
            this.mtxtb_IniticalDate.Mask = "00/00/0000";
            this.mtxtb_IniticalDate.Name = "mtxtb_IniticalDate";
            this.mtxtb_IniticalDate.RejectInputOnFirstFailure = true;
            this.mtxtb_IniticalDate.Size = new System.Drawing.Size(86, 26);
            this.mtxtb_IniticalDate.TabIndex = 3;
            this.mtxtb_IniticalDate.TabStop = false;
            this.mtxtb_IniticalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtb_IniticalDate.ValidatingType = typeof(System.DateTime);
            this.mtxtb_IniticalDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtb_IniticalDate_KeyPress);
            // 
            // lb_TaskDates
            // 
            this.lb_TaskDates.AutoSize = true;
            this.lb_TaskDates.BackColor = System.Drawing.Color.Transparent;
            this.lb_TaskDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaskDates.Location = new System.Drawing.Point(3, 30);
            this.lb_TaskDates.Name = "lb_TaskDates";
            this.lb_TaskDates.Size = new System.Drawing.Size(141, 18);
            this.lb_TaskDates.TabIndex = 61;
            this.lb_TaskDates.Text = "DATAS    INICIAL:";
            // 
            // tcp_Code
            // 
            this.tcp_Code.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tcp_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tcp_Code.Controls.Add(this.txtb_Code);
            this.tcp_Code.Controls.Add(this.lb_Code);
            this.tcp_Code.Controls.Add(this.btn_SearchingCode);
            this.tcp_Code.Location = new System.Drawing.Point(4, 4);
            this.tcp_Code.Name = "tcp_Code";
            this.tcp_Code.Padding = new System.Windows.Forms.Padding(3);
            this.tcp_Code.Size = new System.Drawing.Size(742, 76);
            this.tcp_Code.TabIndex = 0;
            this.tcp_Code.Text = "CÓDIGO";
            // 
            // txtb_Code
            // 
            this.txtb_Code.BackColor = System.Drawing.Color.White;
            this.txtb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Code.Location = new System.Drawing.Point(89, 26);
            this.txtb_Code.Name = "txtb_Code";
            this.txtb_Code.Size = new System.Drawing.Size(465, 26);
            this.txtb_Code.TabIndex = 1;
            this.txtb_Code.WordWrap = false;
            this.txtb_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Code_KeyPress);
            // 
            // lb_Code
            // 
            this.lb_Code.AutoSize = true;
            this.lb_Code.BackColor = System.Drawing.Color.Transparent;
            this.lb_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Code.Location = new System.Drawing.Point(2, 30);
            this.lb_Code.Name = "lb_Code";
            this.lb_Code.Size = new System.Drawing.Size(85, 18);
            this.lb_Code.TabIndex = 52;
            this.lb_Code.Text = "CÓDIGO :";
            // 
            // tc_Search
            // 
            this.tc_Search.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tc_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tc_Search.Controls.Add(this.tcp_Code);
            this.tc_Search.Controls.Add(this.tcp_DatesTask);
            this.tc_Search.Controls.Add(this.tcp_TaskProgress);
            this.tc_Search.Controls.Add(this.tcp_Priority);
            this.tc_Search.Controls.Add(this.tcp_Description);
            this.tc_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tc_Search.HotTrack = true;
            this.tc_Search.Location = new System.Drawing.Point(-1, 1);
            this.tc_Search.Name = "tc_Search";
            this.tc_Search.SelectedIndex = 0;
            this.tc_Search.Size = new System.Drawing.Size(750, 105);
            this.tc_Search.TabIndex = 17;
            this.tc_Search.TabStop = false;
            this.tc_Search.SelectedIndexChanged += new System.EventHandler(this.tc_Search_SelectedIndexChanged);
            // 
            // btn_SearchingCode
            // 
            this.btn_SearchingCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SearchingCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchingCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchingCode.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchingCode.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchingCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchingCode.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_SearchingCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchingCode.Location = new System.Drawing.Point(560, 7);
            this.btn_SearchingCode.Name = "btn_SearchingCode";
            this.btn_SearchingCode.Size = new System.Drawing.Size(173, 59);
            this.btn_SearchingCode.TabIndex = 2;
            this.btn_SearchingCode.Text = "      PESQUISAR";
            this.btn_SearchingCode.UseVisualStyleBackColor = false;
            this.btn_SearchingCode.Click += new System.EventHandler(this.btn_SearchingCode_Click);
            // 
            // btn_CloseCalender_FinalDate
            // 
            this.btn_CloseCalender_FinalDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CloseCalender_FinalDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CloseCalender_FinalDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CloseCalender_FinalDate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CloseCalender_FinalDate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CloseCalender_FinalDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseCalender_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseCalender_FinalDate.Image = global::ToDo_List.Properties.Resources.Delete;
            this.btn_CloseCalender_FinalDate.Location = new System.Drawing.Point(467, 19);
            this.btn_CloseCalender_FinalDate.Name = "btn_CloseCalender_FinalDate";
            this.btn_CloseCalender_FinalDate.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseCalender_FinalDate.TabIndex = 15;
            this.btn_CloseCalender_FinalDate.TabStop = false;
            this.btn_CloseCalender_FinalDate.UseVisualStyleBackColor = false;
            this.btn_CloseCalender_FinalDate.Visible = false;
            this.btn_CloseCalender_FinalDate.Click += new System.EventHandler(this.btn_CloseCalender_FinalDate_Click);
            // 
            // btn_CloseCalender_InitialDate
            // 
            this.btn_CloseCalender_InitialDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CloseCalender_InitialDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CloseCalender_InitialDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CloseCalender_InitialDate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CloseCalender_InitialDate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CloseCalender_InitialDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseCalender_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseCalender_InitialDate.Image = global::ToDo_List.Properties.Resources.Delete;
            this.btn_CloseCalender_InitialDate.Location = new System.Drawing.Point(238, 19);
            this.btn_CloseCalender_InitialDate.Name = "btn_CloseCalender_InitialDate";
            this.btn_CloseCalender_InitialDate.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseCalender_InitialDate.TabIndex = 13;
            this.btn_CloseCalender_InitialDate.TabStop = false;
            this.btn_CloseCalender_InitialDate.UseVisualStyleBackColor = false;
            this.btn_CloseCalender_InitialDate.Visible = false;
            this.btn_CloseCalender_InitialDate.Click += new System.EventHandler(this.btn_CloseCalender_InitialDate_Click);
            // 
            // btn_OpenCalender_InitialDate
            // 
            this.btn_OpenCalender_InitialDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OpenCalender_InitialDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_OpenCalender_InitialDate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_OpenCalender_InitialDate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_OpenCalender_InitialDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCalender_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCalender_InitialDate.Image = global::ToDo_List.Properties.Resources.Calendar;
            this.btn_OpenCalender_InitialDate.Location = new System.Drawing.Point(238, 19);
            this.btn_OpenCalender_InitialDate.Name = "btn_OpenCalender_InitialDate";
            this.btn_OpenCalender_InitialDate.Size = new System.Drawing.Size(35, 35);
            this.btn_OpenCalender_InitialDate.TabIndex = 12;
            this.btn_OpenCalender_InitialDate.UseVisualStyleBackColor = false;
            this.btn_OpenCalender_InitialDate.Click += new System.EventHandler(this.btn_OpenCalender_InitialDate_Click);
            // 
            // btn_OpenCalender_FinalDate
            // 
            this.btn_OpenCalender_FinalDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_OpenCalender_FinalDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_OpenCalender_FinalDate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_OpenCalender_FinalDate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_OpenCalender_FinalDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCalender_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCalender_FinalDate.Image = global::ToDo_List.Properties.Resources.Calendar;
            this.btn_OpenCalender_FinalDate.Location = new System.Drawing.Point(467, 19);
            this.btn_OpenCalender_FinalDate.Name = "btn_OpenCalender_FinalDate";
            this.btn_OpenCalender_FinalDate.Size = new System.Drawing.Size(35, 35);
            this.btn_OpenCalender_FinalDate.TabIndex = 14;
            this.btn_OpenCalender_FinalDate.UseVisualStyleBackColor = false;
            this.btn_OpenCalender_FinalDate.Click += new System.EventHandler(this.btn_OpenCalender_FinalDate_Click);
            // 
            // btn_SearchingDate
            // 
            this.btn_SearchingDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SearchingDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchingDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchingDate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchingDate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchingDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchingDate.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_SearchingDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchingDate.Location = new System.Drawing.Point(560, 7);
            this.btn_SearchingDate.Name = "btn_SearchingDate";
            this.btn_SearchingDate.Size = new System.Drawing.Size(173, 59);
            this.btn_SearchingDate.TabIndex = 5;
            this.btn_SearchingDate.Text = "      PESQUISAR";
            this.btn_SearchingDate.UseVisualStyleBackColor = false;
            this.btn_SearchingDate.Click += new System.EventHandler(this.btn_SearchingDate_Click);
            // 
            // btn_SearchingTaskProgress
            // 
            this.btn_SearchingTaskProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SearchingTaskProgress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchingTaskProgress.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchingTaskProgress.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchingTaskProgress.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchingTaskProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchingTaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchingTaskProgress.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_SearchingTaskProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchingTaskProgress.Location = new System.Drawing.Point(560, 7);
            this.btn_SearchingTaskProgress.Name = "btn_SearchingTaskProgress";
            this.btn_SearchingTaskProgress.Size = new System.Drawing.Size(173, 59);
            this.btn_SearchingTaskProgress.TabIndex = 7;
            this.btn_SearchingTaskProgress.Text = "      PESQUISAR";
            this.btn_SearchingTaskProgress.UseVisualStyleBackColor = false;
            this.btn_SearchingTaskProgress.Click += new System.EventHandler(this.btn_SearchingTaskProgress_Click);
            // 
            // btn_SearchingPriority
            // 
            this.btn_SearchingPriority.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SearchingPriority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchingPriority.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchingPriority.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchingPriority.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchingPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchingPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchingPriority.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_SearchingPriority.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchingPriority.Location = new System.Drawing.Point(560, 7);
            this.btn_SearchingPriority.Name = "btn_SearchingPriority";
            this.btn_SearchingPriority.Size = new System.Drawing.Size(173, 59);
            this.btn_SearchingPriority.TabIndex = 9;
            this.btn_SearchingPriority.Text = "      PESQUISAR";
            this.btn_SearchingPriority.UseVisualStyleBackColor = false;
            this.btn_SearchingPriority.Click += new System.EventHandler(this.btn_SearchingPriority_Click);
            // 
            // btn_SearchingDescription
            // 
            this.btn_SearchingDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_SearchingDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchingDescription.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchingDescription.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchingDescription.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchingDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchingDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchingDescription.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_SearchingDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchingDescription.Location = new System.Drawing.Point(560, 7);
            this.btn_SearchingDescription.Name = "btn_SearchingDescription";
            this.btn_SearchingDescription.Size = new System.Drawing.Size(173, 59);
            this.btn_SearchingDescription.TabIndex = 11;
            this.btn_SearchingDescription.Text = "      PESQUISAR";
            this.btn_SearchingDescription.UseVisualStyleBackColor = false;
            this.btn_SearchingDescription.Click += new System.EventHandler(this.btn_SearchingDescription_Click);
            // 
            // Form_SearchingTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 108);
            this.Controls.Add(this.mc_Calender);
            this.Controls.Add(this.tc_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_SearchingTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISANDO TAREFA";
            this.Load += new System.EventHandler(this.Form_SearchingTask_Load);
            this.tcp_Description.ResumeLayout(false);
            this.tcp_Description.PerformLayout();
            this.tcp_Priority.ResumeLayout(false);
            this.tcp_Priority.PerformLayout();
            this.tcp_TaskProgress.ResumeLayout(false);
            this.tcp_TaskProgress.PerformLayout();
            this.tcp_DatesTask.ResumeLayout(false);
            this.tcp_DatesTask.PerformLayout();
            this.tcp_Code.ResumeLayout(false);
            this.tcp_Code.PerformLayout();
            this.tc_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_Calender;
        private System.Windows.Forms.TabPage tcp_Description;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.Button btn_SearchingDescription;
        private System.Windows.Forms.TabPage tcp_Priority;
        private System.Windows.Forms.ComboBox cb_Priority;
        private System.Windows.Forms.Label lb_Priority;
        private System.Windows.Forms.Button btn_SearchingPriority;
        private System.Windows.Forms.TabPage tcp_TaskProgress;
        private System.Windows.Forms.ComboBox cb_TaskProgress;
        private System.Windows.Forms.Label lb_TaskProgress;
        private System.Windows.Forms.Button btn_SearchingTaskProgress;
        private System.Windows.Forms.TabPage tcp_DatesTask;
        private System.Windows.Forms.Button btn_CloseCalender_FinalDate;
        private System.Windows.Forms.Button btn_CloseCalender_InitialDate;
        private System.Windows.Forms.Button btn_OpenCalender_InitialDate;
        private System.Windows.Forms.Button btn_OpenCalender_FinalDate;
        private System.Windows.Forms.MaskedTextBox mtxtb_FinalDate;
        private System.Windows.Forms.Label lb_FinalDate;
        private System.Windows.Forms.MaskedTextBox mtxtb_IniticalDate;
        private System.Windows.Forms.Label lb_TaskDates;
        private System.Windows.Forms.Button btn_SearchingDate;
        private System.Windows.Forms.TabPage tcp_Code;
        private System.Windows.Forms.TextBox txtb_Code;
        private System.Windows.Forms.Label lb_Code;
        private System.Windows.Forms.Button btn_SearchingCode;
        private System.Windows.Forms.TabControl tc_Search;
    }
}