using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFyLinQ
{
    public partial class Form1 : Form
    {
        DemoNCREntities _ef;

        public Form1()
        {
            InitializeComponent();

            _ef = new DemoNCREntities();

            dataGridView1.DataSource = _ef.Empleadoes;
        }
    }
}
