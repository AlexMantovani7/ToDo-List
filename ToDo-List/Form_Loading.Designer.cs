namespace ToDo_List
{
    partial class Form_Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Loading = new System.Windows.Forms.Label();
            this.lb_LoadingGif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Loading
            // 
            this.lb_Loading.AutoSize = true;
            this.lb_Loading.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Loading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Loading.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loading.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Loading.Location = new System.Drawing.Point(225, 84);
            this.lb_Loading.Name = "lb_Loading";
            this.lb_Loading.Size = new System.Drawing.Size(209, 38);
            this.lb_Loading.TabIndex = 3;
            this.lb_Loading.Text = "CARREGANDO. . .";
            // 
            // lb_LoadingGif
            // 
            this.lb_LoadingGif.BackColor = System.Drawing.Color.Transparent;
            this.lb_LoadingGif.Image = global::ToDo_List.Properties.Resources.Loading_GIF_3;
            this.lb_LoadingGif.Location = new System.Drawing.Point(-10, 0);
            this.lb_LoadingGif.Name = "lb_LoadingGif";
            this.lb_LoadingGif.Size = new System.Drawing.Size(262, 206);
            this.lb_LoadingGif.TabIndex = 4;
            // 
            // Form_Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 207);
            this.Controls.Add(this.lb_Loading);
            this.Controls.Add(this.lb_LoadingGif);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Loading";
            this.Text = "Form_Loading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Loading;
        private System.Windows.Forms.Label lb_LoadingGif;
    }
}