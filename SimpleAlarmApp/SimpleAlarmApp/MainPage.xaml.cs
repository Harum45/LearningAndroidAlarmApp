using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;

namespace SimpleAlarmApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Alarm> Alarms { get; set; }


        public MainPage()
        {
            InitializeComponent();
            Alarms = new ObservableCollection<Alarm>();
            alarmListView.ItemsSource = Alarms;
        }

        private void OnSetAlarmButtonClicked(object sender, EventArgs e)
        {
            var alarmTime = alarmTimePicker.Time;
            var repeatOption = repeatPicker.SelectedItem?.ToString() ?? "なし";

            Alarms.Add(new Alarm
            {
                Time = alarmTime.ToString(@"hh\:mm"),
                Repeat = repeatOption
            });

            DisplayAlert("アラーム設定", $"アラームを {alarmTime} に設定しました。", "OK");


        }

    }

    public class Alarm
    {
        public string Time { get; set; }
        public string Repeat { get; set; }
    }
}
