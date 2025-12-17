//Tuplas são um conjunto sequenciais de dados, podendo haver nomes para essa sequencias ou não
var pt = (X: 1, Y: 2);
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"Em uma reta de ponto {pt} tem uma inclinação de {slope}");
//Modificando uma tupla
pt.X += 5;
Console.WriteLine($"O ponto foi modificado! Agora o X é igual a {pt.X}");
var pt2 = pt with { Y = 10 };
Console.WriteLine($"Foi criado uma nova tupla: {pt2}");
//Os nomes dos componentes da tuplas são meras conveniências, mas ulteis pois ajudam a pesquisar pequenas células e deixa-las únicas
var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);
//novos tipos de tuplas
var namedData = (Name: "Moring observation", Temp: 17, Wind: 4);
var person = (FirstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UniPrince: 0.10m);
Console.WriteLine($"namedData: {namedData}, person: {person}, order: {order}");

//Tipos de registro

Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"Os dois pontos são {pt3} e {pt4}");
public record Point(int X, int Y);