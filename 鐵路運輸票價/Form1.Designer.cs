namespace test5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RdbSouth = new System.Windows.Forms.RadioButton();
            this.RdbNorth = new System.Windows.Forms.RadioButton();
            this.ChkToBack = new System.Windows.Forms.CheckBox();
            this.ChkSpecial = new System.Windows.Forms.CheckBox();
            this.CbxStart = new System.Windows.Forms.ComboBox();
            this.CbxEnd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RdbSouth
            // 
            this.RdbSouth.AutoSize = true;
            this.RdbSouth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RdbSouth.Location = new System.Drawing.Point(73, 52);
            this.RdbSouth.Name = "RdbSouth";
            this.RdbSouth.Size = new System.Drawing.Size(59, 24);
            this.RdbSouth.TabIndex = 0;
            this.RdbSouth.TabStop = true;
            this.RdbSouth.Text = "南下";
            this.RdbSouth.UseVisualStyleBackColor = true;
            // 
            // RdbNorth
            // 
            this.RdbNorth.AutoSize = true;
            this.RdbNorth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RdbNorth.Location = new System.Drawing.Point(242, 52);
            this.RdbNorth.Name = "RdbNorth";
            this.RdbNorth.Size = new System.Drawing.Size(59, 24);
            this.RdbNorth.TabIndex = 1;
            this.RdbNorth.TabStop = true;
            this.RdbNorth.Text = "北上";
            this.RdbNorth.UseVisualStyleBackColor = true;
            // 
            // ChkToBack
            // 
            this.ChkToBack.AutoSize = true;
            this.ChkToBack.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChkToBack.Location = new System.Drawing.Point(73, 272);
            this.ChkToBack.Name = "ChkToBack";
            this.ChkToBack.Size = new System.Drawing.Size(73, 23);
            this.ChkToBack.TabIndex = 2;
            this.ChkToBack.Text = "來回票";
            this.ChkToBack.UseVisualStyleBackColor = true;
            // 
            // ChkSpecial
            // 
            this.ChkSpecial.AutoSize = true;
            this.ChkSpecial.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ChkSpecial.Location = new System.Drawing.Point(73, 342);
            this.ChkSpecial.Name = "ChkSpecial";
            this.ChkSpecial.Size = new System.Drawing.Size(73, 23);
            this.ChkSpecial.TabIndex = 3;
            this.ChkSpecial.Text = "優惠票";
            this.ChkSpecial.UseVisualStyleBackColor = true;
            // 
            // CbxStart
            // 
            this.CbxStart.FormattingEnabled = true;
            this.CbxStart.Location = new System.Drawing.Point(77, 177);
            this.CbxStart.Name = "CbxStart";
            this.CbxStart.Size = new System.Drawing.Size(237, 20);
            this.CbxStart.TabIndex = 4;
            // 
            // CbxEnd
            // 
            this.CbxEnd.FormattingEnabled = true;
            this.CbxEnd.Location = new System.Drawing.Point(377, 177);
            this.CbxEnd.Name = "CbxEnd";
            this.CbxEnd.Size = new System.Drawing.Size(246, 20);
            this.CbxEnd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(73, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "起站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(373, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "迄站";
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnOk.Location = new System.Drawing.Point(73, 444);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(147, 72);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "計算";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(73, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "票價為 :";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblPrice.Location = new System.Drawing.Point(233, 626);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(56, 21);
            this.LblPrice.TabIndex = 10;
            this.LblPrice.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 693);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxEnd);
            this.Controls.Add(this.CbxStart);
            this.Controls.Add(this.ChkSpecial);
            this.Controls.Add(this.ChkToBack);
            this.Controls.Add(this.RdbNorth);
            this.Controls.Add(this.RdbSouth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbSouth;
        private System.Windows.Forms.RadioButton RdbNorth;
        private System.Windows.Forms.CheckBox ChkToBack;
        private System.Windows.Forms.CheckBox ChkSpecial;
        private System.Windows.Forms.ComboBox CbxStart;
        private System.Windows.Forms.ComboBox CbxEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPrice;
    }
}

