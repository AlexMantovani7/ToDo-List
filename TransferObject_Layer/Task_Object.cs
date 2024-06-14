using System;
using System.Collections.Generic;

namespace TransferObject_Layer
{
    public class Task_Object
    {
        public Nullable<int> code { get; set; }
        public string priority { get; set; } // Alta ou Baixa
        public string description { get; set; }
        public string detailsTask { get; set; }
        public Nullable<DateTime> initial_date { get; set; }
        public Nullable<DateTime> final_date { get; set; }
        public string task_progress { get; set; } // ESPERANDO, REALIZANDO, CONCLUIDO ou CANCELADO. (Obs: pode haver um Removido, para não deletar por definitivo a Task).
    }

    public class TaskObject_List : List<Task_Object> { }
}
