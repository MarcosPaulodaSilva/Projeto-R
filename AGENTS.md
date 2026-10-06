# Projeto R Vadronia — regras para agentes

## Leitura obrigatória antes de editar

1. Leia `PROJECT_STATUS.md`.
2. Leia `unity/VadroniaDemo/PROJECT_STATE.md`.
3. Consulte `docs/WORKFLOW_AGENTS.md` para branch, PR e handoff.
4. Consulte o Super Master e a documentação específica da tarefa.

## Regras do projeto

- A única implementação ativa é **Unity 6.6 / 6000.6.0f1**, C#, 2D top-down ortogonal, personagens de corpo visível e pipeline Built-in.
- Os fontes Unity ficam em `unity/VadroniaDemo`.
- O Super Master canônico está em `unity/docs/prompts/super-master-prompt-projeto-r-unity.md`.
- A Bíblia de design/arquitetura está em `unity/docs/design/biblia-projeto-r-pre-producao-unity-pos-auditoria.txt`.
- Lore e história ficam em `docs/lore/`; referências visuais em `docs/references/`; música e vídeo em `assets/`.
- O estado verificado deve ser lido em `PROJECT_STATUS.md` e `unity/VadroniaDemo/PROJECT_STATE.md`. Documentos históricos não substituem esses arquivos.
- Projeto aberto pelo usuário: `C:/Users/Marcos/Downloads/VadroniaDemo`. Alterações que dependam do Editor devem ser validadas na cópia real quando o ambiente tiver acesso a ela.
- Repositório: `MarcosPaulodaSilva/Projeto-R`. O projeto vizinho `../Projeto R` aponta a outro remoto e possui alterações próprias; não misturar os projetos.
- Preserve arquivos `.meta`, GUIDs, saves e trabalho existente. Antes de substituir Assets, mantenha backup local fora do versionamento.
- Não declarar conteúdo recuperado, importado, compilado, executado ou testado sem verificação.
- Não gerar executáveis nem pacotes de distribuição Windows sem novo pedido explícito de Marcos.
- As imagens originais transferidas para a demo devem ser preservadas; não redesenhar silenciosamente uma fonte aprovada.

## Coordenação entre ChatGPT/Codex

- `main` é a fonte canônica integrada.
- Crie uma branch nova a partir da `main` para cada tarefa.
- Não continue uma branch antiga sem comparar com `main`.
- Evite dois agentes editando o mesmo arquivo central em paralelo.
- Ao concluir uma tarefa que altera o estado do projeto, atualize `PROJECT_STATUS.md` no mesmo PR.
- Use PRs como handoff: objetivo, alterações, validação, pendências e próximo passo.
