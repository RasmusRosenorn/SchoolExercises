using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels 
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();
        private ObservableCollection<PersonViewModel> _personsVM = new ObservableCollection<PersonViewModel>();
        private PersonViewModel _selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        public ObservableCollection<PersonViewModel> PersonsVM
        {
            get { return _personsVM; }
            set 
            {
                _personsVM = value;
                OnPropertyChanged("PersonsVM");
            }
        }
        public MainViewModel()
        {
            foreach (Person person in personRepo.GetAll())
            {
                PersonViewModel personViewModel = new PersonViewModel(person);
                PersonsVM.Add(personViewModel);
            }
        }
        public void AddDefaultPerson()
        {
            personRepo.Add("Specify FirstName", "Specify LastName", 0, "Specify Phone");
            PersonsVM.Add(new PersonViewModel(personRepo.GetAll()[personRepo.GetAll().Count - 1]));
            SelectedPerson = PersonsVM[PersonsVM.Count - 1];
        }
        public void DeleteSelectedPerson()
        {
            int selectedPersonIndex = PersonsVM.IndexOf(SelectedPerson);
            PersonsVM.RemoveAt(selectedPersonIndex);
            personRepo.Remove(selectedPersonIndex);
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
