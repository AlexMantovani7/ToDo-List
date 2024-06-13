using System;
using DataAccess_Layer;
using TransferObject_Layer;
using System.Data;

namespace Processing_Layer
{
    public class Task_Process
    {
        private DataBase_Control acessoDados = new DataBase_Control();

        public string ManageField(Task_Object task_Object, string operation)
        {
            try
            {
                acessoDados.CleanParameter();

                acessoDados.AddParameter("@var_operation", operation);

                acessoDados.AddParameter("@var_code", task_Object.code);
                acessoDados.AddParameter("@var_priority", task_Object.priority);
                acessoDados.AddParameter("@var_description", task_Object.description);
                acessoDados.AddParameter("@var_initial_date", task_Object.initial_date);
                acessoDados.AddParameter("@var_final_date", task_Object.final_date);
                acessoDados.AddParameter("@var_task_progress", task_Object.task_progress);

                return acessoDados.RunScalar("sp_ManageField",
                    CommandType.StoredProcedure).ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TaskObject_List ConsultField(Task_Object task_Object, bool searchAll)
        {
            try
            {
                acessoDados.CleanParameter();

                acessoDados.AddParameter("@var_searchAll", searchAll);

                acessoDados.AddParameter("@var_code", task_Object.code);
                acessoDados.AddParameter("@var_priority", task_Object.priority);
                acessoDados.AddParameter("@var_description", task_Object.description);
                acessoDados.AddParameter("@var_initial_date", task_Object.initial_date);
                acessoDados.AddParameter("@var_final_date", task_Object.final_date);
                acessoDados.AddParameter("@var_task_progress", task_Object.task_progress);

                DataTable dataTable = acessoDados.GetDataTable("sp_ConsultTask",
                    CommandType.StoredProcedure);

                TaskObject_List taskObject_List = new TaskObject_List();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    task_Object = new Task_Object()
                    {
                        code = Convert.ToInt32(dataRow["code"]),
                        priority = dataRow["priority"].ToString(),
                        description = dataRow["description"].ToString(),
                        initial_date = Convert.ToDateTime(dataRow["initial_date"]),
                        final_date = Convert.ToDateTime(dataRow["final_date"]),
                        task_progress = dataRow["task_progress"].ToString()
                    };

                    taskObject_List.Add(task_Object);
                }

                return taskObject_List;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}