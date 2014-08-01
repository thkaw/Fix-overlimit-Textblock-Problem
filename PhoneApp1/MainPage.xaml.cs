using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using System.IO;
using System.Text;
using Phone.Controls;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // 建構函式
        public MainPage()
        {
            InitializeComponent();

            Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            string alongstring = "I am LONGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG STring 1234567890~~~~~~~ with text warp" + '\n';

            for (int i = 0; i < 250; i++)
            {
                alongstring += "Item:" + i.ToString() + " Subject No." + i.ToString() + "Long dataaaaaaaaaaaaa with warpppppppppppppppppppp" + '\n';

            }
            tb.Text = alongstring;

            ScrollViewer scrollViewer = new ScrollViewer();

            ScrollableTextBlock stb = new ScrollableTextBlock();

            stb.Text = alongstring;
            stb.Height = Double.NaN;
            stb.Width = Double.NaN;
             
            scrollViewer.Height = 520;
            scrollViewer.Content = stb;

            CustomMessageBox cmb = new CustomMessageBox()
            {
                Caption = "I'm longggggggggggggggggggggggggggggggggggggg Cpation",
                LeftButtonContent = "ya",
                RightButtonContent = "no",
                Content = scrollViewer

            };
             
            cmb.Show();
        }
 
        // 建置當地語系化 ApplicationBar 的程式碼範例
        //private void BuildLocalizedApplicationBar()
        //{
        //    // 將頁面的 ApplicationBar 設定為 ApplicationBar 的新執行個體。
        //    ApplicationBar = new ApplicationBar();

        //    // 建立新的按鈕並將文字值設定為 AppResources 的當地語系化字串。
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // 用 AppResources 的當地語系化字串建立新的功能表項目。
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}


    }
}