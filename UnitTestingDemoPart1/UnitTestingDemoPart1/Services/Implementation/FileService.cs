using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingDemoPart1.Services.Contracts;

namespace UnitTestingDemoPart1.Services.Implementation
{
    public class FileService : IFileService
    {
        private string path;

        /// <summary>
        /// getter setter for 
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        /// <summary>
        /// Read a file given a path
        /// </summary>
        /// <returns>string</returns>
        public string ReadFile()
        {
            string text = "";
            if (this.FileExists())
            {
                // Create a file to write to.
                text = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, text);
            }

            return text;
        }

        /// <summary>
        /// Check if file exists
        /// </summary>
        /// <returns>bool</returns>
        public bool FileExists()
        {
            bool fileExists = false;
            fileExists = File.Exists(this.Path);
            return fileExists;
        }

    }
}
