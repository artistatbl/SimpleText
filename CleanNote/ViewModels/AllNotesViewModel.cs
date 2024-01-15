﻿using CleanNote.Data;
using CleanNote.Models;
using CleanNote.Views;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNote.ViewModels
{
    public partial class AllNotesViewModel : BaseViewModel
    {

        public List<Note> Notes => FakeData.FetchNotes;

        [RelayCommand]
        void AddNote()
        {
            Shell.Current.GoToAsync(nameof(AddNotePage));
        }
    }
}
