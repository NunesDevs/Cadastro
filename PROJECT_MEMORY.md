# Memória do projeto

Revisão: 2026-11-01. Ler este arquivo e `docs/ai-context/QUALITY_REVIEW_2026-11-01.md` antes de retomar alterações.

## Objetivo e estado

Aplicação de console com inclusão, consulta, atualização e exclusão lógica em memória.

Mudanças funcionais desta revisão:
- Validação no domínio para nome, idade e valores de enumeração.
- Repositório utiliza IDs lógicos e preserva a identidade na atualização.
- Lista devolve uma cópia da coleção; alterações na lista recebida não apagam o armazenamento.
- IDs excluídos não são reutilizados nem reativados por atualização.
- Menu tolera opções inválidas, nomes completos e fim da entrada.

## Decisões

- Preservar o propósito didático e o histórico anterior do Git.
- Manter esta revisão na branch `codex/quality-refresh` até integração coordenada.
- Preservar arquivos locais e avisos de terceiros; não versionar resultados de build, credenciais ou dados reais.
- Artefatos de console são distribuíveis locais. Um build ou pacote não comprova publicação em produção.
- .NET 10 LTS foi escolhido porque .NET 3.1 e 6 estavam sem suporte e .NET 8 encerra suporte em 2026-11-10. Referência: https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core .

## Validação reproduzível

SDK .NET 10 para compilar e testar. Runtime .NET 10 para execução via `dotnet`; o pacote Windows é autossuficiente.

```powershell
./build.ps1 -Test -Package
dotnet run --project Cadastro.csproj
./artifacts/publish/Cadastro.exe
```

Testes sem dependências externas em `tests/RegressionTests.csproj` verificam IDs não sequenciais, duplicidade, validação, cópia e exclusão.

## Limitações para continuidade

Armazenamento apenas em memória. A exclusão mantém o registro marcado no histórico da listagem, mas não permite consultá-lo ou atualizá-lo como ativo. Reiniciar encerra a sessão e descarta os dados.

Os documentos automáticos de maio em `docs/ai-context` são um registro histórico, incluindo falsos positivos por palavras como “secret”. Esta memória e a revisão de qualidade descrevem o estado posterior às correções.

IDs são reservados sob lock; podem existir lacunas após cancelar um cadastro. Não reutilizar IDs excluídos ou presumir que ID seja a posição em uma lista.

Pacotes Release omitem símbolos de depuração e mapeiam caminhos de origem em `Directory.Build.props`, para não distribuir caminhos locais. Para depurar, use a configuração Debug.

## Evidência da revisão

Build .NET 10, regressões de domínio e publish win-x64 autossuficiente aprovados. Pacote executado com inclusão/consulta de dados fictícios e encerramento por EOF.
