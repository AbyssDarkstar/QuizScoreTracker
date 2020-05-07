using QuizScoreTracker.Managers;
using System.Windows.Forms;

namespace QuizScoreTracker.Forms
{
    partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            Text = $"About {AssemblyManager.Title}";
            labelProductName.Text = AssemblyManager.Product;
            labelVersion.Text = $"Version {AssemblyManager.Version}";
            labelCopyright.Text = AssemblyManager.Copyright;
            labelCompanyName.Text = AssemblyManager.Company;
            textBoxDescription.Text = AssemblyManager.Description;
        }
    }
}