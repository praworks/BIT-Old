using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Declare Variables
        private int number1;
        private int number2;
        private int result;

        private int intValidation;
        private ErrorProvider errorProvider; // Declare the ErrorProvider object
        public Form1()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(); // Initialize the ErrorProvider object

            //Initialise Variabels on form constructors.
            number1 = 0;
            number2 = 0;

            //Change attribute
            txtResult.ReadOnly = true;
        }

        private void txtNumber1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Clear errorProvider
            errorProvider.SetError(txtNumber1, "");

            if (!int.TryParse(txtNumber1.Text, out intValidation))
            {
                errorProvider.SetError(txtNumber1, "Please fill the required field");
            }
        }

        private void txtNumber2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Clear errorProvider
            errorProvider.SetError(txtNumber2, "");

            if (!int.TryParse(txtNumber2.Text, out intValidation))
            {
                errorProvider.SetError(txtNumber2, "Please fill the required field");
            }
        }

        private void txtResult_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Clear errorProvider
            errorProvider.SetError(txtResult, "");

            if (!int.TryParse(txtResult.Text, out intValidation))
            {
                errorProvider.SetError(txtResult, "Please fill the required field");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    number1 = int.Parse(txtNumber1.Text);
                    number2 = int.Parse(txtNumber2.Text);

                    result = (number1 + number2);

                    txtResult.Text = result.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}