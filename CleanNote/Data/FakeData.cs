using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanNote.Models;

namespace CleanNote.Data
{
    public class FakeData
    {
        public static List<Note> FetchNotes => new List<Note>
        {
            new Note
            {
                Title = "Determinants of Human Acts",
                Content = "Each day is like building up your foundation, one brick at a time. And if the bricks are wobbly ones, they can go tumbling down on you with little provocation; its tough to build off of that compromised foundation. It takes daily work to strengthen our foundations, but once we do it's like having a solid bedrock on which to build.",
                FileUrl = "https://images.pexels.com/photos/260024/pexels-photo-260024.jpeg?auto=compress&cs=tinysrgb&w=600",
                NoteType = NoteType.Text
            },
            new Note
            {
                Title = "Immaculate",
                Content = "Immaculate literally means without a spot or a stain. ",
                FileUrl = "",
                NoteType = NoteType.Voice
            },
            new Note
            {
                Title = "Take Note",
                Content = "Making the most out of life",
                Time = new TimeOnly(13, 30),
                Date = new DateOnly(2024, 8, 28),
                NoteType = NoteType.Reminder
            },
            new Note
            {
                Title = "Ways to Improve English Grammar",
                Content = "Communicating fluently in English is a gradual process, one that takes a lot of practice and time to hone. In the meantime, the learning process can feel daunting: \r\n\r\nYou want to get your meaning across correctly and smoothly, but putting your ideas into writing comes with the pressure of their feeling more permanent. This is why consistent, tailored suggestions are most helpful for improving your English writing abilities. Seeing specific writing suggestions based on common grammatical mistakes multilingual speakers make in English is key to improving your communication and English writing fluency.",
                NoteType = NoteType.Text
            }
        };
    }
}
