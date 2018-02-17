namespace _1.Event_Impl
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.OnNameChange(new NameChangeEventArgs(this.name));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChange != null)
            {
                NameChange(this, args);
            }
        }
    }

}
