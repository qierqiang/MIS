using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using System.Collections;

namespace MIS.Server
{
    //remoting服务发布
    public class RemotingSvr
    {
        //私有构造，以实现静态单例
        private RemotingSvr()
        {
            //向客户端发送完整异常信息
            RemotingConfiguration.CustomErrorsMode = CustomErrorsModes.Off;
            RemotingConfiguration.CustomErrorsEnabled(false);
        }

        //启动服务
        public void Start()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MIS.Entities.S_User), "User", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MIS.Core.DbContextProxy), "Entities", WellKnownObjectMode.SingleCall);

            BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
            BinaryClientFormatterSinkProvider clientProvider = new BinaryClientFormatterSinkProvider();
            serverProvider.TypeFilterLevel = TypeFilterLevel.Full;

            IDictionary props = new Hashtable();
            props["port"] = 8086;
            TcpChannel channel = new TcpChannel(props, clientProvider, serverProvider);

            ChannelServices.RegisterChannel(channel, false);
        }

        //停止服务
        public void Stop()
        {
            foreach (IChannel chnl in ChannelServices.RegisteredChannels)
                ChannelServices.UnregisterChannel(chnl);
        }

        static RemotingSvr _instance = new RemotingSvr();

        public static RemotingSvr Instance { get { return _instance; } }
    }
}