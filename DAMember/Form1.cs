using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Daiana Arantes
//May 2018


namespace DAMember
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Capitalize first Letter from names
        private string Capitalize(string name)
        {
            if (name == "")
            {
                return name;
            }

            name = name.Trim();
  
            return char.ToUpper(name[0]).ToString()
                    + name.Substring(1);
        }

        //Checks if names are all letters 
        private bool  CheckName(string name)
        {

            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        return false;
                    }
                }
            }
                return true;
        }

        //Checks postal Code on canadian model
        private bool PostalCodeValidation(string postalCode)
        {
            if (string.IsNullOrEmpty(postalCode))
            {
                if(textBoxEmail.Text.Length > 0)
                {
                    return true;
                }
                return false;
            }
            else if (!char.IsLetter(postalCode[0]))
            {
                return false;
            }
            else if (!char.IsDigit(postalCode[1]))
            {
                return false;
            }
            else if (!char.IsLetter(postalCode[2]))
            {
                return false;
            }
            else if (!char.IsDigit(postalCode[4]))
            {
                return false;
            }
            else if (!char.IsLetter(postalCode[5]))
            {
                return false;
            }
            else if (!char.IsDigit(postalCode[6]))
            {
                return false;
            }
            else
            {
                return true;
            }
        
        }

        //Checks phone number on canadian model
        private bool PhoneNumberValidation(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return false;
            }

            if (phone[3] != '-' && phone[7] != '-')
            {
                if (phone.Length != 10)
                {
                    return false;
                }    
            }
            else
            {
                if (phone.Length != 12)
                {
                    return false;
                }
            }
            
            for (int i = 0; i < phone.Length; i++)
            {
                if(i != 3 && i!=7 && !char.IsDigit(phone[i]))
                {
                    return false;
                }
            }

            return true;
        }

        //Checks province code
        private bool ProvinceCodeValidation(string provinceCode)
        {
            for (int i = 0; i < provinceCode.Length; i++)
            {
                if(!char.IsLetter(provinceCode[i]))
                {
                    return false;
                }
            }

            if(provinceCode.Length != 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks email if it fits email format
        private bool EmailValidation(string email)
        {
            if(string.IsNullOrEmpty(email))
            {
                return false;
            }
            //Checks if email contains @
            if(!email.Contains("@"))
            {
                return false;
            }
            //Checks if there is letter before "@"
            else if (email.IndexOf("@") <= 0)
            {
                return false;
            }
            //Checks if there is "." after "@"
            else if (!email.Substring(email.IndexOf("@")).Contains("."))
            {
                return false;
            }
            //Checks id there are t lest 2 letters before "."
            else if (email.Substring(email.IndexOf("@")).IndexOf(".") <= 1)
            {
                return false;
            }
            //Checks if there are 2 letters after "."
            else if (email.Substring(email.IndexOf("@"))
                .Substring(email.Substring(email.IndexOf("@")).IndexOf("."))
                .Length <= 1)
            {
                return false;
            }
            return true;
        }

        //Checks if fee is number
        private bool IsNumber(string number)
        {
            if(string.IsNullOrEmpty(number) && number.Length < 1)
            {
                return false;
            }
            else if (number[0] == '-')
            {
                for (int i = 1; i < number.Length; i++)
                {
                    if(!char.IsDigit(number[i]))
                    {
                        return false;
                    }
                }
            }
            else
                for (int i = 0; i < number.Length; i++)
                {
                    if (!char.IsDigit(number[i]))
                    {
                        return false;
                    }
                }


            return true;
        }

        //Fill all the text box at once
        private void buttonPreFill_Click(object sender, EventArgs e)
        {
            textBoxMemberFstName.Text = "Daiana";
            textBoxMemberLstName.Text = "Arantes";
            textBoxSpouseFstName.Text = "Rhuan";
            textBoxSpouseLstName.Text = "Krum";
            textBoxStreetAddress.Text = "187 Brybeck Crescent";
            textBoxCity.Text = "Kitchener";
            textBoxProvinceCode.Text = "ON";
            textBoxPostalCode.Text = "N2M 5H3";
            textBoxPhone.Text = "226-748-3771";
            textBoxEmail.Text = "daiana.arantes@hotmail.com";
            textBoxFee.Text = "22";
        }

        //Close the form
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Submit all filds at once
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //Check if member first name matches requirements
            textBoxMemberFstName.Text = 
                Capitalize(textBoxMemberFstName.Text);

            if (CheckName(textBoxMemberFstName.Text))
            {
                errorMemberFstName.SetError(textBoxMemberFstName, "");
                textBoxMemberFstName.Text = (char.ToUpper
                    (textBoxMemberFstName.Text[0])).ToString() +
                    textBoxMemberFstName.Text.Substring(1);
            }
            else
            {
                errorMemberFstName.SetError(textBoxMemberFstName,
                    "Insert a proper name, ex. Denise");
            }

            //Check if member last name matches requirements
            textBoxMemberLstName.Text = 
                Capitalize(textBoxMemberLstName.Text);

            if (CheckName(textBoxMemberLstName.Text))
            {
                errorMemberLstName.SetError(textBoxMemberLstName, "");
                textBoxMemberLstName.Text = (char.ToUpper
                    (textBoxMemberLstName.Text[0])).ToString() +
                    textBoxMemberLstName.Text.Substring(1);
            }
            else
            {
                errorMemberLstName.SetError(textBoxMemberLstName,
                    "Insert a proper name, ex. Denise");
            }

            //Check if spouse first name matches requirements
            textBoxSpouseFstName.Text = 
                Capitalize(textBoxSpouseFstName.Text);

            if (CheckName(textBoxSpouseFstName.Text))
            {
                errorSpouseFstName.SetError(textBoxSpouseFstName, "");
                textBoxSpouseFstName.Text = (char.ToUpper
                    (textBoxSpouseFstName.Text[0])).ToString() +
                    textBoxSpouseFstName.Text.Substring(1);
            }
            else
            {
                errorSpouseFstName.SetError(textBoxSpouseFstName,
                    "Insert a proper name, ex. Denise");
            }

            //Check if member last name matches requirements
            textBoxSpouseLstName.Text = 
                Capitalize(textBoxSpouseLstName.Text);

            if (CheckName(textBoxSpouseLstName.Text))
            {
                errorSpouseLstName.SetError(textBoxSpouseLstName, "");
                textBoxSpouseLstName.Text = (char.ToUpper
                    (textBoxSpouseLstName.Text[0])).ToString() +
                    textBoxSpouseLstName.Text.Substring(1);
            }
            else
            {
                errorSpouseLstName.SetError(textBoxSpouseLstName,
                    "Insert a proper name, ex. Denise");
            }

            //Check if address matches requirements
            textBoxStreetAddress.Text = 
                Capitalize(textBoxStreetAddress.Text);

            if (string.IsNullOrEmpty(textBoxStreetAddress.Text) ||
                textBoxStreetAddress.Text.Length < 2)
            {
                if (textBoxEmail.Text.Length == 0)
                {
                    errorAddress.SetError(textBoxStreetAddress,
                        "Insert a proper address, ex. 187 Westmount");
                }
            }
            else
            {
                errorAddress.SetError(textBoxStreetAddress, "");
                textBoxStreetAddress.Text = (char.ToUpper
                    (textBoxStreetAddress.Text[0])).ToString()
                    +  textBoxStreetAddress.Text.Substring(1);
            }

            //Check if city matches requirements
            textBoxCity.Text = Capitalize(textBoxCity.Text);

            if (CheckName(textBoxCity.Text))
            {
                errorCity.SetError(textBoxCity, "");
                textBoxCity.Text = (char.ToUpper(textBoxCity.Text[0]))
                    .ToString() + textBoxCity.Text.Substring(1);
            }
            else
            {
                if (textBoxEmail.Text.Length == 0)
                {
                    errorCity.SetError(textBoxCity,
                        "Insert a proper city, ex. London");
                }
            }

            //Check if postal code matches requirements
            textBoxPostalCode.Text = textBoxPostalCode.Text.ToUpper();
            if (textBoxPostalCode.Text.Length == 6)
            {
                textBoxPostalCode.Text = 
                    textBoxPostalCode.Text.Insert(3, " ");
            }
            if (!PostalCodeValidation(textBoxPostalCode.Text))
            {
                errorPostCode.SetError(textBoxPostalCode,
                    "Insert a proper Postal Code, ex. N2M 5H3");
                
            }

            //Check if phone matches requirements
            if (PhoneNumberValidation(textBoxPhone.Text))
            {
                if (!textBoxPhone.Text[3].Equals('-') ||
                    !textBoxPhone.Text[7].Equals('-'))
                {
                    textBoxPhone.Text = textBoxPhone.Text.Insert(3, "-");
                    textBoxPhone.Text = textBoxPhone.Text.Insert(7, "-");
                }
            }
            
            else
            {
                errorPhone.SetError(textBoxPhone,
                    "Insert a proper Phone ex. 123-123-1234");
            }

            //Check if province code matches requirements
            textBoxProvinceCode.Text = textBoxProvinceCode.Text.ToUpper();

            if(!ProvinceCodeValidation(textBoxProvinceCode.Text))
            {
                errorProvCode.SetError(textBoxProvinceCode,
                    "Insert a proper Province Code ex. ON");
            }

            //Check if email matches requirements
            textBoxEmail.Text = textBoxEmail.Text.ToLower();

            if (!EmailValidation(textBoxEmail.Text))
            {
                errorEmail.SetError(textBoxEmail, 
                    "Insert a proper email, ex. example@example.com");
            }
            else
            {
                errorEmail.SetError(textBoxEmail, "");
            }

            //Check if fee matches requirements
            if (IsNumber(textBoxFee.Text))
            {
                textBoxFee.Text = string.Format("{0:0.00}",
                    double.Parse(textBoxFee.Text));
            }
            else
            {
                errorFee.SetError(textBoxFee,
                    "Insert a proper fee, ex. 22 or -22");
            }
        }
    }
}
