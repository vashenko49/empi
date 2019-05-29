using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string folder_directori = "select";
        List<string> list_adress_file = new List<string>();
        decimal classesCount = 0;
        decimal packageCount = 0;
        decimal methodsCount = 0;
        decimal codeLinesCount = 0;
        decimal fullcodeLinesCount = 0;
        decimal methodPNAS = 0;
        decimal countWMC = 0;
        decimal countTCC = 0;
        decimal countCALL = 0;
        decimal countNDD = 0;
        public Form1()
        {
            InitializeComponent();
            textBox_address_folder.Text = folder_directori;
            progressBar_count.Value = 0;
        }
        private void UpdateProgressBar(int percentage)
        {
            progressBar_count.Value = percentage;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        static string[] SearchFile(string patch, string pattern)
        {
            /*флаг SearchOption.AllDirectories означает искать во всех вложенных папках*/
            string[] ReultSearch = Directory.GetFiles(patch, pattern, SearchOption.AllDirectories);
            //возвращаем список найденных файлов соответствующих условию поиска 
            return ReultSearch;
        }
        /*функция нахождения директорий по указанному пути*/
        static string[] SearchDirectory(string patch)
        {
            //находим все папки в по указанному пути
            string[] ReultSearch = Directory.GetDirectories(patch);
            //возвращаем список директорий
            return ReultSearch;
        }
        private void button_find_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBox_address_folder.Text= folder_directori= FBD.SelectedPath;
            }

        }

        private void button_START_Click(object sender, EventArgs e)
        {

            UpdateProgressBar(3);
            //ищем все вложенные папки 
            string[] S = SearchDirectory(folder_directori);
            foreach (string folderPatch in S)
            {
                //добавляем новую строку в список
                // ListPatch += folderPatch + "\n";
                try
                {
                    //пытаемся найти данные в папке 
                    string[] F = SearchFile(folderPatch, "*.java");
                    foreach (string FF in F)
                    {
                        //добавляем файл в список 
                        list_adress_file.Add(FF);
                    }
                }
                catch
                {
                }
            }

            foreach (string i in list_adress_file)
            {
                using (StreamReader sr = new StreamReader(i, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ++fullcodeLinesCount;
                    }
                }
            }


            UpdateProgressBar(33);
            if (list_adress_file.Count == 0 || folder_directori=="" || folder_directori== "select" || textBox_address_folder.Text==""|| textBox_address_folder.Text =="select")
            {
                MessageBox.Show("Select directory");
            }
            else
            {
                foreach( var file in list_adress_file)
                {
                    String arrayLine = File.ReadAllText(file);
                    String clearfile = clearCode(arrayLine);
                    clearfile = Regex.Replace(clearfile, @"\r\n", "");
                    clearfile = Regex.Replace(clearfile, @"\t", " ");
                    clearfile = Regex.Replace(clearfile, @"\s{2,}", " ");
                    clearfile = Regex.Replace(clearfile, @"(\W) ", "$1");
                    clearfile = Regex.Replace(clearfile, @" (\W)", "$1");

                    //количество классов
                    int NOC = Regex.Matches(clearfile, @"\b(class) \w+\b").Count;
                    classesCount += NOC;
                    //количество методов
                    int NOM = Regex.Matches(clearfile, @"(public|protected|private|static|\s) +[\w\<\>\[\]]+\s+(\w+) *\([^\)]*\) *(\{?|[^;])").Count;
                    methodsCount += NOM;
                    //PNAS
                    int PNAS = Regex.Matches(clearfile, @"(public|static|\s) +[\w\<\>\[\]]+\s+(\w+) *\([^\)]*\) *(\{?|[^;])").Count;
                    methodPNAS += PNAS;


                    UpdateProgressBar(66);

                    //количество пакетов
                    int NOP = Regex.Matches(clearfile, @"^(package)\s?[\w.]+;").Count;
                    packageCount += NOP;
                    //количество строчек кода
                    int LOC = Regex.Matches(clearfile, @";").Count;
                    codeLinesCount += LOC;
                    //WMC
                    int WMC = Regex.Matches(clearfile, @"\b\w+(int|boolean|try|do|while|catch|double|float|exit|this|else|switch|break|return|catch|finally)\b").Count;
                    countWMC += WMC;
                    //TCC
                    int TCC= Regex.Matches(clearfile, @"(public|static|\s) +[\w\<\>\[\]]+\s+(\w+) *\([^\)]*\) *(\{?|[^;])").Count;
                    if (TCC == 0)
                    {
                        countTCC += 0;
                    }
                    else
                    {
                        countTCC += NOC/TCC;
                    }
                    //CALL
                    int CALL = 0;
                    foreach(Match match in Regex.Matches(clearfile, @"\b\w+(public|protected|private|static|\s)\b"))
                    {

                        CALL += Regex.Matches(clearfile,match.Value).Count;
                    }
                    countCALL += CALL;
                    int NDD = 0;
                    foreach (Match match in Regex.Matches(clearfile, @"\b\w+(class|\s)\b"))
                    {

                        NDD += Regex.Matches(clearfile, match.Value).Count;
                    }
                    countNDD += NDD;
                }


            }
            UpdateProgressBar(80);
            label_count_files.Text = Convert.ToString(list_adress_file.Count);
            label_LOC.Text = Convert.ToString(codeLinesCount);
            label_NOM.Text = Convert.ToString(methodsCount);
            label_NOC.Text = Convert.ToString(classesCount);
            label_NOP.Text = Convert.ToString(packageCount);

            if (countNDD != 0)
            {
                label_NDD.Text = Convert.ToString(Math.Round(classesCount / countNDD, 6));
            }
            else
            {
                label_NDD.Text = Convert.ToString(0);
            }
            if (countCALL != 0)
            {
                label_CALL.Text = Convert.ToString(Math.Round(methodsCount / countCALL, 6));
            }
            else
            {
                label_CALL.Text = Convert.ToString(0);
            }
            if (countWMC != 0)
            {
                label_WMC.Text = Convert.ToString(Math.Round(methodsCount / countWMC, 4));
            }
            else
            {
                label_WMC.Text = Convert.ToString(0);
            }
            if(methodsCount!=0){
                label_PNAS.Text = Convert.ToString(Math.Round(methodPNAS / methodsCount, 4));
            }
            else
            {
                label_PNAS.Text = Convert.ToString(0);
            }
            UpdateProgressBar(94);
            if (list_adress_file.Count != 0)
            {
                label_TCC.Text = Convert.ToString(Math.Round(countTCC / list_adress_file.Count, 4));
            }
            else
            {
                label_TCC.Text = Convert.ToString(0);
            }

            label_full_LOC.Text = Convert.ToString(fullcodeLinesCount);

            UpdateProgressBar(100);
        }

        private string clearCode(string source)
        {
            var result = new StringBuilder();
            for (int i = 0; i < source.Length;)
            {
                if (TryRead(source, ref i, "//")) { GoTo(source, ref i, "\r\n"); result.AppendLine(); }
                else
                if (TryRead(source, ref i, "/*")) GoTo(source, ref i, "*/");
                else
                if (TryRead(source, ref i, "@\"")) { GoTo(source, ref i, "\"", "\"\""); result.Append("\"\""); }
                else
                if (TryRead(source, ref i, "\"")) { GoTo(source, ref i, "\"", "\\\""); result.Append("\"\""); }
                else
                {
                    result.Append(source[i]);
                    i++;
                }
            }
            return result.ToString();
        }

        private static void GoTo(string s, ref int i, string pattern, string skip = null)
        {
            for (; i < s.Length; i++)
            {
                if (!String.IsNullOrEmpty(skip))
                    while (TryRead(s, ref i, skip)) ;
                if (TryRead(s, ref i, pattern)) break;
            }
        }

        static bool TryRead(string s, ref int pos, string pattern)
        {
            if (pattern.Length == 0) return true;

            for (int i = 0; i < pattern.Length; i++)
                if (pos + i >= s.Length || s[pos + i] != pattern[i])
                    return false;

            pos += pattern.Length;
            return true;
        }
    }
}

