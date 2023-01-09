using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_IT4B
{
    public partial class FormUserEditor : Form
    {
        SqlRepository sqlRepository;    

        public FormUserEditor()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void FormUserEditor_Load(object sender, EventArgs e)
        {
            var users = sqlRepository.GetUsers();
            foreach (var user in users)
            {
                lvUsers.Items.Add(new ListViewItem(new string[] { user.Username,"" }));
            }
        }
    }
}
