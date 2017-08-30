using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemoPart1.Services.Contracts
{
    public interface IFileService
    {
        string Path { get; set; }

        string ReadFile();
        bool FileExists();
    }
}
