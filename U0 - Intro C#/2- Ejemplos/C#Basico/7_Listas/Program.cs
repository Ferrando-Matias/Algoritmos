using _07_Listas;
using System.Collections.Generic;
/*
 * Las listas en C# son objetos tipados. Es decir, cuando creamos una lista
 * le debemos indicar qué tipo de objetos va contener
 * (al igual que las variables:string, int, double, etc o tipo T)
 * Cuando hablamos de tipo «T», nos referimos a cualquier tipo de objetos 
 * que hayamos definido en nuestro código, como por ejemplo puedo crear una lista de 
 * objetos de una clase
 */

List<string> Nombres; //creo una lista de tipo string
Nombres = new List<string>(); // instancio la lista creada anteriormente

List<int> Edades = new List<int>(); //creo e instancio la lista en un solo paso


//DIVERSAS MANERAS DE AGREGAR DATOS A LA LISTA
Nombres.Add("Juan");
Nombres.Add("Pedro");
Nombres.Add("Mariela");
Nombres.Add("Jose");
Nombres.Add("Juana");

Edades.Add(5);
Edades.Add(6);
Edades.Add(20);

/* Inserto un nombre en una posición determina
 * para ello debo indicar el indice de la lista
 * donde necesito intercalarlo
 */
Nombres.Insert(0, "Veronica");

//ELIMINAR ELEMENTOS DE LA LISTA
Nombres.Remove("Pedro"); //puedo remover por el dato que contiene la lista
Nombres.RemoveAt(0);    //o puedo remover por el indice
                        // Si indico eliminar un valor que no existe C# no indicara ningun error
Nombres.Remove("PEPE");
// Si indico eliminar un indice que no existe C# SI indicara un error
//Nombres.RemoveAt(30);

/*  RemoveAll() es el más complejo de los métodos remove,
 *  pero definitivamente también el más poderoso.
 *  Toma un delegado a un método como parámetro y este método decide
 *  si un elemento debe eliminarse o no devolviendo verdadero o falso.
 *  Esto le permite aplicar su propia lógica al eliminar elementos 
 *  y también le permite eliminar más de un elemento a la vez. 
 *  Los delegados no serán tratados en este momento, 
 *  debido a que es un tema complejo en esta instancia de la cursada, 
 *  pero es importante que entiendan lo conveniente que es el método
 *  RemoveAll, así que aquí hay un ejemplo:
 */

List<string> ListadDeNombres = new List<string>()
{
    "Jorge",
    "Juan",
    "Javier",
    "Marcelo"
};

ListadDeNombres.RemoveAll(name =>
{
    if (name.StartsWith("J"))
        return true;
    else
        return false;
});
//El ejemplo anterior borra todos los nombres que comienzan con la letra  J


//ORDENAR LOS ELEMENTOS DE UNA LISTA
Nombres.Sort(); //ordeno de menor a mayor, o de A a Z
Nombres.Reverse();//invierte el orden de la lista

//CONTAR LOS ELEMENTOS DE UNA LISTA
int cantElementos = Nombres.Count();

//SUMAR LOS ELEMENTOS DE UNA LISTA
int sumaElementos = Edades.Sum();

//PROMEDIAR LOS ELEMENTOS DE UNA LISTA
double promedioElementos = Edades.Average();

//MINIMO LOS ELEMENTOS DE UNA LISTA
double minElementos = Edades.Min();

//MAXIMO LOS ELEMENTOS DE UNA LISTA
double maxElementos = Edades.Max();

//OBTENER EL PRIMER Y EL ULTIMO ELEMENTO DE UNA LISTA
string primero = Nombres.First();
string ultimo = Nombres.Last();

//VACIAR TODA LA LISTA (ELIMINA TODOS LOS ELEMENTOS)
Edades.Clear();

//RECORRER UNA LISTA

//Con ciclo for
Console.WriteLine("Lista recorrida con ciclo for");
Console.WriteLine("_____________________________");
int i;
for (i = 0; i < Nombres.Count; i++)
{
    Console.WriteLine("Elemento {0} = {1}", i, Nombres[i]);
}

Console.WriteLine();
i = 0;
//Con ciclo Foreach
Console.WriteLine("Lista recorrida con ciclo Foreach");
Console.WriteLine("_________________________________");

foreach (var v in Nombres)
{
    Console.WriteLine("Elemento {0} = {1}", i, v);
    i++;
}

i = 0;
Console.WriteLine();


//LISTAS DE OBJETOS Y\O CLASES
Console.WriteLine("Lista TIPO t (OBJETOS)");
Console.WriteLine("____________________________________");

List<Usuarios> ListaDeUsuarios = new List<Usuarios>()
{
    new Usuarios() { Nombre = "Juan Perez", Edad = 6 },
    new Usuarios() { Nombre = "Marcela Santos", Edad = 34 },
    new Usuarios() { Nombre = "Jose Bermudez", Edad = 8 },
};

