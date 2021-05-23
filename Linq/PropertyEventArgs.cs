namespace Linq
{
    public class PropertyEventArgs
    {
        public string Message { get; set; }
        public PropertyEventArgs(string message)
        {
            Message = message;
        }
    }
}