namespace Clases
{
    public class Persona
    {
        public string nombre;
        public int edad;

        public override string ToString()
        {
            return "["+nombre+"|"+edad+"]";
        }

        public static bool operator==(Persona p1, Persona p2)
        {
            if (p1.nombre == p2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            if (p1.nombre != p2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Persona p1, Persona p2)
        {
            //-1 0 1
            if (p1.nombre.CompareTo(p2.nombre)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Persona p1, Persona p2)
        {
            //-1 0 1
            if (p1.nombre.CompareTo(p2.nombre) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}