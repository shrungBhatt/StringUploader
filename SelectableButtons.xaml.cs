using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SelectableButtons
{

    [DesignTimeVisible(false)]
    public partial class SelectableButtons : ContentView
    {


        #region BindableProperties

        public static BindableProperty ButtonsListProperty =
            BindableProperty.Create(nameof(ButtonList),
                typeof(IList<SelectableButton>),
                typeof(SelectableButtons),
                null,
                BindingMode.Default,
                propertyChanged: ButtonsListPropertyChanged);

        private static void ButtonsListPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SelectableButtons)bindable;
            control.ButtonList = (IList<SelectableButton>)newValue;
        }

        public IList<SelectableButton> ButtonList
        {
            get { return (IList<SelectableButton>)GetValue(ButtonsListProperty); }
            set { SetValue(ButtonsListProperty, value); }
        }


        #endregion

        public int SelectedState { get; set; }

        public SelectableButtons()
        {
            InitializeComponent();
            BindingContext = this;

        }

        public ICommand OnButtonSelectedCommand => new Command<SelectableButton>(OnButtonSelected);

        private void OnButtonSelected(SelectableButton selectedButton)
        {
            if (selectedButton != null)
            {
                SelectedState = selectedButton.State;

                foreach (SelectableButton button in ButtonList)
                {
                    button.IsSelected = false;
                }

                selectedButton.IsSelected = true;
            }
        }


        #region SelectableButtonsDataModel

        public class SelectableButton : INotifyPropertyChanged
        {
            public string Title { get; set; }
            public int State { get; set; }
            private bool _isSelected;

            public event PropertyChangedEventHandler PropertyChanged;

            public bool IsSelected
            {
                get { return _isSelected; }
                set { _isSelected = value; OnPropertyChanged(nameof(IsSelected)); }
            }

            public void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }

        }



        #endregion

        #region GenerateSelectableButton

        private StackLayout GetSelectableButtons(int totalButtonsRequired)
        {
            StackLayout buttons = new StackLayout();

            return buttons;
        }


        private StackLayout GetAButton()
        {
            StackLayout button = new StackLayout();
            button.Margin = new Thickness(1, 1, 1, 1);
            button.Orientation = StackOrientation.Vertical;


            return button;
        }

        #endregion

    }


}
