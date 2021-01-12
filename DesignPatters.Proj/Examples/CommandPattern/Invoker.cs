using System;
using DesignPatters.Proj.Examples.Command;

namespace DesignPatters.Proj.Examples.CommandPattern
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        public void Invoke()
        {
            Console.WriteLine("Starting invocation");
            _onStart?.Execute();
            _onFinish?.Execute();
        }
    }
}