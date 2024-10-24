namespace FunctionUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Pen lijnkleur = Pens.Black;
            Brush vulKleur = Brushes.Red;

            //voorbeeld:

            g.DrawRectangle(lijnkleur, 0, 0, 50, 50);

            // 1) gebruik nu de FillRectangle function
            //dit maak een vierkant  op 60,60 van 30 bij 30
            g.FillRectangle (vulKleur, 60, 60, 30, 30);

            // 2) maak nu zelf nog een vierkant, kies zelf waar en hoe groot
            g.DrawRectangle(lijnkleur, 0, 0, 50, 50);


            //we gaan nu een driehoek maken:

            g.DrawLine(lijnkleur, 150, 50, 100, 0);
            g.DrawLine(lijnkleur, 100, 0, 50, 50);
            g.DrawLine(lijnkleur, 50, 50, 150, 50);
            //3) maak de driehoek af door nog een lijn tekenen

            //4) zoek nu zelf uit hoe je een circle tekent 
            g.DrawEllipse(lijnkleur, 200, 200, 50, 50);
            g.FillEllipse(vulKleur, 200, 200, 50, 50); 


        }
    }
}
