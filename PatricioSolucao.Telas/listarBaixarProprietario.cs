﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatricioSolucao.Telas
{
    public partial class listarBaixarProprietario : Form
    {
        public listarBaixarProprietario()
        {
            InitializeComponent();
        }

        private void listarBaixarProprietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu Menu_ = new Menu();
            Menu_.Show();
        }
    }
}
