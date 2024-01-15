using CleanNote.Controls;

namespace CleanNote
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Handlers.RegisterHandlers();
            MainPage = new AppShell();
        }
    }
}
