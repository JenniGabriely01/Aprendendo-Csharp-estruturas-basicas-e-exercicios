namespace Aula09
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Operadores lógicos");

            bool isLogged = false;
            bool hasAdminAcess = false;

            Console.WriteLine("Usuário logado: " + isLogged);
            Console.WriteLine("Usuário tem acesso de administrador: " + hasAdminAcess);

            // Operador lógico OR (||), qualque uma das condições satisfaz a condição de estar logado
            if (isLogged || hasAdminAcess)
            {
                Console.WriteLine("Acesso concedido");
            } else
            {
                Console.WriteLine("Acesso negado");
            }

             // Operador lógico AND (&&)
                if (isLogged && hasAdminAcess)
            {
                Console.WriteLine("Acesso ao painel de adm concedido");
            } else
            {
                Console.WriteLine("Acesso ao painel de adm negado");
            }

            // Operador lógico NOT (!)
            if (!isLogged)
            {
                Console.WriteLine("Uuário não está logado");
            }


        }
    }
}
