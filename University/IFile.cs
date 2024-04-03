﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using University.Models;

namespace University
{
     public interface IFile<T> : IReadFile<T>, IWriteFile<T>
    {
        public string FilePath { get; set; }
    }
}
