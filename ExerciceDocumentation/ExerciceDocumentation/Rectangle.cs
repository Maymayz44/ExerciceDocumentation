namespace ExerciceDocumentation
{
    public class Rectangle
    {
        private int longeur;
        private int hauteur;


        public event EventHandler<int> AireCalculee;

        /// <summary>
        /// Crée l'objet et définit ses paramètres
        /// </summary>
        /// <param name="longeur">La longeur du rectangle</param>
        /// <param name="hauteur">La hauteur du rectangle</param>
        public Rectangle(int longeur, int hauteur)
        {
            this.longeur = longeur;
            this.hauteur = hauteur;
        }

        /// <summary>
        /// Calcule l'aire du rectangle
        /// </summary>
        /// <returns>L'aire du rectangle</returns>
        public int CalculerAire()
        {
            int aire = longeur * hauteur;
            AireCalculee?.Invoke(this, aire);
            return aire;
        }
    }
}