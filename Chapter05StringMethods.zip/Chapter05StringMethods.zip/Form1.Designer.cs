namespace Chapter05StringMethods.zip
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
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label07 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTest_Click = new System.Windows.Forms.Button();
            this.btnClose_Click = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(83, 9);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(69, 13);
            this.label01.TabIndex = 2;
            this.label01.Text = "String to test:";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label01.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(79, 43);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(73, 13);
            this.label02.TabIndex = 3;
            this.label02.Text = "String.Length:";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(64, 79);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(88, 13);
            this.label03.TabIndex = 4;
            this.label03.Text = "String.ToUpper():";
            this.label03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(64, 114);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(88, 13);
            this.label04.TabIndex = 5;
            this.label04.Text = "String.ToLower():";
            this.label04.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label04.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Location = new System.Drawing.Point(45, 152);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(107, 13);
            this.label05.TabIndex = 6;
            this.label05.Text = "Search for character:";
            this.label05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label05.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Location = new System.Drawing.Point(26, 187);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(126, 13);
            this.label06.TabIndex = 7;
            this.label06.Text = "Search for last character:";
            this.label06.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label06.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Location = new System.Drawing.Point(12, 222);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(141, 13);
            this.label07.TabIndex = 8;
            this.label07.Text = "Extract Substring from index:";
            this.label07.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label07.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label08
            // 
            this.label08.AutoSize = true;
            this.label08.Location = new System.Drawing.Point(45, 257);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(106, 13);
            this.label08.TabIndex = 9;
            this.label08.Text = "txtInput.Remove() = :";
            this.label08.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label08.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Location = new System.Drawing.Point(121, 290);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(30, 13);
            this.label09.TabIndex = 9;
            this.label09.Text = "Find:";
            this.label09.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label09.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "txtInput.Replace() = :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTest_Click
            // 
            this.btnTest_Click.Location = new System.Drawing.Point(15, 411);
            this.btnTest_Click.Name = "btnTest_Click";
            this.btnTest_Click.Size = new System.Drawing.Size(75, 23);
            this.btnTest_Click.TabIndex = 11;
            this.btnTest_Click.Text = "&Test";
            this.btnTest_Click.UseVisualStyleBackColor = true;
            this.btnTest_Click.Click += new System.EventHandler(this.BtnTest_Click_Click);
            // 
            // btnClose_Click
            // 
            this.btnClose_Click.Location = new System.Drawing.Point(713, 411);
            this.btnClose_Click.Name = "btnClose_Click";
            this.btnClose_Click.Size = new System.Drawing.Size(75, 23);
            this.btnClose_Click.TabIndex = 12;
            this.btnClose_Click.Text = "&Close";
            this.btnClose_Click.UseVisualStyleBackColor = true;
            this.btnClose_Click.Click += new System.EventHandler(this.BtnClose_Click_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(178, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(610, 20);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextChanged += new System.EventHandler(this.ThtInput_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(178, 40);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(53, 20);
            this.txtLength.TabIndex = 14;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(178, 76);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(610, 20);
            this.txtToUpper.TabIndex = 15;
            this.txtToUpper.TextChanged += new System.EventHandler(this.TextBox3_TextChanged_1);
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(178, 111);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(610, 20);
            this.txtToLower.TabIndex = 16;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(178, 149);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(53, 20);
            this.txtSearchChar.TabIndex = 18;
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(178, 184);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(53, 20);
            this.txtLastChar.TabIndex = 19;
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.AutoSize = true;
            this.lblIndexOf.Location = new System.Drawing.Point(249, 152);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(150, 13);
            this.lblIndexOf.TabIndex = 22;
            this.lblIndexOf.Text = "thtInput.Text.IndexOf(\"v\", 0) =";
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIndexOf.Click += new System.EventHandler(this.Label11_Click);
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.AutoSize = true;
            this.lblLastIndexOf.Location = new System.Drawing.Point(242, 187);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(157, 13);
            this.lblLastIndexOf.TabIndex = 23;
            this.lblLastIndexOf.Text = "thtInput.Text.LastIndexOf(\"s\") =";
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(178, 219);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(53, 20);
            this.txtStartIndex.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "for this many characters:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(416, 219);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(53, 20);
            this.txtEndIndex.TabIndex = 26;
            // 
            // lblSubstring
            // 
            this.lblSubstring.AutoSize = true;
            this.lblSubstring.Location = new System.Drawing.Point(479, 222);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(152, 13);
            this.lblSubstring.TabIndex = 27;
            this.lblSubstring.Text = "txtInput.Text.Substring(18, 7) =";
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(637, 219);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(151, 20);
            this.txtSubstringResult.TabIndex = 28;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(178, 254);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(81, 20);
            this.txtRemove.TabIndex = 29;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(416, 149);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(53, 20);
            this.txtSearchIndex.TabIndex = 30;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(416, 184);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(53, 20);
            this.txtLastIndexOf.TabIndex = 31;
            this.txtLastIndexOf.TextChanged += new System.EventHandler(this.TxtLastIndexOf_TextChanged);
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(265, 254);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(523, 20);
            this.txtRemoveResult.TabIndex = 32;
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(178, 287);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(81, 20);
            this.txtReplaceChars.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(320, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Replace with:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(416, 287);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(53, 20);
            this.txtReplaceWith.TabIndex = 35;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(178, 322);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(610, 20);
            this.txtReplaceResult.TabIndex = 36;
            this.txtReplaceResult.TextChanged += new System.EventHandler(this.TxtReplaceResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnClose_Click);
            this.Controls.Add(this.btnTest_Click);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.label08);
            this.Controls.Add(this.label07);
            this.Controls.Add(this.label06);
            this.Controls.Add(this.label05);
            this.Controls.Add(this.label04);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Name = "Form1";
            this.Text = "String Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTest_Click;
        private System.Windows.Forms.Button btnClose_Click;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtToUpper;
        private System.Windows.Forms.TextBox txtToLower;
        private System.Windows.Forms.TextBox txtSearchChar;
        private System.Windows.Forms.TextBox txtLastChar;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.Label lblLastIndexOf;
        private System.Windows.Forms.TextBox txtStartIndex;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEndIndex;
        private System.Windows.Forms.Label lblSubstring;
        private System.Windows.Forms.TextBox txtSubstringResult;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.TextBox txtSearchIndex;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.TextBox txtRemoveResult;
        private System.Windows.Forms.TextBox txtReplaceChars;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.TextBox txtReplaceResult;
    }
}

