using System.Windows.Forms;

namespace Main
{
    class Window
    {
        static Form window;

        public static void OpenWindow()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new Form();

            window.Text = "Roman Numeral Converter";

            Application.Run(window);
        }
    }
}