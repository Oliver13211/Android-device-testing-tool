using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Android_test_tool_for_c_sharp;

public partial class Form1 : Form
{
    Form2 form2;
    string d;
    Error error;

    public Form1()
    {
        InitializeComponent();
        form2 = new Form2();
        error = new Error();
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        if (numericUpDown1.Value > 20)
        {
            numericUpDown1.Value = 1;
        }
        else if (numericUpDown1.Value < 1)
        {
            numericUpDown1.Value = 20;
        }
    }

    private void dataReceived(object sender, DataReceivedEventArgs outLine)
    {
        if (!string.IsNullOrEmpty(outLine.Data))
        {
            Action<string> showUi = (b) =>
            {
                textBox1.Text += b + "\r\n";
            };
            textBox1.Invoke(showUi, new object[] { outLine.Data });
        }
    }

    private void getdata(object sender, DataReceivedEventArgs outLine)
    {
        d = outLine.Data;
    }

    private void geterror(object sender, DataReceivedEventArgs outLine)
    {
        d = outLine.Data;
    }

    private void errorReceived(object sender, DataReceivedEventArgs outLine)
    {
        if (!string.IsNullOrEmpty(outLine.Data))
        {
            Action<string> showUi = (b) =>
            {
                textBox1.Text += b + "\r\n";
            };
            textBox1.Invoke(showUi, new object[] { outLine.Data });
        }
    }

    public async Task<Task> AsyncRunADB(string arguments, DataReceivedEventHandler dataReceivedEventHandler, DataReceivedEventHandler errorDataReceivedEventHandler)
    {
        string cmd = Application.StartupPath + "\\adb_fastboot\\adb.exe";
        //string cmd = "dir";
        Process p = new Process();
        p.StartInfo.FileName = cmd;
        p.StartInfo.Arguments = arguments;
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
        p.StartInfo.StandardErrorEncoding = Encoding.UTF8;
        p.OutputDataReceived += dataReceivedEventHandler;
        p.ErrorDataReceived += errorDataReceivedEventHandler;
        p.Start();
        p.BeginErrorReadLine();
        p.BeginOutputReadLine();
        await p.WaitForExitAsync();
        p.Close();
        return Task.CompletedTask;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        Action showUi = () =>
        {
            statusStrip1.Text = "正在执行操作";
        };
        statusStrip1.Invoke(showUi);
        for (int i = 1; i <= (int)numericUpDown1.Value; i++)
        {
            await AsyncRunADB("reboot", dataReceived, errorReceived);
            while (true)
            {
                await AsyncRunADB("get-state", getdata, geterror);
                if (d == "device")
                {
                    break;
                }
                else
                {
                    if ((int)numericUpDown1.Value == 1)
                    {
                        var sl = Task.Run(() =>
                        {
                            Task.Delay(100000);
                        });
                    }
                }
            }
        }
        Action showUi2 = () =>
        {
            statusStrip1.Text = "准备就绪";
        };
        statusStrip1.Invoke(showUi2);
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        form2.ShowDialog();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            FileStream fs = File.Create(saveFileDialog1.FileName);
            try
            {
                byte[] texts = new UTF8Encoding(true).GetBytes(textBox1.Text);
                fs.WriteAsync(texts, 0, texts.Length);
            }
            catch (Exception)
            {

            }
            fs.Close();
        }
        else
        {
            error.ShowDialog();
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        await AsyncRunADB("shell cat /proc/cpuinfo", dataReceived, errorReceived);
    }
}