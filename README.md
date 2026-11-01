# Cadastro de funcionários

Aplicação de console em C# para praticar cadastro, consulta, atualização e exclusão lógica de funcionários. Os dados ficam em uma `List<CadastroProj>` na memória do processo: encerrar o programa descarta os registros.

## Funcionalidades

- Listar e consultar funcionários por identificador.
- Cadastrar nome, idade, gênero e cargo.
- Atualizar o cadastro e marcar um funcionário como excluído.
- Validar campos obrigatórios, números inteiros, opções dos enums e identificadores existentes na interface de console.

A listagem mantém registros excluídos com a indicação `*Excluído*`. Não há banco de dados, autenticação, API ou interface web.

## Requisitos e execução

O arquivo `Cadastro.csproj` usa **.NET 8** (`net8.0`). Instale o SDK .NET 8; apenas o runtime não permite compilar o código.

Na pasta do projeto:

```powershell
dotnet --list-sdks
dotnet restore Cadastro.csproj
dotnet build Cadastro.csproj --configuration Release
dotnet run --project Cadastro.csproj
```

Escolha `1` a `5` para as operações do menu, `C` para limpar a tela e `X` para sair. Use dados fictícios durante os exercícios.

## Organização

- `Program.cs`: interação no terminal e validação das entradas.
- `Classes/CadastroProj.cs`: entidade de funcionário e exclusão lógica.
- `Classes/cadastroRepo.cs`: armazenamento em memória e operações do repositório.
- `Interfaces/IRepositorio.cs`: contrato do repositório.
- `Enum/`: cargos e gêneros aceitos.
- `docs/ai-context/`: contexto histórico de manutenção; registros antigos não substituem a inspeção do código atual.

## Verificação e limites

Não há projeto de testes automatizados neste repositório. Para um smoke test manual, cadastre um registro fictício, consulte o ID, atualize-o, marque-o como excluído e confira a listagem. Confira também idade inválida, nome vazio e ID inexistente.

Na auditoria de 01/11/2026 foi encontrado o runtime .NET 8, mas nenhum SDK; o build do código-fonte não foi executado nesse ambiente. Artefatos históricos em `bin/` e `obj/` já estavam rastreados e foram preservados. Essas pastas passam a ser ignoradas para novos arquivos; sua retirada do histórico exige uma mudança separada.

O programa é um exercício local. Não deve armazenar informações reais de funcionários: faltam persistência, controle de acesso, auditoria e política de retenção. Não há deploy configurado nem licença identificada na raiz.
