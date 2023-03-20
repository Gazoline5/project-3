using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

public static class Manager
{
    public static Frame MainFrame { get; set; }

    public static string PrintProperties(Object obj)
    {
        string res = "";
        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
        {
            string name = descriptor.Name;
            object value = descriptor.GetValue(obj);
            res += $"\n{name}={value}";
        }
        return res;
    }



    //private static dfominaEntities context;
    //public static dfominaEntities GetContext()
    //{
    //    if (context == null)
    //        context = new dfominaEntities();

    //    return context;
    //}
}
