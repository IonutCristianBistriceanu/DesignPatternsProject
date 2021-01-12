using System;
using DesignPatters.Proj.Examples.Command;

namespace DesignPatters.Proj.Examples.CommandPattern.Commands
{
    public class SimpleCommand : ICommand
    {
        private string _localString = string.Empty;

        public SimpleCommand(string input)
        {
            _localString = input;
        }

        public void Execute()
        {
            Console.WriteLine($"{_localString}");
        }
    }
}