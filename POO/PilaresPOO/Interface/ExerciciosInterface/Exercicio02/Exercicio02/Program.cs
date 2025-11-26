using Exercicio02;

List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opcoes
    1) Cadastrar Fatura
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatorios
    6) Listar Contratos
    0) Sair

    Escolha a opcao:    
    ");

    opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    CadastrarFaturas();
       break;
    case 2:
    Console.WriteLine($"Cadastrar Relatorio em desenvolvimento");
       break;
    case 3:
    Console.WriteLine($"Cadastrar Contrato em desenvolvimento");
       break;
    case 4:
    Console.WriteLine($"Cadastrar Faturas em desenvolvimento");
       break;  
    case 5:
    Console.WriteLine($"Cadastrar Relatorios em desenvolvimento");
       break;   
    case 6:
    Console.WriteLine($"Cadastrar Contratos em desenvolvimento");
       break;
    case 0:
    Console.WriteLine($"sair");
       break;
    default:

    Console.WriteLine($"Opcao invalida");
        break;
}

  Console.WriteLine($"Pressione <enter> para continuar");
  Console.ReadLine();
  
    
} while (opcao != 0);




void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    string dev = Console.ReadLine();
    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();
    Console.WriteLine($"Digite o nome do Cliente Devedor");
    float valor = float.Parse(Console.ReadLine());
    Console.WriteLine($"Dias de atraso da fatura?");
    int qtdDiasAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdDiasAtraso);
    documentos.Add(fat);
    
    Console.WriteLine($"Fatura cadastrada com sucesso");

}
void CadastrarRelatorios()
{
    
}

void CadastrarContratos()
{
    
}

void ListarContratos()
{
    
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
    
}

void ListarRelatorios()
{
    
}

		
	


























































// List<Relatorio> listaRelatorios = new List<Relatorio>();
// List<Contrato> listaContratos = new List<Contrato>();

// Fatura fatMapa = new Fatura();
// listaFaturas.Add(fatMapa);


// Relatorio reltMapa = new Relatorio();
// listaRelatorios.Add(reltMapa);

// Contrato contMapa = new Contrato


// ();
// listaContratos.Add(contMapa);


// foreach (var fatura in listaFaturas)
// {
//     fatura.Imprimir();
// }
