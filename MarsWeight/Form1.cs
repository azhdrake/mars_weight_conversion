using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsWeight
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      // gets the name and earth weight of an object. Checks that both values are valid and maths them up. 
      string name = txtName.Text;
      string errorMessage;
      string validName;

      string mass = txtMass.Text;
      double massDouble = 0;

      if (!ValidateName(name, out validName, out errorMessage))
      {
        MessageBox.Show(errorMessage);
        txtName.Focus();
        return;
      }

      if (!ValidatePositiveDouble(mass, out massDouble, out errorMessage))
      {
        MessageBox.Show(errorMessage, "Error");
        txtMass.Focus();
        return;
      }

      double conversion_factor = 0.377;
      double marsWeight = massDouble * conversion_factor;
      txtMars.Text = String.Format("{0} weighs {1} on Mars", validName, marsWeight.ToString());
    }

    private bool ValidateName(string text, out string name, out string error)
    {
      // Makes sure there is at least two characters typed into the name box.
      error = "";
      name = "";

      text = text.Trim();

      if (String.IsNullOrEmpty(text))
      {
        error = "Please enter a name.";
        return false;
      }
      else if (text.Length < 2)
      {
        error = "Name must be at least two characters.";
      }
      name = text;
      return true;
    }

    private bool ValidatePositiveDouble(string mass, out double number, out string error)
    {
      // makes sure that the earth weight of the object is somewhere between literally nothing and the mass of the moon.
      number = 0;
      error = "";
      try
      {
        number = Double.Parse(mass);
        if(number >= 0 && number < 1e20)
        {
          return true;
        }
        else if(number < 0)
        {
          error = "Enter a positive number, please.";
          return false;
        }
        else if(number >= 1e20)
        {
          error = "Do not take the moon to Mars, we need it.";
        }
      }
      catch (FormatException)
      {
        error = "Enter a number, please.";
        return false;
      }
      catch (OverflowException)
      {
        error = "Enter a slightly smaller number, please.";
        return false;
      }
      return false;
    }
  }
}
