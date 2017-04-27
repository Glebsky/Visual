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
using System.Windows.Threading;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;

namespace FbPoster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GoogleAnalytics> google;
        TextParser parser;
        List<Post> posts;
        DispatcherTimer timer;
        int optseconds;
        int seconds;

        //bools For Settings
        bool isMaxState;
        bool isTimerWork;
        bool isTopMost;
        Thread SoundThr;
        HotKeys gkh = new HotKeys();
        public MainWindow()
        {
            InitializeComponent();
            isMaxState = true;
            // HotKeys Set
            gkh.HookedKeys.Add(System.Windows.Forms.Keys.D1);
            gkh.HookedKeys.Add(System.Windows.Forms.Keys.D2);
            gkh.KeyUp += new System.Windows.Forms.KeyEventHandler(gkh_KeyUp);
            optseconds = 600;
            isTimerWork = true;
            google = new List<GoogleAnalytics>();
            //Parse links
            try
            {
                parser = new TextParser("http://organicplant.ucoz.org/FbPoster/links.txt");

                List<Post> links = parser.ParseLinks("http://organicplant.ucoz.org/FbPoster/links.txt");
                for (int i = 0; i < links.Count; i++)
                {
                    google.Add(new GoogleAnalytics(links[i].Content, links[i].Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось загрузить ссылки");

            }

            //posts
            try
            {
                posts = parser.ParsePost("http://organicplant.ucoz.org/FbPoster/Posts/Posts.txt");
                for (int i = 0; i < posts.Count; i++)
                    PostBox.Items.Add(posts[i].Name);
                for (int i = 0; i < google.Count; i++)
                    LinkBox.Items.Add(google[i].NameUrl);
                LinkBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось загрузить ссылки");
            }

            //timer
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1);


            //Sounds
            SoundThr = new Thread(PlaySound);
            SoundThr.Name = "soundThread";

        }

        void gkh_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.D1)
            {
                CopyRandomPostToClip(sender, new RoutedEventArgs());
            }
            if (e.KeyCode == System.Windows.Forms.Keys.D2)
            {
                CopyPostToClip(sender, new RoutedEventArgs());
            }
        }

        private void PlaySound()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Beep(500, 300);
                Console.Beep(500, 300);
                Thread.Sleep(1000);
            }
        }

        private void Minimize()
        {
            label.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            label1_Copy.Visibility = Visibility.Hidden;
            label1_Copy2.Visibility = Visibility.Hidden;
            LabelLink1_Copy1.Visibility = Visibility.Hidden;
            LabelLink1_Copy2.Visibility = Visibility.Hidden;
            daylabel.Visibility = Visibility.Hidden;
            StatDay.Visibility = Visibility.Hidden;
            StatMonth.Visibility = Visibility.Hidden;
            StatWeek.Visibility = Visibility.Hidden;
            TimerLable.Visibility = Visibility.Hidden;
            PostMessage.Visibility = Visibility.Hidden;
            image.Visibility = Visibility.Hidden;
            PostButton4.Visibility = Visibility.Hidden;
            CopyLink.Visibility = Visibility.Hidden;
            StatBack.Visibility = Visibility.Hidden;
            TimerBack.Visibility = Visibility.Hidden;
            PostBack.Visibility = Visibility.Hidden;
            LinkBox.Margin = new Thickness(0, 0, 85, 0);
            TimerStop.Margin = new Thickness(0, 7, 30, 0);
            Preferences.Margin = new Thickness(0, 7, 4, 0);
            MiniBtn.Margin = new Thickness(0, 7, 56, 0);
            LinkBox.Width = 100;
            stack.Margin = new Thickness(0, 6, 0, 0);
            this.Height = 79;
        }

        private void Maximize()
        {
            label.Visibility = Visibility.Visible;
            label1.Visibility = Visibility.Visible;
            label1_Copy.Visibility = Visibility.Visible;
            label1_Copy2.Visibility = Visibility.Visible;
            LabelLink1_Copy1.Visibility = Visibility.Visible;
            LabelLink1_Copy2.Visibility = Visibility.Visible;
            daylabel.Visibility = Visibility.Visible;
            StatDay.Visibility = Visibility.Visible;
            StatMonth.Visibility = Visibility.Visible;
            StatWeek.Visibility = Visibility.Visible;
            TimerLable.Visibility = Visibility.Visible;
            PostMessage.Visibility = Visibility.Visible;
            image.Visibility = Visibility.Visible;
            PostButton4.Visibility = Visibility.Visible;
            CopyLink.Visibility = Visibility.Visible;
            StatBack.Visibility = Visibility.Visible;
            TimerBack.Visibility = Visibility.Visible;
            PostBack.Visibility = Visibility.Visible;
            LinkBox.Margin = new Thickness(0, 0, 0, 65);
            TimerStop.Margin = new Thickness(0, 7, 67, 0);
            Preferences.Margin = new Thickness(0, 7, 30, 0);
            MiniBtn.Margin = new Thickness(0, 7, 104, 0);
            LinkBox.Width = 146;
            stack.Margin = new Thickness(0, 73, 0, 0);
            this.Height = 281;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!isTimerWork)
                timer.Stop();
            int minute = seconds / 60;
            int second = seconds - (minute * 60);
            second--;
            seconds--;
            if (second < 1)
            {
                if (minute != 0)
                {
                    minute--;
                    second = 59;
                }
            }
            string content = "";
            if (minute == 0 && seconds == 0)
            {
                content = "00:00";
                SoundThr.Start();
                timer.Stop();
            }
            else
                if (minute < 10)
                content = "0" + minute + " : " + second;
            else
                content = minute + " : " + second;

            TimerLable.Content = content;
        }

        private void MouseOn(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void button_Copy3_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void PostButton1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PostButton1_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void StatUpdate(object sender, SelectionChangedEventArgs e)
        {
            string NameLink = LinkBox.SelectedValue.ToString();
            for (int i = 0; i < google.Count; i++)
            {
                if (NameLink == google[i].NameUrl)
                {
                    StatDay.Content = google[i].GetDayStat();
                    StatWeek.Content = google[i].GetWeekStat();
                    StatMonth.Content = google[i].GetMonthStat();
                }
            }
        }

        private void TopMostChange()
        {
            if (isTopMost)
                Topmost = true;
            else
                Topmost = false;

        }

        private void CopyPostToClip(object sender, RoutedEventArgs e)
        {
            try
            {
                string res = "";
                string NameLink = LinkBox.SelectedValue.ToString();
                for (int i = 0; i < posts.Count; i++)
                {
                    if ((string)PostBox.SelectedValue == posts[i].Name)
                        res = posts[i].Content;
                }
                for (int i = 0; i < google.Count; i++)
                {
                    if (NameLink == google[i].NameUrl)
                    {
                        res += "\n";
                        res += google[i].BaseUri;
                    }
                }

                System.Windows.Clipboard.SetText(res);
                if (isTimerWork)
                {
                    if (!timer.IsEnabled)
                    {
                        seconds = optseconds;
                        timer.Start();
                    }
                    else
                    {
                        seconds = optseconds;
                        timer.Stop();
                        timer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удолось скопировать пост");
            }
        }

        private void CopyRandomPostToClip(object sender, RoutedEventArgs e)
        {
            try
            {
                string res = "";
                string NameLink = LinkBox.SelectedValue.ToString();
                Random rnd = new Random();
                int i = rnd.Next(0, posts.Count);
                res = posts[i].Content;
                for (int j = 0; j < google.Count; j++)
                {
                    if (NameLink == google[j].NameUrl)
                    {
                        res += "\n";
                        res += google[j].BaseUri;
                    }
                }

                System.Windows.Clipboard.SetText(res);
                if (isTimerWork)
                {
                    if (!timer.IsEnabled)
                    {
                        seconds = optseconds;
                        timer.Start();
                    }
                    else
                    {
                        seconds = optseconds;
                        timer.Stop();
                        timer.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удолось скопировать пост");
            }
        }

        private void CopyToClip(object sender, RoutedEventArgs e)
        {
            try
            {
                string NameLink = LinkBox.SelectedValue.ToString();
                for (int i = 0; i < google.Count; i++)
                {
                    if (NameLink == google[i].NameUrl)
                    {
                        System.Windows.Clipboard.SetText(google[i].BaseUri);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удолось скопировать ссылку");
            }
        }

        private void StopTimer(object sender, MouseButtonEventArgs e)
        {
            if (seconds != 0)
            {
                if (timer.IsEnabled)
                {
                    TimerLable.Content = "--:--";
                    timer.Stop();
                }
                else
                {
                    timer.Start();
                }
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < posts.Count; i++)
            {
                if ((string)PostBox.SelectedValue == posts[i].Name)
                    PostMessage.Text = posts[i].Content;
            }

        }

        private void OptionsDialog(object sender, MouseButtonEventArgs e)
        {
            Options opt = new Options(optseconds, isTimerWork, isTopMost);
            opt.ShowDialog();
            if (opt.DialogResult == true)
            {
                optseconds = opt.seconds;
                isTimerWork = opt.isTimerWork;
                this.isTopMost = opt.isTopMost;
            }
            TopMostChange();
        }

        private void ChangeState(object sender, MouseButtonEventArgs e)
        {
            if (isMaxState)
            {
                Minimize();
                isMaxState = false;
            }
            else
            {
                Maximize();
                isMaxState = true;
            }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GoToStat(object sender, MouseButtonEventArgs e)
        {
            string html = HtmlDownloadHelper.DownloadHtml("https://sheets.googleapis.com/v4/spreadsheets/1kZhb0tZE7wg5upmZPmZszsvs6NxjAa9oeoO9_abuJsU?includeGridData=false&ranges=A1&ranges=B2&fields=namedRanges%2Cproperties%2Csheets%2CspreadsheetId%2CspreadsheetUrl&key=AIzaSyDb9z0f5DiMDB0_hPm-31JZJLDrYX_D9NI");
            string str = LinkBox.SelectedValue.ToString();
            for (int i = 0; i < google.Count; i++)
            {
                if (str == google[i].NameUrl && google[i].BaseUri.Contains("https://goo.gl/"))
                {
                    string tempstr = google[i].BaseUri.Substring(15);
                    System.Diagnostics.Process.Start("https://goo.gl/#analytics/goo.gl/" + tempstr + "/day");
                }
            }

        }
    }
}
