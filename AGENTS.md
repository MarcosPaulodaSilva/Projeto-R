# AGENTS — Projeto R

## Ordem obrigatória

1. Leia `PROJECT_STATUS.md`.
2. Leia `unity/VadroniaDemo/PROJECT_STATE.md`.
3. Edite somente a partir de uma branch criada da `main` atual.
4. Se a tarefa mexer em sistemas/design, leia `unity/docs/MASTER_PROMPT.md`.
5. Se mexer em cânone/lore, leia `docs/lore/LORE_BIBLE.txt`.

## Regras que não podem ser quebradas

- Projeto ativo: Unity 6.6 / 6000.6.0f1, C#, 2D top-down ortogonal, Built-in pipeline.
- Projeto do Editor: `unity/VadroniaDemo`.
- Preserve `.meta`, GUIDs, saves, cenas e assets aprovados.
- Não recrie sistemas já existentes sem antes inspecionar o código.
- Não crie fontes duplicadas de verdade: atualize os documentos canônicos.
- Não afirmar “testado”, “compilado” ou “integrado” sem verificação real.
- Não gerar executável/pacote Windows sem pedido explícito de Marcos.
- Se o estado do jogo mudar, atualize `PROJECT_STATUS.md` e `unity/VadroniaDemo/PROJECT_STATE.md`.

## Handoff

PRs devem informar: objetivo, arquivos alterados, testes executados, o que não foi validado, riscos e próximo passo.
