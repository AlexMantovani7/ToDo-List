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
    public partial class Form_TodoList : Form
    {
        public Form_TodoList()
        {
            InitializeComponent();
        }

        private void Form_TodoList_Load(object sender, EventArgs e)
        {
            cb_Priority.SelectedIndex = 0;
        }
    }
}
