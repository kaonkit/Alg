namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.checkTask = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "3.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "4.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "5.";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(274, 31);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Подтвердить";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // checkTask
            // 
            this.checkTask.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkTask.FormattingEnabled = true;
            this.checkTask.Items.AddRange(new object[] {
            "1. Распечатать листья",
            "2. Распечатать внутренние узлы",
            "3. Распечатать узлы, у которых только левый сын",
            "4. Распечатать узлы, у которых только правый сын",
            "5. Найти глубину минимального элемента",
            "6. Найти глубину максимального элемента",
            "7. Определить количество элементов в дереве",
            "8. Определить количество листьев в дереве",
            "9. Определить количество внутренних узлов",
            "10. Определить количество узлов, у которых два сына",
            "11. Определить количество узлов, у которых один сын",
            "12. Определить количество узлов, у которых есть левый сын",
            "13. Определить количество узлов, у которых есть правый сын",
            "14. Определить количество узлов, у которых есть только левый сын",
            "15. Определить количество узлов, у которых есть только правый сын",
            "16. Определить среднее арифметическое всех ключей",
            "17. Определить высоту дерева"});
            this.checkTask.Location = new System.Drawing.Point(12, 75);
            this.checkTask.Name = "checkTask";
            this.checkTask.Size = new System.Drawing.Size(460, 276);
            this.checkTask.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "6.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "7.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "8.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "9.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(481, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "10.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "11.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(481, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "12.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(481, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "13.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(481, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "14.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(481, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "15.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(481, 316);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "16.";
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEnter.Location = new System.Drawing.Point(13, 32);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(231, 22);
            this.txtEnter.TabIndex = 3;
            this.txtEnter.Text = "Введите значения узлов...";
            this.txtEnter.Enter += new System.EventHandler(this.txtEnter_Enter);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(182, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Подтвердить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(44, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 14);
            this.label17.TabIndex = 4;
            this.label17.Text = "Введите значения узлов через пробел";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(481, 333);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "17.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 392);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.checkTask);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.CheckedListBox checkTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

