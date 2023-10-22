

using Componentes;
using MenuGlobal;

class prog
{
    static void Main(string[] args)
    {
        Menu.Opcoes();
        Ferramentas ferramentas = new Ferramentas();
        ferramentas.DentroEFora();
    }
}