# Projeto R Vadronia — regras para agentes

## Leitura obrigatória antes de editar

1. Leia `PROJECT_STATUS.md`.
2. Para Unity, leia `unity/VadroniaDemo/PROJECT_STATE.md`.
3. Consulte `docs/WORKFLOW_AGENTS.md` para branch, PR e handoff.
4. Só então abra a documentação específica da tarefa.

## Regras do projeto

- Não gerar executáveis nem pacotes de distribuição Windows sem novo pedido explícito de Marcos.
- Unity e HTML estão separados em `unity/` e `html/`. Os fontes Unity ficam em `unity/VadroniaDemo`; o HTML e seu histórico ficam em `html/`. Não misturar implementações nem suas numerações de versão.
- A implementação ativa é Unity 6.6, 2D top-down ortogonal com personagens de corpo visível; não isométrico, não plataforma e não HTML.
- O Super Master específico da Unity está em `unity/docs/prompts/super-master-prompt-projeto-r-unity.md`. O Super Master HTML permanece em `html/docs/prompts/`.
- O estado atual verificado deve ser lido em `PROJECT_STATUS.md` e `unity/VadroniaDemo/PROJECT_STATE.md`; documentos históricos não substituem esses arquivos.
- Projeto aberto pelo usuário: `C:/Users/Marcos/Downloads/VadroniaDemo`. Alterações que dependam do Editor devem ser validadas na cópia real quando o ambiente tiver acesso a ela; não declarar validação local sem ter executado.
- Repositório: `MarcosPaulodaSilva/Projeto-R`. O projeto vizinho `../Projeto R` aponta a outro remoto e possui alterações próprias; não misturar os projetos.
- Preserve arquivos `.meta`, GUIDs e o trabalho existente. Antes de substituir Assets, mantenha backup local fora do versionamento.
- Não declarar conteúdo recuperado, importado, compilado ou testado sem verificação.
- As imagens originais foram transferidas no commit `bbfb8b51ddcf5f344aed6175f63dc125eab8ca19` e aplicadas na demo local.

## Coordenação entre ChatGPT/Codex

- `main` é a fonte canônica integrada.
- Crie uma branch nova a partir da `main` para cada tarefa.
- Não continue uma branch `codex/*` antiga sem comparar com `main`.
- Evite dois agentes editando o mesmo arquivo central em paralelo.
- Ao concluir uma tarefa que altera o estado do projeto, atualize `PROJECT_STATUS.md` no mesmo PR.
- Use PRs como handoff: objetivo, alterações, validação, pendências e próximo passo.
