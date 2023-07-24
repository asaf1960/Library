namespace Library
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            title = new Label();
            label2 = new Label();
            Librarian = new Button();
            User = new Button();
            SuspendLayout();
            // 
            // title
            // 
            resources.ApplyResources(title, "title");
            title.BackColor = Color.Transparent;
            title.ForeColor = Color.Blue;
            title.Name = "title";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Cyan;
            label2.Name = "label2";
            // 
            // Librarian
            // 
            Librarian.BackColor = Color.FromArgb(255, 128, 128);
            resources.ApplyResources(Librarian, "Librarian");
            Librarian.Name = "Librarian";
            Librarian.UseVisualStyleBackColor = false;
            Librarian.Click += Librarian_Click;
            // 
            // User
            // 
            User.BackColor = Color.FromArgb(255, 128, 128);
            resources.ApplyResources(User, "User");
            User.Name = "User";
            User.UseVisualStyleBackColor = false;
            User.Click += User_Click;
            // 
            // UI
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(User);
            Controls.Add(Librarian);
            Controls.Add(label2);
            Controls.Add(title);
            MaximizeBox = false;
            Name = "UI";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label label2;
        private Button Librarian;
        private Button User;
    }
}