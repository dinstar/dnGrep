﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using NLog;

namespace dnGREP.WPF
{
    /// <summary>
    /// Interaction logic for TestPattern.xaml
    /// </summary>
    public partial class TestPattern : Window
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private TestPatternViewModel inputData = new TestPatternViewModel();

        public TestPattern()
        {
            InitializeComponent();
            this.DataContext = inputData;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputData.UpdateState("");
        }

        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            inputData.SaveSettings();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCopyFile_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(inputData.TestOutputText);
        }
    }
}
