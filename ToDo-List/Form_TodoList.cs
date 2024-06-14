using Processing_Layer;
using System.Windows.Forms;
using TransferObject_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
using ToDo_List.Properties;

namespace ToDo_List
{
    public partial class Form_TodoList : Form
    {
        #region ToDo_List Variables

        private Task_Object task_Object;
        private TaskObject_List taskObject_List;
        private Task_Process task_Process;

        private List<Task_Object> searchList;

        private Manage_DefaultSystemMessages manage_DefaultSystemMessages;
        private Shared_FormFunctions shared_FormFunctions;

        private Manage_LoadingScreen manage_LoadingScreen;
        private Form_Loading form_Loading;
        private Thread loadingThread;
        private bool loadingIsOpening;

        private string currentOperation;
        private bool firstSearch;

        private Task_Object checkLineProgress;
        private static int columnCodeIndex = 0;
        
        private string buttomSearchImage;
        private Form_SearchingTask form_SearchingTask;

        #endregion

        public Form_TodoList()
        {
            try
            {
                InitializeComponent();

                task_Object = new Task_Object();
                taskObject_List = new TaskObject_List();
                task_Process = new Task_Process();

                searchList = new TaskObject_List();

                manage_DefaultSystemMessages = new Manage_DefaultSystemMessages();
                shared_FormFunctions = new Shared_FormFunctions();

                manage_LoadingScreen = new Manage_LoadingScreen();
                form_Loading = new Form_Loading();
                loadingThread = null;
                loadingIsOpening = false;

                currentOperation = "";
                firstSearch = false;

                buttomSearchImage = "SEARCH";
                form_SearchingTask = new Form_SearchingTask();

                dgv_Tasks.AutoGenerateColumns = false;
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
                this.Close();
            }
        }

        #region Form Events

