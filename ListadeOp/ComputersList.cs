using System;
using System.Collections.Generic;
using System.Text;

namespace ListadeOp
{
    public class ComputersList
    {
        public ComputersNode Head; // Head será pc1 que va a ir de forma continua hasta pc2, pc3 etc
        public ComputersNode objComputerNode;

        public void Add(Computers Computertoadd, int insert, int after) //Computertoadd almacena la info escrita en Program
        {
            ComputersNode newComputersNode = new ComputersNode();//instancia de StudentNode, o herendando todos los atributos
            newComputersNode.Computer = Computertoadd; //insercion de Student
            if (insert < after)
            {
                if (Computertoadd.Barcode == insert || Computertoadd.Barcode == after) //si ese es igual a inert O es igual a after
                {
                    if (Computertoadd.Barcode == insert)
                    {
                        objComputerNode = newComputersNode; //la variable que se tiene arriba va a contener al nodo, se captura
                    }

                    else
                    {
                        if (Head == null)  //Lista vacia, nodo padre Head 
                        {
                            Head = newComputersNode;    //significa que se ha creado el primer nodo pero no tiene next 
                            ComputersNode Last = Head;
                            Last = Last.Next;
                            Last.Next = objComputerNode;

                        }

                        else
                        {
                            ComputersNode Last = Head;  //last va a contener un next y studentNode
                            while (Last.Next != null) // si es diferentede null inserta un nuevo nodo

                            {
                                Last = Last.Next;  //va pasando el next y si no es null pasa y pasa
                            }
                            Last.Next = newComputersNode; //inserta el sgte nodo 
                            Last = Last.Next;
                            Last.Next = objComputerNode;

                        }
                    }
                }
                else
                {
                    if (Head == null)
                    {
                        Head = newComputersNode;
                    }
                    else
                    {
                        ComputersNode Last = Head;
                        while (Last.Next != null)
                        {
                            Last = Last.Next;
                        }
                        Last.Next = newComputersNode;
                    }
                }
            }
            else
            {
                if (Computertoadd.Barcode == insert)
                {
                    ComputersNode Last = Head;

                    for (int i = 1002654894; i < after; i++)
                    {
                        
                        Last = Last.Next;
                        

                    }
                    ComputersNode Next = Last.Next;
                    Last.Next = newComputersNode;
                    Last.Next.Next = Next;
                }
                else
                {
                    if (Head == null)
                    {
                        Head = newComputersNode;
                    }
                    else
                    {
                        ComputersNode Last = Head;
                        while (Last.Next != null)
                        {
                            Last = Last.Next;
                        }
                        Last.Next = newComputersNode;

                    }
                }
            }
        }

        public void Print()
        {
            ComputersNode tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"Name of the machine: {tmp.Computer.Mark} - Ram of the machine: {tmp.Computer.Ram} - Barcode of the machine: {tmp.Computer.Barcode} - Processor of the machine: {tmp.Computer.Processor}");
                tmp = tmp.Next;
            }
        }
    }
}