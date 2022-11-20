using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using JeuxDuPendu.Forms;
using JeuxDuPendu.MyControls;

namespace JeuxDuPendu
{
    public partial class GameForm : Form
    {

        // Initialisation de l'instance de la classe d'affichage du pendu.
        HangmanViewer _HangmanViewer = new HangmanViewer();



        private Form parent;


        #region Attributs Multijoueur
        

        #region Attributs Multijoueur Local
        private bool isLocalMultiplayer = false;
        private Player joueur1 = null;
        private Player joueur2 = null;
        private Player joueurActif;
        #endregion

        #region Attributs Multijoueur Distant

        private bool isDistantMultiplayer = false, isServer = false;
        private IPAddress ipServeur;
        private int portServeur;

        #endregion

        #endregion
        private string wordToGuess;

        /// <summary>
        /// Constructeur de la classe pour le mode Solo.
        /// </summary>
        /// <param name="parent"></param>
        public GameForm(Form parent)
        {
            this.parent = parent;

            InitializeComponent();
            InitializeMyComponent();
            StartNewGame();
        }

        /// <summary>
        /// Constructeur de la classe pour le mode Multijoueur Local.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="isLocalMultiplayer"></param>
        /// <param name="joueur1"></param>
        /// <param name="joueur2"></param>
        public GameForm(Form parent,bool isLocalMultiplayer, Player joueur1, Player joueur2)
        {
            this.parent = parent;
            this.joueur1 = joueur1;
            this.joueur2 = joueur2;
            this.joueurActif = joueur1;
            this.isLocalMultiplayer = true;

            InitializeComponent();
            InitializeMyComponent();
            StartNewGame();
        }

        /// <summary>
        /// Constructeur de la classe pour le mode Multijoueur distant (côté serveur).
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="joueur"></param>
        public GameForm(Form parent, Player joueur)
        {
            this.parent = parent;
            this.isDistantMultiplayer = true;
            this.isServer = true;

            
            InitializeComponent();
            InitializeMyComponent();

        }

        /*
        /// <summary>
        /// Constructeur de la classe pour le mode Multijoueur (côté client).
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="joueur"></param>
        public GameForm(Form parent, string ip, int port, Player joueur)
        {
            this.parent = parent;
            this.isDistantMultiplayer = true;
            this.ip = ip;
            this.port = port;

            InitializeComponent();
            InitializeMyComponent();

        }*/

        #region Partie Multijoueur Local.
        /// <summary>
        /// - Incrémentation des scores.
        /// - Affichage d'un message indiquant que le mot a été trouvé.
        /// - Enregistrement des scores dans un fichier de logs.
        /// </summary>
        public void multitLocalEnd()
        {
            if (this.joueurActif == this.joueur1) this.joueur1.Score++; // Si le joueur actif est le joueur 1, on augmente son score.
            else this.joueur2.Score++; // Sinon on augmente le score du joueur 2.

            MessageBox.Show("Bravo " + this.joueurActif.Pseudo + "    vous avez trouvé le mot : " + this.wordToGuess + "\nLes scores sont : \n" + this.joueur1.Pseudo + " : " + this.joueur1.Score + "\n" + this.joueur2.Pseudo + " : " + this.joueur2.Score + "\n");
            Player.enregistrerScore(this.joueur1, this.joueur2); // Sauvegarde le score dans un fichier de Logs.

        }
        /// <summary>
        /// Fonction permettant de changer le joueurActif.
        /// - Change l'apparence du label lJoueur pour qu'il s'adapte au joueur actif.
        /// </summary>
        private void multiLocalChangeTurn()
        {
            if (this.joueurActif == this.joueur1) this.joueurActif = this.joueur2; // Si le joueur actif est le joueur 1 alors le joueur Actif devient le joueur 2.
            else this.joueurActif = this.joueur1; // Sinon le joueur Actif devient le joueur 1.

            lJoueur.Text = joueurActif.Pseudo; // Affichage du pseudo du joueur Actif.
            lJoueur.BackColor = joueurActif.Couleur; // Affichage de la couleur du joueur Actif.
        }
        #endregion

