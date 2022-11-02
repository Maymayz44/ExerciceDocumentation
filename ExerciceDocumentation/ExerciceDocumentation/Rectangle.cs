namespace ExerciceDocumentation
{
    public class Rectangle
    {
        private int longeur;
        private int hauteur;


        public event EventHandler<int> AireCalculee;

        public Rectangle(int longeur, int hauteur)
        {
            this.longeur = longeur;
            this.hauteur = hauteur;
        }

        public int CalculerAire()
        {
            int aire = longeur * hauteur;
            AireCalculee?.Invoke(this, aire);
            return aire;
        }
    }
}