Console.WriteLine("---------------------------------");




//LinkedList

Console.WriteLine("LinkedList");
// Crear una LinkedList de enteros
LinkedList<int> numeros = new LinkedList<int>();

// Agregar elementos a la LinkedList
numeros.AddLast(10); // Agrega al final
numeros.AddLast(20);
numeros.AddLast(30);

// Agregar un elemento al principio
numeros.AddFirst(5); // Agrega al principio

// Mostrar los elementos de la LinkedList
Console.WriteLine("Elementos de la LinkedList:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Salida: 5, 10, 20, 30
}

// Eliminar un elemento
numeros.Remove(20); // Elimina el número 20

// Mostrar los elementos después de la eliminación
Console.WriteLine("Elementos después de eliminar el numero 20:");
foreach (int numero in numeros)
{
    Console.WriteLine(numero); // Salida: 5, 10, 30
}

// Comprobar si un elemento existe
bool existe = numeros.Contains(10);
Console.WriteLine($"¿Contiene el número 10? {existe}"); // Salida: true

// Obtener el primer y último elemento
int primerElemento = numeros.First.Value; // Primer elemento
int ultimoElemento = numeros.Last.Value; // Último elemento

Console.WriteLine($"Primer elemento: {primerElemento}"); // Salida: 5
Console.WriteLine($"Último elemento: {ultimoElemento}"); // Salida: 30

// Limpiar la LinkedList
numeros.Clear();
Console.WriteLine($"Número de elementos después de Clear: {numeros.Count}"); // Salida: 0

Console.WriteLine("---------------------------------");






Console.WriteLine("Queue");
// Listas Queue
// Las listas tipo cola son las listas F.I.F.O. (First In First Out, primero en entrar primero en salir). 
Queue<int> numerosQ = new Queue<int>();

// Agregar elementos a la Queue
numerosQ.Enqueue(10); // Agrega al final
numerosQ.Enqueue(20);
numerosQ.Enqueue(30);

// Mostrar los elementos de la Queue
Console.WriteLine("Elementos en la Queue:");
foreach (int numero in numerosQ)
{
    Console.WriteLine(numero); // Salida: 10, 20, 30
}

// Obtener y eliminar el primer elemento
primerElemento = numerosQ.Dequeue(); // Elimina y retorna el primer elemento
Console.WriteLine($"Elemento eliminado: {primerElemento}"); // Salida: 10

// Mostrar los elementos después de eliminar
Console.WriteLine("Elementos después de eliminar el primer elemento:");
foreach (int numero in numerosQ)
{
    Console.WriteLine(numero); // Salida: 20, 30
}

// Ver el primer elemento sin eliminarlo
int siguienteElemento = numerosQ.Peek(); // Retorna el siguiente elemento sin eliminar
Console.WriteLine($"Siguiente elemento (sin eliminar): {siguienteElemento}"); // Salida: 20

// Comprobar si un elemento existe
existe = numerosQ.Contains(30);
Console.WriteLine($"¿Contiene el número 30? {existe}"); // Salida: true

// Limpiar la Queue
numerosQ.Clear();
Console.WriteLine($"Número de elementos después de Clear: {numerosQ.Count}"); // Salida: 0

Console.WriteLine("---------------------------------");








Console.WriteLine("Stack");

// Crear un Stack de enteros
// Las listas tipo pila son las listas L.I.F.O. (Last In First Out, ultimo en entrar primero en salir). 
Stack<int> numerosS = new Stack<int>();

// Agregar elementos al Stack
numerosS.Push(10); // Agrega al final
numerosS.Push(20);
numerosS.Push(30);

// Mostrar los elementos del Stack
Console.WriteLine("Elementos en el Stack:");
foreach (int numero in numerosS)
{
    Console.WriteLine(numero); // Salida: 30, 20, 10 (LIFO)
}

// Obtener y eliminar el elemento en el final
int elementoSuperior = numerosS.Pop(); // Elimina y retorna el elemento en el tope
Console.WriteLine($"Elemento eliminado: {elementoSuperior}"); // Salida: 30

// Mostrar los elementos después de eliminar
Console.WriteLine("Elementos después de eliminar el elemento en el tope:");
foreach (int numero in numerosS)
{
    Console.WriteLine(numero); // Salida: 20, 10
}

// Ver el elemento en el tope sin eliminarlo
siguienteElemento = numerosS.Peek(); // Retorna el siguiente elemento sin eliminar
Console.WriteLine($"Siguiente elemento (sin eliminar): {siguienteElemento}"); // Salida: 20

// Comprobar si un elemento existe
existe = numerosS.Contains(10);
Console.WriteLine($"¿Contiene el número 10? {existe}"); // Salida: true

// Limpiar el Stack
numerosS.Clear();
Console.WriteLine($"Número de elementos después de Clear: {numeros.Count}"); // Salida: 0