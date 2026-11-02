using Cadastro;
using System;
var repo = new cadastroRepo();
CadastroProj Ficha(int id, string nome="Teste") => new CadastroProj(id,Genero.Outros,nome,Cargo.TI,25);
void Check(bool condition) { if (!condition) throw new Exception("Falha de regressão"); }
void Reject(Action action) { try { action(); throw new Exception("Entrada inválida aceita"); } catch (ArgumentException) {} }
repo.Insere(Ficha(7)); Check(repo.ProximoId()==8);
repo.Atualiza(7,Ficha(7,"Atualizado")); Check(repo.RetornarPorId(7).retornoNome()=="Atualizado");
repo.Lista().Clear(); Check(repo.Lista().Count==1);
Reject(()=>repo.Insere(Ficha(7))); Reject(()=>repo.Atualiza(7,Ficha(8)));
Reject(()=>new CadastroProj(1,Genero.Outros," ",Cargo.TI,20));
Reject(()=>new CadastroProj(1,(Genero)999,"Nome",Cargo.TI,20));
Reject(()=>new CadastroProj(1,Genero.Outros,"Nome",Cargo.TI,-1));
repo.Exclui(7); Check(repo.RetornarPorId(7)==null); Check(repo.ProximoId()==9);
Console.WriteLine("Cadastro: identidade, validação, cópia e exclusão aprovadas.");
