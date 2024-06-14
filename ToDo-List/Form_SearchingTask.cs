using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class Form_SearchingTask : Form
    {
        #region Variables

        public string searchField;
        public string retornedInfo;
        public string retornedInfo_2;

        private Manage_DefaultSystemMessages manage_DefaultSystemMessages;
        private Shared_FormFunctions shared_FormFunctions;

        #endregion

        public Form_SearchingTask()
        {
            try
            {
                InitializeComponent();

                searchField = "CANCELED";
                retornedInfo = "EMPTY";
                retornedInfo_2 = "EMPTY";

                manage_DefaultSystemMessages = new Manage_DefaultSystemMessages();
                shared_FormFunctions = new Shared_FormFunctions();

                this.StartPosition = FormStartPosition.Manual;
                this.StartPosition = FormStartPosition.CenterParent;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region Form Events

        private void Form_SearchingTask_Load(object sender, EventArgs e)
        {
            try
            {
                cb_TaskProgress.SelectedIndex = 0;
                cb_Priority.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Button Click Events

        private void btn_SearchingCode_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                if (int.TryParse(txtb_Code.Text.Trim(), out result) && !txtb_Code.Text.Trim().Equals(""))
                {
                    if (result > 0)
                    {
                        searchField = "CODE";
                        retornedInfo = result.ToString();

                        this.Close();
                    }
                    else
                        manage_DefaultSystemMessages.CurrencyField_ZeroOrInvalid("CÓDIGO");
                }
                else
                    manage_DefaultSystemMessages.NullOrBlank_Field("CÓDIGO");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_SearchingDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime initialResult;
                DateTime finalResult;
                if (DateTime.TryParse(mtxtb_IniticalDate.Text.Trim(), out initialResult) && !mtxtb_IniticalDate.Text.Trim().Equals("")
                    && DateTime.TryParse(mtxtb_FinalDate.Text.Trim(), out finalResult) && !mtxtb_FinalDate.Text.Trim().Equals(""))
                {
                    if (initialResult.Date <= finalResult.Date)
                    {
                        searchField = "DATES";
                        retornedInfo = initialResult.ToString();
                        retornedInfo_2 = finalResult.ToString();

                        this.Close();
                    }
                    else
                        manage_DefaultSystemMessages.DoubleDateField_NullBlankDated("DATAS (INICIAL) E (FINAL)");
                }
                else
                    manage_DefaultSystemMessages.NullOrBlank_Field("DATAS (INICIAL) E (FINAL)");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_SearchingTaskProgress_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_TaskProgress.SelectedIndex >= 0 && cb_TaskProgress.SelectedIndex <= 3)
                {
                    if (cb_TaskProgress.SelectedIndex.Equals(0))
                        retornedInfo = "ESPERANDO";
                    else if (cb_TaskProgress.SelectedIndex.Equals(1))
                        retornedInfo = "REALIZANDO";
                    else if (cb_TaskProgress.SelectedIndex.Equals(2))
                        retornedInfo = "CONCLUIDO";
                    else if (cb_TaskProgress.SelectedIndex.Equals(3))
                        retornedInfo = "CANCELADO";
                    else
                    {
                        manage_DefaultSystemMessages.CurrencyField_ZeroOrInvalid("PROGRESSO DA TAREFA");
                        return;
                    }

                    searchField = "TASK PROGRESS";

                    this.Close();
                }
                else
                    manage_DefaultSystemMessages.CurrencyField_ZeroOrInvalid("PROGRESSO DA TAREFA");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_SearchingPriority_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Priority.SelectedIndex.Equals(0) || cb_Priority.SelectedIndex.Equals(1))
                {
                    if (cb_Priority.SelectedIndex.Equals(0))
                        retornedInfo = "ALTA";
                    else if (cb_Priority.SelectedIndex.Equals(1))
                        retornedInfo = "BAIXA";
                    else
                    {
                        manage_DefaultSystemMessages.CurrencyField_ZeroOrInvalid("PRIORIDADE");
                        return;
                    }

                    searchField = "PRIORITY";

                    this.Close();
                }
                else
                    manage_DefaultSystemMessages.CurrencyField_ZeroOrInvalid("PRIORIDADE");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_SearchingDescription_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtb_Description.Text.Trim().Equals(""))
                {
                    searchField = "DESCRIPTION";
                    retornedInfo = txtb_Description.Text.ToString();

                    this.Close();
                }
                else
                    manage_DefaultSystemMessages.NullOrBlank_Field("DESCRIÇÃO");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region KeyPress Events

        private void txtb_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (shared_FormFunctions.Enter_FocusButton(btn_SearchingCode, e))
                    btn_SearchingCode_Click(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtxtb_IniticalDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                shared_FormFunctions.Enter_FocusMaskedTextBox(mtxtb_FinalDate, e);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void mtxtb_FinalDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (shared_FormFunctions.Enter_FocusButton(btn_SearchingDate, e))
                btn_SearchingDate_Click(sender, e);
        }

        private void txtb_Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (shared_FormFunctions.Enter_FocusButton(btn_SearchingDescription, e))
                btn_SearchingDescription_Click(sender, e);
        }

        #endregion

        #region Calender Events

        private void FormCalender_Mode(bool turnOn)
        {
            try
            {
                if (turnOn)
                    this.Size = new Size(this.Width, 285);
                else
                    this.Size = new Size(this.Width, 147);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GerenciaAtivacaoButtonsFechar_Calendario(string buttonName)
        {
            try
            {
                if (buttonName.Equals("INITIAL DATE"))
                {
                    btn_OpenCalender_InitialDate.Visible = false;
                    btn_CloseCalender_InitialDate.Visible = true;
                }
                else
                {
                    btn_OpenCalender_InitialDate.Visible = true;
                    btn_CloseCalender_InitialDate.Visible = false;
                }

                if (buttonName.Equals("FINAL DATE"))
                {
                    btn_OpenCalender_FinalDate.Visible = false;
                    btn_CloseCalender_FinalDate.Visible = true;
                }
                else
                {
                    btn_OpenCalender_FinalDate.Visible = true;
                    btn_CloseCalender_FinalDate.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void tc_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (mc_Calender.Visible.Equals(true))
                {
                    mc_Calender.Visible = false;
                    GerenciaAtivacaoButtonsFechar_Calendario("EMPTY");
                    FormCalender_Mode(false);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_OpenCalender_InitialDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_Calender.Visible.Equals(false))
                    mc_Calender.Visible = true;

                shared_FormFunctions.Axes_Calendar(btn_OpenCalender_InitialDate, mc_Calender);
                FormCalender_Mode(true);
                GerenciaAtivacaoButtonsFechar_Calendario("INITIAL DATE");

                DateTime varDate = DateTime.Today.Date;
                if (DateTime.TryParse(mtxtb_IniticalDate.Text.Trim(), out varDate))
                    mc_Calender.SetDate(varDate);
                else
                    mc_Calender.SetDate(DateTime.Today);

                mc_Calender.MinDate = DateTime.Parse("01/01/1753");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_CloseCalender_InitialDate_Click(object sender, EventArgs e)
        {
            try
            {
                tc_Search_SelectedIndexChanged(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_OpenCalender_FinalDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_Calender.Visible.Equals(false))
                    mc_Calender.Visible = true;

                shared_FormFunctions.Axes_Calendar(btn_OpenCalender_FinalDate, mc_Calender);
                FormCalender_Mode(true);
                GerenciaAtivacaoButtonsFechar_Calendario("FINAL DATE");

                DateTime varDate = DateTime.Today.Date;
                if (DateTime.TryParse(mtxtb_FinalDate.Text.Trim(), out varDate))
                    mc_Calender.SetDate(varDate);
                else
                    mc_Calender.SetDate(DateTime.Today);

                mc_Calender.MinDate = DateTime.Parse("01/01/1753");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_CloseCalender_FinalDate_Click(object sender, EventArgs e)
        {
            try
            {
                tc_Search_SelectedIndexChanged(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void mc_Calender_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                if (btn_CloseCalender_InitialDate.Visible.Equals(true))
                {
                    mtxtb_IniticalDate.Text = mc_Calender.SelectionStart.ToShortDateString();
                    btn_CloseCalender_InitialDate_Click(sender, e);
                }
                else if (btn_CloseCalender_FinalDate.Visible.Equals(true))
                {
                    mtxtb_FinalDate.Text = mc_Calender.SelectionStart.ToShortDateString();
                    btn_CloseCalender_FinalDate_Click(sender, e);
                }
                else
                    mc_Calender.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
