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
    public partial class Form_Loading : Form
    {
        public Form_Loading()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
        }

        public Form_Loading(Form form)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void CloseLoading()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

            if (lb_LoadingGif.Image != null)
                lb_LoadingGif.Image.Dispose();
        }

    }
}
