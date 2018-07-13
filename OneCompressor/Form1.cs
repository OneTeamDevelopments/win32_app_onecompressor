using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OneCompressor
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void materialRaisedButton2_Click(object sender, System.EventArgs e)
        {
            progress.Value = 0;
            status.Text = "";
            OpenFileDialog input = new OpenFileDialog();
            input.Filter = "OT Bin Dosyaları (*.otbin)|*.otbin";
            input.Title = "Çıkartılacak Dosyayı Seçin";
            input.ShowDialog();

            FolderBrowserDialog output = new FolderBrowserDialog();
            output.Description = "Kaydedilecek Klasörü Seçin";
            output.ShowDialog();

            if (input.FileNames.Length != 0 && output.SelectedPath != "")
            {
                progress.Value = 10;
                status.Text = "Dosyalar çıkartılıyor.";
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "library/onelabs.exe",
                        Arguments = "x -y -o " + output.SelectedPath + " " + input.FileName + " *",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                proc.Start();
                proc.WaitForExit();
                progress.Value = 100;
                status.Text = "Dosyalar çıkartıldı.";
            }
            else
            {
                MessageBox.Show("Dosya seçilmedi.");
            }
        }

        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            if (fileTable.Rows.Count != 0)
            {
                progress.Value = 0;
                status.Text = "";

                if (rom.Text != "" && romVersion.Text != "" && device.Text != "" && deviceCode.Text != "")
                {
                    SaveFileDialog output = new SaveFileDialog();
                    output.Title = "Kaydedilecek Dosyayı Belirtin";
                    output.Filter = "OT Bin Dosyaları (*.otbin)|*.otbin";
                    output.ShowDialog();

                    if (output.FileName != "")
                    {
                        string compressFiles = " rom.ini";
                        ArrayList ABParts = new ArrayList();

                        foreach (DataGridViewRow row in fileTable.Rows)
                        {
                            string ab = row.Cells[2].Value.ToString();
                            compressFiles += " " + row.Cells[0].Value.ToString();
                            if (ab == "1") ABParts.Add(row.Cells[1].Value.ToString());
                        }
                       
                        var ini = new IniFile("rom.ini");
                        ini.Write("romName", rom.Text);
                        ini.Write("romVersion", romVersion.Text);
                        ini.Write("deviceName", device.Text);
                        ini.Write("deviceCode", deviceCode.Text);
                        ini.Write("abParts", string.Join("|",ABParts.ToArray()));

                        progress.Value = 10;
                        status.Text = "Dosya listesi hazırlanıyor.";
                        
                        progress.Value = 20;
                        status.Text = "Dosyalar sıkıştırılıyor.";
                        var proc = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "library/onelabs.exe",
                                Arguments = "a -y " + output.FileName + " " + compressFiles,
                                UseShellExecute = false,
                                CreateNoWindow = true
                            }
                        };
                        proc.Start();
                        proc.WaitForExit();
                        progress.Value = 100;
                        status.Text = "Dosyalar sıkıştırıldı.";
                        File.Delete("rom.ini");
                    }
                    else
                    {
                        MessageBox.Show("Dosya seçilmedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Rom bilgilerini girin.");
                }
            }
            else
            {
                MessageBox.Show("Sıkıştırılacak dosya yok.");
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, System.EventArgs e)
        {
                progress.Value = 0;
                status.Text = "";
                OpenFileDialog input = new OpenFileDialog();
                input.Title = "Sıkıştırılacak Dosyaları Seçin";
                input.Multiselect = true;
                input.ShowDialog();

                if (input.FileNames.Length != 0)
                {
                fileTable.Rows.Clear();
                foreach (string file in input.FileNames)
                {
                    fileTable.Rows.Add(file, Path.GetFileName(file), false);
                }
                }
                else
                {
                    MessageBox.Show("Dosya seçilmedi.");
                }
            }
        }
    }
