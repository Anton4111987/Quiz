namespace Quiz_Exam
{
    partial class PlayMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMenuForm));
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.buttonViewQuiz = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Location = new System.Drawing.Point(387, 93);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(326, 47);
            this.buttonStartQuiz.TabIndex = 0;
            this.buttonStartQuiz.Text = "Стартовать новую викторину";
            this.buttonStartQuiz.UseVisualStyleBackColor = true;
            // 
            // buttonViewQuiz
            // 
            this.buttonViewQuiz.Location = new System.Drawing.Point(387, 161);
            this.buttonViewQuiz.Name = "buttonViewQuiz";
            this.buttonViewQuiz.Size = new System.Drawing.Size(326, 47);
            this.buttonViewQuiz.TabIndex = 1;
            this.buttonViewQuiz.Text = "Просмотр прошлых викторин";
            this.buttonViewQuiz.UseVisualStyleBackColor = true;
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(387, 364);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(326, 48);
            this.buttonTop.TabIndex = 2;
            this.buttonTop.Text = "Просмотреть топ-20 ";
            this.buttonTop.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditUser.Location = new System.Drawing.Point(387, 418);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(326, 48);
            this.buttonEditUser.TabIndex = 3;
            this.buttonEditUser.Text = "Изменить данные пользователя";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(882, 671);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // PlayMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 769);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonEditUser);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonViewQuiz);
            this.Controls.Add(this.buttonStartQuiz);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PlayMenuForm";
            this.Text = "PlayMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.Button buttonViewQuiz;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button button5;
    }
}