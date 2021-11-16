using System;
using System.Windows;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       private void RunCmd (Object sender, RoutedEventArgs e)
        {
            string gitClone = "git clone ";

            if (directory.Text != "" || txtName.Text != "")
            {
                Process test = new Process();
                test.StartInfo.FileName = "cmd.exe";
                test.StartInfo.UseShellExecute = true;
                test.StartInfo.WorkingDirectory = directory.Text;
                test.StartInfo.Arguments = "/c "+gitClone+txtName.Text;
                test.StartInfo.RedirectStandardOutput = false;
                test.Start();
            }
            else
            {
              
                textbox.Text = "Lien ou chemin du dossier manquant";
               
            }
           
            
           
        }

        private void RunGitAdd(Object sender, RoutedEventArgs e)
        {
            string gitAdd = "git add .";

            Process add = new Process();
            add.StartInfo.FileName = "cmd.exe";
            add.StartInfo.UseShellExecute = true;
            add.StartInfo.WorkingDirectory = directory.Text;
            add.StartInfo.Arguments = "/c " +gitAdd;
            add.StartInfo.RedirectStandardOutput = false;
            add.Start();
      
        }

        private void RunGitCommit(Object sender, RoutedEventArgs e)
        {
            string gitCommit = "git commit -m ";
            if (directory.Text != "" || commitText.Text !="")
            {
            Process commit = new Process();
            commit.StartInfo.FileName = "cmd.exe";
            commit.StartInfo.UseShellExecute = true;
            commit.StartInfo.WorkingDirectory = directory.Text;
            commit.StartInfo.Arguments = "/c " + gitCommit + commitText.Text + "";
            commit.StartInfo.RedirectStandardOutput = false;
            commit.Start();
            }
            else
            {
                textbox.Text = "chemin du dossier ou message commit manquant";
            }
           

        }

        public void RunGitPush(Object sender, RoutedEventArgs e )
        {
            string git = "git pull";

            Process test = new Process();
            test.StartInfo.FileName = "cmd.exe";
            test.StartInfo.UseShellExecute = true;
            test.StartInfo.WorkingDirectory = directory.Text;
            test.StartInfo.Arguments = "/c " + git;
            test.StartInfo.RedirectStandardOutput = false;
            test.Start();

            Process push = new Process();
            push.StartInfo.FileName = "cmd.exe";
            push.StartInfo.UseShellExecute = true;
            push.StartInfo.WorkingDirectory = directory.Text;
            push.StartInfo.Arguments = "/c git push";
            push.StartInfo.RedirectStandardOutput = false;
            push.Start();

        }

        public void RunOpen(Object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == true)
            {
               FileInfo fInfo = new FileInfo(openFileDialog.FileName);
               textbox.Text = fInfo.DirectoryName;
            }
        }
    }
}
