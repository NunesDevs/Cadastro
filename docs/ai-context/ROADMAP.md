# Roadmap

## Prioridade 1
- Corrigir bugs críticos.
- Revisar segurança.
- Remover textos provisórios.
- Garantir build.

## Prioridade 2
- Melhorar UX/UI.
- Criar testes.
- Preparar deploy.

## Prioridade 3
- Escalar arquitetura.
- Automatizar CI/CD.

<!-- AUTO-GENERATED:START -->
## Roadmap automático
- Resolver pendências críticas.
- Revisar segurança.
- Garantir build funcional.
- Melhorar documentação.
- Preparar deploy seguro quando autorizado.

## Links
- [[Cadastro]]
- [[Roadmap Geral]]
- [[Codex]]
- [[Claude Code]]
<!-- AUTO-GENERATED:END -->
<!-- JARVIS-AUTO:START -->
## Próximos passos
- Corrigir pendências críticas.
- Revisar segurança.
- Garantir lint/test/build quando disponíveis.
- Melhorar README e documentação.
- Preparar deploy somente quando autorizado.
<!-- JARVIS-AUTO:END -->

## Plano Codex por etapas - 2026-05-17

1. Critico concluido: estabilizar execução local e entradas do console.
   - Migrar target para `net8.0`.
   - Substituir `int.Parse` e leituras nulas por validações com mensagens.
   - Validar IDs e opções de enum antes de acessar o repositório.
   - Garantir `dotnet format`, `dotnet build` e `dotnet test`.
2. Próxima etapa crítica: testes e proteção do domínio.
   - Criar projeto de testes.
   - Cobrir `cadastroRepo` e validações principais do menu.
   - Adicionar proteções de faixa dentro do repositório.
3. Higiene de repositório.
   - Ignorar `bin/` e `obj/`.
   - Planejar remoção de artefatos gerados já versionados, com autorização.
4. Qualidade de código.
   - Renomear classes e métodos para convenções C#.
   - Separar I/O de console da regra de negócio.
5. Preparação futura.
   - Documentar execução, build e eventuais variáveis.
   - Avaliar persistência real se o projeto deixar de ser apenas demonstrativo.
