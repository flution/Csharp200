﻿namespace NumBase
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblResult;
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            lblResult.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            lblResult.Location = new System.Drawing.Point(475, 193);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(50, 23);
            lblResult.TabIndex = 3;
            lblResult.Text = "결과";
            lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.Salmon;
            this.btnInt.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInt.Location = new System.Drawing.Point(142, 94);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(160, 48);
            this.btnInt.TabIndex = 0;
            this.btnInt.Text = "정수형 출력";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDouble.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDouble.Location = new System.Drawing.Point(142, 193);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(160, 48);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "실수형 출력";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnString
            // 
            this.btnString.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnString.Font = new System.Drawing.Font("나눔스퀘어", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnString.Location = new System.Drawing.Point(142, 288);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(160, 48);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "문자열 출력";
            this.btnString.UseVisualStyleBackColor = false;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblResult);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnInt;
    }
}

