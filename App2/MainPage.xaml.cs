using Android.Content;
using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace App2
{
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnButtonClickedRed(object sender, EventArgs e) //Обработчик нажатия на кнопку
		{
			Button button = (Button)sender;
			back.BackgroundColor = Color.Red;
			subtitle.BackgroundColor = Color.LightCoral;
			title.BackgroundColor = Color.LightCoral;
			quit.BackgroundColor = Color.LightCoral;
			slider.Value = 5000;
		}
		private void OnButtonClickedGreen(object sender, EventArgs e) //Обработчик нажатия на кнопку
		{
			Button button = (Button)sender;
			back.BackgroundColor = Color.Green;
			subtitle.BackgroundColor = Color.LimeGreen;
			title.BackgroundColor = Color.LimeGreen;
			quit.BackgroundColor = Color.LimeGreen;
			slider.Value = 5000;
		}
		private void OnButtonClickedBlue(object sender, EventArgs e) //Обработчик нажатия на кнопку
		{
			Button button = (Button)sender;
			back.BackgroundColor = Color.Blue;
			subtitle.BackgroundColor = Color.Navy;
			title.BackgroundColor = Color.Navy;
			quit.BackgroundColor = Color.Navy;
			slider.Value = 5000;
		}
		private void OnButtonClickedQuit(object sender, EventArgs e) //Обработчик нажатия на кнопку
		{
			Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
		}


		void OnValueChanged(object sender, ValueChangedEventArgs e)
		{
			if (header != null)
				header.Text = String.Format("Brightness: {0:F1}", e.NewValue/100);
			Color colour = back.BackgroundColor;
			back.BackgroundColor = colour.WithLuminosity(e.NewValue*0.0001);
		}
	}
}