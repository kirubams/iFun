﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFun.DTO
{
    public class ExpenseTransactionDTO
    {
        public int ExpenseTransactionID { get; set; }
        public int ExpenseID { get; set; }
        public string Comments { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ExpenseDescription { get; set; }
    }
}
