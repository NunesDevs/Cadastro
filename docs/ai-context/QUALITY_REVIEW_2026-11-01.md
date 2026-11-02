# Revisão de qualidade — 2026-11-01

Aplicação de console com inclusão, consulta, atualização e exclusão lógica em memória.

## Escopo

Leitura de fontes, documentação, configurações e scripts do projeto, excluindo dependências, metadados Git e saídas geradas. Sem alteração visual; mudanças de interface gráfica exigem Figma.

## Correções e decisões

- Validação no domínio para nome, idade e valores de enumeração.
- Repositório utiliza IDs lógicos e preserva a identidade na atualização.
- Lista devolve uma cópia da coleção; alterações na lista recebida não apagam o armazenamento.
- IDs excluídos não são reutilizados nem reativados por atualização.
- Menu tolera opções inválidas, nomes completos e fim da entrada.

## Como validar

SDK .NET 10 para compilar e testar. Runtime .NET 10 para execução via `dotnet`; o pacote Windows é autossuficiente.

```powershell
./build.ps1 -Test -Package
dotnet run --project Cadastro.csproj
./artifacts/publish/Cadastro.exe
```

Testes sem dependências externas em `tests/RegressionTests.csproj` verificam IDs não sequenciais, duplicidade, validação, cópia e exclusão.

## Limites reais

Armazenamento apenas em memória. A exclusão mantém o registro marcado no histórico da listagem, mas não permite consultá-lo ou atualizá-lo como ativo. Reiniciar encerra a sessão e descarta os dados.

Confira `PROJECT_MEMORY.md` para continuidade. Os resultados executados estão registrados abaixo.

## Resultado executado

Build .NET 10, regressões de domínio e publish win-x64 autossuficiente aprovados. Pacote executado com inclusão/consulta de dados fictícios e encerramento por EOF.

Publicação em produção não foi realizada. Pacotes foram preparados e a publicação da branch será registrada na auditoria local; integração e distribuição são coordenadas separadamente.
