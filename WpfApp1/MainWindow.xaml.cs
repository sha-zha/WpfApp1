using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
           
            Process test = new Process();
            test.StartInfo.FileName = "cmd.exe";
            test.StartInfo.UseShellExecute = true;
            test.StartInfo.WorkingDirectory = directory.Text;
            test.StartInfo.Arguments = "/c "+gitClone+txtName.Text;
            test.StartInfo.RedirectStandardOutput = false;
            test.Start();
           
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

            Process commit = new Process();
            commit.StartInfo.FileName = "cmd.exe";
            commit.StartInfo.UseShellExecute = true;
            commit.StartInfo.WorkingDirectory = directory.Text;
            commit.StartInfo.Arguments = "/c " + gitCommit + commitText.Text + "";
            commit.StartInfo.RedirectStandardOutput = false;
            commit.Start();

        }

        private void RunGitPush(Object sender, RoutedEventArgs e )
        {
           
            Process push = new Process();
            push.StartInfo.FileName = "cmd.exe";
            push.StartInfo.UseShellExecute = true;
            push.StartInfo.WorkingDirectory = directory.Text;
            push.StartInfo.Arguments = "/c git push";
            push.StartInfo.RedirectStandardOutput = false;
            push.Start();

        }

    }
}
