﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamVCE
{
    [Serializable]
    public class Answer
    {
        public string Question { get; set; }
        public bool IsCorrect { get; set; }
    }
}
