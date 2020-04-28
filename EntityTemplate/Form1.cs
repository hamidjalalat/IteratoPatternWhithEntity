using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Models.DatabaseContext db=new Models.DatabaseContext())
            {
                var listState = db.States.ToList();

                Models.StateArdebil oStateArdebil = new Models.StateArdebil(listState);
                listBox1.SelectedValue = "Id";
                listBox1.DisplayMember = "Name";

                foreach (Models.State item in oStateArdebil)
                {
                    listBox1.Items.Add(item);
                }

            }
        }
    }
}
