namespace CellAu
{
    partial class Form1
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sheetInput = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sheet = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonRuleNo = new System.Windows.Forms.Button();
            this.labelRuleNo = new System.Windows.Forms.Label();
            this.buttonCell = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFillRand = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetInput)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.sheetInput);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(195, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1085, 44);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // sheetInput
            // 
            this.sheetInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sheetInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sheetInput.Location = new System.Drawing.Point(3, 3);
            this.sheetInput.Name = "sheetInput";
            this.sheetInput.Size = new System.Drawing.Size(100, 25);
            this.sheetInput.TabIndex = 0;
            this.sheetInput.TabStop = false;
            this.sheetInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sheetInput_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sheet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(195, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1085, 573);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sheet.Location = new System.Drawing.Point(3, 3);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(372, 458);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ButtonRuleNo, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.labelRuleNo, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.buttonCell, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCell, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonInput, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(186, 573);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Evolve: full";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonRuleNo
            // 
            this.ButtonRuleNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRuleNo.Location = new System.Drawing.Point(3, 426);
            this.ButtonRuleNo.Name = "ButtonRuleNo";
            this.ButtonRuleNo.Size = new System.Drawing.Size(180, 41);
            this.ButtonRuleNo.TabIndex = 1;
            this.ButtonRuleNo.Text = "Change Rule";
            this.ButtonRuleNo.UseVisualStyleBackColor = true;
            this.ButtonRuleNo.Click += new System.EventHandler(this.ButtonRuleNo_Click);
            // 
            // labelRuleNo
            // 
            this.labelRuleNo.AutoSize = true;
            this.labelRuleNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRuleNo.Location = new System.Drawing.Point(3, 470);
            this.labelRuleNo.Name = "labelRuleNo";
            this.tableLayoutPanel2.SetRowSpan(this.labelRuleNo, 2);
            this.labelRuleNo.Size = new System.Drawing.Size(180, 103);
            this.labelRuleNo.TabIndex = 2;
            this.labelRuleNo.Text = "label1";
            // 
            // buttonCell
            // 
            this.buttonCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCell.Location = new System.Drawing.Point(3, 50);
            this.buttonCell.Name = "buttonCell";
            this.buttonCell.Size = new System.Drawing.Size(180, 41);
            this.buttonCell.TabIndex = 3;
            this.buttonCell.Text = "Cell";
            this.buttonCell.UseVisualStyleBackColor = true;
            this.buttonCell.Click += new System.EventHandler(this.buttonCell_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCell.Location = new System.Drawing.Point(3, 94);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(180, 47);
            this.labelCell.TabIndex = 4;
            this.labelCell.Text = "Def: 50\r\nSize: 10 x 10";
            // 
            // buttonInput
            // 
            this.buttonInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInput.Location = new System.Drawing.Point(3, 3);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(180, 41);
            this.buttonInput.TabIndex = 5;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFillRand, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonFillRand
            // 
            this.buttonFillRand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFillRand.Location = new System.Drawing.Point(3, 3);
            this.buttonFillRand.Name = "buttonFillRand";
            this.buttonFillRand.Size = new System.Drawing.Size(186, 44);
            this.buttonFillRand.TabIndex = 5;
            this.buttonFillRand.Text = "Fill Rand";
            this.buttonFillRand.UseVisualStyleBackColor = true;
            this.buttonFillRand.Click += new System.EventHandler(this.buttonFillRand_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.Location = new System.Drawing.Point(3, 285);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(180, 41);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "CellAu";
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheetInput)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox sheetInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonRuleNo;
        private System.Windows.Forms.Label labelRuleNo;
        private System.Windows.Forms.Button buttonCell;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonFillRand;
        private System.Windows.Forms.Button buttonClear;
    }
}

