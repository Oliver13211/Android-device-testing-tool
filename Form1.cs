/* Copyright (c) 2023 Oliver
   AndroidTestingTool is licensed under Mulan PSL v2.
   You can use this software according to the terms and conditions of the Mulan PSL v2. 
   You may obtain a copy of Mulan PSL v2 at:
            http://license.coscl.org.cn/MulanPSL2 
   THIS SOFTWARE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO NON-INFRINGEMENT, MERCHANTABILITY OR FIT FOR A PARTICULAR PURPOSE.  
   See the Mulan PSL v2 for more details.  


                     Mulan Permissive Software License，Version 2

   Mulan Permissive Software License，Version 2 (Mulan PSL v2)
   January 2020 http://license.coscl.org.cn/MulanPSL2

   Your reproduction, use, modification and distribution of the Software shall be subject to Mulan PSL v2 (this License) with the following terms and conditions: 
   
   0. Definition
   
      Software means the program and related documents which are licensed under this License and comprise all Contribution(s). 
   
      Contribution means the copyrightable work licensed by a particular Contributor under this License.
   
      Contributor means the Individual or Legal Entity who licenses its copyrightable work under this License.
   
      Legal Entity means the entity making a Contribution and all its Affiliates.
   
      Affiliates means entities that control, are controlled by, or are under common control with the acting entity under this License, ‘control’ means direct or indirect ownership of at least fifty percent (50%) of the voting power, capital or other securities of controlled or commonly controlled entity.

   1. Grant of Copyright License

      Subject to the terms and conditions of this License, each Contributor hereby grants to you a perpetual, worldwide, royalty-free, non-exclusive, irrevocable copyright license to reproduce, use, modify, or distribute its Contribution, with modification or not.

   2. Grant of Patent License 

      Subject to the terms and conditions of this License, each Contributor hereby grants to you a perpetual, worldwide, royalty-free, non-exclusive, irrevocable (except for revocation under this Section) patent license to make, have made, use, offer for sale, sell, import or otherwise transfer its Contribution, where such patent license is only limited to the patent claims owned or controlled by such Contributor now or in future which will be necessarily infringed by its Contribution alone, or by combination of the Contribution with the Software to which the Contribution was contributed. The patent license shall not apply to any modification of the Contribution, and any other combination which includes the Contribution. If you or your Affiliates directly or indirectly institute patent litigation (including a cross claim or counterclaim in a litigation) or other patent enforcement activities against any individual or entity by alleging that the Software or any Contribution in it infringes patents, then any patent license granted to you under this License for the Software shall terminate as of the date such litigation or activity is filed or taken.

   3. No Trademark License

      No trademark license is granted to use the trade names, trademarks, service marks, or product names of Contributor, except as required to fulfill notice requirements in Section 4.

   4. Distribution Restriction

      You may distribute the Software in any medium with or without modification, whether in source or executable forms, provided that you provide recipients with a copy of this License and retain copyright, patent, trademark and disclaimer statements in the Software.

   5. Disclaimer of Warranty and Limitation of Liability

      THE SOFTWARE AND CONTRIBUTION IN IT ARE PROVIDED WITHOUT WARRANTIES OF ANY KIND, EITHER EXPRESS OR IMPLIED. IN NO EVENT SHALL ANY CONTRIBUTOR OR COPYRIGHT HOLDER BE LIABLE TO YOU FOR ANY DAMAGES, INCLUDING, BUT NOT LIMITED TO ANY DIRECT, OR INDIRECT, SPECIAL OR CONSEQUENTIAL DAMAGES ARISING FROM YOUR USE OR INABILITY TO USE THE SOFTWARE OR THE CONTRIBUTION IN IT, NO MATTER HOW IT’S CAUSED OR BASED ON WHICH LEGAL THEORY, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.

   6. Language

      THIS LICENSE IS WRITTEN IN BOTH CHINESE AND ENGLISH, AND THE CHINESE VERSION AND ENGLISH VERSION SHALL HAVE THE SAME LEGAL EFFECT. IN THE CASE OF DIVERGENCE BETWEEN THE CHINESE AND ENGLISH VERSIONS, THE CHINESE VERSION SHALL PREVAIL.

   END OF THE TERMS AND CONDITIONS

   How to Apply the Mulan Permissive Software License，Version 2 (Mulan PSL v2) to Your Software

      To apply the Mulan PSL v2 to your work, for easy identification by recipients, you are suggested to complete following three steps:

      i Fill in the blanks in following statement, including insert your software name, the year of the first publication of your software, and your name identified as the copyright owner; 

      ii Create a file named “LICENSE” which contains the whole context of this License in the first directory of your software package;

      iii Attach the statement to the appropriate annotated syntax at the beginning of each source file.


   Copyright (c) 2023 Oliver
   AndroidTestingTool is licensed under Mulan PSL v2.
   You can use this software according to the terms and conditions of the Mulan PSL v2. 
   You may obtain a copy of Mulan PSL v2 at:
               http://license.coscl.org.cn/MulanPSL2 
   THIS SOFTWARE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO NON-INFRINGEMENT, MERCHANTABILITY OR FIT FOR A PARTICULAR PURPOSE.  
   See the Mulan PSL v2 for more details.
*/
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
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
            int j = 0;
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
                    if (numericUpDown1.Value != 1)
                    {
                        if (j == 10)
                        {
                            Action action = () =>
                            {
                                textBox1.Text = textBox1.Text + "设备脱机时间过长，自动停止运行任务\r\n";
                            };
                            textBox1.Invoke(action);
                            break;
                        }
                        else
                        {
                            var sl = Task.Run(() =>
                            {
                                Task.Delay(20000);
                            });
                        }
                    }
                    else
                    {
                        break;
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

    private async void toolStripButton3_Click(object sender, EventArgs e)
    {
        await AsyncRunADB("kill-server", getdata, geterror);
    }
}