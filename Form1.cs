using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Android_test_tool_for_c_sharp;

public partial class Form1 : Form
{
    Form2 form2;

    public Form1()
    {
        InitializeComponent();
        form2 = new Form2();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

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
        p.StartInfo.FileName = cmd;           //�趨������  
        p.StartInfo.Arguments = arguments;    //�趨��ʽִ�Ѕ���  
        p.StartInfo.UseShellExecute = false;        //�ر�Shell��ʹ��  
        p.StartInfo.RedirectStandardInput = true;   //�ض����׼����  
        p.StartInfo.RedirectStandardOutput = true;  //�ض����׼���  
        p.StartInfo.RedirectStandardError = true;   //�ض���������  
        p.StartInfo.CreateNoWindow = true;          //���ò���ʾ����  
        p.StartInfo.StandardOutputEncoding = Encoding.UTF8; // ָ�����������Ϊ UTF-8
        p.StartInfo.StandardErrorEncoding = Encoding.UTF8; // ָ���������������Ϊ UTF-8
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
        for (int i = 1; i <= (int)numericUpDown1.Value; i++)
        {
            await AsyncRunADB("reboot", dataReceived, errorReceived);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        FileStream fs = File.Create(Application.StartupPath + "log.txt");
        try
        {
            byte[] texts = new UTF8Encoding(true).GetBytes(textBox1.Text);
            fs.WriteAsync(texts, 0, texts.Length);
        }
        catch (Exception)
        {
            throw;
        }
        fs.Close();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        form2.ShowDialog();
    }
}