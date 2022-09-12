namespace Login_IT4B
{
    public partial class FormMain : Form
    {
        private Form parentForm;
        public User User { get; set; }

        public void Show(Form parentForm)
        {
            this.parentForm = parentForm;
            Show();
        }

        public FormMain(User user)
        {
            User = user;
            InitializeComponent();
            lblUser.Text = User.Username;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(parentForm != null)
            {
                parentForm.Close();
            }
        }
    }
}