        #region Parti Multijoueur distant    
      
        
        #endregion


        /// <summary>
        /// Initialisations des composant specifique a l'application
        /// </summary>
        private void InitializeMyComponent()
        {
            // On positionne le controle d'affichage du pendu dans panel1 : 
            panel1.Controls.Add(_HangmanViewer);
			
			// à la position 0,0
            _HangmanViewer.Location = new Point(0, 0);
			
			// et de la même taille que panel1
            _HangmanViewer.Size = panel1.Size;
        }

        /// <summary>
        /// Initialise une nouvelle partie
        /// </summary>
        public void StartNewGame()
        {
            // Methode de reinitialisation classe d'affichage du pendu.
            _HangmanViewer.Reset();


            // Récupération d'un mot aléatoire dans l'attribut wordToGuess
            if (isDistantMultiplayer == false) this.wordToGuess = GameRules.genererMotAleatoire();

            //.Show("Le mot :" + this.wordToGuess);


            // Le label contenant les mauvaises lettres est mis à vide.
            lMauvaisesLettres.Text = "";

            // Affichage du mot trouvé dans le label.
            lCrypedWord.Text = GameRules.crypterMot(this.wordToGuess);
        }


    #region Gestion des évènements.

            #region Gestion du chargement du formulaire.
        
            /// <summary>
            /// Méthode appelée lorsque le formulaire est chargé.
            /// Si le multijoueur local est activé.
            ///     Alors, le nom du joueur est affiché.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void GameForm_Load(object sender, EventArgs e)
            {
                if (this.isLocalMultiplayer){
                    lJoueur.Visible = true;
                    lJoueur.Text = joueurActif.Pseudo;
                    lJoueur.BackColor = joueurActif.Couleur;
                }

                if (this.isDistantMultiplayer)
                {
                    bRetour.Enabled = false;
                    bRetour.Visible = false;
                    bReset.Enabled = false;
                    bReset.Visible = false;
                }
            }
            #endregion

            #region Gestion d'une touche du clavier appuyée.
            /// <summary>
            /// Methode appelé lors de l'appui d'un touche du clavier, lorsque le focus est sur le forulaire
            /// </summary>
            private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
            {
                KeyPressed(e.KeyChar);
            }



            /// <summary>
            /// Gestion du jeu.
            /// </summary>
            /// <param name="letter"></param>
            private void KeyPressed(char letter)
                {
                    if (!String.IsNullOrEmpty(this.wordToGuess)) // Si le mot n'est pas null ou vide :
                    {
                        letter = char.ToUpper(letter);
                
                        if( GameRules.isLetter( letter )){ // Si la lettre est comprise entre A & Z : 
                    
                            if( this.wordToGuess.Contains( letter )){ // Si la lettre est dans le mot : 
                                                                      
                                lCrypedWord.Text = GameRules.decrypterMot(this.wordToGuess, lCrypedWord.Text, letter); // On affiche la lettre dans le label.

                            }else{ // Si la lettre n'est pas dans le mot :

                                if( !lMauvaisesLettres.Text.Contains( letter ) ) { // Si la lettre n'a pas déjà été essayée :

                                    lMauvaisesLettres.Text = GameRules.mauvaisesLettres( lMauvaisesLettres.Text, letter); // On ajoute la lettre dans le label.
                                    
                                    if(this.isLocalMultiplayer){ // Si le jeu est en local.

                                        _HangmanViewer.MoveNextStep(); // On dessine l'étape suivante sur le pendu.

                                        multiLocalChangeTurn(); // Le tour du joueur change.
                                    }else{
                                        _HangmanViewer.MoveNextStep(); // On dessine l'étape suivante sur le pendu.
                                    }

                                }else{ // Si la lettre a déjà été essayée.

                                    MessageBox.Show("La lettre " + letter + " a déjà était essayée.");    

                                }
                            }
                            
                            if (GameRules.motComplet(lCrypedWord.Text)) { //  Si le mot est complété.
                                if(this.isLocalMultiplayer) multitLocalEnd();
                                else MessageBox.Show("Bravo !\nVous avez trouvé le mot : " + this.wordToGuess);
                                StartNewGame();
                            }
                            if (_HangmanViewer.IsGameOver) { // Si le pendu est dessiné :
                                MessageBox.Show("Perdu ! Le mot était : " + wordToGuess + "\n");
                                StartNewGame(); // Démarrage d'une nouvelle partie.
                            }


                        }else{ // Si la lettre n'est pas entre A & Z :
                            MessageBox.Show("Veuillez choisir une lettre de l'alphabet.");
                        }
                    }

                }        
            #endregion

        


        

        
        





