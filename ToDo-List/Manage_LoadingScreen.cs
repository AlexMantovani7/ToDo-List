using System;
using System.Threading;
using System.Windows.Forms;

namespace ToDo_List
{
    public class Manage_LoadingScreen
    {
        private Form_Loading form_Loading;
        private Thread loadingThread;

        public void OpenLoading(Form currentForm, Form_Loading form_LS, Thread thread)
        {
            try
            {
                form_Loading = form_LS;
                loadingThread = thread;

                loadingThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
                loadingThread.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadingProcess(object form)
        {
            try
            {
                Form newForm = form as Form;

                form_Loading = new Form_Loading(newForm);
                form_Loading.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CloseLoading()
        {
            try
            {
                Thread.Sleep(50);
                form_Loading.BeginInvoke(new ThreadStart(form_Loading.CloseLoading));
                form_Loading = null;
                loadingThread = null;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
