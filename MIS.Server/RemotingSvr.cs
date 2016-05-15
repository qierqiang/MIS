using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;

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

        }

        //停止服务
        public void Stop()
        {


        }
    }
}