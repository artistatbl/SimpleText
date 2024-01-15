
using CleanNote.Views;

namespace CleanNote
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(AllNotesPage), typeof(AllNotesPage));
            Routing.RegisterRoute(nameof(AddNotePage), typeof(AddNotePage));
            Routing.RegisterRoute(nameof(NoteDetailsPage), typeof(NoteDetailsPage));
        }
    }
}
