using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MalinesCommon.Windows.ViewModel
{
    /// <summary>
    /// Provides implementations of <see cref="ICommand"/> base functions.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        // Private fields
        private Action<Object> _command;
        private Func<Object, bool> _canExecute;


        // Public events

        /// <summary>
        /// Occurs when a value indicating whether it is executable changes.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        // Constructor

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/> class from a specified delegates.
        /// </summary>
        /// <param name="command">A delegate that defines command action.</param>
        /// <param name="canExecute">A delegate that determines whether the command can execute in its current state.</param>
        public DelegateCommand(Action<Object> command, Func<Object, bool> canExecute)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            if (canExecute == null)
                canExecute = param => true;

            this._command = command;
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/> class from a specified delegates.
        /// </summary>
        /// <param name="command">A delegate that defines command action.</param>
        public DelegateCommand(Action<Object> command)
            : this(command, null)
        { }


        // Public methods

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this._command(parameter);
        }

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return this._canExecute(parameter);
        }
    }
}
