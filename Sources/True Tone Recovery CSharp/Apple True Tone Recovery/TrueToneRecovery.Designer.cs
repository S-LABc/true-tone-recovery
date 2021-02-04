namespace Apple_True_Tone_Recovery
{
    partial class TrueToneRecovery
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
            this.components = new System.ComponentModel.Container();
            this.cbModelType = new MetroFramework.Controls.MetroComboBox();
            this.cbPort = new MetroFramework.Controls.MetroComboBox();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbCoverBoardSN = new MetroFramework.Controls.MetroTextBox();
            this.spLCD = new System.IO.Ports.SerialPort(this.components);
            this.lblNumCBSN = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbModelType
            // 
            this.cbModelType.FormattingEnabled = true;
            this.cbModelType.ItemHeight = 23;
            this.cbModelType.Location = new System.Drawing.Point(15, 151);
            this.cbModelType.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbModelType.Name = "cbModelType";
            this.cbModelType.Size = new System.Drawing.Size(150, 29);
            this.cbModelType.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbModelType.TabIndex = 0;
            this.cbModelType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbModelType.UseSelectable = true;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.ItemHeight = 23;
            this.cbPort.Items.AddRange(new object[] {
            "COM32"});
            this.cbPort.Location = new System.Drawing.Point(175, 151);
            this.cbPort.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.PromptText = "Порт";
            this.cbPort.Size = new System.Drawing.Size(95, 29);
            this.cbPort.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbPort.TabIndex = 1;
            this.cbPort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbPort.UseSelectable = true;
            this.cbPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPort_MouseClick);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(280, 151);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(115, 29);
            this.btnWrite.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Записать";
            this.btnWrite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnWrite.UseSelectable = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(15, 80);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Cover Board Serial Number";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbCoverBoardSN
            // 
            this.tbCoverBoardSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbCoverBoardSN.CustomButton.Image = null;
            this.tbCoverBoardSN.CustomButton.Location = new System.Drawing.Point(356, 1);
            this.tbCoverBoardSN.CustomButton.Name = "";
            this.tbCoverBoardSN.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbCoverBoardSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCoverBoardSN.CustomButton.TabIndex = 1;
            this.tbCoverBoardSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCoverBoardSN.CustomButton.UseSelectable = true;
            this.tbCoverBoardSN.CustomButton.Visible = false;
            this.tbCoverBoardSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbCoverBoardSN.Lines = new string[0];
            this.tbCoverBoardSN.Location = new System.Drawing.Point(15, 103);
            this.tbCoverBoardSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbCoverBoardSN.MaxLength = 0;
            this.tbCoverBoardSN.Name = "tbCoverBoardSN";
            this.tbCoverBoardSN.PasswordChar = '\0';
            this.tbCoverBoardSN.PromptText = "Cover Board SN";
            this.tbCoverBoardSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCoverBoardSN.SelectedText = "";
            this.tbCoverBoardSN.SelectionLength = 0;
            this.tbCoverBoardSN.SelectionStart = 0;
            this.tbCoverBoardSN.ShortcutsEnabled = true;
            this.tbCoverBoardSN.Size = new System.Drawing.Size(380, 25);
            this.tbCoverBoardSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbCoverBoardSN.TabIndex = 9;
            this.tbCoverBoardSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCoverBoardSN.UseSelectable = true;
            this.tbCoverBoardSN.WaterMark = "Cover Board SN";
            this.tbCoverBoardSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCoverBoardSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCoverBoardSN.TextChanged += new System.EventHandler(this.tbCoverBoardSN_TextChanged);
            // 
            // spLCD
            // 
            this.spLCD.BaudRate = 115200;
            // 
            // lblNumCBSN
            // 
            this.lblNumCBSN.Enabled = false;
            this.lblNumCBSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumCBSN.Location = new System.Drawing.Point(339, 80);
            this.lblNumCBSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblNumCBSN.Name = "lblNumCBSN";
            this.lblNumCBSN.Size = new System.Drawing.Size(55, 21);
            this.lblNumCBSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblNumCBSN.TabIndex = 12;
            this.lblNumCBSN.Text = "-- / --";
            this.lblNumCBSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumCBSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TrueToneRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 195);
            this.Controls.Add(this.lblNumCBSN);
            this.Controls.Add(this.cbModelType);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbCoverBoardSN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "TrueToneRecovery";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Apple True Tone Recovery";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrueToneRecovery_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbModelType;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbCoverBoardSN;
        private System.IO.Ports.SerialPort spLCD;
        private MetroFramework.Controls.MetroLabel lblNumCBSN;
    }
}

