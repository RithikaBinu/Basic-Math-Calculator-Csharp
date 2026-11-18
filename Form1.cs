using System;
using System.Data;
using System.Windows.Forms;

namespace Fourth // Kept your original namespace name
{
    public partial class Form1 : Form
    {
        // This string will hold the entire mathematical equation as it is typed
        private string currentExpression = "";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void NumberButton_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            
            currentExpression += btn.Text;
            txtDisplay.Text = currentExpression;
        }

        
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            
            currentExpression += btn.Text;
            txtDisplay.Text = currentExpression;
        }

        
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable table = new DataTable();
                var result = table.Compute(currentExpression, string.Empty);

                
                txtDisplay.Text = result.ToString();

                
                currentExpression = result.ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Invalid Mathematical Expression", "Error");
                currentExpression = "";
                txtDisplay.Text = "";
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            currentExpression = "";
            txtDisplay.Text = "";
        }
    }
}