            #region Gestion du bouton Reset.

            /// <summary>
            /// Methode appelé lors de l'appui d'un touche du clavier, lorsque le focus est sur le bouton "Nouvelle partie"
            /// </summary>
            private void bReset_KeyPress(object sender, KeyPressEventArgs e)
            {
                KeyPressed(e.KeyChar);
            }

            /// <summary>
            /// Methode appelée lors du survol du bouton "Nouvelle partie".
            /// - Change le curseur de la souris en "Main".
            /// Elle change la couleur du bouton en orange.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void bReset_MouseHover(object sender, EventArgs e)
                {
                    Cursor.Current = Cursors.Hand;
                    bReset.BackColor = Color.Orange;
                }

            /// <summary>
            /// Methode appelée lorsque la souris quitte le bouton "Nouvelle partie".
            /// - Change le curseur de la souris en flèche.
            /// Elle change la couleur du bouton en jaune.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void bReset_MouseLeave(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Default;
                bReset.BackColor = Color.Yellow;
            }

            /// <summary>
            /// Methode appelé lors de l'appui sur le bouton "Nouvelle partie"
            /// ELle démarre une nouvelle partie.
            /// </summary>
            private void bReset_Click(object sender, EventArgs e)
            {
                StartNewGame();
            }

            #endregion
        
            #region Gestion du bouton Retour.
        
            /// <summary>
            /// Méthode appelée lors du clic sur le bouton retour.
            /// Elle raffiche le formulaire parent et ferme le formulaire actuel.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void bRetour_Click(object sender, EventArgs e)
            {
                //Afficher le formulaire parent
                parent.Show();
                this.Close();

            }

            /// <summary>
            /// Methode appelée lors du survol du bouton "Retour".
            /// - Change le curseur de la souris en "Main"
            /// Elle change la couleur du bouton en rouge.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void bRetour_MouseHover(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Hand;
                bRetour.BackColor = Color.Red;
            }

            /// <summary>
            /// Méthode appelée lorsque la souris n'est plus sur le bouton "Retour".
            /// - Change le curseur de la souris en "Default"
            /// Elle change la couleur en vert clair.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void bRetour_MouseLeave(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Default;
                bRetour.BackColor = Color.LightGreen;
            }
            #endregion

            #region Gestion du bouton de sortie.

            /// <summary>
            /// Méthode appelée lors du survol de la sortie.
            /// Change l'aspect du curseur.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void pBoxLeave_MouseHover(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Hand;
            }

            /// <summary>
            /// Méthode appelée lorsque la souris n'est plus sur la sortie.
            /// Change l'aspect du curseur par défaut.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void pBoxLeave_MouseLeave(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.Default;
            }

            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
            {

            }

            private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
            {

            }

            /// <summary>
            /// Méthode appelée au clic sur l'image de sortie.
            /// Quitte le programme.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void pBoxLeave_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }

            #endregion

    #endregion
    }

}
