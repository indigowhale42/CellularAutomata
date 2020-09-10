namespace CellAu
{
    partial class FormRuleDialog
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
            this.buttonChangeRule = new System.Windows.Forms.Button();
            this.buttonCancelRule = new System.Windows.Forms.Button();
            this.textBoxRule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChangeRule
            // 
            this.buttonChangeRule.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonChangeRule.Location = new System.Drawing.Point(359, 264);
            this.buttonChangeRule.Name = "buttonChangeRule";
            this.buttonChangeRule.Size = new System.Drawing.Size(132, 50);
            this.buttonChangeRule.TabIndex = 0;
            this.buttonChangeRule.Text = "Change";
            this.buttonChangeRule.UseVisualStyleBackColor = true;
            this.buttonChangeRule.Click += new System.EventHandler(this.buttonChangeRule_Click);
            // 
            // buttonCancelRule
            // 
            this.buttonCancelRule.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelRule.Location = new System.Drawing.Point(532, 264);
            this.buttonCancelRule.Name = "buttonCancelRule";
            this.buttonCancelRule.Size = new System.Drawing.Size(134, 50);
            this.buttonCancelRule.TabIndex = 1;
            this.buttonCancelRule.Text = "Cancel";
            this.buttonCancelRule.UseVisualStyleBackColor = true;
            this.buttonCancelRule.Click += new System.EventHandler(this.buttonCancelRule_Click);
            // 
            // textBoxRule
            // 
            this.textBoxRule.Location = new System.Drawing.Point(210, 149);
            this.textBoxRule.MaxLength = 3;
            this.textBoxRule.Name = "textBoxRule";
            this.textBoxRule.Size = new System.Drawing.Size(281, 26);
            this.textBoxRule.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для изменения правила введите число от 0 до 255.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(88, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текущее:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(206, 209);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(21, 20);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "   ";
            // 
            // FormRuleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 337);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRule);
            this.Controls.Add(this.buttonCancelRule);
            this.Controls.Add(this.buttonChangeRule);
            this.Name = "FormRuleDialog";
            this.Text = "FormRuleDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeRule;
        private System.Windows.Forms.Button buttonCancelRule;
        private System.Windows.Forms.TextBox textBoxRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelError;
    }
}