﻿using System;
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

        public Form1()
        {
            InitializeComponent();

            using (var ef = new DemoNCREntities())
            {

                var query = from e in ef.Empleadoes
                            orderby e.Nombre, e.Puesto.Descripcion
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
}
