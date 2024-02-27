using System;
using System.Windows.Forms;
using System.Drawing;

namespace Main
{
    class Window
    {
        static Form window;
        static TextBox roman;
        static Button convertBtn;
        static Label originalInput;
        static Label result;

        static void _convertBtn_Click(object sender, EventArgs e)
        {
            string romanNumerals = roman.Text;

            if (romanNumerals == "")
            {
                MessageBox.Show("No Roman Numerals Found!");
            }
            else
            {
                var (numberResult, originalRomanNumerals) = Program.RomanToNumber(romanNumerals);
                originalInput.Text = "Input: " + originalRomanNumerals;
                result.Text = "Output: " + numberResult;
            }

        }

        public static void OpenWindow()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new Form
            {
                Text = "Roman Numeral Converter"
            };

            roman = new TextBox
            {
                Size = new Size(121, 21),
                Location = new Point(80, 25)
            };

            convertBtn = new Button
            {
                Text = "Convert!",
                Size = new Size(121, 21),
                Location = new Point(80, 75) 
            };

            originalInput = new Label
            {
                Text = "Input: ",
                Size = new Size(121, 21),
                Location = new Point(80, 150)
            };

            result = new Label
            {
                Text = "Output: ",
                Size = new Size(121, 21),
                Location = new Point(80, 175)
            };

            originalInput.AutoSize = true;
            result.AutoSize = true;

            convertBtn.Click += new EventHandler(_convertBtn_Click);

            window.Controls.Add(roman);
            window.Controls.Add(convertBtn);
            window.Controls.Add(originalInput);
            window.Controls.Add(result);

            Application.Run(window);
        }
    }
}