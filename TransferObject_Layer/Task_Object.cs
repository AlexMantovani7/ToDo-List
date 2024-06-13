using System;
using System.Collections.Generic;

namespace TransferObject_Layer
{
    public class Task_Object
    {
        public Nullable<int> code { get; set; }
        public string priority { get; set; }
        public string description { get; set; }
        public Nullable<DateTime> initial_date { get; set; }
        public Nullable<DateTime> final_date { get; set; }
        public string task_progress { get; set; }
    }

    public class TaskObject_List : List<Task_Object> { }
}
