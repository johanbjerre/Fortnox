namespace Fortnox.TestApp
{
    partial class Form1
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
            this.getAllArticlesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.articleNumberBox = new System.Windows.Forms.RichTextBox();
            this.GetArticle = new System.Windows.Forms.Button();
            this.appVeyor = new System.Windows.Forms.Button();
            this.getAllAccounts = new System.Windows.Forms.Button();
            this.getAccount = new System.Windows.Forms.Button();
            this.accountNumberBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getAllArticlesButton
            // 
            this.getAllArticlesButton.Location = new System.Drawing.Point(12, 12);
            this.getAllArticlesButton.Name = "getAllArticlesButton";
            this.getAllArticlesButton.Size = new System.Drawing.Size(117, 23);
            this.getAllArticlesButton.TabIndex = 0;
            this.getAllArticlesButton.Text = "GetAllArticles";
            this.getAllArticlesButton.UseVisualStyleBackColor = true;
            this.getAllArticlesButton.Click += new System.EventHandler(this.getAllArticlesButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // articleNumberBox
            // 
            this.articleNumberBox.Location = new System.Drawing.Point(135, 41);
            this.articleNumberBox.Name = "articleNumberBox";
            this.articleNumberBox.Size = new System.Drawing.Size(82, 23);
            this.articleNumberBox.TabIndex = 2;
            this.articleNumberBox.Text = "1";
            this.articleNumberBox.TextChanged += new System.EventHandler(this.articleNumberBox_TextChanged);
            // 
            // GetArticle
            // 
            this.GetArticle.Location = new System.Drawing.Point(12, 41);
            this.GetArticle.Name = "GetArticle";
            this.GetArticle.Size = new System.Drawing.Size(117, 23);
            this.GetArticle.TabIndex = 3;
            this.GetArticle.Text = "GetArticle";
            this.GetArticle.UseVisualStyleBackColor = true;
            this.GetArticle.Click += new System.EventHandler(this.GetArticle_Click);
            // 
            // appVeyor
            // 
            this.appVeyor.Location = new System.Drawing.Point(441, 12);
            this.appVeyor.Name = "appVeyor";
            this.appVeyor.Size = new System.Drawing.Size(116, 23);
            this.appVeyor.TabIndex = 4;
            this.appVeyor.Text = "AppVeyor";
            this.appVeyor.UseVisualStyleBackColor = true;
            this.appVeyor.Click += new System.EventHandler(this.appVeyor_Click);
            // 
            // getAllAccounts
            // 
            this.getAllAccounts.Location = new System.Drawing.Point(12, 84);
            this.getAllAccounts.Name = "getAllAccounts";
            this.getAllAccounts.Size = new System.Drawing.Size(117, 23);
            this.getAllAccounts.TabIndex = 5;
            this.getAllAccounts.Text = "GetAllAccounts";
            this.getAllAccounts.UseVisualStyleBackColor = true;
            this.getAllAccounts.Click += new System.EventHandler(this.getAllAccounts_Click);
            // 
            // getAccount
            // 
            this.getAccount.Location = new System.Drawing.Point(13, 114);
            this.getAccount.Name = "getAccount";
            this.getAccount.Size = new System.Drawing.Size(116, 23);
            this.getAccount.TabIndex = 6;
            this.getAccount.Text = "GetAccount";
            this.getAccount.UseVisualStyleBackColor = true;
            this.getAccount.Click += new System.EventHandler(this.getAccount_Click);
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(136, 114);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(81, 23);
            this.accountNumberBox.TabIndex = 7;
            this.accountNumberBox.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 425);
            this.Controls.Add(this.accountNumberBox);
            this.Controls.Add(this.getAccount);
            this.Controls.Add(this.getAllAccounts);
            this.Controls.Add(this.appVeyor);
            this.Controls.Add(this.GetArticle);
            this.Controls.Add(this.articleNumberBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getAllArticlesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getAllArticlesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox articleNumberBox;
        private System.Windows.Forms.Button GetArticle;
        private System.Windows.Forms.Button appVeyor;
        private System.Windows.Forms.Button getAllAccounts;
        private System.Windows.Forms.Button getAccount;
        private System.Windows.Forms.RichTextBox accountNumberBox;
    }
}

