﻿using System;
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

        public GameForm(bool multijoueur, bool isServer, Form parent)
        {
            InitializeComponent();
            InitializeMyComponent();
            StartNewGame();
            this.parent = parent;
            this.multijoueurDistant = multijoueur;

        }

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
            this.randomWord = GameRules.genererMotAleatoire();

            // Le label contenant les mauvaises lettres est mis à vide.
            lMauvaisesLettres.Text = "";

            // Affichage du mot trouvé dans le label.
            lCrypedWord.Text = GameRules.crypterMot(this.randomWord);
        }


        /// <summary>
        /// Methode appelé lors de l'appui d'un touche du clavier, lorsque le focus est sur le bouton "Nouvelle partie"
        /// </summary>
        private void bReset_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e.KeyChar);
        }

        /// <summary>
        /// Methode appelé lors de l'appui d'un touche du clavier, lorsque le focus est sur le forulaire
        /// </summary>
        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e.KeyChar);
        }

        /// <summary>
        /// Methode appelé lors de l'appui sur le bouton "Nouvelle partie"
        /// </summary>
        private void bReset_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void KeyPressed(char letter)
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


        #region Trigger
        private void bRetour_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();

        }
        

        private void GameForm_Load(object sender, EventArgs e)
        {
            if (this.multijoueurLocal == true) this.lJoueur.Visible = true;
        }

        private void bReset_MouseHover(object sender, EventArgs e)
        {
            bReset.BackColor = Color.Orange;
        }

        private void bReset_MouseLeave(object sender, EventArgs e)
        {
            bReset.BackColor = Color.Yellow;
        }

        private void bRetour_MouseHover(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.Red;
        }

        private void bRetour_MouseLeave(object sender, EventArgs e)
        {
            bRetour.BackColor = Color.LightGreen;
        }

        #endregion

        private void pBoxLeave_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pBoxLeave_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pBoxLeave_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }

}