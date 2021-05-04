using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;//StreamWriter 파일을 쓰고 작업할때 쓰는 부분
        public FileLogger(string path)
        {
            writer = File.CreateText(path); // 파일을 만드는 작업
            writer.AutoFlush = true; // 자동으로 데이터를 쓰느냐
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FildLog {DateTime.Now}\t>>>>> {message} ");
        }
    }
}
