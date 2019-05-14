using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pokemon_catch_rate_calculator.Model;

namespace Pokemon_catch_rate_calculator
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public float crInit;
        public float crSleep;
        public float cr1HP;
        public float cr1HPSleep;

        public List<Pokemon> PokemonList { get; set; }

        Pokemon _pokemonClass;
        public Pokemon PokemonClass
        {
            get
            {
                return _pokemonClass;
            }
            set
            {
                if(_pokemonClass != value)
                {
                    _pokemonClass = value;
                    RaisePropertyChanged("PokemonClass");
                }
            }
        }

        int _pkmnBaseHealth;
        public int PkmnBaseHealth
        {
            get
            {
                return _pkmnBaseHealth;
            }
            set
            {
                if(_pkmnBaseHealth != value)
                {
                    _pkmnBaseHealth = value;
                    RaisePropertyChanged("PkmnBaseHealth");
                }
            }
        }

        int _pkmnCatchRate;
        public int PkmnCatchRate
        {
            get
            {
                return _pkmnCatchRate;
            }
            set
            {
                if(_pkmnCatchRate != value)
                {
                    _pkmnCatchRate = value;
                    RaisePropertyChanged("PkmnCatchRate");
                }
            }
        }



        int _pkmnLevel;
        public int PkmnLevel
        {
            get
            {
                return _pkmnLevel;
            }
            set
            {
                if(_pkmnLevel != value)
                {
                    _pkmnLevel = value;
                    RaisePropertyChanged("PkmnLevel");
                }
            }
        }



        public List<Ball> BallList { get; set; }

        Ball _ballClass;
        public Ball BallClass
        {
            get
            {
                return _ballClass;
            }
            set
            {
                if (_ballClass != value)
                {
                    _ballClass = value;
                    RaisePropertyChanged("BallClass");
                }
            }
        }

        double _ballCatchBonus;
        public double BallCatchBonus
        {
            get
            {
                return _ballCatchBonus;
            }
            set
            {
                if (_ballCatchBonus != value)
                {
                    _ballCatchBonus = value;
                    RaisePropertyChanged("BallCatchBonus");
                }
            }
        }
        


        public MainWindow()
        {
            InitializeComponent();

            PokemonList = new List<Pokemon>
            {
                new Pokemon {pkmnName = "Bulbasaur", baseHealth = 45, catchRate = 45},
                new Pokemon {pkmnName = "Ivysaur", baseHealth = 60, catchRate = 45},
                new Pokemon {pkmnName = "Venasaur", baseHealth = 80, catchRate = 45},
                new Pokemon {pkmnName = "Charmander", baseHealth = 39, catchRate = 45},
                new Pokemon {pkmnName = "Charmeleon", baseHealth = 58, catchRate = 45},
                new Pokemon {pkmnName = "Charizard", baseHealth = 78, catchRate = 45},
                new Pokemon {pkmnName = "Squirtle", baseHealth = 44, catchRate = 45},
                new Pokemon {pkmnName = "Wartortle", baseHealth = 59, catchRate = 45},
                new Pokemon {pkmnName = "Blastoise", baseHealth = 79, catchRate = 45},
            };


            BallList = new List<Ball>
            {
                new Ball {ballName = "Pokeball", catchBonus = 1},
                new Ball {ballName = "Great Ball", catchBonus = 1.5},
                new Ball {ballName = "Ultra Ball", catchBonus = 2},
                new Ball {ballName = "Master Ball", catchBonus = 255},
                new Ball {ballName = "Safari Ball", catchBonus = 1.5},
                new Ball {ballName = "Level Ball", catchBonus = 8},
            };

            DataContext = this;
        }


        public void catchCalc(Pokemon chosenPkmn, int level, Ball chosenBall)
        {
            int IV = 15;
            int pkmnHealth = ((((2 * chosenPkmn.baseHealth) + IV) * level) / 100) + level + 10;

            

            switch (chosenBall.ballName)
            {
                case ("Level Ball"):
                    {
                        PkmnDock.Visibility = Visibility.Visible;
                        int OwnLevel = (int)OwnPkmnLevelSlider.Value;


                        if(OwnLevel >= (level * 4))
                        {
                            chosenBall.catchBonus = 8;
                            break;
                        }
                        else if (OwnLevel < (level * 4) && OwnLevel >= (level * 2))
                        {
                            chosenBall.catchBonus = 4;
                            break;
                        }
                        else if (OwnLevel < (level * 2) && OwnLevel > level)
                        {
                            chosenBall.catchBonus = 2;
                            break;
                        }
                        else
                        {
                            chosenBall.catchBonus = 1;
                            break;
                        }
                    }
            }


            

            crInit = (float)((pkmnHealth * chosenPkmn.catchRate * chosenBall.catchBonus) / (3 * pkmnHealth));
            crSleep = (float)((pkmnHealth * chosenPkmn.catchRate * chosenBall.catchBonus) / (3 * pkmnHealth)) * 2.5f;
            cr1HP = (float)((((3 * pkmnHealth) - 2) * chosenPkmn.catchRate * chosenBall.catchBonus) / (3 * pkmnHealth));
            cr1HPSleep = (float)((((3 * pkmnHealth) - 2) * chosenPkmn.catchRate * chosenBall.catchBonus) / (3 * pkmnHealth)) * 2.5f;


            if (crInit > 255)
                crInit = 255;

            if (crSleep > 255)
                crSleep = 255;

            if (cr1HP > 255)
                cr1HP = 255;

            if (cr1HPSleep > 255)
                cr1HPSleep = 255;
        }

        public float rateToPercent(float catchRate)
        {
            return (catchRate / 255f) * 100f;
        }

        private void recalcButton(object sender, MouseButtonEventArgs e)
        {
            recalc();
        }

        private void recalc()
        {
            int Level = (int)PkmnLevelSlider.Value;
            
            if (PkmnSelectCombo.SelectedItem == null || BallSelectCombo.SelectedItem == null)
                return;
            
            catchCalc((Pokemon)PkmnSelectCombo.SelectedItem, Level, (Ball)BallSelectCombo.SelectedItem);

            
            CatchRateInitial.Text = rateToPercent(crInit).ToString("0.00") + "%";
            CatchRateSleep.Text = rateToPercent(crSleep).ToString("0.00") + "%";
            CatchRate1HP.Text = rateToPercent(cr1HP).ToString("0.00") + "%";
            CatchRate1HPSleep.Text = rateToPercent(cr1HPSleep).ToString("0.00") + "%";
        }


        void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); recalc(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
