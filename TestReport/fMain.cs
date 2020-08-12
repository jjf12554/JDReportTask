using ReportInterface;
using JDTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestReport
{
    public class fMain : JobInterface
    {
        public override void Run()
        {
            Thread.Sleep(3000);
            LogTool.Info("test"+users);
        }
    }
}
