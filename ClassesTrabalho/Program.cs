/* 
 * Trabalho POOI
 * Lucas de Freitas Oliveira 
 * Felipe Las Casas
*/

using ClassesTrabalho;

var menu = new Menu(new Dictionary<string, Action>
{
    {"Soma",  Soma.ExercicioSoma},
});

menu.SelecionarEExecutar();