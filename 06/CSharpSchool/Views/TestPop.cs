﻿using CSharpSchool.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool.Views
{
  public partial class TestPop : Form
  {
    public TestPop()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      App app = App.Instance();
      app.name = this.tbox_1.Text;
      app.age = int.Parse(this.tbox_2.Text);
      app.gender = this.tbox_3.Text;
    }
  }
}