        private void Form_TodoList_Load(object sender, EventArgs e)
        {
            try
            {
                Get_DGVList();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }
        
        private void Form_TodoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (manage_DefaultSystemMessages.WindowClosing_Message("").Equals(DialogResult.Cancel))
                    e.Cancel = true;
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        #endregion

        #region General Functions

        private void CleanRegistrationFields()
        {
            try
            {
                txtb_CodeTask.Clear();

                mtxtb_InitialDate.Clear();
                mtxtb_FinalDate.Clear();

                txtb_TaskProgress.Clear();

                cb_Priority.SelectedIndex = 0;

                txtb_Description.Clear();
                txtb_DetailsTask.Clear();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void Get_DGVList()
        {
            try
            {
                Task_Object to = new Task_Object();
                taskObject_List = task_Process.ConsultField(to, true);

                Loading_DGVList();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void Loading_DGVList()
        {
            try
            {
                if (taskObject_List.Count > 0)
                {
                    dgv_Tasks.Rows.Clear();
                    checkLineProgress = new Task_Object();

                    foreach (Task_Object item in taskObject_List)
                    {
                        AddDGVLine(item);
                    }

                    if (firstSearch)
                    {
                        int result = 0;
                        firstSearch = false;

                        Task_Object convertTask = new Task_Object();

                        foreach (Task_Object item in taskObject_List.Where(to => to.code.Equals(task_Object.code)))
                        {
                            result = (int)item.code;
                            break;
                        }

                        if (!result.Equals(0))
                        {
                            convertTask = taskObject_List.Where(to => to.code.Equals(task_Object.code)).Last();

                            foreach (DataGridViewRow item in dgv_Tasks.Rows)
                            {
                                if (item.Cells[columnCodeIndex].Value.Equals((int)convertTask.code))
                                    dgv_Tasks.CurrentCell = dgv_Tasks.Rows[item.Index].Cells[columnCodeIndex];
                            }
                        }
                        else
                            dgv_Tasks.Rows[0].Selected = true;
                    }
                    else
                    {
                        firstSearch = false;
                        dgv_Tasks.Rows[0].Selected = true;
                    }

                    FillFields();
                }
                else
                {
                    firstSearch = false;

                    dgv_Tasks.Rows.Clear();

                    shared_FormFunctions.ManageMainButtons(false, btn_AlterTask, btn_DeleteTask, btn_CompleteTask, btn_CancelTask, btn_BackGrid,
                        btn_SearchTask, btn_ForwardGrid);

                    CleanRegistrationFields();
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void AddDGVLine(Task_Object item)
        {
            try
            {
                if (!item.task_progress.Equals("CONCLUIDO"))
                {
                    if (DateTime.Now.Date >= item.initial_date && DateTime.Now.Date <= item.final_date)
                        item.task_progress = "REALIZANDO";
                    else if (DateTime.Now.Date < item.initial_date)
                        item.task_progress = "ESPERANDO";
                    else if (DateTime.Now.Date > item.final_date)
                        item.task_progress = "CANCELADO";
                }
                
                checkLineProgress = item;

                dgv_Tasks.Rows.Add(item.code, item.priority, DateTime.Parse(item.initial_date.ToString()).ToString("dd/MM/yyyy"), item.description, DateTime.Parse(item.final_date.ToString()).ToString("dd/MM/yyyy"),
                    item.task_progress);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void FillFields()
        {
            try
            {
                if (dgv_Tasks.RowCount > 0)
                {
                    loadingIsOpening = true;
                    manage_LoadingScreen.OpenLoading(this, form_Loading, loadingThread);

                    int selectedLineCode = Convert.ToInt32(dgv_Tasks.Rows[dgv_Tasks.CurrentCell.RowIndex].Cells[columnCodeIndex].Value);

                    object sender = new object();
                    EventArgs e = new EventArgs();

                    foreach (Task_Object item in taskObject_List.Where(to => to.code.Equals(selectedLineCode)))
                    {
                        txtb_CodeTask.Text = item.code.ToString();

                        mtxtb_InitialDate.Text = DateTime.Parse(item.initial_date.ToString()).ToString("dd/MM/yyyy");
                        mtxtb_FinalDate.Text = DateTime.Parse(item.final_date.ToString()).ToString("dd/MM/yyyy");

                        if (!item.task_progress.Equals("CONCLUIDO"))
                        {
                            if (DateTime.Now.Date >= item.initial_date && DateTime.Now.Date <= item.final_date)
                            {
                                item.task_progress = "REALIZANDO";

                            }
                            else if (DateTime.Now.Date < item.initial_date)
                            {
                                item.task_progress = "ESPERANDO";
                            }
                            else if (DateTime.Now.Date > item.final_date)
                            {
                                item.task_progress = "CANCELADO";
                            }

                            txtb_TaskProgress.Text = item.task_progress;
                        }
                        else
                            txtb_TaskProgress.Text = "CONCLUIDO";

                        if (item.priority.Equals("ALTA"))
                            cb_Priority.SelectedIndex = 0;
                        else if (item.priority.Equals("BAIXA"))
                            cb_Priority.SelectedIndex = 1;
                        else
                            cb_Priority.SelectedIndex = 0;

                        txtb_Description.Text = item.description.ToString();
                        txtb_DetailsTask.Text = item.detailsTask.ToString();

                        if (firstSearch.Equals(false))
                            task_Object = item;

                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
            finally
            {
                if (loadingIsOpening)
                {
                    loadingIsOpening = false;
                    manage_LoadingScreen.CloseLoading();
                }
            }
        }

        private bool ValidatingFieldData(Task_Object validatingTask_Object)
        {
            try
            {
                bool validData = true;
                DateTime dateOutput_Initial = DateTime.Now;
                DateTime dateOutput_Final = DateTime.Now;

                if (currentOperation.Equals("ALTERACAO") || currentOperation.Equals("REMOCAO") || currentOperation.Equals("CONCLUIDO") || currentOperation.Equals("CANCELADO"))
                    validatingTask_Object.code = int.Parse(txtb_CodeTask.Text);
                else
                    validatingTask_Object.code = 0;

                if (validData)
                {
                    if (DateTime.TryParse(mtxtb_InitialDate.Text.Trim(), out dateOutput_Initial))
                    {
                        if (DateTime.TryParse(mtxtb_FinalDate.Text.Trim(), out dateOutput_Final))
                        {
                            if (dateOutput_Initial.Date >= DateTime.Now.Date && dateOutput_Initial.Date <= dateOutput_Final.Date)
                                validatingTask_Object.initial_date = dateOutput_Initial.Date;
                            else
                            {
                                manage_DefaultSystemMessages.NullOrBlank_Field("DATA INICIAL");
                                validData = false;
                            }

                            if (dateOutput_Final.Date >= DateTime.Now.Date && dateOutput_Final.Date >= dateOutput_Initial.Date)
                                validatingTask_Object.final_date = dateOutput_Final.Date;
                            else
                            {
                                manage_DefaultSystemMessages.NullOrBlank_Field("DATA FINAL");
                                validData = false;
                            }
                        }
                        else
                        {
                            manage_DefaultSystemMessages.NullOrBlank_Field("DATA FINAL");
                            validData = false;
                        }
                    }
                    else
                    {
                        manage_DefaultSystemMessages.NullOrBlank_Field("DATA INICIAL");
                        validData = false;
                    }
                }

                if (validData)
                {
                    if (currentOperation.Equals("CONCLUIDO") || currentOperation.Equals("CANCELADO"))
                    {
                        validatingTask_Object.task_progress = currentOperation;
                    }
                    else
                    {
                        //if (DateTime.TryParse(mtxtb_InitialDate.Text.Trim(), out dateOutput_Initial) && DateTime.TryParse(mtxtb_FinalDate.Text.Trim(), out dateOutput_Final))
                        //{

                        if (DateTime.Now.Date >= dateOutput_Initial.Date && DateTime.Now.Date <= dateOutput_Final.Date)
                            validatingTask_Object.task_progress = "REALIZANDO";
                        else if (DateTime.Now.Date < dateOutput_Initial.Date)
                            validatingTask_Object.task_progress = "ESPERANDO";
                        else if (DateTime.Now.Date > dateOutput_Final.Date)
                            validatingTask_Object.task_progress = "CANCELADO";
                        else
                        {
                            manage_DefaultSystemMessages.NullOrBlank_Field("PROGRESSO ATUAL");
                            validData = false;
                        }
                        //}
                    }
                }

                if (validData)
                {
                    if (cb_Priority.SelectedIndex.Equals(0))
                        validatingTask_Object.priority = "ALTA";
                    else if (cb_Priority.SelectedIndex.Equals(1))
                        validatingTask_Object.priority = "BAIXA";
                    else
                    {
                        manage_DefaultSystemMessages.NullOrBlank_Field("PRIORIDADE");
                        validData = false;
                    }
                }

                if (validData)
                {
                    if (txtb_Description.Text.Trim().Equals(""))
                    {
                        manage_DefaultSystemMessages.NullOrBlank_Field("DESCRIÇÃO");
                        validData = false;
                    }
                    else
                    {
                        validatingTask_Object.description = txtb_Description.Text;
                    }
                }

                validatingTask_Object.detailsTask = txtb_DetailsTask.Text;

                return validData;
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
                return false;
            }
        }

        #endregion

        #region KeyPress Events

        private void mtxtb_InitialDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                shared_FormFunctions.Enter_FocusMaskedTextBox(mtxtb_FinalDate, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void mtxtb_FinalDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                shared_FormFunctions.Enter_FocusTextBox(txtb_Description, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void txtb_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                shared_FormFunctions.Enter_FocusTextBox(txtb_DetailsTask, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void txtb_DetailsTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (shared_FormFunctions.Enter_FocusButton(btn_Confirmed_Data, e))
                    btn_Confirmed_Data_Click(sender, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        #endregion

        #region Button Click Events

        private void btn_CreateTask_Click(object sender, EventArgs e)
        {
            try
            {
                shared_FormFunctions.ModificationModeForm(gb_MainList, gb_GeneralData, tbc_First, tbc_Second, btn_CreateTask, btn_AlterTask,
                    btn_DeleteTask, btn_CompleteTask, btn_Canceled_Data, btn_BackGrid, btn_SearchTask, btn_ForwardGrid);

                currentOperation = "CADASTRO";
                CleanRegistrationFields();

                mtxtb_InitialDate.Focus();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_AlterTask_Click(object sender, EventArgs e)
        {
            try
            {
                shared_FormFunctions.ModificationModeForm(gb_MainList, gb_GeneralData, tbc_First, tbc_Second, btn_CreateTask, btn_AlterTask,
                    btn_DeleteTask, btn_CompleteTask, btn_Canceled_Data, btn_BackGrid, btn_SearchTask, btn_ForwardGrid);

                currentOperation = "ALTERACAO";

                mtxtb_InitialDate.Focus();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                currentOperation = "REMOCAO";
                btn_Confirmed_Data_Click(sender, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_CompleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                currentOperation = "CONCLUIDO";
                btn_Confirmed_Data_Click(sender, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_CancelTask_Click(object sender, EventArgs e)
        {
            try
            {
                currentOperation = "CANCELADO";
                btn_Confirmed_Data_Click(sender, e);
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_BackGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Tasks.CurrentRow.Index > 0)
                {
                    int linha = shared_FormFunctions.ChangeRow_DGV(dgv_Tasks, false);

                    dgv_Tasks.CurrentCell = dgv_Tasks.Rows[linha].Cells[dgv_Tasks.CurrentCell.ColumnIndex];
                    FillFields();
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_ForwardGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Tasks.CurrentRow.Index < (dgv_Tasks.RowCount - 1))
                {
                    int linha = shared_FormFunctions.ChangeRow_DGV(dgv_Tasks, true);

                    dgv_Tasks.CurrentCell = dgv_Tasks.Rows[linha].Cells[dgv_Tasks.CurrentCell.ColumnIndex];
                    FillFields();
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }
        
        private void btn_Confirmed_Data_Click(object sender, EventArgs e)
        {
            try
            {
                if (manage_DefaultSystemMessages.Confirmation_Message(currentOperation).Equals(DialogResult.OK))
                {
                    Task_Object validatingTask_Object = new Task_Object();

                    string CurrentStatus = "EM ANDAMENTO";
                    
                    if (ValidatingFieldData(validatingTask_Object))
                    {
                        if (currentOperation.Equals("CADASTRO") || currentOperation.Equals("ALTERACAO") || currentOperation.Equals("REMOCAO") || currentOperation.Equals("CONCLUIDO")
                            || currentOperation.Equals("CANCELADO"))
                        {
                            CurrentStatus = task_Process.ManageField(validatingTask_Object, currentOperation);
                        }
                        else
                        {
                            manage_DefaultSystemMessages.DataBaseException("A operação informada não existe !");
                            return;
                        }
                        
                        int returnedCode = 0;
                        if (int.TryParse(CurrentStatus, out returnedCode))
                        {
                            task_Object = validatingTask_Object;
                            task_Object.code = returnedCode;

                            firstSearch = true;

                            if (buttomSearchImage.Equals("CANCEL SEARCH"))
                                btn_SearchTask_Click(sender, e);
                            else
                                Get_DGVList();

                            shared_FormFunctions.QueryModeForm(gb_MainList, gb_GeneralData, dgv_Tasks, btn_CreateTask, btn_AlterTask, btn_DeleteTask,
                                btn_CompleteTask, btn_Canceled_Data, btn_BackGrid, btn_SearchTask, btn_ForwardGrid);

                            if (btn_CloseCalender_InitialDate.Visible.Equals(true))
                                btn_CloseCalender_InitialDate_Click(sender, e);
                            if (btn_CloseCalender_FinalDate.Visible.Equals(true))
                                btn_CloseCalender_FinalDate_Click(sender, e);

                            currentOperation = "";
                        }
                        else
                        {
                            manage_DefaultSystemMessages.DataBaseException(CurrentStatus);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_Canceled_Data_Click(object sender, EventArgs e)
        {
            try
            {
                if (manage_DefaultSystemMessages.Cancellation_Message().Equals(DialogResult.OK))
                {
                    shared_FormFunctions.QueryModeForm(gb_MainList, gb_GeneralData, dgv_Tasks, btn_CreateTask, btn_AlterTask, btn_DeleteTask,
                                btn_CompleteTask, btn_Canceled_Data, btn_BackGrid, btn_SearchTask, btn_ForwardGrid);

                    if (buttomSearchImage.Equals("CANCEL SEARCH"))
                        btn_SearchTask_Click(sender, e);
                    else
                        Get_DGVList();

                    if (btn_CloseCalender_InitialDate.Visible.Equals(true))
                        btn_CloseCalender_InitialDate_Click(sender, e);
                    if (btn_CloseCalender_FinalDate.Visible.Equals(true))
                        btn_CloseCalender_FinalDate_Click(sender, e);

                    currentOperation = "";
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        #endregion

        #region Button Search Events

        private void btn_SearchTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttomSearchImage.Equals("SEARCH"))
                {
                    form_SearchingTask = new Form_SearchingTask();
                    form_SearchingTask.ShowDialog();

                    if (!form_SearchingTask.searchField.Equals("CANCELED") && !form_SearchingTask.retornedInfo.Equals("EMPTY"))
                    {
                        searchList = new TaskObject_List();

                        if (form_SearchingTask.searchField.Equals("CODE"))
                        {
                            searchList = taskObject_List.Where(to => to.code.Equals(int.Parse(form_SearchingTask.retornedInfo))).ToList();
                        }
                        else if (form_SearchingTask.searchField.Equals("DATES") && !form_SearchingTask.retornedInfo_2.Equals("EMPTY"))
                        {
                            searchList = searchList.Where(to => DateTime.Parse(to.initial_date.ToString()).Date >= DateTime.Parse(form_SearchingTask.retornedInfo).Date
                            && DateTime.Parse(to.final_date.ToString()).Date <= DateTime.Parse(form_SearchingTask.retornedInfo_2).Date).ToList();
                        }
                        else if (form_SearchingTask.searchField.Equals("TASK PROGRESS"))
                        {
                            searchList = taskObject_List.Where(to => to.task_progress.Contains(form_SearchingTask.retornedInfo)).ToList(); // ESPERANDO, REALIZANDO, CONCLUIDO ou CANCELADO. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
                        }
                        else if (form_SearchingTask.searchField.Equals("PRIORITY"))
                        {
                            searchList = taskObject_List.Where(to => to.priority.Equals(form_SearchingTask.retornedInfo)).ToList(); //ALTA ou BAIXA
                        }
                        else if (form_SearchingTask.searchField.Equals("DESCRIPTION"))
                        {
                            searchList = taskObject_List.Where(to => to.description.Contains(form_SearchingTask.retornedInfo)).ToList();
                        }
                        else
                        {
                            manage_DefaultSystemMessages.SearchedInformationNotFound_Message();
                            return;
                        }

                        if (searchList.Count() > 0)
                        {
                            dgv_Tasks.Rows.Clear();

                            foreach (Task_Object item in searchList)
                            {
                                AddDGVLine(item);
                            }

                            dgv_Tasks.Rows[0].Selected = true;
                            FillFields();
                        }
                        else
                        {
                            manage_DefaultSystemMessages.SearchedInformationNotFound_Message();
                            return;
                        }

                        btn_SearchTask.Image = Resources.Delete;
                        btn_SearchTask.Text = " CANCELAR PESQUISA";
                        buttomSearchImage = "CANCEL SEARCH";
                    }
                }
                else
                {
                    Get_DGVList();

                    btn_SearchTask.Image = Resources.Find;
                    btn_SearchTask.Text = "      PESQUISAR";
                    buttomSearchImage = "SEARCH";

                    currentOperation = "";
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }
        
        private void btn_OpenCalender_InitialDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_Calender_InitialDate.Visible.Equals(false))
                {
                    DateTime dateVariable = DateTime.Today.Date;
                    if (DateTime.TryParse(mtxtb_InitialDate.Text.Trim(), out dateVariable))
                    {
                        if (dateVariable.Date >= DateTime.Today)
                            mc_Calender_InitialDate.SetDate(dateVariable);
                    }

                    mc_Calender_InitialDate.MinDate = DateTime.Today.Date;
                    mc_Calender_InitialDate.Visible = true;
                    mc_Calender_InitialDate.Focus();

                    btn_OpenCalender_InitialDate.Visible = false;
                    btn_CloseCalender_InitialDate.Visible = true;
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_CloseCalender_InitialDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_CloseCalender_InitialDate.Visible.Equals(true) && mc_Calender_InitialDate.Visible.Equals(true))
                {
                    mtxtb_InitialDate.Focus();
                    btn_CloseCalender_InitialDate.Visible = false;
                    mc_Calender_InitialDate.Visible = false;

                    btn_OpenCalender_InitialDate.Visible = true;
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void mc_Calender_InitialDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (mc_Calender_InitialDate.Visible.Equals(true))
                {
                    mtxtb_InitialDate.Text = mc_Calender_InitialDate.SelectionStart.ToShortDateString();
                    btn_CloseCalender_InitialDate_Click(sender, e);
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_OpenCalender_FinalDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_Calender_FinalDate.Visible.Equals(false))
                {
                    DateTime dateVariable = DateTime.Today.Date;
                    if (DateTime.TryParse(mtxtb_FinalDate.Text.Trim(), out dateVariable))
                    {
                        if (dateVariable.Date >= DateTime.Today)
                            mc_Calender_FinalDate.SetDate(dateVariable);
                    }

                    mc_Calender_FinalDate.MinDate = DateTime.Today.Date;
                    mc_Calender_FinalDate.Visible = true;
                    mc_Calender_FinalDate.Focus();

                    btn_OpenCalender_FinalDate.Visible = false;
                    btn_CloseCalender_FinalDate.Visible = true;
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void btn_CloseCalender_FinalDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_CloseCalender_FinalDate.Visible.Equals(true) && mc_Calender_FinalDate.Visible.Equals(true))
                {
                    mtxtb_FinalDate.Focus();
                    btn_CloseCalender_FinalDate.Visible = false;
                    mc_Calender_FinalDate.Visible = false;

                    btn_OpenCalender_FinalDate.Visible = true;
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void mc_Calender_FinalDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (mc_Calender_FinalDate.Visible.Equals(true))
                {
                    mtxtb_FinalDate.Text = mc_Calender_FinalDate.SelectionStart.ToShortDateString();
                    btn_CloseCalender_FinalDate_Click(sender, e);
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        #endregion

        #region DataGridView Events

        private void dgv_Tasks_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.Equals(((int)Keys.Up)) || e.KeyValue.Equals(((int)Keys.Down)))
                    FillFields();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void dgv_Tasks_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var clickedLine = dgv_Tasks.HitTest(e.X, e.Y);
                if (clickedLine != null && clickedLine.RowIndex >= 0)
                    FillFields();
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void dgv_Tasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var clickedLine = dgv_Tasks.HitTest(e.X, e.Y);
                if (clickedLine != null && clickedLine.RowIndex >= 0)
                {
                    if (e.Button.Equals(MouseButtons.Left))
                        tbc_First.SelectedIndex = 1;
                }
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        private void dgv_Tasks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (checkLineProgress.task_progress.Equals("CONCLUIDO"))
                    dgv_Tasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                else if (checkLineProgress.task_progress.Equals("CANCELADO"))
                    dgv_Tasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.RosyBrown;
                else if (checkLineProgress.task_progress.Equals("REALIZANDO"))
                    dgv_Tasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
                else if (checkLineProgress.task_progress.Equals("ESPERANDO"))
                    dgv_Tasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }
            catch (Exception exception)
            {
                manage_DefaultSystemMessages.ExceptionMessage(exception);
            }
        }

        #endregion

    }
}
