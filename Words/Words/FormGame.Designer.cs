namespace Words
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonDifficulty = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.textBoxRule = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(157, 197);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(175, 68);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Играть";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonDifficulty
            // 
            this.buttonDifficulty.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDifficulty.Location = new System.Drawing.Point(157, 281);
            this.buttonDifficulty.Name = "buttonDifficulty";
            this.buttonDifficulty.Size = new System.Drawing.Size(175, 61);
            this.buttonDifficulty.TabIndex = 1;
            this.buttonDifficulty.Text = "Средняя";
            this.buttonDifficulty.UseVisualStyleBackColor = true;
            this.buttonDifficulty.Click += new System.EventHandler(this.buttonDifficulty_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(111, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(272, 112);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "5 Слов";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDifficulty.Location = new System.Drawing.Point(3, 294);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(148, 36);
            this.labelDifficulty.TabIndex = 3;
            this.labelDifficulty.Text = "Сложность:";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLanguage.Location = new System.Drawing.Point(157, 361);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(175, 61);
            this.buttonLanguage.TabIndex = 4;
            this.buttonLanguage.Text = "Русский";
            this.buttonLanguage.UseVisualStyleBackColor = true;
            this.buttonLanguage.Click += new System.EventHandler(this.buttonLanguage_Click);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguage.Location = new System.Drawing.Point(3, 374);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(75, 36);
            this.labelLanguage.TabIndex = 5;
            this.labelLanguage.Text = "Язык:";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRule
            // 
            this.textBoxRule.BackColor = System.Drawing.Color.LightSlateGray;
            this.textBoxRule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRule.Location = new System.Drawing.Point(12, 12);
            this.textBoxRule.Multiline = true;
            this.textBoxRule.Name = "textBoxRule";
            this.textBoxRule.Size = new System.Drawing.Size(452, 44);
            this.textBoxRule.TabIndex = 7;
            this.textBoxRule.Text = "При нажатии на букву \"ё\" появляется буква \"Æ\" из осетинского алфавита";
            this.textBoxRule.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(348, 361);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 61);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxRule);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.buttonLanguage);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDifficulty);
            this.Controls.Add(this.buttonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGame";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonDifficulty;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TextBox textBoxRule;
        private System.Windows.Forms.Button buttonExit;
    }
}

