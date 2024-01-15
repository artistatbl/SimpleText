using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNote.Models;

namespace CleanNote.Converters
{
    public class NoteDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextTemplate { get; set; }
        public DataTemplate VoiceTemplate { get; set; }
        public DataTemplate ReminderTemplate { get; set; }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Note)item).NoteType switch
            {
                NoteType.Voice => VoiceTemplate,
                NoteType.Reminder => ReminderTemplate,
                _ => TextTemplate,
            };
        }
    }
}
