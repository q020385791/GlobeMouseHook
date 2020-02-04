namespace GlobeMouseHook
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
            this.components = new System.ComponentModel.Container();
            this.btnStartMouseHook = new System.Windows.Forms.Button();
            this.btnStopMouseHook = new System.Windows.Forms.Button();
            this.PosX = new System.Windows.Forms.Label();
            this.PosY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStartMouseHook
            // 
            this.btnStartMouseHook.Location = new System.Drawing.Point(38, 42);
            this.btnStartMouseHook.Name = "btnStartMouseHook";
            this.btnStartMouseHook.Size = new System.Drawing.Size(75, 23);
            this.btnStartMouseHook.TabIndex = 0;
            this.btnStartMouseHook.Text = "Start";
            this.btnStartMouseHook.UseVisualStyleBackColor = true;
            this.btnStartMouseHook.Click += new System.EventHandler(this.BtnStartMouseHook_Click);
            // 
            // btnStopMouseHook
            // 
            this.btnStopMouseHook.Location = new System.Drawing.Point(167, 42);
            this.btnStopMouseHook.Name = "btnStopMouseHook";
            this.btnStopMouseHook.Size = new System.Drawing.Size(75, 23);
            this.btnStopMouseHook.TabIndex = 1;
            this.btnStopMouseHook.Text = "Stop";
            this.btnStopMouseHook.UseVisualStyleBackColor = true;
            this.btnStopMouseHook.Click += new System.EventHandler(this.BtnStopMouseHook_Click);
            // 
            // PosX
            // 
            this.PosX.AutoSize = true;
            this.PosX.Location = new System.Drawing.Point(13, 82);
            this.PosX.Name = "PosX";
            this.PosX.Size = new System.Drawing.Size(41, 15);
            this.PosX.TabIndex = 2;
            this.PosX.Text = "label1";
            // 
            // PosY
            // 
            this.PosY.AutoSize = true;
            this.PosY.Location = new System.Drawing.Point(74, 82);
            this.PosY.Name = "PosY";
            this.PosY.Size = new System.Drawing.Size(41, 15);
            this.PosY.TabIndex = 3;
            this.PosY.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 109);
            this.Controls.Add(this.PosY);
            this.Controls.Add(this.PosX);
            this.Controls.Add(this.btnStopMouseHook);
            this.Controls.Add(this.btnStartMouseHook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartMouseHook;
        private System.Windows.Forms.Button btnStopMouseHook;
        private System.Windows.Forms.Label PosX;
        private System.Windows.Forms.Label PosY;
        private System.Windows.Forms.Timer timer1;
    }
}

