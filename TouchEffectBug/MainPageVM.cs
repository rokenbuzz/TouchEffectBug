using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace TouchEffectBug
{
    public class MainPageVM
    {
        public MainPageVM()
        {
            DoSomethingCommand = new RelayCommand(DoSomething);
        }

        public RelayCommand DoSomethingCommand { get; private set; }

        private void DoSomething()
        {
            Console.WriteLine("**** IN DoSomething() ****");
        }
    }
}
