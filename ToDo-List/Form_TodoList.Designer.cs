namespace ToDo_List
{
    partial class Form_TodoList
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbc_First = new System.Windows.Forms.TabControl();
            this.tbp_First_TaskList = new System.Windows.Forms.TabPage();
            this.gb_MainList = new System.Windows.Forms.GroupBox();
            this.dgv_Tasks = new System.Windows.Forms.DataGridView();
            this.colCodeTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriorityTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInitialDateTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescriptionTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinalDateTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaskProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_Fist_TaskData = new System.Windows.Forms.TabPage();
            this.tbc_Second = new System.Windows.Forms.TabControl();
            this.tbp_Second_GeneralData = new System.Windows.Forms.TabPage();
            this.gb_GeneralData = new System.Windows.Forms.GroupBox();
            this.cb_Priority = new System.Windows.Forms.ComboBox();
            this.lb_Priority = new System.Windows.Forms.Label();
            this.lb_TaskProgress = new System.Windows.Forms.Label();
            this.btn_CloseCalender_InitialDate = new System.Windows.Forms.Button();
            this.mc_Calender_InitialDate = new System.Windows.Forms.MonthCalendar();
            this.lb_InitialDate = new System.Windows.Forms.Label();
            this.lb_MandatoryFilling_1 = new System.Windows.Forms.Label();
            this.btn_OpenCalender_InitialDate = new System.Windows.Forms.Button();
            this.mtxtb_InitialDate = new System.Windows.Forms.MaskedTextBox();
            this.btn_CloseCalender_FinalDate = new System.Windows.Forms.Button();
            this.mc_Calender_FinalDate = new System.Windows.Forms.MonthCalendar();
            this.lb_Description = new System.Windows.Forms.Label();
            this.lb_FinalDate = new System.Windows.Forms.Label();
            this.lb_MandatoryFilling_4 = new System.Windows.Forms.Label();
            this.lb_MandatoryFilling_3 = new System.Windows.Forms.Label();
            this.lb_MandatoryFilling_2 = new System.Windows.Forms.Label();
            this.btn_OpenCalender_FinalDate = new System.Windows.Forms.Button();
            this.txtb_Description = new System.Windows.Forms.TextBox();
            this.txtb_DetailsTask = new System.Windows.Forms.TextBox();
            this.lb_DetailsTask = new System.Windows.Forms.Label();
            this.mtxtb_FinalDate = new System.Windows.Forms.MaskedTextBox();
            this.txtb_CodeTask = new System.Windows.Forms.TextBox();
            this.lb_CodeTask = new System.Windows.Forms.Label();
            this.txtb_TaskProgress = new System.Windows.Forms.TextBox();
            this.txtb_BackGroundDivision_Top = new System.Windows.Forms.TextBox();
            this.txtb_BackGroundDivision_Lower = new System.Windows.Forms.TextBox();
            this.btn_Canceled_Data = new System.Windows.Forms.Button();
            this.btn_Confirmed_Data = new System.Windows.Forms.Button();
            this.lb_WindowLogo = new System.Windows.Forms.Label();
            this.btn_CancelTask = new System.Windows.Forms.Button();
            this.btn_CompleteTask = new System.Windows.Forms.Button();
            this.btn_SearchTask = new System.Windows.Forms.Button();
            this.btn_ForwardGrid = new System.Windows.Forms.Button();
            this.btn_BackGrid = new System.Windows.Forms.Button();
            this.btn_DeleteTask = new System.Windows.Forms.Button();
            this.btn_AlterTask = new System.Windows.Forms.Button();
            this.btn_CreateTask = new System.Windows.Forms.Button();
            this.tbc_First.SuspendLayout();
            this.tbp_First_TaskList.SuspendLayout();
            this.gb_MainList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).BeginInit();
            this.tbp_Fist_TaskData.SuspendLayout();
            this.tbc_Second.SuspendLayout();
            this.tbp_Second_GeneralData.SuspendLayout();
            this.gb_GeneralData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_First
            // 
            this.tbc_First.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_First.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbc_First.Controls.Add(this.tbp_First_TaskList);
            this.tbc_First.Controls.Add(this.tbp_Fist_TaskData);
            this.tbc_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_First.HotTrack = true;
            this.tbc_First.ItemSize = new System.Drawing.Size(171, 34);
            this.tbc_First.Location = new System.Drawing.Point(1, 63);
            this.tbc_First.Name = "tbc_First";
            this.tbc_First.SelectedIndex = 0;
            this.tbc_First.Size = new System.Drawing.Size(1264, 624);
            this.tbc_First.TabIndex = 174;
            // 
            // tbp_First_TaskList
            // 
            this.tbp_First_TaskList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbp_First_TaskList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbp_First_TaskList.Controls.Add(this.gb_MainList);
            this.tbp_First_TaskList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_First_TaskList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbp_First_TaskList.Location = new System.Drawing.Point(4, 38);
            this.tbp_First_TaskList.Name = "tbp_First_TaskList";
            this.tbp_First_TaskList.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_First_TaskList.Size = new System.Drawing.Size(1256, 582);
            this.tbp_First_TaskList.TabIndex = 0;
            this.tbp_First_TaskList.Text = "LISTA DE TAREFAS";
            // 
            // gb_MainList
            // 
            this.gb_MainList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_MainList.BackColor = System.Drawing.Color.Transparent;
            this.gb_MainList.Controls.Add(this.dgv_Tasks);
            this.gb_MainList.Location = new System.Drawing.Point(-2, -2);
            this.gb_MainList.Name = "gb_MainList";
            this.gb_MainList.Size = new System.Drawing.Size(1256, 582);
            this.gb_MainList.TabIndex = 17;
            this.gb_MainList.TabStop = false;
            // 
            // dgv_Tasks
            // 
            this.dgv_Tasks.AllowUserToAddRows = false;
            this.dgv_Tasks.AllowUserToDeleteRows = false;
            this.dgv_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Tasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Tasks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Tasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Tasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Tasks.ColumnHeadersHeight = 30;
            this.dgv_Tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodeTask,
            this.colPriorityTask,
            this.colInitialDateTask,
            this.colDescriptionTask,
            this.colFinalDateTask,
            this.colTaskProgress});
            this.dgv_Tasks.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Tasks.Location = new System.Drawing.Point(0, 0);
            this.dgv_Tasks.MultiSelect = false;
            this.dgv_Tasks.Name = "dgv_Tasks";
            this.dgv_Tasks.ReadOnly = true;
            this.dgv_Tasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Tasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Tasks.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            this.dgv_Tasks.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_Tasks.RowTemplate.ReadOnly = true;
            this.dgv_Tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Tasks.Size = new System.Drawing.Size(1256, 585);
            this.dgv_Tasks.TabIndex = 17;
            this.dgv_Tasks.TabStop = false;
            this.dgv_Tasks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_Tasks_RowsAdded);
            this.dgv_Tasks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_Tasks_KeyUp);
            this.dgv_Tasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Tasks_MouseClick);
            this.dgv_Tasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Tasks_MouseDoubleClick);
            // 
            // colCodeTask
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.colCodeTask.DefaultCellStyle = dataGridViewCellStyle11;
            this.colCodeTask.HeaderText = "CÓDIGO";
            this.colCodeTask.Name = "colCodeTask";
            this.colCodeTask.ReadOnly = true;
            this.colCodeTask.Width = 250;
            // 
            // colPriorityTask
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.colPriorityTask.DefaultCellStyle = dataGridViewCellStyle12;
            this.colPriorityTask.HeaderText = "PRIORIDADE";
            this.colPriorityTask.Name = "colPriorityTask";
            this.colPriorityTask.ReadOnly = true;
            this.colPriorityTask.Width = 200;
            // 
            // colInitialDateTask
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.colInitialDateTask.DefaultCellStyle = dataGridViewCellStyle13;
            this.colInitialDateTask.HeaderText = "DATA INICIAL";
            this.colInitialDateTask.Name = "colInitialDateTask";
            this.colInitialDateTask.ReadOnly = true;
            this.colInitialDateTask.Width = 250;
            // 
            // colDescriptionTask
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.colDescriptionTask.DefaultCellStyle = dataGridViewCellStyle14;
            this.colDescriptionTask.HeaderText = "DESCRIÇÃO";
            this.colDescriptionTask.Name = "colDescriptionTask";
            this.colDescriptionTask.ReadOnly = true;
            this.colDescriptionTask.Width = 655;
            // 
            // colFinalDateTask
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.colFinalDateTask.DefaultCellStyle = dataGridViewCellStyle15;
            this.colFinalDateTask.HeaderText = "DATA FINAL";
            this.colFinalDateTask.Name = "colFinalDateTask";
            this.colFinalDateTask.ReadOnly = true;
            this.colFinalDateTask.Width = 250;
            // 
            // colTaskProgress
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.colTaskProgress.DefaultCellStyle = dataGridViewCellStyle16;
            this.colTaskProgress.HeaderText = "PROGRESSO ATUAL";
            this.colTaskProgress.Name = "colTaskProgress";
            this.colTaskProgress.ReadOnly = true;
            this.colTaskProgress.Width = 300;
            // 
            // tbp_Fist_TaskData
            // 
            this.tbp_Fist_TaskData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbp_Fist_TaskData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbp_Fist_TaskData.Controls.Add(this.tbc_Second);
            this.tbp_Fist_TaskData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbp_Fist_TaskData.Location = new System.Drawing.Point(4, 38);
            this.tbp_Fist_TaskData.Name = "tbp_Fist_TaskData";
            this.tbp_Fist_TaskData.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Fist_TaskData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbp_Fist_TaskData.Size = new System.Drawing.Size(1256, 582);
            this.tbp_Fist_TaskData.TabIndex = 1;
            this.tbp_Fist_TaskData.Text = "DADOS DA TAREFA";
            // 
            // tbc_Second
            // 
            this.tbc_Second.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbc_Second.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Second.Controls.Add(this.tbp_Second_GeneralData);
            this.tbc_Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Second.HotTrack = true;
            this.tbc_Second.ItemSize = new System.Drawing.Size(171, 34);
            this.tbc_Second.Location = new System.Drawing.Point(-2, -2);
            this.tbc_Second.Name = "tbc_Second";
            this.tbc_Second.SelectedIndex = 0;
            this.tbc_Second.Size = new System.Drawing.Size(1253, 582);
            this.tbc_Second.TabIndex = 1;
            // 
            // tbp_Second_GeneralData
            // 
            this.tbp_Second_GeneralData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbp_Second_GeneralData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbp_Second_GeneralData.Controls.Add(this.gb_GeneralData);
            this.tbp_Second_GeneralData.Location = new System.Drawing.Point(4, 4);
            this.tbp_Second_GeneralData.Name = "tbp_Second_GeneralData";
            this.tbp_Second_GeneralData.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Second_GeneralData.Size = new System.Drawing.Size(1245, 540);
            this.tbp_Second_GeneralData.TabIndex = 0;
            this.tbp_Second_GeneralData.Text = "DADOS GERAIS";
            // 
            // gb_GeneralData
            // 
            this.gb_GeneralData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_GeneralData.BackColor = System.Drawing.Color.Transparent;
            this.gb_GeneralData.Controls.Add(this.cb_Priority);
            this.gb_GeneralData.Controls.Add(this.lb_Priority);
            this.gb_GeneralData.Controls.Add(this.lb_TaskProgress);
            this.gb_GeneralData.Controls.Add(this.btn_CloseCalender_InitialDate);
            this.gb_GeneralData.Controls.Add(this.mc_Calender_InitialDate);
            this.gb_GeneralData.Controls.Add(this.lb_InitialDate);
            this.gb_GeneralData.Controls.Add(this.lb_MandatoryFilling_1);
            this.gb_GeneralData.Controls.Add(this.btn_OpenCalender_InitialDate);
            this.gb_GeneralData.Controls.Add(this.mtxtb_InitialDate);
            this.gb_GeneralData.Controls.Add(this.btn_CloseCalender_FinalDate);
            this.gb_GeneralData.Controls.Add(this.mc_Calender_FinalDate);
            this.gb_GeneralData.Controls.Add(this.lb_Description);
            this.gb_GeneralData.Controls.Add(this.lb_FinalDate);
            this.gb_GeneralData.Controls.Add(this.lb_MandatoryFilling_4);
            this.gb_GeneralData.Controls.Add(this.lb_MandatoryFilling_3);
            this.gb_GeneralData.Controls.Add(this.lb_MandatoryFilling_2);
            this.gb_GeneralData.Controls.Add(this.btn_OpenCalender_FinalDate);
            this.gb_GeneralData.Controls.Add(this.txtb_Description);
            this.gb_GeneralData.Controls.Add(this.txtb_DetailsTask);
            this.gb_GeneralData.Controls.Add(this.lb_DetailsTask);
            this.gb_GeneralData.Controls.Add(this.mtxtb_FinalDate);
            this.gb_GeneralData.Controls.Add(this.txtb_CodeTask);
            this.gb_GeneralData.Controls.Add(this.lb_CodeTask);
            this.gb_GeneralData.Controls.Add(this.txtb_TaskProgress);
            this.gb_GeneralData.Controls.Add(this.txtb_BackGroundDivision_Top);
            this.gb_GeneralData.Controls.Add(this.txtb_BackGroundDivision_Lower);
            this.gb_GeneralData.Controls.Add(this.btn_Canceled_Data);
            this.gb_GeneralData.Controls.Add(this.btn_Confirmed_Data);
            this.gb_GeneralData.Enabled = false;
            this.gb_GeneralData.Location = new System.Drawing.Point(-2, -6);
            this.gb_GeneralData.Name = "gb_GeneralData";
            this.gb_GeneralData.Size = new System.Drawing.Size(1249, 544);
            this.gb_GeneralData.TabIndex = 0;
            this.gb_GeneralData.TabStop = false;
            // 
            // cb_Priority
            // 
            this.cb_Priority.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Priority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Priority.Items.AddRange(new object[] {
            "ALTA PRIORIDADE",
            "BAIXA PRIORIDADE"});
            this.cb_Priority.Location = new System.Drawing.Point(350, 147);
            this.cb_Priority.MaxDropDownItems = 2;
            this.cb_Priority.Name = "cb_Priority";
            this.cb_Priority.Size = new System.Drawing.Size(180, 26);
            this.cb_Priority.TabIndex = 177;
            // 
            // lb_Priority
            // 
            this.lb_Priority.AutoSize = true;
            this.lb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Priority.Location = new System.Drawing.Point(229, 151);
            this.lb_Priority.Name = "lb_Priority";
            this.lb_Priority.Size = new System.Drawing.Size(119, 18);
            this.lb_Priority.TabIndex = 151;
            this.lb_Priority.Text = "PRIORIDADE :";
            // 
            // lb_TaskProgress
            // 
            this.lb_TaskProgress.AutoSize = true;
            this.lb_TaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaskProgress.Location = new System.Drawing.Point(21, 133);
            this.lb_TaskProgress.Name = "lb_TaskProgress";
            this.lb_TaskProgress.Size = new System.Drawing.Size(171, 18);
            this.lb_TaskProgress.TabIndex = 86;
            this.lb_TaskProgress.Text = "PROGRESSO ATUAL";
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
            this.btn_CloseCalender_InitialDate.Location = new System.Drawing.Point(522, 39);
            this.btn_CloseCalender_InitialDate.Name = "btn_CloseCalender_InitialDate";
            this.btn_CloseCalender_InitialDate.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseCalender_InitialDate.TabIndex = 173;
            this.btn_CloseCalender_InitialDate.TabStop = false;
            this.btn_CloseCalender_InitialDate.UseVisualStyleBackColor = false;
            this.btn_CloseCalender_InitialDate.Visible = false;
            this.btn_CloseCalender_InitialDate.Click += new System.EventHandler(this.btn_CloseCalender_InitialDate_Click);
            // 
            // mc_Calender_InitialDate
            // 
            this.mc_Calender_InitialDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mc_Calender_InitialDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mc_Calender_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_Calender_InitialDate.Location = new System.Drawing.Point(551, 68);
            this.mc_Calender_InitialDate.MaxSelectionCount = 1;
            this.mc_Calender_InitialDate.Name = "mc_Calender_InitialDate";
            this.mc_Calender_InitialDate.TabIndex = 175;
            this.mc_Calender_InitialDate.Visible = false;
            this.mc_Calender_InitialDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_Calender_InitialDate_DateSelected);
            // 
            // lb_InitialDate
            // 
            this.lb_InitialDate.AutoSize = true;
            this.lb_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InitialDate.Location = new System.Drawing.Point(299, 48);
            this.lb_InitialDate.Name = "lb_InitialDate";
            this.lb_InitialDate.Size = new System.Drawing.Size(120, 18);
            this.lb_InitialDate.TabIndex = 174;
            this.lb_InitialDate.Text = "DATA INICIAL :";
            // 
            // lb_MandatoryFilling_1
            // 
            this.lb_MandatoryFilling_1.AutoSize = true;
            this.lb_MandatoryFilling_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MandatoryFilling_1.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_MandatoryFilling_1.Location = new System.Drawing.Point(286, 44);
            this.lb_MandatoryFilling_1.Name = "lb_MandatoryFilling_1";
            this.lb_MandatoryFilling_1.Size = new System.Drawing.Size(21, 25);
            this.lb_MandatoryFilling_1.TabIndex = 176;
            this.lb_MandatoryFilling_1.Text = "*";
            this.lb_MandatoryFilling_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_OpenCalender_InitialDate.Location = new System.Drawing.Point(522, 39);
            this.btn_OpenCalender_InitialDate.Name = "btn_OpenCalender_InitialDate";
            this.btn_OpenCalender_InitialDate.Size = new System.Drawing.Size(35, 35);
            this.btn_OpenCalender_InitialDate.TabIndex = 172;
            this.btn_OpenCalender_InitialDate.UseVisualStyleBackColor = false;
            this.btn_OpenCalender_InitialDate.Click += new System.EventHandler(this.btn_OpenCalender_InitialDate_Click);
            // 
            // mtxtb_InitialDate
            // 
            this.mtxtb_InitialDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtb_InitialDate.Location = new System.Drawing.Point(421, 44);
            this.mtxtb_InitialDate.Mask = "00/00/0000";
            this.mtxtb_InitialDate.Name = "mtxtb_InitialDate";
            this.mtxtb_InitialDate.RejectInputOnFirstFailure = true;
            this.mtxtb_InitialDate.Size = new System.Drawing.Size(94, 26);
            this.mtxtb_InitialDate.TabIndex = 171;
            this.mtxtb_InitialDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtb_InitialDate.ValidatingType = typeof(System.DateTime);
            this.mtxtb_InitialDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtb_InitialDate_KeyPress);
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
            this.btn_CloseCalender_FinalDate.Location = new System.Drawing.Point(836, 38);
            this.btn_CloseCalender_FinalDate.Name = "btn_CloseCalender_FinalDate";
            this.btn_CloseCalender_FinalDate.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseCalender_FinalDate.TabIndex = 5;
            this.btn_CloseCalender_FinalDate.TabStop = false;
            this.btn_CloseCalender_FinalDate.UseVisualStyleBackColor = false;
            this.btn_CloseCalender_FinalDate.Visible = false;
            this.btn_CloseCalender_FinalDate.Click += new System.EventHandler(this.btn_CloseCalender_FinalDate_Click);
            // 
            // mc_Calender_FinalDate
            // 
            this.mc_Calender_FinalDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mc_Calender_FinalDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mc_Calender_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc_Calender_FinalDate.Location = new System.Drawing.Point(865, 67);
            this.mc_Calender_FinalDate.MaxSelectionCount = 1;
            this.mc_Calender_FinalDate.Name = "mc_Calender_FinalDate";
            this.mc_Calender_FinalDate.TabIndex = 164;
            this.mc_Calender_FinalDate.Visible = false;
            this.mc_Calender_FinalDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_Calender_FinalDate_DateSelected);
            // 
            // lb_Description
            // 
            this.lb_Description.AutoSize = true;
            this.lb_Description.BackColor = System.Drawing.Color.Transparent;
            this.lb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(227, 197);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(115, 18);
            this.lb_Description.TabIndex = 125;
            this.lb_Description.Text = "DESCRIÇÃO :";
            // 
            // lb_FinalDate
            // 
            this.lb_FinalDate.AutoSize = true;
            this.lb_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FinalDate.Location = new System.Drawing.Point(623, 47);
            this.lb_FinalDate.Name = "lb_FinalDate";
            this.lb_FinalDate.Size = new System.Drawing.Size(110, 18);
            this.lb_FinalDate.TabIndex = 147;
            this.lb_FinalDate.Text = "DATA FINAL :";
            // 
            // lb_MandatoryFilling_4
            // 
            this.lb_MandatoryFilling_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MandatoryFilling_4.AutoSize = true;
            this.lb_MandatoryFilling_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MandatoryFilling_4.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_MandatoryFilling_4.Location = new System.Drawing.Point(213, 193);
            this.lb_MandatoryFilling_4.Name = "lb_MandatoryFilling_4";
            this.lb_MandatoryFilling_4.Size = new System.Drawing.Size(21, 25);
            this.lb_MandatoryFilling_4.TabIndex = 170;
            this.lb_MandatoryFilling_4.Text = "*";
            this.lb_MandatoryFilling_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_MandatoryFilling_3
            // 
            this.lb_MandatoryFilling_3.AutoSize = true;
            this.lb_MandatoryFilling_3.BackColor = System.Drawing.Color.Transparent;
            this.lb_MandatoryFilling_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MandatoryFilling_3.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_MandatoryFilling_3.Location = new System.Drawing.Point(216, 147);
            this.lb_MandatoryFilling_3.Name = "lb_MandatoryFilling_3";
            this.lb_MandatoryFilling_3.Size = new System.Drawing.Size(21, 25);
            this.lb_MandatoryFilling_3.TabIndex = 169;
            this.lb_MandatoryFilling_3.Text = "*";
            this.lb_MandatoryFilling_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_MandatoryFilling_2
            // 
            this.lb_MandatoryFilling_2.AutoSize = true;
            this.lb_MandatoryFilling_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MandatoryFilling_2.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_MandatoryFilling_2.Location = new System.Drawing.Point(610, 43);
            this.lb_MandatoryFilling_2.Name = "lb_MandatoryFilling_2";
            this.lb_MandatoryFilling_2.Size = new System.Drawing.Size(21, 25);
            this.lb_MandatoryFilling_2.TabIndex = 168;
            this.lb_MandatoryFilling_2.Text = "*";
            this.lb_MandatoryFilling_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_OpenCalender_FinalDate.Location = new System.Drawing.Point(836, 38);
            this.btn_OpenCalender_FinalDate.Name = "btn_OpenCalender_FinalDate";
            this.btn_OpenCalender_FinalDate.Size = new System.Drawing.Size(35, 35);
            this.btn_OpenCalender_FinalDate.TabIndex = 4;
            this.btn_OpenCalender_FinalDate.UseVisualStyleBackColor = false;
            this.btn_OpenCalender_FinalDate.Click += new System.EventHandler(this.btn_OpenCalender_FinalDate_Click);
            // 
            // txtb_Description
            // 
            this.txtb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Description.Location = new System.Drawing.Point(344, 193);
            this.txtb_Description.MaxLength = 50;
            this.txtb_Description.Name = "txtb_Description";
            this.txtb_Description.Size = new System.Drawing.Size(726, 26);
            this.txtb_Description.TabIndex = 126;
            this.txtb_Description.WordWrap = false;
            this.txtb_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Description_KeyPress);
            // 
            // txtb_DetailsTask
            // 
            this.txtb_DetailsTask.AcceptsTab = true;
            this.txtb_DetailsTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_DetailsTask.Location = new System.Drawing.Point(344, 240);
            this.txtb_DetailsTask.MaxLength = 150;
            this.txtb_DetailsTask.Multiline = true;
            this.txtb_DetailsTask.Name = "txtb_DetailsTask";
            this.txtb_DetailsTask.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtb_DetailsTask.Size = new System.Drawing.Size(726, 90);
            this.txtb_DetailsTask.TabIndex = 10;
            this.txtb_DetailsTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_DetailsTask_KeyPress);
            // 
            // lb_DetailsTask
            // 
            this.lb_DetailsTask.AutoSize = true;
            this.lb_DetailsTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DetailsTask.Location = new System.Drawing.Point(170, 243);
            this.lb_DetailsTask.Name = "lb_DetailsTask";
            this.lb_DetailsTask.Size = new System.Drawing.Size(172, 18);
            this.lb_DetailsTask.TabIndex = 149;
            this.lb_DetailsTask.Text = "DETALHES TAREFA :";
            // 
            // mtxtb_FinalDate
            // 
            this.mtxtb_FinalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtb_FinalDate.Location = new System.Drawing.Point(735, 43);
            this.mtxtb_FinalDate.Mask = "00/00/0000";
            this.mtxtb_FinalDate.Name = "mtxtb_FinalDate";
            this.mtxtb_FinalDate.RejectInputOnFirstFailure = true;
            this.mtxtb_FinalDate.Size = new System.Drawing.Size(94, 26);
            this.mtxtb_FinalDate.TabIndex = 3;
            this.mtxtb_FinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtb_FinalDate.ValidatingType = typeof(System.DateTime);
            this.mtxtb_FinalDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtb_FinalDate_KeyPress);
            // 
            // txtb_CodeTask
            // 
            this.txtb_CodeTask.Enabled = false;
            this.txtb_CodeTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_CodeTask.Location = new System.Drawing.Point(108, 42);
            this.txtb_CodeTask.Multiline = true;
            this.txtb_CodeTask.Name = "txtb_CodeTask";
            this.txtb_CodeTask.Size = new System.Drawing.Size(124, 29);
            this.txtb_CodeTask.TabIndex = 1;
            this.txtb_CodeTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtb_CodeTask.WordWrap = false;
            // 
            // lb_CodeTask
            // 
            this.lb_CodeTask.AutoSize = true;
            this.lb_CodeTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CodeTask.Location = new System.Drawing.Point(21, 46);
            this.lb_CodeTask.Name = "lb_CodeTask";
            this.lb_CodeTask.Size = new System.Drawing.Size(85, 18);
            this.lb_CodeTask.TabIndex = 89;
            this.lb_CodeTask.Text = "CÓDIGO :";
            // 
            // txtb_TaskProgress
            // 
            this.txtb_TaskProgress.Enabled = false;
            this.txtb_TaskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TaskProgress.Location = new System.Drawing.Point(36, 151);
            this.txtb_TaskProgress.MaxLength = 150;
            this.txtb_TaskProgress.Name = "txtb_TaskProgress";
            this.txtb_TaskProgress.Size = new System.Drawing.Size(141, 26);
            this.txtb_TaskProgress.TabIndex = 8;
            this.txtb_TaskProgress.WordWrap = false;
            // 
            // txtb_BackGroundDivision_Top
            // 
            this.txtb_BackGroundDivision_Top.AcceptsTab = true;
            this.txtb_BackGroundDivision_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_BackGroundDivision_Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtb_BackGroundDivision_Top.Enabled = false;
            this.txtb_BackGroundDivision_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_BackGroundDivision_Top.Location = new System.Drawing.Point(8, 12);
            this.txtb_BackGroundDivision_Top.MaxLength = 0;
            this.txtb_BackGroundDivision_Top.Multiline = true;
            this.txtb_BackGroundDivision_Top.Name = "txtb_BackGroundDivision_Top";
            this.txtb_BackGroundDivision_Top.Size = new System.Drawing.Size(1229, 92);
            this.txtb_BackGroundDivision_Top.TabIndex = 88;
            // 
            // txtb_BackGroundDivision_Lower
            // 
            this.txtb_BackGroundDivision_Lower.AcceptsTab = true;
            this.txtb_BackGroundDivision_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_BackGroundDivision_Lower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtb_BackGroundDivision_Lower.Enabled = false;
            this.txtb_BackGroundDivision_Lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_BackGroundDivision_Lower.Location = new System.Drawing.Point(8, 111);
            this.txtb_BackGroundDivision_Lower.MaxLength = 0;
            this.txtb_BackGroundDivision_Lower.Multiline = true;
            this.txtb_BackGroundDivision_Lower.Name = "txtb_BackGroundDivision_Lower";
            this.txtb_BackGroundDivision_Lower.Size = new System.Drawing.Size(1229, 361);
            this.txtb_BackGroundDivision_Lower.TabIndex = 100;
            // 
            // btn_Canceled_Data
            // 
            this.btn_Canceled_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Canceled_Data.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Canceled_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Canceled_Data.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Canceled_Data.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Canceled_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Canceled_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Canceled_Data.Image = global::ToDo_List.Properties.Resources.Delete;
            this.btn_Canceled_Data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Canceled_Data.Location = new System.Drawing.Point(1064, 477);
            this.btn_Canceled_Data.Name = "btn_Canceled_Data";
            this.btn_Canceled_Data.Size = new System.Drawing.Size(173, 59);
            this.btn_Canceled_Data.TabIndex = 18;
            this.btn_Canceled_Data.Text = "    CANCELAR";
            this.btn_Canceled_Data.UseVisualStyleBackColor = false;
            this.btn_Canceled_Data.Click += new System.EventHandler(this.btn_Canceled_Data_Click);
            // 
            // btn_Confirmed_Data
            // 
            this.btn_Confirmed_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmed_Data.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Confirmed_Data.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Confirmed_Data.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Confirmed_Data.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Confirmed_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmed_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmed_Data.Image = global::ToDo_List.Properties.Resources.Apply;
            this.btn_Confirmed_Data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirmed_Data.Location = new System.Drawing.Point(885, 477);
            this.btn_Confirmed_Data.Name = "btn_Confirmed_Data";
            this.btn_Confirmed_Data.Size = new System.Drawing.Size(173, 59);
            this.btn_Confirmed_Data.TabIndex = 17;
            this.btn_Confirmed_Data.Text = "     CONFIRMAR";
            this.btn_Confirmed_Data.UseVisualStyleBackColor = false;
            this.btn_Confirmed_Data.Click += new System.EventHandler(this.btn_Confirmed_Data_Click);
            // 
            // lb_WindowLogo
            // 
            this.lb_WindowLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_WindowLogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_WindowLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_WindowLogo.Font = new System.Drawing.Font("Microsoft Tai Le", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_WindowLogo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_WindowLogo.Location = new System.Drawing.Point(0, -6);
            this.lb_WindowLogo.Name = "lb_WindowLogo";
            this.lb_WindowLogo.Size = new System.Drawing.Size(1264, 74);
            this.lb_WindowLogo.TabIndex = 181;
            this.lb_WindowLogo.Text = "                  TODO LIST";
            this.lb_WindowLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelTask
            // 
            this.btn_CancelTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CancelTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CancelTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CancelTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CancelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelTask.Image = global::ToDo_List.Properties.Resources.Bad_mark;
            this.btn_CancelTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelTask.Location = new System.Drawing.Point(568, 11);
            this.btn_CancelTask.Name = "btn_CancelTask";
            this.btn_CancelTask.Size = new System.Drawing.Size(135, 46);
            this.btn_CancelTask.TabIndex = 183;
            this.btn_CancelTask.Text = "      ENCERRAR";
            this.btn_CancelTask.UseVisualStyleBackColor = false;
            this.btn_CancelTask.Click += new System.EventHandler(this.btn_CancelTask_Click);
            // 
            // btn_CompleteTask
            // 
            this.btn_CompleteTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CompleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CompleteTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CompleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CompleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompleteTask.Image = global::ToDo_List.Properties.Resources.Good_mark;
            this.btn_CompleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CompleteTask.Location = new System.Drawing.Point(427, 11);
            this.btn_CompleteTask.Name = "btn_CompleteTask";
            this.btn_CompleteTask.Size = new System.Drawing.Size(135, 46);
            this.btn_CompleteTask.TabIndex = 182;
            this.btn_CompleteTask.Text = "      COMPLETAR";
            this.btn_CompleteTask.UseVisualStyleBackColor = false;
            this.btn_CompleteTask.Click += new System.EventHandler(this.btn_CompleteTask_Click);
            // 
            // btn_SearchTask
            // 
            this.btn_SearchTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SearchTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_SearchTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_SearchTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchTask.Image = global::ToDo_List.Properties.Resources.Find;
            this.btn_SearchTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SearchTask.Location = new System.Drawing.Point(1040, 11);
            this.btn_SearchTask.Name = "btn_SearchTask";
            this.btn_SearchTask.Size = new System.Drawing.Size(141, 46);
            this.btn_SearchTask.TabIndex = 180;
            this.btn_SearchTask.Text = "      PESQUISAR";
            this.btn_SearchTask.UseVisualStyleBackColor = false;
            this.btn_SearchTask.Click += new System.EventHandler(this.btn_SearchTask_Click);
            // 
            // btn_ForwardGrid
            // 
            this.btn_ForwardGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ForwardGrid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ForwardGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ForwardGrid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ForwardGrid.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ForwardGrid.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ForwardGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForwardGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ForwardGrid.Image = global::ToDo_List.Properties.Resources.Forward;
            this.btn_ForwardGrid.Location = new System.Drawing.Point(1192, 11);
            this.btn_ForwardGrid.Name = "btn_ForwardGrid";
            this.btn_ForwardGrid.Size = new System.Drawing.Size(61, 46);
            this.btn_ForwardGrid.TabIndex = 179;
            this.btn_ForwardGrid.UseVisualStyleBackColor = false;
            this.btn_ForwardGrid.Click += new System.EventHandler(this.btn_ForwardGrid_Click);
            // 
            // btn_BackGrid
            // 
            this.btn_BackGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BackGrid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BackGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_BackGrid.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BackGrid.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_BackGrid.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_BackGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackGrid.Image = global::ToDo_List.Properties.Resources.Back;
            this.btn_BackGrid.Location = new System.Drawing.Point(967, 11);
            this.btn_BackGrid.Name = "btn_BackGrid";
            this.btn_BackGrid.Size = new System.Drawing.Size(61, 46);
            this.btn_BackGrid.TabIndex = 178;
            this.btn_BackGrid.UseVisualStyleBackColor = false;
            this.btn_BackGrid.Click += new System.EventHandler(this.btn_BackGrid_Click);
            // 
            // btn_DeleteTask
            // 
            this.btn_DeleteTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_DeleteTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteTask.Image = global::ToDo_List.Properties.Resources.No_entry;
            this.btn_DeleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteTask.Location = new System.Drawing.Point(286, 11);
            this.btn_DeleteTask.Name = "btn_DeleteTask";
            this.btn_DeleteTask.Size = new System.Drawing.Size(135, 46);
            this.btn_DeleteTask.TabIndex = 177;
            this.btn_DeleteTask.Text = "      DELETAR";
            this.btn_DeleteTask.UseVisualStyleBackColor = false;
            this.btn_DeleteTask.Click += new System.EventHandler(this.btn_DeleteTask_Click);
            // 
            // btn_AlterTask
            // 
            this.btn_AlterTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AlterTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AlterTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_AlterTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AlterTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterTask.Image = global::ToDo_List.Properties.Resources.Modify;
            this.btn_AlterTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AlterTask.Location = new System.Drawing.Point(146, 11);
            this.btn_AlterTask.Name = "btn_AlterTask";
            this.btn_AlterTask.Size = new System.Drawing.Size(135, 46);
            this.btn_AlterTask.TabIndex = 176;
            this.btn_AlterTask.Text = "      ALTERAR";
            this.btn_AlterTask.UseVisualStyleBackColor = false;
            this.btn_AlterTask.Click += new System.EventHandler(this.btn_AlterTask_Click);
            // 
            // btn_CreateTask
            // 
            this.btn_CreateTask.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CreateTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateTask.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CreateTask.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_CreateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateTask.Image = global::ToDo_List.Properties.Resources.Add;
            this.btn_CreateTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTask.Location = new System.Drawing.Point(5, 11);
            this.btn_CreateTask.Name = "btn_CreateTask";
            this.btn_CreateTask.Size = new System.Drawing.Size(135, 46);
            this.btn_CreateTask.TabIndex = 175;
            this.btn_CreateTask.Text = "      CADASTRAR";
            this.btn_CreateTask.UseVisualStyleBackColor = false;
            this.btn_CreateTask.Click += new System.EventHandler(this.btn_CreateTask_Click);
            // 
            // Form_TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_CancelTask);
            this.Controls.Add(this.btn_CompleteTask);
            this.Controls.Add(this.btn_SearchTask);
            this.Controls.Add(this.btn_ForwardGrid);
            this.Controls.Add(this.btn_BackGrid);
            this.Controls.Add(this.btn_DeleteTask);
            this.Controls.Add(this.btn_AlterTask);
            this.Controls.Add(this.btn_CreateTask);
            this.Controls.Add(this.tbc_First);
            this.Controls.Add(this.lb_WindowLogo);
            this.Name = "Form_TodoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo LIST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_TodoList_FormClosing);
            this.Load += new System.EventHandler(this.Form_TodoList_Load);
            this.tbc_First.ResumeLayout(false);
            this.tbp_First_TaskList.ResumeLayout(false);
            this.gb_MainList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tasks)).EndInit();
            this.tbp_Fist_TaskData.ResumeLayout(false);
            this.tbc_Second.ResumeLayout(false);
            this.tbp_Second_GeneralData.ResumeLayout(false);
            this.gb_GeneralData.ResumeLayout(false);
            this.gb_GeneralData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SearchTask;
        private System.Windows.Forms.Button btn_ForwardGrid;
        private System.Windows.Forms.Button btn_BackGrid;
        private System.Windows.Forms.Button btn_DeleteTask;
        private System.Windows.Forms.Button btn_AlterTask;
        private System.Windows.Forms.Button btn_CreateTask;
        private System.Windows.Forms.TabControl tbc_First;
        private System.Windows.Forms.TabPage tbp_First_TaskList;
        private System.Windows.Forms.GroupBox gb_MainList;
        private System.Windows.Forms.DataGridView dgv_Tasks;
        private System.Windows.Forms.TabPage tbp_Fist_TaskData;
        private System.Windows.Forms.TabControl tbc_Second;
        private System.Windows.Forms.TabPage tbp_Second_GeneralData;
        private System.Windows.Forms.GroupBox gb_GeneralData;
        private System.Windows.Forms.Button btn_CloseCalender_FinalDate;
        private System.Windows.Forms.MonthCalendar mc_Calender_FinalDate;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.Label lb_FinalDate;
        private System.Windows.Forms.Label lb_MandatoryFilling_4;
        private System.Windows.Forms.Label lb_MandatoryFilling_3;
        private System.Windows.Forms.Label lb_MandatoryFilling_2;
        private System.Windows.Forms.Button btn_OpenCalender_FinalDate;
        private System.Windows.Forms.TextBox txtb_Description;
        private System.Windows.Forms.Label lb_Priority;
        private System.Windows.Forms.TextBox txtb_DetailsTask;
        private System.Windows.Forms.Label lb_DetailsTask;
        private System.Windows.Forms.MaskedTextBox mtxtb_FinalDate;
        private System.Windows.Forms.TextBox txtb_CodeTask;
        private System.Windows.Forms.Label lb_CodeTask;
        private System.Windows.Forms.TextBox txtb_TaskProgress;
        private System.Windows.Forms.Label lb_TaskProgress;
        private System.Windows.Forms.TextBox txtb_BackGroundDivision_Top;
        private System.Windows.Forms.TextBox txtb_BackGroundDivision_Lower;
        private System.Windows.Forms.Button btn_Canceled_Data;
        private System.Windows.Forms.Button btn_Confirmed_Data;
        private System.Windows.Forms.Label lb_WindowLogo;
        private System.Windows.Forms.Button btn_CompleteTask;
        private System.Windows.Forms.Button btn_CancelTask;
        private System.Windows.Forms.Button btn_CloseCalender_InitialDate;
        private System.Windows.Forms.MonthCalendar mc_Calender_InitialDate;
        private System.Windows.Forms.Label lb_InitialDate;
        private System.Windows.Forms.Label lb_MandatoryFilling_1;
        private System.Windows.Forms.Button btn_OpenCalender_InitialDate;
        private System.Windows.Forms.MaskedTextBox mtxtb_InitialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriorityTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInitialDateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescriptionTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinalDateTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaskProgress;
        private System.Windows.Forms.ComboBox cb_Priority;
    }
}

