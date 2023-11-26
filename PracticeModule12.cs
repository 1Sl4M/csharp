using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.PropertyChanged += HandlePropertyChanged;

            myObject.Name = "NewName";

            Console.ReadLine();
        }

        private static void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено");
        }
    }
}
public interface IPropertyChanged
{
    event PropertyChangedEventHandler PropertyChanged;
}

public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

public class PropertyChangedEventArgs : EventArgs
{
    public string PropertyName { get; }

    public PropertyChangedEventArgs(string propertyName)
    {
        PropertyName = propertyName;
    }
}

public class MyClass : IPropertyChanged
{
    private string _name;

    public event PropertyChangedEventHandler PropertyChanged;

    public string Name
    {
        get { return _name; }
        set
        {
            if (_name != value)
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
