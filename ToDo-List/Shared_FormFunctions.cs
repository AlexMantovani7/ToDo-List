using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo_List.Properties;

namespace ToDo_List
{
    public class Shared_FormFunctions
    {
        
        #region Manage DataGridView

        public int ChangeRow_DGV(DataGridView dgv_Tasks, bool nextRow)
        {
            try
            {
                int row = 0;
                if (nextRow)
                    row = dgv_Tasks.CurrentRow.Index + 1;
                else
                    row = dgv_Tasks.CurrentRow.Index - 1;

                return row;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Manage Fields

        public bool Enter_FocusButton(Button focusButton, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.Equals((char)Keys.Enter))
                {
                    focusButton.Focus();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Enter_FocusTextBox(TextBox txtbFocus, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.Equals((char)Keys.Enter))
                {
                    txtbFocus.Focus();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Enter_FocusMaskedTextBox(MaskedTextBox maskedTextBoxFocus, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.Equals((char)Keys.Enter))
                {
                    maskedTextBoxFocus.Focus();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Axes_Calendar(Button calendarButton, MonthCalendar monthCalendar)
        {
            try
            {
                int X_Axis = (calendarButton.Location.X + calendarButton.Size.Width) - 4;
                int Y_Axis = (calendarButton.Location.Y + calendarButton.Size.Height) - 4;

                monthCalendar.Location = new Point(X_Axis, Y_Axis);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region General Form Management

        public void ModificationModeForm(GroupBox gb_MainList, GroupBox gb_GeneralData, TabControl tbc_First, TabControl tbc_Second, Button btn_CreateTask, Button btn_AlterTask,
            Button btn_DeleteTask, Button btn_CompleteTask, Button btn_Canceled_Data, Button btn_BackGrid, Button btn_SearchTask, Button btn_ForwardGrid)
        {
            try
            {
                int index_PaginaPrincipal = 1;
                int index_PaginaSecundario = 0;

                gb_MainList.Enabled = false;
                gb_GeneralData.Enabled = true;

                tbc_First.SelectTab(index_PaginaPrincipal);
                tbc_Second.SelectTab(index_PaginaSecundario);

                btn_CreateTask.Enabled = false;
                btn_AlterTask.Enabled = false;
                btn_DeleteTask.Enabled = false;
                btn_CompleteTask.Enabled = false;
                btn_Canceled_Data.Enabled = false;
                btn_BackGrid.Enabled = false;
                btn_SearchTask.Enabled = false;
                btn_ForwardGrid.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void QueryModeForm(GroupBox gb_MainList, GroupBox gb_GeneralData, DataGridView dgv_Tasks,
            Button btn_CreateTask, Button btn_AlterTask, Button btn_DeleteTask, Button btn_CompleteTask, Button btn_Canceled_Data, Button btn_BackGrid, Button btn_SearchTask, Button btn_ForwardGrid)
        {
            try
            {
                gb_MainList.Enabled = true;
                gb_GeneralData.Enabled = false;

                btn_CreateTask.Enabled = true;
                btn_AlterTask.Enabled = true;
                btn_DeleteTask.Enabled = true;
                btn_CompleteTask.Enabled = true;
                btn_Canceled_Data.Enabled = true;
                btn_BackGrid.Enabled = true;
                btn_SearchTask.Enabled = true;
                btn_ForwardGrid.Enabled = true;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ManageMainButtons(bool turnOn_Off, Button btn_AlterTask, Button btn_DeleteTask, Button btn_CompleteTask, Button btn_CancelTask, Button btn_BackGrid,
            Button btn_SearchTask, Button btn_ForwardGrid)
        {
            try
            {
                btn_AlterTask.Enabled = turnOn_Off;
                btn_DeleteTask.Enabled = turnOn_Off;
                btn_CompleteTask.Enabled = turnOn_Off;
                btn_CancelTask.Enabled = turnOn_Off;
                btn_BackGrid.Enabled = turnOn_Off;
                btn_SearchTask.Enabled = turnOn_Off;
                btn_ForwardGrid.Enabled = turnOn_Off;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

    }
}
