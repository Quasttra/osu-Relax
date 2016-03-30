using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace osu_Relax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IO_Console();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IO_Console();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public string cmd_console;
        public void IO_Console()
        {
            cmd_console = textBox1.Text.ToLower();
            textBox1.Text = "";

            int process_osu;

            if (!string.IsNullOrEmpty(cmd_console) && !string.IsNullOrWhiteSpace(cmd_console))
            {
                switch (cmd_console)
                {
                    default:
                        console_listbox.Items.Add("You are mistaken, buddy. Try enter 'help' for... help, of course!");
                        break;
                    case "help":
                        console_listbox.Items.Add("Update - This command updating song list");
                        console_listbox.Items.Add("Clear - Clean up after you, slut");
                        console_listbox.Items.Add("Start - Lets rock!(Running relax mode)");
                        console_listbox.Items.Add("Exit - Good bye, see you!");
                        break;
                    case "start":
                        process_osu = Process.GetProcessesByName("osu!").Length;
                        if(process_osu != 0)
                        {
                            console_listbox.Items.Add("Process found!");
                        } else
                        {
                            console_listbox.Items.Add("Process NOT found, try again!");
                        }
                        break;
                    case "clear":
                        console_listbox.Items.Clear();
                        break;
                    case "exit":
                        Application.Exit();
                        break;
                }
            }
        }
    }
}
