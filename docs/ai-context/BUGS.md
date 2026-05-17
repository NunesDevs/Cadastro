# Bugs e pendências

- CLAUDE.md → teste
- docs\ai-context\BUGS.md → TODO
- docs\ai-context\PROJECT.md → TODO
- docs\ai-context\PROMPTS.md → TODO
- docs\ai-context\ROADMAP.md → teste

<!-- AUTO-GENERATED:START -->
## Achados automáticos
- `CLAUDE.md` contém texto provisório ou pendência: **teste**
<!-- AUTO-GENERATED:END -->
<!-- JARVIS-AUTO:START -->
## Pendências automáticas
- `CLAUDE.md` contém pendência textual: teste
<!-- JARVIS-AUTO:END -->

## Auditoria Codex - 2026-05-17

### Corrigido na etapa 1 critica
- Aplicação podia encerrar com exceção em opções inválidas do menu.
- `Console.ReadLine()` podia retornar nulo e causar falhas em `ToUpper()`/`int.Parse`.
- Campos numéricos aceitavam somente entradas perfeitas; texto, vazio ou idade negativa derrubavam o fluxo.
- Gênero e cargo aceitavam números fora dos enums.
- Visualizar, atualizar e excluir com ID inexistente causavam acesso fora da lista.
- Projeto mirava `net6.0`; nesta máquina o runtime instalado é .NET 8, então o app compilava mas não executava.

### Pendências
- Criar testes automatizados para menu, validação de entrada e repositório.
- Padronizar nomes públicos para PascalCase (`cadastroRepo`, `retornoNome`, `retornarId`, `retornaExcluido`).
- Decidir se funcionários excluídos devem aparecer em listagem e visualização.
- Proteger o repositório contra acesso inválido também no nível da classe, não só no menu.
- Remover ou desrastrear artefatos gerados (`bin/`, `obj/`) do versionamento em uma etapa própria.
