using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;

namespace _12._09reg
{
    public partial class Form1 : Form
    {
        string path = @"Software\MyWindowsFormsApp";

        public Form1()
        {
            InitializeComponent();
            //string color = ReadRegistryValue(path, "TextColor", "Black");
            //int size = ReadRegistryValue(path, "TextSize", 12);
            LoadSettings();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string color = colorChoose.Text;
            int size = int.Parse(sizeChoose.Text);
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(path))
            {
                if (key != null)
                {
                    key.SetValue("TextColor", color);
                    key.SetValue("TextSize", size);
                }
            }
            changeSettings(color, size);
            MessageBox.Show("Settings saved");
        }
        private void LoadSettings()
        {
            string color = "Black";
            int size = 12;

            using (RegistryKey key =
                Registry.CurrentUser.OpenSubKey(path))
            {
                if (key != null)
                {
                    object colorValue = key.GetValue("TextColor");
                    object sizeValue = key.GetValue("TextSize");

                    if (colorValue != null)
                    {
                        color = colorValue.ToString();
                    }

                    if (sizeValue != null)
                    {
                        size = Convert.ToInt32(sizeValue);
                    }
                }
            }

            colorChoose.Text = color;
            sizeChoose.Text = size.ToString();
        }
        private void changeSettings(string color, int size)
        {
            if (color == "Black")
            {
                settingsLabel.ForeColor = Color.Black;
                colorLabel.ForeColor = Color.Black;
                sizeLabel.ForeColor = Color.Black;
            }
            else if (color == "Grey")
            {
                settingsLabel.ForeColor = Color.Gray;
                colorLabel.ForeColor = Color.Gray;
                sizeLabel.ForeColor = Color.Gray;
            }
            else if (color == "Red")
            {
                settingsLabel.ForeColor = Color.Red;
                colorLabel.ForeColor = Color.Red;
                sizeLabel.ForeColor = Color.Red;
            }
            else if (color == "Blue")
            {
                settingsLabel.ForeColor = Color.Blue;
                colorLabel.ForeColor = Color.Blue;
                sizeLabel.ForeColor = Color.Blue;
            }
            else if (color == "Green")
            {
                settingsLabel.ForeColor = Color.Green;
                colorLabel.ForeColor = Color.Green;
                sizeLabel.ForeColor = Color.Green;
            }

            settingsLabel.Font = new Font(settingsLabel.Font.FontFamily, size);
            colorLabel.Font = new Font(colorLabel.Font.FontFamily, size);
            sizeLabel.Font = new Font(sizeLabel.Font.FontFamily, size);
            okButton.Font = new Font(okButton.Font.FontFamily, size);
        }
    }
}
