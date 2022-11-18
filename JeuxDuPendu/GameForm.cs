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
        private bool multijoueurLocal = false;
        private bool multijoueurDistant = false;
        
        private string randomWord;
            
       
        /// <summary>
        /// Constructeur du formulaire de jeux
        /// </summary>
        public GameForm(Form parent)
        {
            InitializeComponent();
            InitializeMyComponent();
            StartNewGame();

            this.parent = parent;
        }

        #region Partie Multijoueur Local.
        
        private Player joueur1 = null;
        private Player joueur2 = null;
        private Player joueurActif;
        public GameForm(Pseudo parent, bool multijoueurLocal, string pseudo1, string pseudo2)
        {
            {
                InitializeComponent();
                InitializeMyComponent();
                StartNewGame();
                this.parent = parent;

                if(multijoueurLocal == true)
                {
                    this.multijoueurLocal = multijoueurLocal;
                    this.joueur1 = new Player(pseudo1, 0, Color.LightBlue);
                    this.joueur2 = new Player(pseudo2, 0, Color.IndianRed);
                    
                    joueurActif = joueur1; // Le joueur actif est le joueur 1.

                    lJoueur.Text = joueurActif.Pseudo;
                    lJoueur.BackColor = joueurActif.Couleur;
                }
                
                
            }
        }
        #endregion

        #region Parti Multijoueur distant
        /*
        // Déclaration d'un thread.
        private System.Threading.Thread networkThread;
        private string ip, port;

        /// <summary>
        /// Constructeur Multijoueur (Serveur)
        /// </summary>
        /// <param name="multijoueur"></param>
        /// <param name="isServer"></param>
        /// <param name="parent"></param>
        public GameForm(bool multijoueur, bool isServer, Form parent)
        {
            InitializeComponent();
            InitializeMyComponent();
            this.parent = parent;

            MessageBox.Show("Multijoueur lancé : " + multijoueur);
            
            this.multijoueurDistant = multijoueur;

            if (isServer)
            {
                bRetour.Enabled = false;
                
                // Création d'un thread pour le serveur.
                networkThread = new System.Threading.Thread(new System.Threading.ThreadStart(StartServer));
                networkThread.Start();
            }
            
        }

        /*
        public GameForm(bool multijoueur, bool isServer, Form parent, string ip, string port, string pseudo)
        {
            InitializeComponent();
            InitializeMyComponent();
            this.parent = parent;

            MessageBox.Show("Multijoueur lancé : " + multijoueur);

            this.multijoueurDistant = multijoueur;

            if (isServer)
            {
                bRetour.Enabled = false;

                // Création d'un thread pour le serveur.
                networkThread = new System.Threading.Thread(new System.Threading.ThreadStart(StartServer));
                networkThread.Start();
            }
            else
            {
                motForm = new Mot(this);
                new System.Threading.Thread(new System.Threading.ThreadStart(runClient)).Start();
            }
        }
        



        public void StartServer()
        {

            // Créer un serveur avec la classe TcpListener
            TcpListener server = new TcpListener(IPAddress.Parse("172.21.230.170"), 1234);
            server.Start();

            for(; ; )
            {

                if (server.Pending())
                {
                    // Attendre une connexion
                    TcpClient client = server.AcceptTcpClient();

                    // Créer un flux de données pour la communication

                    NetworkStream stream = client.GetStream();

                    byte[] bytes = new byte[client.ReceiveBufferSize];
                    stream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                    String dataReceived = Encoding.ASCII.GetString(bytes);
                    this.randomWord = dataReceived;
                    Console.WriteLine("mamacita\n");
                    while (String.IsNullOrEmpty(this.randomWord))
                    {
                        Console.WriteLine("Pas de mot.\n");
                    }
                    Console.WriteLine("Mot reçu : " + this.randomWord + "\n");
                    StartNewGame();
                    // Je devine le mot

                    Mot motForm = new Mot(this);
                    motForm.Show();
                   

                    while (!motForm.getWordReady()); // Attend une réponse.
                    
                    string mot = motForm.getMot();

                    byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(mot);
                    stream.Write(bytesToSend, 0, bytesToSend.Length);
                    client.Close();
                }

            }
        }

        public void runClient()
        {
            

            MessageBox.Show("Le client rentre.");
            
            
            motForm.Show();

            MessageBox.Show("Le mot doit être tapé.");
            
            while (!motForm.getWordReady()) ; // Attend une réponse.
            
            string textToSend = motForm.getMot();
            
            TcpClient client = new TcpClient("172.21.230.170", 1234);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            
            // Il attend que le serveur lui réponde (finisse sa partie).
            
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Le nouveau mot à dechiffrado  : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead)+"\n");
            string txtReceived = Encoding.ASCII.GetString(bytesToRead, 0, bytesRead);
            
            this.randomWord = txtReceived;
            StartNewGame();
            
            Console.WriteLine("Mamacita\n");

            client.Close();
        }
        */
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


            // Récupération d'un mot aléatoire dans l'attribut randomWord
            if (multijoueurDistant == false) this.randomWord = GameRules.genererMotAleatoire();

            //.Show("Le mot :" + this.randomWord);


            // Le label contenant les mauvaises lettres est mis à vide.
            lMauvaisesLettres.Text = "";

            // Affichage du mot trouvé dans le label.
            lCrypedWord.Text = GameRules.crypterMot(this.randomWord);
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
                if (this.multijoueurLocal == true) this.lJoueur.Visible = true;
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
            private void KeyPressed(char letter)
            {
                if (String.IsNullOrEmpty(this.randomWord) == false)
                {
                        letter = char.ToUpper(letter);
                        //MessageBox.Show("Mot : " + this.randomWord + "\nLettre tapée : " + letter);

                        // Si la lettre est comprise entre A et Z
                        if (GameRules.isLetter(letter))
                        {
                            // Si la lettre est dans le randomWord
                            if (this.randomWord.Contains(letter))
                            {
                                // On affiche la lettre dans le label
                                lCrypedWord.Text = GameRules.decrypterMot(this.randomWord, lCrypedWord.Text, letter);
                            }
                            else
                            {
                                if (lMauvaisesLettres.Text.Contains(letter) == false)
                                {
                                    lMauvaisesLettres.Text = GameRules.mauvaisesLettres(lMauvaisesLettres.Text, letter); // On ajoute la lettre dans le label des mauvaises lettres

                                    if (this.multijoueurLocal == true) // Si le jeu est en multijoueurLocal.
                                    {
                                        // On avance le pendu d'une etape
                                        _HangmanViewer.MoveNextStep();

                                        // On change le joueur actif.
                                        if (joueurActif == joueur1)
                                        {
                                            joueurActif = joueur2;
                                        }
                                        else
                                        {
                                            joueurActif = joueur1;
                                        }

                                        lJoueur.Text = joueurActif.Pseudo;
                                        lJoueur.BackColor = joueurActif.Couleur;

                                    }
                                    else
                                    {
                                        // On passe à l'étape suivante.
                                        _HangmanViewer.MoveNextStep();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("La lettre " + letter + " a déjà été essayée");
                                }

                            }

                            if (GameRules.motComplet(lCrypedWord.Text)) // Si le mot est complété.
                            {

                                if (this.multijoueurLocal == true)
                                {
                                    if (joueurActif.Pseudo == joueur1.Pseudo) joueur1.Score++; // Si le joueur actif est le joueur 1, on augmente son score.
                                    else joueur2.Score++; // Sinon on augmente le score du joueur 2.
                                    MessageBox.Show("Bravo " + joueurActif.Pseudo +
                                                    " vous avez trouvé le mot : " +
                                                    this.randomWord +
                                                    "\nLes scores sont : \n" +
                                                    joueur1.Pseudo + " : " + joueur1.Score + "\n" +
                                                    joueur2.Pseudo + " : " + joueur2.Score + "\n");

                                    Player.enregistrerScore(joueur1, joueur2);
                                }
                                else
                                {
                                    MessageBox.Show("Bravo vous avez trouvé le mot :" + this.randomWord + "\n"); // On affiche un message de victoire.
                                }
                                StartNewGame();
                            }

                            // Si le pendu est complet, le joueur à perdu.
                            if (_HangmanViewer.IsGameOver)
                            {
                                if (this.multijoueurLocal == true)
                                {
                                    MessageBox.Show("Le joueur " + joueurActif.Pseudo + " a perdu.\nLe mot était : " + this.randomWord + "\n");
                                }
                                else
                                {
                                    MessageBox.Show("Perdu ! Le mot était : " + randomWord + "\n");
                                }
                                StartNewGame();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La lettre doit être dans l'alphabet.");
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
