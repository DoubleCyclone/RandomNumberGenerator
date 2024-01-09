using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        /* Import register and unregister methods */
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        /* SPECIFY CONSTANTS */
        private const int MOD_NONE = 0x0000;
        private const int MOD_ALT = 0x0001;
        private const int MOD_CONTROL = 0x0002;
        private const int MOD_SHIFT = 0x0004;
        private const int MOD_WIN = 0x0008;
        private const int WM_HOTKEY = 0x0312;
        private const int HOTKEY_ID = 1;
        private const int HOTKEY2_ID = 2;

        /* OVERRIDE WNDPROC METHOD SO WE CAN LISTEN TO HOTKEYS */
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();

                if (id == HOTKEY_ID)
                {
                    button1.PerformClick();
                }
                else if (id == HOTKEY2_ID)
                {
                    button2.PerformClick();
                }
            }

            base.WndProc(ref m);
        }

        /* AMOUNT, MIN and MAX variables */
        int amount, min, max;

        /* URI ADDRESS */
        private static HttpClient sharedClient = new()
        {
            BaseAddress = new Uri("https://www.random.org"),
        };

        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new Size(330, 240);

            FormClosing += (s, e) => { UnregisterHotKey(Handle, HOTKEY_ID); };
            RegisterHotKey(Handle, HOTKEY_ID, MOD_CONTROL, (int)Keys.D1);
            RegisterHotKey(Handle, HOTKEY2_ID, MOD_CONTROL, (int)Keys.D2);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await GetAsync(sharedClient, 1, min, max);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await GetAsync(sharedClient, amount, min, max);
        }

        static async Task GetAsync(HttpClient httpClient, int amount, int min, int max)
        {
            /* ARRANGE COLUMN AMOUNT ACCORDING TO THE REQUIRED NUMBER AMOUNT */
            int colNum = 1;
            if (amount > 50)
            {
                colNum = (int)Math.Ceiling((double)amount / 50);
            }
            /* EXAMPLE */
            /* https://www.random.org/integers/?num=2&min=1&max=100&col=1&base=10&format=plain&rnd=new */

            /* GET REQUEST */
            using HttpResponseMessage response = await httpClient.GetAsync($"/integers/?num={amount}&min={min}&max={max}&col={colNum}&base=10&format=plain&rnd=new");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            MessageBox.Show($"{jsonResponse}\n", "Generated Numbers", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(amountMaskedTextBox.Text);
            min = Convert.ToInt32(lowerLimitMaskedTextBox.Text);
            max = Convert.ToInt32(upperLimitMaskedTextBox.Text);

            this.KeyPreview = true;
        }

        private void amountMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (amountMaskedTextBox.Text != String.Empty)
            {
                amount = Convert.ToInt32(amountMaskedTextBox.Text);
            }
        }

        private void lowerLimitMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lowerLimitMaskedTextBox.Text != String.Empty)
            {
                min = Convert.ToInt32(lowerLimitMaskedTextBox.Text);
            }
        }

        private void upperLimitMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (upperLimitMaskedTextBox.Text != String.Empty)
            {
                max = Math.Max(min + 1, Convert.ToInt32(upperLimitMaskedTextBox.Text));
            }
        }

        private void amountMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (amountMaskedTextBox.Text == String.Empty || Convert.ToInt32(amountMaskedTextBox.Text) < 1)
            {
                amount = 1;
                amountMaskedTextBox.Text = amount.ToString();
            }
        }
        private void lowerLimitMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (lowerLimitMaskedTextBox.Text == String.Empty)
            {
                min = 0;
                lowerLimitMaskedTextBox.Text = min.ToString();
            }
            else if (upperLimitMaskedTextBox.Text != String.Empty)
            {
                if (Convert.ToInt32(upperLimitMaskedTextBox.Text) < Convert.ToInt32(lowerLimitMaskedTextBox.Text))
                {
                    max = min + 1;
                    upperLimitMaskedTextBox.Text = max.ToString();
                }
            }
        }

        private void upperLimitMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (upperLimitMaskedTextBox.Text == String.Empty)
            {
                if (lowerLimitMaskedTextBox.Text == String.Empty)
                {
                    min = 0;
                    lowerLimitMaskedTextBox.Text = min.ToString();
                }
                max = min + 1;
                upperLimitMaskedTextBox.Text = max.ToString();
            }
            else if (lowerLimitMaskedTextBox.Text != String.Empty)
            {
                if (Convert.ToInt32(upperLimitMaskedTextBox.Text) < Convert.ToInt32(lowerLimitMaskedTextBox.Text))
                {
                    max = min + 1;
                    upperLimitMaskedTextBox.Text = max.ToString();
                }
            }
        }

        private void amountMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            amountMaskedTextBox.SelectionStart = amountMaskedTextBox.MaskedTextProvider.LastAssignedPosition + 1;
        }

        private void lowerLimitMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            lowerLimitMaskedTextBox.SelectionStart = lowerLimitMaskedTextBox.MaskedTextProvider.LastAssignedPosition + 1;
        }

        private void upperLimitMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            upperLimitMaskedTextBox.SelectionStart = upperLimitMaskedTextBox.MaskedTextProvider.LastAssignedPosition + 1;
        }
    }
}