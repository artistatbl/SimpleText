using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNote.Models
{
    public class Note
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public NoteType NoteType { get; set; }
        public string? FileUrl { get; set; }
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }
        public DateTime DateModified { get; set; }
        public double Height => GetHeight();
        public string Color => GetColor();

        private string GetColor()
        {
            switch (NoteType)
            {
                case NoteType.Reminder:
                    return "#3269FF";
                case NoteType.Voice:
                    return "#ECEAF5";
                default:
                    return "#171C26";
            }
        }

        private double GetHeight()
        {
            switch (NoteType)
            {
                case NoteType.Reminder:
                case NoteType.Voice:
                    return 200f;
                default:
                    return 315f;
            }
        }

    }

    public enum NoteType
    {
        Text = 1,
        Voice,
        Reminder
    }
}
