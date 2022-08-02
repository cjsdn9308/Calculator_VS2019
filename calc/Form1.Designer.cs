
namespace calc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.MinimumSize = new System.Drawing.Size(320, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 47);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("굴림", 20F);
            this.btn1.Location = new System.Drawing.Point(17, 250);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 66);
            this.btn1.TabIndex = 1;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("굴림", 20F);
            this.btn2.Location = new System.Drawing.Point(96, 250);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 66);
            this.btn2.TabIndex = 2;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("굴림", 20F);
            this.btn3.Location = new System.Drawing.Point(175, 250);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 66);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("굴림", 20F);
            this.btn4.Location = new System.Drawing.Point(17, 176);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 66);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("굴림", 20F);
            this.btn5.Location = new System.Drawing.Point(96, 176);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 66);
            this.btn5.TabIndex = 5;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("굴림", 20F);
            this.btn6.Location = new System.Drawing.Point(175, 176);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 66);
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("굴림", 20F);
            this.btn7.Location = new System.Drawing.Point(17, 102);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 66);
            this.btn7.TabIndex = 7;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("굴림", 20F);
            this.btn8.Location = new System.Drawing.Point(96, 102);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 66);
            this.btn8.TabIndex = 8;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("굴림", 20F);
            this.btn9.Location = new System.Drawing.Point(175, 102);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 66);
            this.btn9.TabIndex = 9;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("굴림", 20F);
            this.btn0.Location = new System.Drawing.Point(96, 324);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(72, 66);
            this.btn0.TabIndex = 10;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("굴림", 20F);
            this.btnResult.Location = new System.Drawing.Point(175, 324);
            this.btnResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(72, 66);
            this.btnResult.TabIndex = 11;
            this.btnResult.TabStop = false;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSum.Location = new System.Drawing.Point(254, 102);
            this.btnSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(72, 66);
            this.btnSum.TabIndex = 12;
            this.btnSum.TabStop = false;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSub.Location = new System.Drawing.Point(254, 176);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(72, 66);
            this.btnSub.TabIndex = 13;
            this.btnSub.TabStop = false;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMul.Location = new System.Drawing.Point(254, 250);
            this.btnMul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(72, 66);
            this.btnMul.TabIndex = 14;
            this.btnMul.TabStop = false;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("굴림", 20F);
            this.btnDiv.Location = new System.Drawing.Point(254, 324);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(72, 66);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("굴림", 20F);
            this.btnReset.Location = new System.Drawing.Point(17, 324);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 66);
            this.btnReset.TabIndex = 16;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 412);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "계산기";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
    }
}

