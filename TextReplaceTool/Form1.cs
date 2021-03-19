using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplaceTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_handle_Click(object sender, EventArgs e)
        {

            var textArray = this.tb_source.Lines;
            var midddle = this.tb_middle.Text;
            StringBuilder builder = new StringBuilder();
            foreach (var text in textArray)
            {
                string midddleReplace = midddle;
                string[] itemArray = text.Split(',');
                Regex reg = new Regex("\\$\\d+");
                var matcheArray = reg.Matches(midddle);
                foreach (var matche in matcheArray.OrderByDescending(x=>x.Value))
                {
                    try
                    {
                        int index = int.Parse(matche.ToString().Replace("$", ""));
                        midddleReplace = midddleReplace.Replace(matche.ToString(), itemArray[index]);
                    }
                    catch (Exception)
                    {

                    }

                }
                builder.AppendLine(midddleReplace);
            }
            this.tb_dest.Text = builder.ToString();


        }

    }
}
