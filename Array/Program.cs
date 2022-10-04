int valoresX = int.Parse(Console.ReadLine());
int[] valor = new int[valoresX];

for (int i = 0; i < valor.Length; i++)
{
    valor[i] = int.Parse(Console.ReadLine());

    
}

OrderNarCrescente();

void OrderNarCrescente()
{
    for(int i = 0; i < valor.Length - 1; i++)
    {
        for(int j = i+1; j < valor.Length; j++)
        {
            if(valor[i] > valor[j])
            {
                int aux = valor[i];
                valor[i] = valor[j];
                valor[j] = aux;
            }
        }
    }
}

imprimir();

void imprimir()
{
    for(int l = 0; l < valoresX; l++)
    {
        Console.WriteLine("Posição: "+ l+ " valor " + valor[l] );
    }
}