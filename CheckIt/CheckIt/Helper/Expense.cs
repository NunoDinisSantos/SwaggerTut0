﻿namespace CheckIt.Helper
{
    public class Expense
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public float Cost { get; set; } = 0;
    }
}
