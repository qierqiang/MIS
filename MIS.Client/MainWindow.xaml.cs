using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
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

namespace MIS.Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            IClientChannelSinkProvider sinkProvider = null;
            HttpClientChannel cl = new HttpClientChannel("", sinkProvider);
            ChannelServices.RegisterChannel(cl, false);

            object op = Activator.GetObject(typeof(MIS.Entities.S_User), "tcp://127.0.0.1:8086/User");
            op = Activator.GetObject(typeof(MIS.Core.DbContextProxy), "tcp://127.0.0.1:8086/Entities");
            op = null;
        }
    }
}
