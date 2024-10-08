using System.Data.SqlClient;

namespace System
{
    internal class EventHandler1
    {
        private Action<object, EventArgs, SqlConnection> save_Click;

        public EventHandler1(Action<object, EventArgs, SqlConnection> save_Click)
        {
            this.save_Click = save_Click;
        }

        public static implicit operator EventHandler(EventHandler1 v) => throw new NotImplementedException();
    }
}