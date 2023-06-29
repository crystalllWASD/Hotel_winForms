namespace Hotel_winForms
{
    partial class ChoiceARGForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceARGForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonGuest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAuth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGuest, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonAuth
            // 
            this.buttonAuth.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuth.ForeColor = System.Drawing.Color.Maroon;
            this.buttonAuth.Location = new System.Drawing.Point(30, 32);
            this.buttonAuth.Margin = new System.Windows.Forms.Padding(30, 32, 30, 16);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(252, 59);
            this.buttonAuth.TabIndex = 0;
            this.buttonAuth.Text = "Авторизоваться";
            this.buttonAuth.UseVisualStyleBackColor = false;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.Color.Maroon;
            this.buttonReg.Location = new System.Drawing.Point(30, 127);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(252, 67);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonGuest
            // 
            this.buttonGuest.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGuest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuest.ForeColor = System.Drawing.Color.Maroon;
            this.buttonGuest.Location = new System.Drawing.Point(30, 230);
            this.buttonGuest.Margin = new System.Windows.Forms.Padding(30, 16, 30, 32);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(252, 61);
            this.buttonGuest.TabIndex = 2;
            this.buttonGuest.Text = "Гость";
            this.buttonGuest.UseVisualStyleBackColor = false;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // ChoiceARGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(312, 323);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(660, 740);
            this.MinimumSize = new System.Drawing.Size(330, 370);
            this.Name = "ChoiceARGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Great Place";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonGuest;
    }
}

