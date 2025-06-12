using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Projet_Deviseur.ProjetDeviseur.Data;

namespace Projet_Deviseur.ProjetDeviseur.UI.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _motDePasse;
        private string _erreurMessage;

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        public string MotDePasse
        {
            get => _motDePasse;
            set { _motDePasse = value; OnPropertyChanged(); }
        }

        public string ErreurMessage
        {
            get => _erreurMessage;
            set { _erreurMessage = value; OnPropertyChanged(); }
        }

        // Commande à lier au bouton de la vue
        public ICommand ConnexionCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            ConnexionCommand = new RelayCommand(Connexion);
        }

        private void Connexion()
        {
            ErreurMessage = "";

            using (var db = new ApplicationDbContext())
            {
                var utilisateur = db.Utilisateurs
                    .FirstOrDefault(u => u.Email == Email && u.PasswordUtilisateur == MotDePasse);

                if (utilisateur != null)
                {
                    // Ici, tu pourras naviguer vers la fenêtre d'accueil ou enregistrer l'utilisateur courant
                    // Navigation non gérée dans ce snippet (dépend du reste de ton appli)
                }
                else
                {
                    ErreurMessage = "Email ou mot de passe incorrect.";
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
