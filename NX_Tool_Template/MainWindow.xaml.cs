﻿using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NX_Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            /// 屏幕居中最前显示
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //this.Topmost = true;
        }
        // 主界面正要关闭
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // 弹窗提示是否确定要退出
            MessageBoxButton btn = MessageBoxButton.YesNo;
            MessageBoxResult result = ModernDialog.ShowMessage("确定要退出NX Tool 吗？", "警告", btn);
            System.Console.WriteLine(result);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true; // 中断点击事件
            }
        }

        // 主界面完成关闭
        private void Window_Closed(object sender, System.EventArgs e)
        {
            //Application.Current.Shutdown(); // 正常结束
            Environment.Exit(0);              // 强制结束
        }
    }
}
