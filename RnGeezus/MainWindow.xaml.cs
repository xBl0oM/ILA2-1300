using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RnGeezus
{
    
    public partial class MainWindow : Window
    {
        private int RandomNumber;
        private int i = 0;
        

        public MainWindow()
        {
           
            
            InitializeComponent();
            Dubstep.Source = new Uri(@"C:\Schule\BBB\2.Jahr\ila\1300\RnGeezus\RnGeezus\Dupstep.mp3");
            Dubstep.Play();
            ButtonWrong.Source = new Uri(@"C:\Schule\BBB\2.Jahr\ila\1300\RnGeezus\RnGeezus\[YT2mp3.info] - Wrong Buzzer - Sound Effect (32kbps).mp3");
            VictorySong.Source = new Uri(@"C:\Schule\BBB\2.Jahr\ila\1300\RnGeezus\RnGeezus\TheFatRat - Xenogenesis (Outro Song) (mp3cut.net) (1).mp3");
            Random rd = new Random();
            RandomNumber = rd.Next(1, 101);
            
        }

        public void userNumber_enter(object sender, KeyEventArgs e)
        {            
            
            
            if (e.Key == Key.Enter)
            {
                if(int.TryParse(userNumber.Text, out int userGuess)){
                    if (userGuess > 100 | userGuess < 0)
                    {
                        MessageBox.Show("Only guess numbers between 1-100");
                    }
                   else if (userGuess > RandomNumber)
                    { 
                        
                        MessageBox.Show("Your guess is to high");
                        i++;
                        userNumber.Clear();
                       
                    }
                    else if (userGuess < RandomNumber)
                    {
                                           
                        MessageBox.Show("Your guess is to low");
                        i++;
                        userNumber.Clear();
                        Dubstep.Play();
                    }
                    else
                    {
                        Dubstep.Stop();
                        VictorySong.Play();
                        i++;
                        MessageBox.Show("You're correct. And it only took you " + i + " guesses");
                        userNumber.Clear();
                        
                    }
                }

            }

        }

        
    }
}
