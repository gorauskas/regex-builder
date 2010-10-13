namespace RegexBuilder {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textRegex = new System.Windows.Forms.TextBox();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkMultiLine = new System.Windows.Forms.CheckBox();
            this.checkCase = new System.Windows.Forms.CheckBox();
            this.rtbTest = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textRegex);
            this.flowLayoutPanel1.Controls.Add(this.buttonMatch);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Controls.Add(this.checkMultiLine);
            this.flowLayoutPanel1.Controls.Add(this.checkCase);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regex:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textRegex
            // 
            this.textRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textRegex.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegex.Location = new System.Drawing.Point(50, 3);
            this.textRegex.Name = "textRegex";
            this.textRegex.Size = new System.Drawing.Size(378, 22);
            this.textRegex.TabIndex = 1;
            this.textRegex.Text = "(a|b|r)+";
            // 
            // buttonMatch
            // 
            this.buttonMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatch.Location = new System.Drawing.Point(434, 3);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonMatch.TabIndex = 2;
            this.buttonMatch.Text = "Match";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(515, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkMultiLine
            // 
            this.checkMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMultiLine.AutoSize = true;
            this.checkMultiLine.Location = new System.Drawing.Point(596, 6);
            this.checkMultiLine.Name = "checkMultiLine";
            this.checkMultiLine.Size = new System.Drawing.Size(71, 17);
            this.checkMultiLine.TabIndex = 4;
            this.checkMultiLine.Text = "Multi Line";
            this.checkMultiLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMultiLine.UseVisualStyleBackColor = true;
            // 
            // checkCase
            // 
            this.checkCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkCase.AutoSize = true;
            this.checkCase.Location = new System.Drawing.Point(673, 6);
            this.checkCase.Name = "checkCase";
            this.checkCase.Size = new System.Drawing.Size(96, 17);
            this.checkCase.TabIndex = 5;
            this.checkCase.Text = "Case Sensitive";
            this.checkCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkCase.UseVisualStyleBackColor = true;
            // 
            // rtbTest
            // 
            this.rtbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTest.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTest.Location = new System.Drawing.Point(0, 30);
            this.rtbTest.Name = "rtbTest";
            this.rtbTest.Size = new System.Drawing.Size(784, 532);
            this.rtbTest.TabIndex = 2;
            this.rtbTest.Text = "Abracadabra abracadabra\nabracadabra Abracadabra";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.rtbTest);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Regex Builder";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRegex;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkMultiLine;
        private System.Windows.Forms.CheckBox checkCase;
        private System.Windows.Forms.RichTextBox rtbTest;
    }
}

