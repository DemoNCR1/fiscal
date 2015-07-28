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

            var query = from e in _ef.Empleadoes
                        select new
                        {
                            Codigo = e.Id,
                            Nombre = e.Nombre,
                            Puesto = e.Puesto.Descripcion
                        };

            dataGridView1.DataSource = query;
        }
    }
}
