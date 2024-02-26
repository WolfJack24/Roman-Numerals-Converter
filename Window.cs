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
                Text = "",
                Size = new Size(121, 21),
                Location = new Point(80, 150)
            };

            result = new Label
            {
                Text = "",
                Size = new Size(121, 21),
                Location = new Point(80, 175)
            };

            originalInput.AutoSize = true;
            result.AutoSize = true;

            window.Controls.Add(roman);
            window.Controls.Add(convertBtn);
            window.Controls.Add(originalInput);
            window.Controls.Add(result);

            Application.Run(window);
        }
    }
}