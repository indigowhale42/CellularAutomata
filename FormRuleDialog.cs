using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellAu
{
    public partial class FormRuleDialog : Form
    {
        public int RuleNumberDialodResult { get; set; }

        public FormRuleDialog(int ruleNumber)
        {
            InitializeComponent();

            labelError.Text = "    ";
            textBoxRule.Text = ruleNumber.ToString();
        }

        private void buttonChangeRule_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(textBoxRule.Text);
                if (result < 0 || result > 255)
                    throw new Exception();
                RuleNumberDialodResult = result;
            }
            catch (Exception)
            {
                labelError.Text = "Неправильный ввод. " + textBoxRule.Text;
                DialogResult = DialogResult.None;
            }
        }

        private void buttonCancelRule_Click(object sender, EventArgs e)
        {
            //RuleNumberDialodResult = -1;
        }
    }
}
