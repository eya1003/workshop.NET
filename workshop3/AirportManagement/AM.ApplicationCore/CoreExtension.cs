﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class CoreExtension
    {
        public static void showList<T> (this IEnumerable<T> list, string title, ShowLine  showLine) {
            showLine($"=== title===");
            foreach (T item in list) 
            {
                showLine(item);
            }
        }
    }
}
