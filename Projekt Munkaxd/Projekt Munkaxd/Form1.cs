using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Munkaxd
{
    public partial class Form1 : Form
    {
        private float _ticks;
        private int _ticks2;
        public Form1()
        {
            InitializeComponent();
        }

        
        //**************************************GOMBOK***************************************//


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            
            Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\White.jpg");
            this.BackgroundImage = myimage;
            MessageBox.Show("Noah:\nAhh...mi történhetett?");
            MessageBox.Show("És hol vagyok?");
            MessageBox.Show("*Kiáltva* Halló...Valaki van itt?");
            MessageBox.Show("Na mindegy lássuk mire is emlékszem mielőtt ide kerültem volna...");
            button4.Visible = true;

        }
            private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üdvözöllek a játék leírásában!\n\nEz a játék egy kaland,sci-fi keverék, szóval lesznek benne bizarr dolgok ne ijedj meg!\n\n Amit a játék kínál a játékosnak:\n -10 arany kezdésnek\n -1 darab fáklya \n -Ruhadarabok(szövetruha,régi kopott kapucnis kabát)\n -Egy térkép darab");
            MessageBox.Show("Történet(Dióhéjban): A főszereplőt Noah Walker-t elrabolják miközben lerobban az autója egy sikátoros utca mellett.\n\nInnen a történet választás opcionális, ahogy a játékos(Te) választ azon törénet szerint fog a játék folyni.\nVálasztási lehetőségek: \n-Időutazás\n-Ufo elrablás\n\nIdőutazás:\nTörténet lényege, hogy a sikátorban lévő ember elrabolt és berakott egy időgépbe majd visszarepültél az időben, pontosabban 1545-be. Egyetlen módja annak, hogy haza tudj jutni az az, hogy meg kell találnod egy nagyon ritka ásványt és összezúznod és közben gondolnod kell arra az időpontra, ahova vissza akarsz jutni. Az ásvány megtalálásához át kell küzdened magad különböző akadályokon. Ha ezeket leküzdötted akkor tudsz értelem szerűen közelebb kerülni a célhoz.A játék során elrejtett a fejlesztő(Daweed) egy Easter Egg-et(Húsvéti tojást) aminek a megtalálásával több időt nyerhetsz, hogy véghez vidd a célod.\n\nKitesznek a Szaharába. A cél itt az, hogy juss el Egyiptomig és mássz fel a piramis tetejére, ahol megleled a visszautat, ahonnan elraboltak téged. Persze itt a fejlesztő(Daweed) a pályán elrejtett pár Easter Egget, amit előszeretettel lehet megtalálni(ha megtudod).");
            
            button1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
            button3.Visible = false;
            Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig.jpg");
            this.BackgroundImage = myimage;
            MessageBox.Show("Noah:\nDe sajnos meg kellett állnom mert lerobbant az autóm.");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\EjszakaiUt.jpg");
            this.BackgroundImage = myimage;
            timer1.Start();
            MessageBox.Show("Noah:\nElőször is munkából tartottam hazafelé");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Szabi.jpg");
            this.BackgroundImage = myimage;
            button5.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
        }




        //**************************************************************TIMER*********************************************************************//



        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            button3.Visible = true;
            if (_ticks == 1.0) {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\0.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 1.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\1.jpg");
                this.BackgroundImage = myimage;

            }
            if (_ticks == 2.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\2.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 2.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\3.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 3.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\4.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 3.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\5.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 4.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\6.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 4.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\7.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 5.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\8.jpg");
                this.BackgroundImage = myimage;

            }
            if (_ticks == 5.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\9.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 6.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\10.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 6.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\11.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 7.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\12.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 7.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\13.jpg");
                this.BackgroundImage = myimage;

            }
            if (_ticks == 8.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\14.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 8.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\15.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 9.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\16.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 9.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\17.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks ==10.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\18.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 10.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\19.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 11.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\20.jpg");
                this.BackgroundImage = myimage;
            }

            if (_ticks == 11.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\21.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 12.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\22.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 12.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\23.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 13.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\24.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 13.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\25.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 14.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\26.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 14.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\27.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 15.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\28.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 15.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\29.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 16.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\30.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 16.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\31.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 17.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\32.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 17.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\33.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 18.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\34.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 18.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\35.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 19.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\36.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 19.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\37.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 20.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\38.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 20.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\39.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 21.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\40.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 21.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\41.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 22.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\42.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 22.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\43.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 23.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\44.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 23.5)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\45.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks == 24.0)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\Ut\46.jpg");
                this.BackgroundImage = myimage;
                timer1.Stop();

            }
          

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks2++;
            if (_ticks2 == 3)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig2.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks2 == 4) {
                MessageBox.Show("Meghallottam egy zajt a sikátorból.\nBekiáltottam egyet a sötét helyre 'VAN OTT VALAKI?', majd beljebb merészkedtem, mert azt gondoltam talán tudna nekem segíteni.");
            }
            if (_ticks2 == 8) {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig3.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks2 == 9)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig4.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks2 == 10)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig5.jpg");
                this.BackgroundImage = myimage;
            }
            if (_ticks2 == 11)
            {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\cig6.jpg");
                this.BackgroundImage = myimage;
                MessageBox.Show("Noah:\nLáttam egy embert a földön és ez az utolso emlékem mielőtt minden elsötétült.");
            }
            if (_ticks2 == 14) {
                Image myimage = new Bitmap(@"C:\C#\Projekt\ProjektKépek\black.png");
                this.BackgroundImage = myimage;
                timer2.Stop();
                button5.Visible = true;
            }
        }

        
    }
}