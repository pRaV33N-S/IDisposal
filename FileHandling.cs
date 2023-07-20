﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDisposal
{
    public class FileHandler : IDisposable
    {
        File fileObject = null;
        static int totalFiles = 0;
        bool disposedValue;
        public FileHandler(string fileName)
        {
            if (fileObject == null)
            {
                totalFiles++;
                fileObject = new File(fileName);
            }
            Console.WriteLine("File Created");
            Console.WriteLine("Number Of Files Are : "+totalFiles);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    totalFiles = 0;
                }
            }
                Console.WriteLine("File {0} has been disposed",fileObject.Name);
                fileObject = null;
            disposedValue = true;
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void GetFileDetails()
        {
            Console.WriteLine(fileObject.Name + "file has been created successfully");
        }
        ~FileHandler()
        {
            Dispose(false);
        }
    }
}
