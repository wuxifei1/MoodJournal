﻿using System.Windows;
using System.Windows.Input;
using MoodTracker.ViewModels;
using MoodTracker.View;
using System.Windows.Controls;
using MoodTracker.Controls;

namespace MoodTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            // 默认导航到首页
            MainContentFrame.Navigate(new HomePage());
        }

        //页面切换逻辑
        public void NavigateTo(Page page)
        {
            MainContentFrame.Navigate(page);
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void SideNav_NavigationRequested(object sender, RoutedEventArgs e)
        {
            if (sender is SideNav sideNav)
            {
                if (sideNav.HomeButton.IsChecked == true)
                {
                    MainContentFrame.Navigate(new HomePage());
                }
                else if (sideNav.AnalyticsButton.IsChecked == true)
                {
                    MainContentFrame.Navigate(new DataAnalysisPage());
                }
            }
        }
    }
}
