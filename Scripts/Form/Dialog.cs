﻿using System;
using System.Windows.Forms;

namespace JsonShow
{
    public partial class Dialog : Form
    {
        public SerializeJsonForm serializeName;
        public string content = "";

        public Dialog()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void SerializeColumName_TextChanged(object sender, EventArgs e)
        {
        }

        private void OkSerializeName_Click(object sender, EventArgs e)
        {
            //serializeName.columnName = SerializeColumName.Text;
            content = SerializeColumName.Text;
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void CancelSerializeName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloumnName_Load(object sender, EventArgs e)
        {
        }
    }
}