using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameBot2048
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToUInt16(NumericUpDownRows.Value);
            int columns = Convert.ToUInt16(NumericUpDownColumns.Value);
            int speed = Convert.ToUInt16(NumericUpDownSpeed.Value);
            MyClass.Rows = rows;
            MyClass.Columns = columns;
            MyClass.Speed = speed;
            this.Close();
        }
    }
}
