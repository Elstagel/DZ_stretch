using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stretch_v._2
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

		private void RadioButtonFill_Click(object sender, RoutedEventArgs e)
		{
			ImgDzirt.Stretch = System.Windows.Media.Stretch.Fill;
		}

		private void RadioButtonNone_Click(object sender, RoutedEventArgs e)
		{
			ImgDzirt.Stretch = System.Windows.Media.Stretch.None;
		}

		private void RadioButtonUniform_Click(object sender, RoutedEventArgs e)
		{
			ImgDzirt.Stretch = System.Windows.Media.Stretch.Uniform;

		}

		private void RadioButtonUniformToFill_Click(object sender, RoutedEventArgs e)
		{
			ImgDzirt.Stretch = System.Windows.Media.Stretch.UniformToFill;

		}

	}
}