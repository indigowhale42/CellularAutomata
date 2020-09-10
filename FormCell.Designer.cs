namespace CellAu
{
    partial class FormCell
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
            this.labelError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCellsNumber = new System.Windows.Forms.TextBox();
            this.buttonCancelCell = new System.Windows.Forms.Button();
            this.buttonChangeCell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCellSize = new System.Windows.Forms.TextBox();
            this.labelError2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(216, 191);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(21, 20);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(98, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текущее:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количества клеток: введите число от 10 до 500.";
            // 
            // textBoxCellsNumber
            // 
            this.textBoxCellsNumber.Location = new System.Drawing.Point(220, 138);
            this.textBoxCellsNumber.MaxLength = 3;
            this.textBoxCellsNumber.Name = "textBoxCellsNumber";
            this.textBoxCellsNumber.Size = new System.Drawing.Size(281, 26);
            this.textBoxCellsNumber.TabIndex = 8;
            // 
            // buttonCancelCell
            // 
            this.buttonCancelCell.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelCell.Location = new System.Drawing.Point(587, 379);
            this.buttonCancelCell.Name = "buttonCancelCell";
            this.buttonCancelCell.Size = new System.Drawing.Size(134, 50);
            this.buttonCancelCell.TabIndex = 7;
            this.buttonCancelCell.Text = "Cancel";
            this.buttonCancelCell.UseVisualStyleBackColor = true;
            this.buttonCancelCell.Click += new System.EventHandler(this.buttonCancelCell_Click);
            // 
            // buttonChangeCell
            // 
            this.buttonChangeCell.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonChangeCell.Location = new System.Drawing.Point(414, 379);
            this.buttonChangeCell.Name = "buttonChangeCell";
            this.buttonChangeCell.Size = new System.Drawing.Size(132, 50);
            this.buttonChangeCell.TabIndex = 6;
            this.buttonChangeCell.Text = "Change";
            this.buttonChangeCell.UseVisualStyleBackColor = true;
            this.buttonChangeCell.Click += new System.EventHandler(this.buttonChangeCell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(98, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Текущее:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(39, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Размер клеток: введите число от 1 до 30.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxCellSize
            // 
            this.textBoxCellSize.Location = new System.Drawing.Point(220, 273);
            this.textBoxCellSize.MaxLength = 3;
            this.textBoxCellSize.Name = "textBoxCellSize";
            this.textBoxCellSize.Size = new System.Drawing.Size(281, 26);
            this.textBoxCellSize.TabIndex = 12;
            this.textBoxCellSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Location = new System.Drawing.Point(220, 315);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(25, 20);
            this.labelError2.TabIndex = 15;
            this.labelError2.Text = "    ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(44, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Сетка";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 441);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCellSize);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCellsNumber);
            this.Controls.Add(this.buttonCancelCell);
            this.Controls.Add(this.buttonChangeCell);
            this.Name = "FormCell";
            this.Text = "FormCell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCellsNumber;
        private System.Windows.Forms.Button buttonCancelCell;
        private System.Windows.Forms.Button buttonChangeCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCellSize;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}