using C_Fundamentos2.Models;
using System.Globalization;
using System.Linq.Expressions;
using Newtonsoft.Json;

// Programação Orientada á Objetos (POO) //

























// DateTime dataVenda = DateTime.Now;

// List<Produtos> listaProdutos = new List<Produtos>();

// Produtos p1 = new Produtos
// (1, "Iphone 16 Pro Max", 7912M, dataVenda);
// Produtos p2 = new Produtos
// (2, "Iphone 15 Pro Max", 4500M, dataVenda);
// Produtos p3 = new Produtos
// (3, "Iphone 14 Pro Max", 3900M, dataVenda);

// listaProdutos.Add(p1);
// listaProdutos.Add(p2);
// listaProdutos.Add(p3);

// Console.WriteLine(p1);
// Console.WriteLine(p2);
// Console.WriteLine(p3);





















// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2= new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);










// int numero = 10;
// bool ehPar = false;


// // if ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));












// Pessoa p1 = new Pessoa("Pedro", "Oliveira");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do arquivo" + quantidadeLinhas);
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
//     {   
//         Console.WriteLine("Não foi possível ler o arquivo");
//     }



















// (int, string, string) tupla = (1, "Pedro", "Oliveira");

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");




















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("ES", "Espírito Santo");
// estados.Add("SP", "São Paulo");
// estados.Add("MG","Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("SP");
// estados["MG"] = "Minas Gerais - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "SP";
// Console.WriteLine("Verificando o elemento");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }









// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }








// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }




















// try 
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura-txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }

// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Pasta não encontrada. {ex.Message}");
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }









// string dataString = "2022-04-170 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }
















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");

// double porcentagem = .93472;

// Console.WriteLine(porcentagem.ToString("P"));







// string numero1 ="10";
// string numero2 ="20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);












// Pessoa p1 = new Pessoa(nome:"Pedro",sobrenome: "Oliveira");
// Pessoa p2 = new Pessoa(nome:"Brenda", sobrenome:"Oliveira");

// Curso cursoDeMedicina = new Curso();
// cursoDeMedicina.Nome = "Medicina";
// cursoDeMedicina.Alunos = new List<Pessoa>();

// cursoDeMedicina.AdicionarAluno(p1);
// cursoDeMedicina.AdicionarAluno(p2);
// cursoDeMedicina.ListarAlunos();

// Pessoa p1 = new Pessoa();
// p1.Nome = "Pedro";
// p1.Idade = 22;
// p1.Estado = "ES";
// p1.estadoCivil = "Casado";
// p1.Apresentar();