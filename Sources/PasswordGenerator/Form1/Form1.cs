using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password.Text = Password.Generate((uint) lengthPassword.Value);
        }
    }

    class Password
    {
        private static readonly string _upperCase = "ABCDEFGHIKLMNOPQRSTVWXYZ";
        private static readonly string _lowerCase = _upperCase.ToLower();
        private static readonly string _digits = "0123456789";
        private static readonly string _symbols = "!@#$%^&*_-=+";
        private static readonly string _combined = _upperCase + _lowerCase + _digits + _symbols;
        private static Random rand = new();

        public static string Generate(uint length)
        {
            StringBuilder stringBuilder = new();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(_combined[rand.Next(_combined.Length)]);
            }
            return stringBuilder.ToString();
        }
    }
}