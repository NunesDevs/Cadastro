# Revisão do workspace — 01/11/2026

Leitura de `Cadastro.csproj`, `Program.cs`, entidades, contrato e repositório confirmou aplicação de console .NET 8 com dados exclusivamente em memória e exclusão lógica. O README foi alinhado ao código e `.gitignore` recebeu `bin/` e `obj/`, sem apagar os artefatos anteriormente versionados.

Validação: inspeção estática; `dotnet --info` encontrou runtime 8.0.14 e nenhum SDK. Build e execução do código-fonte pendentes de SDK .NET 8. Não há suíte automatizada. Nenhuma mudança de regra de negócio ou publicação.
