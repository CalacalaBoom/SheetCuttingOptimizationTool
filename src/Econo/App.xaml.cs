using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Econo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // 随机获取一个空闲主机端口（推荐）
            Serve.RunNative(service =>
            {
                service.AddEventBus();
                // 每天创建一个日志文件
                service.AddFileLogging("logs/application-{0:yyyy}-{0:MM}-{0:dd}.log", options =>
                {
                    options.FileNameRule = fileName =>
                    {
                        return string.Format(fileName, DateTime.UtcNow);
                    };
                });
            }, urls: Serve.IdleHost.Urls);
        }
    }
}
