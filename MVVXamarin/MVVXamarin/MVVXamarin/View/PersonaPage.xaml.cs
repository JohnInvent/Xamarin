using MVVXamarin.Model;
using MVVXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVXamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel contexto = new PersonaViewModel();
        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvPersonas.ItemSelected += LvPersonas_ItemSelected;
        }

        private void LvPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem!=null)
            {
                PersonaModel modelo = (PersonaModel)e.SelectedItem;
                Navigation.PushAsync(new DetallePage(modelo));
                //contexto.Nombre = modelo.Nombre;
                //contexto.Apellido = modelo.Apellido;
                //contexto.Edad = modelo.Edad;
                //contexto.Id = modelo.Id;
            }
        }
    }
}