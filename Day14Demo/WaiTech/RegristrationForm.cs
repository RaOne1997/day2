using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day14Demo.ArctechInfo;
using Day14Demo.ArctechInfo.Controls;
namespace Day14Demo.WaiTech
{
    internal class RegristrationForm : Window
    {
        private const string Heading = "FirstName,LastName,Age,Gender,City,State,Country,Univercity,WorkSpace\n";
        private const string FilePath = @"E:\Abhijeet warade\test\RegristrationlistData.csv";

        private readonly Label _labelFirstName, _labelLastName, _labelAge, _labelCity, _labelGender, _labelMale, _labelFemale,
            _labelState, _labelCountry, _labelUnivercity, _labelWorkSpace;
        private readonly TextBox _textBoxFirstName, _textBoxLastName, _textBoxAge, _textBoxCity, _textBoxState, _textBoxCountry, _textBoxUnivercity
            ,_textBoxWorkSpace;
        private readonly Checkbox _chkboxFemale, _chkBoxMale;
        private readonly Button _buttonSave, _buttonCancel, buttonRetry;

        private readonly Label _labelStatus;
        public RegristrationForm(string title, int left, int top)
            : base(title, left, top, 100, 20)
        {

            _labelFirstName = new Label("First Name:", 2, 2);
            _textBoxFirstName = new TextBox(15, 2, 25);

            _labelLastName = new Label("Last Name:", 45, 2);
            _textBoxLastName = new TextBox(58, 2, 25);

            _labelAge = new Label("Age:", 2, 4);
            _textBoxAge = new TextBox(15, 4, 10);

           

            _labelCity = new Label("City:", 2, 6);
            _textBoxCity = new TextBox(15, 6, 25);

            _labelState = new Label("State:", 45, 6);
            _textBoxState = new TextBox(58, 6, 30);

            _labelCountry = new Label("Country:", 2, 8);
            _textBoxCountry = new TextBox(15, 8, 25);

            _labelUnivercity = new Label("Univercity:", 45, 8);
            _textBoxUnivercity = new TextBox(58, 8, 40);

           _labelWorkSpace = new Label("Workspace:", 2, 10);
            _textBoxWorkSpace = new TextBox(15, 10, 25);


            //Checkbox
            _labelGender = new Label("Gender:", 45, 4);
            _labelMale = new Label("Male:", 55, 4);
            _chkBoxMale = new Checkbox(62, 4, 2);
            _chkBoxMale.OnClicked += ButtonCheckOnOnClicked;

            _labelFemale = new Label("Female:", 67, 4);
            _chkboxFemale = new Checkbox(76, 4, 2);
            _chkboxFemale.OnClicked += ButtonCheckOnOnClicked;

            //button

            _buttonSave = new Button("Save Resume", 75, 16);
            _buttonSave.OnClicked += ButtonSaveOnOnClicked;

            _buttonCancel = new Button("Cancel", 89, 16);
            _buttonCancel.OnClicked += ButtonCancelOnOnClicked;

            buttonRetry = new Button("Retry", 67, 16);
            // buttonRetry.OnClicked += ButtonCancelOnOnClicked;


            _labelStatus = new Label("Resume Form Initialized. Please enter your Resume.", 1, 18, 98);
            _labelStatus.SetColor(ConsoleColor.Black, ConsoleColor.Yellow);

            InitializeControl();
        }
        private void InitializeControl()
        {
            AddControl(_labelFirstName);
            AddControl(_textBoxFirstName);

            AddControl(_labelLastName);
            AddControl(_textBoxLastName);

            AddControl(_labelAge);
            AddControl(_textBoxAge);

            AddControl(_labelGender);
            AddControl(_labelMale);
            AddControl(_chkBoxMale);
            AddControl(_labelFemale);
            AddControl(_chkboxFemale);

            AddControl(_labelCity);
            AddControl(_textBoxCity);

            AddControl(_labelState);
            AddControl(_textBoxState);



            AddControl(_labelCountry);
            AddControl(_textBoxCountry);

            AddControl(_labelUnivercity);
            AddControl(_textBoxUnivercity);

            AddControl(_labelWorkSpace);
            AddControl(_textBoxWorkSpace);




            AddControl(_buttonSave);
            AddControl(_buttonCancel);
            AddControl(buttonRetry);

            AddControl(_labelStatus);
        }

        private void ButtonCheckOnOnClicked(object? sender, EventArgs e)
        {
            if (sender == _chkBoxMale)
            {
                _chkBoxMale.Text = "[M]";
                _chkBoxMale.Show();
                return;
            }else if (sender == _chkboxFemale)
            {
                _chkboxFemale.Text = "[F]";
                _chkboxFemale.Show();
                return;

            }

        }

        private void ButtonCancelOnOnClicked(object? sender, EventArgs e)
        {
            Close();
        }
        private void ButtonretryOnOnClicked(object? sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSaveOnOnClicked(object? sender, EventArgs e)
        {
            string data;
            string gens= null;

            if (_textBoxFirstName.Text == "")
            {
                _textBoxFirstName.Focus();
                _labelStatus.Text = $"Please Enter First Name  ";
                _labelStatus.Show();
                return;
            }
            else if (_textBoxLastName.Text == "")
            {
                _textBoxLastName.Focus();
                _labelStatus.Show();
                return;
            }
            else if (_textBoxAge.Text == "")
            {
                _textBoxAge.Focus();
                _labelStatus.Show();
                return;
            }
            else if (_textBoxCity.Text == "")
            {
                _textBoxCity.Focus();
                _labelStatus.Show();
                return;

            }
            else
            {
               
                if(_chkBoxMale.Text != null)
                {
                    gens = "M";
                }else if (_chkboxFemale.Text != null)
                {

                    gens = "F";
                }
                data = $"{_textBoxFirstName.Text},{_textBoxLastName.Text},{_textBoxAge.Text},{_textBoxCity.Text},{gens}\n";


                if (!File.Exists(FilePath))
                    File.WriteAllText(FilePath, Heading);

                try
                {
                    File.AppendAllText(FilePath, data);
                    _labelStatus.Text = $"File successfully saved at {FilePath}";
                }
                catch (Exception exception)
                {
                    _labelStatus.Text = $"Error Saving File. {exception.Message}";
                }
            }
            _labelStatus.Show();
        }
    }
}
