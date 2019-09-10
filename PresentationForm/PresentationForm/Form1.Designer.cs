namespace PresentationForm
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
            this.btnChallengeOne = new System.Windows.Forms.Button();
            this.btnChallengeTwo = new System.Windows.Forms.Button();
            this.btnChallengeThree = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChallengeOne
            // 
            this.btnChallengeOne.Location = new System.Drawing.Point(59, 47);
            this.btnChallengeOne.Name = "btnChallengeOne";
            this.btnChallengeOne.Size = new System.Drawing.Size(131, 23);
            this.btnChallengeOne.TabIndex = 0;
            this.btnChallengeOne.Text = "Reverse A String";
            this.btnChallengeOne.UseVisualStyleBackColor = true;
            this.btnChallengeOne.Click += new System.EventHandler(this.btnChallengeOne_Click);
            // 
            // btnChallengeTwo
            // 
            this.btnChallengeTwo.Location = new System.Drawing.Point(59, 104);
            this.btnChallengeTwo.Name = "btnChallengeTwo";
            this.btnChallengeTwo.Size = new System.Drawing.Size(131, 23);
            this.btnChallengeTwo.TabIndex = 1;
            this.btnChallengeTwo.Text = "Challenge Two";
            this.btnChallengeTwo.UseVisualStyleBackColor = true;
            // 
            // btnChallengeThree
            // 
            this.btnChallengeThree.Location = new System.Drawing.Point(59, 153);
            this.btnChallengeThree.Name = "btnChallengeThree";
            this.btnChallengeThree.Size = new System.Drawing.Size(131, 23);
            this.btnChallengeThree.TabIndex = 2;
            this.btnChallengeThree.Text = "Challenge Three";
            this.btnChallengeThree.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(51, 273);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(139, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description of the challenge";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(447, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(447, 104);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(397, 52);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(31, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(389, 107);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 417);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnChallengeThree);
            this.Controls.Add(this.btnChallengeTwo);
            this.Controls.Add(this.btnChallengeOne);
            this.Name = "Form1";
            this.Text = "Challenges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChallengeOne;
        private System.Windows.Forms.Button btnChallengeTwo;
        private System.Windows.Forms.Button btnChallengeThree;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
    }
}

