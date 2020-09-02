using Marija_Bozic_Dan_59.Helper;
using Marija_Bozic_Dan_59.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Marija_Bozic_Dan_59.ViewModels
{
    public class MainWindowViewModel:ViewModelBase
    {
        List<Picture> pictureFilds = new List<Picture>();
        Random rnd = new Random();
        MainWindow main;
        public int counter =0;
        System.Timers.Timer timer = new System.Timers.Timer();
        Stopwatch watchTime = new Stopwatch();
        Thread t;

        public MainWindowViewModel(MainWindow main)
        {
            this.main = main;
            filde_00 = new Picture();
            filde_01 = new Picture();
            filde_02 = new Picture();
            filde_03 = new Picture();
            filde_10 = new Picture();
            filde_11 = new Picture();
            filde_12 = new Picture();
            filde_13 = new Picture();
            filde_20 = new Picture();
            filde_21 = new Picture();
            filde_22 = new Picture();
            filde_23 = new Picture();
            filde_30 = new Picture();
            filde_31 = new Picture();
            filde_32 = new Picture();
            filde_33 = new Picture();        
            pictureFilds.Add(filde_00);
            pictureFilds.Add(filde_01);
            pictureFilds.Add(filde_02);
            pictureFilds.Add(filde_03);
            pictureFilds.Add(filde_10);
            pictureFilds.Add(filde_20);
            pictureFilds.Add(filde_30);
            pictureFilds.Add(filde_11);
            pictureFilds.Add(filde_12);
            pictureFilds.Add(filde_13);
            pictureFilds.Add(filde_21);
            pictureFilds.Add(filde_22);
            pictureFilds.Add(filde_23);
            pictureFilds.Add(filde_31);
            pictureFilds.Add(filde_32);
            pictureFilds.Add(filde_33);

            CardInitialization();

            
            timer.Interval = 60000;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Elapsed += OnTimedEvent;
            timer.Start();
            watchTime.Start();
        }
        #region Property

        private Picture filde_00;
        public Picture Filde_00
        {
            get
            {
                return filde_00;
            }
            set
            {
                filde_00 = value;
                OnPropertyChanged("Filde_00");
            }
        }
        private Picture filde_01;
        public Picture Filde_01
        {
            get
            {
                return filde_01;
            }
            set
            {
                filde_01 = value;
                OnPropertyChanged("Filde_01");
            }
        }
        private Picture filde_10;
        public Picture Filde_10
        {
            get
            {
                return filde_10;
            }
            set
            {
                filde_10 = value;
                OnPropertyChanged("Filde_10");
            }
        }

        private Picture filde_20;
        public Picture Filde_20
        {
            get
            {
                return filde_20;
            }
            set
            {
                filde_20 = value;
                OnPropertyChanged("Filde_20");
            }
        }
        private Picture filde_30;
        public Picture Filde_30
        {
            get
            {
                return filde_30;
            }
            set
            {
                filde_30 = value;
                OnPropertyChanged("Filde_30");
            }
        }
        private Picture filde_02;
        public Picture Filde_02
        {
            get
            {
                return filde_02;
            }
            set
            {
                filde_02 = value;
                OnPropertyChanged("Filde_02");
            }
        }
        private Picture filde_03;
        public Picture Filde_03
        {
            get
            {
                return filde_03;
            }
            set
            {
                filde_03 = value;
                OnPropertyChanged("Filde_03");
            }
        }

        private Picture filde_11;
        public Picture Filde_11
        {
            get
            {
                return filde_11;
            }
            set
            {
                filde_11 = value;
                OnPropertyChanged("Filde_11");
            }
        }

        private Picture filde_12 ;
        public Picture Filde_12
        {
            get
            {
                return filde_12;
            }
            set
            {
                filde_12 = value;
                OnPropertyChanged("Filde_12");
            }
        }

        private Picture filde_13;
        public Picture Filde_13
        {
            get
            {
                return filde_13;
            }
            set
            {
                filde_13 = value;
                OnPropertyChanged("Filde_13");
            }
        }

        private Picture filde_21;
        public Picture Filde_21
        {
            get
            {
                return filde_21;
            }
            set
            {
                filde_21 = value;
                OnPropertyChanged("Filde_21");
            }
        }

        private Picture filde_22;
        public Picture Filde_22
        {
            get
            {
                return filde_22;
            }
            set
            {
                filde_22 = value;
                OnPropertyChanged("Filde_22");
            }
        }

        private Picture filde_23;
        public Picture Filde_23
        {
            get
            {
                return filde_23;
            }
            set
            {
                filde_23 = value;
                OnPropertyChanged("Filde_23");
            }
        }

        private Picture filde_31;
        public Picture Filde_31
        {
            get
            {
                return filde_31;
            }
            set
            {
                filde_31 = value;
                OnPropertyChanged("Filde_31");
            }
        }

        private Picture filde_32;
        public Picture Filde_32
        {
            get
            {
                return filde_32;
            }
            set
            {
                filde_32 = value;
                OnPropertyChanged("Filde_32");
            }
        }

        private Picture filde_33;
        public Picture Filde_33
        {
            get
            {
                return filde_33;
            }
            set
            {
                filde_33 = value;
                OnPropertyChanged("Filde_33");
            }
        }
        #endregion

        #region Methods

        public void CheckFields()
        {
            while (true)
            {                
                if (counter == 2)
                {
                    List<Picture> selectedPictures = new List<Picture>();
                    selectedPictures = pictureFilds.Where(x => x.isShown && !x.isMatch).ToList();
                    if (selectedPictures.Count != 2)
                    {
                        continue;
                    }
                    if (selectedPictures[0].Name == selectedPictures[1].Name)
                    {
                        selectedPictures[0].IsMatch = true;
                        selectedPictures[1].IsMatch = true;
                       // counter = 0;
                    }                 
                    CheckIsEndOfGame();
                }
                Thread.Sleep(500);
            }
        }

        public void CheckIsEndOfGame()
        {
            if(pictureFilds.Where(p=>p.IsMatch).ToList().Count==16)
            {
                timer.Stop();
                watchTime.Stop();
                MessageBox.Show("You win game!");
                LoggedInfo.LoggAction(watchTime.ElapsedMilliseconds/1000);
            }
        }

        public void CloseAll()
        {           
            if(counter==2)
            {
                foreach (Picture item in pictureFilds)
                {
                    if(item.IsShown && !item.IsMatch)
                    {
                        item.IsShown = false;
                    }
                }
                counter = 0;
            }
        }

        public  void CardInitialization()
        {
            List<string> listLetters = new List<string>() { "X", "X", "Y", "Y", "Z", "A", "S", "O", "P", "W", "Z", "A", "S", "O", "P", "W" };

            for (int i = 0; i < pictureFilds.Count; i++)
            {
                string pictureName = listLetters[rnd.Next(0, listLetters.Count)];
                pictureFilds[i].Name = pictureName;
                pictureFilds[i].IsMatch = false;
                pictureFilds[i].IsShown = false;
                listLetters.Remove(pictureName);
            }

            t = new Thread(CheckFields);
            t.IsBackground = true;
            t.Start();
        }
        private  void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            watchTime.Stop();
            t.Abort();
            MessageBoxResult result = MessageBox.Show("Your time is UP! You lost game!", "Info", MessageBoxButton.OK);
            if (result == MessageBoxResult.OK)
            {
                CardInitialization();
                watchTime.Start();
            }
        }
    #endregion
    }
}
