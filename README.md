# Cadastro de funcionários em C#

Aplicação de console com inclusão, consulta, atualização e exclusão lógica em memória.

## Comportamento

- Validação no domínio para nome, idade e valores de enumeração.
- Repositório utiliza IDs lógicos e preserva a identidade na atualização.
- Lista devolve uma cópia da coleção; alterações na lista recebida não apagam o armazenamento.
- IDs excluídos não são reutilizados nem reativados por atualização.
- Menu tolera opções inválidas, nomes completos e fim da entrada.

## Executar e validar

SDK .NET 10 para compilar e testar. Runtime .NET 10 para execução via `dotnet`; o pacote Windows é autossuficiente.

```powershell
./build.ps1 -Test -Package
dotnet run --project Cadastro.csproj
./artifacts/publish/Cadastro.exe
```

Testes sem dependências externas em `tests/RegressionTests.csproj` verificam IDs não sequenciais, duplicidade, validação, cópia e exclusão.

## Limites

Armazenamento apenas em memória. A exclusão mantém o registro marcado no histórico da listagem, mas não permite consultá-lo ou atualizá-lo como ativo. Reiniciar encerra a sessão e descarta os dados.

## Manutenção e licença

Código autoral licenciado sob a [MIT](LICENSE). Dependências, ferramentas e materiais de terceiros mantêm suas próprias licenças e avisos.

Decisões e continuidade: [PROJECT_MEMORY.md](PROJECT_MEMORY.md).
