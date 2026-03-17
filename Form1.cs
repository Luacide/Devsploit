using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Devsploit
{
    public partial class Form1 : Form
    {
        // --- WRD API DLLImports ---
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit();

        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SendLuaCScript(string script);

        // --- Window Dragging DLLImports ---
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        // --- Window Controls ---
        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e) // Close Button
        {
            Application.Exit();
        }

        // --- Main Functions ---
        private async void Inject_Click(object sender, EventArgs e)
        {
            // 1. Set to Yellow and "In-progress"
            attachwarn.Text = "In-progress";
            attachwarn.ForeColor = System.Drawing.Color.Yellow;

            // Small delay so you can actually see the "In-progress" state
            await System.Threading.Tasks.Task.Delay(1000);

            // 2. Try to launch the exploit
            if (LaunchExploit())
            {
                // 3. Success: Green and "Attached"
                attachwarn.Text = "Attached";
                attachwarn.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // 4. Failure: Red and "Not Attached" (or "Failed")
                attachwarn.Text = "Not Attached";
                attachwarn.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            SendLuaCScript(text.Text); // Sends the code from your textbox to the game
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                text.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, text.Text);
            }
        }

        private void gl_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Search for a URL in your textbox using Regex
                string pattern = @"(http|https)://[^\s]+";
                System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(text.Text, pattern);

                if (match.Success)
                {
                    string url = match.Value;

                    // 2. Download the content from that URL
                    using (System.Net.WebClient wc = new System.Net.WebClient())
                    {
                        string downloadedCode = wc.DownloadString(url);

                        // 3. Put the downloaded code into your executor
                        text.Text = downloadedCode;
                    }
                }
                else
                {
                    MessageBox.Show("No valid URL found in the text box!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load script: " + ex.Message);
            }
        }

        private void killrb_Click(object sender, EventArgs e)
        {
            // Define the common process names for the Roblox player
            string[] robloxProcesses = { "RobloxPlayerBeta", "RobloxPlayerLauncher" };

            foreach (string procName in robloxProcesses)
            {
                // Get all running instances of that process name
                foreach (Process process in Process.GetProcessesByName(procName))
                {
                    try
                    {
                        process.Kill(); // Forcefully stop the process
                        process.WaitForExit(); // Ensure it is fully closed before moving on
                    }
                    catch (Exception ex)
                    {
                        // This prevents the app from crashing if it can't kill a specific instance
                        MessageBox.Show("Could not kill process: " + ex.Message);
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text.Clear();
        }

        private void openoutput_Click(object sender, EventArgs e)
        {
            // This Lua script toggles the Developer Console visibility via StarterGui
            string toggleConsoleScript = @"
        local StarterGui = game:GetService('StarterGui')
        local success, isVisible = pcall(function() 
            return StarterGui:GetCore('DevConsoleVisible') 
        end)
        
        if success then
            StarterGui:SetCore('DevConsoleVisible', not isVisible)
        else
            -- If getting status fails, just force it to open
            StarterGui:SetCore('DevConsoleVisible', true)
        end
    ";

            SendLuaCScript(toggleConsoleScript);
        }
    }
}
